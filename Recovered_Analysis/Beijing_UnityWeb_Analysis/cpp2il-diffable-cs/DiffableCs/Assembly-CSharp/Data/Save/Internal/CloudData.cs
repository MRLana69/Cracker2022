namespace Data.Save.Internal;

public class CloudData : DiskData
{
	public int obfuscatedCoins; //Field offset: 0x8
	public int obfuscatedKeys; //Field offset: 0xC
	public int obfuscatedUnrewardedCoins; //Field offset: 0x10
	public Dictionary<UpgradeType, int> powerups; //Field offset: 0x14
	public Dictionary<UpgradeType, int> upgrades; //Field offset: 0x18
	public List<CelebrationReward> pendingRewards; //Field offset: 0x1C
	public Dictionary<BoardId, Dictionary<ThemeIdentifier, BoardThemeData>> boardThemeData; //Field offset: 0x20
	public List<CharacterId> unlockedCharacters; //Field offset: 0x24
	public Dictionary<CharacterId, int> collectedCharacterTokens; //Field offset: 0x28
	public Dictionary<CharacterId, int> selectedOutfits; //Field offset: 0x2C
	public Dictionary<CharacterId, List<int>> unlockedOutfits; //Field offset: 0x30
	public List<BoardId> unlockedBoards; //Field offset: 0x34
	public bool[] hasSkippedMissions; //Field offset: 0x38
	public int runsCompletedInCurrentMissionSet; //Field offset: 0x3C
	public int currentMissionSet; //Field offset: 0x40
	public int[] currentMissionProgress; //Field offset: 0x44
	public int missionSetCompletedCount; //Field offset: 0x48
	public int currentSkipForVideoMissionIndex; //Field offset: 0x4C
	public DateTime currentSkipForVideoIndexSetAt; //Field offset: 0x50
	public DateTime lastTimeMissionWasSkippedForVideo; //Field offset: 0x58
	public bool hasSkippedMissionForVideoThisSet; //Field offset: 0x60
	public List<int> achievementProgress; //Field offset: 0x64
	public int unreportedGames; //Field offset: 0x68
	public DateTime unreportedGamesTimeStamp; //Field offset: 0x70
	public int highScore; //Field offset: 0x78
	public bool[] unlockedTrophies; //Field offset: 0x7C
	public Dictionary<AwardId, PersistentAwardProgress> awardsProgress; //Field offset: 0x80
	public DateTime weeklyGiftUnlockTime; //Field offset: 0x88
	public int[] statValues; //Field offset: 0x90
	public int[] mysteryBoxesOpened; //Field offset: 0x94
	public int completedRunCount; //Field offset: 0x98
	public CharacterId currentCharacterId; //Field offset: 0x9C
	public BoardId currentBoardId; //Field offset: 0xA0
	public BoardId previousBoardId; //Field offset: 0xA4
	public Dictionary<AwardId, bool> awardIsNew; //Field offset: 0xA8
	public Dictionary<AwardId, bool> awardHasPayedOut; //Field offset: 0xAC
	public bool awardsFirstLoaded; //Field offset: 0xB0
	public string weeklyHuntProgressVersion; //Field offset: 0xB4
	public List<bool> hasLoggedWeeklyHuntPeriod; //Field offset: 0xB8
	public WeeklyHuntProgressData weeklyHuntProgressData; //Field offset: 0xBC
	public int wordHuntWordsInRow; //Field offset: 0xC0
	public bool wordHuntPayedOut; //Field offset: 0xC4
	public int wordHuntUnlockedMask; //Field offset: 0xC8
	public int wordHuntLastPayoutDayOfYear; //Field offset: 0xCC
	public CharacterNameEventData characterNameEventData; //Field offset: 0xD0
	public long lastEventID; //Field offset: 0xD8
	public long lastTimeAnEventHasBeenTried; //Field offset: 0xE0
	public long lastTimeAnEventWasStarted; //Field offset: 0xE8
	public long lastTimeEventPopupWasForceShown; //Field offset: 0xF0
	public string lastEventItemID; //Field offset: 0xF8
	public bool shouldRestoreItemAfterEvent; //Field offset: 0xFC
	public string wordHuntDailyWord; //Field offset: 0x100
	public DateTime wordHuntExpireTime; //Field offset: 0x108
	public SampleState syboAnalyticsSampleState; //Field offset: 0x110
	public string syboAnalyticsUserId; //Field offset: 0x114
	public string syboAggregatedDataString; //Field offset: 0x118
	public Dictionary<string, string> syboAnalyticsUnhandledAbTestData; //Field offset: 0x11C
	public int syboAnalyticsCurrentSession; //Field offset: 0x120
	public bool kilooAnalyticsHasLoggedSyboUserId; //Field offset: 0x124
	public int persistedSessionEventNumber; //Field offset: 0x128
	public ManagerData managerData; //Field offset: 0x12C
	public string lastTopRunResultAwardedID; //Field offset: 0x130
	public string pendingTopRunResultID; //Field offset: 0x134
	public int pendingTopRunResultsScore; //Field offset: 0x138
	public int pendingTopRunResultsRank; //Field offset: 0x13C
	public int pendingTopRunResultsWeek; //Field offset: 0x140
	public int pendingTopRunBeatenFriendsAward; //Field offset: 0x144
	public bool behavioralAdsAllowed; //Field offset: 0x148
	public InterstitialStats interstitialStats; //Field offset: 0x14C
	public Dictionary<UpgradeType, int> consumableSeenVideosCount; //Field offset: 0x150
	public Dictionary<UpgradeType, DateTime> consumableVideoSeenAt; //Field offset: 0x154
	public Cooldowns cooldowns; //Field offset: 0x158
	public int inAppLegacyPurchaseCount; //Field offset: 0x15C
	public int inAppConsumablePurchaseCount; //Field offset: 0x160
	public int inAppRestoredPurchaseCount; //Field offset: 0x164
	public int inAppNonConsumablePurchaseCount; //Field offset: 0x168
	public bool isFreshInstall; //Field offset: 0x16C
	public bool hasUserRunAppBefore; //Field offset: 0x16D
	public DateTime lastDailyOnlineLog; //Field offset: 0x170
	public DateTime lastPlayDate; //Field offset: 0x178
	public DateTime lastQuitDate; //Field offset: 0x180
	public BundleTier lastPurchasedBundle; //Field offset: 0x188
	public bool hasPaidOutFacebookReward; //Field offset: 0x18C
	public bool hasSeenFrontScreenFirstTime; //Field offset: 0x18D
	public bool hasMadeOneValidPurchase; //Field offset: 0x18E
	public string firstInstalledVersion; //Field offset: 0x190
	public DateTime firstInstallDate; //Field offset: 0x198
	public bool hasDoubleCoinsUpgrade; //Field offset: 0x1A0
	public bool hasAdRemovalUpgrade; //Field offset: 0x1A1
	public Dictionary<CharacterId, bool> hasCharacterBeenSeen; //Field offset: 0x1A4
	public Dictionary<BoardId, bool> hasBoardBeenSeen; //Field offset: 0x1A8
	public Dictionary<CharacterId, HashSet<int>> characterOutfitsSeen; //Field offset: 0x1AC
	public CollectCoinsDummy[] collectCoinsDummyData; //Field offset: 0x1B0
	public Dictionary<Id, string> earnCurrencyData; //Field offset: 0x1B4
	public Dictionary<string, string> inAppPurchaseHistory; //Field offset: 0x1B8
	public int numberOfBreadCrumbsShownOnFrontPage; //Field offset: 0x1BC
	public int ageRestrictionInputVersion; //Field offset: 0x1C0
	public int ageRestrictionInputMonth; //Field offset: 0x1C4
	public int ageRestrictionInputYear; //Field offset: 0x1C8
	public BreadcrumbSave breadcrumbs; //Field offset: 0x1CC
	public SSEventType lastEventTypeShown; //Field offset: 0x1D0
	public DateTime lastEventShownTimestamp; //Field offset: 0x1D8
	public string lastSeenBundleVersion; //Field offset: 0x1E0
	public DateTime lastTimeAVideoForKeysWasSeen; //Field offset: 0x1E8
	public DateTime welcomePackStartTime; //Field offset: 0x1F0
	public int currentIntroVideoAdPrizeIndex; //Field offset: 0x1F8
	public int currentRandomVideoAdPrizeIndex; //Field offset: 0x1FC
	public int currentVideoAdPrizeSeed; //Field offset: 0x200
	public int videosWatchedSinceDailyKeys; //Field offset: 0x204
	public Dictionary<string, Status> friendStatus; //Field offset: 0x208
	public bool allowSellHeadstartDuringRun; //Field offset: 0x20C
	public bool allowSellScoreboosterDuringRun; //Field offset: 0x20D
	public bool hasCollectedFromFriends; //Field offset: 0x20E
	public bool hasShownCollectPopup; //Field offset: 0x20F
	public bool hasShownFacebookPopup; //Field offset: 0x210
	public bool hasShownHoverboardPopup; //Field offset: 0x211
	public bool hasShownMissionIntroPopup; //Field offset: 0x212
	public bool hasShownEndGameMissionPopup; //Field offset: 0x213
	public bool isTutorialCompleted; //Field offset: 0x214
	public bool shouldShowCollectPopup; //Field offset: 0x215
	public bool shouldShowFacebookPopup; //Field offset: 0x216
	public bool shouldShowHoverboardPopup; //Field offset: 0x217
	public bool shouldShowMissionIntroductionPopup; //Field offset: 0x218
	public bool shouldShowEndGameMissionPopup; //Field offset: 0x219
	public int lastShownTopRunIntroPopupVersionNumber; //Field offset: 0x21C
	public bool neverAskForRating; //Field offset: 0x220
	public string language; //Field offset: 0x224
	public bool soundEffectsEnabled; //Field offset: 0x228
	public bool musicEnabled; //Field offset: 0x229
	public bool topRunChallengersEnabled; //Field offset: 0x22A
	public bool remoteNotificationsEnabled; //Field offset: 0x22B
	public int localNotificationsEnabled; //Field offset: 0x22C
	public bool hasLoggedStaticData; //Field offset: 0x230
	public DateTime lastLoggedDailyData; //Field offset: 0x238
	public float analyticsSamplingKey; //Field offset: 0x240
	public DateTime abTestLastDailyEventsReportDate; //Field offset: 0x248
	public string abTestPlayerSeed; //Field offset: 0x250
	public string abTestTagData; //Field offset: 0x254
	public string flurryUserId; //Field offset: 0x258
	public bool hasLoggedGameCenterLogin; //Field offset: 0x25C
	public bool hasLoggedFacebookLogin; //Field offset: 0x25D
	public Dictionary<string, int> hasLoggedFlurryDailyEventSocial; //Field offset: 0x260

	public CloudData() { }

	public override void Deobfuscate() { }

	public override void Obfuscate() { }

}

