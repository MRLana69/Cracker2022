namespace Kiloo.Common.JsonUtil;

public class AdSystemEventLogger : AdEventListenerAdapter
{
	private bool <clicked>k__BackingField; //Field offset: 0x8
	private CacheFailSource <cacheFailSource>k__BackingField; //Field offset: 0xC
	private AdState <adState>k__BackingField; //Field offset: 0x10

	public AdState adState
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public CacheFailSource cacheFailSource
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public bool clicked
	{
		 get { } //Length: 950
		private set { } //Length: 8
	}

	public AdSystemEventLogger() { }

	public override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

	public override void CachingTimedOut(AdType adType, string providerID, string adLocationID) { }

	public override void ClickedAd(AdType adType, string providerID, string adLocationID) { }

	public override void DismissedAd(AdType adType, string providerID, string adLocationID) { }

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

	public override void FailedToShowAd(AdType adType, string providerID, string adLocationID) { }

	public override void FinishedWatchingVideo(string providerID, string adLocationID) { }

	public AdState get_adState() { }

	public CacheFailSource get_cacheFailSource() { }

	public bool get_clicked() { }

	private string GetAdShownPrefix(AdType adType) { }

	private string GetCurrentProviderIDForLocation(string adLocationId) { }

	private string GetIdOfAdlocationBeingShown() { }

	private string GetResultOfVideoShown(AdType adType, string providerId) { }

	private string GetVideoShownPrefix() { }

	public override void PriorityListWrapped(string waterfallID) { }

	private void set_adState(AdState value) { }

	private void set_cacheFailSource(CacheFailSource value) { }

	private void set_clicked(bool value) { }

	public override void ShowedAd(AdType adType, string providerID, string adLocationID) { }

}

