using System;
using System.Collections.Generic;
using TopRun.Internal;

namespace Data.Save.Internal;

public class LocalData : DiskData
{
	public bool hasMigratedPlayerInfo;

	public int migratedPlayerPrefsVersion;

	public DateTime scheduledFirstInterstitialShowTime;

	public Dictionary<string, string> lastShowedProviders;

	public int missionsVersion;

	public int syboAnalyticsGamesSinceFlush;

	public string syboAnalyticsPreviousClientVersion;

	public string syboAnalyticsOperatingSystem;

	public string syboAnalyticsDeviceID;

	public string syboAnalyticsOSLanguage;

	public DeviceInfo.PerformanceLevel syboAnalyticsPerformanceLevel;

	public int syboAnalyticsGpuScore;

	public string syboAnalyticsOnlineSettingsLocale;

	public Dictionary<string, string> syboAnalyticsPendingOfferRewardToOfferIdMap;

	public DateTime lastKnownServerTime;

	public string lastVersionRated;

	public DateTime lastTimeAppWasUpdatedOrInstalled;

	public bool cloudSaveEnabled;

	public DateTime latestSuccessfulCloudSaveSyncTime;

	public DateTime lastCloudSaveReminderShownTime;

	public bool hasCloudSaveCelebrationBeenShown;

	public int introductionPopupShownCount;

	public bool allAssetBundlesDownloaded;

	public int latestAvailableAssetBundlesVersion;

	public int lastWeekMedalWasShown;

	public PlayerIdsData playerIdsData;

	public RanksData ranksData;

	public int numberOfRunsSinceLastGuideline;

	public DateTime lastShownCloudSaveIntroduction;

	public bool cloudSaveOptedOut;

	public override void Obfuscate()
	{
	}

	public override void Deobfuscate()
	{
	}
}
