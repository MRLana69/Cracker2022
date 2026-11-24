namespace Kiloo.Monetization.FlurryPlugin.Internal;

public interface IFlurryVideoAds
{

	public event FlurryAdsCallback onAdClickedEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event FlurryAdsCallback onAdClosedEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event FlurryAdsCallback onAdOpenedEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event FlurryAdsCallback onApplicationExitEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<bool> onInitFinished
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event FlurryAdsCallback onRenderFailedEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event FlurryAdsCallback onSpaceDidFailToReceiveAdEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event FlurryAdsCallback onSpaceDidReceiveAdEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event FlurryAdsCallback onVideoCompletedEvent
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public void add_onAdClickedEvent(FlurryAdsCallback value) { }

	public void add_onAdClosedEvent(FlurryAdsCallback value) { }

	public void add_onAdOpenedEvent(FlurryAdsCallback value) { }

	public void add_onApplicationExitEvent(FlurryAdsCallback value) { }

	public void add_onInitFinished(Action<bool> value) { }

	public void add_onRenderFailedEvent(FlurryAdsCallback value) { }

	public void add_onSpaceDidFailToReceiveAdEvent(FlurryAdsCallback value) { }

	public void add_onSpaceDidReceiveAdEvent(FlurryAdsCallback value) { }

	public void add_onVideoCompletedEvent(FlurryAdsCallback value) { }

	public void DisplayAd(string adSpace) { }

	public void EnableDebugLogs() { }

	public void EnableTestAds() { }

	public void FetchAd(string adSpace) { }

	public void Initialize() { }

	public bool IsReady(string adSpace) { }

	public void remove_onAdClickedEvent(FlurryAdsCallback value) { }

	public void remove_onAdClosedEvent(FlurryAdsCallback value) { }

	public void remove_onAdOpenedEvent(FlurryAdsCallback value) { }

	public void remove_onApplicationExitEvent(FlurryAdsCallback value) { }

	public void remove_onInitFinished(Action<bool> value) { }

	public void remove_onRenderFailedEvent(FlurryAdsCallback value) { }

	public void remove_onSpaceDidFailToReceiveAdEvent(FlurryAdsCallback value) { }

	public void remove_onSpaceDidReceiveAdEvent(FlurryAdsCallback value) { }

	public void remove_onVideoCompletedEvent(FlurryAdsCallback value) { }

}

