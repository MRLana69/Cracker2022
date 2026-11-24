namespace Kiloo.Common.Ads;

public abstract class AbstractAdProvider : AdEventListenerAdapter
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, bool> <>9__44_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <GetAbstractAdProviderSubTypes>b__44_0(Type t) { }

	}

	private sealed class <GetAbstractAdProviderSubTypes>d__44 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private Type <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private Assembly[] <>7__wrap1; //Field offset: 0x14
		private int <>7__wrap2; //Field offset: 0x18
		private IEnumerator<Type> <>7__wrap3; //Field offset: 0x1C

		private Type System.Collections.Generic.IEnumerator<System.Type>.Current
		{
			 get { } //Length: 1306
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetAbstractAdProviderSubTypes>d__44(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

		private Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public struct AdAttempt
	{
		public string adLocationID; //Field offset: 0x0
		public string cacheID; //Field offset: 0x4
		public AdType adType; //Field offset: 0x8

		public AdAttempt(string adLocationID, string cacheID, AdType adType) { }

	}

	protected class EventListenerInvoker : IAdEventListener
	{
		private readonly List<IAdEventListener> _listeners; //Field offset: 0x8

		public EventListenerInvoker() { }

		public void AddListener(IAdEventListener listener) { }

		public void AddToStartOfList(IAdEventListener listener) { }

		public void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

		public void CachingTimedOut(AdType adType, string providerID, string adLocationID) { }

		public void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID) { }

		public void Clear() { }

		public void ClickedAd(AdType adType, string providerID, string adLocationID) { }

		private List<IAdEventListener> CloneListeners() { }

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

		public void RemoveListener(IAdEventListener listener) { }

		public void ShowedAd(AdType adType, string providerID, string adLocationID) { }

		public void StartedCachingAd(AdType adType, string providerID, string adLocationID) { }

		public void WillShowAd(AdType adType, string providerID, string adLocationID) { }

	}

	private enum InitState
	{
		Uninitialized = 0,
		Initializing = 1,
		Initialized = 2,
		Unsupported = 3,
	}

	protected static readonly EventListenerInvoker eventInvoker; //Field offset: 0x0
	protected const string DEFAULT_CACHE_LOCATION = "undetermined"; //Field offset: 0x0
	protected const string DEFAULT_SHOW_LOCATION = "undetermined"; //Field offset: 0x0
	private static readonly Dictionary<string, AbstractAdProvider> _idToAbstractAdProvider; //Field offset: 0x4
	private static readonly Dictionary<string, AbstractAdProvider> _idToDebugAdProvider; //Field offset: 0x8
	private static IAdSettingsProvider _settingsProvider; //Field offset: 0xC
	protected string _showInterstitialLocation; //Field offset: 0x8
	protected string _cacheInterstitialLocation; //Field offset: 0xC
	protected string _showVideoLocation; //Field offset: 0x10
	protected string _cacheVideoLocation; //Field offset: 0x14
	private InitState _initState; //Field offset: 0x18
	private Nullable<bool> _isLoadedAdConstantsRestricted; //Field offset: 0x1C
	private bool _hasCheckedPlatformSupport; //Field offset: 0x1E
	protected readonly Dictionary<AdType, bool> _supportedAdTypes; //Field offset: 0x20
	private AdType[] _allAdTypes; //Field offset: 0x24
	private bool <isCaching>k__BackingField; //Field offset: 0x28

	public virtual List<AdType> adTypesWithClickCallbackSupport
	{
		 get { } //Length: 95
	}

	public abstract string id
	{
		 get { } //Length: 0
	}

	private static Dictionary<string, AbstractAdProvider> idToAdProvider
	{
		 get { } //Length: 223
	}

	public bool isCaching
	{
		 get { } //Length: 63
		private set { } //Length: 55
	}

	public bool isInitialized
	{
		 get { } //Length: 9
	}

	public bool isInitializing
	{
		 get { } //Length: 9
	}

	public abstract bool supportsMulticaching
	{
		 get { } //Length: 0
	}

	private static AbstractAdProvider() { }

	protected AbstractAdProvider() { }

	public static void AddEventListener(IAdEventListener listener) { }

	public void CacheAd(AdType adType, string adLocationID, string cacheID) { }

	public override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached) { }

	protected virtual void CacheInterstitial(string adLocationID, string cacheID) { }

	protected virtual void CacheVideo(string adLocationID, string cacheID) { }

	public override void CachingTimedOut(AdType adType, string providerID, string adLocationID) { }

	private void CheckHasCacheIDs(Dictionary<AdLocationInfo, string> cacheIDs) { }

	private void CheckOnlineSettingRestriction() { }

	protected abstract void CheckPlatformSupport(AdProviderConfiguration configuration) { }

	public static void ClearStaticCollections() { }

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID) { }

	protected void FinishInitialization(bool success) { }

	public virtual List<AdType> get_adTypesWithClickCallbackSupport() { }

	public abstract string get_id() { }

	private static Dictionary<string, AbstractAdProvider> get_idToAdProvider() { }

	public bool get_isCaching() { }

	public bool get_isInitialized() { }

	public bool get_isInitializing() { }

	public abstract bool get_supportsMulticaching() { }

	private static IEnumerable<Type> GetAbstractAdProviderSubTypes() { }

	public static AbstractAdProvider GetAdProvider(string id) { }

	public static void HandleAdConstantsChanged() { }

	public bool HasCachedAd(AdType adType, string cacheID) { }

	protected virtual bool HasCachedInterstitial(string cacheID) { }

	protected virtual bool HasCachedVideo(string cacheID) { }

	private void Initialize(AdProviderConfiguration configuration) { }

	private bool IsAnyTypeSupportedOnPlatform() { }

	public bool IsCachingLocation(AdLocationInfo info) { }

	public static bool IsProviderSupportedOnPlatform(string id, AdType adType) { }

	public bool IsSupportedOnPlatform(AdType adType) { }

	private static void MapAbstractAdProviders(IAdSettingsProvider settingsProvider) { }

	public static void MapAdProviders(IAdSettingsProvider settingsProvider) { }

	private static void MapDebugAdProvider() { }

	protected virtual void OnCacheTimeout(AdType adType, string adLocationID) { }

	private void OnFinishedCaching(string providerID) { }

	protected virtual void OnInitialize(AdProviderConfiguration configuration) { }

	public static void RemoveEventListener(IAdEventListener listener) { }

	private void set_isCaching(bool value) { }

	public bool ShowAd(AdType adType, string adLocationID, string cacheID) { }

	protected virtual void ShowInterstitial(string adLocationID, string cacheID) { }

	protected virtual void ShowVideo(string adLocationID, string cacheID) { }

	public void TimeoutCaching(AdType adType, string adLocationID) { }

}

