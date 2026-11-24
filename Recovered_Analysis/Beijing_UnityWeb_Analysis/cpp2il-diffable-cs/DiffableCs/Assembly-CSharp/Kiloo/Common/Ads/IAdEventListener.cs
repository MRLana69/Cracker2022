namespace Kiloo.Common.Ads;

public interface IAdEventListener
{

	public void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

	public void CachingTimedOut(AdType adType, string providerID, string adLocationID) { }

	public void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID) { }

	public void ClickedAd(AdType adType, string providerID, string adLocationID) { }

	public void DismissedAd(AdType adType, string providerID, string adLocationID) { }

	public void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

	public void FailedToInitAdProvider(string providerID) { }

	public void FailedToShowAd(AdType adType, string providerID, string adLocationID) { }

	public void FinishedWatchingVideo(string providerID, string adLocationID) { }

	public void PriorityListWrapped(string waterfallID) { }

	public void ReachedDailyInterstitialLimit(int limit) { }

	public void ReachedHourlyInterstitialLimit(int limit) { }

	public void ReachedNewUserInterstitialLimit(int limit) { }

	public void ReachedTimeBetweenAdsInterstitialLimit(int limit) { }

	public void ShowedAd(AdType adType, string providerID, string adLocationID) { }

	public void StartedCachingAd(AdType adType, string providerID, string adLocationID) { }

	public void WillShowAd(AdType adType, string providerID, string adLocationID) { }

}

