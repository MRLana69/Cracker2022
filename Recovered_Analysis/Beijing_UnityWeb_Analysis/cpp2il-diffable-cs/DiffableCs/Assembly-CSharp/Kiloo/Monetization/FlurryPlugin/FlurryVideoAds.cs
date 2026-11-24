namespace Kiloo.Monetization.FlurryPlugin;

public static class FlurryVideoAds
{
	private static IFlurryVideoAds _platformBridge; //Field offset: 0x0
	private static bool _initialized; //Field offset: 0x4
	private static FlurryAdsCallback onTakeoverWillDisplay; //Field offset: 0x8
	private static FlurryAdsCallback onTakeoverWillClose; //Field offset: 0xC
	private static FlurryAdsCallback onVideoDidFinish; //Field offset: 0x10
	private static FlurryAdsCallback onVideoDidNotFinish; //Field offset: 0x14
	private static FlurryAdsCallback onVideoAvailable; //Field offset: 0x18
	private static FlurryAdsCallback onVideoUnavailable; //Field offset: 0x1C
	private static FlurryAdsCallback onVideoClicked; //Field offset: 0x20
	private static Action<bool> onInitFinished; //Field offset: 0x24

	public static event Action<bool> onInitFinished
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event FlurryAdsCallback onTakeoverWillClose
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event FlurryAdsCallback onTakeoverWillDisplay
	{
		 add { } //Length: 150
		 remove { } //Length: 209
	}

	public static event FlurryAdsCallback onVideoAvailable
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event FlurryAdsCallback onVideoClicked
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event FlurryAdsCallback onVideoDidFinish
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event FlurryAdsCallback onVideoDidNotFinish
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event FlurryAdsCallback onVideoUnavailable
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	private static FlurryVideoAds() { }

	public static void add_onInitFinished(Action<bool> value) { }

	public static void add_onTakeoverWillClose(FlurryAdsCallback value) { }

	public static void add_onTakeoverWillDisplay(FlurryAdsCallback value) { }

	public static void add_onVideoAvailable(FlurryAdsCallback value) { }

	public static void add_onVideoClicked(FlurryAdsCallback value) { }

	public static void add_onVideoDidFinish(FlurryAdsCallback value) { }

	public static void add_onVideoDidNotFinish(FlurryAdsCallback value) { }

	public static void add_onVideoUnavailable(FlurryAdsCallback value) { }

	public static void CacheAd(string adSpace) { }

	public static void EnableDebugLogs() { }

	public static void EnableTestAds() { }

	public static bool HasCachedAd(string adSpace) { }

	public static void Initialize() { }

	private static bool IsInitialized() { }

	public static bool IsSupportedOnPlatform() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	public static void remove_onInitFinished(Action<bool> value) { }

	public static void remove_onTakeoverWillClose(FlurryAdsCallback value) { }

	public static void remove_onTakeoverWillDisplay(FlurryAdsCallback value) { }

	public static void remove_onVideoAvailable(FlurryAdsCallback value) { }

	public static void remove_onVideoClicked(FlurryAdsCallback value) { }

	public static void remove_onVideoDidFinish(FlurryAdsCallback value) { }

	public static void remove_onVideoDidNotFinish(FlurryAdsCallback value) { }

	public static void remove_onVideoUnavailable(FlurryAdsCallback value) { }

	public static void ShowAd(string adSpace) { }

}

