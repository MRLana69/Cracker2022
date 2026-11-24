namespace Kiloo.Analytics;

public static class Manager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__29_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Initialize>b__29_0() { }

	}

	private sealed class <>c__DisplayClass26_0
	{
		public bool overrideSample; //Field offset: 0x8

		public <>c__DisplayClass26_0() { }

		internal void <LogEvent>b__0(Event data) { }

	}

	private const string ONLINESETTINGS_ANALYTICS_ENABLED_KEY = "kiloo_analytics_enabled"; //Field offset: 0x0
	private static readonly EventRemoteLogger _eventRemoteLogger; //Field offset: 0x0
	private const int SESSION_PAUSE_SECONDS = 120; //Field offset: 0x0
	private const bool DEFAULT_ANALYTICS_SEND_ENABLED = True; //Field offset: 0x0
	private const bool DEFAULT_ANALYTICS_SAVE_ENABLED = True; //Field offset: 0x0
	private const float DEFAULT_ANALYTICS_REQUEST_TIME_WINDOW = 2; //Field offset: 0x0
	private const float DEFAULT_ANALYTICS_MAXIMUM_SEND_TIME = 3; //Field offset: 0x0
	private const float DEFAULT_ANALYTICS_SAMPLE_SIZE = 0; //Field offset: 0x0
	private const string DEFAULT_ANALYTICS_SERVER_URL = "http://logger.kiloo-games.com/"; //Field offset: 0x0
	private const bool DEFAULT_ANALYTICS_ENABLED = False; //Field offset: 0x0
	private const string ONLINESETTINGS_ANALYTICS_SEND_ENABLED_KEY = "kiloo_analytics_send_enabled"; //Field offset: 0x0
	private const string ONLINESETTINGS_ANALYTICS_SAVE_ENABLED_KEY = "kiloo_analytics_save_enabled"; //Field offset: 0x0
	private const string ONLINESETTINGS_ANALYTICS_REQUEST_TIME_WINDOW_KEY = "kiloo_analytics_request_time_window"; //Field offset: 0x0
	private const string ONLINESETTINGS_ANALYTICS_MAXIMUM_SEND_TIME_KEY = "kiloo_analytics_maximum_send_time"; //Field offset: 0x0
	private const string ONLINESETTINGS_ANALYTICS_SAMPLE_SIZE_KEY = "kiloo_analytics_sample"; //Field offset: 0x0
	private const string ONLINESETTINGS_ANALYTICS_SERVER_URL_KEY = "kiloo_analytics_url"; //Field offset: 0x0
	private static bool _isPartOfSample; //Field offset: 0x4
	private static bool _initialized; //Field offset: 0x5

	public static bool isPartOfSample
	{
		 get { } //Length: 3
	}

	public static bool isSupportedOnPlatform
	{
		 get { } //Length: 92
	}

	public static float userSampleValue
	{
		 get { } //Length: 51
	}

	private static Manager() { }

	public static bool get_isPartOfSample() { }

	public static bool get_isSupportedOnPlatform() { }

	public static float get_userSampleValue() { }

	public static void Initialize(bool overrideSample = false) { }

	private static void InitializeOrUpdate() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogErr(string msg, Object context = null) { }

	public static void LogEvent(EventType eventType, bool overrideSample = false, string extra = null) { }

	public static void LogEvent(string eventName, Dictionary<string, object> parameters = null) { }

	private static void LogEventData(Event eventData) { }

	private static void LogWarn(string msg, Object context = null) { }

	private static void OnFinishedDownloadingOnlineSettings() { }

	private static void OnHasRefreshed(RefreshType refreshType) { }

	private static bool Sample() { }

	private static void UpdateSettings(bool overrideSample = false) { }

}

