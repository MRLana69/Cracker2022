//Type is in global namespace

public class AdSettingsProvider : IAdSettingsProvider
{
	private const string AGE_RESTRICTION_PREFIX = "_restricted"; //Field offset: 0x0
	private const uint DEFAULT_INTERSTITIAL_GRACE_PERIOD = 72000; //Field offset: 0x0
	private const int DEFAULT_NUMBER_OF_FAILS_FOR_PROVIDER = 1; //Field offset: 0x0
	private const int DEFAULT_GLOBAL_TIME_BETWEEN_INTERSTITIALS = 10; //Field offset: 0x0
	private const int DEFAULT_LIMIT_PER_HOUR = 5; //Field offset: 0x0
	private const int DEFAULT_LIMIT_PER_DAY = 20; //Field offset: 0x0
	private const int DEFAULT_LOCK_ON_TIME_LIMIT_INTERSTITIAL = 72000; //Field offset: 0x0
	private const string IMPRESSION_LIMIT_KEY = "impression_limit_{0}_{1}"; //Field offset: 0x0
	private const int DEFAULT_LOCK_ON_TIME_LIMIT_VIDEO = 72000; //Field offset: 0x0
	private const bool DEFAULT_AD_LOCATION_AVAILABILITY = False; //Field offset: 0x0
	private const int DEFAULT_AD_LOCATION_TIME_LIMIT = 10; //Field offset: 0x0
	private const int DEFAULT_AD_LOCATION_WAIT_WHILE_CACHING_TIME_LIMIT = 10; //Field offset: 0x0
	private const string DEFAULT_PRIORITY_LIST_VERSION = "notset"; //Field offset: 0x0
	private const int DEFAULT_IMPRESSION_LIMIT = 2147483647; //Field offset: 0x0
	private static List<AdProviderInfo> _allInterstitialProviders; //Field offset: 0x0
	private const int DEFAULT_CACHE_TIMEOUT_LIMIT = 10; //Field offset: 0x0
	private const string WATERFALL_LOCATION_LIST_KEY = "{0}_list"; //Field offset: 0x0
	private const string WATERFALL_ADTYPE_LIST_KEY = "default_{0}_list"; //Field offset: 0x0
	private const string PRIORITY_LIST_VERSION_KEY = "prio_list_{0}_version"; //Field offset: 0x0
	private const char PRIORITY_LIST_PROVIDER_SEPARATOR = '\u2C'; //Field offset: 0x0
	private const char PRIORITY_LIST_PROVIDER_COMPONENTS_SEPARATOR = '\u3A'; //Field offset: 0x0
	private const char PRIORITY_LIST_PROVIDER_PRIORITY_WEIGHT_SEPARATOR = '\u5F'; //Field offset: 0x0
	private const string INTERSTITIAL_GRACE_PERIOD_KEY = "ads_grace_period"; //Field offset: 0x0
	private const string NUMBER_OF_FAILS_FOR_EACH_PROVIDER = "number_of_fails_for_interstitial"; //Field offset: 0x0
	private const string GLOBAL_TIME_BETWEEN_INTERSTITIALS_KEY = "global_time_between_interstitials"; //Field offset: 0x0
	private const string PROVIDER_MINIMUM_DEVICE_VERSION_KEY = "provider_{0}_{1}_minimum_device_version"; //Field offset: 0x0
	private const string LIMIT_PER_DAY = "interstitials_limit_per_day"; //Field offset: 0x0
	private const string LIMIT_PER_HOUR = "interstitials_limit_per_hour"; //Field offset: 0x0
	private const string CACHE_TIMEOUT_LIMIT_ADTYPE_KEY = "cache_timeout_limit_{0}"; //Field offset: 0x0
	private const string CACHE_TIMEOUT_LIMIT_PROVIDER_KEY = "cache_timeout_limit_{0}_{1}"; //Field offset: 0x0
	private const string AD_LOCATION_OVERRIDE_CACHE_ID_KEY = "ad_location_{0}_{1}{2}_cacheid"; //Field offset: 0x0
	private const string AD_LOCATION_TIME_LIMIT_KEY = "ad_location_{0}_time_between_interstitials"; //Field offset: 0x0
	private const string AD_LOCATION_AVAILABILITY_KEY = "ad_location_{0}_enabled"; //Field offset: 0x0
	private const string AD_LOCATION_WAIT_WHILE_CACHING_TIME_LIMIT_KEY = "ad_location_{0}_{1}_wait_caching_limit"; //Field offset: 0x0
	private const string LOCK_ON_TIME_LIMIT_KEY = "lock_on_time_limit_{0}"; //Field offset: 0x0
	private static List<AdProviderInfo> _allVideoProviders; //Field offset: 0x4
	private static List<string> _interstitialProviderIDs; //Field offset: 0x8
	private static List<string> _videoProviderIDs; //Field offset: 0xC
	private static Dictionary<string, AdType> _cachedAdTypesForLocationIDs; //Field offset: 0x10
	private Dictionary<AdType, string> _debugPriorityListVersion; //Field offset: 0x8

	private static AdSettingsProvider() { }

	public AdSettingsProvider() { }

	public virtual bool AreInterstitialsAllowed() { }

	private static void CacheProviderIDs() { }

	private string[] GetAdColonyZoneIDs() { }

	public virtual string[] GetAdProvidersToInitialize() { }

	private Nullable<AdType> GetAdTypeForLocationID(string locationID) { }

	private static IEnumerable<AdProviderInfo> GetAllProvidersForAdType(AdType adType) { }

	public virtual bool GetAvailabilityForLocation(string locationID) { }

	public virtual string GetCacheID(string adProvider, AdLocationInfo adLocation) { }

	public virtual TimeSpan GetCacheTimeoutLimit(string providerID, AdType adType) { }

	public virtual AdProviderConfiguration GetConfigurationForProvider(string providerID) { }

	private static List<AdProviderInfo> GetDebugPriorityList(AdType adType) { }

	public virtual int GetFailCountTolerance(string adProvider, AdType adType) { }

	public virtual uint GetGracePeriodValue() { }

	public virtual string GetLatestVersionForWaterfall(AdLocation adLocation) { }

	public virtual int GetMaxImpressionForProvider(string adProvider, AdType adType) { }

	public virtual int GetMaxInterstitialImpressionsPerDay() { }

	public virtual int GetMaxInterstitialImpressionsPerHour() { }

	public virtual TimeSpan GetMinimumShowInterval(AdType adType) { }

	public virtual TimeSpan GetMinimumShowIntervalForLocation(string locationID, AdType adType) { }

	public virtual IList<AdProviderInfo> GetPriorityList(string waterfallID, AdType adType) { }

	public virtual Dictionary<AdLocationInfo, string> GetProviderCacheIDs(string providerId) { }

	public virtual int GetProviderWaitWhileCachingTimeLimit(string adLocationID, string providerID) { }

	public virtual DateTime GetScheduledFirstInterstitialShowTime() { }

	public virtual Nullable<TimeSpan> GetTimeLimitForAdProvider(string providerID, AdType adType) { }

	public virtual string GetWaterfallID(AdType adType) { }

	public virtual string GetWaterfallID(string adLocationID) { }

	public virtual void SetDebugPriorityListVersion(AdType adType, string value) { }

	public virtual bool TryGetProviderOverrideSupportedOnPlatform(AdType adType, string providerID, out string supportedDeviceVersion) { }

	public virtual void UpdateProviderCacheIDs() { }

}

