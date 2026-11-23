using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Backend;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

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

	private static Action _003C_003Ef__mg_0024cache0;

	public static bool isPartOfSample => _isPartOfSample;

	public static float userSampleValue
	{
		get
		{
			PlayerInfo instance = PlayerInfo.Instance;
			float analyticsSamplingKey = instance.AnalyticsSamplingKey;
			return analyticsSamplingKey * 100f;
		}
	}

	public static bool isSupportedOnPlatform
	{
		get
		{
			//IL_0017: Expected Obj, but got I4
			RuntimePlatform platform = Application.platform;
			object obj = platform - 8;
			if ((platform == RuntimePlatform.IPhonePlayer || ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3)) && !DeviceUtility.isFlexionDevice)
			{
				bool isKindleDevice = DeviceUtility.isKindleDevice;
				return (byte)((isKindleDevice ? 1u : 0u) ^ 1u) != 0;
			}
			return false;
		}
	}

	unsafe static Manager()
	{
		_eventRemoteLogger = EventRemoteLogger.instance;
		_isPartOfSample = false;
		_initialized = false;
		if (isSupportedOnPlatform)
		{
			OnlineSettings instance = OnlineSettings.instance;
			Action action = default;
			action._002Ector(null, (nint)(delegate*<void>)(&OnFinishedDownloadingOnlineSettings));
			instance.AddOnFinishedDownloadingOnlineSettingsHandler(action);
		}
	}

	public static void LogEvent(EventType eventType, bool overrideSample = false, string extra = null)
	{
		//IL_0067: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		object obj = (_initialized ? 1 : 0) ^ 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
		object obj2 = 0 & obj;
		if (obj2 != null)
		{
			Initialize(overrideSample: true);
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			object obj3 = (nint)0 | (nint)(_isPartOfSample ? 1 : 0);
			if (obj3 != null)
			{
				throw new ArgumentException();
			}
		}
	}

	private static void LogEventData(Event eventData)
	{
		if (eventData != null)
		{
			LogEvent(eventData.name, eventData.parameters);
		}
	}

	private static void UpdateSettings(bool overrideSample = false)
	{
		bool flag = overrideSample || Sample();
		_isPartOfSample = flag;
		OnlineSettings instance = OnlineSettings.instance;
		string value = instance.GetValue("kiloo_analytics_url", "http://logger.kiloo-games.com/");
		Uri uri = default;
		uri._002Ector(value);
		OnlineSettings instance2 = OnlineSettings.instance;
		float value2 = instance2.GetValue("kiloo_analytics_maximum_send_time", 3f);
		OnlineSettings instance3 = OnlineSettings.instance;
		float value3 = instance3.GetValue("kiloo_analytics_request_time_window", 2f);
		OnlineSettings instance4 = OnlineSettings.instance;
		bool value4 = instance4.GetValue("kiloo_analytics_save_enabled", defaultValue: true);
		OnlineSettings instance5 = OnlineSettings.instance;
		bool value5 = instance5.GetValue("kiloo_analytics_send_enabled", defaultValue: true);
		EventRemoteLogger eventRemoteLogger = _eventRemoteLogger;
		eventRemoteLogger.isPartOfSample = _isPartOfSample;
		EventRemoteLogger eventRemoteLogger2 = _eventRemoteLogger;
		eventRemoteLogger2.allowSaving = value4;
		EventRemoteLogger eventRemoteLogger3 = _eventRemoteLogger;
		eventRemoteLogger3.allowSending = value5;
		EventRemoteLogger eventRemoteLogger4 = _eventRemoteLogger;
		eventRemoteLogger4._sendOnPauseRequestTimeWindow = value3;
		eventRemoteLogger4._sendOnPauseMaximumSendTime = value2;
		eventRemoteLogger4._sendOnPause = true;
		_eventRemoteLogger.SetServiceInfo(uri, 120);
		_eventRemoteLogger.CheckSessionRemoval();
	}

	public static void Initialize(bool overrideSample = false)
	{
		if (!_initialized && isSupportedOnPlatform)
		{
			bool flag = overrideSample || Sample();
			_isPartOfSample = flag;
			if (~(_isPartOfSample ? 1u : 0u) == 0)
			{
				UpdateSettings(overrideSample);
				_initialized = true;
				LogEvent(EventType.StaticData);
				LogEvent(EventType.SyboUserId);
			}
		}
	}

	public static void LogEvent(string eventName, Dictionary<string, object> parameters = null)
	{
		if (~(_initialized ? 1u : 0u) == 0 && ~(_isPartOfSample ? 1u : 0u) == 0)
		{
			_eventRemoteLogger.LogEvent(eventName, parameters);
		}
	}

	private static bool Sample()
	{
		OnlineSettings instance = OnlineSettings.instance;
		bool value = instance.GetValue("kiloo_analytics_enabled", defaultValue: false);
		if (value)
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			float value2 = instance2.GetValue("kiloo_analytics_sample", 0f);
			PlayerInfo instance3 = PlayerInfo.Instance;
			if (!instance3._hasMadeOneValidPurchase)
			{
				float num = userSampleValue;
				bool flag = !(num < 0f);
				bool flag2 = !(value2 < num);
				return flag & flag2;
			}
		}
		return value;
	}

	private static void OnFinishedDownloadingOnlineSettings()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Initialize();
		}
		else
		{
			UpdateSettings();
		}
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarn(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogErr(string msg, UnityEngine.Object context = null)
	{
	}
}
