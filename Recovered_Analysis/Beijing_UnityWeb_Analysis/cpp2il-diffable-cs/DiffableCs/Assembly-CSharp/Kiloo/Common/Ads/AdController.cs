namespace Kiloo.Common.Ads;

public class AdController
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<AdLocation> <>9__33_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__33_0(AdLocation location) { }

	}

	private sealed class <>c__DisplayClass29_0
	{
		public AdType adType; //Field offset: 0x8

		public <>c__DisplayClass29_0() { }

		internal bool <IsCached>b__0(AdLocation location) { }

	}

	private sealed class <>c__DisplayClass38_0
	{
		public string adLocationId; //Field offset: 0x8

		public <>c__DisplayClass38_0() { }

		internal bool <SetProviderForAdLocation>b__0(AdLocation item) { }

	}

	private sealed class <>c__DisplayClass46_0
	{
		public AdController <>4__this; //Field offset: 0x8
		public AdType adType; //Field offset: 0xC
		public PriorityList list; //Field offset: 0x10
		public string waterfallID; //Field offset: 0x14

		public <>c__DisplayClass46_0() { }

		internal void <CreatePriorityListForID>b__0() { }

		internal void <CreatePriorityListForID>b__1() { }

	}

	private sealed class <>c__DisplayClass49_0
	{
		public string adLocationID; //Field offset: 0x8

		public <>c__DisplayClass49_0() { }

		internal bool <GetAdLocationFromID>b__0(AdLocation l) { }

	}

	private sealed class <CheckCacheExpiredCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AdController <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1239
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CheckCacheExpiredCoroutine>d__31(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class CacheList
	{
		public readonly List<AdLocation> list; //Field offset: 0x8
		public readonly int capacity; //Field offset: 0xC
		private int _locationToShowNext; //Field offset: 0x10

		public int count
		{
			 get { } //Length: 9
		}

		public CacheList(int capacity) { }

		public void Add(AdLocation location) { }

		public void AdvanceShowPointer() { }

		public int get_count() { }

		public AdLocation GetLocationToShow() { }

	}

	public class EventHandler : AdEventListenerAdapter
	{
		private AdController _controller; //Field offset: 0x8

		public EventHandler(AdController controller) { }

		public override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

		public override void CachingTimedOut(AdType adType, string providerID, string adLocationID) { }

		public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

		public override void FailedToInitAdProvider(string providerID) { }

		public override void FailedToShowAd(AdType adType, string providerID, string adLocationID) { }

		private void HandleFail(string providerID, string adLocationID) { }

		private bool IncrementFailCount(string waterfallID) { }

		public override void ShowedAd(AdType adType, string providerID, string adLocationID) { }

	}

	private const int DEFAULT_NUMBER_OF_INTERSTITIALS_TO_CACHE = 1; //Field offset: 0x0
	private const string ONLINE_SETTINGS_KEY_AD_MAX_EXPIRY_CHECK_INTERVAL = "ad_expiry_max_check_interval"; //Field offset: 0x0
	private const string ONLINE_SETTINGS_KEY_AD_MIN_EXPIRY_CHECK_INTERVAL = "ad_expiry_min_check_interval"; //Field offset: 0x0
	private const float DEFAULT_AD_EXPIRY_MAX_CHECK_INTERVAL = 30; //Field offset: 0x0
	private const float DEFAULT_AD_EXPIRY_MIN_CHECK_INTERVAL = 10; //Field offset: 0x0
	private const string ONLINE_SETTINGS_KEY_NUMBER_OF_INTERSTITIALS_TO_CACHE = "interstitial_ads_cache_pool_size"; //Field offset: 0x0
	private const string ONLINE_SETTINGS_KEY_NUMBER_OF_VIDEO_ADS_TO_CACHE = "video_ads_cache_pool_size"; //Field offset: 0x0
	private const int DEFAULT_NUMBER_OF_VIDEO_ADS_TO_CACHE = 2; //Field offset: 0x0
	private readonly IAdSettingsProvider _settings; //Field offset: 0x8
	private readonly List<AdLocation> _adLocations; //Field offset: 0xC
	private readonly Dictionary<string, PriorityList> _idToPriorityList; //Field offset: 0x10
	private DateTime _timeOfLastVideo; //Field offset: 0x18
	private DateTime _timeOfLastInterstitial; //Field offset: 0x20
	private InterstitialStats _interstitialStats; //Field offset: 0x28
	private List<IAdEventListener> _eventListeners; //Field offset: 0x2C
	private readonly Dictionary<AdType, CacheList> _cacheLists; //Field offset: 0x30
	private bool <allowReCacheOnFail>k__BackingField; //Field offset: 0x34

	private static float adExpiryMaxCheckInterval
	{
		 get { } //Length: 89
	}

	private static float adExpiryMinCheckInterval
	{
		 get { } //Length: 96
	}

	public bool allowReCacheOnFail
	{
		 get { } //Length: 278
		 set { } //Length: 27
	}

	public AdController(IAdSettingsProvider settings, ICollection<AdLocationInfo> adLocations, InterstitialStats interstitialStats) { }

	public void AddEventListener(IAdEventListener eventListener) { }

	public bool AreInterstitialsAllowed() { }

	public void Cache(AdLocation specificLocation = null) { }

	public void ChangeToNextProvider() { }

	private IEnumerator CheckCacheExpiredCoroutine() { }

	private PriorityList CreatePriorityListForID(string waterfallID, AdType adType, IAdSettingsProvider settings) { }

	private static float get_adExpiryMaxCheckInterval() { }

	private static float get_adExpiryMinCheckInterval() { }

	public bool get_allowReCacheOnFail() { }

	private AdLocation GetAdLocationFromID(string adLocationID) { }

	public bool GetAvailabilityForLocation(string locationID) { }

	private AbstractAdProvider GetCurrentProvider(AdLocation adLocation) { }

	public string GetCurrentProviderIDForLocation(string locationID) { }

	public uint GetGracePeriodValue() { }

	public string GetInfo() { }

	public string GetWaterfallID(AdLocationInfo adLocation) { }

	private bool HasPriorityListChanged(AdLocation adLocation) { }

	public bool HasPriorityListWrapped(string locationID) { }

	public bool IsCached(AdType adType) { }

	public bool IsCachedDebug(AdLocationInfo adLocationInfo) { }

	public bool IsCaching(string adLocationID) { }

	public void RemoveEventListener(IAdEventListener eventListener) { }

	public void set_allowReCacheOnFail(bool value) { }

	public void SetDebugPriorityListVersion(AdType adtype, string version) { }

	public void SetProviderForAdLocation(string adLocationId, AbstractAdProvider provider) { }

	public bool Show(string adLocationID) { }

	public void UpdateCacheIdsFromOnlineSettings() { }

	public void UpdateInterstitialStats(InterstitialStats stats) { }

	private void UpdatePriorityListForID(string waterfallID, AdType adType) { }

}

