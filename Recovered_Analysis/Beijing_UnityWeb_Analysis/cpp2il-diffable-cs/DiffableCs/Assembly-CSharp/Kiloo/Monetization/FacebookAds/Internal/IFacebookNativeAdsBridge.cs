namespace Kiloo.Monetization.FacebookAds.Internal;

public interface IFacebookNativeAdsBridge
{

	public event Action<bool> onInitialize
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onNativeAdClosed
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onNativeAdError
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onNativeAdLoaded
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onNativeAdShown
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onNativeCacheAdError
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onNativeClicked
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onNativeLoggedImpression
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onRewardedVideoCacheError
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onRewardedVideoClosed
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onRewardedVideoCompleted
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onRewardedVideoDidLoad
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onRewardedVideoError
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<string> onRewardedVideoStarted
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

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

	public void Initialize() { }

	public bool IsNativeAdLoaded(string cacheID) { }

	public bool IsVideoAdLoaded(string cacheID) { }

	public void LoadVideoAd(string cacheID) { }

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

