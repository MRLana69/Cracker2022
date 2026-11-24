using System;

namespace Kiloo.Monetization.FlurryPlugin.Internal;

public interface IFlurryVideoAds
{
	event FlurryAdsCallback onAdClosedEvent;

	event FlurryAdsCallback onApplicationExitEvent;

	event FlurryAdsCallback onRenderFailedEvent;

	event FlurryAdsCallback onSpaceDidFailToReceiveAdEvent;

	event FlurryAdsCallback onSpaceDidReceiveAdEvent;

	event FlurryAdsCallback onAdClickedEvent;

	event FlurryAdsCallback onAdOpenedEvent;

	event FlurryAdsCallback onVideoCompletedEvent;

	event Action<bool> onInitFinished;

	void Initialize();

	bool IsReady(string adSpace);

	void FetchAd(string adSpace);

	void DisplayAd(string adSpace);

	void EnableDebugLogs();

	void EnableTestAds();
}
