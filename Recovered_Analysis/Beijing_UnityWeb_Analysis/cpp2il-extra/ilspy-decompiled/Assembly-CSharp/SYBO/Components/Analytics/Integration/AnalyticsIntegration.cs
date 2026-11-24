using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using ABTest;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using Kiloo.Analytics;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Common;
using SYBO.Common.Visuals;
using SYBO.Components.Analytics.Albatross;
using SYBO.Components.Logging;
using SYBO.Components.Singletons;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Info;
using SYBO.Subway.UI;
using TopRun.Internal;
using UI.DoubleCoinsVideo;
using UI.Popups.ConsumablesPopupInternal;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using WeeklyHunt;
using WordHunt;

namespace SYBO.Components.Analytics.Integration;

public class AnalyticsIntegration : SingletonMonoBehaviour<AnalyticsIntegration>, IAnalyticsIntegrationTest, ICoroutineHandler
{
	public const string PlatformConfig = "ios";

	public const string PrefabPath = "Analytics/AnalyticsIntegration";

	public const int UnusedInt = -1;

	public static readonly string AnalyticsUserIdPersistedDefault;

	public static readonly string PreviousClientVersionPersistedDefault;

	public static readonly int GamesSinceFlushPersistedDefault;

	public static readonly int CurrentSessionPersistedDefault;

	public static readonly string OperatingSystemPersistedDefault;

	public static readonly string DeviceIDPersistedDefault;

	public static readonly string OSLanguagePersistedDefault;

	public static readonly DeviceInfo.PerformanceLevel PerformanceLevelPersistedDefault;

	public static readonly int GpuScorePersistedDefault;

	public static readonly string OnlineSettingsLocalePersistedDefault;

	public static readonly string UnhandledAbTestDataPersistedDefault;

	public static readonly SampleState SampleStateDefault;

	private const long ForegroundChangeThresholdMsTicks = 2000L;

	private const int MenuScreenHistoryCountTracked = 4;

	private const int MenuScreenHistoryCountReported = 3;

	private const float MaxFrameTimeSampleRangeMs = 2000f;

	private const int NoAbTestSegmentDefault = -1;

	private const string PrefsKeyPersistedLeavesForegroundTime = "LeavesForegroundTime";

	private static readonly string PrefsKeyPersistedLeavesForegroundTimeDefault;

	private const string PrefsKeyPersistedLeavesForegroundSessionDelta = "LeavesForegroundSessionDelta";

	private const int PrefsKeyPersistedLeavesForegroundSessionDeltaDefault = -1;

	private const int persistedSessionEventNumberDefault = -1;

	public const string OSKeyAnalyticsEnabled = "sybo_analytics_enabled";

	private const bool OSKeyAnalyticsEnabledDefault = false;

	public const string OSKeyAnalyticsFlushEnabled = "sybo_analytics_flush_enabled";

	private const bool OSKeyAnalyticsFlushEnabledDefault = true;

	public const string OSKeySamplingThreshold = "sybo_analytics_sampling_threshold";

	private const float OSKeySamplingThresholdDefault = 0f;

	public const string OSKeyEndpointBaseUrl = "sybo_analytics_endpoint_baseurl";

	private const string OSKeyEndpointBaseUrlDefault = null;

	public const string OSKeyMaxGamesWithoutFlush = "sybo_analytics_max_games_without_flush";

	private const int OSKeyMaxGamesWithoutFlushDefault = 10;

	public const string OSKeyGamesInSessionBeforeFirstFlush = "sybo_analytics_games_in_session_before_first_flush";

	private const int OSKeyGamesInSessionBeforeFirstFlushDefault = 1;

	public const string OSKeyOnlyValidatedPurchases = "sybo_analytics_only_validated_purchases";

	private const bool OSKeyOnlyValidatedPurchasesDefault = true;

	private AnalyticsSettings _settings;

	private float _samplingKey;

	private SampleState _sampleState;

	private bool _useDebugSettings;

	private bool _useDebugSettingsOnce;

	private AnalyticsSettings _debugSettings;

	private bool _usedDebugSettings;

	private SessionTracker _sessionTracker;

	private long _msTicksAtCurrentSessionStart;

	private AnalyticsManager _manager;

	private int _lastSession;

	private int _lastGameIdInSession;

	private bool _isRunInProgress;

	private bool _isReadyToPostGameEvents;

	private bool _hasUnflushedPurchaseEvent;

	private bool _waitingToInitialize;

	private bool _subscribedEventPostingHandlers;

	private bool _subscribedToFrontScreenEvent;

	private bool _subscribedToInAppManager;

	private static bool _jsonClassInfoCached;

	private string _menuScreenLast;

	private Queue<string> _menuScreenQueue;

	private IPerformanceTracker _performanceProvider;

	private long _cachedMissionSkipPurchaseId;

	private static Action<ISubwayBaseEvent> m_OnEventPosted;

	public unsafe AnalyticsSettings DebugSettings
	{
		get
		{
			//IL_008e: Expected I, but got Obj
			//IL_00a4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			ref string reference = ref *(string*)null;
			nint num = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AnalyticsHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v24 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (AnalyticsHelper.AndroidOsVersionByApiVersion.TryGetValue((string)(object)this, out reference))
			{
				return (AnalyticsSettings)(object)reference;
			}
			reference = ref *(string*)"0.0.0";
			return (AnalyticsSettings)(object)"0.0.0";
		}
	}

	public bool OnlyValidatedPurchases
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_debugSettings != 0;
		}
	}

	private bool IsSupportedOnDevice
	{
		get
		{
			AnalyticsSettings settings = _settings;
			return settings.OnlyValidatedPurchases;
		}
	}

	private bool IsPartOfSample
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_031b: Expected I, but got Obj
			//IL_0331: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_026a: Expected Obj, but got I
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Expected Obj, but got Unknown
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v117 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string bundleVersion = DeviceUtility.GetBundleVersion();
			if (bundleVersion != null && bundleVersion.m_stringLength != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SHA256Managed sHA256Managed = default;
				sHA256Managed.Initialize();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj5 = default;
				object obj4 = obj5;
				object obj7 = default;
				object obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj8 = default;
				if (obj6 == obj8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				if (sHA256Managed != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj9 = (nint)0 << 2;
					object obj10 = obj2 + obj9;
					if ((nint)obj10 == 59)
					{
						object obj11 = obj2 + 4;
						if ((nint)obj11 > -1)
						{
							object obj12 = obj11 + -1;
							obj11 = obj12;
						}
						goto IL_0436;
					}
				}
				object obj13 = default;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
			goto IL_0436;
			IL_0436:
			bool result = default;
			return result;
		}
	}

	private bool IsActive
	{
		get
		{
			if (_sampleState == SampleState.SampleKeyIncluded)
			{
				return true;
			}
			return _sampleState == SampleState.ExplicitIncluded;
		}
	}

	private int GameCountInSession
	{
		get
		{
			AnalyticsSettings settings = _settings;
			if (~(settings.Enabled ? 1u : 0u) == 0)
			{
				if (_sampleState == SampleState.SampleKeyIncluded)
				{
					return 1;
				}
				return (_sampleState == SampleState.ExplicitIncluded) ? 1 : 0;
			}
			return 0;
		}
	}

	AnalyticsManager IAnalyticsIntegrationTest.Manager
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Expected Obj, but got Unknown
			//IL_01d4: Expected Obj, but got I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_01f1: Expected Obj, but got I4
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected Obj, but got Unknown
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected Obj, but got Unknown
			//IL_027a: Expected Obj, but got I4
			//IL_0067: Expected Obj, but got I4
			//IL_0113: Expected Obj, but got I
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Expected Obj, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 32;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 16;
			obj5 = obj;
			_ = -1;
			ManagerData managerData = TopRunSave.managerData;
			Dictionary<string, string>.KeyCollection keys = ((Dictionary<string, string>)(object)managerData).Keys;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			AnalyticsManager analyticsManager = null;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				AnalyticsManager analyticsManager2 = (AnalyticsManager)(object)(obj4 + (object)analyticsManager);
				analyticsManager = analyticsManager2;
			}
			object obj7 = obj5 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj5 + obj9;
			obj10 = 66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj5 + obj11;
				if ((nint)obj12 == 66)
				{
					object obj13 = obj5 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_02b8;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_02b8;
			IL_02b8:
			return analyticsManager;
		}
	}

	public static event Action<ISubwayBaseEvent> OnEventPosted
	{
		add
		{
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AnalyticsIntegration);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = AnalyticsIntegration.m_OnEventPosted;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(AnalyticsIntegration);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(AnalyticsIntegration);
				if (!flag)
				{
					nint num5 = (nint)typeof(AnalyticsIntegration);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(AnalyticsIntegration);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(AnalyticsIntegration);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
				object obj5 = (nint)0 + (nint)56;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	static AnalyticsIntegration()
	{
		//IL_07c5: Expected Obj, but got I
		//IL_07d5: Expected Obj, but got I
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_0819: Expected Obj, but got I
		//IL_0829: Expected Obj, but got I
		//IL_0839: Expected Obj, but got I
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected Obj, but got Unknown
		//IL_0875: Expected Obj, but got I
		//IL_0885: Expected Obj, but got I
		//IL_0895: Expected Obj, but got I
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08d1: Expected Obj, but got I
		//IL_08e1: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_092d: Expected Obj, but got I
		//IL_093d: Expected Obj, but got I
		//IL_094d: Expected Obj, but got I
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected Obj, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_0989: Expected Obj, but got I
		//IL_0999: Expected Obj, but got I
		//IL_09a9: Expected Obj, but got I
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected Obj, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected Obj, but got Unknown
		//IL_09e5: Expected Obj, but got I
		//IL_09f5: Expected Obj, but got I
		//IL_0a05: Expected Obj, but got I
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected Obj, but got Unknown
		//IL_0a41: Expected Obj, but got I
		//IL_0a51: Expected Obj, but got I
		//IL_0a61: Expected Obj, but got I
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		//IL_0a9d: Expected Obj, but got I
		//IL_0aad: Expected Obj, but got I
		//IL_0abd: Expected Obj, but got I
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected Obj, but got Unknown
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Expected Obj, but got Unknown
		//IL_0af9: Expected Obj, but got I
		//IL_0b09: Expected Obj, but got I
		//IL_0b19: Expected Obj, but got I
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected Obj, but got Unknown
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected Obj, but got Unknown
		//IL_0b55: Expected Obj, but got I
		//IL_0b65: Expected Obj, but got I
		//IL_0b75: Expected Obj, but got I
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Expected Obj, but got Unknown
		//IL_0bb1: Expected Obj, but got I
		//IL_0bc1: Expected Obj, but got I
		//IL_0bd1: Expected Obj, but got I
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got Unknown
		//IL_0c0d: Expected Obj, but got I
		//IL_0c1d: Expected Obj, but got I
		//IL_0c2d: Expected Obj, but got I
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected Obj, but got Unknown
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Expected Obj, but got Unknown
		//IL_0c69: Expected Obj, but got I
		//IL_0c79: Expected Obj, but got I
		//IL_0c89: Expected Obj, but got I
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected Obj, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_0068: Expected VT, but got Obj
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00ca: Expected VT, but got Obj
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0131: Expected VT, but got Obj
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_0193: Expected VT, but got Obj
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_01fa: Expected VT, but got Obj
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_025c: Expected VT, but got Obj
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02c3: Expected VT, but got Obj
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02e7: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_0325: Expected VT, but got Obj
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_038c: Expected VT, but got Obj
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03b0: Expected Obj, but got I4
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03ee: Expected VT, but got Obj
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_0417: Expected Obj, but got I4
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0455: Expected VT, but got Obj
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0479: Expected Obj, but got I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04b7: Expected VT, but got Obj
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_04e0: Expected Obj, but got I4
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_051e: Expected VT, but got Obj
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_0580: Expected VT, but got Obj
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_05a9: Expected Obj, but got I4
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_05e7: Expected VT, but got Obj
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_060b: Expected Obj, but got I4
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected Obj, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_0649: Expected VT, but got Obj
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_0672: Expected Obj, but got I4
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected Obj, but got Unknown
		//IL_06b0: Expected VT, but got Obj
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected Obj, but got Unknown
		//IL_06d4: Expected Obj, but got I4
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_0712: Expected VT, but got Obj
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected Obj, but got Unknown
		//IL_073b: Expected Obj, but got I4
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_076b: Expected VT, but got Obj
		//IL_0786: Expected I, but got Obj
		//IL_079c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v17+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v18+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S5_v14 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v22+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S4_v23+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v110 @ S5_v18 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v27+60]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S4_v28+48]");
		object obj28 = 0;
		object obj29 = obj28 & 0x7FF;
		object obj30 = obj29 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S5_v22 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S4_v32+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S4_v33+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v148 @ S5_v26 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S4_v37+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S4_v38+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v167 @ S5_v30 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S4_v42+60]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S4_v43+48]");
		object obj43 = 0;
		object obj44 = obj43 & 0x7FF;
		object obj45 = obj44 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S5_v34 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S4_v47+60]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S4_v48+48]");
		object obj48 = 0;
		object obj49 = obj48 & 0x7FF;
		object obj50 = obj49 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v205 @ S5_v38 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S4_v52+60]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S4_v53+48]");
		object obj53 = 0;
		object obj54 = obj53 & 0x7FF;
		object obj55 = obj54 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S5_v42 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S4_v57+60]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S4_v58+48]");
		object obj58 = 0;
		object obj59 = obj58 & 0x7FF;
		object obj60 = obj59 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v243 @ S5_v46 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S4_v62+60]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S4_v63+48]");
		object obj63 = 0;
		object obj64 = obj63 & 0x7FF;
		object obj65 = obj64 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v262 @ S5_v50 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S4_v67+60]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S4_v68+48]");
		object obj68 = 0;
		object obj69 = obj68 & 0x7FF;
		object obj70 = obj69 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v281 @ S5_v54 (should have been resolved before IL gen)");
		Dictionary<string, string> androidOsVersionByApiVersion = default;
		AnalyticsHelper.AndroidOsVersionByApiVersion = androidOsVersionByApiVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<KeyValuePair<string, string>> list = default;
		list._002Ector();
		object obj72 = default;
		object obj71 = obj72 + 224;
		obj71 = 0;
		obj71 = "4.0.1";
		object obj73 = obj71 + 4;
		obj73 = "14";
		object obj74 = obj72 + 296;
		obj74 = obj71;
		KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)(obj72 + 304);
		keyValuePair = (KeyValuePair<string, string>)obj74;
		list.Add(keyValuePair);
		object obj75 = obj72 + 216;
		obj75 = 0;
		obj75 = "4.0.2";
		object obj76 = obj75 + 4;
		obj76 = "14";
		object obj77 = obj72 + 288;
		obj77 = obj75;
		keyValuePair = (KeyValuePair<string, string>)obj77;
		list.Add(keyValuePair);
		object obj78 = obj72 + 200;
		obj78 = 0;
		obj78 = "4.0.3";
		object obj79 = obj78 + 4;
		obj79 = "15";
		object obj80 = obj72 + 280;
		obj80 = obj78;
		keyValuePair = (KeyValuePair<string, string>)obj80;
		list.Add(keyValuePair);
		object obj81 = obj72 + 192;
		obj81 = 0;
		obj81 = "4.0.4";
		object obj82 = obj81 + 4;
		obj82 = "15";
		object obj83 = obj72 + 272;
		obj83 = obj81;
		keyValuePair = (KeyValuePair<string, string>)obj83;
		list.Add(keyValuePair);
		object obj84 = obj72 + 176;
		obj84 = 0;
		obj84 = "4.1";
		object obj85 = obj84 + 4;
		obj85 = "16";
		object obj86 = obj72 + 264;
		obj86 = obj84;
		keyValuePair = (KeyValuePair<string, string>)obj86;
		list.Add(keyValuePair);
		object obj87 = obj72 + 168;
		obj87 = 0;
		obj87 = "4.2";
		object obj88 = obj87 + 4;
		obj88 = "17";
		object obj89 = obj72 + 256;
		obj89 = obj87;
		keyValuePair = (KeyValuePair<string, string>)obj89;
		list.Add(keyValuePair);
		object obj90 = obj72 + 152;
		obj90 = 0;
		obj90 = "4.3";
		object obj91 = obj90 + 4;
		obj91 = "18";
		object obj92 = obj72 + 248;
		obj92 = obj90;
		keyValuePair = (KeyValuePair<string, string>)obj92;
		list.Add(keyValuePair);
		object obj93 = obj72 + 144;
		obj93 = 0;
		obj93 = "4.4.0";
		object obj94 = obj93 + 4;
		obj94 = "19";
		object obj95 = obj72 + 240;
		obj95 = obj93;
		keyValuePair = (KeyValuePair<string, string>)obj95;
		list.Add(keyValuePair);
		object obj96 = obj72 + 128;
		obj96 = 0;
		obj96 = "4.4.1";
		object obj97 = obj96 + 4;
		obj97 = "19";
		object obj98 = obj72 + 232;
		obj98 = obj96;
		keyValuePair = (KeyValuePair<string, string>)obj98;
		list.Add(keyValuePair);
		object obj99 = obj72 + 120;
		obj99 = 0;
		obj99 = "4.4.2";
		object obj100 = obj99 + 4;
		obj100 = "19";
		object obj101 = obj72 + 208;
		obj101 = obj99;
		keyValuePair = (KeyValuePair<string, string>)obj101;
		list.Add(keyValuePair);
		object obj102 = obj72 + 104;
		obj102 = 0;
		obj102 = "4.4.3";
		object obj103 = obj102 + 4;
		obj103 = "19";
		object obj104 = obj72 + 184;
		obj104 = obj102;
		keyValuePair = (KeyValuePair<string, string>)obj104;
		list.Add(keyValuePair);
		object obj105 = obj72 + 88;
		obj105 = 0;
		obj105 = "4.4.4";
		object obj106 = obj105 + 4;
		obj106 = "19";
		object obj107 = obj72 + 160;
		obj107 = obj105;
		keyValuePair = (KeyValuePair<string, string>)obj107;
		list.Add(keyValuePair);
		object obj108 = obj72 + 80;
		obj108 = 0;
		obj108 = "5.0";
		object obj109 = obj108 + 4;
		obj109 = "21";
		object obj110 = obj72 + 136;
		obj110 = obj108;
		keyValuePair = (KeyValuePair<string, string>)obj110;
		list.Add(keyValuePair);
		object obj111 = obj72 - -64;
		obj111 = 0;
		obj111 = "5.1";
		object obj112 = obj111 + 4;
		obj112 = "22";
		object obj113 = obj72 + 112;
		obj113 = obj111;
		keyValuePair = (KeyValuePair<string, string>)obj113;
		list.Add(keyValuePair);
		object obj114 = obj72 + 56;
		obj114 = 0;
		obj114 = "6.0";
		object obj115 = obj114 + 4;
		obj115 = "23";
		object obj116 = obj72 + 96;
		obj116 = obj114;
		keyValuePair = (KeyValuePair<string, string>)obj116;
		list.Add(keyValuePair);
		object obj117 = obj72 + 48;
		obj117 = 0;
		obj117 = "7.0";
		object obj118 = obj117 + 4;
		obj118 = "24";
		object obj119 = obj72 + 72;
		obj119 = obj117;
		keyValuePair = (KeyValuePair<string, string>)obj119;
		list.Add(keyValuePair);
		object obj120 = obj72 + 32;
		obj120 = 0;
		obj120 = "7.1";
		object obj121 = obj120 + 4;
		obj121 = "25";
		object obj122 = obj72 + 40;
		obj122 = obj120;
		keyValuePair = (KeyValuePair<string, string>)obj122;
		list.Add(keyValuePair);
		object obj123 = obj72 + 16;
		obj123 = 0;
		obj123 = "8.0";
		object obj124 = obj123 + 4;
		obj124 = "26";
		object obj125 = obj72 + 24;
		obj125 = obj123;
		keyValuePair = (KeyValuePair<string, string>)obj125;
		list.Add(keyValuePair);
		object obj126 = obj72 + 8;
		obj126 = 0;
		obj126 = "8.1";
		object obj127 = obj126 + 4;
		obj127 = "27";
		obj72 = obj126;
		keyValuePair = (KeyValuePair<string, string>)obj72;
		list.Add(keyValuePair);
		nint num15 = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S0_v329 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+5C]");
		object obj128 = (nint)0 + (nint)4;
		obj128 = list;
	}

	private void Start()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = AnalyticsIntegration.m_OnEventPosted;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(AnalyticsIntegration);
			if (!flag)
			{
				nint num5 = (nint)typeof(AnalyticsIntegration);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(AnalyticsIntegration);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(AnalyticsIntegration);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
			object obj5 = (nint)0 + (nint)56;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private static void ABTestManager_OnTagAdded(string testTag, int segmentIndex)
	{
		//IL_00e2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		if (!string.Equals((string)segmentIndex, "NotEnoughCurrencyPopup"))
		{
			return;
		}
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v22 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v14 (System.Collections.Generic.Dictionary`2<System.String, InApp.InAppItemModel>)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v15+15]");
		bool flag = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [testTag @ L0 (System.String)+14]");
		object obj3 = 0;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v8+20]");
			object obj4 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v8+1C]");
			object obj5 = (nint)0 + (nint)1;
		}
		((AggregatedDataTracking)(object)testTag).PlayerInfo_OnKeysChanged();
	}

	private unsafe void UIScreenController_OnAwake()
	{
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0203: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0136: Expected I, but got Obj
		//IL_007d: Expected I4, but got Obj
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I
		//IL_00d2: Expected I, but got Obj
		nint num = (nint)typeof(Singleton<LogManager>);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Logging.LogManager>>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Singleton<LogManager>);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v58 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Logging.LogManager>>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogManager instance = Singleton<LogManager>.GetInstance();
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			float userSampleValue = Kiloo.Analytics.Manager.userSampleValue;
			_samplingKey = userSampleValue;
			string syboAggregatedDataString = SyboAnalyticsSave.syboAggregatedDataString;
			_sampleState = (SampleState)syboAggregatedDataString;
			UpdateEndpoint();
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v36 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v54 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Delegate obj3 = default;
			obj3.method_ptr = method_ptr;
			obj3.method = (nint)__ldftn(AnalyticsIntegration.OnlineSettings_OnDownloaded);
			object obj4 = obj3 + 16;
			obj4 = this;
			object obj5 = saveDataPath + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v41 (System.String)+18]");
			Delegate obj6 = ((Delegate)0).CombineImpl(obj3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj7 = default;
			obj5 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(AnalyticsIntegration.UIScreenController_OnAwake);
		object obj8 = action + 16;
		obj8 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnAwake -= action;
	}

	protected unsafe override void OnDestroy()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AnalyticsIntegration.UIScreenController_OnAwake);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationPaused += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnChangedScreen -= action2;
	}

	private void OnlineSettings_OnDownloaded(bool success)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		if ((success ? 1 : 0) == -1)
		{
			nint num = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v119 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v148 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			object obj5 = default;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			goto IL_019e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v76+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v87+47]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				goto IL_019e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		return;
		IL_019e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj6 = default;
		object obj7 = default;
		if (obj6 == obj7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj9 = default;
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj11 = default;
			object obj10 = obj11;
		}
		else
		{
			object obj12 = default;
			object obj10 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void InitializeSettings()
	{
		UpdateFrontScreenHandler(subscribe: false);
		if (_manager != null)
		{
			_manager.Flush();
		}
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}

	private unsafe void InitializeSampleState()
	{
		//IL_0212: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_02cb: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I
		//IL_0018: Expected I, but got Obj
		//IL_00b7: Expected I4, but got Obj
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_0065: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		if (~(_useDebugSettingsOnce ? 1u : 0u) == 0)
		{
		}
		AnalyticsSettings settings = _settings;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v5 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v46 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool flag = ((OnlineSettings)(object)saveDataPath).TryGetValue("sybo_analytics_enabled", out *(string*)null);
		settings.Enabled = flag;
		AnalyticsSettings settings2 = _settings;
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v14 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v42 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		bool flushEnabled = ((OnlineSettings)(object)saveDataPath2).TryGetValue("sybo_analytics_flush_enabled", out *(string*)1);
		settings2.FlushEnabled = flushEnabled;
		AnalyticsSettings settings3 = _settings;
		string saveDataPath3 = OnlineSettings.GetSaveDataPath();
		float startOffset = ((LayoutGroup)(object)saveDataPath3).GetStartOffset((int)"sybo_analytics_sampling_threshold", 0f);
		settings3._samplingThreshold = startOffset;
		object obj3 = _settings + 16;
		string saveDataPath4 = OnlineSettings.GetSaveDataPath();
		bool value = ((OnlineSettings)(object)saveDataPath4).GetValue("sybo_analytics_endpoint_baseurl", false);
		obj3 = value;
		object obj4 = _settings - -64;
		string deviceID = GetDeviceID();
		obj4 = deviceID;
		AnalyticsSettings settings4 = _settings;
		string saveDataPath5 = OnlineSettings.GetSaveDataPath();
		uint value2 = ((OnlineSettings)(object)saveDataPath5).GetValue("sybo_analytics_max_games_without_flush", 10u);
		settings4.MaxGamesWithoutFlush = (int)value2;
		AnalyticsSettings settings5 = _settings;
		string saveDataPath6 = OnlineSettings.GetSaveDataPath();
		uint value3 = ((OnlineSettings)(object)saveDataPath6).GetValue("sybo_analytics_games_in_session_before_first_flush", 1u);
		settings5.GamesInSessionBeforeFirstFlush = (int)value3;
		AnalyticsSettings settings6 = _settings;
		string saveDataPath7 = OnlineSettings.GetSaveDataPath();
		bool onlyValidatedPurchases = ((OnlineSettings)(object)saveDataPath7).TryGetValue("sybo_analytics_only_validated_purchases", out *(string*)1);
		settings6.OnlyValidatedPurchases = onlyValidatedPurchases;
	}

	private void InitializeFromSettings()
	{
		//IL_00cc: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		AnalyticsSettings settings = _settings;
		if (~(settings.Enabled ? 1u : 0u) == 0)
		{
			AnalyticsSettings settings2 = _settings;
			bool flag;
			if (settings2._samplingThreshold > 0f)
			{
				AnalyticsSettings settings3 = _settings;
				flag = !(_samplingKey > settings3._samplingThreshold);
			}
			else
			{
				flag = false;
			}
			bool flag2 = _sampleState == SampleState.Unsampled;
			object obj = flag & flag2;
			if (obj != null)
			{
				_sampleState = SampleState.SampleKeyIncluded;
				SyboAnalyticsSave.syboAggregatedDataString = (string)_sampleState;
			}
		}
	}

	private unsafe static void CacheJsonClassInfo()
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_00e1: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got I4
		//IL_0280: Expected I, but got Obj
		//IL_0296: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		AnalyticsUserIdPersistedDefault = string.Empty;
		nint num = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = string.Empty;
		GamesSinceFlushPersistedDefault = 0;
		CurrentSessionPersistedDefault = -1;
		nint num2 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v19 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
		object obj2 = (nint)0 + (nint)16;
		obj2 = string.Empty;
		nint num3 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
		object obj3 = (nint)0 + (nint)20;
		obj3 = string.Empty;
		nint num4 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v27 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
		object obj4 = (nint)0 + (nint)24;
		obj4 = string.Empty;
		PerformanceLevelPersistedDefault = DeviceInfo.PerformanceLevel.Low;
		GpuScorePersistedDefault = -1;
		nint num5 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v37 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
		object obj5 = (nint)0 + (nint)36;
		obj5 = string.Empty;
		nint num6 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v41 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
		object obj6 = (nint)0 + (nint)40;
		obj6 = string.Empty;
		SampleStateDefault = SampleState.Unsampled;
		nint num7 = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v48 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+5C]");
		object obj7 = (nint)0 + (nint)48;
		obj7 = string.Empty;
		_jsonClassInfoCached = false;
		nint num8 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v55 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v67 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj9 = default;
		obj9.method_ptr = method_ptr;
		obj9.method = (nint)(delegate*<string, int, void>)(&ABTestManager_OnTagAdded);
		object obj10 = obj9 + 16;
		obj10 = 0;
		Delegate obj11 = ((Delegate)ABTestManager.onTagAdded).CombineImpl(obj9);
		nint num10 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v64 (Il2CppClass<ABTest.ABTestManager>)+5C]");
		object obj12 = (nint)0 + (nint)12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj13 = default;
		obj12 = obj13;
	}

	private bool HasUserInPlayerInfo()
	{
		return true;
	}

	private void UpdateEndpoint()
	{
		//IL_00dc: Expected Obj, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_06aa: Expected Obj, but got I4
		//IL_06b3: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_02ad: Expected I4, but got Obj
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_03c8: Expected VT, but got Obj
		//IL_03e8: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got VT
		//IL_043a: Expected I8, but got I4
		AnalyticsSettings settings = _settings;
		bool flag = ~(settings.Enabled ? 1u : 0u) == 0 && (_sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded);
		bool flag2 = _sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded;
		InitializeSampleState();
		InitializeFromSettings();
		object obj;
		object obj3 = default;
		if (_sessionTracker != null)
		{
			if (!flag)
			{
				goto IL_0124;
			}
			obj = 1;
		}
		else
		{
			AnalyticsSettings settings2 = _settings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CollisionNotifier collisionNotifier = default;
			collisionNotifier.TriggerEnter += (Action<Collider>)settings2.SessionTimeoutSeconds;
			object obj2 = this + 40;
			obj2 = collisionNotifier;
			if (!flag)
			{
				goto IL_0124;
			}
			obj3 = 0;
			obj = 1;
		}
		goto IL_067c;
		IL_067c:
		AnalyticsSettings settings3 = _settings;
		bool flag3 = ~(settings3.Enabled ? 1u : 0u) == 0 && (_sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded);
		bool flag4 = !flag2 && (_sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded);
		object obj4 = obj ^ flag3;
		PostAnalyticsProvider postAnalyticsProvider = ((AnalyticsIntegration)null).CreatePostAnalyticsProvider();
		AnalyticsSettings settings4 = _settings;
		if (~(settings4.Enabled ? 1u : 0u) == 0)
		{
			if (_manager != null)
			{
				AnalyticsManager manager = _manager;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				AnalyticsSettings settings5 = _settings;
				string text = default;
				if (text.get_Chars((int)settings5.BaseURL) != '\0')
				{
					Initialize();
				}
			}
			bool flag5 = _manager != null;
			object obj5 = postAnalyticsProvider ^ 1;
			object obj6 = flag5 | obj5;
			AnalyticsManager manager2;
			if (obj6 != null)
			{
				manager2 = _manager;
				if (!flag5)
				{
					goto IL_0349;
				}
			}
			else
			{
				bool flag6 = _sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded;
				bool flag7 = !flag6;
				manager2 = _manager;
				if (!flag7)
				{
					goto IL_0349;
				}
			}
			bool flag8 = manager2 != null;
			object obj7 = obj3 & flag8;
			if (obj7 != null)
			{
				Game_OnMenuScreenShown();
			}
			goto IL_05e2;
		}
		goto IL_0630;
		IL_0124:
		AnalyticsSettings settings6 = _settings;
		bool flag9 = ~(settings6.Enabled ? 1u : 0u) == 0 && (_sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded);
		obj3 = flag9;
		obj = 0;
		goto IL_067c;
		IL_0349:
		InitializeManager();
		goto IL_05e2;
		IL_05e2:
		if (_sampleState != SampleState.SampleKeyIncluded && _sampleState != SampleState.ExplicitIncluded)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			AnalyticsSettings settings7 = _settings;
			((AggregatedDataTracking)val).PurchaseHandler_OnIngameCurrencyPurchaseCompleted((object)postAnalyticsProvider, (PurchaseHandler.SyboInGameCurrencyPurchaseEventArgs)settings7.SessionTimeoutSeconds);
		}
		else
		{
			object obj8 = postAnalyticsProvider & 1;
			object obj9 = flag4 & obj8;
			if (obj9 != null)
			{
				PostJoinedSampleEvent(JoinedSampleSource.SampleThreshold, -1L);
			}
		}
		goto IL_0630;
		IL_0630:
		if (obj4 != null)
		{
			((CollisionNotifier)(object)_sessionTracker).Awake();
		}
		AnalyticsSettings settings8 = _settings;
		bool subscribe = ~(settings8.Enabled ? 1u : 0u) == 0 && (_sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded);
		UpdateFrontScreenHandler(subscribe);
	}

	private PostAnalyticsProvider CreatePostAnalyticsProvider()
	{
		//IL_005e: Expected Obj, but got I4
		bool flag;
		if (SyboAnalyticsSave.syboAnalyticsCurrentSession != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ S0_v2 (System.Int32)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		return (PostAnalyticsProvider)((flag ? 1 : 0) ^ 1);
	}

	private void UpdateEventHandlersPostingAnalyticsEvents(bool subscribe)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected I4, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_015e: Expected Obj, but got I4
		if (!subscribe)
		{
			return;
		}
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4;
		if (MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v29 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v19 (System.Boolean)+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v20+8]");
			if ((nint)0 != 0)
			{
				if (~(_waitingToInitialize ? 1u : 0u) != 0)
				{
					OnApplicationFocus(focusStatus: true);
				}
				obj4 = 1;
				goto IL_01f0;
			}
		}
		UpdateEndpoint();
		obj4 = 0;
		goto IL_01f0;
		IL_01f0:
		bool waitingToInitialize = _waitingToInitialize;
		object obj5 = obj4 | waitingToInitialize;
		bool waitingToInitialize2 = (byte)(obj5 & 1) != 0;
		_waitingToInitialize = waitingToInitialize2;
	}

	private unsafe void UpdateFrontScreenHandler(bool subscribe)
	{
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected Obj, but got Unknown
		//IL_0778: Expected I, but got Obj
		//IL_078e: Expected Obj, but got I
		//IL_131e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1323: Expected Obj, but got Unknown
		//IL_1336: Expected I, but got Obj
		//IL_134c: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0f2b: Expected I, but got Obj
		//IL_0f41: Expected Obj, but got I
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Expected Obj, but got Unknown
		//IL_07b9: Expected I, but got Obj
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Expected Obj, but got Unknown
		//IL_15e7: Expected I, but got Obj
		//IL_15fd: Expected Obj, but got I
		//IL_0e74: Expected I, but got Obj
		//IL_0e8a: Expected Obj, but got I
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected Obj, but got Unknown
		//IL_088e: Expected I, but got Obj
		//IL_08a4: Expected Obj, but got I
		//IL_0806: Expected I, but got Obj
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_00a3: Expected I, but got Obj
		//IL_0f6c: Expected I, but got Obj
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Expected Obj, but got Unknown
		//IL_13ea: Expected Obj, but got I4
		//IL_13fd: Expected I, but got Obj
		//IL_1413: Expected Obj, but got I
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected Obj, but got Unknown
		//IL_1156: Expected I, but got Obj
		//IL_116c: Expected Obj, but got I
		//IL_0fb9: Expected I, but got Obj
		//IL_0eb5: Expected I, but got Obj
		//IL_08cf: Expected I, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_1006: Expected I, but got Obj
		//IL_101c: Expected Obj, but got I
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected Obj, but got Unknown
		//IL_091c: Expected I, but got Obj
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_01a9: Expected I, but got Obj
		//IL_1683: Unknown result type (might be due to invalid IL or missing references)
		//IL_1688: Expected Obj, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_1047: Expected I, but got Obj
		//IL_0a0d: Expected I, but got Obj
		//IL_0a23: Expected Obj, but got I
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_148b: Expected Obj, but got Unknown
		//IL_14b0: Expected I, but got Obj
		//IL_14c6: Expected Obj, but got I
		//IL_11df: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected Obj, but got Unknown
		//IL_1209: Expected I, but got Obj
		//IL_121f: Expected Obj, but got I
		//IL_0abb: Expected Obj, but got I4
		//IL_0ace: Expected I, but got Obj
		//IL_0ae4: Expected Obj, but got I
		//IL_0a4e: Expected I, but got Obj
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0353: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I
		//IL_02d3: Expected I, but got Obj
		//IL_1506: Expected Obj, but got I
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1514: Expected Obj, but got Unknown
		//IL_1258: Unknown result type (might be due to invalid IL or missing references)
		//IL_125d: Expected Obj, but got Unknown
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b74: Expected Obj, but got Unknown
		//IL_0b0f: Expected I, but got Obj
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0420: Expected I, but got Obj
		//IL_0436: Expected Obj, but got I
		//IL_0394: Expected I, but got Obj
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected Obj, but got Unknown
		//IL_129a: Unknown result type (might be due to invalid IL or missing references)
		//IL_129f: Expected Obj, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_0461: Expected I, but got Obj
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected Obj, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_0c8e: Expected Obj, but got I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected Obj, but got Unknown
		//IL_0cde: Expected I, but got Obj
		//IL_0cf4: Expected Obj, but got I
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05aa: Expected I, but got Obj
		//IL_05c0: Expected Obj, but got I
		//IL_1559: Unknown result type (might be due to invalid IL or missing references)
		//IL_155e: Expected Obj, but got Unknown
		//IL_12dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e1: Expected Obj, but got Unknown
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected Obj, but got Unknown
		//IL_0d1f: Expected I, but got Obj
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected Obj, but got Unknown
		//IL_05eb: Expected I, but got Obj
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0def: Expected Obj, but got Unknown
		//IL_0dfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Expected Obj, but got Unknown
		//IL_0e17: Expected Obj, but got I
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06e7: Expected Obj, but got I
		OnApplicationFocus(subscribe);
		bool subscribedEventPostingHandlers = _subscribedEventPostingHandlers;
		if (subscribe)
		{
			if (!subscribedEventPostingHandlers)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Action<CelebrationReward> action = default;
				object obj = action + 16;
				obj = this;
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v301 (Il2CppClass<RewardManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num3 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v508 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				RewardManager.OnMysteryBoxAddedForUnlock -= action;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num4 = 0;
				_ = 0;
				Action<CelebrationReward> action2 = default;
				object obj3 = action2 + 16;
				obj3 = this;
				RewardManager.OnRewardPaidOut -= action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				Action<CelebrationReward> action3 = default;
				object obj4 = action3 + 16;
				obj4 = this;
				nint num6 = (nint)typeof(CelebrationPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v326 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num7 = (nint)typeof(CelebrationPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v504 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CelebrationPopup.OnRewardDoubleUp -= action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num8 = 0;
				_ = 0;
				Action<int> action4 = default;
				object obj6 = action4 + 16;
				obj6 = this;
				nint num9 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v341 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num10 = (nint)typeof(WordHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v500 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WordHuntManager.OnDailyLetterCoinsRewarded -= action4;
				AssetBundleManager instance = AssetBundleManager.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num11 = 0;
				_ = 0;
				Action<int> action5 = default;
				object obj8 = action5 + 16;
				obj8 = this;
				((OfferWallManager)(object)instance).onPendingRewardsReceived -= action5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Delegate obj9 = default;
				obj9.method_ptr = method_ptr;
				obj9.method = (nint)__ldftn(AnalyticsIntegration.OnDoubleCoinsReceived);
				object obj10 = obj9 + 16;
				obj10 = this;
				Delegate obj11 = ((Delegate)DoubleCoinsVideo.onDoubleCoinsReceived).CombineImpl(obj9);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				Action<CelebrationReward> onDoubleCoinsReceived = default;
				DoubleCoinsVideo.onDoubleCoinsReceived = onDoubleCoinsReceived;
				nint num12 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S0_v357 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num13 = (nint)typeof(SellConsumablesHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v494 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr2 = 0;
				Delegate obj13 = default;
				obj13.method_ptr = method_ptr2;
				obj13.method = (nint)__ldftn(AnalyticsIntegration.OnRewardConsumablesWithVideo);
				object obj14 = obj13 + 16;
				obj14 = this;
				Delegate obj15 = ((Delegate)SellConsumablesHelper.OnRewardWithVideo).CombineImpl(obj13);
				nint num14 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v366 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+5C]");
				object obj16 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj17 = default;
				obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num15 = 0;
				_ = 0;
				Action<EarnCoinsData.Id, int> action6 = default;
				object obj18 = action6 + 16;
				obj18 = this;
				nint num16 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S0_v379 (Il2CppClass<Info.EarnCoinsData>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num17 = (nint)typeof(EarnCoinsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S0_v490 (Il2CppClass<Info.EarnCoinsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EarnCoinsData.OnRewardURLOpened -= action6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num18 = 0;
				_ = 0;
				Action<int> action7 = default;
				object obj20 = action7 + 16;
				obj20 = this;
				FriendHelperCrew.OnFriendCoinsReceived -= action7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr3 = 0;
				Action action8 = default;
				((Delegate)action8).method_ptr = method_ptr3;
				((Delegate)action8).method = (nint)__ldftn(AnalyticsIntegration.Game_OnGameStarted);
				object obj21 = action8 + 16;
				obj21 = this;
				nint num19 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ S0_v401 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num20 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v486 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Game.OnGameStarted -= action8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num21 = 0;
				_ = 0;
				Action<bool, bool, bool, bool> action9 = default;
				object obj23 = action9 + 16;
				obj23 = this;
				Game.OnRunStarted -= action9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num22 = 0;
				_ = 0;
				Action<bool> action10 = default;
				object obj24 = action10 + 16;
				obj24 = this;
				Game.OnPlayerDied -= action10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr4 = 0;
				Action action11 = default;
				((Delegate)action11).method_ptr = method_ptr4;
				((Delegate)action11).method = (nint)__ldftn(AnalyticsIntegration.Game_OnGameEnded);
				object obj25 = action11 + 16;
				obj25 = this;
				Game.OnGameEnded -= action11;
				SlideinPowerupHelper instance2 = SlideinPowerupHelper.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num23 = 0;
				_ = 0;
				EventHandler<PurchaseHandler.SyboInGameCurrencyPurchaseEventArgs> eventHandler = default;
				object obj26 = eventHandler + 16;
				obj26 = this;
				((PurchaseHandler)(object)instance2).OnIngameCurrencyPurchaseCompleted -= eventHandler;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num24 = 0;
				_ = 0;
				Action<Characters.CharacterId, int> action12 = default;
				object obj27 = action12 + 16;
				obj27 = this;
				nint num25 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ S0_v445 (Il2CppClass<CharacterNameEventManager>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num26 = (nint)typeof(CharacterNameEventManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ S0_v482 (Il2CppClass<CharacterNameEventManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterNameEventManager.OnCharacterSkippedWithKeys -= action12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num27 = 0;
				_ = 0;
				Action<Characters.CharacterId> action13 = default;
				object obj29 = action13 + 16;
				obj29 = this;
				CharacterNameEventManager.OnCharacterSkippedWithVideo -= action13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr5 = 0;
				MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
				((Delegate)missionCompleteHandler).method_ptr = method_ptr5;
				((Delegate)missionCompleteHandler).method = (nint)__ldftn(AnalyticsIntegration.MissionManager_OnMissionComplete);
				object obj30 = missionCompleteHandler + 16;
				obj30 = this;
				MissionsManager.onMissionComplete -= missionCompleteHandler;
				StayInOneLaneMission instance3 = StayInOneLaneMission.instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr6 = 0;
				Delegate obj31 = default;
				obj31.method_ptr = method_ptr6;
				obj31.method = (nint)__ldftn(AnalyticsIntegration.MissionManager_OnMissionSkipped);
				object obj32 = obj31 + 16;
				obj32 = this;
				object obj33 = instance3 + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ S0_v468 (Missions.StayInOneLaneMission)+1C]");
				Delegate obj34 = ((Delegate)0).CombineImpl(obj31);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj35 = default;
				obj33 = obj35;
				_subscribedEventPostingHandlers = true;
			}
		}
		else if (subscribedEventPostingHandlers)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr7 = 0;
			Action action14 = default;
			((Delegate)action14).method_ptr = method_ptr7;
			((Delegate)action14).method = (nint)__ldftn(AnalyticsIntegration.Game_OnMenuScreenShown);
			object obj36 = action14 + 16;
			obj36 = this;
			nint num28 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v67 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num29 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v284 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Game.OnGameDestroyed += action14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num30 = 0;
			_ = 0;
			Action<CelebrationReward> action15 = default;
			object obj38 = action15 + 16;
			obj38 = this;
			nint num31 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v82 (Il2CppClass<RewardManager>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num32 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v280 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager.OnRewardPaidOut += action15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num33 = 0;
			CelebrationReward celebrationReward = default;
			celebrationReward.CelebrationRewardOrigin = (CelebrationRewardOrigin)num33;
			celebrationReward.amount = 0;
			object obj40 = celebrationReward + 16;
			obj40 = this;
			RewardManager.AddRewardToUnlock(celebrationReward);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			CelebrationPopup celebrationPopup = default;
			((UnityEngine.Object)celebrationPopup).m_CachedPtr = cachedPtr;
			((UIScreen)celebrationPopup)._selectedFooterButton = 0;
			object obj41 = celebrationPopup + 16;
			obj41 = this;
			nint num34 = (nint)typeof(CelebrationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v107 (Il2CppClass<UI.Screens.CelebrationPopup>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num35 = (nint)typeof(CelebrationPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v276 (Il2CppClass<UI.Screens.CelebrationPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			celebrationPopup.SetupCelebrationScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num36 = 0;
			_ = 0;
			char c = default;
			object obj43 = c + 16;
			obj43 = this;
			nint num37 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v122 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num38 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v272 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WordHuntManager.PickedupLetter(c);
			AssetBundleManager instance4 = AssetBundleManager.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num39 = 0;
			string text = default;
			text.m_stringLength = (int)num39;
			_ = 0;
			object obj45 = text + 16;
			obj45 = this;
			((OfferWallManager)(object)instance4).ShowOfferWall(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr8 = 0;
			Delegate obj46 = default;
			obj46.method_ptr = method_ptr8;
			obj46.method = (nint)__ldftn(AnalyticsIntegration.OnDoubleCoinsReceived);
			object obj47 = obj46 + 16;
			obj47 = this;
			Delegate obj48 = ((Delegate)DoubleCoinsVideo.onDoubleCoinsReceived).RemoveImpl(obj46);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			Action<CelebrationReward> onDoubleCoinsReceived2 = default;
			DoubleCoinsVideo.onDoubleCoinsReceived = onDoubleCoinsReceived2;
			nint num40 = (nint)typeof(SellConsumablesHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S0_v138 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
			object obj49 = (nint)0 & (nint)0x200;
			if (obj49 != null)
			{
				nint num41 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S0_v266 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr9 = 0;
			Delegate obj50 = default;
			obj50.method_ptr = method_ptr9;
			obj50.method = (nint)__ldftn(AnalyticsIntegration.OnRewardConsumablesWithVideo);
			object obj51 = obj50 + 16;
			obj51 = this;
			Delegate obj52 = ((Delegate)SellConsumablesHelper.OnRewardWithVideo).RemoveImpl(obj50);
			nint num42 = (nint)typeof(SellConsumablesHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ S0_v147 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+5C]");
			object obj53 = (nint)0 + (nint)8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj54 = default;
			obj53 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num43 = 0;
			_ = 0;
			int num44 = default;
			object obj55 = num44 + 16;
			obj55 = this;
			nint num45 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ S0_v160 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj56 = (nint)0 & (nint)0x200;
			if (obj56 != null)
			{
				nint num46 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S0_v262 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EarnCoinsData.Trigger(num44);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr2 = 0;
			FriendHelperCrew friendHelperCrew = default;
			((UnityEngine.Object)friendHelperCrew).m_CachedPtr = cachedPtr2;
			friendHelperCrew._progress = (GameObject)0;
			object obj57 = friendHelperCrew + 16;
			obj57 = this;
			friendHelperCrew.CollectReward();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num47 = 0;
			_ = 0;
			Action<bool, bool, bool, bool> action16 = default;
			object obj58 = action16 + 16;
			obj58 = this;
			Game.OnRunStarted += action16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr10 = 0;
			Action action17 = default;
			((Delegate)action17).method_ptr = method_ptr10;
			((Delegate)action17).method = (nint)__ldftn(AnalyticsIntegration.Game_OnRunStarted);
			object obj59 = action17 + 16;
			obj59 = this;
			Game.OnGameRevived += action17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num48 = 0;
			_ = 0;
			Action<bool> action18 = default;
			object obj60 = action18 + 16;
			obj60 = this;
			Game.OnRunEnded += action18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr11 = 0;
			Action action19 = default;
			((Delegate)action19).method_ptr = method_ptr11;
			((Delegate)action19).method = (nint)__ldftn(AnalyticsIntegration.Game_OnGameEnded);
			object obj61 = action19 + 16;
			obj61 = this;
			Game.OnMenuScreenShown += action19;
			SlideinPowerupHelper instance5 = SlideinPowerupHelper.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num49 = 0;
			_ = 0;
			Characters.CharacterId characterId = default;
			object obj62 = characterId + 16;
			obj62 = this;
			((PurchaseHandler)(object)instance5).StartPurchaseCharacterWithInapp(characterId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num50 = 0;
			_ = 0;
			Action<Characters.CharacterId> action20 = default;
			object obj63 = action20 + 16;
			obj63 = this;
			nint num51 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ S0_v221 (Il2CppClass<CharacterNameEventManager>)+BA]");
			object obj64 = (nint)0 & (nint)0x200;
			if (obj64 != null)
			{
				nint num52 = (nint)typeof(CharacterNameEventManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ S0_v258 (Il2CppClass<CharacterNameEventManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterNameEventManager.OnCharacterSkippedWithVideo += action20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num53 = 0;
			CharacterNameEventManager characterNameEventManager = default;
			characterNameEventManager._eventType = (SSEventType)num53;
			_ = 0;
			object obj65 = characterNameEventManager + 16;
			obj65 = this;
			characterNameEventManager.CheckIfDataIsValid();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num54 = 0;
			MissionsManager missionsManager = default;
			missionsManager._currentMissionTemplateSetLoaded = (int)num54;
			missionsManager._defaultMissionIndexUpdateInterval = 0;
			object obj66 = missionsManager + 16;
			obj66 = this;
			missionsManager._002Ector();
			StayInOneLaneMission instance6 = StayInOneLaneMission.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr12 = 0;
			Delegate obj67 = default;
			obj67.method_ptr = method_ptr12;
			obj67.method = (nint)__ldftn(AnalyticsIntegration.MissionManager_OnMissionSkipped);
			object obj68 = obj67 + 16;
			obj68 = this;
			object obj69 = instance6 + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S0_v244 (Missions.StayInOneLaneMission)+1C]");
			Delegate obj70 = ((Delegate)0).RemoveImpl(obj67);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj71 = default;
			obj69 = obj71;
			_subscribedEventPostingHandlers = false;
		}
		bool subscribedToInAppManager = _subscribedToInAppManager;
		AnalyticsSettings settings = _settings;
		if (~(settings.Enabled ? 1u : 0u) == 0)
		{
			if (subscribedToInAppManager)
			{
				return;
			}
			nint num55 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v48 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj72 = (nint)0 & (nint)0x200;
			if (obj72 != null)
			{
				nint num56 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v55 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr13 = 0;
			InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
			((Delegate)onPurchaseSuccess).method_ptr = method_ptr13;
			((Delegate)onPurchaseSuccess).method = (nint)__ldftn(AnalyticsIntegration.InAppManager_OnPurchaseSuccess);
			object obj73 = onPurchaseSuccess + 16;
			obj73 = this;
			((InAppManager)(object)activeInAppOffers).onPurchaseSuccess -= onPurchaseSuccess;
			_subscribedToInAppManager = true;
		}
		else
		{
			if (!subscribedToInAppManager)
			{
				return;
			}
			nint num57 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v20 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj74 = (nint)0 & (nint)0x200;
			if (obj74 != null)
			{
				nint num58 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v40 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
			nint num59 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj75 = (nint)0 & (nint)0x200;
			if (obj75 != null)
			{
				nint num60 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)activeInAppOffers2).FindKernel((string)null) != 0)
			{
				nint num61 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v30 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj76 = (nint)0 & (nint)0x200;
				if (obj76 != null)
				{
					nint num62 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v36 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr14 = 0;
				InAppManager.OnPurchaseFailure onPurchaseFailure = default;
				((Delegate)onPurchaseFailure).method_ptr = method_ptr14;
				((Delegate)onPurchaseFailure).method = (nint)__ldftn(AnalyticsIntegration.InAppManager_OnPurchaseSuccess);
				object obj77 = onPurchaseFailure + 16;
				obj77 = this;
				((InAppManager)(object)activeInAppOffers3).onPurchaseFailure += onPurchaseFailure;
			}
			_subscribedToInAppManager = false;
		}
	}

	private void Initialize()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = _manager + 20;
		string userAgentString = GetUserAgentString();
		obj = userAgentString;
	}

	private void InitializeManager()
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Math3D.Init();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MeshMorpher meshMorpher = default;
		meshMorpher.SetMorph(2000f);
		object obj2 = this + 84;
		obj2 = meshMorpher;
		PostDeviceInfoIfDataChanged();
	}

	private static string GetNewUserId()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_000d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		object obj3 = currentSkipForVideoMissionIndex + 1;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int missionsVersion = PlayerSave.missionsVersion;
		obj2 = missionsVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		return string.Format((IFormatProvider)(object)"{0}_{1}", format, arg);
	}

	private unsafe string GetUserAgentString()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_00b2: Expected VT, but got Obj
		//IL_00b2: Expected VT, but got Obj
		//IL_00b2: Expected VT, but got Obj
		//IL_00b2: Expected VT, but got Obj
		//IL_00b2: Expected VT, but got Obj
		//IL_000a: Expected Obj, but got Ref
		AnalyticsSettings settings = _settings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Vector3 vector = default;
		object obj = vector + 8;
		obj = this;
		_ = settings.WebRequestTimeoutSeconds;
		AnalyticsSettings settings2 = _settings;
		AnalyticsSettings settings3 = _settings;
		AnalyticsSettings settings4 = _settings;
		object obj2 = _settings - -64;
		AnalyticsSettings settings5 = _settings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ref GameObject reference = default;
		Math3D.PreciseAlign(ref reference, (Vector3)settings2.BaseURL, (Vector3)settings3.ApplicationID, (Vector3)settings4.ApiVersion, (Vector3)obj2, (Vector3)settings5.Key, vector);
		return (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
	}

	private void AddUserToSample(JoinedSampleSource joinedSampleSource, long sourceId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8AA2");
		if (sourceId < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentNullException ex = default;
			ex._002Ector("length");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void PostJoinedSampleEvent(JoinedSampleSource joinedSampleSource, long sourceId)
	{
		//IL_000e: Expected Obj, but got I4
		((ObfuscatedMemory)(object)this).SetInt64((string)joinedSampleSource, sourceId);
		LogWarningIfWindowsPhone();
	}

	private string GetDeviceID()
	{
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num3 = default;
		object obj2 = num3 + 16;
		obj2 = 46;
		string text = bundleIdentifier.Substring(num3);
		object obj3 = text + 16;
		string text2 = ((string)obj3).PadRight(2, '0');
		object obj4 = text + 20;
		string text3 = ((string)obj4).PadRight(2, '0');
		object obj5 = text + 24;
		string text4 = ((string)obj5).PadRight(2, '0');
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		AnalyticsSettings settings = _settings;
		throw new ArrayTypeMismatchException();
	}

	private void PostDeviceInfoIfDataChanged()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_104d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1052: Expected Obj, but got Unknown
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Expected Obj, but got Unknown
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Expected Obj, but got Unknown
		//IL_0031: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 24;
		obj5 = obj;
		_ = -1;
		if (_manager == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			object obj6 = default;
			((Func<int>)5473)._002Ector(obj6, (IntPtr)this);
			SessionStartedEvent.GetIncrementedSessionID = (Func<int>)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj8 = default;
			object obj7 = obj8;
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj11 = default;
			if (obj9 == obj11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj13 = default;
				object obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj15 = default;
				object obj14 = obj15;
			}
			else
			{
				object obj14 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	private void OnValidate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj4 = default;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj5 = default;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj6 = default;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18+38]");
					object obj7 = default;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18+4C]");
						object obj8 = default;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							object obj9 = default;
							if (obj9 == null)
							{
								goto IL_0576;
							}
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		goto IL_0576;
		IL_0576:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
	}

	private void Reset()
	{
		if (_settings != null)
		{
			_settings.SetDebugDefaults();
		}
	}

	private unsafe void OnApplicationFocus(bool focusStatus)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_015c: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_00b7: Expected I, but got Obj
		bool subscribedToFrontScreenEvent = _subscribedToFrontScreenEvent;
		if (focusStatus)
		{
			if (subscribedToFrontScreenEvent)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(AnalyticsIntegration.Game_OnMenuScreenShown);
			object obj = action + 16;
			obj = this;
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v38 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v44 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Game.OnMenuScreenShown -= action;
			_subscribedToFrontScreenEvent = true;
		}
		else
		{
			if (!subscribedToFrontScreenEvent)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)__ldftn(AnalyticsIntegration.Game_OnMenuScreenShown);
			object obj3 = action2 + 16;
			obj3 = this;
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v24 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Game.OnGameDestroyed += action2;
			_subscribedToFrontScreenEvent = false;
		}
	}

	private void OnApplicationQuit()
	{
		_settings.SetDebugDefaults();
		_debugSettings.SetCommonDefaults();
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got VT
		//IL_0108: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj2 = 0;
		if (_manager == null)
		{
			return;
		}
		AnalyticsSettings settings = _settings;
		if (~(settings.Enabled ? 1u : 0u) == 0 && (_sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded))
		{
			if (pauseStatus)
			{
				Game_OnMenuScreenShown();
			}
			else
			{
				DateTime userBirthday = AgeRestriction.GetUserBirthday();
				obj = userBirthday;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBA");
				object obj3 = default;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D66F");
				string tooltip = default;
				((TooltipAttribute)(object)"LeavesForegroundTime")._002Ector(tooltip);
				int incrementedSessionEventNumber = GetIncrementedSessionEventNumber();
				PlayerPrefs.SetString("LeavesForegroundSessionDelta", (string)incrementedSessionEventNumber);
				RenderPipelineManager.CleanupRenderPipeline();
			}
			((CollisionNotifier)(object)_sessionTracker).Awake();
		}
	}

	public void Flush()
	{
		AnalyticsSettings settings = _settings;
		if (~(settings.Enabled ? 1u : 0u) == 0 && (_sampleState == SampleState.SampleKeyIncluded || _sampleState == SampleState.ExplicitIncluded))
		{
			Game_OnPlayerDied(wasPlayerAutoRevived: true);
		}
	}

	private void PostSessionAndForegroundEvents()
	{
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_019d: Expected Obj, but got F4
		//IL_0114: Expected I, but got Obj
		if (_manager == null || (_sampleState != SampleState.SampleKeyIncluded && _sampleState != SampleState.ExplicitIncluded))
		{
			return;
		}
		AnalyticsSettings settings = _settings;
		if (~(settings.FlushEnabled ? 1u : 0u) != 0)
		{
			return;
		}
		AnalyticsManager manager = _manager;
		if (~(manager._validUser ? 1u : 0u) == 0)
		{
			SyboAnalyticsSave.syboAnalyticsPreviousClientVersion = null;
			_hasUnflushedPurchaseEvent = false;
			_manager.FlushInternal();
			return;
		}
		nint num = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v30 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		object obj2 = timeSinceLevelLoad;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		Log.Analytics.LogErrorFormat(0, "[SYBO Analytics] - {0:0.00}s : Attempted to flush events before initializing user ID", args);
	}

	private bool IsTicksSinceLastActiveOverForegroundChangeThreshold(long msTicksSinceLastActive)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	private void PostLeavesForegroundEvent(bool skipTimeThresholdCheck)
	{
		if (skipTimeThresholdCheck)
		{
			PostSessionAndForegroundEvents();
		}
	}

	private int GetIncrementedSessionID()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		object obj = this - -64;
		return obj + 1;
	}

	private int GetSessionID()
	{
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00c6: Expected I8, but got VT
		//IL_0013: Expected I, but got Obj
		int persistedSessionEventNumber = SyboAnalyticsSave.persistedSessionEventNumber;
		int result = (SyboAnalyticsSave.persistedSessionEventNumber = persistedSessionEventNumber + 1);
		nint num2 = (nint)typeof(AnalyticsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime eventTime = AnalyticsEvent.GetEventTime();
		_msTicksAtCurrentSessionStart = (long)eventTime;
		SyboAnalyticsSave.syboAnalyticsGamesSinceFlush = -1;
		return result;
	}

	private int GetSessionDelta()
	{
		return SyboAnalyticsSave.persistedSessionEventNumber;
	}

	private int GetIncrementedSessionEventNumber()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AnalyticsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime eventTime = AnalyticsEvent.GetEventTime();
		object obj2 = eventTime - _msTicksAtCurrentSessionStart;
		return obj2 / 1000;
	}

	private float GetSamplingKey()
	{
		return Time.time;
	}

	private static string GetOperatingSystem()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		IndexOutOfRangeException ex = default;
		object obj = ex + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Guid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<System.Guid>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Guid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v21 (Il2CppClass<System.Guid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ex._002Ector();
		obj = ex;
		_ = ((Exception)ex)._className;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EF7B");
		string result = default;
		return result;
	}

	private static string GetPlatformVendor()
	{
		//IL_00da: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_00ef: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		OperatingSystemFamily operatingSystemFamily = SystemInfo.GetOperatingSystemFamily();
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath == 11;
		bool flag2 = !flag;
		OperatingSystemFamily operatingSystemFamily2 = operatingSystemFamily;
		if (!flag2)
		{
			nint num = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v13 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AnalyticsHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string androidOsVersionFromApiVersion = AnalyticsHelper.GetAndroidOsVersionFromApiVersion((string)operatingSystemFamily);
			operatingSystemFamily2 = (OperatingSystemFamily)androidOsVersionFromApiVersion;
		}
		return (string)operatingSystemFamily2;
	}

	private void PostEvent<T>(T eventData, bool ignoreSampleCheck = false) where T : AnalyticsEvent
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = ignoreSampleCheck;
		object obj2 = this + 12;
		obj2 = eventData;
	}

	private void Game_OnMenuScreenShown()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
		object obj5 = default;
		object obj4 = obj5 << 32;
		object obj7 = default;
		object obj6 = obj7 | obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj9 = default;
		object obj8 = obj9;
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj11 = default;
		if (obj10 == obj11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj13 = default;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj15 = default;
			object obj14 = obj15;
		}
		else
		{
			object obj14 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void Game_OnGameStarted()
	{
		if (~(_waitingToInitialize ? 1u : 0u) == 0)
		{
			UpdateEndpoint();
			_waitingToInitialize = false;
		}
		_isReadyToPostGameEvents = true;
		LogWarningIfWindowsPhone();
	}

	private unsafe void Game_OnRunStarted(bool wasPlayerRevived, bool revivedWithAds, bool adsWasAvailable, bool adsFailed)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00df: Expected I4, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0025: Expected VT, but got I4
		//IL_0025: Expected VT, but got I4
		//IL_0025: Expected VT, but got Obj
		//IL_0025: Expected VT, but got Obj
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 20;
		obj = adsFailed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.AnalyticsIntegration)+C]");
		string text = $"/{(object[])0}/analytics";
		object obj3 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.AnalyticsIntegration)+8]");
		string text2 = string.ConcatArray((string[])0, (int)text);
		obj3 = text2;
		bool flag = Math3D.LinePlaneIntersection(out *(Vector3*)this, (Vector3)"POST", (Vector3)text, (Vector3)adsWasAvailable, (Vector3)1);
		object obj4 = obj2 + 8;
		obj4 = wasPlayerRevived;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	private void Game_OnGameEnded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Expected Obj, but got Unknown
		//IL_136f: Expected Obj, but got I4
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1383: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		object obj6 = default;
		object obj5 = obj6 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		if (~(_isReadyToPostGameEvents ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			object obj7 = default;
			if (_lastSession == (nint)obj7)
			{
				object obj8 = this - -64;
				object obj9 = this - -64;
				object obj10 = obj9 + 1;
				obj8 = obj10;
			}
			else
			{
				object obj11 = this - -64;
				obj11 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj13 = default;
			object obj12 = obj13;
			object obj15 = default;
			object obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj16 = default;
			if (obj14 == obj16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj18 = default;
				object obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj20 = default;
				object obj19 = obj20;
			}
			else
			{
				object obj19 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	private void FlushIfNeeded()
	{
		if (~(_isRunInProgress ? 1u : 0u) == 0)
		{
			HandleNewAbTestTags();
			_isRunInProgress = false;
		}
		LogRunSummary();
	}

	private void LogRunSummary()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_01c1: Expected Obj, but got I4
		if (_sampleState != SampleState.SampleKeyIncluded && _sampleState != SampleState.ExplicitIncluded)
		{
			return;
		}
		AnalyticsSettings settings = _settings;
		bool flag;
		if (settings.GamesInSessionBeforeFirstFlush == -1)
		{
			flag = false;
		}
		else
		{
			AnalyticsSettings settings2 = _settings;
			object obj = this - -64;
			object obj2 = obj + 1;
			if (settings2.GamesInSessionBeforeFirstFlush == (nint)obj2)
			{
				object obj3 = this - -64;
				object obj4 = obj3 + 1;
				flag = (nint)obj4 > 0;
			}
			else
			{
				flag = false;
			}
		}
		AnalyticsSettings settings3 = _settings;
		bool flag2;
		if (settings3.MaxGamesWithoutFlush == -1)
		{
			flag2 = false;
		}
		else
		{
			AnalyticsSettings settings4 = _settings;
			string syboAnalyticsPreviousClientVersion = SyboAnalyticsSave.syboAnalyticsPreviousClientVersion;
			flag2 = settings4.MaxGamesWithoutFlush <= (nint)syboAnalyticsPreviousClientVersion;
		}
		object obj5 = flag2 | flag;
		if (obj5 != null)
		{
			PostSessionAndForegroundEvents();
		}
	}

	private void Game_OnPlayerDied(bool wasPlayerAutoRevived)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_054e: Expected I, but got Obj
		//IL_0564: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_05df: Expected I, but got Obj
		//IL_05f5: Expected Obj, but got I
		//IL_0350: Expected I, but got Obj
		//IL_018b: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I
		//IL_01cc: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(AnalyticsIntegration);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v257 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj6;
		object obj8;
		object obj9 = default;
		if (wasPlayerAutoRevived)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj7 = default;
			obj6 = obj7;
			obj8 = obj9;
		}
		else
		{
			object obj10 = default;
			bool flag;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
				object obj11 = obj9 << 32;
				object obj13 = default;
				object obj12 = obj13 | obj11;
				if ((nint)obj12 > 2000)
				{
					nint num3 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v84 (Il2CppClass<System.Convert>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num4 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v158 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
					object obj15 = obj9 << 32;
					object obj17 = default;
					object obj16 = obj17 | obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj18 = default;
					obj6 = obj18;
					obj8 = obj9;
					goto IL_0581;
				}
			}
			nint num5 = (nint)typeof(AnalyticsIntegration);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v34 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num6 = (nint)typeof(AnalyticsIntegration);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v64 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsIntegration>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj20 = default;
			obj6 = obj20;
			obj8 = obj9;
		}
		goto IL_0581;
		IL_0581:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj21 = default;
		if (obj8 == obj21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj23 = default;
			object obj22 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj25 = default;
			object obj24 = obj25;
		}
		else
		{
			object obj24 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void UIScreenController_OnChangedScreen(string screenName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected Obj, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected Obj, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected Obj, but got Unknown
		//IL_0a98: Expected Obj, but got I4
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected Obj, but got Unknown
		//IL_0aaf: Expected Obj, but got I4
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected Obj, but got Unknown
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 12;
		object obj5 = obj2 + 36;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = 0;
		object obj7 = obj2 + 24;
		obj7 = obj;
		_ = -1;
		if (~(_isReadyToPostGameEvents ? 1u : 0u) != 0)
		{
			return;
		}
		_isRunInProgress = false;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v431 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v93+50]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj14 = default;
		if (obj12 == obj14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj16 = default;
			object obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj18 = default;
			object obj17 = obj18;
		}
		else
		{
			object obj17 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void PurchaseHandler_OnIngameCurrencyPurchaseCompleted(object sender, PurchaseHandler.SyboInGameCurrencyPurchaseEventArgs e)
	{
		//IL_0017: Expected Obj, but got I
		//IL_0017: Expected Obj, but got F4
		float samplingKey = _samplingKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+10]");
		((SafeAnimation.SafeAnimationEventEventArgs)samplingKey)._002Ector((string)0);
		((AggregatedDataTracking)(object)this).PlayerInfo_OnKeysChanged();
	}

	private void InAppManager_OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult)
	{
		//IL_0025: Expected I, but got Obj
		//IL_003b: Expected Obj, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02b3: Expected Obj, but got I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I4
		//IL_02e6: Expected Obj, but got I4
		//IL_02fe: Expected I4, but got Obj
		//IL_00e7: Expected Obj, but got I4
		//IL_0066: Expected I, but got Obj
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I4
		//IL_0357: Expected I8, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_038a: Invalid comparison between I4 and F4
		//IL_021f: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		if (!Directory.IsRootDirectory(productId))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(productId);
		}
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v43 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 8;
		bool flag = Path.SameRoot(productId, "Sybo_Analytics_Buffer.log");
		obj2 = flag;
		object obj3 = this + 12;
		bool flag2 = Path.SameRoot(productId, "Sybo_Analytics_Chunk_{0}.log");
		obj3 = flag2;
		AnalyticsSettings settings = (AnalyticsSettings)((wasRestored ? 1u : 0u) << 10);
		_settings = settings;
		SampleState sampleState = (SampleState)((object)validationResult << 10);
		_sampleState = sampleState;
		object obj4;
		if (_settings == null)
		{
			obj4 = 0;
		}
		else
		{
			bool flag3 = (long)_sampleState == long.MinValue;
			bool flag4 = (nint)_settings == -1;
			object obj5 = flag3 & flag4;
			obj4 = ((obj5 == null) ? ((object)(_sampleState / _settings)) : ((object)0));
		}
		float samplingKey = (float)obj4 + 1f;
		_samplingKey = samplingKey;
		_msTicksAtCurrentSessionStart = 0L;
		bool flag5 = false;
		while ((float)(flag5 ? 1 : 0) < _samplingKey)
		{
			bool writeStream = ((PersistentAnalyticsEventLog)(object)this).GetWriteStream(flag5);
			if (File.GetAttributes((string)writeStream) != 0)
			{
				if ((flag5 ? 1 : 0) != _msTicksAtCurrentSessionStart)
				{
					bool writeStream2 = ((PersistentAnalyticsEventLog)(object)this).GetWriteStream(flag5);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E658");
				}
				long msTicksAtCurrentSessionStart = _msTicksAtCurrentSessionStart + 1;
				_msTicksAtCurrentSessionStart = msTicksAtCurrentSessionStart;
			}
			bool flag6 = (byte)((flag5 ? 1u : 0u) + 1u) != 0;
			flag5 = flag6;
		}
		((PersistentAnalyticsEventLog)(object)this).CloseWriteStream();
		FileAttributes fileAttributes;
		if (_msTicksAtCurrentSessionStart > 0)
		{
			fileAttributes = FileAttributes.ReadOnly;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.AnalyticsIntegration)+8]");
			fileAttributes = File.GetAttributes((string)0);
		}
		Queue<string> menuScreenQueue = (Queue<string>)(fileAttributes & FileAttributes.ReadOnly);
		_menuScreenQueue = menuScreenQueue;
		object obj6 = this + 32;
		RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		obj6 = randomNumberGenerator;
	}

	private void OnRewardConsumablesWithVideo(InAppItemModel.ItemType type, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03a6: Expected Obj, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03da: Expected I, but got Obj
		//IL_03f0: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I4
		//IL_01f2: Expected I8, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 8;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v219 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj7 = default;
		if (obj7 != null)
		{
			object obj8 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [amount @ L2 (InApp.InAppItemModel+ItemType)+28]");
		if ((nint)0 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [amount @ L2 (InApp.InAppItemModel+ItemType)+28]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [amount @ L2 (InApp.InAppItemModel+ItemType)+14]");
				if ((nint)0 == 17)
				{
					object obj9 = amount - -64;
					_cachedMissionSkipPurchaseId = (long)obj9;
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		object obj11 = default;
		if (obj10 == obj11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj13 = default;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj15 = default;
			object obj14 = obj15;
		}
		else
		{
			object obj16 = default;
			object obj14 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private string GetMenusBeforeString(bool excludeLastMenuIfNotPurchaseOrigin)
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_0270: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I4
		//IL_0232: Expected I4, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0084: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		object obj5 = default;
		bool flag2;
		object obj7 = default;
		while (true)
		{
			nint num = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v12 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(AnalyticsHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v52 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<KeyValuePair<string, string>> androidApiVersionByOsVersion = AnalyticsHelper.AndroidApiVersionByOsVersion;
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v9 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.String, System.String>>)+C]");
			bool flag = (nint)obj4 < 0;
			nint num3 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v12 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			flag2 = obj6 == null;
			if (!flag)
			{
				break;
			}
			if (!flag2)
			{
				nint num4 = (nint)typeof(AnalyticsHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v46 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77AA");
			obj = obj2;
			string text = ((string)(object)this).ToLower((CultureInfo)obj);
			if (text != null)
			{
				bool flag3 = excludeLastMenuIfNotPurchaseOrigin;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				if (string.Equals((string)flag3, (string)0))
				{
					return (string)(object)this;
				}
			}
			obj5 = obj7 + 1;
		}
		if (!flag2)
		{
			nint num5 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v30 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnalyticsSettings debugSettings = ((AnalyticsIntegration)excludeLastMenuIfNotPurchaseOrigin).DebugSettings;
		return string.ConcatArray((string[])(object)debugSettings, (int)" fx");
	}

	private bool IsRewardMysteryBox(CelebrationReward reward)
	{
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_023c: Expected I4, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I4
		//IL_02fd: Expected I4, but got Obj
		//IL_031f: Expected I4, but got Obj
		//IL_01a6: Expected I4, but got Obj
		//IL_01a6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector((IEnumerable<string>)_menuScreenQueue);
		if (reward != null && list._size >= 2)
		{
			int index = list._size - 1;
			int index2 = list._size - 2;
			string text = list.get_Item(index2);
			if (!(text != "NotEnoughCurrencyPopup"))
			{
				string text2 = list.get_Item(index);
				if (!(text2 != "CelebrationPopup"))
				{
					goto IL_01f2;
				}
			}
			list.RemoveAt(index);
		}
		goto IL_01f2;
		IL_01f2:
		nint num = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v14 (Il2CppClass<System.Math>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v31 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = list._size - 3;
		bool flag = 0 >= num3;
		bool flag2 = !flag;
		int num4 = num3;
		if (!flag2)
		{
			num4 = 0;
		}
		bool flag3 = (byte)(int)string.Empty != 0;
		while (num4 < list._size)
		{
			bool flag4;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ L0_v5 (System.Boolean)+8]");
				flag4 = (nint)0 == 0;
			}
			else
			{
				flag4 = true;
			}
			bool flag5 = !flag4;
			bool flag6 = !flag5;
			string values = (string)flag3;
			if (!flag6)
			{
				string text3 = string.ConcatArray((string[])flag3, (int)",");
				values = text3;
			}
			string text4 = list.get_Item(num4);
			string text5 = string.ConcatArray((string[])(object)values, (int)text4);
			int num5 = num4 + 1;
			num4 = num5;
			flag3 = (byte)(int)text5 != 0;
		}
		return flag3;
	}

	private void RewardManager_OnMysteryBoxAddedForUnlock(CelebrationReward reward)
	{
		//IL_00af: Expected I4, but got Obj
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		if (_menuScreenLast.get_Chars((int)reward) != '\0')
		{
			Queue<string> menuScreenQueue = _menuScreenQueue;
			if (menuScreenQueue._size != 0)
			{
				Queue<string> menuScreenQueue2 = _menuScreenQueue;
				if (menuScreenQueue2._size > 3)
				{
					string text = _menuScreenQueue.Dequeue();
				}
			}
			_menuScreenQueue.Enqueue((string)(object)reward);
			object obj = this + 76;
			obj = reward;
		}
		if ((string)(object)reward != "FrontScreen" && ~(_hasUnflushedPurchaseEvent ? 1u : 0u) == 0)
		{
			PostSessionAndForegroundEvents();
		}
	}

	private void RewardManager_OnRewardPaidOut(CelebrationReward reward)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_0051: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_0153: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		if (!((SafeAnimation)null).HasAnimationClip((string)(object)reward) || reward.syboAnalyticsSource == ObtainableItemSource.IngameCurrencyPurchase)
		{
			return;
		}
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v24 (Il2CppClass<RewardManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v146 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		nint num3 = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v92 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v133 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void OnDoubleCoinsReceived(CelebrationReward reward)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0307: Expected Obj, but got I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_034c: Expected Obj, but got I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I4
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0396: Expected I, but got Obj
		//IL_03ac: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 52;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		object obj7 = obj2 + 44;
		obj7 = 0;
		object obj8 = obj2 + 40;
		obj8 = 0;
		object obj9 = obj2 + 8;
		obj9 = 0;
		obj2 = 0;
		object obj10 = obj2 + 32;
		obj10 = obj;
		_ = -1;
		nint num = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v146 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj12 = default;
		if (obj12 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v38 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v83 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj14 = default;
		object obj15 = default;
		if (obj14 == obj15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj17 = default;
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj19 = default;
			object obj18 = obj19;
		}
		else
		{
			object obj20 = default;
			object obj18 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void CelebrationPopup_OnRewardDoubleUp(CelebrationReward reward)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02ad: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02e0: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 52;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		object obj7 = obj2 + 44;
		obj7 = 0;
		object obj8 = obj2 + 40;
		obj8 = 0;
		object obj9 = obj2 + 8;
		obj9 = 0;
		obj2 = 0;
		object obj10 = obj2 + 32;
		obj10 = obj;
		_ = -1;
		nint num = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v136 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj16 = default;
		if (obj14 == obj16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj18 = default;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj20 = default;
			object obj19 = obj20;
		}
		else
		{
			object obj19 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void PlayerInfo_OnDailyLetterCoinsRewarded(int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_025a: Expected Obj, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0271: Expected Obj, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02b6: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02e9: Expected I, but got Obj
		//IL_02ff: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 52;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		object obj7 = obj2 + 44;
		obj7 = 0;
		object obj8 = obj2 + 40;
		obj8 = 0;
		object obj9 = obj2 + 8;
		obj9 = 0;
		obj2 = 0;
		object obj10 = obj2 + 32;
		obj10 = obj;
		_ = -1;
		nint num = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v135 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
		obj4 = 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj16 = default;
		if (obj14 == obj16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj18 = default;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj20 = default;
			object obj19 = obj20;
		}
		else
		{
			object obj19 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void OfferWallManager_OnPendingRewardsReceived(int rewardAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_032a: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00ed: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v130 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		nint num3 = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v25 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v64 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private int GetPendingRewardAmount()
	{
		int syboAnalyticsGamesSinceFlush = SyboAnalyticsSave.syboAnalyticsGamesSinceFlush;
		int syboAnalyticsGamesSinceFlush2 = syboAnalyticsGamesSinceFlush + 1;
		SyboAnalyticsSave.syboAnalyticsGamesSinceFlush = syboAnalyticsGamesSinceFlush2;
		return SyboAnalyticsSave.syboAnalyticsGamesSinceFlush;
	}

	private void EarnCoinsData_OnRewardURLOpened(EarnCoinsData.Id id, int coinAmount)
	{
		//IL_0128: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		object obj = 0;
		object obj2 = id - 9;
		if (id != EarnCoinsData.Id.FacebookLogin)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 == 2)
				{
					obj = 7;
				}
			}
			else
			{
				obj = 6;
			}
		}
		else
		{
			obj = 4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void FacebookRewardsPopup_OnFacebookRewardPaidOut(FacebookRewardsInfo.FacebookRewardType rewardType, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		obj3 = rewardType;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj9 = default;
		if (obj7 == obj9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj11 = default;
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj13 = default;
			object obj12 = obj13;
		}
		else
		{
			object obj12 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void FacebookRewardsPopup_OnFacebookCharacterReceived(Characters.CharacterId characterId, int outfitIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03d0: Expected Obj, but got I4
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03fa: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v176 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		obj3 = 9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void FriendHelperCrew_OnFriendCoinsReceived(int coinAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected Obj, but got Unknown
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected Obj, but got Unknown
		//IL_0a89: Expected Obj, but got I4
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected Obj, but got Unknown
		//IL_0aa6: Expected Obj, but got I4
		//IL_0aaf: Expected Obj, but got I4
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 40;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 32;
		obj5 = 0;
		obj2 = 0;
		object obj6 = obj2 + 24;
		obj6 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj8 = default;
		object obj7 = obj8;
		object obj10 = default;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj11 = default;
		if (obj9 == obj11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj13 = default;
			object obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj15 = default;
			object obj14 = obj15;
		}
		else
		{
			object obj14 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void CharacterNameEventManager_OnCharacterSkippedWithKeys(Characters.CharacterId characterId, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_043a: Expected Obj, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_045f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		obj3 = 9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj9 = default;
		if (obj7 == obj9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj11 = default;
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj13 = default;
			object obj12 = obj13;
		}
		else
		{
			object obj12 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void CharacterNameEventManager_OnCharacterSkippedWithVideo(Characters.CharacterId characterId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_032a: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00ed: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v130 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		nint num3 = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v25 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v64 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void PostCharacterSkippedEvent(Characters.CharacterId characterId, ObtainableItemSource sourceType, long sourceId = -1L)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void MissionManager_OnMissionComplete(string message, int missionIndex)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		nint num = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v45 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string itemTitleId = ItemInfo.GetItemTitleId((InAppItemModel.BundleItem)21);
		DateTime startChallengeDateTime = WeeklyHuntData.startChallengeDateTime;
		bool flag = IsRewardMysteryBox((CelebrationReward)1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num3 = (nint)typeof(AnalyticsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(AnalyticsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v41 (Il2CppClass<SYBO.Components.Analytics.Integration.AnalyticsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string androidDeviceOsString = AnalyticsHelper.GetAndroidDeviceOsString((string)6, (string)2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		obj2 = obj;
		object obj5 = obj2 + 16;
		obj5 = obj2;
		throw new ArrayTypeMismatchException();
	}

	private void MissionManager_OnMissionSkipped(bool skippedWithVideo, int missionIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0307: Expected I, but got Obj
		//IL_031d: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_02dc: Expected I8, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<System.Convert>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v134 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		object obj5 = missionIndex + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		_cachedMissionSkipPurchaseId = -1L;
	}

	private void HandleNewAbTestTags()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		if (~(_isReadyToPostGameEvents ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj5 = default;
			object obj4 = obj5;
			object obj7 = default;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj8 = default;
			if (obj6 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj10 = default;
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj12 = default;
				object obj11 = obj12;
			}
			else
			{
				object obj11 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	private void LogWarningIfWindowsPhone()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0347: Expected Obj, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01fb: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		AnalyticsSettings settings = _settings;
		if (~(settings.Enabled ? 1u : 0u) != 0 || (_sampleState != SampleState.SampleKeyIncluded && _sampleState != SampleState.ExplicitIncluded))
		{
			return;
		}
		SampleState syboAnalyticsSampleState = SyboAnalyticsSave.syboAnalyticsSampleState;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj7 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			bool flag = (nint)obj5 == -1;
			object obj8 = obj9 ^ 1;
			object obj10 = flag | obj8;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
		}
		object obj11 = obj6 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj6 + obj13;
		obj14 = 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj6 + obj15;
			if ((nint)obj16 == 96)
			{
				object obj17 = obj6 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_0447;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0447;
		IL_0447:
		SyboAnalyticsSave.SyboAnalyticsClearPendingOffers();
	}

	void IAnalyticsIntegrationTest.SimulateOnlineSettingsDownload()
	{
	}

	void IAnalyticsIntegrationTest.GenerateFakeSessionEvents(int count)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8FD1");
	}

	void ICoroutineHandler.StartCoroutine(IEnumerator coroutine)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		int unrewardedCoins = InventorySave.unrewardedCoins;
		int coins = InventorySave.coins;
		object obj = default;
		SubwayAppEntersForegroundEvent subwayAppEntersForegroundEvent = default;
		object obj2 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<IEnumerator, UIntPtr>(ref coroutine))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			subwayAppEntersForegroundEvent._002Ector();
			((BaseSessionEvent)subwayAppEntersForegroundEvent)._sessionEventID = bragScoreThreshold;
			PostEvent((SubwaySessionStartedEvent)(object)subwayAppEntersForegroundEvent);
			obj = obj2 + 1;
		}
	}

	public AnalyticsIntegration()
	{
		UpdateEventHandlersPostingAnalyticsEvents(subscribe: true);
	}
}
