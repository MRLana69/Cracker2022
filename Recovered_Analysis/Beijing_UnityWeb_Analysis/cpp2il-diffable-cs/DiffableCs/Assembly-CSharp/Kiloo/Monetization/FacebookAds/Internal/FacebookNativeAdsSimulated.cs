namespace Kiloo.Monetization.FacebookAds.Internal;

public class FacebookNativeAdsSimulated : MonoBehaviour, IFacebookNativeAdsBridge
{
	private const string CALLBACK_RECEIVER_NAME = "FacebookAdSimulatedReceiver"; //Field offset: 0x0
	private bool _adReady; //Field offset: 0xC
	private bool _adLoading; //Field offset: 0xD
	private bool _initialized; //Field offset: 0xE
	private Action<bool> onInitialize; //Field offset: 0x10
	private Action<string> onNativeAdLoaded; //Field offset: 0x14
	private Action<string> onNativeAdShown; //Field offset: 0x18
	private Action<string> onNativeAdClosed; //Field offset: 0x1C
	private Action<string> onNativeAdError; //Field offset: 0x20
	private Action<string> onNativeCacheAdError; //Field offset: 0x24
	private Action<string> onNativeClicked; //Field offset: 0x28
	private Action<string> onNativeLoggedImpression; //Field offset: 0x2C
	private Action<string> onRewardedVideoDidLoad; //Field offset: 0x30
	private Action<string> onRewardedVideoError; //Field offset: 0x34
	private Action<string> onRewardedVideoCacheError; //Field offset: 0x38
	private Action<string> onRewardedVideoCompleted; //Field offset: 0x3C
	private Action<string> onRewardedVideoClosed; //Field offset: 0x40
	private Action<string> onRewardedVideoStarted; //Field offset: 0x44

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
		 remove { } //Length: 114
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
		 add { } //Length: 114
		 remove { } //Length: 112
	}

	public FacebookNativeAdsSimulated() { }

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

	public static FacebookNativeAdsSimulated CreatePlugin() { }

	public void Initialize() { }

	public bool IsNativeAdLoaded(string cacheID) { }

	public bool IsVideoAdLoaded(string cacheID) { }

	public void LoadVideoAd(string cacheID) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	public void LogExternalClick(string cacheID) { }

	public void LogExternalImpression(string cacheID) { }

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

