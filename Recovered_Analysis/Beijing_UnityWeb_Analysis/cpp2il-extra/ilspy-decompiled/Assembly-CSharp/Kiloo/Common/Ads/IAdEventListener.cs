namespace Kiloo.Common.Ads;

public interface IAdEventListener
{
	void WillShowAd(AdType adType, string providerID, string adLocationID);

	void ShowedAd(AdType adType, string providerID, string adLocationID);

	void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached);

	void DismissedAd(AdType adType, string providerID, string adLocationID);

	void StartedCachingAd(AdType adType, string providerID, string adLocationID);

	void FinishedWatchingVideo(string providerID, string adLocationID);

	void FailedToCacheAd(AdType adType, string providerID, string adLocationID);

	void FailedToShowAd(AdType adType, string providerID, string adLocationID);

	void FailedToInitAdProvider(string providerID);

	void CachingTimedOut(AdType adType, string providerID, string adLocationID);

	void ClickedAd(AdType adType, string providerID, string adLocationID);

	void ReachedDailyInterstitialLimit(int limit);

	void ReachedHourlyInterstitialLimit(int limit);

	void ReachedNewUserInterstitialLimit(int limit);

	void ReachedTimeBetweenAdsInterstitialLimit(int limit);

	void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID);

	void PriorityListWrapped(string waterfallID);
}
