namespace Kiloo.Monetization.FacebookAds.Internal;

public class FacebookNativeAdsIos : MonoBehaviour, IFacebookNativeAdsBridge
{
	private const string CALL_SOURCE = "FacebookNativeAdBridgeIOS"; //Field offset: 0x0
	private static FacebookNativeAdsIos _instance; //Field offset: 0x0
	private const string CALLBACK_RECEIVER_NAME = "FacebookAdsBridgeReceiver"; //Field offset: 0x0
	private Action<bool> onInitialize; //Field offset: 0xC
	private Action<string> onNativeAdLoaded; //Field offset: 0x10
	private Action<string> onNativeAdShown; //Field offset: 0x14
	private Action<string> onNativeAdClosed; //Field offset: 0x18
	private Action<string> onNativeAdError; //Field offset: 0x1C
	private Action<string> onNativeCacheAdError; //Field offset: 0x20
	private Action<string> onNativeClicked; //Field offset: 0x24
	private Action<string> onNativeLoggedImpression; //Field offset: 0x28
	private Action<string> onRewardedVideoDidLoad; //Field offset: 0x2C
	private Action<string> onRewardedVideoError; //Field offset: 0x30
	private Action<string> onRewardedVideoCacheError; //Field offset: 0x34
	private Action<string> onRewardedVideoCompleted; //Field offset: 0x38
	private Action<string> onRewardedVideoClosed; //Field offset: 0x3C
	private Action<string> onRewardedVideoStarted; //Field offset: 0x40

	public event Action<bool> onInitialize
	{
		 add { } //Length: 2
		 remove { } //Length: 111
	}

	public event Action<string> onNativeAdClosed
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onNativeAdError
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onNativeAdLoaded
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onNativeAdShown
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onNativeCacheAdError
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onNativeClicked
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onNativeLoggedImpression
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onRewardedVideoCacheError
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onRewardedVideoClosed
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onRewardedVideoCompleted
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onRewardedVideoDidLoad
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onRewardedVideoError
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> onRewardedVideoStarted
	{
		 add { } //Length: 111
		 remove { } //Length: 114
	}

	private void _callback_onInitialize() { }

	private void _callback_onNativeAdClick(string cacheID) { }

	private void _callback_onNativeAdClosed(string cacheID) { }

	private void _callback_onNativeAdDidLoad(string cacheID) { }

	private void _callback_onNativeAdError(string error) { }

	private void _callback_onNativeAdFinishHandlingClick(string cacheID) { }

	private void _callback_onNativeAdShown(string cacheID) { }

	private void _callback_onNativeAdWillLogImpression(string cacheID) { }

	private void _callback_onNativeCacheAdError(string placement) { }

	private void _callback_onVideoAdCacheError(string placement) { }

	private void _callback_onVideoAdComplete(string cacheID) { }

	private void _callback_onVideoAdDidClick(string cacheID) { }

	private void _callback_onVideoAdDidClose(string cacheID) { }

	private void _callback_onVideoAdDidLoad(string cacheID) { }

	private void _callback_onVideoAdError(string error) { }

	private void _callback_onVideoAdWillClose(string cacheID) { }

	private void _callback_onVideoAdWillLogImpression(string cacheID) { }

	private void _facebookAdsBridge_AddTestDevice(string deviceID) { }

	private void _facebookAdsBridge_InitializePlugin() { }

	private bool _facebookAdsBridge_IsNativeAdValid(string placementId) { }

	private bool _facebookAdsBridge_IsVideoAdValid(string placementId) { }

	private void _facebookAdsBridge_LoadNativeAd(string placementId) { }

	private void _facebookAdsBridge_LoadVideoAd(string placementId) { }

	private void _facebookAdsBridge_ShowNativeAd(string placementId, double width, double height) { }

	private void _facebookAdsBridge_ShowVideoAd(string placementId) { }

	public FacebookNativeAdsIos() { }

	public void add_onInitialize(Action<bool> value) { }

	public void add_onNativeAdClosed(Action<string> value) { }

	public void add_onNativeAdError(Action<string> value) { }

	public void add_onNativeAdLoaded(Action<string> value) { }

	public void add_onNativeAdShown(Action<string> value) { }

	public void add_onNativeCacheAdError(Action<string> value) { }

	public void add_onNativeClicked(Action<string> value) { }

	public void add_onNativeLoggedImpression(Action<string> value) { }

	public void add_onRewardedVideoCacheError(Action<string> value) { }

	public void add_onRewardedVideoClosed(Action<string> value) { }

	public void add_onRewardedVideoCompleted(Action<string> value) { }

	public void add_onRewardedVideoDidLoad(Action<string> value) { }

	public void add_onRewardedVideoError(Action<string> value) { }

	public void add_onRewardedVideoStarted(Action<string> value) { }

	public void AddTestDevice(string deviceID) { }

	public void CacheNativeAd(string cacheID) { }

	public static FacebookNativeAdsIos CreatePlugin() { }

	public void Initialize() { }

	public bool IsNativeAdLoaded(string cacheID) { }

	public bool IsVideoAdLoaded(string cacheID) { }

	public void LoadVideoAd(string cacheID) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	public void remove_onInitialize(Action<bool> value) { }

	public void remove_onNativeAdClosed(Action<string> value) { }

	public void remove_onNativeAdError(Action<string> value) { }

	public void remove_onNativeAdLoaded(Action<string> value) { }

	public void remove_onNativeAdShown(Action<string> value) { }

	public void remove_onNativeCacheAdError(Action<string> value) { }

	public void remove_onNativeClicked(Action<string> value) { }

	public void remove_onNativeLoggedImpression(Action<string> value) { }

	public void remove_onRewardedVideoCacheError(Action<string> value) { }

	public void remove_onRewardedVideoClosed(Action<string> value) { }

	public void remove_onRewardedVideoCompleted(Action<string> value) { }

	public void remove_onRewardedVideoDidLoad(Action<string> value) { }

	public void remove_onRewardedVideoError(Action<string> value) { }

	public void remove_onRewardedVideoStarted(Action<string> value) { }

	public void SetDebugLogs(bool enableLogs) { }

	public void ShowInterstitial(string cacheID) { }

	public void ShowVideo(string cacheID) { }

}

