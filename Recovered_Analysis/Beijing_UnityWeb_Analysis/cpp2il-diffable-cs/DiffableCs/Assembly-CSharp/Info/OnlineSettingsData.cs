namespace Info;

public class OnlineSettingsData
{
	public readonly float mysteryBoxDoubleRewardChance; //Field offset: 0x8
	public readonly bool mysteryBoxDoubleRewardAllowKeys; //Field offset: 0xC
	public readonly int chartboostDelaySeconds; //Field offset: 0x10
	public readonly string saveMeLocales; //Field offset: 0x14
	public readonly string bundlesEnabledLocales; //Field offset: 0x18
	public readonly string bundlesDisabledLocales; //Field offset: 0x1C
	public readonly int toprunScorematchAmount; //Field offset: 0x20
	public readonly int toprunRefreshInterval; //Field offset: 0x24
	public readonly bool tapjoyPreloadVideos; //Field offset: 0x28
	public readonly int toprunGracePeriod; //Field offset: 0x2C
	public readonly string toprunBaseUrl; //Field offset: 0x30
	public readonly bool kilooAnalyticsEnabled; //Field offset: 0x34
	public readonly float kilooAnalyticsSample; //Field offset: 0x38
	public readonly string fbAdchoiceLink; //Field offset: 0x3C
	public readonly int interstitialGameOverTotalShowSlots; //Field offset: 0x40
	public readonly int interstitialGameOverActiveShowSlot; //Field offset: 0x44
	public readonly string latestVersionAndroidMinOsVersion; //Field offset: 0x48
	public readonly string latestVersion; //Field offset: 0x4C
	public readonly Dictionary<string, string> latestVersionChangelog; //Field offset: 0x50
	public readonly int cacheTimeoutLimitInterstitial; //Field offset: 0x54
	public readonly int ageRestrictionThreshold; //Field offset: 0x58
	public readonly int ageRestrictionVersion; //Field offset: 0x5C
	public readonly int toprunStrangerAmount; //Field offset: 0x60
	public readonly bool allowLoadScreenUserTips; //Field offset: 0x64
	public readonly Dictionary<string, string> loadScreenTitle; //Field offset: 0x68
	public readonly Dictionary<string, UserTip[]> userTips; //Field offset: 0x6C
	public readonly bool interstitialLocationGameoverAfterCountupEnabled; //Field offset: 0x70
	public readonly int interstitialLocationGameoverAfterCountupTimeLimit; //Field offset: 0x74
	public readonly int abtestTwokeysVersion; //Field offset: 0x78
	public readonly bool abtestTwokeysActive; //Field offset: 0x7C
	public readonly string abtestTwokeysTag; //Field offset: 0x80
	public readonly string abtestTwokeysSegmentOffset; //Field offset: 0x84
	public readonly string abtestTwokeysSegmentSize; //Field offset: 0x88
	public readonly string abtestTwokeysSegmentPayload; //Field offset: 0x8C
	public readonly int abtestMainscreenButtonsVersion; //Field offset: 0x90
	public readonly bool abtestMainscreenButtonsActive; //Field offset: 0x94
	public readonly string abtestMainscreenButtonsTag; //Field offset: 0x98
	public readonly string abtestMainscreenButtonsSegmentOffset; //Field offset: 0x9C
	public readonly string abtestMainscreenButtonsSegmentSize; //Field offset: 0xA0
	public readonly string abtestMainscreenButtonsSegmentPayload; //Field offset: 0xA4
	public readonly string syboAnalyticsEndpointBaseurl; //Field offset: 0xA8
	public readonly int syboAnalyticsMaxGamesWithoutFlush; //Field offset: 0xAC
	public readonly bool syboAnalyticsEnabled; //Field offset: 0xB0
	public readonly float syboAnalyticsSamplingThreshold; //Field offset: 0xB4
	public readonly string eventType; //Field offset: 0xB8
	public readonly DateTime eventStart; //Field offset: 0xC0
	public readonly DateTime eventEnd; //Field offset: 0xC8
	public readonly string eventValue; //Field offset: 0xD0
	public readonly string eventPopupTitleFirst; //Field offset: 0xD4
	public readonly string eventPopupTitleSecond; //Field offset: 0xD8
	public readonly string eventPopupDescriptionFirst; //Field offset: 0xDC
	public readonly string eventPopupDescriptionSecond; //Field offset: 0xE0
	public readonly string discountDealName; //Field offset: 0xE4
	public readonly int inAppTier1; //Field offset: 0xE8
	public readonly int inAppTier2; //Field offset: 0xEC
	public readonly int inAppTier3; //Field offset: 0xF0
	public readonly int inAppTier4; //Field offset: 0xF4
	public readonly int inAppTier5; //Field offset: 0xF8
	public readonly int inAppTier6; //Field offset: 0xFC
	public readonly int inAppTier7; //Field offset: 0x100
	public readonly int inAppTier8; //Field offset: 0x104
	public readonly int inAppTier9; //Field offset: 0x108
	public readonly int inAppDoubleCoins; //Field offset: 0x10C
	public readonly DateTime discountEndTime; //Field offset: 0x110
	public readonly string videoadsProviderlist; //Field offset: 0x118
	public readonly string adcolonyVideoPriority; //Field offset: 0x11C
	public readonly string vungleVideoPriority; //Field offset: 0x120
	public readonly string supersonicVideoPriority; //Field offset: 0x124
	public readonly string chartboostVideoPriority; //Field offset: 0x128
	public readonly string tapjoyVideoPriority; //Field offset: 0x12C
	public readonly string defaultVideoList; //Field offset: 0x130
	public readonly int interstitialsLimitPerHour; //Field offset: 0x134
	public readonly int interstitialsLimitPerDay; //Field offset: 0x138
	public readonly int interstitialProvidersListVersion; //Field offset: 0x13C
	public readonly string interstitialGroups; //Field offset: 0x140
	public readonly string interstitialGroupsDefaultCountryCodes; //Field offset: 0x144
	public readonly int interstitialGroupsDefaultChartboostPriority; //Field offset: 0x148
	public readonly int interstitialGroupsDefaultChartboostWeight; //Field offset: 0x14C
	public readonly int interstitialGroupsDefaultSupersonicPriority; //Field offset: 0x150
	public readonly int interstitialGroupsDefaultSupersonicWeight; //Field offset: 0x154
	public readonly int interstitialGroupsDefaultFacebookPriority; //Field offset: 0x158
	public readonly int interstitialGroupsDefaultFacebookWeight; //Field offset: 0x15C
	public readonly int interstitialGroupsDefaultInmobiPriority; //Field offset: 0x160
	public readonly int interstitialGroupsDefaultInmobiWeight; //Field offset: 0x164
	public readonly int interstitialGroupsDefaultMdotmPriority; //Field offset: 0x168
	public readonly int interstitialGroupsDefaultMdotmWeight; //Field offset: 0x16C
	public readonly string defaultInterstitialList; //Field offset: 0x170
	public readonly bool adLocationHomeVideosEnabled; //Field offset: 0x174
	public readonly bool adLocationEarnCoinsVideosEnabled; //Field offset: 0x175
	public readonly bool adLocationDoubleUpVideosEnabled; //Field offset: 0x176
	public readonly bool adLocationWordyWeekendVideosEnabled; //Field offset: 0x177
	public readonly bool adLocationHomeInterstitialsEnabled; //Field offset: 0x178
	public readonly bool adLocationGameOverInterstitialsEnabled; //Field offset: 0x179
	public int consumableVideoCooldownSeconds; //Field offset: 0x17C
	public int consumableVideoViewLimit; //Field offset: 0x180
	public int consumableVideoRewardHoverboard; //Field offset: 0x184
	public int missionSkipWithVideoCooldownSeconds; //Field offset: 0x188

	public OnlineSettingsData() { }

}

