namespace Data.Save.Internal;

public class LocalData : DiskData
{
	public bool hasMigratedPlayerInfo; //Field offset: 0x8
	public int migratedPlayerPrefsVersion; //Field offset: 0xC
	public DateTime scheduledFirstInterstitialShowTime; //Field offset: 0x10
	public Dictionary<string, string> lastShowedProviders; //Field offset: 0x18
	public int missionsVersion; //Field offset: 0x1C
	public int syboAnalyticsGamesSinceFlush; //Field offset: 0x20
	public string syboAnalyticsPreviousClientVersion; //Field offset: 0x24
	public string syboAnalyticsOperatingSystem; //Field offset: 0x28
	public string syboAnalyticsDeviceID; //Field offset: 0x2C
	public string syboAnalyticsOSLanguage; //Field offset: 0x30
	public PerformanceLevel syboAnalyticsPerformanceLevel; //Field offset: 0x34
	public int syboAnalyticsGpuScore; //Field offset: 0x38
	public string syboAnalyticsOnlineSettingsLocale; //Field offset: 0x3C
	public Dictionary<string, string> syboAnalyticsPendingOfferRewardToOfferIdMap; //Field offset: 0x40
	public DateTime lastKnownServerTime; //Field offset: 0x48
	public string lastVersionRated; //Field offset: 0x50
	public DateTime lastTimeAppWasUpdatedOrInstalled; //Field offset: 0x58
	public bool cloudSaveEnabled; //Field offset: 0x60
	public DateTime latestSuccessfulCloudSaveSyncTime; //Field offset: 0x68
	public DateTime lastCloudSaveReminderShownTime; //Field offset: 0x70
	public bool hasCloudSaveCelebrationBeenShown; //Field offset: 0x78
	public int introductionPopupShownCount; //Field offset: 0x7C
	public bool allAssetBundlesDownloaded; //Field offset: 0x80
	public int latestAvailableAssetBundlesVersion; //Field offset: 0x84
	public int lastWeekMedalWasShown; //Field offset: 0x88
	public PlayerIdsData playerIdsData; //Field offset: 0x8C
	public RanksData ranksData; //Field offset: 0x90
	public int numberOfRunsSinceLastGuideline; //Field offset: 0x94
	public DateTime lastShownCloudSaveIntroduction; //Field offset: 0x98
	public bool cloudSaveOptedOut; //Field offset: 0xA0

	public LocalData() { }

	public override void Deobfuscate() { }

	public override void Obfuscate() { }

}

