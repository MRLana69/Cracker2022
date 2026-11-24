using System;
using System.Collections.Generic;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Data.Save.Internal;
using Info;
using Kiloo.Common.Backend;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using Kiloo.Plugins.Facebook;
using UnityEngine;
using UnityEngine.UI;

namespace Kiloo.Analytics;

public static class Manager
{
	private const string ONLINESETTINGS_ANALYTICS_ENABLED_KEY = "kiloo_analytics_enabled";

	private const string ONLINESETTINGS_ANALYTICS_SERVER_URL_KEY = "kiloo_analytics_url";

	private const string ONLINESETTINGS_ANALYTICS_SAMPLE_SIZE_KEY = "kiloo_analytics_sample";

	private const string ONLINESETTINGS_ANALYTICS_MAXIMUM_SEND_TIME_KEY = "kiloo_analytics_maximum_send_time";

	private const string ONLINESETTINGS_ANALYTICS_REQUEST_TIME_WINDOW_KEY = "kiloo_analytics_request_time_window";

	private const string ONLINESETTINGS_ANALYTICS_SAVE_ENABLED_KEY = "kiloo_analytics_save_enabled";

	private const string ONLINESETTINGS_ANALYTICS_SEND_ENABLED_KEY = "kiloo_analytics_send_enabled";

	private const bool DEFAULT_ANALYTICS_ENABLED = false;

	private const string DEFAULT_ANALYTICS_SERVER_URL = "http://logger.kiloo-games.com/";

	private const float DEFAULT_ANALYTICS_SAMPLE_SIZE = 0f;

	private const float DEFAULT_ANALYTICS_MAXIMUM_SEND_TIME = 3f;

	private const float DEFAULT_ANALYTICS_REQUEST_TIME_WINDOW = 2f;

	private const bool DEFAULT_ANALYTICS_SAVE_ENABLED = true;

	private const bool DEFAULT_ANALYTICS_SEND_ENABLED = true;

	private const int SESSION_PAUSE_SECONDS = 120;

	private static readonly EventRemoteLogger _eventRemoteLogger;

	private static bool _isPartOfSample;

	private static bool _initialized;

	public static bool isPartOfSample => false;

	public static float userSampleValue
	{
		get
		{
			//IL_001b: Expected F4, but got I
			LocalDebugData localDebug = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+240]");
			return 0f;
		}
	}

	public static bool isSupportedOnPlatform
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return _isPartOfSample;
		}
	}

	static Manager()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		FacebookSession._jsonConverter = (IJsonSerializer)(object)text;
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = 0;
	}

	private static void OnHasRefreshed(RefreshType refreshType)
	{
		_ = -1;
		_ = -1;
		_ = -1;
	}

	public static void LogEvent(EventType eventType, bool overrideSample = false, string extra = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_030f: Expected I, but got Obj
		//IL_0325: Expected Obj, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_017b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v130 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 16;
		if (FacebookSession.statusChangedEvent == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29 (Il2CppClass<System.Type>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v120 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		obj2 = typeof(FacebookSession.State);
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		nint num5 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v75 (Il2CppClass<System.Enum>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v99 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj12 = default;
		if (obj10 == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj14 = default;
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj16 = default;
			object obj15 = obj16;
		}
		else
		{
			object obj15 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		if (extra != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			LogEvent(text, (Dictionary<string, object>)(object)extra);
			string text2 = text;
		}
		else
		{
			string text2 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
	}

	private static void LogEventData(Event eventData)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = eventData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (!obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			return;
		}
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RunTracker.Initialize();
	}

	private static void UpdateSettings(bool overrideSample = false)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (!overrideSample)
		{
			return;
		}
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v8 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overrideSample @ L0 (System.Boolean)+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overrideSample @ L0 (System.Boolean)+C]");
		Log((string)num3, (UnityEngine.Object)0);
	}

	public unsafe static void Initialize(bool overrideSample = false)
	{
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_02b5: Expected I, but got Obj
		//IL_02cb: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_032d: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_037c: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I4
		//IL_00fc: Expected I, but got Obj
		//IL_0169: Expected I4, but got Obj
		//IL_018e: Expected I4, but got Obj
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got F4
		//IL_027e: Expected Obj, but got I4
		object obj;
		if (overrideSample)
		{
			obj = 1;
		}
		else
		{
			nint num = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v75 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v82 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Event runEndedData = RunTracker.GetRunEndedData();
			obj = runEndedData & 1;
		}
		nint num3 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v68 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = obj != null;
		_isPartOfSample = flag;
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v15 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v64 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool value = ((OnlineSettings)(object)saveDataPath).GetValue("kiloo_analytics_url", (byte)(int)"http://logger.kiloo-games.com/" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)value);
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		float startOffset = ((LayoutGroup)(object)saveDataPath2).GetStartOffset((int)"kiloo_analytics_maximum_send_time", 3f);
		string saveDataPath3 = OnlineSettings.GetSaveDataPath();
		float startOffset2 = ((LayoutGroup)(object)saveDataPath3).GetStartOffset((int)"kiloo_analytics_request_time_window", 2f);
		string saveDataPath4 = OnlineSettings.GetSaveDataPath();
		bool allowSaving = ((OnlineSettings)(object)saveDataPath4).TryGetValue("kiloo_analytics_save_enabled", out *(string*)1);
		string saveDataPath5 = OnlineSettings.GetSaveDataPath();
		bool allowSending = ((OnlineSettings)(object)saveDataPath5).TryGetValue("kiloo_analytics_send_enabled", out *(string*)1);
		EventRemoteLogger eventRemoteLogger = _eventRemoteLogger;
		bool flag2 = _isPartOfSample;
		eventRemoteLogger.isPartOfSample = flag2;
		EventRemoteLogger eventRemoteLogger2 = _eventRemoteLogger;
		eventRemoteLogger2.allowSaving = allowSaving;
		EventRemoteLogger eventRemoteLogger3 = _eventRemoteLogger;
		eventRemoteLogger3.allowSending = allowSending;
		EventRemoteLogger eventRemoteLogger4 = _eventRemoteLogger;
		eventRemoteLogger4._sendOnPause = true;
		object obj5 = eventRemoteLogger4 - -64;
		obj5 = startOffset;
		eventRemoteLogger4._sendOnPauseRequestTimeWindow = startOffset2;
		_eventRemoteLogger.LogEvent((string)(object)uri, (Dictionary<string, object>)120);
		_eventRemoteLogger.Save();
	}

	public static void LogEvent(string eventName, Dictionary<string, object> parameters = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_0139: Expected I, but got Obj
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 20;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = obj;
		_ = -1;
		eventName.m_firstChar = '\uffff';
		_ = -1;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj6 = default;
		if (obj6 != null)
		{
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v69 (Il2CppClass<System.Type>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v162 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj2 = typeof(FacebookError.Category);
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v118 (Il2CppClass<System.Enum>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v149 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj10 = default;
			object obj9 = obj10;
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj13 = default;
			if (obj11 == obj13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj15 = default;
				object obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj17 = default;
				object obj16 = obj17;
			}
			else
			{
				object obj16 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj18 = default;
		if (obj18 != null)
		{
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj19 = default;
		if (obj19 != null)
		{
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj20 = default;
		if (obj20 != null)
		{
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj21 = default;
		if (obj21 != null)
		{
			object obj22 = eventName + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj23 = default;
			obj22 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj24 = default;
		if (obj24 != null)
		{
			object obj25 = eventName + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj26 = default;
			obj25 = obj26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj27 = default;
		if (obj27 != null)
		{
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj28 = default;
		if (obj28 != null)
		{
			object obj29 = eventName + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj30 = default;
			obj29 = obj30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj31 = default;
		if (obj31 != null)
		{
			object obj32 = eventName + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj33 = default;
			obj32 = obj33;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj34 = default;
		if (obj34 != null)
		{
			object obj35 = eventName + 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj36 = default;
			obj35 = obj36;
		}
	}

	private static bool Sample()
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		string dataPath = Application.dataPath;
		object obj = dataPath - 8;
		if ((nint)dataPath != 8 && ((nint)obj == 1 || (nint)obj == 2 || (nint)obj != 3))
		{
			return false;
		}
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool iOSOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying();
		return (byte)((iOSOtherAudioPlaying ? 1u : 0u) ^ 1u) != 0;
	}

	private unsafe static void OnFinishedDownloadingOnlineSettings()
	{
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(EventRemoteLogger);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.EventRemoteLogger>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventRemoteLogger);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v43 (Il2CppClass<Kiloo.Common.Backend.EventRemoteLogger>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_eventRemoteLogger = EventRemoteLogger.instance;
		_isPartOfSample = false;
		_initialized = false;
		if (!Sample())
		{
			return;
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v39 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnFinishedDownloadingOnlineSettings);
		object obj3 = action + 16;
		obj3 = 0;
		((OnlineSettings)(object)saveDataPath).RemoveOnFinishedDownloadingOnlineSettingsHandler(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj4 = action2 + 16;
		obj4 = 0;
		AppRefreshHandler.hasRefreshed -= action2;
	}

	private static void InitializeOrUpdate()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RunTracker.Initialize();
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v35 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C17");
		object obj3 = default;
		if (obj3 == null)
		{
			return;
		}
		nint num5 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v29 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((CloudItemUpdatedArgs)(object)_eventRemoteLogger)._002Ector((ICloudItem)(object)msg, (string)(object)context);
	}

	private static void LogWarn(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogErr(string msg, UnityEngine.Object context = null)
	{
	}
}
