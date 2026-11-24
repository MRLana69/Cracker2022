using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Ads;
using Missions;
using SYBO.Components.Analytics.Integration;
using SYBO.Subway.Info;
using TopRun.Internal;
using UI.Breadcrumbs;
using UI.Screens.RewardManagement;
using WeeklyHunt;

namespace Data.Save.Internal;

public class CloudData : DiskData
{
	public int obfuscatedCoins;

	public int obfuscatedKeys;

	public int obfuscatedUnrewardedCoins;

	public Dictionary<UpgradeType, int> powerups;

	public Dictionary<UpgradeType, int> upgrades;

	public List<CelebrationReward> pendingRewards;

	public Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData;

	public List<Characters.CharacterId> unlockedCharacters;

	public Dictionary<Characters.CharacterId, int> collectedCharacterTokens;

	public Dictionary<Characters.CharacterId, int> selectedOutfits;

	public Dictionary<Characters.CharacterId, List<int>> unlockedOutfits;

	public List<Boards.BoardId> unlockedBoards;

	public bool[] hasSkippedMissions;

	public int runsCompletedInCurrentMissionSet;

	public int currentMissionSet;

	public int[] currentMissionProgress;

	public int missionSetCompletedCount;

	public int currentSkipForVideoMissionIndex;

	public DateTime currentSkipForVideoIndexSetAt;

	public DateTime lastTimeMissionWasSkippedForVideo;

	public bool hasSkippedMissionForVideoThisSet;

	public List<int> achievementProgress;

	public int unreportedGames;

	public DateTime unreportedGamesTimeStamp;

	public int highScore;

	public bool[] unlockedTrophies;

	public Dictionary<AwardId, PersistentAwardProgress> awardsProgress;

	public DateTime weeklyGiftUnlockTime;

	public int[] statValues;

	public int[] mysteryBoxesOpened;

	public int completedRunCount;

	public Characters.CharacterId currentCharacterId;

	public Boards.BoardId currentBoardId;

	public Boards.BoardId previousBoardId;

	public Dictionary<AwardId, bool> awardIsNew;

	public Dictionary<AwardId, bool> awardHasPayedOut;

	public bool awardsFirstLoaded;

	public string weeklyHuntProgressVersion;

	public List<bool> hasLoggedWeeklyHuntPeriod;

	public WeeklyHuntProgressData weeklyHuntProgressData;

	public int wordHuntWordsInRow;

	public bool wordHuntPayedOut;

	public int wordHuntUnlockedMask;

	public int wordHuntLastPayoutDayOfYear;

	public CharacterNameEventData characterNameEventData;

	public long lastEventID;

	public long lastTimeAnEventHasBeenTried;

	public long lastTimeAnEventWasStarted;

	public long lastTimeEventPopupWasForceShown;

	public string lastEventItemID;

	public bool shouldRestoreItemAfterEvent;

	public string wordHuntDailyWord;

	public DateTime wordHuntExpireTime;

	public SampleState syboAnalyticsSampleState;

	public string syboAnalyticsUserId;

	public string syboAggregatedDataString;

	public Dictionary<string, string> syboAnalyticsUnhandledAbTestData;

	public int syboAnalyticsCurrentSession;

	public bool kilooAnalyticsHasLoggedSyboUserId;

	public int persistedSessionEventNumber;

	public ManagerData managerData;

	public string lastTopRunResultAwardedID;

	public string pendingTopRunResultID;

	public int pendingTopRunResultsScore;

	public int pendingTopRunResultsRank;

	public int pendingTopRunResultsWeek;

	public int pendingTopRunBeatenFriendsAward;

	public bool behavioralAdsAllowed;

	public InterstitialStats interstitialStats;

	public Dictionary<UpgradeType, int> consumableSeenVideosCount;

	public Dictionary<UpgradeType, DateTime> consumableVideoSeenAt;

	public Cooldowns cooldowns;

	public int inAppLegacyPurchaseCount;

	public int inAppConsumablePurchaseCount;

	public int inAppRestoredPurchaseCount;

	public int inAppNonConsumablePurchaseCount;

	public bool isFreshInstall;

	public bool hasUserRunAppBefore;

	public DateTime lastDailyOnlineLog;

	public DateTime lastPlayDate;

	public DateTime lastQuitDate;

	public InAppData.BundleTier lastPurchasedBundle;

	public bool hasPaidOutFacebookReward;

	public bool hasSeenFrontScreenFirstTime;

	public bool hasMadeOneValidPurchase;

	public string firstInstalledVersion;

	public DateTime firstInstallDate;

	public bool hasDoubleCoinsUpgrade;

	public bool hasAdRemovalUpgrade;

	public Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen;

	public Dictionary<Boards.BoardId, bool> hasBoardBeenSeen;

	public Dictionary<Characters.CharacterId, HashSet<int>> characterOutfitsSeen;

	public CollectCoinsDummy[] collectCoinsDummyData;

	public Dictionary<EarnCoinsData.Id, string> earnCurrencyData;

	public Dictionary<string, string> inAppPurchaseHistory;

	public int numberOfBreadCrumbsShownOnFrontPage;

	public int ageRestrictionInputVersion;

	public int ageRestrictionInputMonth;

	public int ageRestrictionInputYear;

	public Breadcrumb.BreadcrumbSave breadcrumbs;

	public SSEventType lastEventTypeShown;

	public DateTime lastEventShownTimestamp;

	public string lastSeenBundleVersion;

	public DateTime lastTimeAVideoForKeysWasSeen;

	public DateTime welcomePackStartTime;

	public int currentIntroVideoAdPrizeIndex;

	public int currentRandomVideoAdPrizeIndex;

	public int currentVideoAdPrizeSeed;

	public int videosWatchedSinceDailyKeys;

	public Dictionary<string, Friend.Status> friendStatus;

	public bool allowSellHeadstartDuringRun;

	public bool allowSellScoreboosterDuringRun;

	public bool hasCollectedFromFriends;

	public bool hasShownCollectPopup;

	public bool hasShownFacebookPopup;

	public bool hasShownHoverboardPopup;

	public bool hasShownMissionIntroPopup;

	public bool hasShownEndGameMissionPopup;

	public bool isTutorialCompleted;

	public bool shouldShowCollectPopup;

	public bool shouldShowFacebookPopup;

	public bool shouldShowHoverboardPopup;

	public bool shouldShowMissionIntroductionPopup;

	public bool shouldShowEndGameMissionPopup;

	public int lastShownTopRunIntroPopupVersionNumber;

	public bool neverAskForRating;

	public string language;

	public bool soundEffectsEnabled;

	public bool musicEnabled;

	public bool topRunChallengersEnabled;

	public bool remoteNotificationsEnabled;

	public int localNotificationsEnabled;

	public bool hasLoggedStaticData;

	public DateTime lastLoggedDailyData;

	public float analyticsSamplingKey;

	public DateTime abTestLastDailyEventsReportDate;

	public string abTestPlayerSeed;

	public string abTestTagData;

	public string flurryUserId;

	public bool hasLoggedGameCenterLogin;

	public bool hasLoggedFacebookLogin;

	public Dictionary<string, int> hasLoggedFlurryDailyEventSocial;

	public override void Obfuscate()
	{
		((DataManager<>)(object)this).OnSaveGameChanged();
	}

	public override void Deobfuscate()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00b7: Expected I4, but got Obj
		//IL_00d0: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v15 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string intBinaryString = Utils.GetIntBinaryString(obfuscatedCoins);
		obfuscatedCoins = (int)intBinaryString;
		string intBinaryString2 = Utils.GetIntBinaryString(obfuscatedKeys);
		obfuscatedKeys = (int)intBinaryString2;
		string intBinaryString3 = Utils.GetIntBinaryString(obfuscatedUnrewardedCoins);
		obfuscatedUnrewardedCoins = (int)intBinaryString3;
	}

	public CloudData()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00b7: Expected I4, but got Obj
		//IL_00d0: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v15 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string intBinaryString = Utils.GetIntBinaryString(obfuscatedCoins);
		obfuscatedCoins = (int)intBinaryString;
		string intBinaryString2 = Utils.GetIntBinaryString(obfuscatedKeys);
		obfuscatedKeys = (int)intBinaryString2;
		string intBinaryString3 = Utils.GetIntBinaryString(obfuscatedUnrewardedCoins);
		obfuscatedUnrewardedCoins = (int)intBinaryString3;
	}
}
