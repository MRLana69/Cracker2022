//Type is in global namespace

public class AssetBundleVersionControl
{
	private const string VERSION_INFO_SAVE_PATH = "AssetBundleVersion"; //Field offset: 0x0
	private static int DEFAULT_BUNDLES_VERSION; //Field offset: 0x0
	private const string MANIFESTS_DEAULT_FOLDER = "editor"; //Field offset: 0x0
	private const string MANIFESTS_EDITOR_FOLDER = "editor"; //Field offset: 0x0
	private const string MANIFESTS_IOS_FOLDER = "ios"; //Field offset: 0x0
	private const char UPDATED_BUNDLE_VALUE_SEPARATOR = '\u3A'; //Field offset: 0x0
	private const char UPDATED_BUNDLE_SEPARATOR = '\u3B'; //Field offset: 0x0
	private const string MANIFESTS_ANDROID_FOLDER = "android"; //Field offset: 0x0
	private const string ONLINE_SETTINGS_BUNDLES_VERSION_KEY = "asset_bundles_version"; //Field offset: 0x0
	private const string DEBUG_TAG = "[AssetBundleVersionControl]: "; //Field offset: 0x0
	public const string SHIPPED_BUNDLE_DATA_FILENAME = "ShippedAssetBundlesManifest"; //Field offset: 0x0
	public const string DOWNLOADABLE_BUNDLE_DATA_FILENAME = "DownloadableAssetBundlesManifest"; //Field offset: 0x0
	private const string ASSET_BUNDLE_MANIFESTS_RESOURCES_PATH = "AssetBundleManifests/"; //Field offset: 0x0
	private const string VERSION_INFO_FILE_NAME = "AssetBundleVersionInfo"; //Field offset: 0x0
	private const string ONLINE_SETTINGS_UPDATED_ASSET_BUNDLES = "updated_bundles_list"; //Field offset: 0x0
	private static readonly IJsonSerializer _jsonConverter; //Field offset: 0x4
	private static AssetBundleVersionControl _instance; //Field offset: 0x8
	private bool _initialized; //Field offset: 0x8
	private string _versionInfoFilePath; //Field offset: 0xC
	private Dictionary<string, int> _availableBundlesData; //Field offset: 0x10
	private Dictionary<string, int> _shippedBundlesData; //Field offset: 0x14
	private Dictionary<string, int> _downloadableBundlesData; //Field offset: 0x18
	private Dictionary<string, int> _neededBundles; //Field offset: 0x1C
	public Action OnDownloadableAssetBundlesUpdated; //Field offset: 0x20

	public static AssetBundleVersionControl Instance
	{
		 get { } //Length: 79
		private set { } //Length: 65
	}

	private static AssetBundleVersionControl() { }

	private AssetBundleVersionControl() { }

	private void AddNeededBundles(Dictionary<string, int> neededBundles, CharacterId character) { }

	private void CreateAvailableBundlesVersionInfo(Dictionary<string, int> shippedData, Dictionary<string, int> downloadableData) { }

	private void DeleteAvailableBundlesData() { }

	public static AssetBundleVersionControl get_Instance() { }

	public int GetAvailableShippedVersionForBundle(string bundleName) { }

	public int GetCurrentlyAvailableBundleVersion() { }

	public int GetLatestVersionForBundle(string bundleName) { }

	private string GetManifestPath(string filename) { }

	public Dictionary<string, int> GetNeededBundles() { }

	private static string GetVersionInfoFilePath() { }

	private bool HasAppBeenUpdated(string lastSeenVersion) { }

	public void Initialize() { }

	private void InitializeNeededBundles() { }

	public bool IsBundleVersionShipped(string bundleName, int version) { }

	private bool IsFreshInstall(string lastSeenVersion) { }

	private void LoadAvailableBundlesData() { }

	private void Log(string msg) { }

	private void LogError(string msg) { }

	private void LogWarning(string msg) { }

	private void OnOnlineSettingsDownloaded() { }

	private Dictionary<string, int> ParseUpdatedBundles(string serializedUpdatedBundles) { }

	private Dictionary<string, int> ReadAssetBundleManifest(bool downloadables) { }

	private void SaveAvailableBundlesData() { }

	private static void set_Instance(AssetBundleVersionControl value) { }

}

