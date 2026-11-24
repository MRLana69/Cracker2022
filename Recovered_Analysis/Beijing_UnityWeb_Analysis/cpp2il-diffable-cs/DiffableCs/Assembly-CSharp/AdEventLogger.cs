//Type is in global namespace

public class AdEventLogger : IAdEventListener
{
	private struct CacheAttemptInfo
	{
		public AdType adType; //Field offset: 0x0
		public string providerID; //Field offset: 0x4
		public DateTime startCacheTime; //Field offset: 0x8
		public TimeSpan timePaused; //Field offset: 0x10

	}

	private const string EVENT_INTERSTITIAL_PROVIDER_REQUEST = "AdSystem2.0_Interstitial Providers Request"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_VIDEO_REQUEST_SUCCESS = "Success"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_VIDEO_REQUEST_FAILED = "Failed"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_VIDEO_REQUEST_TIMEDOUT = "Timedout"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_VIDEO_SHOW_START = "Video starts"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_VIDEO_SHOW_COMPLETE = "Video completes"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_VIDEO_SHOW_CLICKED = "Video clicked"; //Field offset: 0x0
	private const string EVENT_ARGKEY_INTERSTITIAL_LIMIT = "Limit"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_VIDEO_SHOW_FAILED = "Video failed to show"; //Field offset: 0x0
	private const string EVENT_ARGKEY_PROVIDER_FAILED = "{0} Fails"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_PROVIDER = "Provider"; //Field offset: 0x0
	private const string EVENT_ARGKEY_CACHE_TIME = "{0}{1}{2} Time"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_WATERFALL_INTEGER = "Integer"; //Field offset: 0x0
	private const string EVENT_ARGKEY_WATERFALL_COUNT = "{0}_{1}"; //Field offset: 0x0
	private const int WATERFALL_COUNT_LIMIT = 20; //Field offset: 0x0
	private const string EVENT_ARGKEY_PROVIDER_RESULT = "{0}_{1} Result"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_INTERSTITIAL_CLICK = "Click"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_INTERSTITIAL_DISMISSED = "Dismissed Ad"; //Field offset: 0x0
	private const string EVENT_VIDEOADS_PROVIDER_SHOW = "AdSystem2.0_VideoAds Providers Show"; //Field offset: 0x0
	private const string EVENT_INTERSTITIAL_PROVIDER_SHOW = "AdSystem2.0_Interstitial Providers Show"; //Field offset: 0x0
	private const string EVENT_INTERSTITIAL_SHOW_DAILY_LIMIT_REACHED = "AdSystem2.0_Interstitials Show Daily Limit Reached"; //Field offset: 0x0
	private const string EVENT_INTERSTITIAL_SHOW_HOURLY_LIMIT_REACHED = "AdSystem2.0_Interstitials Show Hourly Limit Reached"; //Field offset: 0x0
	private const string EVENT_INTERSTITIAL_SHOW_NEW_USER_LIMIT_REACHED = "AdSystem2.0_Interstitials Show New User Limit Reached"; //Field offset: 0x0
	private const string EVENT_INTERSTITIAL_SHOW_TIME_BETWEEN_ADS_LIMIT_REACHED = "AdSystem2.0_Interstitials Show Time Between Ads Limit Reached"; //Field offset: 0x0
	private const string EVENT_VIDEOADS_CACHE_REQUEST_ENDED = "AdSystem2.0_VideoAds Cache Request Ended"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_INTERSTITIAL_SHOW_AD = "Show Ad"; //Field offset: 0x0
	private const string EVENT_VIDEOADS_FAILED_TO_SHOW = "AdSystem2.0_Failed To Show Video Provider"; //Field offset: 0x0
	private const string EVENT_ADS_CACHING_TIME = "AdSystem2.0_Ads Caching Time"; //Field offset: 0x0
	private const string EVENT_FAILED_TO_INITIALIZE_PROVIDER = "AdSystem2.0_Failed To Initialize Provider"; //Field offset: 0x0
	private const string EVENT_END_OF_WATERFALL = "AdSystem2.0_End of waterfall"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_SUCCESS = "Request Success"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_FAILED = "Request Failed"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_TIMEOUT = "Request TimeOut"; //Field offset: 0x0
	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_FAILED_TO_SHOW = "Request Failed To Show"; //Field offset: 0x0
	private readonly string EVENT_ARGKEY_WATERFALL_ABOVE_LIMIT; //Field offset: 0x8
	private Dictionary<string, int> _priorityListIterationCounter; //Field offset: 0xC
	private Dictionary<string, CacheAttemptInfo> _cacheInfo; //Field offset: 0x10
	private DateTime _onPauseTime; //Field offset: 0x18

	public AdEventLogger() { }

	public void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

	public void CachingTimedOut(AdType adType, string providerID, string adLocationID) { }

	public void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID) { }

	public void ClickedAd(AdType adType, string providerID, string adLocationID) { }

	public void DismissedAd(AdType adType, string providerID, string adLocationID) { }

	public void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

	public void FailedToInitAdProvider(string providerID) { }

	public void FailedToShowAd(AdType adType, string providerID, string adLocationID) { }

	public void FinishedWatchingVideo(string providerID, string adLocationID) { }

	private void LogCacheTime(AdType adType, string providerID, string adLocationID, string status) { }

	private void LogProviderResult(string providerID, string adLocationID, string eventName, string eventValue) { }

	private void OnApplicationPaused() { }

	private void OnApplicationResumed() { }

	public void PriorityListWrapped(string waterfallID) { }

	public void ReachedDailyInterstitialLimit(int limit) { }

	public void ReachedHourlyInterstitialLimit(int limit) { }

	public void ReachedNewUserInterstitialLimit(int limit) { }

	public void ReachedTimeBetweenAdsInterstitialLimit(int limit) { }

	public void ShowedAd(AdType adType, string providerID, string adLocationID) { }

	public void StartedCachingAd(AdType adType, string providerID, string adLocationID) { }

	public void WillShowAd(AdType adType, string providerID, string adLocationID) { }

}

