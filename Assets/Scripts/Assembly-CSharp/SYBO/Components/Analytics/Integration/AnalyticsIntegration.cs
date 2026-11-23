using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using InAppPurchase.Internal;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Common.Components.Singleton;
using SYBO.Components.Analytics.Albatross;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Components.Analytics.Integration;

public class AnalyticsIntegration : Singleton<AnalyticsIntegration>, IAnalyticsIntegrationTest, ICoroutineHandler
{
	public const string PlatformConfig = "android";

	public const string PrefabPath = "Analytics/AnalyticsIntegration";

	public const int DefaultCurrentSession = -1;

	private const int DefaultSessionEventCounter = -1;

	private const long AppEntersForegroundThresholdMsTicks = 2000L;

	private const int MenuScreenHistoryCountTracked = 4;

	private const int MenuScreenHistoryCountReported = 3;

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

	private AnalyticsSettings _settings;

	private float _samplingKey;

	private int _currentSessionEventCounter;

	private bool _useDebugSettings;

	private bool _useDebugSettingsOnce;

	private AnalyticsSettings _debugSettings;

	private bool _usedDebugSettings;

	private long _msTicksAtCurrentSessionStart;

	private AnalyticsManager _manager;

	private long _msTicksWhenLastActive;

	private int _lastSession = -1;

	private int _lastGameIdInSession;

	private bool _isRunInProgress;

	private bool _isReadyToPostGameEvents;

	private bool _hasUnflushedPurchaseEvent;

	private bool _waitingToInitialize;

	private bool _subscribedToGameEvents;

	private bool _subscribedToFrontScreenEvent;

	private bool _subscribedToPurchaseCompletedEvents;

	private string _menuScreenLast;

	private Queue<string> _menuScreenQueue;

	private bool _isApplicationQuitting;

	private static Func<string> _003C_003Ef__mg_0024cache0;

	private static Func<string> _003C_003Ef__mg_0024cache1;

	private static Action<ISubwayBaseEvent> m_OnEventPosted;

	AnalyticsManager IAnalyticsIntegrationTest.Manager => _manager;

	public AnalyticsSettings DebugSettings => _debugSettings;

	private bool IsSupportedOnDevice => true;

	private bool IsPartOfSample
	{
		get
		{
			AnalyticsSettings settings = _settings;
			if (settings.SamplingThreshold > 0f)
			{
				return !(_samplingKey > settings.SamplingThreshold);
			}
			return false;
		}
	}

	private bool IsActive
	{
		get
		{
			AnalyticsSettings settings = _settings;
			if (~(settings.Enabled ? 1u : 0u) != 0)
			{
				return false;
			}
			AnalyticsSettings settings2 = _settings;
			if (settings2.SamplingThreshold > 0f)
			{
				return !(_samplingKey > settings2.SamplingThreshold);
			}
			return false;
		}
	}

	private int GameCountInSession => _lastGameIdInSession + 1;

	public static event Action<ISubwayBaseEvent> OnEventPosted
	{
		add
		{
			Delegate obj = AnalyticsIntegration.m_OnEventPosted;
			Action<ISubwayBaseEvent> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == AnalyticsIntegration.m_OnEventPosted;
				Action<ISubwayBaseEvent> onEventPosted = action;
				if (!flag)
				{
					onEventPosted = AnalyticsIntegration.m_OnEventPosted;
				}
				AnalyticsIntegration.m_OnEventPosted = onEventPosted;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AnalyticsIntegration.m_OnEventPosted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AnalyticsIntegration.m_OnEventPosted;
			Action<ISubwayBaseEvent> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == AnalyticsIntegration.m_OnEventPosted;
				Action<ISubwayBaseEvent> onEventPosted = action;
				if (!flag)
				{
					onEventPosted = AnalyticsIntegration.m_OnEventPosted;
				}
				AnalyticsIntegration.m_OnEventPosted = onEventPosted;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AnalyticsIntegration.m_OnEventPosted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private unsafe void Start()
	{
		if (Application.isPlaying)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			float analyticsSamplingKey = instance.AnalyticsSamplingKey;
			_samplingKey = analyticsSamplingKey;
			InitializeFromSettings();
			OnlineSettings instance2 = OnlineSettings.instance;
			throw new ArgumentException();
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(AnalyticsIntegration.UIScreenController_OnAwake));
		UIScreenController.OnAwake += action;
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(AnalyticsIntegration.BackBtnBehaviour_OnInitiatingQuit));
		BackBtnBehaviour.OnInitiatingQuit += eventHandler;
	}

	private unsafe void UIScreenController_OnAwake()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(AnalyticsIntegration.UIScreenController_OnAwake));
		UIScreenController.OnAwake -= action;
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void BackBtnBehaviour_OnInitiatingQuit(object sender, EventArgs args)
	{
		_isApplicationQuitting = true;
	}

	protected void OnApplicationQuit()
	{
		_isApplicationQuitting = true;
	}

	protected override void OnDestroy()
	{
		UpdateGameEventHandlers(subscribe: false);
		if (_manager != null)
		{
			_manager.Shutdown();
		}
		throw new ArrayTypeMismatchException();
	}

	private void OnlineSettings_OnDownloaded(bool success)
	{
		//IL_006c: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected I4, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		if (!success)
		{
			return;
		}
		object obj;
		if (Game.IsInstantiated)
		{
			Game instance = Game.Instance;
			Variable<bool> isInGame = instance.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0)
			{
				if (~(_waitingToInitialize ? 1u : 0u) == 0)
				{
					obj = 1;
				}
				else
				{
					UpdateFrontScreenHandler(subscribe: true);
					obj = 1;
				}
				goto IL_00b1;
			}
		}
		InitializeFromSettings();
		obj = 0;
		goto IL_00b1;
		IL_00b1:
		bool waitingToInitialize = (byte)((_waitingToInitialize | obj) ? 1 : 0) != 0;
		_waitingToInitialize = waitingToInitialize;
	}

	private void InitializeSettings()
	{
		if (~(_useDebugSettingsOnce ? 1u : 0u) == 0)
		{
		}
		AnalyticsSettings settings = _settings;
		OnlineSettings instance = OnlineSettings.instance;
		bool value = instance.GetValue("sybo_analytics_enabled", defaultValue: false);
		settings.Enabled = value;
		AnalyticsSettings settings2 = _settings;
		OnlineSettings instance2 = OnlineSettings.instance;
		bool value2 = instance2.GetValue("sybo_analytics_flush_enabled", defaultValue: true);
		settings2.FlushEnabled = value2;
		AnalyticsSettings settings3 = _settings;
		OnlineSettings instance3 = OnlineSettings.instance;
		float value3 = instance3.GetValue("sybo_analytics_sampling_threshold", 0f);
		settings3.SamplingThreshold = value3;
		AnalyticsSettings settings4 = _settings;
		OnlineSettings instance4 = OnlineSettings.instance;
		string value4 = instance4.GetValue("sybo_analytics_endpoint_baseurl", null);
		settings4.BaseURL = value4;
		AnalyticsSettings settings5 = _settings;
		OnlineSettings instance5 = OnlineSettings.instance;
		int value5 = instance5.GetValue("sybo_analytics_max_games_without_flush", 10);
		settings5.MaxGamesWithoutFlush = value5;
		AnalyticsSettings settings6 = _settings;
		OnlineSettings instance6 = OnlineSettings.instance;
		int value6 = instance6.GetValue("sybo_analytics_games_in_session_before_first_flush", 1);
		settings6.GamesInSessionBeforeFirstFlush = value6;
	}

	private void InitializeFromSettings()
	{
		//IL_0482: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I4
		AnalyticsSettings settings = _settings;
		bool flag;
		if (~(settings.Enabled ? 1u : 0u) == 0)
		{
			AnalyticsSettings settings2 = _settings;
			flag = settings2.SamplingThreshold > 0f && !(_samplingKey > settings2.SamplingThreshold);
		}
		else
		{
			flag = false;
		}
		InitializeSettings();
		bool flag2 = !flag;
		bool flag3 = !flag2;
		bool flag4 = false;
		if (!flag3)
		{
			AnalyticsSettings settings3 = _settings;
			bool flag5;
			if (~(settings3.Enabled ? 1u : 0u) == 0)
			{
				AnalyticsSettings settings4 = _settings;
				flag5 = settings4.SamplingThreshold > 0f && !(_samplingKey > settings4.SamplingThreshold);
			}
			else
			{
				flag5 = false;
			}
			flag4 = flag5;
		}
		AnalyticsSettings settings5 = _settings;
		bool flag6;
		if (~(settings5.Enabled ? 1u : 0u) == 0)
		{
			AnalyticsSettings settings6 = _settings;
			flag6 = settings6.SamplingThreshold > 0f && !(_samplingKey > settings6.SamplingThreshold);
		}
		else
		{
			flag6 = false;
		}
		object obj = flag6 ^ flag;
		AnalyticsSettings settings7 = _settings;
		AnalyticsManager manager2;
		if (~(settings7.Enabled ? 1u : 0u) == 0)
		{
			AnalyticsManager manager = _manager;
			if (_manager != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				AnalyticsSettings settings8 = _settings;
				string text = default;
				if (text != settings8.BaseURL)
				{
					UpdateEndpoint();
				}
				manager2 = _manager;
				if (_manager != null)
				{
					goto IL_03c0;
				}
			}
			if (HasUserInPlayerInfo())
			{
				AnalyticsSettings settings9 = _settings;
				if (!(settings9.SamplingThreshold > 0f) || _samplingKey > settings9.SamplingThreshold)
				{
					manager2 = _manager;
					goto IL_03c0;
				}
			}
			InitializeManager();
		}
		goto IL_02bb;
		IL_02bb:
		if (obj != null)
		{
			long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
			_msTicksWhenLastActive = msTicksSinceDeviceStartup;
		}
		AnalyticsSettings settings10 = _settings;
		bool subscribe;
		if (~(settings10.Enabled ? 1u : 0u) == 0)
		{
			AnalyticsSettings settings11 = _settings;
			subscribe = settings11.SamplingThreshold > 0f && !(_samplingKey > settings11.SamplingThreshold);
		}
		else
		{
			subscribe = false;
		}
		UpdateGameEventHandlers(subscribe);
		return;
		IL_03c0:
		bool flag7 = manager2 != null;
		object obj2 = flag4 & flag7;
		if (obj2 != null)
		{
			PostSessionAndForegroundEvents();
		}
		goto IL_02bb;
	}

	private bool HasUserInPlayerInfo()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		//IL_000e: Expected Obj, but got I4
		PlayerInfo instance = PlayerInfo.Instance;
		string syboAnalyticsUserId = instance._syboAnalyticsUserId;
		object obj;
		if (instance._syboAnalyticsUserId != null)
		{
			obj = 0;
			if (syboAnalyticsUserId._stringLength != 0)
			{
				goto IL_0067;
			}
		}
		obj = 1;
		goto IL_0067;
		IL_0067:
		return (byte)(obj ^ 1) != 0;
	}

	private void UpdateEndpoint()
	{
		AnalyticsManager manager = _manager;
		PostAnalyticsProvider postAnalyticsProvider = CreatePostAnalyticsProvider();
		manager.Endpoint__BackingField = postAnalyticsProvider;
	}

	private PostAnalyticsProvider CreatePostAnalyticsProvider()
	{
		AnalyticsSettings settings = _settings;
		_ = settings.WebRequestTimeoutSeconds;
		AnalyticsSettings settings2 = _settings;
		PostAnalyticsProvider postAnalyticsProvider = default;
		PostAnalyticsProvider.IHTTPPostLayer httpLayer = default;
		postAnalyticsProvider._002Ector(settings2.BaseURL, settings2.ApplicationID, settings2.ApiVersion, settings2.UserAgentString, settings2.Key, httpLayer);
		return postAnalyticsProvider;
	}

	private unsafe void UpdateGameEventHandlers(bool subscribe)
	{
		UpdateFrontScreenHandler(subscribe);
		UpdatePurchaseHandler(subscribe);
		if (subscribe)
		{
			if (!_subscribedToGameEvents)
			{
				Action action = default;
				action._002Ector(this, (nint)__ldftn(AnalyticsIntegration.Game_OnGameStarted));
				Game.OnGameStarted += action;
				throw new ArgumentException();
			}
		}
		else if (~(_subscribedToGameEvents ? 1u : 0u) == 0)
		{
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(AnalyticsIntegration.Game_OnGameStarted));
			Game.OnGameStarted -= action2;
			throw new ArgumentException();
		}
	}

	private void UpdatePurchaseHandler(bool subscribe)
	{
		if (subscribe)
		{
			if (!_subscribedToPurchaseCompletedEvents)
			{
				PurchaseHandler instance = PurchaseHandler.Instance;
				throw new ArgumentException();
			}
		}
		else if (~(_subscribedToPurchaseCompletedEvents ? 1u : 0u) == 0)
		{
			PurchaseHandler instance2 = PurchaseHandler.Instance;
			throw new ArgumentException();
		}
	}

	private unsafe void UpdateFrontScreenHandler(bool subscribe)
	{
		bool subscribedToFrontScreenEvent;
		if (subscribe)
		{
			if (_subscribedToFrontScreenEvent)
			{
				return;
			}
			Action action = default;
			action._002Ector(this, (nint)__ldftn(AnalyticsIntegration.Game_OnMenuScreenShown));
			Game.OnMenuScreenShown += action;
			subscribedToFrontScreenEvent = true;
		}
		else
		{
			if (~(_subscribedToFrontScreenEvent ? 1u : 0u) != 0)
			{
				return;
			}
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(AnalyticsIntegration.Game_OnMenuScreenShown));
			Game.OnMenuScreenShown -= action2;
			subscribedToFrontScreenEvent = false;
		}
		_subscribedToFrontScreenEvent = subscribedToFrontScreenEvent;
	}

	private void InitializeManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		if (_manager == null)
		{
			throw new ArgumentException();
		}
	}

	private string GetUserAgentString()
	{
		string bundleVersion = DeviceUtility.GetBundleVersion();
		string[] array = bundleVersion.Split('.');
		string text = array[0].PadLeft(2, '0');
		string text2 = array[1].PadLeft(2, '0');
		string text3 = array[2].PadLeft(2, '0');
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AnalyticsSettings settings = _settings;
		throw new ArrayTypeMismatchException();
	}

	private string GetDeviceID()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		string deviceIdentifier = DeviceUtility.GetDeviceIdentifier();
		object obj3;
		if (deviceIdentifier != null)
		{
			obj3 = 0;
			if (deviceIdentifier._stringLength != 0)
			{
				goto IL_035c;
			}
		}
		obj3 = 1;
		goto IL_035c;
		IL_0286:
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		goto IL_02a3;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag = obj5 != obj6;
		object obj8 = default;
		object obj7 = obj8;
		string result;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			result = null;
			if (!flag2)
			{
				goto IL_0286;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj9 = default;
			obj7 = obj9;
		}
		_ = 0;
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		string result2 = default;
		return result2;
		IL_035c:
		bool flag3 = obj3 == null;
		bool flag4 = !flag3;
		result = null;
		if (!flag4)
		{
			SHA256Managed sHA256Managed = default;
			sHA256Managed._002Ector();
			object obj11 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							string text = default;
							result = text;
							if (!flag5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_01f2;
							}
							goto IL_0286;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01f2;
		}
		goto IL_02a3;
		IL_02a3:
		return result;
	}

	private void OnValidate()
	{
		_settings.SetDefaults();
	}

	private void Reset()
	{
		_settings.SetDefaults();
		_debugSettings.SetDebugDefaults();
	}

	private void OnApplicationFocus(bool focusStatus)
	{
		if (_manager == null)
		{
			return;
		}
		AnalyticsSettings settings = _settings;
		bool flag;
		if (~(settings.Enabled ? 1u : 0u) == 0)
		{
			AnalyticsSettings settings2 = _settings;
			flag = settings2.SamplingThreshold > 0f && !(_samplingKey > settings2.SamplingThreshold);
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			if (focusStatus)
			{
				PostSessionAndForegroundEvents();
			}
			long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
			_msTicksWhenLastActive = msTicksSinceDeviceStartup;
		}
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		if (pauseStatus)
		{
			Flush();
		}
	}

	public void Flush()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		AnalyticsManager manager = _manager;
		if (_manager == null)
		{
			return;
		}
		AnalyticsSettings settings = _settings;
		if (!(settings.SamplingThreshold > 0f) || _samplingKey > settings.SamplingThreshold)
		{
			return;
		}
		AnalyticsSettings settings2 = _settings;
		if (~(settings2.FlushEnabled ? 1u : 0u) == 0 && !_isApplicationQuitting)
		{
			if (~(manager._validUser ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				float time = Time.time;
				object obj3 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				throw new ArrayTypeMismatchException();
			}
			PlayerInfo instance = PlayerInfo.Instance;
			instance._dirty = true;
			instance._syboAnalyticsGamesSinceFlush = 0;
			_hasUnflushedPurchaseEvent = false;
			_manager.Flush();
		}
	}

	private void PostSessionAndForegroundEvents()
	{
		//IL_017e: Expected Obj, but got I8
		//IL_019b: Expected Obj, but got I4
		//IL_00c6: Expected I8, but got I4
		//IL_00ee: Expected I8, but got I4
		//IL_0116: Expected I8, but got I4
		long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
		object obj = msTicksSinceDeviceStartup - _msTicksWhenLastActive;
		AnalyticsSettings settings = _settings;
		object obj2 = settings.SessionTimeoutSeconds * 1000;
		if (Game.IsInstantiated)
		{
			Game instance = Game.Instance;
			Variable<bool> isInGame = instance.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v43 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 == 0 && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				goto IL_0098;
			}
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			goto IL_0098;
		}
		if ((nint)obj >= 2001)
		{
			SubwayAppEntersForegroundEvent subwayAppEntersForegroundEvent = default;
			subwayAppEntersForegroundEvent._002Ector();
			throw new ArrayTypeMismatchException();
		}
		return;
		IL_0098:
		SubwaySessionStartedEvent subwaySessionStartedEvent = default;
		subwaySessionStartedEvent._002Ector();
		PlayerInfo instance2 = PlayerInfo.Instance;
		subwaySessionStartedEvent.HighScore = instance2._highScore;
		PlayerInfo instance3 = PlayerInfo.Instance;
		int amountOfCoins = instance3.amountOfCoins;
		subwaySessionStartedEvent.CoinBalance = amountOfCoins;
		PlayerInfo instance4 = PlayerInfo.Instance;
		int amountOfKeys = instance4.amountOfKeys;
		subwaySessionStartedEvent.KeyBalance = amountOfKeys;
		throw new ArrayTypeMismatchException();
	}

	private int GetIncrementedSessionID()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int num = instance._syboAnalyticsCurrentSession + 1;
		instance._dirty = true;
		instance._syboAnalyticsCurrentSession = num;
		long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
		_currentSessionEventCounter = -1;
		_msTicksAtCurrentSessionStart = msTicksSinceDeviceStartup;
		return num;
	}

	private int GetSessionID()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance._syboAnalyticsCurrentSession;
	}

	private int GetSessionDelta()
	{
		//IL_001d: Expected Obj, but got I8
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
		object obj = msTicksSinceDeviceStartup - _msTicksAtCurrentSessionStart;
		return obj / 1000;
	}

	private int GetIncrementedSessionEventNumber()
	{
		return ++_currentSessionEventCounter;
	}

	private float GetSamplingKey()
	{
		return _samplingKey;
	}

	private string GetKilooUserID()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance.FlurryUserId;
	}

	private static string GetOperatingSystem()
	{
		string text = SystemInfo.GetOperatingSystem();
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			text = AnalyticsHelper.GetAndroidDeviceOsString(text);
		}
		return text;
	}

	private static string GetPlatformVendor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			return "google";
		}
		RuntimePlatform platform2 = Application.platform;
		if (platform2 == RuntimePlatform.IPhonePlayer)
		{
			return "apple";
		}
		RuntimePlatform platform3 = Application.platform;
		if (platform3 != RuntimePlatform.MetroPlayerARM)
		{
			RuntimePlatform platform4 = Application.platform;
			if (platform4 != RuntimePlatform.MetroPlayerX86)
			{
				RuntimePlatform platform5 = Application.platform;
				if (platform5 != RuntimePlatform.MetroPlayerX64)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					float time = Time.time;
					object obj3 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					throw new ArrayTypeMismatchException();
				}
			}
		}
		return "microsoft";
	}

	private void PostEvent<T>(T eventData, bool ignoreSampleCheck = false) where T : AnalyticsEvent
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_01bd: Expected VT, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_01dd: Expected VT, but got I
		//IL_01e9: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		AnalyticsManager manager = _manager;
		if (~(manager._validUser ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			float time = Time.time;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		bool flag;
		if (ignoreSampleCheck)
		{
			flag = true;
		}
		else
		{
			AnalyticsSettings settings = _settings;
			flag = settings.SamplingThreshold > 0f && !(_samplingKey > settings.SamplingThreshold);
		}
		AnalyticsSettings settings2 = _settings;
		object obj4 = flag & settings2.Enabled;
		if (obj4 != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S3_v9 (Il2CppMethodRgctx<SYBO.Components.Analytics.Integration.AnalyticsIntegration::PostEvent>)+4]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S3_v10+4] (should have been resolved before IL gen)");
			if (AnalyticsIntegration.m_OnEventPosted != null)
			{
				Action<ISubwayBaseEvent> onEventPosted = AnalyticsIntegration.m_OnEventPosted;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S0_v30 (System.Action`1<SYBO.Components.Analytics.Integration.ISubwayBaseEvent>)+C] (should have been resolved before IL gen)");
			}
		}
		bool hasUnflushedPurchaseEvent = default;
		if (~(_hasUnflushedPurchaseEvent ? 1u : 0u) == 0)
		{
			hasUnflushedPurchaseEvent = true;
		}
		else
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SubwayPurchaseEvent));
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v6 (Il2CppMethodRgctx<SYBO.Components.Analytics.Integration.AnalyticsIntegration::PostEvent>)+8]");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			nint num4 = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ S3_v6 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		}
		_hasUnflushedPurchaseEvent = hasUnflushedPurchaseEvent;
	}

	private void Game_OnMenuScreenShown()
	{
		if (~(_waitingToInitialize ? 1u : 0u) == 0)
		{
			InitializeFromSettings();
			_waitingToInitialize = false;
		}
		_isReadyToPostGameEvents = true;
	}

	private void Game_OnGameStarted()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I4
		//IL_063d: Expected Obj, but got I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_0663: Expected Obj, but got I4
		//IL_0671: Expected Obj, but got I4
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I4
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		int syboAnalyticsGamesSinceFlush = instance._syboAnalyticsGamesSinceFlush + 1;
		instance._dirty = true;
		instance._syboAnalyticsGamesSinceFlush = syboAnalyticsGamesSinceFlush;
		if (~(_isReadyToPostGameEvents ? 1u : 0u) != 0)
		{
			return;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		PlayerInfo instance3 = PlayerInfo.Instance;
		int lastGameIdInSession = ((_lastSession == instance3._syboAnalyticsCurrentSession) ? (_lastGameIdInSession + 1) : 0);
		_lastGameIdInSession = lastGameIdInSession;
		PlayerInfo instance4 = PlayerInfo.Instance;
		_lastSession = instance4._syboAnalyticsCurrentSession;
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterType)instance2._currentCharacter);
		int currentThemeIndex = instance2.currentThemeIndex;
		CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter((Characters.CharacterType)instance2._currentCharacter, currentThemeIndex);
		if (themeForCharacter != null)
		{
			string text = Strings.Get(themeForCharacter.title);
		}
		Hoverboards.Board board = Hoverboards.boardData.get_Item(instance2._currentHoverboard);
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.TryGetCustomThemesForBoard(instance2._currentHoverboard);
		bool flag = list == null;
		object obj3 = 0;
		if (!flag)
		{
			object obj4 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj5 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			obj3 = 0;
			object obj7 = default;
			object obj9 = default;
			object obj12 = default;
			object obj13 = default;
			object obj15 = default;
			object obj16 = default;
			object obj18 = default;
			object obj10 = default;
			object obj19 = default;
			object obj20 = default;
			object obj21 = default;
			object obj22 = default;
			while (true)
			{
				_ = 0;
				object obj6 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj11;
				if ((nint)0 != 1)
				{
					if (obj7 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj8 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj9 == null)
									{
										continue;
									}
									if (obj10 == null)
									{
										obj11 = 0;
									}
									else
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											goto IL_04fd;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 == 1;
										obj11 = obj12;
										if (flag2)
										{
											goto IL_0514;
										}
										obj3 = obj13;
										obj11 = obj12;
									}
									_ = -1;
									_ = typeof(Hoverboard.BoardAbility);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v143+24]");
									_ = 0;
									_ = 0;
									object obj14 = obj + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														obj10 = obj15;
														obj3 = obj16;
														continue;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													obj10 = obj15;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													obj10 = obj15;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												obj10 = obj15;
											}
											goto IL_04fd;
										}
									}
									goto IL_0514;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_04fd;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_04fd;
				IL_04fd:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj17 = obj18;
				goto IL_053d;
				IL_0514:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj11;
				obj17 = obj19;
				goto IL_053d;
				IL_053d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj20 == obj21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj17 = obj22;
				}
				_ = 0;
				object obj23 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
			object obj24 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237B");
		_ = _lastGameIdInSession;
		string text2 = Strings.Get(model.name);
		string text3 = Strings.Get(board.name);
		object obj25 = instance2._currentMissionSet + 1;
		if ((nint)obj25 >= 30)
		{
			obj25 = 30;
		}
		if ((nint)obj25 <= 1)
		{
			obj25 = 1;
		}
		_ = instance2._highScore;
		int amountOfCoins = instance2.amountOfCoins;
		int amountOfKeys = instance2.amountOfKeys;
		int upgradeAmount = instance2.GetUpgradeAmount(PowerupType.hoverboard);
		int upgradeAmount2 = instance2.GetUpgradeAmount(PowerupType.headstart2000);
		int upgradeAmount3 = instance2.GetUpgradeAmount(PowerupType.scorebooster);
		throw new ArrayTypeMismatchException();
	}

	private void Game_OnRunStarted(bool wasPlayerRevived)
	{
		//IL_0044: Expected Obj, but got I4
		_isRunInProgress = true;
		object obj = _isReadyToPostGameEvents & wasPlayerRevived;
		if (obj != null)
		{
			GameContinuedEvent gameContinuedEvent = default;
			gameContinuedEvent._002Ector(_lastGameIdInSession, autoRevived: false);
			throw new ArrayTypeMismatchException();
		}
	}

	private void Game_OnGameEnded()
	{
		if (~(_isRunInProgress ? 1u : 0u) == 0)
		{
			LogRunSummary();
			_isRunInProgress = false;
		}
		FlushIfNeeded();
	}

	private void FlushIfNeeded()
	{
		//IL_0075: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		AnalyticsSettings settings = _settings;
		if (!(settings.SamplingThreshold > 0f) || _samplingKey > settings.SamplingThreshold)
		{
			return;
		}
		AnalyticsSettings settings2 = _settings;
		bool flag = settings2.GamesInSessionBeforeFirstFlush == -1;
		bool flag2 = false;
		if (!flag)
		{
			object obj = _lastGameIdInSession + 1;
			bool flag3 = settings2.GamesInSessionBeforeFirstFlush != (nint)obj;
			flag2 = false;
			if (!flag3)
			{
				object obj2 = _lastGameIdInSession + 1;
				bool flag4 = (nint)obj2 > 0;
				flag2 = flag4;
			}
		}
		AnalyticsSettings settings3 = _settings;
		bool flag6;
		if (settings3.MaxGamesWithoutFlush != -1)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			bool flag5 = settings3.MaxGamesWithoutFlush <= instance._syboAnalyticsGamesSinceFlush;
			flag6 = flag5 | flag2;
		}
		else
		{
			flag6 = flag2;
		}
		if (flag6)
		{
			Flush();
		}
	}

	private void LogRunSummary()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(_isReadyToPostGameEvents ? 1u : 0u) == 0)
		{
			GameStats instance = GameStats.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237B");
			_ = _lastGameIdInSession;
			_ = instance._score;
			int powerupActivationCountLastRun = instance.GetPowerupActivationCountLastRun(PowerupType.hoverboard);
			int mysteryPowerupActivationCountLastRun = instance.GetMysteryPowerupActivationCountLastRun(PowerupType.hoverboard);
			object obj3 = powerupActivationCountLastRun - mysteryPowerupActivationCountLastRun;
			if ((nint)obj3 >= 0)
			{
				object obj4 = obj3 << 16;
				object obj5 = obj4 >> 16;
				int powerupActivationCountLastRun2 = instance.GetPowerupActivationCountLastRun(PowerupType.headstart);
				_ = instance._doubleMultiplierPickupsCollectedRun;
				int pickupCountSpawnedLastRun = instance.GetPickupCountSpawnedLastRun(PickupType.MultiplierScore2x);
				_ = instance._scoreBoosterTierRun;
				int coinsCollectedRun = instance.CoinsCollectedRun;
				_ = instance._coinsCollectedRawRun;
				_ = instance._coinsSpawnedRun;
				_ = instance._coinMagnetPickupsCollectedRun;
				int pickupCountSpawnedLastRun2 = instance.GetPickupCountSpawnedLastRun(PickupType.CoinMagnet);
				_ = instance._jetpackPickupsCollectedRun;
				int pickupCountSpawnedLastRun3 = instance.GetPickupCountSpawnedLastRun(PickupType.JetPack);
				_ = instance._superSneakerPickupsCollectedRun;
				int pickupCountSpawnedLastRun4 = instance.GetPickupCountSpawnedLastRun(PickupType.SuperSneakers);
				_ = instance._mysteryBoxPickupsCollectedRun;
				int pickupCountSpawnedLastRun5 = instance.GetPickupCountSpawnedLastRun(PickupType.MysteryBox);
				_ = instance._superMysteryBoxPickupsCollectedRun;
				int pickupCountSpawnedLastRun6 = instance.GetPickupCountSpawnedLastRun(PickupType.SuperMysteryBox);
				_ = instance._keyPickupsCollectedRun;
				int pickupCountSpawnedLastRun7 = instance.GetPickupCountSpawnedLastRun(PickupType.Key);
				_ = instance._dailyLetterPickupsCollectedRun;
				int pickupCountSpawnedLastRun8 = instance.GetPickupCountSpawnedLastRun(PickupType.LetterHuntDaily);
				_ = instance._characterLetterPickupsCollectedRun;
				int pickupCountSpawnedLastRun9 = instance.GetPickupCountSpawnedLastRun(PickupType.LetterHuntCharacter);
				_ = instance._huntTokensCollectedRun;
				int pickupCountSpawnedLastRun10 = instance.GetPickupCountSpawnedLastRun(PickupType.TokenHunt);
				_ = instance._pogoStickPickupsCollectedRun;
				int pickupCountSpawnedLastRun11 = instance.GetPickupCountSpawnedLastRun(PickupType.PogoStick);
				int pickupCountSpawnedLastRun12 = instance.GetPickupCountSpawnedLastRun(PickupType.MysteryPowerup);
				int mysteryPowerupActivationCountLastRun2 = instance.GetMysteryPowerupActivationCountLastRun(PowerupType.hoverboard);
				int mysteryPowerupActivationCountLastRun3 = instance.GetMysteryPowerupActivationCountLastRun(PowerupType.doubleCoinsMysteryPowerup);
				int mysteryPowerupActivationCountLastRun4 = instance.GetMysteryPowerupActivationCountLastRun(PowerupType.doubleJump);
				int mysteryPowerupActivationCountLastRun5 = instance.GetMysteryPowerupActivationCountLastRun(PowerupType.plusMultiplier);
				_ = instance._stumblesRun;
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj6 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	private void Game_OnPlayerDied(bool wasPlayerAutoRevived)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Expected VT, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_00b9: Expected F8, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_00f8: Expected F8, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected VT, but got Unknown
		//IL_010d: Expected Obj, but got I
		//IL_0151: Expected F8, but got I
		//IL_0162: Expected F8, but got I
		//IL_012f: Expected Obj, but got I
		//IL_01a0: Expected F8, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		if (~(_isReadyToPostGameEvents ? 1u : 0u) == 0)
		{
			_isRunInProgress = false;
			Game instance = Game.Instance;
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v22 (T)+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237B");
			_ = _lastGameIdInSession;
			double num = instance._elapsedRunDuration;
			double num2 = Math.Abs((double)instance._elapsedRunDuration);
			if (!(num2 < 2147483648.0))
			{
				num = -2147483648.0;
			}
			Character character = instance._character;
			Enum obj4 = (Enum)(obj + 56);
			_ = -1;
			obj4 = (Enum)(object)typeof(Character.DeathCause);
			_ = character.LastDeathCause;
			string text = obj4.ToString();
			Character character2 = instance._character;
			_ = character2._lastObstacleType;
			Enum obj5 = (Enum)(obj + 40);
			_ = -1;
			obj5 = (Enum)(object)typeof(Character.ObstacleType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			_ = 0;
			string text2 = obj5.ToString();
			double num3 = instance.SpeedAtLastObstacleHit;
			double num4 = Math.Abs((double)instance.SpeedAtLastObstacleHit);
			if (!(num4 < 2147483648.0))
			{
				num3 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v43+4C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+8]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v90+4C]");
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+10]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+10]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v87+4C]");
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+C]");
			Transform transform = ((Component)0).transform;
			Vector3 currentTransformPosition = instance._character.CurrentTransformPosition;
			object obj9 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Vector3 position = (Vector3)(obj + 8);
			Vector3 vector = transform.InverseTransformPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			double num5 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			double num6 = Math.Abs(0.0);
			if (!(num6 < 2147483648.0))
			{
				num5 = -2147483648.0;
			}
			Character character3 = instance._character;
			bool flag = character3.__trackIndex == 2;
			object obj10 = 4;
			if (!flag)
			{
				obj10 = 2;
			}
			if (character3.__trackIndex == 0)
			{
				obj10 = 1;
			}
			Enum obj11 = (Enum)(obj + 56);
			_ = -1;
			obj11 = (Enum)(object)typeof(TrackLane);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			string text3 = obj11.ToString();
			throw new ArrayTypeMismatchException();
		}
	}

	private void UIScreenController_OnChangedScreen(string screenName)
	{
		if (_menuScreenLast != screenName)
		{
			Queue<string> menuScreenQueue = _menuScreenQueue;
			if (menuScreenQueue._size != 0)
			{
				Queue<string> menuScreenQueue2 = _menuScreenQueue;
				if (menuScreenQueue2._size >= 4)
				{
					string text = _menuScreenQueue.Dequeue();
				}
			}
			_menuScreenQueue.Enqueue(screenName);
			_menuScreenLast = screenName;
		}
		if (screenName == "FrontUI" && ~(_hasUnflushedPurchaseEvent ? 1u : 0u) == 0)
		{
			Flush();
		}
	}

	private void PurchaseHandler_OnIngameCurrencyPurchaseCompleted(object sender, PurchaseHandler.SyboInGameCurrencyPurchaseEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I
		//IL_01c5: Expected I8, but got I
		//IL_01c5: Expected I8, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01c5: Expected I8, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected VT, but got Unknown
		//IL_00cb: Expected I8, but got I
		//IL_011c: Expected I8, but got I
		//IL_011c: Expected I8, but got I
		//IL_011c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		object obj3 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Game instance = Game.Instance;
		Variable<bool> isInGame = instance.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			_ = 1;
			_ = _lastGameIdInSession;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+28]");
		object obj4 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+28]");
		if ((nint)0 != 1)
		{
			if ((nint)obj4 != 1)
			{
				return;
			}
			string menusBeforeString = GetMenusBeforeString(excludeLastMenuIfNotPurchaseOrigin: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			int? gameNumberOrNull = (int?)(object)(obj + 8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+38]");
			long currencyDelta = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+14]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+2C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+30]");
			SubwayIngameCurrencyPurchaseEvent subwayIngameCurrencyPurchaseEvent = default;
			subwayIngameCurrencyPurchaseEvent._002Ector((string)num, (InAppItemModel.ItemType)num2, num3, menusBeforeString, gameNumberOrNull, (InGameCurrencyType)num4, currencyDelta, 0L);
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+10]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+14]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+18]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L2 (System.Object)+20]");
		SubwayItemAddedEvent subwayItemAddedEvent = default;
		subwayItemAddedEvent._002Ector(ObtainableItemSource.FreeUnlock, -1L, (string)num5, (InAppItemModel.ItemType)num6, num7, 0L);
		throw new ArrayTypeMismatchException();
	}

	private unsafe void InAppManager_OnPurchaseSuccess(string productId, bool wasRestored)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0908: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Ref, but got Unknown
		//IL_00da: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0947: Expected Obj, but got I
		//IL_01fb: Expected VT, but got I
		//IL_0243: Expected Obj, but got I
		object obj = default;
		int? num = (int?)(object)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj2 = (Nullable)num - -64;
		obj2 = 0;
		_ = 0;
		_ = 0;
		if (!PurchaseValidationExtensions.WasPreviousPurchaseValid || wasRestored)
		{
			return;
		}
		if (!InAppData.inAppData.TryGetValue(productId, out *(InAppItemModel*)((Nullable)num + 92)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		ref string itemTitleId = ref *(string*)((Nullable)num + 88);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<System.Int32>)+5C]");
		if (!PurchaseHandler.TryGetItemTitleId((InAppItemModel)0, out itemTitleId))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		string menusBeforeString = GetMenusBeforeString(excludeLastMenuIfNotPurchaseOrigin: true);
		object obj3 = (Nullable)num + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		if (Game.IsInstantiated)
		{
			Game instance = Game.Instance;
			Variable<bool> isInGame = instance.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v284 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0)
			{
				_ = 1;
				_ = _lastGameIdInSession;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<System.Int32>)+5C]");
		object obj4 = 0;
		PlayerInfo instance2 = PlayerInfo.Instance;
		string platformVendor = GetPlatformVendor();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<System.Int32>)+50]");
		num = (int?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<System.Int32>)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<System.Int32>)+58]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v46+30]");
		SubwayRealCurrencyPurchaseEvent subwayRealCurrencyPurchaseEvent = default;
		subwayRealCurrencyPurchaseEvent._002Ector((string)num2, InAppItemModel.ItemType.Undefined, instance2._syboLastPurchaseNumber, menusBeforeString, num, platformVendor, 0f);
		throw new ArrayTypeMismatchException();
	}

	private string GetMenusBeforeString(bool excludeLastMenuIfNotPurchaseOrigin)
	{
		//IL_016c: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		List<string> list = default;
		list._002Ector((IEnumerable<string>)_menuScreenQueue);
		if (excludeLastMenuIfNotPurchaseOrigin && list._size >= 2)
		{
			int index = list._size - 1;
			int index2 = list._size - 2;
			string text = list.get_Item(index2);
			if (!(text == "NotEnoughCurencyPopup"))
			{
				string text2 = list.get_Item(index);
				if (!(text2 == "CelebrationPopup"))
				{
					goto IL_00ec;
				}
			}
			list.RemoveAt(index);
		}
		goto IL_00ec;
		IL_00ec:
		int num = list._size - 3;
		if (num <= 0)
		{
			num = 0;
		}
		string text3 = string.Empty;
		string text4;
		object obj;
		string text5;
		string text6;
		int num3;
		for (int num2 = num; num2 < list._size; text4 = ((obj == null) ? (text3 + ",") : text3), text5 = list.get_Item(num2), text6 = text4 + text5, num3 = num2 + 1, text3 = text6, num2 = num3)
		{
			if (text3 != null)
			{
				obj = 0;
				if (text3._stringLength != 0)
				{
					continue;
				}
			}
			obj = 1;
		}
		return text3;
	}

	private static int GetItemPayoutAmount(InAppItemModel item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = item.InAppItemType__BackingField - 1;
		if ((nint)obj3 <= 7)
		{
			object obj4 = 1 << (int)obj3;
			object obj5 = obj4 & 0x8F;
			int result = 1;
			if (obj5 == null)
			{
				object obj6 = obj4 & 0x30;
				if (obj6 == null)
				{
					goto IL_00a3;
				}
				InAppManager instance = InAppManager.instance;
				int itemPayoutAmount = instance.GetItemPayoutAmount(item.ItemId__BackingField);
				result = itemPayoutAmount;
			}
			return result;
		}
		goto IL_00a3;
		IL_00a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		float time = Time.time;
		object obj7 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	private static int GetItemBalance(InAppItemModel.ItemType itemType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = itemType - 1;
		bool flag = itemType == InAppItemModel.ItemType.Character;
		int result = 1;
		if (!flag)
		{
			bool flag2 = (nint)obj3 == 1;
			result = 1;
			if (!flag2)
			{
				bool flag3 = (nint)obj3 == 2;
				result = 1;
				if (!flag3)
				{
					bool flag4 = (nint)obj3 == 3;
					result = 1;
					if (!flag4)
					{
						if ((nint)obj3 != 4)
						{
							if ((nint)obj3 != 5)
							{
								if ((nint)obj3 == 6)
								{
									goto IL_0235;
								}
								bool flag5 = (nint)obj3 == 7;
								result = 1;
								if (!flag5)
								{
									if ((nint)obj3 != 8)
									{
										if ((nint)obj3 != 9)
										{
											if ((nint)obj3 != 10)
											{
												goto IL_0235;
											}
											PlayerInfo instance = PlayerInfo.Instance;
											int upgradeAmount = instance.GetUpgradeAmount(PowerupType.scorebooster);
											result = upgradeAmount;
										}
										else
										{
											PlayerInfo instance2 = PlayerInfo.Instance;
											int upgradeAmount2 = instance2.GetUpgradeAmount(PowerupType.headstart2000);
											result = upgradeAmount2;
										}
									}
									else
									{
										PlayerInfo instance3 = PlayerInfo.Instance;
										int upgradeAmount3 = instance3.GetUpgradeAmount(PowerupType.hoverboard);
										result = upgradeAmount3;
									}
								}
							}
							else
							{
								PlayerInfo instance4 = PlayerInfo.Instance;
								int amountOfKeys = instance4.amountOfKeys;
								result = amountOfKeys;
							}
						}
						else
						{
							PlayerInfo instance5 = PlayerInfo.Instance;
							int amountOfCoins = instance5.amountOfCoins;
							result = amountOfCoins;
						}
					}
				}
			}
		}
		return result;
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		float time = Time.time;
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	void IAnalyticsIntegrationTest.SimulateOnlineSettingsDownload()
	{
		OnlineSettings_OnDownloaded(success: true);
	}

	void IAnalyticsIntegrationTest.GenerateFakeSessionEvents(int count)
	{
		//IL_004d: Expected I8, but got I4
		//IL_005a: Expected I8, but got I4
		//IL_006c: Expected I8, but got I4
		PlayerInfo instance = PlayerInfo.Instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		int amountOfCoins = instance2.amountOfCoins;
		PlayerInfo instance3 = PlayerInfo.Instance;
		int amountOfKeys = instance3.amountOfKeys;
		object obj = default;
		if (count > (nint)obj)
		{
			SubwaySessionStartedEvent subwaySessionStartedEvent = default;
			subwaySessionStartedEvent._002Ector();
			subwaySessionStartedEvent.KeyBalance = amountOfKeys;
			subwaySessionStartedEvent.CoinBalance = amountOfCoins;
			subwaySessionStartedEvent.HighScore = instance._highScore;
			throw new ArrayTypeMismatchException();
		}
	}

	void ICoroutineHandler.StartCoroutine(IEnumerator coroutine)
	{
		Coroutine coroutine2 = StartCoroutine(coroutine);
	}

	public AnalyticsIntegration()
	{
		Queue<string> queue = default;
		queue._002Ector(4);
		_menuScreenQueue = queue;
		base._002Ector();
	}
}
