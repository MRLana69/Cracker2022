namespace Info;

public static class OnlineSettingsManager
{
	private const string DEBUG_LOGS_TAG = "[OnlineSettingsManager]: "; //Field offset: 0x0
	private const string BASE_URL = "https://onlinesettings.kiloo-games.com/"; //Field offset: 0x0
	private const string FILENAME = "settings"; //Field offset: 0x0
	private static OnlineSettings<OnlineSettingsData> _onlineSettings; //Field offset: 0x0
	private static LocalizedOnlineSettings _localizedOnlineSettings; //Field offset: 0x4
	private static bool _initialized; //Field offset: 0x8
	private static string _filePath; //Field offset: 0xC
	public static Action onNewSettingsDownloaded; //Field offset: 0x10
	private static readonly BuildPurpose[] TEST_TIME_BUILDS_SUPPORTED; //Field offset: 0x14

	public static OnlineSettingsData data
	{
		 get { } //Length: 91
	}

	public static LocalizedOnlineSettings localizedData
	{
		 get { } //Length: 106
	}

	private static OnlineSettingsManager() { }

	private static void CheckInitialization() { }

	public static void DownloadNow() { }

	public static OnlineSettingsData get_data() { }

	public static LocalizedOnlineSettings get_localizedData() { }

	public static void Initialize() { }

	private static void InitializeLocalizedSettings() { }

	private static void Log(string msg) { }

	private static void LogWarning(string msg) { }

	private static void OnNewSettingsDownloaded() { }

}

