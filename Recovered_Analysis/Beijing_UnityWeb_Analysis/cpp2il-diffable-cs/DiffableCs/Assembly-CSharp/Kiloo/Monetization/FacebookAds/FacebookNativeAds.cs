namespace Kiloo.Monetization.FacebookAds;

public static class FacebookNativeAds
{
	private static IFacebookNativeAdsBridge _platformBridge; //Field offset: 0x0
	private const int MINIMUM_SUPPORTED_IOS_VERSION = 9; //Field offset: 0x0
	private static Action<bool> onNativeInitialize; //Field offset: 0x4
	private static Action<string> onNativeDidLoad; //Field offset: 0x8
	private static Action<string> onNativeAdShown; //Field offset: 0xC
	private static Action<string> onNativeAdClosed; //Field offset: 0x10
	private static Action<string> onNativeAdClicked; //Field offset: 0x14
	private static Action<string> onNativeAdError; //Field offset: 0x18
	private static Action<string> onNativeCacheAdError; //Field offset: 0x1C
	private static Action<string> onVideoDidLoad; //Field offset: 0x20
	private static Action<string> onVideoError; //Field offset: 0x24
	private static Action<string> onVideoCacheError; //Field offset: 0x28
	private static Action<string> onVideoViewStarted; //Field offset: 0x2C
	private static Action<string> onVideoViewFinished; //Field offset: 0x30
	private static Action<string> onVideoViewClosed; //Field offset: 0x34

	public static event Action<string> onNativeAdClicked
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onNativeAdClosed
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onNativeAdError
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onNativeAdShown
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onNativeCacheAdError
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onNativeDidLoad
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<bool> onNativeInitialize
	{
		 add { } //Length: 105
		 remove { } //Length: 209
	}

	public static event Action<string> onVideoCacheError
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onVideoDidLoad
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onVideoError
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onVideoViewClosed
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onVideoViewFinished
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<string> onVideoViewStarted
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	private static FacebookNativeAds() { }

	public static void add_onNativeAdClicked(Action<string> value) { }

	public static void add_onNativeAdClosed(Action<string> value) { }

	public static void add_onNativeAdError(Action<string> value) { }

	public static void add_onNativeAdShown(Action<string> value) { }

	public static void add_onNativeCacheAdError(Action<string> value) { }

	public static void add_onNativeDidLoad(Action<string> value) { }

	public static void add_onNativeInitialize(Action<bool> value) { }

	public static void add_onVideoCacheError(Action<string> value) { }

	public static void add_onVideoDidLoad(Action<string> value) { }

	public static void add_onVideoError(Action<string> value) { }

	public static void add_onVideoViewClosed(Action<string> value) { }

	public static void add_onVideoViewFinished(Action<string> value) { }

	public static void add_onVideoViewStarted(Action<string> value) { }

	public static void AddTestDevice(string deviceID) { }

	public static void AddTestDevices(List<string> deviceIDs) { }

	public static void CacheNativeAd(string cacheID) { }

	public static void Initialize() { }

	private static void InstantiateNativeBridge() { }

	public static bool IsCachedVideoAvailable(string placementId) { }

	private static bool IsInitialized() { }

	public static bool IsNativeAdLoaded(string cacheID) { }

	public static bool IsSupportedOnPlatform() { }

	public static void LoadVideoAd(string cacheID) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	private static void OnInitialize(bool succeeded) { }

	private static void OnNativeAdClosed(string cacheID) { }

	private static void OnNativeAdError(string message) { }

	private static void OnNativeAdShown(string cacheID) { }

	private static void OnNativeCacheAdError(string placement) { }

	private static void OnNativeDidLoad(string cacheID) { }

	private static void OnVideoCacheError(string placement) { }

	private static void OnVideoDidLoad(string message) { }

	private static void OnVideoError(string message) { }

	private static void OnVideoViewClosed(string message) { }

	private static void OnVideoViewFinished(string message) { }

	private static void OnVideoViewStarted(string message) { }

	public static void remove_onNativeAdClicked(Action<string> value) { }

	public static void remove_onNativeAdClosed(Action<string> value) { }

	public static void remove_onNativeAdError(Action<string> value) { }

	public static void remove_onNativeAdShown(Action<string> value) { }

	public static void remove_onNativeCacheAdError(Action<string> value) { }

	public static void remove_onNativeDidLoad(Action<string> value) { }

	public static void remove_onNativeInitialize(Action<bool> value) { }

	public static void remove_onVideoCacheError(Action<string> value) { }

	public static void remove_onVideoDidLoad(Action<string> value) { }

	public static void remove_onVideoError(Action<string> value) { }

	public static void remove_onVideoViewClosed(Action<string> value) { }

	public static void remove_onVideoViewFinished(Action<string> value) { }

	public static void remove_onVideoViewStarted(Action<string> value) { }

	public static void ShowInterstitial(string cacheID) { }

	public static void ShowVideo(string cacheID) { }

}

