//Type is in global namespace

public class AdSystemManager : AdEventListenerAdapter
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__56_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Initialize>b__56_0() { }

	}

	public const string LAST_SHOWED_PROVIDER_SAVED_SUFFIX = "_(saved)"; //Field offset: 0x0
	private const string ONLINE_SETTINGS_ALLOW_RECACHE_DURING_RUN_KEY = "allow_recache_during_run"; //Field offset: 0x0
	private static Action onAdSystemInitialized; //Field offset: 0x0
	private static Action<string> onWillShowVideo; //Field offset: 0x4
	private static Action<string> onShowedVideo; //Field offset: 0x8
	private static Action<string> onFailedToShowVideo; //Field offset: 0xC
	private static Action<string> onDismissedVideo; //Field offset: 0x10
	private static Action<string, bool> onCachedVideo; //Field offset: 0x14
	private static Action<string> onFailedToCacheVideo; //Field offset: 0x18
	private static Action<string> onFinishedWatchingVideo; //Field offset: 0x1C
	private static Action<string> onWillShowInterstitial; //Field offset: 0x20
	private static Action<string> onCachedInterstitial; //Field offset: 0x24
	private static Action<string> onFailedToCacheInterstitial; //Field offset: 0x28
	private static Action<string> onShowedInterstitial; //Field offset: 0x2C
	private static Action<string> onFailedToShowInterstitial; //Field offset: 0x30
	private static Action<string> onDismissedInterstitial; //Field offset: 0x34
	private static Action<string> onPriorityListWrapped; //Field offset: 0x38
	private static Action<string> onChangedProvider; //Field offset: 0x3C
	private static AdSystemManager _instance; //Field offset: 0x40
	private bool _isInitialized; //Field offset: 0x8
	private bool _showAllowed; //Field offset: 0x9
	private AdController _adController; //Field offset: 0xC
	private AdLocationInfo _currentlyShowingAdAtLocation; //Field offset: 0x10
	private Dictionary<string, string> _lastShowedProviderPerLocation; //Field offset: 0x14
	private Action _videoReward; //Field offset: 0x18

	public static event Action onAdSystemInitialized
	{
		 add { } //Length: 65
		 remove { } //Length: 126
	}

	public static event Action<string> onCachedInterstitial
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string, bool> onCachedVideo
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onChangedProvider
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onDismissedInterstitial
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onDismissedVideo
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onFailedToCacheInterstitial
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onFailedToCacheVideo
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onFailedToShowInterstitial
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onFailedToShowVideo
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onFinishedWatchingVideo
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onPriorityListWrapped
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onShowedInterstitial
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onShowedVideo
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onWillShowInterstitial
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<string> onWillShowVideo
	{
		 add { } //Length: 126
		 remove { } //Length: 129
	}

	public static AdSystemManager instance
	{
		 get { } //Length: 81
	}

	public static bool isInitialized
	{
		 get { } //Length: 971
	}

	private AdSystemManager() { }

	private void <Show>b__66_0() { }

	public static void add_onAdSystemInitialized(Action value) { }

	public static void add_onCachedInterstitial(Action<string> value) { }

	public static void add_onCachedVideo(Action<string, bool> value) { }

	public static void add_onChangedProvider(Action<string> value) { }

	public static void add_onDismissedInterstitial(Action<string> value) { }

	public static void add_onDismissedVideo(Action<string> value) { }

	public static void add_onFailedToCacheInterstitial(Action<string> value) { }

	public static void add_onFailedToCacheVideo(Action<string> value) { }

	public static void add_onFailedToShowInterstitial(Action<string> value) { }

	public static void add_onFailedToShowVideo(Action<string> value) { }

	public static void add_onFinishedWatchingVideo(Action<string> value) { }

	public static void add_onPriorityListWrapped(Action<string> value) { }

	public static void add_onShowedInterstitial(Action<string> value) { }

	public static void add_onShowedVideo(Action<string> value) { }

	public static void add_onWillShowInterstitial(Action<string> value) { }

	public static void add_onWillShowVideo(Action<string> value) { }

	private void AppHasRefreshed(RefreshType refreshType) { }

	public bool AreInterstitialsAllowed() { }

	public void Cache() { }

	public override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

	public override void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID) { }

	public void ChangeToNextProvider() { }

	public void DisableAudio() { }

	public override void DismissedAd(AdType adType, string providerID, string adLocationID) { }

	public void EnableAudio() { }

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

	public override void FailedToShowAd(AdType adType, string providerID, string adLocationID) { }

	public override void FinishedWatchingVideo(string providerID, string adLocationID) { }

	public static AdSystemManager get_instance() { }

	public static bool get_isInitialized() { }

	public bool GetAvailabilityForLocation(string locationID) { }

	public string GetCurrentProviderIDForLocation(string locationID) { }

	public uint GetGracePeriodValue() { }

	public string GetIdOfAdlocationBeingShown() { }

	public string GetLastShowedProviderForLocation(string locationID) { }

	private void GiveReward() { }

	private void HandleOnWillShowScreen(string screenName) { }

	public bool HasPriorityListWrapped(string locationID) { }

	private void HideOverlay(AdType adType) { }

	private void Initialize() { }

	public bool IsCached(AdLocationInfo info) { }

	public bool IsCachedDebug(AdLocationInfo adLocationInfo) { }

	public bool IsCaching(string adLocationID) { }

	private void LoadLastShowedProviders() { }

	private void OnOnlineSettingsDownloadResult(bool b) { }

	public override void PriorityListWrapped(string waterfallID) { }

	public static void remove_onAdSystemInitialized(Action value) { }

	public static void remove_onCachedInterstitial(Action<string> value) { }

	public static void remove_onCachedVideo(Action<string, bool> value) { }

	public static void remove_onChangedProvider(Action<string> value) { }

	public static void remove_onDismissedInterstitial(Action<string> value) { }

	public static void remove_onDismissedVideo(Action<string> value) { }

	public static void remove_onFailedToCacheInterstitial(Action<string> value) { }

	public static void remove_onFailedToCacheVideo(Action<string> value) { }

	public static void remove_onFailedToShowInterstitial(Action<string> value) { }

	public static void remove_onFailedToShowVideo(Action<string> value) { }

	public static void remove_onFinishedWatchingVideo(Action<string> value) { }

	public static void remove_onPriorityListWrapped(Action<string> value) { }

	public static void remove_onShowedInterstitial(Action<string> value) { }

	public static void remove_onShowedVideo(Action<string> value) { }

	public static void remove_onWillShowInterstitial(Action<string> value) { }

	public static void remove_onWillShowVideo(Action<string> value) { }

	public void SetProviderForAdLocation(string adLocationId, AbstractAdProvider provider) { }

	public void Show(AdLocationInfo adLocationInfo, Action videoPayout = null) { }

	private void ShowAd(AdLocationInfo adLocationInfo) { }

	public override void ShowedAd(AdType adType, string providerID, string adLocationID) { }

	private void ShowOverlay(AdType adType, string adLocationID) { }

	private void ShowTransitionOverlay(AdType adType, string adLocationID) { }

	private void SkipVideoAd() { }

	private void UpdateCacheIdsFromOnlineSettings() { }

	public void UpdateDebugPriorityListVersion(AdType adType) { }

	private void UpdateLastShowedProviders(string adLocationID, string providerID, bool shouldSave) { }

	public override void WillShowAd(AdType adType, string providerID, string adLocationID) { }

}

