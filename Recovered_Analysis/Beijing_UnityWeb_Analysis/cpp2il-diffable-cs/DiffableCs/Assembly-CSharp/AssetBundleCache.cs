//Type is in global namespace

public static class AssetBundleCache
{
	private enum CachingAction
	{
		Add = 0,
		Remove = 1,
		ClearCache = 2,
	}

	private static readonly string ASSET_BUNDLE_CACHE_PATH; //Field offset: 0x0
	private const string CACHED_VERSION_INFO_FILE_NAME = "CachedBundlesVersionInfo"; //Field offset: 0x0
	private const string DEBUG_TAG = "[AssetBundleCache]: "; //Field offset: 0x0
	private static Dictionary<string, int> _cachedBundlesVersionInfo; //Field offset: 0x4
	private static bool _isPerformingBulkCaching; //Field offset: 0x8

	private static AssetBundleCache() { }

	public static bool CacheAssetBundle(string bundleName, int version, byte[] bytes) { }

	public static bool CacheEditorBundle(string bundleName, int version, string bundlePath) { }

	public static void ClearCache() { }

	public static void EndBulkCaching() { }

	public static int GetVersionForCachedBundle(string bundleName) { }

	public static void Initialize() { }

	public static bool IsAssetBundleCached(string bundleName, int version) { }

	public static AssetBundle LoadAssetBundle(string bundleName, int version) { }

	public static AssetBundleCreateRequest LoadAssetBundleAsync(string bundleName, int version) { }

	private static void LoadCachedBundlesVersionInfo() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	private static void RecordCachingInfo(string bundleName, int version, CachingAction action) { }

	public static bool RemoveFromCache(string bundleName, int version) { }

	private static void SaveCachedBundlesVersionInfo() { }

	public static void StartBulkCaching() { }

}

