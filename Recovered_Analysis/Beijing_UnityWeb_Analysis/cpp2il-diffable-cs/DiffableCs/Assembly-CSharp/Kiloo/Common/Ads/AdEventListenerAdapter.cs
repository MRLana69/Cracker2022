namespace Kiloo.Common.Ads;

public class AdEventListenerAdapter : IAdEventListener
{

	public AdEventListenerAdapter() { }

	protected virtual void AdFailed(AdType adType, string providerID, string adLocationID) { }

	public virtual void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

	public virtual void CachingTimedOut(AdType adType, string providerID, string adLocationID) { }

	public virtual void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID) { }

	public virtual void ClickedAd(AdType adType, string providerID, string adLocationID) { }

	public virtual void DismissedAd(AdType adType, string providerID, string adLocationID) { }

	public virtual void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

	public virtual void FailedToInitAdProvider(string providerID) { }

	public virtual void FailedToShowAd(AdType adType, string providerID, string adLocationID) { }

	public virtual void FinishedWatchingVideo(string providerID, string adLocationID) { }

	public virtual void PriorityListWrapped(string waterfallID) { }

	public virtual void ReachedDailyInterstitialLimit(int limit) { }

	public virtual void ReachedHourlyInterstitialLimit(int limit) { }

	public virtual void ReachedNewUserInterstitialLimit(int limit) { }

	public virtual void ReachedTimeBetweenAdsInterstitialLimit(int limit) { }

	public virtual void ShowedAd(AdType adType, string providerID, string adLocationID) { }

	public virtual void StartedCachingAd(AdType adType, string providerID, string adLocationID) { }

	public virtual void WillShowAd(AdType adType, string providerID, string adLocationID) { }

}

