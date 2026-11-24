namespace Kiloo.Common.Ads;

public interface IAdSettingsProvider
{

	public bool AreInterstitialsAllowed() { }

	public string[] GetAdProvidersToInitialize() { }

	public bool GetAvailabilityForLocation(string locationID) { }

	public string GetCacheID(string adProvider, AdLocationInfo adLocationID) { }

	public TimeSpan GetCacheTimeoutLimit(string providerID, AdType adType) { }

	public AdProviderConfiguration GetConfigurationForProvider(string providerID) { }

	public int GetFailCountTolerance(string adProvider, AdType adType) { }

	public uint GetGracePeriodValue() { }

	public string GetLatestVersionForWaterfall(AdLocation adLocation) { }

	public int GetMaxImpressionForProvider(string adProvider, AdType adType) { }

	public int GetMaxInterstitialImpressionsPerDay() { }

	public int GetMaxInterstitialImpressionsPerHour() { }

	public TimeSpan GetMinimumShowInterval(AdType adType) { }

	public TimeSpan GetMinimumShowIntervalForLocation(string locationID, AdType adType) { }

	public IList<AdProviderInfo> GetPriorityList(string waterfallID, AdType adType) { }

	public Dictionary<AdLocationInfo, string> GetProviderCacheIDs(string providerId) { }

	public int GetProviderWaitWhileCachingTimeLimit(string adLocationID, string providerID) { }

	public DateTime GetScheduledFirstInterstitialShowTime() { }

	public Nullable<TimeSpan> GetTimeLimitForAdProvider(string providerID, AdType adType) { }

	public string GetWaterfallID(string adLocationID) { }

	public string GetWaterfallID(AdType adType) { }

	public void SetDebugPriorityListVersion(AdType adType, string version) { }

	public bool TryGetProviderOverrideSupportedOnPlatform(AdType adType, string providerID, out string supportedDeviceVersion) { }

	public void UpdateProviderCacheIDs() { }

}

