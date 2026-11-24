//Type is in global namespace

public static class StorageSizeLogging
{
	private sealed class <>c__DisplayClass31_0
	{
		public double mbSize; //Field offset: 0x8

		public <>c__DisplayClass31_0() { }

		internal double <GetAppropiateBucketSize>b__0(int item) { }

	}

	private static long _currentSize; //Field offset: 0x0
	private const string DATA_MAIN = "Data"; //Field offset: 0x0
	private const string CACHE_MAIN = "Cache"; //Field offset: 0x0
	private const string ASSETBUNDLES_MAIN = "AssetBundles"; //Field offset: 0x0
	private const bool DEFAULT_STORAGE_SIZE_LOGGING_SETTING = False; //Field offset: 0x0
	private const string STORAGE_SIZE_LOGGING_ENABLED_KEY = "storage_logging_enabled"; //Field offset: 0x0
	private static Dictionary<string, string> _androidProviderPathsDictionary; //Field offset: 0x8
	private static Dictionary<string, string> _iOSProviderPathsDictionary; //Field offset: 0xC
	private static string _userDataPath; //Field offset: 0x10
	private static string _userExternalDataPath; //Field offset: 0x14
	private static string _userCachePath; //Field offset: 0x18
	private static string _userTemporaryPath; //Field offset: 0x1C
	private static string _assetBundlesPath; //Field offset: 0x20
	private static int _dataSize; //Field offset: 0x24
	private static int _cacheSize; //Field offset: 0x28
	private static int _assetBundlesSize; //Field offset: 0x2C
	private static bool _hasFlurryLoggedInSession; //Field offset: 0x30
	private static List<int> _buckets; //Field offset: 0x34

	private static bool _isStorageLoggingEnabled
	{
		 get { } //Length: 92
	}

	public static int AssetBundlesSize
	{
		 get { } //Length: 89
	}

	public static int CacheSize
	{
		 get { } //Length: 89
	}

	public static int DataSize
	{
		 get { } //Length: 536
	}

	private static StorageSizeLogging() { }

	private static bool get__isStorageLoggingEnabled() { }

	public static int get_AssetBundlesSize() { }

	public static int get_CacheSize() { }

	public static int get_DataSize() { }

	private static string GetAppropiateBucketSize(long size) { }

	public static bool HasFlurryLoggedInSession() { }

	private static void InitDevicePaths() { }

	private static void Log(string msg, Object context = null) { }

	private static int LogOverallUsage(string generalLocation, List<string> paths) { }

	private static void LogProviderUsage(Dictionary<string, string> providerDictionary) { }

	public static void RegisterStorageUsage() { }

	private static void VerifyPathAndAddFileSizes(string directoryPath) { }

	private static void WalkDirectoryTree(DirectoryInfo directoryInfo) { }

}

