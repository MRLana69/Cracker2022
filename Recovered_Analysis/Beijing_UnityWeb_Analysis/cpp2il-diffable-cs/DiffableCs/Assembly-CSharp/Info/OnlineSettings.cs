namespace Info;

public class OnlineSettings
{
	private sealed class <DownloadCoroutine>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public OnlineSettings <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 641
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadCoroutine>d__36(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const string DISABLED_SETTING = "disabled"; //Field offset: 0x0
	private const string PLATFORM = "WebGL"; //Field offset: 0x0
	private const string URL = "/newonlinesettings.php"; //Field offset: 0x0
	private static readonly char[] LINEBREAK_CHARS; //Field offset: 0x0
	private const string FILE_SECRET = "pdvshbhkndf92k19zvbckawd92fjk"; //Field offset: 0x0
	private const int FILEFORMAT_VERSION = 1; //Field offset: 0x0
	private static OnlineSettings _instance; //Field offset: 0x4
	private Dictionary<string, string> _settings; //Field offset: 0x8
	private bool _isDownloading; //Field offset: 0xC
	private GameObject _downloadGameObject; //Field offset: 0x10
	private Action _onFinishedDownloadingOnlineSettingsHandler; //Field offset: 0x14
	public Action<bool> onOnlineSettingsDownloadResult; //Field offset: 0x18
	private string _checksumToShow; //Field offset: 0x1C

	public static OnlineSettings instance
	{
		 get { } //Length: 92
	}

	public bool isDownloading
	{
		 get { } //Length: 6
	}

	public static bool isInstanced
	{
		 get { } //Length: 545
	}

	public Dictionary<string, string> rawSettings
	{
		 get { } //Length: 219
	}

	private static OnlineSettings() { }

	private OnlineSettings() { }

	public void AddOnFinishedDownloadingOnlineSettingsHandler(Action handler) { }

	private IEnumerator DownloadCoroutine() { }

	public void DownloadNow() { }

	public static OnlineSettings get_instance() { }

	public bool get_isDownloading() { }

	public static bool get_isInstanced() { }

	public Dictionary<string, string> get_rawSettings() { }

	public string GetChecksumToShow() { }

	public string GetCurrentPlatform() { }

	public string GetCurrentPlatformPretty() { }

	private static string GetSaveDataPath() { }

	public bool GetValue(string key, bool defaultValue) { }

	public string GetValue(string key, string defaultValue) { }

	public uint GetValue(string key, uint defaultValue) { }

	public int GetValue(string key, int defaultValue) { }

	public float GetValue(string key, float defaultValue) { }

	public double GetValue(string key, double defaultValue) { }

	public bool HasValue(string key) { }

	private void LoadFromFile() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	public void RemoveOnFinishedDownloadingOnlineSettingsHandler(Action handler) { }

	private void SaveToFile() { }

	private void SetCurrentChecksum(string response) { }

	public bool TryGetValue(string key, out string valueString) { }

	private static bool ValidateChecksum(string response) { }

}

