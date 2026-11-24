namespace Kiloo.Monetization.FacebookAds.Internal;

public class FacebookNativeAdsAndroid : MonoBehaviour, IFacebookNativeAdsBridge
{
	private const string CALLBACK_RECEIVER_NAME = "FacebookAdAndroidReceiver"; //Field offset: 0x0
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

	private void _callback_onNativeAdCacheError(string cacheID) { }

	private void _callback_onNativeAdClicked(string cacheID) { }

	private void _callback_onNativeAdClosed(string cacheID) { }

	private void _callback_onNativeAdError(string error) { }

	private void _callback_onNativeAdInitialize(string succeeded) { }

	private void _callback_onNativeAdLoaded(string cacheID) { }

	private void _callback_onNativeAdShown(string cacheId) { }

	private void _callback_onNativeLoggedImpression(string cacheID) { }

	private void _callback_onRewardedVideoClosed(string placementID) { }

	private void _callback_onRewardedVideoCompleted(string placementID) { }

	private void _callback_onRewardedVideoDidLoad(string placementID) { }

	private void _callback_onRewardedVideoStarted(string placementID) { }

	private void _callback_onVideoAdError(string message) { }

	private void _callback_onVideoCacheAdError(string cacheID) { }

	public FacebookNativeAdsAndroid() { }

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

	private void Call(string method, object[] args) { }

	private T Call(string method, object[] args) { }

	public static FacebookNativeAdsAndroid CreatePlugin() { }

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

