//Type is in global namespace

public class AssetBundleManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<string, bool> <>9__51_1; //Field offset: 0x4
		public static Predicate<string> <>9__51_0; //Field offset: 0x8
		public static Comparison<CharacterBundleRequest> <>9__56_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal bool <GetAbsolutePath>b__51_0(string s) { }

		internal bool <GetAbsolutePath>b__51_1(string s) { }

		internal int <ProcessCharacterBundleRequests>b__56_0(CharacterBundleRequest r1, CharacterBundleRequest r2) { }

	}

	private sealed class <>c__DisplayClass55_0
	{
		public string bundleName; //Field offset: 0x8

		public <>c__DisplayClass55_0() { }

		internal bool <OnRequestFinished>b__0(KeyValuePair<string, Action<AssetBundle>> entry) { }

	}

	private sealed class <>c__DisplayClass58_0
	{
		public CharacterModelRequest modelRequest; //Field offset: 0x8

		public <>c__DisplayClass58_0() { }

		internal bool <RemoveAsyncCharacterBundleRequest>b__0(CharacterBundleRequest r) { }

		internal bool <RemoveAsyncCharacterBundleRequest>b__1(CharacterBundleRequest r) { }

	}

	private sealed class <CacheNeededAssetBundles>d__61 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private float <>2__current; //Field offset: 0xC
		public AssetBundleManager <>4__this; //Field offset: 0x10
		private Dictionary<string, int> <neededBundles>5__2; //Field offset: 0x14
		private int <nShippedBundles>5__3; //Field offset: 0x18
		private int <nBundlesProcessed>5__4; //Field offset: 0x1C
		private Enumerator<string, int> <>7__wrap4; //Field offset: 0x20

		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			 get { } //Length: 6
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 1335
		}

		public <CacheNeededAssetBundles>d__61(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private float System.Collections.Generic.IEnumerator<System.Single>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DownloadAllAssetBundles>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AssetBundleManager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 226
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadAllAssetBundles>d__76(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DownloadAssetBundle>d__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string bundleName; //Field offset: 0x10
		public AssetBundleManager <>4__this; //Field offset: 0x14
		public int version; //Field offset: 0x18
		private bool <downloadSuccessful>5__2; //Field offset: 0x1C
		private IRequest <request>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1260
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadAssetBundle>d__77(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoadAssetBundleAsync>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string bundleName; //Field offset: 0x10
		public int cachedVersion; //Field offset: 0x14
		public AssetBundleManager <>4__this; //Field offset: 0x18
		public Action<AssetBundle> requestResultHandler; //Field offset: 0x1C
		private AssetBundleCreateRequest <request>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 321
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadAssetBundleAsync>d__54(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ProcessCharacterBundleRequests>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AssetBundleManager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 554
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ProcessCharacterBundleRequests>d__56(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UnloadBundlesCoroutine>d__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AssetBundleManager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1704
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UnloadBundlesCoroutine>d__69(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const string COMPRESSION_SIGNATURE = "subway_bundles"; //Field offset: 0x0
	private static string _assetBundleBaseServerUrl; //Field offset: 0x0
	private const int SIMULTANEOUS_CHARACTER_BUNDLE_REQUESTS_HIGH = 6; //Field offset: 0x0
	private const int SIMULTANEOUS_CHARACTER_BUNDLE_REQUESTS_LOW = 3; //Field offset: 0x0
	private const string ASSET_BUNDLE_EXTENSION_OS_KEY = "asset_bundle_extension"; //Field offset: 0x0
	private const string ASSET_BUNDLE_IS_USING_EXTENSION_OS_KEY = "asset_bundle_using_extension"; //Field offset: 0x0
	private const string ASSET_BUNDLE_DOWNLOAD_REST_TIME_OS_KEY = "asset_bundle_download_rest_time"; //Field offset: 0x0
	private const string ASSET_BUNDLE_REQUEST_MAX_BACKOFF_TIME_OS_KEY = "asset_bundle_request_max_backoff_time"; //Field offset: 0x0
	private const string ASSET_BUNDLE_REQUEST_TIMEOUT_OS_KEY = "asset_bundle_request_timeout"; //Field offset: 0x0
	private const string ASSET_BUNDLE_SERVER_ANDROID_FOLDER_OS_KEY = "asset_bundle_server_android_folder"; //Field offset: 0x0
	private const string ASSET_BUNDLE_SERVER_IOS_FOLDER_OS_KEY = "asset_bundle_server_ios_folder"; //Field offset: 0x0
	private const string ASSET_BUNDLE_SERVER_URL_OS_KEY = "asset_bundle_server"; //Field offset: 0x0
	private const char ITEM_SEPARATOR = '\u2C'; //Field offset: 0x0
	private const char VALUE_SEPARATOR = '\u2D'; //Field offset: 0x0
	private const string DEBUG_TAG = "[AssetBundleManager]: "; //Field offset: 0x0
	private const string TEMPORARY_EDITOR_ASSET_BUNDLE_FOLDER = "Temp"; //Field offset: 0x0
	private const string UNCOMPRESSED_ASSET_BUNDLE_STANDALONE_FOLDER = "standalone"; //Field offset: 0x0
	private const string UNCOMPRESSED_ASSET_BUNDLE_IOS_FOLDER = "ios"; //Field offset: 0x0
	private const string UNCOMPRESSED_ASSET_BUNDLE_ANDROID_FOLDER = "android"; //Field offset: 0x0
	private const string EDITOR_ASSET_BUNDLE_CACHE_PATH = "..\EditorCache"; //Field offset: 0x0
	private const string ASSET_BUNDLES_ROOT_PATH = "..\..\AssetBundles"; //Field offset: 0x0
	private const string ASSET_BUNDLE_RESOURCES_PATH = "AssetBundles"; //Field offset: 0x0
	private static string _serverDirIos; //Field offset: 0x4
	private static string _serverDirAndroid; //Field offset: 0x8
	private static string _serverDirGenerated; //Field offset: 0xC
	private static float _requestDownloadTimeout; //Field offset: 0x10
	private static float _requestMaxBackoffTime; //Field offset: 0x14
	private static float _downloadAttemptRestTime; //Field offset: 0x18
	private static bool _usingBundleExtension; //Field offset: 0x1C
	private static string _assetBundleExtension; //Field offset: 0x20
	private static AssetBundleManager _instance; //Field offset: 0x24
	private AssetBundleVersionControl _versionControl; //Field offset: 0x8
	private List<string> _assetBundlesLoading; //Field offset: 0xC
	private Dictionary<string, AssetBundle> _loadedAssetBundles; //Field offset: 0x10
	private Dictionary<string, bool> _pendingUnloads; //Field offset: 0x14
	private List<KeyValuePair<string, Action<AssetBundle>>> _pendingRequests; //Field offset: 0x18
	private List<CharacterBundleRequest> _pendingCharacterBundleRequests; //Field offset: 0x1C
	private List<CharacterBundleRequest> _activeCharacterBundleRequests; //Field offset: 0x20
	private int _simultaneousCharacterBundleRequests; //Field offset: 0x24
	private Dictionary<string, int> _pendingDownloads; //Field offset: 0x28
	private bool _isDownloading; //Field offset: 0x2C
	private float _lastInitializedDownloads; //Field offset: 0x30
	private bool _downloadableBundlesUpdated; //Field offset: 0x34
	private IEnumerator _currentDownloaderCoroutine; //Field offset: 0x38
	private bool _delayedAvailabilityCheck; //Field offset: 0x3C
	private int attemptingToPrecacheAmount; //Field offset: 0x40
	private int succesfullyPrecached; //Field offset: 0x44
	private int attemptingToDownloadAmount; //Field offset: 0x48
	private int succesfullyDownloaded; //Field offset: 0x4C

	public static AssetBundleManager Instance
	{
		 get { } //Length: 93
		private set { } //Length: 938
	}

	private static AssetBundleManager() { }

	private AssetBundleManager() { }

	private void AddAssetBundleDownloadRequest(string bundleName, int version) { }

	private bool AllowedToInitializeDownloads() { }

	private bool CacheAssetBundle(string bundleName, int version, byte[] bundleBytes = null) { }

	public IEnumerator<float> CacheNeededAssetBundles() { }

	public void CancelCharacterBundleRequest(CharacterBundleRequest request) { }

	public void CharacterBundleRequestCompleted(CharacterBundleRequest request) { }

	public static void ClearCache() { }

	private void DebugRequestStatus(string bundleName) { }

	private void DelayedAvailabilityCheck() { }

	private IEnumerator DownloadAllAssetBundles() { }

	private IEnumerator DownloadAssetBundle(string bundleName, int version) { }

	private void DownloadFailedFor(string bundleName, int version) { }

	public void EnqueueAsyncCharacterBundleRequest(CharacterId characterId, int theme, Action onBundlesLoaded, CharacterModelRequest modelRequest) { }

	public static AssetBundleManager get_Instance() { }

	private static string GetAbsolutePath(string path) { }

	public void GetAssetBundle(string bundleName, Action<AssetBundle> requestResultHandler, bool asynchronous = false) { }

	public static string GetAssetBundlesCachePath() { }

	private string GetAssetBundlesServerURL(string bundleName) { }

	public string GetDownloadedBundles() { }

	private string GetEditorBundlesPath(string bundleName) { }

	public string GetPreCachedBundles() { }

	private void InitializeDownloadRequests() { }

	private IEnumerator LoadAssetBundleAsync(string bundleName, int cachedVersion, Action<AssetBundle> requestResultHandler) { }

	private void Log(string msg) { }

	private void LogError(string msg) { }

	private void LogWarning(string msg) { }

	private void OnDownloadableAssetBundlesUpdated() { }

	private void OnEventChanged() { }

	private void OnRequestFinished(string bundleName, AssetBundle assetBundle, Action<AssetBundle> requestResultHandler) { }

	public static Dictionary<string, int> ParseAssetBundleVersionData(string serializedData) { }

	public void PerformAvailabilityCheck() { }

	private IEnumerator ProcessCharacterBundleRequests() { }

	public void RemoveAsyncCharacterBundleRequest(CharacterModelRequest modelRequest) { }

	private void RequestAssetBundle(string bundleName, Action<AssetBundle> requestResultHandler, bool asynchronous = false) { }

	private void ResolveDownloadRequest(string bundleName, int version) { }

	public void ResumeAssetBundlesDownload() { }

	public static string SerializeAssetBundleVersionData(Dictionary<string, int> versionData) { }

	private static void set_Instance(AssetBundleManager value) { }

	private void StopAssetbundlesDownload() { }

	public void UnloadAssetBundle(string bundleName, bool unloadAllLoadedObjects) { }

	private IEnumerator UnloadBundlesCoroutine() { }

}

