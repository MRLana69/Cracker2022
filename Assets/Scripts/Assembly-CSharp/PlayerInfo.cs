using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using Missions;
using SYBO.Common.Components.Singleton;
using SYBO.Components.Analytics;
using SYBO.Subway.Info;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;

public class PlayerInfo
{
	private enum Key
	{
		AmountOfCoins,
		HighestScore,
		DailyWord,
		DailyWordUnlockMask,
		DailyWordExpireTime,
		DailyWordPayedOut,
		CurrentCharacter,
		CurrentMissionSet,
		CurrentMissionSetProgress,
		CollectedCharacterTokens,
		AmountOfMysteryBoxesOpened,
		TutorialCompleted,
		InAppPurchaseCount,
		InAppConsumablePurchaseCount,
		InAppNonconsumablePurchaseCount,
		InAppRestoredPurchaseCount,
		EarnCurrencyData,
		PayBonusFacebook,
		PayBonusFacebookPack,
		PayBonusFacebookCharacter,
		PayBonusGameCenter,
		UnlockedTrophies,
		AchievementProgress,
		DoubleCoins,
		DailyWordInRow,
		MissionCompletedSum,
		NumberOfRunsSinceLastGuideline,
		HasShownHoverboardPopup,
		HasShownAwardsIntroductionPopup,
		HasShownTopRunIntroductionPopup,
		LastShownTopRunIntroPopupVersionNumber,
		HasShownHoverboardCustomizationPopup,
		HasShownTurboHeadstartIntroductionPopup,
		ShouldShowHoverboardPopup,
		HasShownFacebookPopup,
		ShouldShowFacebookPopup,
		HasShownDuelIntroductionPopup,
		ShouldShowDuelIntroductionPopup,
		ShouldShowDuelsBreadcrumb,
		HasShownMission1Popup,
		ShouldShowMission1Popup,
		HasShownCollectPopup,
		ShouldShowCollectPopup,
		HasShownMission2Popup,
		ShouldShowMission2Popup,
		DummyFriendCollected,
		DummyFriendShouldShow,
		DailyWordLastPayoutDayOfYear,
		AmountOfSuperMysteryBoxesOpened,
		HasHoverboardsBeenSeen,
		UnlockedHoverboardTypes,
		CurrentHoverboard,
		PreviousHoverboard,
		ShouldRestoreAfterEvent,
		BreadCrumbsShownOnFrontPage,
		UnreportedGames,
		UnreportedGamesTimestamp,
		HistoryOfInapp,
		HasCharacterBeenSeen,
		NeverAskForRating,
		LastVersionRated,
		NumberOfTotalRuns,
		AmountOfSeasonalEggs,
		HasCollectedFromFriends,
		AmountOfKeys,
		HasFirstMBKey,
		HasFirstSMBKey,
		LastTopRunResultsAwardedID,
		PendingTopRunResultsID,
		PendingTopRunResultScore,
		PendingTopRunResultRank,
		PendingTopRunResultWeek,
		LastWeekMedalWasShown,
		LastPlayDate,
		LastQuitDate,
		LastDailyOnlineLog,
		HasShownKeysPopup,
		MissionsVersionLastUpdate,
		SpecialChallengeData,
		CharacterThemesUnlocked,
		CharacterLastSelectedThemes,
		CharacterThemesSeen,
		PendingRewards,
		RemoteNotificationsEnabled,
		IsFreshInstall,
		LastEventID,
		LastTimeAnEventHasBeenTried,
		LastTimeAnEventWasStarted,
		LastTimeEventPopupHasBeenForcedShown,
		LastEventItemID,
		DailyInterstitialExpireTime,
		LastTimeInterstitialWasSeen,
		LastTimeInterstitialProviderHasChanged,
		HourlyInterstitialExpireTime,
		NumberOfInterstitialsPerDay,
		NumberOfInterstitialsPerHour,
		InterstitialProviderListVersion,
		IsSaveMePopupEnabled,
		NumberOfRuns,
		LastKnownServerTime,
		LastTimeAVideoForKeysWasSeen,
		LastTimeAWeeklyFacebookGiftWasCollected,
		LastPurchasedBundle,
		LastTimeAppWasUpdatedOrInstalled,
		FirstInstallDate,
		Stats,
		HoverboardCustomizationData,
		CollectCoinsDummyData,
		AwardStatus,
		CharacterNameEventData,
		HasCollectedFirstAwardReward,
		HasCollectedFacebookWeeklyGiftThisWeek,
		AmountOfMiniMysteryBoxesOpened,
		FlurryUserId,
		LatestAvailableBundlesVersion,
		AllBundlesDownloaded,
		HasShownVoucherPopupOnFrontScreen,
		HasShownVoucherPopupInShop,
		ShouldUseAlternativeHuntPrizes,
		AnalyticsSamplingKey,
		SyboAnalyticsUserId,
		SyboAnalyticsSessionCounter,
		SyboAnalyticsGamesSinceFlush,
		SyboAnalyticsPreviousClientVersion,
		AllowSellHeadstartDuringRun,
		AllowSellScoreboosterDuringRun,
		HasMadeOneValidPurchase,
		HasLoggedStaticData,
		HasLoggedSyboUserId,
		SyboLastPurchaseNumber,
		AgeRestrictionInputVersion,
		AgeRestrictionInputMonth,
		AgeRestrictionInputYear,
		FirstInstalledVersion,
		SecondDayLeft
	}

	private static readonly CultureInfo DATETIME_CULTUREINFO;

	private bool _dataExists;

	private bool _dirty;

	public Action onCoinsChanged;

	public Action onKeysChanged;

	private int _xoredAmountOfCoins;

	private int _xoredAmountOfKeys;

	private int _highScore;

	private int _formerHighScore;

	public Action onHighScoreChanged;

	private int _highestMeters;

	private int _amountOfMysteryBoxesOpened;

	private int _amountOfMiniMysteryBoxesOpened;

	private bool _willShowSMBAfterDailyChallenge;

	private int _amountOfSuperMysteryBoxesOpened;

	private int _amountOfSeasonalEggs;

	private string _weeklyChallangeData;

	private string _lastPlayDate;

	private string _lastQuitDate;

	private string _lastDailyOnlineLog;

	private bool _hasReceivedFirstMBKey;

	private bool _hasReceivedFirstSMBKey;

	private List<CelebrationReward> _pendingRewards;

	private CelebrationReward _lastAddedReward;

	private string _lastTopRunResultAwardedID;

	private string _pendingTopRunResultID;

	private int _pendingTopRunResultsScore;

	private int _pendingTopRunResultsRank;

	private int _pendingTopRunResultsWeek;

	private int _pendingTopRunBeatenFriendsAward;

	private int _lastWeekMedalWasShown;

	private float _analyticsSamplingKey;

	private string _syboAnalyticsUserId;

	private int _syboAnalyticsCurrentSession;

	private int _syboAnalyticsGamesSinceFlush;

	private string _syboAnalyticsPreviousClientVersion;

	private long _syboLastPurchaseNumber;

	private int _lastMissionCompleted;

	private int _currentMissionSet;

	private int[] _currentMissionProgress;

	private int _missionCompletedSum;

	public Action onScoreMultiplierChanged;

	private Dictionary<Characters.CharacterType, int> _lastSelectedThemes;

	private Dictionary<Characters.CharacterType, int[]> _characterThemesSeen;

	public Action<Characters.CharacterType> OnCharacterOutfitUnlocked;

	private Dictionary<Characters.CharacterType, int[]> _characterThemesUnlocked;

	private DateTime _lastTimeInterstitialProviderHasChanged;

	private DateTime _lastTimeInterstitialWasSeen;

	private DateTime _dailyInterstitialExpireTime;

	private DateTime _hourlyInterstitialExpireTime;

	private int _numberOfInterstitialsPerDay;

	private int _numberOfInterstitialsPerHour;

	private int _interstitialProviderListVersion;

	private int _currentCharacter;

	public Action<Characters.CharacterType> OnTokenCollected;

	private int[] _collectedCharacterTokens;

	private Dictionary<Characters.CharacterType, bool> _hasCharacterBeenSeen;

	private Hoverboards.BoardType _currentHoverboard;

	private Hoverboards.BoardType _previousHoverboard;

	private Dictionary<Hoverboards.BoardType, bool> _hoverboardUnlockStatus;

	public Action<Hoverboards.BoardType> OnBoardUnlocked;

	private Dictionary<Hoverboards.BoardType, bool> _hasHoverboardBeenSeen;

	private int _unreportedGames;

	private DateTime _unreportedGamesTimestamp;

	private bool[] _unlockedTrophies;

	private int[] _achievementProgress;

	private bool _hasCollectedFirstAwardReward;

	private bool _hasCollectedFacebookWeeklyGiftThisWeek;

	private bool _hasPayedOutFacebook;

	private bool _hasPayedOutFacebookPack;

	private bool _hasPayedOutFacebookCharacter;

	private bool _hasPayedOutGameCenter;

	private string _dailyWord;

	private int _dailyWordInRow;

	private int _dailyWordLastPayoutDayOfYear;

	private IntMask _dailyWordUnlockedMask;

	private DateTime _dailyWordExpireTime;

	private DateTime _dailyWordExpireDeviceTime;

	private bool _dailyWordPayedOut;

	public Action OnPickedUpLetter;

	public Action OnDailyWordInRowChanged;

	private bool _isTutorialCompleted;

	private int _numberOfBreadCrumbsShownOnFrontPage;

	private bool _shouldRestoreAfterEvent;

	private long _lastEventID;

	private string _lastEventItemID;

	private long _lastTimeAnEventWasStarted;

	private long _lastTimeAnEventHasBeenTried;

	private long _lastTimeEventPopupHasBeenForcedShown;

	private DateTime _lastKnownServerTime;

	private DateTime _lastTimeAVideoForKeysWasSeen;

	private DateTime _weeklyGiftEndTime;

	private DateTime _lastTimeAppWasUpdatedOrInstalled;

	private DateTime _firstInstallDate;

	private string _firstInstalledVersion;

	private int _numberOfRunsSinceLastGuideline;

	private bool _hasShownHoverboardPopup;

	private bool _shouldShowHoverboardPopup;

	private bool _hasShownFacebookPopup;

	private bool _shouldShowFacebookPopup;

	private bool _hasShownDuelIntroductionPopup;

	private bool _shouldShowDuelIntroductionPopup;

	private bool _shouldShowDuelsBreadcrumb;

	private bool _hasShownMission1Popup;

	private bool _shouldShowMission1Popup;

	private bool _hasShownCollectPopup;

	private bool _shouldShowCollectPopup;

	private bool _hasShownMission2Popup;

	private bool _shouldShowMission2Popup;

	private bool _hasShownAwardsIntroductionPopup;

	private bool _hasShownTopRunIntroductionPopup;

	private bool _hasShownHoverboardCustmoizationPopup;

	private bool _hasShownTurboHeadstartIntroductionPopup;

	private int _lastShownTopRunIntroPopupVersionNumber;

	private bool _hasCollectedFromFriends;

	private int _numberOfRuns;

	private bool _isSaveMePopupEnabled;

	private bool _hasShownVoucherPopupOnFrontScreen;

	private bool _hasShownVoucherPopupInShop;

	private string _shouldUseAlternativeHuntPrizes;

	private int _latestAvailableAssetBundlesVersion;

	private bool _allAssetBundlesDownloaded;

	private bool _dummyFriendCollected;

	private bool _dummyFriendShouldShow;

	private int _inAppLegacyPurchaseCount;

	private int _inAppConsumablePurchaseCount;

	private int _inAppNonconsumablePurchaseCount;

	private int _inAppRestoredPurchaseCount;

	private string _earnCurrenyData;

	private bool _hasMadeOneValidPurchase;

	private bool _hasLoggedSyboUserId;

	private string HuntDefaultTime;

	public Action<PowerupType, int> onPowerupAmountChanged;

	private Dictionary<PowerupType, int> _upgradeAmounts;

	private Dictionary<PowerupType, int> _upgradeTiers;

	private Dictionary<string, string> _inappHistory;

	private bool _hasDoubleCoinsUpgrade;

	private InAppData.BundleTier _lastPurchasedBundle;

	private bool _hasShownKeysPopup;

	private Statistics _stats;

	private string _trophyMissionData;

	private string _characterNameEventData;

	private HoverboardCustomizationData _hoverboardCustomizationData;

	private CollectCoinsDummyData _collectCoinsDummyData;

	private bool _neverAskForRating;

	private string _lastVersionRated;

	private int _ratingAskCounter;

	private int _missionsVersionLastUpdate;

	private bool _remoteNotificationsEnabled;

	private bool _isFreshInstall;

	private string _flurryUserId;

	private bool _hasLoggedStaticData;

	private string _flurryUserIdHash;

	private const string SECRET = "we12rtyuiklhgfdjerKJGHfvghyuhnjiokLJHl145rtyfghjvbn";

	private bool _allowSellHeadstartDuringRun;

	private bool _allowSellScoreboosterDuringRun;

	private int _ageRestrictionInputVersion;

	private int _ageRestrictionInputMonth;

	private int _ageRestrictionInputYear;

	private const int VERSION = 1;

	private Key _flurry_nextKeyToRead;

	private bool _doubleScore;

	private static PlayerInfo _instance;

	private string _userName;

	private int _SecondDayLeft;

	private Action m_onKnownServerTimeChange;

	public bool dataExists => _dataExists;

	public string UserName
	{
		get
		{
			//IL_002a: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			string userName = PlayerPrefs.GetString("PLAYER_NAME_KEY");
			_userName = userName;
			string userName2 = _userName;
			object obj;
			if (_userName != null)
			{
				obj = 0;
				if (userName2._stringLength != 0)
				{
					goto IL_00bb;
				}
			}
			obj = 1;
			goto IL_00bb;
			IL_00bb:
			if (obj != null)
			{
				string text = GenerateRandomID(6);
				string userName3 = "User_" + text;
				_userName = userName3;
				PlayerPrefs.SetString("PLAYER_NAME_KEY", _userName);
			}
			return _userName;
		}
		set
		{
			if (value != "")
			{
				_userName = value;
				PlayerPrefs.SetString("PLAYER_NAME_KEY", value);
			}
		}
	}

	public int amountOfCoins
	{
		get
		{
			return Utils.EncryptDecryptXORValue(_xoredAmountOfCoins);
		}
		set
		{
			int num = Utils.EncryptDecryptXORValue(_xoredAmountOfCoins);
			if (num != value)
			{
				int xoredAmountOfCoins = Utils.EncryptDecryptXORValue(value);
				_dirty = true;
				_xoredAmountOfCoins = xoredAmountOfCoins;
				Action action = onCoinsChanged;
				if (onCoinsChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int amountOfKeys
	{
		get
		{
			return Utils.EncryptDecryptXORValue(_xoredAmountOfKeys);
		}
		set
		{
			int num = Utils.EncryptDecryptXORValue(_xoredAmountOfKeys);
			if (num != value)
			{
				int xoredAmountOfKeys = Utils.EncryptDecryptXORValue(value);
				_dirty = true;
				_xoredAmountOfKeys = xoredAmountOfKeys;
				Action action = onKeysChanged;
				if (onKeysChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int highScore
	{
		get
		{
			return _highScore;
		}
		set
		{
			if (value > _highScore)
			{
				_highScore = value;
				_formerHighScore = _highScore;
				_dirty = true;
				Action action = onHighScoreChanged;
				if (onHighScoreChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int formerHighScore => _formerHighScore;

	public int highestMeters
	{
		get
		{
			return _highestMeters;
		}
		set
		{
			if (value != _highestMeters)
			{
				_dirty = true;
				_highestMeters = value;
			}
		}
	}

	public int amountOfMysteryBoxesOpened
	{
		get
		{
			return _amountOfMysteryBoxesOpened;
		}
		set
		{
			if (value != _amountOfMysteryBoxesOpened)
			{
				_dirty = true;
				_amountOfMysteryBoxesOpened = value;
			}
		}
	}

	public int amountOfMiniMysteryBoxesOpened
	{
		get
		{
			return _amountOfMiniMysteryBoxesOpened;
		}
		set
		{
			if (value != _amountOfMiniMysteryBoxesOpened)
			{
				_dirty = true;
				_amountOfMiniMysteryBoxesOpened = value;
			}
		}
	}

	public bool willShowSMBAfterDailyChallenge
	{
		get
		{
			return _willShowSMBAfterDailyChallenge;
		}
		set
		{
			_willShowSMBAfterDailyChallenge = value;
		}
	}

	public int amountOfSuperMysteryBoxesOpened
	{
		get
		{
			return _amountOfSuperMysteryBoxesOpened;
		}
		set
		{
			if (value != _amountOfSuperMysteryBoxesOpened)
			{
				_dirty = true;
				_amountOfSuperMysteryBoxesOpened = value;
			}
		}
	}

	public int amountOfSeasonalEggs
	{
		get
		{
			return _amountOfSeasonalEggs;
		}
		set
		{
			if (value != _amountOfSeasonalEggs)
			{
				_dirty = true;
				_amountOfSeasonalEggs = value;
			}
		}
	}

	public string weeklyChallangeData
	{
		get
		{
			return _weeklyChallangeData;
		}
		set
		{
			if (_weeklyChallangeData != value)
			{
				_weeklyChallangeData = value;
				_dirty = true;
			}
		}
	}

	public string lastPlayDate
	{
		get
		{
			return _lastPlayDate;
		}
		set
		{
			if (_lastPlayDate != value)
			{
				_lastPlayDate = value;
				_dirty = true;
			}
		}
	}

	public string lastQuitDate
	{
		get
		{
			return _lastQuitDate;
		}
		set
		{
			if (_lastQuitDate != value)
			{
				_lastQuitDate = value;
				_dirty = true;
			}
		}
	}

	public string lastDailyOnlineLog
	{
		get
		{
			return _lastDailyOnlineLog;
		}
		set
		{
			if (_lastDailyOnlineLog != value)
			{
				_lastDailyOnlineLog = value;
				_dirty = true;
			}
		}
	}

	public bool hasReceivedFirstMBKey
	{
		get
		{
			return _hasReceivedFirstMBKey;
		}
		set
		{
			if (value != _hasReceivedFirstMBKey)
			{
				_dirty = true;
				_hasReceivedFirstMBKey = value;
			}
		}
	}

	public bool hasReceivedFirstSMBKey
	{
		get
		{
			return _hasReceivedFirstSMBKey;
		}
		set
		{
			if (value != _hasReceivedFirstSMBKey)
			{
				_dirty = true;
				_hasReceivedFirstSMBKey = value;
			}
		}
	}

	public List<CelebrationReward> pendingRewards => _pendingRewards;

	public CelebrationReward lastAddedReward => _lastAddedReward;

	public string lastTopRunResultAwardedID
	{
		get
		{
			return _lastTopRunResultAwardedID;
		}
		set
		{
			if (_lastTopRunResultAwardedID != value)
			{
				_lastTopRunResultAwardedID = value;
				_dirty = true;
			}
		}
	}

	public string pendingTopRunResultID
	{
		get
		{
			return _pendingTopRunResultID;
		}
		set
		{
			if (_pendingTopRunResultID != value)
			{
				_pendingTopRunResultID = value;
				_dirty = true;
			}
		}
	}

	public int pendingTopRunResultScore
	{
		get
		{
			return _pendingTopRunResultsScore;
		}
		set
		{
			if (value != _pendingTopRunResultsScore)
			{
				_dirty = true;
				_pendingTopRunResultsScore = value;
			}
		}
	}

	public int pendingTopRunResultsRank
	{
		get
		{
			return _pendingTopRunResultsRank;
		}
		set
		{
			if (value != _pendingTopRunResultsRank)
			{
				_dirty = true;
				_pendingTopRunResultsRank = value;
			}
		}
	}

	public int pendingTopRunResultsWeek
	{
		get
		{
			return _pendingTopRunResultsWeek;
		}
		set
		{
			if (value != _pendingTopRunResultsWeek)
			{
				_dirty = true;
				_pendingTopRunResultsWeek = value;
			}
		}
	}

	public int pendingTopRunBeatenFriendsAward
	{
		get
		{
			return _pendingTopRunBeatenFriendsAward;
		}
		set
		{
			if (value != _pendingTopRunBeatenFriendsAward)
			{
				_dirty = true;
				_pendingTopRunBeatenFriendsAward = value;
			}
		}
	}

	public int lastWeekMedalWasShown
	{
		get
		{
			return _lastWeekMedalWasShown;
		}
		set
		{
			if (value != _lastWeekMedalWasShown)
			{
				_dirty = true;
				_lastWeekMedalWasShown = value;
			}
		}
	}

	public float AnalyticsSamplingKey
	{
		get
		{
			float analyticsSamplingKey = _analyticsSamplingKey;
			if (_analyticsSamplingKey < 0f)
			{
				SetAnalyticsSamplingKey();
				analyticsSamplingKey = _analyticsSamplingKey;
			}
			return analyticsSamplingKey;
		}
		set
		{
			if (!(value < 0f))
			{
				_analyticsSamplingKey = value;
			}
		}
	}

	public string SyboAnalyticsUserId
	{
		get
		{
			return _syboAnalyticsUserId;
		}
		set
		{
			//IL_002a: Expected Obj, but got I4
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected Obj, but got Unknown
			//IL_000e: Expected Obj, but got I4
			string syboAnalyticsUserId = _syboAnalyticsUserId;
			object obj;
			if (_syboAnalyticsUserId != null)
			{
				obj = 0;
				if (syboAnalyticsUserId._stringLength != 0)
				{
					goto IL_0096;
				}
			}
			obj = 1;
			goto IL_0096;
			IL_0096:
			object obj2 = obj ^ 1;
			if (obj2 == null)
			{
				_syboAnalyticsUserId = value;
				_dirty = true;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
	}

	public bool IsSyboAnalyticsUserIdAssigned
	{
		get
		{
			//IL_004e: Expected Obj, but got I4
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected I4, but got Unknown
			//IL_0032: Expected Obj, but got I4
			string syboAnalyticsUserId = _syboAnalyticsUserId;
			object obj;
			if (_syboAnalyticsUserId != null)
			{
				obj = 0;
				if (syboAnalyticsUserId._stringLength != 0)
				{
					goto IL_0053;
				}
			}
			obj = 1;
			goto IL_0053;
			IL_0053:
			return (byte)(obj ^ 1) != 0;
		}
	}

	public int SyboAnalyticsCurrentSession
	{
		get
		{
			return _syboAnalyticsCurrentSession;
		}
		set
		{
			_dirty = true;
			_syboAnalyticsCurrentSession = value;
		}
	}

	public int SyboAnalyticsGamesSinceFlush
	{
		get
		{
			return _syboAnalyticsGamesSinceFlush;
		}
		set
		{
			_dirty = true;
			_syboAnalyticsGamesSinceFlush = value;
		}
	}

	public string SyboAnalyticsPreviousClientVersion
	{
		get
		{
			return _syboAnalyticsPreviousClientVersion;
		}
		set
		{
			_syboAnalyticsPreviousClientVersion = value;
			_dirty = true;
		}
	}

	public long SyboLastPurchaseNumber => _syboLastPurchaseNumber;

	public int currentMissionSet => _currentMissionSet;

	public int lastMissionCompleted => _lastMissionCompleted;

	public int missionCompletedSum
	{
		get
		{
			bool flag = _missionCompletedSum == 0;
			bool flag2 = !flag;
			int result = _missionCompletedSum;
			if (!flag2)
			{
				result = (_missionCompletedSum = _currentMissionSet + 1);
			}
			return result;
		}
		set
		{
			_missionCompletedSum = value;
		}
	}

	public int BaseMissionScoremultiplier
	{
		get
		{
			int num = _currentMissionSet + 1;
			if (num >= 30)
			{
				num = 30;
			}
			if (num <= 1)
			{
				num = 1;
			}
			return num;
		}
	}

	public int scoreMultiplier
	{
		get
		{
			//IL_004a: Expected Obj, but got I4
			//IL_0062: Expected Obj, but got I4
			//IL_015e: Expected Obj, but got I4
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected I4, but got Unknown
			//IL_0079: Expected Obj, but got I4
			int num = _currentMissionSet + 1;
			if (num >= 30)
			{
				num = 30;
			}
			if (num <= 1)
			{
				num = 1;
			}
			int num2 = num + 5;
			GameStats instance = GameStats.Instance;
			if (!instance._characterDayEventActivated)
			{
				num2 = num;
			}
			GameStats instance2 = GameStats.Instance;
			bool flag = (byte)(~(instance2._scoreBoosterActivated ? 1u : 0u)) != 0;
			int num3 = num2;
			if (!flag)
			{
				GameStats instance3 = GameStats.Instance;
				object obj = instance3._scoreBoosterTier - 1;
				bool flag2 = (nint)obj == 1;
				object obj2 = 6;
				if (!flag2)
				{
					obj2 = 5;
				}
				bool flag3 = (nint)obj == 2;
				object obj3 = 7;
				if (!flag3)
				{
					obj3 = obj2;
				}
				int num4 = num2 + obj3;
				num3 = num4;
			}
			int num5 = num3 + 10;
			if (!PlusMultiplier.plusMultiplierEnabled)
			{
				num5 = num3;
			}
			int result = num5 << 1;
			if (!_doubleScore)
			{
				result = num5;
			}
			return result;
		}
	}

	public int rawMultiplier
	{
		get
		{
			int num = _currentMissionSet + 1;
			if (num >= 30)
			{
				num = 30;
			}
			if (num <= 1)
			{
				num = 1;
			}
			return num;
		}
	}

	public int currentThemeIndex
	{
		get
		{
			return GetIndexForLastSelectedTheme((Characters.CharacterType)_currentCharacter);
		}
		set
		{
			SetLastSelectedTheme((Characters.CharacterType)_currentCharacter, value);
		}
	}

	public DateTime lastTimeInterstitialProviderHasChanged
	{
		get
		{
			return _lastTimeInterstitialProviderHasChanged;
		}
		set
		{
			if (_lastTimeInterstitialProviderHasChanged != value)
			{
				_dirty = true;
				_lastTimeInterstitialProviderHasChanged = value;
			}
		}
	}

	public DateTime lastTimeInterstitialWasSeen
	{
		get
		{
			return _lastTimeInterstitialWasSeen;
		}
		set
		{
			if (_lastTimeInterstitialWasSeen != value)
			{
				_dirty = true;
				_lastTimeInterstitialWasSeen = value;
			}
		}
	}

	public DateTime dailyInterstitialsTimeLeft
	{
		get
		{
			return _dailyInterstitialExpireTime;
		}
		set
		{
			if (_dailyInterstitialExpireTime != value)
			{
				_dirty = true;
				_dailyInterstitialExpireTime = value;
			}
		}
	}

	public DateTime hourlyInterstitialsTimeLeft
	{
		get
		{
			return _hourlyInterstitialExpireTime;
		}
		set
		{
			if (_hourlyInterstitialExpireTime != value)
			{
				_dirty = true;
				_hourlyInterstitialExpireTime = value;
			}
		}
	}

	public int numberOfInterstitialsPerDay
	{
		get
		{
			return _numberOfInterstitialsPerDay;
		}
		set
		{
			if (value != _numberOfInterstitialsPerDay)
			{
				_dirty = true;
				_numberOfInterstitialsPerDay = value;
			}
		}
	}

	public int numberOfInterstitialsPerHour
	{
		get
		{
			return _numberOfInterstitialsPerHour;
		}
		set
		{
			if (value != _numberOfInterstitialsPerHour)
			{
				_dirty = true;
				_numberOfInterstitialsPerHour = value;
			}
		}
	}

	public int interstitialProviderListVersion
	{
		get
		{
			return _interstitialProviderListVersion;
		}
		set
		{
			if (value != _interstitialProviderListVersion)
			{
				_dirty = true;
				_interstitialProviderListVersion = value;
			}
		}
	}

	public int currentCharacter
	{
		get
		{
			return _currentCharacter;
		}
		set
		{
			if (value != _currentCharacter)
			{
				_dirty = true;
				_currentCharacter = value;
			}
		}
	}

	public Characters.CharacterType currentCharacterType => (Characters.CharacterType)_currentCharacter;

	public Hoverboards.BoardType currentHoverboard
	{
		get
		{
			return _currentHoverboard;
		}
		set
		{
			if (value != _currentHoverboard)
			{
				_dirty = true;
				_currentHoverboard = value;
			}
		}
	}

	public Hoverboards.BoardType previousHoverboard
	{
		get
		{
			return _previousHoverboard;
		}
		set
		{
			if (value != _previousHoverboard)
			{
				_dirty = true;
				_previousHoverboard = value;
			}
		}
	}

	public int[] achievementProgress => _achievementProgress;

	public bool hasCollectedFirstAwardReward
	{
		get
		{
			return _hasCollectedFirstAwardReward;
		}
		set
		{
			if (value != _hasCollectedFirstAwardReward)
			{
				_dirty = true;
				_hasCollectedFirstAwardReward = value;
			}
		}
	}

	public bool hasCollectedFacebookWeeklyGiftThisWeek
	{
		get
		{
			return _hasCollectedFacebookWeeklyGiftThisWeek;
		}
		set
		{
			if (value != _hasCollectedFacebookWeeklyGiftThisWeek)
			{
				_dirty = true;
				_hasCollectedFacebookWeeklyGiftThisWeek = value;
			}
		}
	}

	public bool hasPayedOutFacebook
	{
		get
		{
			return _hasPayedOutFacebook;
		}
		set
		{
			if (value != _hasPayedOutFacebook)
			{
				_dirty = true;
				_hasPayedOutFacebook = value;
			}
		}
	}

	public bool hasPayedOutFacebookPack
	{
		get
		{
			return _hasPayedOutFacebookPack;
		}
		set
		{
			if (value != _hasPayedOutFacebookPack)
			{
				_dirty = true;
				_hasPayedOutFacebookPack = value;
			}
		}
	}

	public bool hasPayedOutFacebookCharacter
	{
		get
		{
			return _hasPayedOutFacebookCharacter;
		}
		set
		{
			if (value != _hasPayedOutFacebookCharacter)
			{
				_dirty = true;
				_hasPayedOutFacebookCharacter = value;
			}
		}
	}

	public int SecondDayLeft
	{
		get
		{
			return _SecondDayLeft;
		}
		set
		{
			if (value != _SecondDayLeft)
			{
				_dirty = true;
				_SecondDayLeft = value;
			}
		}
	}

	public bool hasPayedOutGameCenter
	{
		get
		{
			return _hasPayedOutGameCenter;
		}
		set
		{
			if (value != _hasPayedOutGameCenter)
			{
				_dirty = true;
				_hasPayedOutGameCenter = value;
			}
		}
	}

	public string dailyWord => _dailyWord;

	public int dailyWordInRow => _dailyWordInRow;

	public int dailyWordLastPayoutDayOfYear => _dailyWordLastPayoutDayOfYear;

	public IntMask dailyWordUnlockedMask => _dailyWordUnlockedMask;

	public TimeSpan dailyWordTimeLeft
	{
		get
		{
			DateTime utcNow = CDateTime.UtcNow;
			return _dailyWordExpireTime - utcNow;
		}
	}

	public TimeSpan dailyWordDeviceTiemLeft
	{
		get
		{
			DateTime utcNow = CDateTime.UtcNow;
			return _dailyWordExpireDeviceTime - utcNow;
		}
	}

	public bool IsTutorialCompleted
	{
		get
		{
			return _isTutorialCompleted;
		}
		set
		{
			if (value != _isTutorialCompleted)
			{
				_dirty = true;
				_isTutorialCompleted = value;
			}
		}
	}

	public int numberOfBreadCrumbsShownOnFrontPage => _numberOfBreadCrumbsShownOnFrontPage;

	public bool shouldRestoreAfterEvent
	{
		get
		{
			return _shouldRestoreAfterEvent;
		}
		set
		{
			if (value != _shouldRestoreAfterEvent)
			{
				_dirty = true;
				_shouldRestoreAfterEvent = value;
			}
		}
	}

	public long lastEventID
	{
		get
		{
			return _lastEventID;
		}
		set
		{
			if (value != _lastEventID)
			{
				_dirty = true;
				_lastEventID = value;
			}
		}
	}

	public string lastEventItemID
	{
		get
		{
			return _lastEventItemID;
		}
		set
		{
			if (_lastEventItemID != value)
			{
				_lastEventItemID = value;
				_dirty = true;
			}
		}
	}

	public long lastTimeAnEventWasStarted
	{
		get
		{
			return _lastTimeAnEventWasStarted;
		}
		set
		{
			if (value != _lastTimeAnEventWasStarted)
			{
				_dirty = true;
				_lastTimeAnEventWasStarted = value;
			}
		}
	}

	public long lastTimeAnEventHasBeenTried
	{
		get
		{
			return _lastTimeAnEventHasBeenTried;
		}
		set
		{
			if (value != _lastTimeAnEventHasBeenTried)
			{
				_dirty = true;
				_lastTimeAnEventHasBeenTried = value;
			}
		}
	}

	public long lastTimeEventPopupHasBeenForcedShown
	{
		get
		{
			return _lastTimeEventPopupHasBeenForcedShown;
		}
		set
		{
			if (value != _lastTimeEventPopupHasBeenForcedShown)
			{
				_dirty = true;
				_lastTimeEventPopupHasBeenForcedShown = value;
			}
		}
	}

	public DateTime lastKnownServerTime
	{
		get
		{
			return _lastKnownServerTime;
		}
		set
		{
			_dirty = true;
			_lastKnownServerTime = value;
			Action action = this.m_onKnownServerTimeChange;
			if (this.m_onKnownServerTimeChange != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v7.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public DateTime lastTimeAVideoForKeysWasSeen
	{
		get
		{
			return _lastTimeAVideoForKeysWasSeen;
		}
		set
		{
			_dirty = true;
			_lastTimeAVideoForKeysWasSeen = value;
		}
	}

	public DateTime weeklyGiftEndTime
	{
		get
		{
			return _weeklyGiftEndTime;
		}
		set
		{
			_dirty = true;
			_weeklyGiftEndTime = value;
		}
	}

	public DateTime lastTimeAppWasUpdatedOrInstalled
	{
		get
		{
			return _lastTimeAppWasUpdatedOrInstalled;
		}
		set
		{
			_dirty = true;
			_lastTimeAppWasUpdatedOrInstalled = value;
		}
	}

	public DateTime firstInstallDate
	{
		get
		{
			return _firstInstallDate;
		}
		set
		{
			_dirty = true;
			_firstInstallDate = value;
		}
	}

	public string firstInstalledVersion
	{
		get
		{
			return _firstInstalledVersion;
		}
		set
		{
			_firstInstalledVersion = value;
			_dirty = true;
		}
	}

	public bool hasShownHoverboardPopup
	{
		get
		{
			return _hasShownHoverboardPopup;
		}
		set
		{
			if (value != _hasShownHoverboardPopup)
			{
				_dirty = true;
				_hasShownHoverboardPopup = value;
			}
		}
	}

	public bool shouldShowHoverboardPopup
	{
		get
		{
			return _shouldShowHoverboardPopup;
		}
		set
		{
			if (value != _shouldShowHoverboardPopup)
			{
				_dirty = true;
				_shouldShowHoverboardPopup = value;
			}
		}
	}

	public bool hasShownFacebookPopup
	{
		get
		{
			return _hasShownFacebookPopup;
		}
		set
		{
			if (value != _hasShownFacebookPopup)
			{
				_dirty = true;
				_hasShownFacebookPopup = value;
			}
		}
	}

	public bool shouldShowFacebookPopup
	{
		get
		{
			return _shouldShowFacebookPopup;
		}
		set
		{
			if (value != _shouldShowFacebookPopup)
			{
				_dirty = true;
				_shouldShowFacebookPopup = value;
			}
		}
	}

	public bool hasShownDuelIntroductionPopup
	{
		get
		{
			return _hasShownDuelIntroductionPopup;
		}
		set
		{
			if (value != _hasShownDuelIntroductionPopup)
			{
				_dirty = true;
				_hasShownDuelIntroductionPopup = value;
			}
		}
	}

	public bool shouldShowDuelIntroductionPopup
	{
		get
		{
			return _shouldShowDuelIntroductionPopup;
		}
		set
		{
			if (value != _shouldShowDuelIntroductionPopup)
			{
				_dirty = true;
				_shouldShowDuelIntroductionPopup = value;
			}
		}
	}

	public bool hasShownAwardsIntroductionPopup
	{
		get
		{
			return _hasShownAwardsIntroductionPopup;
		}
		set
		{
			if (value != _hasShownAwardsIntroductionPopup)
			{
				_dirty = true;
				_hasShownAwardsIntroductionPopup = value;
			}
		}
	}

	public bool hasShownHoverboardCustmoizationPopup
	{
		get
		{
			return _hasShownHoverboardCustmoizationPopup;
		}
		set
		{
			if (value != _hasShownHoverboardCustmoizationPopup)
			{
				_dirty = true;
				_hasShownHoverboardCustmoizationPopup = value;
			}
		}
	}

	public bool hasShownTurboHeadstartIntroductionPopup
	{
		get
		{
			return _hasShownTurboHeadstartIntroductionPopup;
		}
		set
		{
			if (value != _hasShownTurboHeadstartIntroductionPopup)
			{
				_dirty = true;
				_hasShownTurboHeadstartIntroductionPopup = value;
			}
		}
	}

	public bool hasShownTopRunIntroductionPopup
	{
		get
		{
			return _hasShownTopRunIntroductionPopup;
		}
		set
		{
			if (value != _hasShownTopRunIntroductionPopup)
			{
				_dirty = true;
				_hasShownTopRunIntroductionPopup = value;
			}
		}
	}

	public int lastShownTopRunIntroPopupVersionNumber
	{
		get
		{
			return _lastShownTopRunIntroPopupVersionNumber;
		}
		set
		{
			if (value != _lastShownTopRunIntroPopupVersionNumber)
			{
				_dirty = true;
				_lastShownTopRunIntroPopupVersionNumber = value;
			}
		}
	}

	public bool shouldShowDuelsBreadcrumb
	{
		get
		{
			return _shouldShowDuelsBreadcrumb;
		}
		set
		{
			if (value != _shouldShowDuelsBreadcrumb)
			{
				_dirty = true;
				_shouldShowDuelsBreadcrumb = value;
			}
		}
	}

	public bool hasShownMission1Popup
	{
		get
		{
			return _hasShownMission1Popup;
		}
		set
		{
			if (value != _hasShownMission1Popup)
			{
				_dirty = true;
				_hasShownMission1Popup = value;
			}
		}
	}

	public bool shouldShowMission1Popup
	{
		get
		{
			return _shouldShowMission1Popup;
		}
		set
		{
			if (value != _shouldShowMission1Popup)
			{
				_dirty = true;
				_shouldShowMission1Popup = value;
			}
		}
	}

	public bool hasShownCollectPopup
	{
		get
		{
			return _hasShownCollectPopup;
		}
		set
		{
			if (value != _hasShownCollectPopup)
			{
				_dirty = true;
				_hasShownCollectPopup = value;
			}
		}
	}

	public bool shouldShowCollectPopup
	{
		get
		{
			return _shouldShowCollectPopup;
		}
		set
		{
			if (value != _shouldShowCollectPopup)
			{
				_dirty = true;
				_shouldShowCollectPopup = value;
			}
		}
	}

	public bool hasShownMission2Popup
	{
		get
		{
			return _hasShownMission2Popup;
		}
		set
		{
			if (value != _hasShownMission2Popup)
			{
				_dirty = true;
				_hasShownMission2Popup = value;
			}
		}
	}

	public bool shouldShowMission2Popup
	{
		get
		{
			return _shouldShowMission2Popup;
		}
		set
		{
			bool flag = _shouldShowMission2Popup;
			if (value != flag)
			{
				_dirty = true;
				_shouldShowMission2Popup = value;
			}
		}
	}

	public bool hasCollectedFromFriends
	{
		get
		{
			return _hasCollectedFromFriends;
		}
		set
		{
			if (value != _hasCollectedFromFriends)
			{
				_dirty = true;
				_hasCollectedFromFriends = value;
			}
		}
	}

	public int numberOfRuns
	{
		get
		{
			return _numberOfRuns;
		}
		set
		{
			if (value != _numberOfRuns)
			{
				_dirty = true;
				_numberOfRuns = value;
			}
		}
	}

	public bool isSaveMePopupEnabled
	{
		get
		{
			return _isSaveMePopupEnabled;
		}
		set
		{
			if (value != _isSaveMePopupEnabled)
			{
				_dirty = true;
				_isSaveMePopupEnabled = value;
			}
		}
	}

	public bool hasShownVoucherPopupOnFrontScreen
	{
		get
		{
			return _hasShownVoucherPopupOnFrontScreen;
		}
		set
		{
			if (value != _hasShownVoucherPopupOnFrontScreen)
			{
				_dirty = true;
				_hasShownVoucherPopupOnFrontScreen = value;
			}
		}
	}

	public bool hasShownVoucherPopupInShop
	{
		get
		{
			return _hasShownVoucherPopupInShop;
		}
		set
		{
			if (value != _hasShownVoucherPopupInShop)
			{
				_dirty = true;
				_hasShownVoucherPopupInShop = value;
			}
		}
	}

	public string ShouldUseAlternativeHuntPrizes
	{
		get
		{
			return _shouldUseAlternativeHuntPrizes;
		}
		set
		{
			if (_shouldUseAlternativeHuntPrizes != value)
			{
				_shouldUseAlternativeHuntPrizes = value;
				_dirty = true;
			}
		}
	}

	public int LatestAvailableAssetBundlesVersion
	{
		get
		{
			return _latestAvailableAssetBundlesVersion;
		}
		set
		{
			_dirty = true;
			_latestAvailableAssetBundlesVersion = value;
		}
	}

	public bool AllAssetBundlesDownloaded
	{
		get
		{
			return _allAssetBundlesDownloaded;
		}
		set
		{
			_dirty = true;
			_allAssetBundlesDownloaded = value;
		}
	}

	public bool dummyFriendCollected
	{
		get
		{
			return _dummyFriendCollected;
		}
		set
		{
			_dirty = true;
			_dummyFriendCollected = value;
		}
	}

	public bool dummyFriendShouldShow
	{
		get
		{
			return _dummyFriendShouldShow;
		}
		set
		{
			_dirty = true;
			_dummyFriendShouldShow = value;
		}
	}

	public int inAppLegacyPurchaseCount
	{
		get
		{
			return _inAppLegacyPurchaseCount;
		}
		set
		{
			_dirty = true;
			_inAppLegacyPurchaseCount = value;
		}
	}

	public int inAppConsumablePurchaseCount
	{
		get
		{
			return _inAppConsumablePurchaseCount;
		}
		set
		{
			_dirty = true;
			_inAppConsumablePurchaseCount = value;
		}
	}

	public int inAppNonconsumablePurchaseCount
	{
		get
		{
			return _inAppNonconsumablePurchaseCount;
		}
		set
		{
			_dirty = true;
			_inAppNonconsumablePurchaseCount = value;
		}
	}

	public int inAppRestoredPurchaseCount
	{
		get
		{
			return _inAppRestoredPurchaseCount;
		}
		set
		{
			_dirty = true;
			_inAppRestoredPurchaseCount = value;
		}
	}

	public bool hasMadeOneValidPurchase
	{
		get
		{
			return _hasMadeOneValidPurchase;
		}
		set
		{
			_dirty = true;
			_hasMadeOneValidPurchase = value;
		}
	}

	public bool hasLoggedSyboUserId
	{
		get
		{
			return _hasLoggedSyboUserId;
		}
		set
		{
			_dirty = true;
			_hasLoggedSyboUserId = value;
		}
	}

	public string earnCurrenyData
	{
		get
		{
			return _earnCurrenyData;
		}
		set
		{
			_earnCurrenyData = value;
			_dirty = true;
		}
	}

	public bool HasDoubleCoinsUpgrade
	{
		get
		{
			return _hasDoubleCoinsUpgrade;
		}
		set
		{
			if (value != _hasDoubleCoinsUpgrade)
			{
				_dirty = true;
				_hasDoubleCoinsUpgrade = value;
			}
		}
	}

	public InAppData.BundleTier lastPurchasedBundle
	{
		get
		{
			return _lastPurchasedBundle;
		}
		private set
		{
			if (value != _lastPurchasedBundle)
			{
				_dirty = true;
				_lastPurchasedBundle = value;
			}
		}
	}

	public bool hasShownKeysPopup
	{
		get
		{
			return _hasShownKeysPopup;
		}
		set
		{
			if (value != _hasShownKeysPopup)
			{
				_dirty = true;
				_hasShownKeysPopup = value;
			}
		}
	}

	public Statistics stats => _stats;

	public string trophyMissionData
	{
		get
		{
			return _trophyMissionData;
		}
		set
		{
			if (_trophyMissionData != value)
			{
				_trophyMissionData = value;
				_dirty = true;
			}
		}
	}

	public string characterNameEventData
	{
		get
		{
			return _characterNameEventData;
		}
		set
		{
			if (_characterNameEventData != value)
			{
				_characterNameEventData = value;
				_dirty = true;
			}
		}
	}

	public HoverboardCustomizationData HoverboardCustomizationData
	{
		get
		{
			return _hoverboardCustomizationData;
		}
		private set
		{
			_hoverboardCustomizationData = value;
		}
	}

	public CollectCoinsDummyData CollectCoinsDummyData
	{
		get
		{
			return _collectCoinsDummyData;
		}
		private set
		{
			_collectCoinsDummyData = value;
		}
	}

	public bool neverAskForRating
	{
		get
		{
			return _neverAskForRating;
		}
		set
		{
			if (value != _neverAskForRating)
			{
				_dirty = true;
				_neverAskForRating = value;
			}
		}
	}

	public string lastVersionRated
	{
		get
		{
			return _lastVersionRated;
		}
		set
		{
			if (_lastVersionRated != value)
			{
				_lastVersionRated = value;
				_dirty = true;
			}
		}
	}

	public int ratingAskCounter
	{
		get
		{
			return _ratingAskCounter;
		}
		set
		{
			if (value != _ratingAskCounter)
			{
				_dirty = true;
				_ratingAskCounter = value;
			}
		}
	}

	public int missionsVersionLastUpdate
	{
		get
		{
			return _missionsVersionLastUpdate;
		}
		set
		{
			if (value != _missionsVersionLastUpdate)
			{
				_dirty = true;
				_missionsVersionLastUpdate = value;
			}
		}
	}

	public bool remoteNotificationsEnabled
	{
		get
		{
			return _remoteNotificationsEnabled;
		}
		set
		{
			if (value != _remoteNotificationsEnabled)
			{
				_dirty = true;
				_remoteNotificationsEnabled = value;
			}
		}
	}

	public bool isFreshInstall
	{
		get
		{
			return _isFreshInstall;
		}
		set
		{
			if (value != _isFreshInstall)
			{
				_dirty = true;
				_isFreshInstall = value;
			}
		}
	}

	public bool hasLoggedStaticData
	{
		get
		{
			return _hasLoggedStaticData;
		}
		set
		{
			if (value != _hasLoggedStaticData)
			{
				_dirty = true;
				_hasLoggedStaticData = value;
			}
		}
	}

	public unsafe string FlurryUserId
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			//IL_0073: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected VT, but got Unknown
			//IL_00aa: Expected Ref, but got VT
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			_ = 0;
			object result = this + 592;
			string flurryUserId = _flurryUserId;
			object obj3;
			if (_flurryUserId != null)
			{
				obj3 = 0;
				if (flurryUserId._stringLength != 0)
				{
					goto IL_00cd;
				}
			}
			obj3 = 1;
			goto IL_00cd;
			IL_00cd:
			if (obj3 != null)
			{
				Guid guid = Guid.NewGuid();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Guid guid2 = (Guid)(obj + 16);
				string flurryUserId2 = ((Guid*)guid2)->ToString();
				_flurryUserId = flurryUserId2;
				_dirty = true;
			}
			return (string)result;
		}
	}

	public string flurryUserIdHash
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0059: Expected Obj, but got I4
			//IL_003d: Expected Obj, but got I4
			object result = this + 600;
			string text = _flurryUserIdHash;
			object obj;
			if (_flurryUserIdHash != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_009c;
				}
			}
			obj = 1;
			goto IL_009c;
			IL_009c:
			if (obj != null)
			{
				string flurryUserId = FlurryUserId;
				byte[] bytes = Checksum.ComputeSHA256(flurryUserId);
				string text2 = StringUtility.ToHexString(bytes);
				_flurryUserIdHash = text2;
			}
			return (string)result;
		}
	}

	public bool allowSellHeadstartDuringRun
	{
		get
		{
			return _allowSellHeadstartDuringRun;
		}
		set
		{
			if (value != _allowSellHeadstartDuringRun)
			{
				_dirty = true;
				_allowSellHeadstartDuringRun = value;
			}
		}
	}

	public bool allowSellScoreboosterDuringRun
	{
		get
		{
			return _allowSellScoreboosterDuringRun;
		}
		set
		{
			if (value != _allowSellScoreboosterDuringRun)
			{
				_dirty = true;
				_allowSellScoreboosterDuringRun = value;
			}
		}
	}

	public int ageRestrictionInputVersion
	{
		get
		{
			return _ageRestrictionInputVersion;
		}
		set
		{
			if (value != _ageRestrictionInputVersion)
			{
				_dirty = true;
				_ageRestrictionInputVersion = value;
			}
		}
	}

	public int ageRestrictionInputMonth
	{
		get
		{
			return _ageRestrictionInputMonth;
		}
		set
		{
			if (value != _ageRestrictionInputMonth)
			{
				_dirty = true;
				_ageRestrictionInputMonth = value;
			}
		}
	}

	public int ageRestrictionInputYear
	{
		get
		{
			return _ageRestrictionInputYear;
		}
		set
		{
			if (value != _ageRestrictionInputYear)
			{
				_dirty = true;
				_ageRestrictionInputYear = value;
			}
		}
	}

	public float doubleScoreMultiplierDuration => GetPowerupDuration(PowerupType.doubleMultiplier);

	public bool doubleScore
	{
		get
		{
			return _doubleScore;
		}
		set
		{
			if (value != _doubleScore)
			{
				_doubleScore = value;
				Action action = onScoreMultiplierChanged;
				if (onScoreMultiplierChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v10.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public static PlayerInfo Instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			PlayerInfo result = _instance;
			if (!flag2)
			{
				PlayerInfo playerInfo = default;
				playerInfo._002Ector();
				_instance = playerInfo;
				result = playerInfo;
			}
			return result;
		}
	}

	public event Action onKnownServerTimeChange
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 636;
			Delegate obj2 = this.m_onKnownServerTimeChange;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 636;
			Delegate obj2 = this.m_onKnownServerTimeChange;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private static string GenerateRandomID(int length)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0024: Expected I, but got Obj
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		System.Random random = default;
		random._002Ector();
		object obj = 0;
		char[] array = default;
		int index = default;
		while (length > (nint)obj)
		{
			object obj2 = "0123456789";
			nint num = (nint)random;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v4 (Il2CppClass<System.Random>)+F4] (should have been resolved before IL gen)");
			object obj3 = obj << 1;
			object obj4 = (object)array + obj3;
			char c = "0123456789".get_Chars(index);
			object obj5 = obj + 1;
			obj = obj5;
		}
		return ((string)null).CreateString(array);
	}

	private unsafe PlayerInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0469: Expected I4, but got I8
		//IL_04b6: Expected I8, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected VT, but got Unknown
		//IL_016e: Expected I8, but got I4
		//IL_0169: Expected native int or pointer, but got VT
		//IL_0185: Expected VT, but got I
		//IL_0194: Expected VT, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_weeklyChallangeData = string.Empty;
		_lastPlayDate = string.Empty;
		_lastQuitDate = string.Empty;
		_lastDailyOnlineLog = string.Empty;
		List<CelebrationReward> list = default;
		list._002Ector();
		_pendingRewards = list;
		_lastTopRunResultAwardedID = string.Empty;
		_pendingTopRunResultID = string.Empty;
		_lastWeekMedalWasShown = -1;
		_pendingTopRunResultsWeek = -1;
		_pendingTopRunResultsScore = -1;
		_syboAnalyticsUserId = string.Empty;
		_syboAnalyticsCurrentSession = -1;
		_syboAnalyticsPreviousClientVersion = string.Empty;
		_lastMissionCompleted = -1;
		_syboLastPurchaseNumber = -1L;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, int> lastSelectedThemes = default;
		_lastSelectedThemes = lastSelectedThemes;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, int[]> characterThemesSeen = default;
		_characterThemesSeen = characterThemesSeen;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ S4_v14 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, int[]> characterThemesUnlocked = default;
		_characterThemesUnlocked = characterThemesUnlocked;
		Dictionary<Characters.CharacterType, Characters.Model> characterData = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v9 (System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>)+10]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v9 (System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>)+18]");
		object obj3 = num7 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] collectedCharacterTokens = default;
		_collectedCharacterTokens = collectedCharacterTokens;
		nint num8 = 0;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S4_v19 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, bool> hasCharacterBeenSeen = default;
		_hasCharacterBeenSeen = hasCharacterBeenSeen;
		nint num10 = 0;
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ S4_v24 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Hoverboards.BoardType, bool> hoverboardUnlockStatus = default;
		_hoverboardUnlockStatus = hoverboardUnlockStatus;
		nint num12 = 0;
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ S4_v29 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Hoverboards.BoardType, bool> hasHoverboardBeenSeen = default;
		_hasHoverboardBeenSeen = hasHoverboardBeenSeen;
		_ = 0;
		*(DateTime*)(nint)(object)(obj + 8) = new DateTime(0L);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_unreportedGamesTimestamp = (DateTime)0;
		int length = Enum.GetValues(Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Trophies.Trophy))).Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		bool[] unlockedTrophies = default;
		_unlockedTrophies = unlockedTrophies;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] array = default;
		_achievementProgress = array;
		_dailyWord = string.Empty;
		_lastEventItemID = string.Empty;
		_shouldShowDuelsBreadcrumb = true;
		_shouldUseAlternativeHuntPrizes = string.Empty;
		_earnCurrenyData = string.Empty;
		nint num14 = 0;
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ S4_v34 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>>)+4] (should have been resolved before IL gen)");
		nint num16 = 0;
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num18 = 0;
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num20 = 0;
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v354 @ S5_v14+4] (should have been resolved before IL gen)");
		Dictionary<PowerupType, int> upgradeAmounts = default;
		_upgradeAmounts = upgradeAmounts;
		nint num22 = 0;
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ S4_v54 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>>)+4] (should have been resolved before IL gen)");
		nint num24 = 0;
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v391 @ S5_v19+4] (should have been resolved before IL gen)");
		nint num26 = 0;
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v407 @ S5_v24+4] (should have been resolved before IL gen)");
		nint num28 = 0;
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v423 @ S5_v29+4] (should have been resolved before IL gen)");
		nint num30 = 0;
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v439 @ S5_v34+4] (should have been resolved before IL gen)");
		nint num32 = 0;
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v455 @ S5_v39+4] (should have been resolved before IL gen)");
		Dictionary<PowerupType, int> upgradeTiers = default;
		_upgradeTiers = upgradeTiers;
		nint num34 = 0;
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v476 @ S4_v84 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> inappHistory = default;
		_inappHistory = inappHistory;
		_trophyMissionData = string.Empty;
		_characterNameEventData = string.Empty;
		_lastVersionRated = string.Empty;
		_remoteNotificationsEnabled = true;
		Load();
	}

	public void ResetHighestScoreTo(int score)
	{
		_formerHighScore = score;
		if (_highScore != score)
		{
			_dirty = true;
			_highScore = score;
			Action action = onHighScoreChanged;
			if (onHighScoreChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public void BragCompleted()
	{
		ResetHighestScoreTo(_highScore);
	}

	public void TriggerOnScoreMultiplierChanged()
	{
		Action action = onScoreMultiplierChanged;
		if (onScoreMultiplierChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public bool IsNewUser()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		object obj = _currentMissionSet + 1;
		if ((nint)obj >= 30)
		{
			obj = 30;
		}
		if ((nint)obj <= 1)
		{
			obj = 1;
		}
		return (nint)obj < 2;
	}

	public void AddSaveMeTokenToUnlock(int amount = 1)
	{
		int num = amountOfKeys;
		int num2 = num + amount;
		amountOfKeys = num2;
	}

	public void AddPendingReward(CelebrationReward reward)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		_lastAddedReward = reward;
		int num = -1;
		int num2 = -1;
		int num3 = 0;
		object obj = default;
		object obj2 = default;
		while (true)
		{
			List<CelebrationReward> list = _pendingRewards;
			if (num3 >= list._size)
			{
				break;
			}
			CelebrationReward celebrationReward = _pendingRewards.get_Item(num3);
			CelebrationReward celebrationReward2 = _pendingRewards.get_Item(num3);
			bool flag = celebrationReward2.CelebrationRewardOrigin == CelebrationRewardOrigin.CharacterEventSuperMysteryBox;
			int num4 = num3;
			if (!flag)
			{
				num4 = num;
			}
			if (num != -1)
			{
				num4 = num;
			}
			CelebrationReward celebrationReward3 = _pendingRewards.get_Item(num3);
			bool flag2 = celebrationReward3.CelebrationRewardOrigin == CelebrationRewardOrigin.NewHighScore;
			int num5 = num3;
			if (!flag2)
			{
				num5 = num2;
			}
			if (num2 != -1)
			{
				num5 = num2;
			}
			bool flag3 = celebrationReward.Uid == reward.Uid;
			obj = obj2 | flag3;
			int num6 = num3 + 1;
			num = num4;
			num2 = num5;
			num3 = num6;
		}
		object obj3 = obj & 1;
		if (obj3 != null)
		{
			return;
		}
		if (num2 >= 0 && reward.CelebrationRewardOrigin != CelebrationRewardOrigin.CharacterEventSuperMysteryBox)
		{
			_pendingRewards.Insert(num2, reward);
		}
		else if (num >= 0)
		{
			if (reward.CelebrationRewardOrigin == CelebrationRewardOrigin.CharacterEventSuperMysteryBox)
			{
				_pendingRewards.Add(reward);
			}
			else
			{
				_pendingRewards.Insert(num, reward);
			}
		}
		else
		{
			_pendingRewards.Add(reward);
		}
		_dirty = true;
	}

	public void RemovePendingReward(CelebrationReward reward)
	{
		throw new ArgumentException();
	}

	private void SetAnalyticsSamplingKey()
	{
		SyboRandom syboRandom = default;
		syboRandom._002Ector();
		double num = syboRandom.NextDouble();
		_dirty = true;
		_analyticsSamplingKey = (float)num;
	}

	public void SyboIncrementLastPurchaseNumber()
	{
		long syboLastPurchaseNumber = _syboLastPurchaseNumber + 1;
		_dirty = true;
		_syboLastPurchaseNumber = syboLastPurchaseNumber;
	}

	public bool IsCurrentMissionSetInited()
	{
		return false;
	}

	public void InitCurrentMissionSet(int missionSet, int missionCount, bool resetProgress)
	{
		//IL_0045: Expected Obj, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		if (missionSet == _currentMissionSet)
		{
			return;
		}
		_currentMissionSet = missionSet;
		if (resetProgress)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int[] currentMissionProgress = default;
			_currentMissionProgress = currentMissionProgress;
			object obj = 0;
			while ((nint)obj < missionCount)
			{
				object obj2 = obj << 2;
				object obj3 = (object)_currentMissionProgress + obj2;
				_ = 0;
				object obj4 = obj + 1;
				obj = obj4;
			}
		}
		_dirty = true;
		Action action = onScoreMultiplierChanged;
		if (onScoreMultiplierChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public int GetCurrentMissionProgress(int mission)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		if (mission >= 3)
		{
			object obj = mission - 3;
			object obj2 = obj << 2;
			object obj3 = (object)_achievementProgress + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v17+10]");
			return 0;
		}
		int[] currentMissionProgress = _currentMissionProgress;
		bool flag = _currentMissionProgress == null;
		int result = 0;
		if (!flag)
		{
			bool flag2 = currentMissionProgress.Length <= mission;
			result = 0;
			if (!flag2)
			{
				int num = mission << 2;
				object obj4 = _currentMissionProgress + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v13+10]");
				result = 0;
			}
		}
		return result;
	}

	public void SetCurrentMissionProgress(int mission, int progress)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		if (mission >= 3)
		{
			object obj = mission - 3;
			object obj2 = obj << 2;
			object obj3 = (object)_achievementProgress + obj2;
			return;
		}
		int num = mission << 2;
		object obj4 = _currentMissionProgress + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+10]");
		if ((nint)progress != 0)
		{
			int num2 = mission << 2;
			object obj5 = _currentMissionProgress + num2;
			_dirty = true;
		}
	}

	public bool IncrementCurrentMissionProgress(int mission, int target)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		int num = mission << 2;
		object obj = _currentMissionProgress + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v3+10]");
		if ((nint)target > (nint)0)
		{
			int num2 = mission << 2;
			object obj2 = _currentMissionProgress + num2;
			object obj3 = obj2 + 16;
			object obj4 = obj3 + 1;
			obj3 = obj4;
			_dirty = true;
			int num3 = mission << 2;
			object obj5 = _currentMissionProgress + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v15+10]");
			return (nint)target == 0;
		}
		return false;
	}

	public int GetCurrentRank()
	{
		MissionsManager instance = MissionsManager.Instance;
		int numberOfBasicMission = instance.GetNumberOfBasicMission();
		return _currentMissionSet / numberOfBasicMission;
	}

	public unsafe int GetIndexForLastSelectedTheme(Characters.CharacterType character)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		int result = default;
		if (_lastSelectedThemes.TryGetValue(character, out *(int*)(obj + 12)))
		{
			List<CharacterTheme> list = CharacterThemes.TryGetCustomThemesForChar(character);
			if (list != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				bool flag = (nint)0 > (nint)list._size;
				result = 0;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					result = 0;
				}
			}
		}
		return result;
	}

	public void SetLastSelectedTheme(Characters.CharacterType character, int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 != null)
		{
			Dictionary<Characters.CharacterType, int> lastSelectedThemes = _lastSelectedThemes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			bool flag = lastSelectedThemes.Remove(Characters.CharacterType.slick);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		if ((nint)0 >= (nint)1)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>)+5C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		_dirty = true;
	}

	public unsafe void ThemeSeen(Characters.CharacterType character, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Ref, but got Unknown
		//IL_0114: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _characterThemesSeen.TryGetValue(character, out *(int[]*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12+C]");
			object obj4 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj6 = default;
			object obj8 = default;
			object obj10 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v28+C]");
				if (0 <= (nint)obj6)
				{
					break;
				}
				object obj7 = obj8 << 2;
				object obj9 = obj10 + obj7;
				object obj11 = obj8 << 2;
				object obj12 = obj5 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v22+10]");
				_ = 0;
				obj6 = obj8 + 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v28+C]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj10 + obj13;
		}
		_characterThemesSeen.Remove(character);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32[]>>)+5C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S5_v4+4] (should have been resolved before IL gen)");
		_dirty = true;
	}

	public unsafe bool IsThemeSeenForCharacter(Characters.CharacterType character, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool result = default;
		if (index != 0)
		{
			bool flag = _characterThemesSeen.TryGetValue(character, out *(int[]*)(obj + 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj4 = 0;
				while (true)
				{
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ L1_v3+C]");
					bool flag2 = (nint)obj5 < 0;
					bool flag3 = !flag2;
					result = flag2;
					if (flag3)
					{
						break;
					}
					object obj6 = obj3 << 2;
					object obj7 = obj4 + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v11+10]");
					bool flag4 = (nint)index == 0;
					result = flag2;
					if (flag4)
					{
						break;
					}
					object obj8 = obj3 + 1;
					obj3 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					obj4 = 0;
				}
			}
		}
		return result;
	}

	public unsafe void UnlockTheme(Characters.CharacterType character, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Ref, but got Unknown
		//IL_016a: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _characterThemesUnlocked.TryGetValue(character, out *(int[]*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12+C]");
			object obj4 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj6 = default;
			object obj10 = default;
			object obj12 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v34+C]");
				if (0 <= (nint)obj6)
				{
					break;
				}
				object obj7 = obj6 << 2;
				object obj8 = obj5 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v22+10]");
				if ((nint)index != 0)
				{
					object obj9 = obj10 << 2;
					object obj11 = obj12 + obj9;
					object obj13 = obj10 << 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					object obj14 = 0 + obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v28+10]");
					_ = 0;
					obj6 = obj10 + 1;
					continue;
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v34+C]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj12 + obj15;
		}
		_characterThemesUnlocked.Remove(character);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32[]>>)+5C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S5_v5+4] (should have been resolved before IL gen)");
		_dirty = true;
		Action<Characters.CharacterType> onCharacterOutfitUnlocked = OnCharacterOutfitUnlocked;
		if (OnCharacterOutfitUnlocked != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S0_v25 (System.Action`1<SYBO.Subway.Info.Characters+CharacterType>)+C] (should have been resolved before IL gen)");
		}
	}

	public unsafe bool IsThemeUnlockedForCharacter(Characters.CharacterType character, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Ref, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool result = true;
		if (!Globals.DEBUG_ALL_CHARS)
		{
			bool flag = index == 0;
			result = true;
			if (!flag)
			{
				bool flag2 = _characterThemesUnlocked.TryGetValue(character, out *(int[]*)(obj + 12));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				bool flag3 = (nint)0 == 0;
				result = false;
				if (!flag3)
				{
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					object obj4 = 0;
					while (true)
					{
						object obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ L1_v3+C]");
						bool flag4 = (nint)obj5 < 0;
						bool flag5 = !flag4;
						result = flag4;
						if (flag5)
						{
							break;
						}
						object obj6 = obj3 << 2;
						object obj7 = obj4 + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v11+10]");
						bool flag6 = (nint)index == 0;
						result = flag4;
						if (flag6)
						{
							break;
						}
						object obj8 = obj3 + 1;
						obj3 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						obj4 = 0;
					}
				}
			}
		}
		return result;
	}

	public void CollectToken(Characters.CharacterType characterType, int amount)
	{
		//IL_003e: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		object obj = (int)characterType << 2;
		object obj2 = (object)_collectedCharacterTokens + obj;
		object obj3 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+10]");
		object obj4 = (nint)amount + (nint)0;
		obj3 = obj4;
		_dirty = true;
		if (OnTokenCollected != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	public bool IsCharacterOwned(Characters.CharacterType characterType)
	{
		return IsCollectionComplete(characterType);
	}

	private bool IsCollectionComplete(Characters.CharacterType characterType)
	{
		//IL_0055: Expected Obj, but got I4
		bool result = true;
		if (!Globals.DEBUG_ALL_CHARS)
		{
			Characters.Model model = Characters.characterData.get_Item(characterType);
			bool flag = model.unlockType == PurchaseData.UnlockType.AlwaysUnlocked;
			result = true;
			if (!flag)
			{
				object obj = (int)characterType << 2;
				object obj2 = (object)_collectedCharacterTokens + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+10]");
				bool flag2 = (nint)0 >= (nint)model.Price;
				result = flag2;
			}
		}
		return result;
	}

	public int GetCollectedTokens(Characters.CharacterType modelType)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = (int)modelType << 2;
		object obj2 = (object)_collectedCharacterTokens + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v3+10]");
		return 0;
	}

	public bool IsTokenUseful(Characters.CharacterType characterType, CelebrationReward currentReward = null, bool isDoubling = false)
	{
		return false;
	}

	public bool HasCharacterBeenSeen(Characters.CharacterType characterType)
	{
		//IL_0027: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Characters.Model model = Characters.characterData.get_Item(characterType);
		if (~(model.isNewInThisUpdate ? 1u : 0u) != 0)
		{
			return true;
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Boolean>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _hasCharacterBeenSeen.get_Item(characterType);
		}
		return false;
	}

	public void MarkCharacterAsSeen(Characters.CharacterType characterType)
	{
		//IL_0077: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Boolean>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Boolean>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Boolean>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		_dirty = true;
	}

	private DateTime DefaultExpirationDateForCharacter(Characters.CharacterType cType)
	{
		//IL_0056: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_008d: Expected VT, but got Obj
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		Characters.Model model = Characters.characterData.get_Item(cType);
		object obj;
		if (model.defaultExpirationDate != DateTime.MinValue)
		{
			obj = model + 48;
		}
		else
		{
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (Il2CppClass<System.DateTime>)+5C]");
			obj = (nint)0 + (nint)16;
		}
		return (DateTime)obj;
	}

	public unsafe DateTime CharacterExpirationDate(Characters.CharacterType characterType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Ref, but got Unknown
		//IL_02d8: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		object obj = default;
		PlayerInfo playerInfo = (PlayerInfo)(obj - 16);
		playerInfo.onCoinsChanged = null;
		_ = 0;
		Characters.Model model = Characters.characterData.get_Item(characterType);
		string key = "character_expiretime_" + model.modelName;
		OnlineSettings instance = OnlineSettings.instance;
		DateTime result;
		if (!instance.HasValue(key))
		{
			DateTime dateTime = playerInfo.DefaultExpirationDateForCharacter(characterType);
			result = dateTime;
		}
		else
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			bool flag = instance2.TryGetValue(key, out *(string*)(playerInfo + 12));
			bool flag2 = !flag;
			result = DateTime.MinValue;
			if (!flag2)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						DateTime dateTime2 = default;
						result = dateTime2;
						if (flag3)
						{
							goto IL_04ab;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						result = dateTime2;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						result = DateTime.MinValue;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					result = DateTime.MinValue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj2 = default;
				object obj3 = default;
				bool flag4 = obj2 != obj3;
				object obj5 = default;
				object obj4 = obj5;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj7 = default;
						object obj6 = obj7;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj8 = default;
							if (obj8 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (PlayerInfo)+4]");
								object obj9 = (nint)0 << 2;
								object obj10 = (object)playerInfo + obj9;
								obj10 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (PlayerInfo)+4]");
								object obj11 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								DateTime dateTime3 = playerInfo.DefaultExpirationDateForCharacter(characterType);
								string text = "Unable to convert '" + (string)(object)playerInfo.onCoinsChanged + "'.";
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (PlayerInfo)+4]");
								object obj12 = -1;
								result = dateTime3;
								goto IL_04ab;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj13 = obj7;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							obj4 = obj7;
							if (flag5)
							{
								goto IL_04b0;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					object obj14 = default;
					obj4 = obj14;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						obj4 = obj14;
					}
				}
				goto IL_04b0;
			}
		}
		goto IL_04ab;
		IL_04b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_04ab;
		IL_04ab:
		return result;
	}

	public unsafe DateTime CharacterStartAvailabilityDate(Characters.CharacterType characterType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Ref, but got Unknown
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_04ce: Expected VT, but got Obj
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_0308: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		Characters.Model model = Characters.characterData.get_Item(characterType);
		string key = "character_starttime_" + model.modelName;
		OnlineSettings instance = OnlineSettings.instance;
		DateTime result;
		if (!instance.HasValue(key))
		{
			object obj3;
			if (model.defaultStartDate != DateTime.MinValue)
			{
				obj3 = model + 56;
			}
			else
			{
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v161 (Il2CppClass<System.DateTime>)+5C]");
				obj3 = (nint)0 + (nint)8;
			}
			result = (DateTime)obj3;
			goto IL_04e1;
		}
		OnlineSettings instance2 = OnlineSettings.instance;
		if (!instance2.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_04d3;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				DateTime dateTime = default;
				result = dateTime;
				if (flag)
				{
					goto IL_04e1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag2 = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						string text = "Unable to convert '" + (string)0 + "'.";
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj14 = -1;
						goto IL_04d3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj15 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					obj6 = obj9;
					if (flag3)
					{
						goto IL_04e6;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj16 = default;
			obj6 = obj16;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj16;
			}
		}
		goto IL_04e6;
		IL_04e1:
		return result;
		IL_04e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_04d3;
		IL_04d3:
		result = DateTime.MinValue;
		goto IL_04e1;
	}

	public unsafe bool IsCharacterActive(Characters.CharacterType characterType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Ref, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		object obj = default;
		PlayerInfo playerInfo = (PlayerInfo)(obj - 16);
		playerInfo.onCoinsChanged = null;
		_ = 0;
		bool result = true;
		if (!Globals.DEBUG_ALL_CHARS)
		{
			result = true;
			if (!Globals.DEBUG_DISPLAY_ALL_CHARS)
			{
				Characters.Model model = Characters.characterData.get_Item(characterType);
				bool flag = (byte)(~(model.hasOnlineSettings ? 1u : 0u)) != 0;
				result = true;
				if (!flag)
				{
					string key = "character_expiretime_" + model.modelName;
					OnlineSettings instance = OnlineSettings.instance;
					if (instance.HasValue(key))
					{
						OnlineSettings instance2 = OnlineSettings.instance;
						if (instance2.TryGetValue(key, out *(string*)(playerInfo + 12)))
						{
							bool flag2 = (string)(object)playerInfo.onCoinsChanged != "disabled";
							result = false;
							if (!flag2)
							{
								goto IL_034d;
							}
						}
					}
					SSEventsManagerController instance3 = SSEventsManagerController.instance;
					IEventManager activeEventManager = instance3.GetActiveEventManager();
					if (activeEventManager != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj3 = default;
						object obj2 = obj3 - 3;
						if ((nint)obj3 == 3 || ((nint)obj2 != 1 && (nint)obj2 != 2 && (nint)obj2 != 3 && (nint)obj2 == 4))
						{
							_ = 0;
							object obj4 = playerInfo + 11;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
							object obj5 = default;
							bool flag3 = (nint)obj5 == (nint)characterType;
							result = true;
							if (flag3)
							{
								goto IL_034d;
							}
						}
					}
					DateTime t = playerInfo.CharacterStartAvailabilityDate(characterType);
					DateTime t2 = playerInfo.CharacterExpirationDate(characterType);
					DateTime now = CDateTime.Now;
					int num = DateTime.Compare(t2, now);
					if (num >= 1)
					{
						DateTime now2 = CDateTime.Now;
						int num2 = DateTime.Compare(t, now2);
						bool flag4 = num2 < 0;
						result = true;
						if (flag4)
						{
							goto IL_034d;
						}
					}
					result = false;
				}
			}
		}
		goto IL_034d;
		IL_034d:
		return result;
	}

	public unsafe TimeSpan CharacterExpirationTimespan(Characters.CharacterType characterType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Ref, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0251: Expected VT, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		object obj = default;
		PlayerInfo playerInfo = (PlayerInfo)(obj - 32);
		playerInfo._highScore = (int)characterType;
		playerInfo._xoredAmountOfKeys = 0;
		Enum obj2 = (Enum)(playerInfo + 8);
		_ = -1;
		obj2 = (Enum)(object)typeof(Characters.CharacterType);
		_ = playerInfo._highScore;
		string text = obj2.ToString();
		string key = "character_expiretime_" + text;
		DateTime now = CDateTime.Now;
		OnlineSettings instance = OnlineSettings.instance;
		DateTime dateTime;
		if (!instance.HasValue(key))
		{
			Characters.Model model = Characters.characterData.get_Item((Characters.CharacterType)playerInfo._highScore);
			object obj3;
			if (model.defaultExpirationDate != DateTime.MinValue)
			{
				Characters.Model model2 = Characters.characterData.get_Item((Characters.CharacterType)playerInfo._highScore);
				obj3 = model2 + 48;
			}
			else
			{
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v75 (Il2CppClass<System.DateTime>)+5C]");
				obj3 = (nint)0 + (nint)16;
			}
			dateTime = (DateTime)obj3;
		}
		else
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			bool flag = instance2.TryGetValue(key, out *(string*)(playerInfo + 24));
			bool flag2 = !flag;
			dateTime = now;
			if (!flag2)
			{
				if ((string)playerInfo._xoredAmountOfKeys == "disabled")
				{
					DateTime now2 = CDateTime.Now;
					dateTime = now2;
				}
				else
				{
					DateTime dateTime2 = playerInfo.CharacterExpirationDate((Characters.CharacterType)playerInfo._highScore);
					dateTime = dateTime2;
				}
			}
		}
		if (dateTime == DateTime.MinValue)
		{
			DateTime now3 = CDateTime.Now;
			dateTime = now3;
		}
		DateTime now4 = CDateTime.Now;
		return dateTime - now4;
	}

	private DateTime DefaultExpirationDateForHoverboard(Hoverboards.BoardType bType)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00a4: Expected VT, but got Obj
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		Hoverboards.Board board = Hoverboards.boardData.get_Item(bType);
		object obj;
		if (board.defaultExpirationTime != DateTime.MinValue)
		{
			Hoverboards.Board board2 = Hoverboards.boardData.get_Item(bType);
			obj = board2 + 40;
		}
		else
		{
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<System.DateTime>)+5C]");
			obj = (nint)0 + (nint)16;
		}
		return (DateTime)obj;
	}

	public unsafe DateTime BoardExpirationDate(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Ref, but got Unknown
		//IL_02e5: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 32);
		_ = 0;
		object obj3 = obj + 16;
		_ = 0;
		_ = -1;
		obj = (Enum)(object)typeof(Hoverboards.BoardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1C]");
		_ = 0;
		string text = obj.ToString();
		string key = "hoverboard_expiretime_" + text;
		OnlineSettings instance = OnlineSettings.instance;
		DateTime result;
		if (!instance.HasValue(key))
		{
			Enum obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1C]");
			DateTime dateTime = ((PlayerInfo)(object)obj4).DefaultExpirationDateForHoverboard(Hoverboards.BoardType.normal);
			result = dateTime;
		}
		else
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			bool flag = instance2.TryGetValue(key, out *(string*)(obj + 24));
			bool flag2 = !flag;
			result = DateTime.MinValue;
			if (!flag2)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						DateTime dateTime2 = default;
						result = dateTime2;
						if (flag3)
						{
							goto IL_04e4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						result = dateTime2;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						result = DateTime.MinValue;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					result = DateTime.MinValue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj5 = default;
				object obj6 = default;
				bool flag4 = obj5 != obj6;
				object obj8 = default;
				object obj7 = obj8;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj10 = default;
						object obj9 = obj10;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj11 = default;
							if (obj11 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
								object obj12 = (nint)0 << 2;
								object obj13 = obj3 + obj12;
								obj13 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
								object obj14 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Enum obj15 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1C]");
								DateTime dateTime3 = ((PlayerInfo)(object)obj15).DefaultExpirationDateForHoverboard(Hoverboards.BoardType.normal);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+18]");
								string text2 = "Unable to convert '" + (string)0 + "'.";
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
								object obj16 = -1;
								result = dateTime3;
								goto IL_04e4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj17 = obj10;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							obj7 = obj10;
							if (flag5)
							{
								goto IL_04e9;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					object obj18 = default;
					obj7 = obj18;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						obj7 = obj18;
					}
				}
				goto IL_04e9;
			}
		}
		goto IL_04e4;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_04e4;
		IL_04e4:
		return result;
	}

	public unsafe DateTime BoardStartAvailabilityDate(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Ref, but got Unknown
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0536: Expected VT, but got Obj
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_034b: Expected Obj, but got I
		//IL_0376: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 32);
		_ = 0;
		object obj3 = obj + 16;
		_ = 0;
		_ = -1;
		obj = (Enum)(object)typeof(Hoverboards.BoardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1C]");
		_ = 0;
		string text = obj.ToString();
		string key = "hoverboard_starttime_" + text;
		OnlineSettings instance = OnlineSettings.instance;
		DateTime result;
		if (!instance.HasValue(key))
		{
			Dictionary<Hoverboards.BoardType, Hoverboards.Board> boardData = Hoverboards.boardData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1C]");
			Hoverboards.Board board = boardData.get_Item(Hoverboards.BoardType.normal);
			object obj4;
			if (board.defaultStartDate != DateTime.MinValue)
			{
				Dictionary<Hoverboards.BoardType, Hoverboards.Board> boardData2 = Hoverboards.boardData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1C]");
				Hoverboards.Board board2 = boardData2.get_Item(Hoverboards.BoardType.normal);
				obj4 = board2 + 48;
			}
			else
			{
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v169 (Il2CppClass<System.DateTime>)+5C]");
				obj4 = (nint)0 + (nint)8;
			}
			result = (DateTime)obj4;
			goto IL_0549;
		}
		OnlineSettings instance2 = OnlineSettings.instance;
		if (!instance2.TryGetValue(key, out *(string*)(obj + 24)))
		{
			goto IL_053b;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				DateTime dateTime = default;
				result = dateTime;
				if (flag)
				{
					goto IL_0549;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 != obj6;
		object obj8 = default;
		object obj7 = obj8;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj10 = default;
				object obj9 = obj10;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj11 = default;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
						object obj12 = (nint)0 << 2;
						object obj13 = obj3 + obj12;
						obj13 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+18]");
						string text2 = "Unable to convert '" + (string)0 + "'.";
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10+4]");
						object obj15 = -1;
						goto IL_053b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj16 = obj10;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					obj7 = obj10;
					if (flag3)
					{
						goto IL_054e;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj17 = default;
			obj7 = obj17;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj7 = obj17;
			}
		}
		goto IL_054e;
		IL_0549:
		return result;
		IL_054e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_053b;
		IL_053b:
		result = DateTime.MinValue;
		goto IL_0549;
	}

	public unsafe bool isBoardActive(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Ref, but got Unknown
		//IL_032f: Expected Obj, but got I4
		object obj = default;
		PlayerInfo playerInfo = (PlayerInfo)(obj - 32);
		Hoverboards.BoardType boardType2 = default;
		playerInfo._highScore = (int)boardType2;
		playerInfo._xoredAmountOfKeys = 0;
		_ = 0;
		if (Globals.DEBUG_ALL_BOARDS || Globals.DEBUG_DISPLAY_ALL_BOARDS)
		{
			goto IL_0418;
		}
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType2);
		RuntimePlatform platform = Application.platform;
		bool result;
		if (platform != RuntimePlatform.Android || DeviceUtility.isFlexionDevice || DeviceUtility.isKindleDevice)
		{
			bool flag = Hoverboards.exclusiveAndroidBoards.Contains(boardType2);
			result = false;
			if (flag)
			{
				goto IL_0449;
			}
		}
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.ExpiredLimitedBoard);
		if (activeEventManager != null)
		{
			_ = 0;
			object obj2 = playerInfo + 23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (PlayerInfo)+17]");
			bool flag2 = (nint)0 == 0;
			boardType2 = (Hoverboards.BoardType)playerInfo._highScore;
			if (!flag2)
			{
				object obj3 = default;
				bool flag3 = playerInfo._highScore == (nint)obj3;
				boardType2 = (Hoverboards.BoardType)playerInfo._highScore;
				if (flag3)
				{
					goto IL_0418;
				}
			}
		}
		object obj4 = board.unlockType - 3;
		if (board.unlockType != PurchaseData.UnlockType.WeeklyHunt)
		{
			bool flag4 = (nint)obj4 == 1;
			result = false;
			if (!flag4)
			{
				goto IL_0225;
			}
		}
		else
		{
			bool flag5 = WeeklyHuntManager.IsBoardAwardedInCurrentPeriod(boardType2);
			bool flag6 = !flag5;
			result = false;
			if (!flag6)
			{
				goto IL_0225;
			}
		}
		goto IL_0449;
		IL_0418:
		result = true;
		goto IL_0449;
		IL_0449:
		return result;
		IL_0225:
		bool flag7 = (byte)(~(board.hasOnlineTimeLimit ? 1u : 0u)) != 0;
		result = true;
		if (!flag7)
		{
			Enum obj5 = (Enum)(playerInfo + 8);
			_ = -1;
			obj5 = (Enum)(object)typeof(Hoverboards.BoardType);
			_ = playerInfo._highScore;
			string text = obj5.ToString();
			string key = "hoverboard_expiretime_" + text;
			OnlineSettings instance2 = OnlineSettings.instance;
			if (instance2.HasValue(key))
			{
				OnlineSettings instance3 = OnlineSettings.instance;
				if (instance3.TryGetValue(key, out *(string*)(playerInfo + 24)))
				{
					bool flag8 = (string)playerInfo._xoredAmountOfKeys != "disabled";
					result = false;
					if (!flag8)
					{
						goto IL_0449;
					}
				}
			}
			DateTime t = playerInfo.BoardExpirationDate((Hoverboards.BoardType)playerInfo._highScore);
			DateTime t2 = playerInfo.BoardStartAvailabilityDate((Hoverboards.BoardType)playerInfo._highScore);
			DateTime now = CDateTime.Now;
			int num = DateTime.Compare(t, now);
			if (num >= 1)
			{
				DateTime now2 = CDateTime.Now;
				int num2 = DateTime.Compare(t2, now2);
				bool flag9 = num2 < 0;
				result = true;
				if (flag9)
				{
					goto IL_0449;
				}
			}
			result = false;
		}
		goto IL_0449;
	}

	public unsafe TimeSpan BoardExpirationTimespan(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Ref, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0251: Expected VT, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		object obj = default;
		PlayerInfo playerInfo = (PlayerInfo)(obj - 32);
		playerInfo._highScore = (int)boardType;
		playerInfo._xoredAmountOfKeys = 0;
		Enum obj2 = (Enum)(playerInfo + 8);
		_ = -1;
		obj2 = (Enum)(object)typeof(Hoverboards.BoardType);
		_ = playerInfo._highScore;
		string text = obj2.ToString();
		string key = "hoverboard_expiretime_" + text;
		DateTime now = CDateTime.Now;
		OnlineSettings instance = OnlineSettings.instance;
		DateTime dateTime;
		if (!instance.HasValue(key))
		{
			Hoverboards.Board board = Hoverboards.boardData.get_Item((Hoverboards.BoardType)playerInfo._highScore);
			object obj3;
			if (board.defaultExpirationTime != DateTime.MinValue)
			{
				Hoverboards.Board board2 = Hoverboards.boardData.get_Item((Hoverboards.BoardType)playerInfo._highScore);
				obj3 = board2 + 40;
			}
			else
			{
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v75 (Il2CppClass<System.DateTime>)+5C]");
				obj3 = (nint)0 + (nint)16;
			}
			dateTime = (DateTime)obj3;
		}
		else
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			bool flag = instance2.TryGetValue(key, out *(string*)(playerInfo + 24));
			bool flag2 = !flag;
			dateTime = now;
			if (!flag2)
			{
				if ((string)playerInfo._xoredAmountOfKeys == "disabled")
				{
					DateTime now2 = CDateTime.Now;
					dateTime = now2;
				}
				else
				{
					DateTime dateTime2 = playerInfo.BoardExpirationDate((Hoverboards.BoardType)playerInfo._highScore);
					dateTime = dateTime2;
				}
			}
		}
		if (dateTime == DateTime.MinValue)
		{
			DateTime now3 = CDateTime.Now;
			dateTime = now3;
		}
		DateTime now4 = CDateTime.Now;
		return dateTime - now4;
	}

	public void UnlockHoverboard(Hoverboards.BoardType boardType)
	{
		//IL_00a2: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		if (OnBoardUnlocked != null)
		{
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v9 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ S3_v10+4] (should have been resolved before IL gen)");
		}
		_dirty = true;
	}

	public void LockHoverboard(Hoverboards.BoardType boardType)
	{
		//IL_0057: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S5_v5+4] (should have been resolved before IL gen)");
			_dirty = true;
		}
	}

	public bool IsHoverboardUnlocked(Hoverboards.BoardType boardType)
	{
		//IL_0063: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		bool result = true;
		if (!Globals.DEBUG_ALL_BOARDS)
		{
			Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
			bool flag = board.unlockType == PurchaseData.UnlockType.AlwaysUnlocked;
			result = true;
			if (!flag)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				bool flag2 = obj4 == null;
				result = false;
				if (!flag2)
				{
					bool flag3 = _hoverboardUnlockStatus.get_Item(boardType);
					result = flag3;
				}
			}
		}
		return result;
	}

	public bool HasHoverboardBeenSeen(Hoverboards.BoardType boardType)
	{
		//IL_0027: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		if (~(board.isNewInThisUpdate ? 1u : 0u) != 0)
		{
			return true;
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _hasHoverboardBeenSeen.get_Item(boardType);
		}
		return false;
	}

	public void MarkHoverboardAsSeen(Hoverboards.BoardType boardType)
	{
		//IL_0077: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		_dirty = true;
	}

	public int IncrementUnreportedGames()
	{
		int num = ++_unreportedGames;
		bool flag = num == 1;
		bool flag2 = !flag;
		int result = num;
		if (!flag2)
		{
			DateTime now = CDateTime.Now;
			_unreportedGamesTimestamp = now;
			result = _unreportedGames;
		}
		_dirty = true;
		return result;
	}

	public DateTime GetFirstUnreportedGameTimestamp()
	{
		return _unreportedGamesTimestamp;
	}

	public void ClearUnreportedGames()
	{
		_dirty = true;
		_unreportedGames = 0;
	}

	public int NumberOfUnlockedTrophyForFirstAchievement()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		object obj = 0;
		int num = default;
		while ((nint)obj < 8)
		{
			num++;
			object obj2 = obj + (object)_unlockedTrophies;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3+10]");
			if ((nint)0 == 0)
			{
				num = num;
			}
			object obj3 = obj + 1;
			obj = obj3;
		}
		return num;
	}

	public void UnlockTrophy(Trophies.Trophy trophy)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		object obj = trophy + _unlockedTrophies;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+10]");
		if ((nint)0 == 0)
		{
			object obj2 = trophy + _unlockedTrophies;
			_ = 1;
			_dirty = true;
		}
	}

	private Stat StatForTrophyType(Trophies.Trophy trophy)
	{
		if (trophy <= Trophies.Trophy.tapeBlack)
		{
			return (Stat)(trophy + 1);
		}
		return Stat.NotSet;
	}

	public void OldTrophySpawned(Trophies.Trophy trophy)
	{
		//IL_0054: Expected Obj, but got I4
		Statistics statistics = _stats;
		Stat stat = (Stat)(trophy + 1);
		if (trophy > Trophies.Trophy.tapeBlack)
		{
			stat = Stat.NotSet;
		}
		object obj = (int)stat << 2;
		object obj2 = (object)statistics._values + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v5+10]");
		int value = (int)((nint)0 + (nint)1);
		statistics.set_Item(stat, value);
	}

	public bool ShouldSpawnTrophy(Trophies.Trophy trophy)
	{
		AwardsManager instance = AwardsManager.instance;
		Stat stat = (Stat)((trophy <= Trophies.Trophy.tapeBlack) ? (trophy + 1) : Trophies.Trophy.diamond);
		return instance.ShouldSpawnOldTrophyForStat(stat);
	}

	public unsafe int GetDailyWordDaysInARow(out bool mostRecentIsToday)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00c1: Expected Ref, but got VT
		//IL_0023: Expected Obj, but got I4
		DateTime dateTime = (DateTime)(this + 320);
		int dayOfYear = ((DateTime*)dateTime)->DayOfYear;
		ref bool reference;
		if (dayOfYear == _dailyWordLastPayoutDayOfYear)
		{
			reference = ref *(bool*)1;
			return _dailyWordInRow;
		}
		object obj = dayOfYear - 1;
		if (_dailyWordLastPayoutDayOfYear == (nint)obj || (dayOfYear == 1 && _dailyWordLastPayoutDayOfYear >= 365))
		{
			reference = ref *(bool*)null;
			return _dailyWordInRow;
		}
		reference = ref *(bool*)null;
		return 0;
	}

	public unsafe void CheckIfWeShouldRemoveProgressForDailyQuestInRow()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		PlayerInfo instance = Instance;
		if (instance.GetDailyWordDaysInARow(out *(bool*)(obj + 15)) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
			if ((nint)0 == 0)
			{
				MissionsManager instance2 = MissionsManager.Instance;
				instance2.RemoveProgressForThis(MissionTarget.DailyQuestInRow);
			}
		}
	}

	public unsafe void InitDailyWord(DailyWord.DailyWordReward[] dailyWordRewards)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Ref, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected VT, but got Unknown
		//IL_015a: Expected Ref, but got VT
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected VT, but got Unknown
		//IL_0191: Expected Ref, but got VT
		//IL_0105: Expected VT, but got I4
		//IL_010e: Expected VT, but got Obj
		//IL_0121: Expected Obj, but got VT
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected VT, but got Unknown
		//IL_01b2: Expected Ref, but got VT
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		int dailyWordDaysInARow = GetDailyWordDaysInARow(out *(bool*)(obj + 31));
		PlayerInfo instance = Instance;
		TimeSpan timeSpan = instance.dailyWordTimeLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		double num = 0.0 * 1E-07;
		bool flag = !(num > 0.0);
		bool flag2 = !flag;
		string value = _dailyWord;
		if (!flag2)
		{
			bool flag3 = dailyWordDaysInARow >= dailyWordRewards.Length;
			value = _dailyWord;
			if (!flag3)
			{
				int num2 = dailyWordDaysInARow << 4;
				object obj3 = dailyWordRewards + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v62+18]");
				value = (string)0;
			}
		}
		if (!_dailyWord.Equals(value))
		{
			_dailyWord = value;
			_dailyWordPayedOut = false;
			_dirty = true;
			_dailyWordUnlockedMask = (IntMask)0;
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((PickupManager)val).SetPickerState(PickerType.LetterHuntDaily, PickerEnabledState.Enabled);
			DailyLetterPickupManager instance2 = DailyLetterPickupManager.Instance;
			instance2.UpdateLetter();
		}
		DateTime dateTime = (DateTime)(this + 400);
		DateTime dateTime2 = ((DateTime*)dateTime)->AddSeconds(86400.0);
		DateTime utcNow = CDateTime.UtcNow;
		DateTime dateTime3 = (DateTime)(obj + 8);
		DateTime dailyWordExpireDeviceTime = ((DateTime*)dateTime3)->AddSeconds(86400.0);
		DateTime dateTime4 = (DateTime)(this + 320);
		if (!((DateTime*)dateTime4)->Equals(dateTime2))
		{
			_dailyWordExpireDeviceTime = dailyWordExpireDeviceTime;
			_dailyWordExpireTime = dateTime2;
			_dirty = true;
			DateTime utcNow2 = CDateTime.UtcNow;
			_lastKnownServerTime = utcNow2;
		}
	}

	public bool IsActiveDailyLetterEvent()
	{
		char newDailyLetter = GetNewDailyLetter();
		return newDailyLetter != '\0';
	}

	public bool HasDailyWordTimeLeft()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (IsActiveDailyLetterEvent())
		{
			TimeSpan timeSpan = dailyWordTimeLeft;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = 0.0 * 1E-07;
			return num > 0.0;
		}
		bool result = default;
		return result;
	}

	public unsafe void PickedupLetter(char letter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Expected I4, but got VT
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Ref, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected VT, but got Unknown
		//IL_0168: Expected Ref, but got VT
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
		//IL_0095: Expected VT, but got I4
		//IL_009f: Expected I4, but got Obj
		//IL_0413: Expected I4, but got Obj
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		int num = default;
		while (true)
		{
			string text = _dailyWord;
			if (num >= text._stringLength)
			{
				break;
			}
			char c = text.get_Chars(num);
			if (c == letter)
			{
				int num2 = _dailyWordUnlockedMask >> num;
				if ((num2 & 1) == 0)
				{
					int num3 = 1 << num;
					int num4 = _dailyWordUnlockedMask | num3;
					_dailyWordUnlockedMask = (IntMask)num4;
					int num5 = (int)OnPickedUpLetter;
					if (OnPickedUpLetter != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S0_v112 (System.Int32)+C] (should have been resolved before IL gen)");
					}
					_dirty = true;
					num = (int)OnPickedUpLetter;
					break;
				}
			}
			int num6 = num + 1;
			num = num6;
		}
		if (!isDailyWordComplete() || _dailyWordPayedOut)
		{
			return;
		}
		int dailyWordDaysInARow = GetDailyWordDaysInARow(out *(bool*)(obj + 31));
		int num7 = dailyWordDaysInARow + 1;
		_dailyWordInRow = num7;
		DateTime dateTime = (DateTime)(this + 320);
		int dayOfYear = ((DateTime*)dateTime)->DayOfYear;
		_dailyWordLastPayoutDayOfYear = dayOfYear;
		Action onDailyWordInRowChanged = OnDailyWordInRowChanged;
		if (OnDailyWordInRowChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v148.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		MissionsManager instance = MissionsManager.Instance;
		instance.PlayerDidThis(MissionTarget.DailyQuests);
		MissionsManager instance2 = MissionsManager.Instance;
		instance2.PlayerDidThis(MissionTarget.DailyQuestInRow);
		int dayIndex = _dailyWordInRow - 1;
		DailyWord.DailyWordReward rewardForDay = DailyWord.GetRewardForDay(dayIndex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)0 == 1)
			{
				CelebrationRewardOrigin origin = CelebrationRewardOrigin.SuperMysteryBox;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				if ((nint)0 == 0)
				{
					origin = CelebrationRewardOrigin.MysteryBox;
				}
				RewardManager.AddRewardToUnlock(origin);
				UIScreenController instance3 = UIScreenController.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				UIScreenController.SlideIn slideIn = default;
				slideIn._002Ector(UIScreenController.SlideInType.LettersCompleteMysteryBox, MysteryBox.Type.Normal);
				instance3.QueueSlideIn(slideIn);
				PlayerInfo instance4 = Instance;
				instance4._willShowSMBAfterDailyChallenge = true;
			}
			else
			{
				Enum obj3 = (Enum)(obj + 8);
				_ = -1;
				obj3 = (Enum)(object)typeof(DailyWord.DailyWordRewardType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				string text2 = obj3.ToString();
				string text3 = "PlayerInfo Unhandled DailyWordRewardType: " + text2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			if ((nint)0 >= (nint)1)
			{
				int num8 = amountOfCoins;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				int num9 = (int)((nint)num8 + (nint)0);
				amountOfCoins = num9;
				UIScreenController instance5 = UIScreenController.Instance;
				UISlideInMissionSetHelper coinReward = instance5.coinReward;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				coinReward.NewCoinAmount(0);
				UIScreenController instance6 = UIScreenController.Instance;
				UIScreenController.SlideIn slideIn2 = default;
				slideIn2._002Ector(UIScreenController.SlideInType.LettersCompleteCoins);
				instance6.QueueSlideIn(slideIn2);
			}
		}
		_dirty = true;
		_dailyWordPayedOut = true;
	}

	public char GetNewDailyLetter()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0026: Expected I4, but got Obj
		object obj = this + 316;
		int num = 0;
		while (true)
		{
			string text = _dailyWord;
			if (text._stringLength <= num)
			{
				break;
			}
			int num2 = obj >> num;
			if ((num2 & 1) != 0)
			{
				int num3 = num + 1;
				num = num3;
				continue;
			}
			return _dailyWord.get_Chars(num);
		}
		return '\0';
	}

	public bool isDailyWordComplete()
	{
		//IL_004e: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_0096: Invalid comparison between VT and Obj
		string text = _dailyWord;
		object obj;
		if (_dailyWord != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00a1;
			}
		}
		obj = 1;
		goto IL_00a1;
		IL_00a1:
		if (obj != null)
		{
			return false;
		}
		string text2 = _dailyWord;
		int num = 1 << text2._stringLength;
		object obj2 = num - 1;
		return _dailyWordUnlockedMask == (IntMask)obj2;
	}

	public bool ShouldShowStickersForCharacterThemes()
	{
		bool flag = (byte)(~(_hasShownHoverboardPopup ? 1u : 0u)) != 0;
		bool result = false;
		if (!flag)
		{
			bool flag2 = (byte)(~(_hasShownFacebookPopup ? 1u : 0u)) != 0;
			result = false;
			if (!flag2)
			{
				bool flag3 = _hasShownMission1Popup;
				result = flag3;
			}
		}
		return result;
	}

	public bool ShouldShowStickersForHoverboards()
	{
		bool result = true;
		if (!_hasShownHoverboardPopup)
		{
			result = true;
			if (!_hasShownCollectPopup)
			{
				result = true;
				if (!_hasShownFacebookPopup)
				{
					bool flag = _hasShownMission1Popup;
					result = flag;
				}
			}
		}
		return result;
	}

	public void BreadCrumbShownOnFrontPage()
	{
		int num = _numberOfBreadCrumbsShownOnFrontPage + 1;
		_dirty = true;
		_numberOfBreadCrumbsShownOnFrontPage = num;
	}

	public void RunCompleted()
	{
		//IL_0204: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		_dirty = true;
		int numberOfRunsSinceLastGuideline = _numberOfRunsSinceLastGuideline + 1;
		_numberOfRunsSinceLastGuideline = numberOfRunsSinceLastGuideline;
		if (++_numberOfRuns >= 4 && !_isSaveMePopupEnabled)
		{
			_dirty = true;
			_isSaveMePopupEnabled = true;
		}
		if (_numberOfRunsSinceLastGuideline < 5)
		{
			return;
		}
		_numberOfRunsSinceLastGuideline = 0;
		if (~(_hasShownHoverboardPopup ? 1u : 0u) == 0)
		{
			goto IL_03ad;
		}
		if (_shouldShowHoverboardPopup)
		{
			return;
		}
		Achievements instance = Achievements.Instance;
		if (instance.GetNumberOfHoverboardsUsed() != 0)
		{
			int upgradeAmount = _instance.GetUpgradeAmount(PowerupType.hoverboard);
			Achievements instance2 = Achievements.Instance;
			int numberOfHoverboardsUsed = instance2.GetNumberOfHoverboardsUsed();
			object obj = 3 - numberOfHoverboardsUsed;
			if (upgradeAmount != (nint)obj)
			{
				_hasShownHoverboardPopup = true;
				_dirty = true;
				goto IL_03ad;
			}
		}
		_shouldShowCollectPopup = false;
		_shouldShowFacebookPopup = false;
		_shouldShowHoverboardPopup = true;
		_shouldShowMission2Popup = false;
		_shouldShowMission1Popup = false;
		goto IL_03be;
		IL_0328:
		_dummyFriendShouldShow = false;
		_hasShownCollectPopup = true;
		goto IL_03be;
		IL_03ad:
		if (!_hasShownFacebookPopup)
		{
			SocialManager instance3 = SocialManager.instance;
			if (!instance3.facebookIsLoggedIn)
			{
				PlayerInfo instance4 = _instance;
				if (!instance4._hasPayedOutFacebook)
				{
					_shouldShowFacebookPopup = true;
					goto IL_03be;
				}
			}
		}
		if (~(_hasShownMission1Popup ? 1u : 0u) != 0)
		{
			object obj2 = _currentMissionSet + 1;
			if ((nint)obj2 >= 30)
			{
				obj2 = 30;
			}
			if ((nint)obj2 <= 1)
			{
				obj2 = 1;
			}
			if ((nint)obj2 <= 4)
			{
				_shouldShowMission1Popup = true;
				goto IL_03be;
			}
			_hasShownMission1Popup = true;
			_dirty = true;
		}
		if (_hasShownCollectPopup)
		{
			return;
		}
		if (~(_hasCollectedFromFriends ? 1u : 0u) == 0)
		{
			goto IL_0328;
		}
		SocialManager instance5 = SocialManager.instance;
		if (!instance5.facebookIsLoggedIn)
		{
			SocialManager instance6 = SocialManager.instance;
			if (!instance6.gamecenterIsLoggedIn)
			{
				if (~(_hasCollectedFromFriends ? 1u : 0u) == 0)
				{
					goto IL_0328;
				}
				return;
			}
		}
		_shouldShowCollectPopup = true;
		goto IL_03be;
		IL_03be:
		_dirty = true;
	}

	public bool AddTransactionToHistory(string orderId, string itemId)
	{
		//IL_007f: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I
		RuntimePlatform platform = Application.platform;
		bool flag = platform == RuntimePlatform.OSXEditor;
		bool result = true;
		if (!flag)
		{
			RuntimePlatform platform2 = Application.platform;
			bool flag2 = platform2 == RuntimePlatform.WindowsEditor;
			result = true;
			if (!flag2)
			{
				RuntimePlatform platform3 = Application.platform;
				bool flag3 = platform3 == RuntimePlatform.MetroPlayerARM;
				result = true;
				if (!flag3)
				{
					nint num = 0;
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S3_v5+4] (should have been resolved before IL gen)");
					object obj3 = default;
					object obj2 = obj3 ^ -1;
					object obj4 = obj2 >> 31;
					result = false;
					if (obj4 == null)
					{
						nint num3 = 0;
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S5_v5+4] (should have been resolved before IL gen)");
						_dirty = true;
						result = true;
					}
				}
			}
		}
		return result;
	}

	public bool RemoveTransactionFromHistory(string orderId)
	{
		//IL_0044: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_006a: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		bool flag = (byte)(obj2 >> 31) != 0;
		if (flag)
		{
			bool flag2 = _inappHistory.Remove(orderId);
			_dirty = true;
		}
		return flag;
	}

	public bool HasTransactionHistoryItemId(string itemId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		bool flag2 = default;
		bool result;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		bool flag5 = default;
		bool flag7 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = !flag2;
				result = flag2;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj6 != null)
								{
									result = flag2;
									break;
								}
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj7 == obj8;
			bool flag4 = !flag3;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				result = false;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag7;
			}
			_ = 0;
			object obj9 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj10 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8F8");
		return result;
	}

	public bool IsTransactionInHistory(string orderId)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public void PrintAllInappHistory()
	{
		string text = Globals.convertStringStringDictionaryToString(_inappHistory);
	}

	public int GetUpgradeTierSum()
	{
		//IL_0030: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		int currentTier = GetCurrentTier(PowerupType.jetpack);
		int currentTier2 = GetCurrentTier(PowerupType.doubleMultiplier);
		object obj = currentTier + currentTier2;
		int currentTier3 = GetCurrentTier(PowerupType.coinmagnet);
		object obj2 = obj + currentTier3;
		int currentTier4 = GetCurrentTier(PowerupType.supersneakers);
		return obj2 + currentTier4;
	}

	public bool IsUpgradeStackable(PowerupType type)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public bool IsUpgradeTiered(PowerupType type)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public int GetUpgradeAmount(PowerupType type)
	{
		return _upgradeAmounts.get_Item(type);
	}

	public int GetCurrentTier(PowerupType type)
	{
		//IL_0047: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _upgradeTiers.get_Item(type);
		}
		return 0;
	}

	public float GetPowerupDuration(PowerupType type)
	{
		//IL_00d4: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00a5: Expected F4, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, Upgrade>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			if (type == PowerupType.hoverboard)
			{
				Hoverboard instance = Hoverboard.Instance;
				if (~(instance._isARewardFromMysteryPowerup ? 1u : 0u) == 0)
				{
					return 15f;
				}
			}
			Upgrade upgrade = Upgrades.upgrades.get_Item(type);
			int currentTier = GetCurrentTier(type);
			int num3 = currentTier << 2;
			object obj5 = upgrade.durations + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v28+10]");
			return 0f;
		}
		return 0f;
	}

	public float GetPowerupSpeed(PowerupType type)
	{
		//IL_0058: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, Upgrade>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			Upgrade upgrade = Upgrades.upgrades.get_Item(type);
			return upgrade.speed;
		}
		return 0f;
	}

	public float GetPowerupLandSpeed(PowerupType type)
	{
		//IL_0058: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, Upgrade>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			Upgrade upgrade = Upgrades.upgrades.get_Item(type);
			return upgrade.landSpeed;
		}
		return 0f;
	}

	public void IncreasePowerupTier(PowerupType type)
	{
		//IL_0075: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			int num3 = _upgradeTiers.get_Item(type);
			object obj5 = num3 + 1;
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S5_v4+4] (should have been resolved before IL gen)");
			_dirty = true;
		}
	}

	public void ResetPowerupTier(PowerupType type)
	{
		//IL_0057: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S5_v5+4] (should have been resolved before IL gen)");
			_dirty = true;
		}
	}

	public void UseUpgrade(PowerupType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 != null)
		{
			int num3 = _upgradeAmounts.get_Item(type);
			if (num3 >= 1)
			{
				int num4 = _upgradeAmounts.get_Item(type);
				object obj7 = num4 - 1;
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S5_v5+4] (should have been resolved before IL gen)");
				_dirty = true;
				Action<PowerupType, int> action = onPowerupAmountChanged;
				if (onPowerupAmountChanged != null)
				{
					int num7 = _upgradeAmounts.get_Item(type);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S0_v39 (System.Action`2<PowerupType, System.Int32>)+C] (should have been resolved before IL gen)");
				}
				return;
			}
		}
		_ = -1;
		obj = (Enum)(object)typeof(PowerupType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		string text2 = "You are using more upgrades than you have available for the UpgradeType: " + text + ". Or the type of upgrade is not available.";
	}

	public void IncreaseUpgradeAmount(PowerupType type, int amount = 1)
	{
		//IL_00b9: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			int num3 = _upgradeAmounts.get_Item(type);
			object obj5 = num3 + amount;
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S5_v5+4] (should have been resolved before IL gen)");
			_dirty = true;
			Action<PowerupType, int> action = onPowerupAmountChanged;
			if (onPowerupAmountChanged != null)
			{
				int num6 = _upgradeAmounts.get_Item(type);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S0_v20 (System.Action`2<PowerupType, System.Int32>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe void HUNT_DEFAULT()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected VT, but got Unknown
		//IL_004c: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string text = PlayerPrefs.GetString("HUNT_DEFAULT");
		if (text != "done")
		{
			PlayerPrefs.SetString("HUNT_DEFAULT", "done");
			DateTime now = DateTime.Now;
			DateTime dateTime = (DateTime)(obj + 8);
			string value = ((DateTime*)dateTime)->ToString();
			PlayerPrefs.SetString("HUNT_TIME", value);
		}
		string huntDefaultTime = PlayerPrefs.GetString("HUNT_TIME");
		HuntDefaultTime = huntDefaultTime;
		DateTime dateTime2 = DateTime.Parse(HuntDefaultTime);
		WeeklyHuntManager.UpdateHuntData(dateTime2);
	}

	public void UpdateLastPurchasedBundle()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (_lastPurchasedBundle != InAppData.BundleTier.None)
		{
			if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier1)
			{
				if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier2)
				{
					if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier3)
					{
						if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier4)
						{
							if (_lastPurchasedBundle == InAppData.BundleTier.BundleTier5)
							{
								_ = 5;
								_ = -1;
								obj = (Enum)(object)typeof(InAppData.BundleTier);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
								_ = 0;
								string text = obj.ToString();
								string text2 = "Trying to update last purchased bundle when there are no more tiers. Last purchased bundle is " + text;
							}
							else
							{
								_ = _lastPurchasedBundle;
								_ = -1;
								obj = (Enum)(object)typeof(InAppData.BundleTier);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
								_ = 0;
								string text3 = obj.ToString();
								string text4 = "No know bundle tier: " + text3;
							}
						}
						else if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier5)
						{
							_dirty = true;
							_lastPurchasedBundle = InAppData.BundleTier.BundleTier5;
						}
					}
					else if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier4)
					{
						_dirty = true;
						_lastPurchasedBundle = InAppData.BundleTier.BundleTier4;
					}
				}
				else if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier3)
				{
					_dirty = true;
					_lastPurchasedBundle = InAppData.BundleTier.BundleTier3;
				}
			}
			else if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier2)
			{
				_dirty = true;
				_lastPurchasedBundle = InAppData.BundleTier.BundleTier2;
			}
		}
		else if (_lastPurchasedBundle != InAppData.BundleTier.BundleTier1)
		{
			_dirty = true;
			_lastPurchasedBundle = InAppData.BundleTier.BundleTier1;
		}
	}

	private static string GetSavePath()
	{
		string userDataPath = DeviceUtility.GetUserDataPath();
		return userDataPath + "/playerdata";
	}

	private unsafe static bool TryGetLoadPaths(out string path)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected I4, but got Unknown
		string userDataPath = DeviceUtility.GetUserDataPath();
		object obj;
		if (userDataPath != null)
		{
			obj = 0;
			if (userDataPath._stringLength != 0)
			{
				goto IL_0082;
			}
		}
		obj = 1;
		goto IL_0082;
		IL_0082:
		if (obj != null)
		{
			ref string reference = ref *(string*)null;
		}
		else
		{
			string text = userDataPath + "/playerdata";
			ref string reference = ref *(string*)text;
		}
		return (byte)(obj ^ 1) != 0;
	}

	public void SaveIfDirty()
	{
		if (!_dirty)
		{
			Statistics statistics = _stats;
			if (!statistics.dirty)
			{
				HoverboardCustomizationData hoverboardCustomizationData = _hoverboardCustomizationData;
				if (!hoverboardCustomizationData._dirty && ~(CollectCoinsDummyData._dirty ? 1u : 0u) != 0)
				{
					return;
				}
			}
		}
		Save();
	}

	private void Save()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_37b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ba: Expected Obj, but got Unknown
		//IL_3709: Expected Obj, but got I
		//IL_35c7: Expected Obj, but got I
		//IL_35f2: Expected Obj, but got I
		//IL_3617: Expected Obj, but got I
		//IL_362d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3632: Expected Obj, but got Unknown
		//IL_36a8: Expected Obj, but got I
		//IL_1730: Unknown result type (might be due to invalid IL or missing references)
		//IL_1735: Expected Obj, but got Unknown
		//IL_28cc: Expected Obj, but got I4
		//IL_28b0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj5;
		object obj6;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						if ((nint)0 != 1)
																						{
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 != 1)
																							{
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																								if ((nint)0 != 1)
																								{
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																									if ((nint)0 != 1)
																									{
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																										if ((nint)0 != 1)
																										{
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																											if ((nint)0 != 1)
																											{
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																												if ((nint)0 != 1)
																												{
																													_ = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																													_ = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																													if ((nint)0 != 1)
																													{
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																														if ((nint)0 != 1)
																														{
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																															if ((nint)0 != 1)
																															{
																																_ = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																_ = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																if ((nint)0 != 1)
																																{
																																	_ = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																	_ = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																	if ((nint)0 != 1)
																																	{
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																		if ((nint)0 != 1)
																																		{
																																			_ = 0;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																			_ = 0;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																			if ((nint)0 != 1)
																																			{
																																				_ = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																				_ = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																				if ((nint)0 != 1)
																																				{
																																					_ = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																					_ = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																					if ((nint)0 != 1)
																																					{
																																						_ = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																						_ = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																						if ((nint)0 != 1)
																																						{
																																							_ = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																							_ = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																							if ((nint)0 != 1)
																																							{
																																								_ = 0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																								_ = 0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																								if ((nint)0 != 1)
																																								{
																																									_ = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																									_ = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																									if ((nint)0 != 1)
																																									{
																																										_ = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																										_ = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																										if ((nint)0 != 1)
																																										{
																																											_ = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																											_ = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																											if ((nint)0 != 1)
																																											{
																																												_ = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																												_ = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																												if ((nint)0 != 1)
																																												{
																																													_ = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																													_ = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																													if ((nint)0 != 1)
																																													{
																																														_ = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																														_ = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																														if ((nint)0 != 1)
																																														{
																																															_ = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																															_ = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																															if ((nint)0 != 1)
																																															{
																																																_ = 0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																_ = 0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																if ((nint)0 != 1)
																																																{
																																																	_ = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																	_ = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																	if ((nint)0 != 1)
																																																	{
																																																		_ = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																		_ = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																		if ((nint)0 != 1)
																																																		{
																																																			_ = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																			_ = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																			if ((nint)0 != 1)
																																																			{
																																																				_ = 0;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																				_ = 0;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																				if ((nint)0 != 1)
																																																				{
																																																					_ = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																					_ = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																					if ((nint)0 != 1)
																																																					{
																																																						_ = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																						_ = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																						if ((nint)0 != 1)
																																																						{
																																																							_ = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																							_ = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																							if ((nint)0 != 1)
																																																							{
																																																								_ = 0;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																								_ = 0;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																								if ((nint)0 != 1)
																																																								{
																																																									_ = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																									_ = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																									if ((nint)0 != 1)
																																																									{
																																																										_ = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																										_ = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																										if ((nint)0 != 1)
																																																										{
																																																											_ = 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																											_ = 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																											if ((nint)0 != 1)
																																																											{
																																																												_ = 0;
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																												_ = 0;
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																												if ((nint)0 != 1)
																																																												{
																																																													_ = 0;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																													_ = 0;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																													if ((nint)0 != 1)
																																																													{
																																																														_ = 0;
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																														_ = 0;
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																														if ((nint)0 != 1)
																																																														{
																																																															_ = 0;
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																															_ = 0;
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																															if ((nint)0 != 1)
																																																															{
																																																																_ = 0;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																_ = 0;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																if ((nint)0 != 1)
																																																																{
																																																																	_ = 0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																	_ = 0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																	if ((nint)0 != 1)
																																																																	{
																																																																		_ = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																		_ = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																		if ((nint)0 != 1)
																																																																		{
																																																																			_ = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																			_ = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																			if ((nint)0 != 1)
																																																																			{
																																																																				_ = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																				_ = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																				if ((nint)0 != 1)
																																																																				{
																																																																					if (_currentMissionSet >= 0)
																																																																					{
																																																																						_ = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																						_ = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																						if ((nint)0 == 1)
																																																																						{
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																							goto IL_34c7;
																																																																						}
																																																																					}
																																																																					_ = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																					_ = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																					if ((nint)0 != 1)
																																																																					{
																																																																						_ = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																						_ = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																						if ((nint)0 != 1)
																																																																						{
																																																																							_ = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																							_ = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																							if ((nint)0 != 1)
																																																																							{
																																																																								_ = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																								_ = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																								if ((nint)0 != 1)
																																																																								{
																																																																									_ = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																									_ = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																									if ((nint)0 != 1)
																																																																									{
																																																																										_ = 0;
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																										_ = 0;
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																										if ((nint)0 != 1)
																																																																										{
																																																																											_ = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																																																																											_ = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																											if ((nint)0 != 1)
																																																																											{
																																																																												_ = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																												_ = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																												if ((nint)0 != 1)
																																																																												{
																																																																													_ = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																													_ = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																													if ((nint)0 != 1)
																																																																													{
																																																																														_ = 0;
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																														_ = 0;
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																														if ((nint)0 != 1)
																																																																														{
																																																																															_ = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																															_ = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																															if ((nint)0 != 1)
																																																																															{
																																																																																_ = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																_ = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																if ((nint)0 != 1)
																																																																																{
																																																																																	_ = 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																	_ = 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																	if ((nint)0 != 1)
																																																																																	{
																																																																																		_ = 0;
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																		_ = 0;
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																		if ((nint)0 != 1)
																																																																																		{
																																																																																			_ = 0;
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																			_ = 0;
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																			if ((nint)0 != 1)
																																																																																			{
																																																																																				_ = 0;
																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																																																																																				_ = 0;
																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																				if ((nint)0 != 1)
																																																																																				{
																																																																																					_ = 0;
																																																																																					object obj4 = this + 280;
																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
																																																																																					_ = 0;
																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																					if ((nint)0 != 1)
																																																																																					{
																																																																																						_ = 0;
																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																						_ = 0;
																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																						if ((nint)0 != 1)
																																																																																						{
																																																																																							_ = 0;
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																							_ = 0;
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																							if ((nint)0 != 1)
																																																																																							{
																																																																																								_ = 0;
																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																								_ = 0;
																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																								if ((nint)0 != 1)
																																																																																								{
																																																																																									_ = 0;
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																									_ = 0;
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																									if ((nint)0 != 1)
																																																																																									{
																																																																																										_ = 0;
																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																										_ = 0;
																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																										if ((nint)0 != 1)
																																																																																										{
																																																																																											_ = 0;
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																											_ = 0;
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																											if ((nint)0 != 1)
																																																																																											{
																																																																																												_ = 0;
																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																												_ = 0;
																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																												if ((nint)0 != 1)
																																																																																												{
																																																																																													_ = 0;
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																													_ = 0;
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																													if ((nint)0 != 1)
																																																																																													{
																																																																																														_ = 0;
																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																														_ = 0;
																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																														if ((nint)0 != 1)
																																																																																														{
																																																																																															_ = 0;
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																															_ = 0;
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																															if ((nint)0 != 1)
																																																																																															{
																																																																																																_ = 0;
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																_ = 0;
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																if ((nint)0 != 1)
																																																																																																{
																																																																																																	_ = 0;
																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																	_ = 0;
																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																	if ((nint)0 != 1)
																																																																																																	{
																																																																																																		_ = 0;
																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																		_ = 0;
																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																		if ((nint)0 != 1)
																																																																																																		{
																																																																																																			_ = 0;
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																			_ = 0;
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																			if ((nint)0 != 1)
																																																																																																			{
																																																																																																				_ = 0;
																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																				_ = 0;
																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																				if ((nint)0 != 1)
																																																																																																				{
																																																																																																					_ = 0;
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																					_ = 0;
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																					if ((nint)0 != 1)
																																																																																																					{
																																																																																																						_ = 0;
																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																						_ = 0;
																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																						if ((nint)0 != 1)
																																																																																																						{
																																																																																																							_ = 0;
																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																							_ = 0;
																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																							if ((nint)0 != 1)
																																																																																																							{
																																																																																																								_ = 0;
																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																								_ = 0;
																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																								if ((nint)0 != 1)
																																																																																																								{
																																																																																																									_ = 0;
																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																									_ = 0;
																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																									if ((nint)0 != 1)
																																																																																																									{
																																																																																																										_ = 0;
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																										_ = 0;
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																										if ((nint)0 != 1)
																																																																																																										{
																																																																																																											_ = 0;
																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																											_ = 0;
																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																											if ((nint)0 != 1)
																																																																																																											{
																																																																																																												_ = 0;
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																																																																																																												_ = 0;
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																												if ((nint)0 != 1)
																																																																																																												{
																																																																																																													_ = 0;
																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																													_ = 0;
																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																													if ((nint)0 != 1)
																																																																																																													{
																																																																																																														_ = 0;
																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																														_ = 0;
																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																														if ((nint)0 != 1)
																																																																																																														{
																																																																																																															_ = 0;
																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																															_ = 0;
																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																															if ((nint)0 != 1)
																																																																																																															{
																																																																																																																_ = 0;
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																_ = 0;
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																if ((nint)0 != 1)
																																																																																																																{
																																																																																																																	_ = 0;
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																	_ = 0;
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																	if ((nint)0 != 1)
																																																																																																																	{
																																																																																																																		_ = 0;
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																		_ = 0;
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																		if ((nint)0 != 1)
																																																																																																																		{
																																																																																																																			_ = 0;
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																			_ = 0;
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																			if ((nint)0 != 1)
																																																																																																																			{
																																																																																																																				_ = 0;
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																				_ = 0;
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																				if ((nint)0 != 1)
																																																																																																																				{
																																																																																																																					_ = 0;
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																					_ = 0;
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																					if ((nint)0 != 1)
																																																																																																																					{
																																																																																																																						_ = 0;
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																						_ = 0;
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																						if ((nint)0 != 1)
																																																																																																																						{
																																																																																																																							_ = 0;
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																							_ = 0;
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																							if ((nint)0 != 1)
																																																																																																																							{
																																																																																																																								_ = 0;
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																								_ = 0;
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																								if ((nint)0 != 1)
																																																																																																																								{
																																																																																																																									_ = 0;
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																									_ = 0;
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																									if ((nint)0 != 1)
																																																																																																																									{
																																																																																																																										_ = 0;
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																										_ = 0;
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																										if ((nint)0 != 1)
																																																																																																																										{
																																																																																																																											_ = 0;
																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																											_ = 0;
																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																											if ((nint)0 != 1)
																																																																																																																											{
																																																																																																																												_ = 0;
																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																												_ = 0;
																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																												if ((nint)0 != 1)
																																																																																																																												{
																																																																																																																													_ = 0;
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																													_ = 0;
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																													if ((nint)0 != 1)
																																																																																																																													{
																																																																																																																														_ = 0;
																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																														_ = 0;
																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																														if ((nint)0 != 1)
																																																																																																																														{
																																																																																																																															_ = 0;
																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																															_ = 0;
																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																															if ((nint)0 != 1)
																																																																																																																															{
																																																																																																																																_ = 0;
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																_ = 0;
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																if ((nint)0 != 1)
																																																																																																																																{
																																																																																																																																	_ = 0;
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																	_ = 0;
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																	if ((nint)0 != 1)
																																																																																																																																	{
																																																																																																																																		_ = 0;
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																		_ = 0;
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																		if ((nint)0 != 1)
																																																																																																																																		{
																																																																																																																																			_ = 0;
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																																			_ = 0;
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																			if ((nint)0 != 1)
																																																																																																																																			{
																																																																																																																																				_ = 0;
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																																				_ = 0;
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																				if ((nint)0 != 1)
																																																																																																																																				{
																																																																																																																																					_ = 0;
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																																					_ = 0;
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																					if ((nint)0 != 1)
																																																																																																																																					{
																																																																																																																																						_ = 0;
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																																						_ = 0;
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																						if ((nint)0 != 1)
																																																																																																																																						{
																																																																																																																																							_ = 0;
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																																							_ = 0;
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																							if ((nint)0 != 1)
																																																																																																																																							{
																																																																																																																																								_ = 0;
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																								_ = 0;
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																								if ((nint)0 != 1)
																																																																																																																																								{
																																																																																																																																									_ = 0;
																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																																																									_ = 0;
																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																									if ((nint)0 != 1)
																																																																																																																																									{
																																																																																																																																										_ = 0;
																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																										_ = 0;
																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																										if ((nint)0 != 1)
																																																																																																																																										{
																																																																																																																																											_ = 0;
																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																																																											_ = 0;
																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																											if ((nint)0 != 1)
																																																																																																																																											{
																																																																																																																																												_ = 0;
																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																												_ = 0;
																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																												if ((nint)0 != 1)
																																																																																																																																												{
																																																																																																																																													_ = 0;
																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																																																													_ = 0;
																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																													if ((nint)0 != 1)
																																																																																																																																													{
																																																																																																																																														_ = 0;
																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																														_ = 0;
																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																														if ((nint)0 != 1)
																																																																																																																																														{
																																																																																																																																															_ = 0;
																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																															_ = 0;
																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																															if ((nint)0 != 1)
																																																																																																																																															{
																																																																																																																																																_ = 0;
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																_ = 0;
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																if ((nint)0 != 1)
																																																																																																																																																{
																																																																																																																																																	_ = 0;
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																	_ = 0;
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																	if ((nint)0 != 1)
																																																																																																																																																	{
																																																																																																																																																		_ = 0;
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																		_ = 0;
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																		if ((nint)0 != 1)
																																																																																																																																																		{
																																																																																																																																																			_ = 0;
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																			_ = 0;
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																			if ((nint)0 != 1)
																																																																																																																																																			{
																																																																																																																																																				_ = 0;
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
																																																																																																																																																				_ = 0;
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																				if ((nint)0 != 1)
																																																																																																																																																				{
																																																																																																																																																					_ = 0;
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6D");
																																																																																																																																																					_ = 0;
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																					if ((nint)0 != 1)
																																																																																																																																																					{
																																																																																																																																																						_ = 0;
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																						_ = 0;
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																						if ((nint)0 != 1)
																																																																																																																																																						{
																																																																																																																																																							_ = 0;
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																							_ = 0;
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																							if ((nint)0 != 1)
																																																																																																																																																							{
																																																																																																																																																								_ = 0;
																																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																								_ = 0;
																																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																								if ((nint)0 != 1)
																																																																																																																																																								{
																																																																																																																																																									_ = 0;
																																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																									_ = 0;
																																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																									if ((nint)0 != 1)
																																																																																																																																																									{
																																																																																																																																																										_ = 0;
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																										_ = 0;
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																										if ((nint)0 != 1)
																																																																																																																																																										{
																																																																																																																																																											_ = 0;
																																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																											_ = 0;
																																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																											if ((nint)0 != 1)
																																																																																																																																																											{
																																																																																																																																																												_ = 0;
																																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @630");
																																																																																																																																																												_ = 0;
																																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																												if ((nint)0 != 1)
																																																																																																																																																												{
																																																																																																																																																													_ = 0;
																																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																													_ = 0;
																																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																													if ((nint)0 != 1)
																																																																																																																																																													{
																																																																																																																																																														_ = 0;
																																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																														_ = 0;
																																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																														if ((nint)0 != 1)
																																																																																																																																																														{
																																																																																																																																																															_ = 0;
																																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																																																																																																																																																															_ = 0;
																																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																															if ((nint)0 != 1)
																																																																																																																																																															{
																																																																																																																																																																string flurryUserId = _flurryUserId;
																																																																																																																																																																_ = 0;
																																																																																																																																																																if (_flurryUserId != null)
																																																																																																																																																																{
																																																																																																																																																																	obj5 = 0;
																																																																																																																																																																	if (flurryUserId._stringLength != 0)
																																																																																																																																																																	{
																																																																																																																																																																		goto IL_37fb;
																																																																																																																																																																	}
																																																																																																																																																																}
																																																																																																																																																																obj5 = 1;
																																																																																																																																																																goto IL_37fb;
																																																																																																																																																															}
																																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																															object obj7 = default;
																																																																																																																																																															obj6 = obj7;
																																																																																																																																																														}
																																																																																																																																																														else
																																																																																																																																																														{
																																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																															object obj8 = default;
																																																																																																																																																															obj6 = obj8;
																																																																																																																																																														}
																																																																																																																																																													}
																																																																																																																																																													else
																																																																																																																																																													{
																																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																														object obj9 = default;
																																																																																																																																																														obj6 = obj9;
																																																																																																																																																													}
																																																																																																																																																												}
																																																																																																																																																												else
																																																																																																																																																												{
																																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																													object obj10 = default;
																																																																																																																																																													obj6 = obj10;
																																																																																																																																																												}
																																																																																																																																																											}
																																																																																																																																																											else
																																																																																																																																																											{
																																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																												object obj11 = default;
																																																																																																																																																												obj6 = obj11;
																																																																																																																																																											}
																																																																																																																																																										}
																																																																																																																																																										else
																																																																																																																																																										{
																																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																											object obj12 = default;
																																																																																																																																																											obj6 = obj12;
																																																																																																																																																										}
																																																																																																																																																									}
																																																																																																																																																									else
																																																																																																																																																									{
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																										object obj13 = default;
																																																																																																																																																										obj6 = obj13;
																																																																																																																																																									}
																																																																																																																																																								}
																																																																																																																																																								else
																																																																																																																																																								{
																																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																									object obj14 = default;
																																																																																																																																																									obj6 = obj14;
																																																																																																																																																								}
																																																																																																																																																							}
																																																																																																																																																							else
																																																																																																																																																							{
																																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																								object obj15 = default;
																																																																																																																																																								obj6 = obj15;
																																																																																																																																																							}
																																																																																																																																																						}
																																																																																																																																																						else
																																																																																																																																																						{
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																							object obj16 = default;
																																																																																																																																																							obj6 = obj16;
																																																																																																																																																						}
																																																																																																																																																						goto IL_34de;
																																																																																																																																																					}
																																																																																																																																																				}
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																				goto IL_34c7;
																																																																																																																																																			}
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																			object obj17 = default;
																																																																																																																																																			obj6 = obj17;
																																																																																																																																																		}
																																																																																																																																																		else
																																																																																																																																																		{
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																			object obj18 = default;
																																																																																																																																																			obj6 = obj18;
																																																																																																																																																		}
																																																																																																																																																	}
																																																																																																																																																	else
																																																																																																																																																	{
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																		object obj19 = default;
																																																																																																																																																		obj6 = obj19;
																																																																																																																																																	}
																																																																																																																																																}
																																																																																																																																																else
																																																																																																																																																{
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																	object obj20 = default;
																																																																																																																																																	obj6 = obj20;
																																																																																																																																																}
																																																																																																																																															}
																																																																																																																																															else
																																																																																																																																															{
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																object obj21 = default;
																																																																																																																																																obj6 = obj21;
																																																																																																																																															}
																																																																																																																																															goto IL_34de;
																																																																																																																																														}
																																																																																																																																													}
																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																													goto IL_34c7;
																																																																																																																																												}
																																																																																																																																											}
																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																											goto IL_34c7;
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																									goto IL_34c7;
																																																																																																																																								}
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																								object obj22 = default;
																																																																																																																																								obj6 = obj22;
																																																																																																																																							}
																																																																																																																																							else
																																																																																																																																							{
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																								object obj23 = default;
																																																																																																																																								obj6 = obj23;
																																																																																																																																							}
																																																																																																																																						}
																																																																																																																																						else
																																																																																																																																						{
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																							object obj24 = default;
																																																																																																																																							obj6 = obj24;
																																																																																																																																						}
																																																																																																																																					}
																																																																																																																																					else
																																																																																																																																					{
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																						object obj25 = default;
																																																																																																																																						obj6 = obj25;
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																				else
																																																																																																																																				{
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																					object obj26 = default;
																																																																																																																																					obj6 = obj26;
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																			else
																																																																																																																																			{
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																				object obj27 = default;
																																																																																																																																				obj6 = obj27;
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																		else
																																																																																																																																		{
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																			object obj28 = default;
																																																																																																																																			obj6 = obj28;
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																	else
																																																																																																																																	{
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																		object obj29 = default;
																																																																																																																																		obj6 = obj29;
																																																																																																																																	}
																																																																																																																																}
																																																																																																																																else
																																																																																																																																{
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																	object obj30 = default;
																																																																																																																																	obj6 = obj30;
																																																																																																																																}
																																																																																																																															}
																																																																																																																															else
																																																																																																																															{
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																object obj31 = default;
																																																																																																																																obj6 = obj31;
																																																																																																																															}
																																																																																																																														}
																																																																																																																														else
																																																																																																																														{
																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																															object obj32 = default;
																																																																																																																															obj6 = obj32;
																																																																																																																														}
																																																																																																																													}
																																																																																																																													else
																																																																																																																													{
																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																														object obj33 = default;
																																																																																																																														obj6 = obj33;
																																																																																																																													}
																																																																																																																												}
																																																																																																																												else
																																																																																																																												{
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																													object obj34 = default;
																																																																																																																													obj6 = obj34;
																																																																																																																												}
																																																																																																																											}
																																																																																																																											else
																																																																																																																											{
																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																												object obj35 = default;
																																																																																																																												obj6 = obj35;
																																																																																																																											}
																																																																																																																										}
																																																																																																																										else
																																																																																																																										{
																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																											object obj36 = default;
																																																																																																																											obj6 = obj36;
																																																																																																																										}
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																										object obj37 = default;
																																																																																																																										obj6 = obj37;
																																																																																																																									}
																																																																																																																								}
																																																																																																																								else
																																																																																																																								{
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																									object obj38 = default;
																																																																																																																									obj6 = obj38;
																																																																																																																								}
																																																																																																																							}
																																																																																																																							else
																																																																																																																							{
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																								object obj39 = default;
																																																																																																																								obj6 = obj39;
																																																																																																																							}
																																																																																																																						}
																																																																																																																						else
																																																																																																																						{
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																							object obj40 = default;
																																																																																																																							obj6 = obj40;
																																																																																																																						}
																																																																																																																					}
																																																																																																																					else
																																																																																																																					{
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																						object obj41 = default;
																																																																																																																						obj6 = obj41;
																																																																																																																					}
																																																																																																																				}
																																																																																																																				else
																																																																																																																				{
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																					object obj42 = default;
																																																																																																																					obj6 = obj42;
																																																																																																																				}
																																																																																																																			}
																																																																																																																			else
																																																																																																																			{
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																				object obj43 = default;
																																																																																																																				obj6 = obj43;
																																																																																																																			}
																																																																																																																		}
																																																																																																																		else
																																																																																																																		{
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																			object obj44 = default;
																																																																																																																			obj6 = obj44;
																																																																																																																		}
																																																																																																																	}
																																																																																																																	else
																																																																																																																	{
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																		object obj45 = default;
																																																																																																																		obj6 = obj45;
																																																																																																																	}
																																																																																																																}
																																																																																																																else
																																																																																																																{
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																	object obj46 = default;
																																																																																																																	obj6 = obj46;
																																																																																																																}
																																																																																																															}
																																																																																																															else
																																																																																																															{
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																object obj47 = default;
																																																																																																																obj6 = obj47;
																																																																																																															}
																																																																																																															goto IL_34de;
																																																																																																														}
																																																																																																													}
																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																													goto IL_34c7;
																																																																																																												}
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																												object obj48 = default;
																																																																																																												obj6 = obj48;
																																																																																																												goto IL_34de;
																																																																																																											}
																																																																																																										}
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																										goto IL_34c7;
																																																																																																									}
																																																																																																								}
																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																								goto IL_34c7;
																																																																																																							}
																																																																																																						}
																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																						goto IL_34c7;
																																																																																																					}
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																					object obj49 = default;
																																																																																																					obj6 = obj49;
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																					object obj50 = default;
																																																																																																					obj6 = obj50;
																																																																																																				}
																																																																																																				goto IL_34de;
																																																																																																			}
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																		}
																																																																																																		goto IL_34c7;
																																																																																																	}
																																																																																																}
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																															}
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																														}
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																													}
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																												}
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																											}
																																																																																											goto IL_34c7;
																																																																																										}
																																																																																									}
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																									goto IL_34c7;
																																																																																								}
																																																																																							}
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																							goto IL_34c7;
																																																																																						}
																																																																																					}
																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																				}
																																																																																			}
																																																																																			else
																																																																																			{
																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																			}
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																		}
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																	}
																																																																																}
																																																																																else
																																																																																{
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																}
																																																																																goto IL_34c7;
																																																																															}
																																																																														}
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																														goto IL_34c7;
																																																																													}
																																																																												}
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																											}
																																																																											else
																																																																											{
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																											}
																																																																										}
																																																																										else
																																																																										{
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																										}
																																																																									}
																																																																									else
																																																																									{
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																									}
																																																																								}
																																																																								else
																																																																								{
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																								}
																																																																							}
																																																																							else
																																																																							{
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																							}
																																																																						}
																																																																						else
																																																																						{
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																						}
																																																																					}
																																																																					else
																																																																					{
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																					}
																																																																				}
																																																																				else
																																																																				{
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																				}
																																																																			}
																																																																			else
																																																																			{
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																			}
																																																																		}
																																																																		else
																																																																		{
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																		}
																																																																	}
																																																																	else
																																																																	{
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																	}
																																																																}
																																																																else
																																																																{
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																}
																																																															}
																																																															else
																																																															{
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																															}
																																																														}
																																																														else
																																																														{
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																														}
																																																													}
																																																													else
																																																													{
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																													}
																																																												}
																																																												else
																																																												{
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																												}
																																																											}
																																																											else
																																																											{
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																											}
																																																										}
																																																										else
																																																										{
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																										}
																																																									}
																																																									else
																																																									{
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																									}
																																																								}
																																																								else
																																																								{
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																								}
																																																							}
																																																							else
																																																							{
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																							}
																																																						}
																																																						else
																																																						{
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																						}
																																																					}
																																																					else
																																																					{
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																					}
																																																				}
																																																				else
																																																				{
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																				}
																																																			}
																																																			else
																																																			{
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																			}
																																																		}
																																																		else
																																																		{
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																		}
																																																	}
																																																	else
																																																	{
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																	}
																																																}
																																																else
																																																{
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																}
																																															}
																																															else
																																															{
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																															}
																																														}
																																														else
																																														{
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																														}
																																													}
																																													else
																																													{
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																													}
																																												}
																																												else
																																												{
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																												}
																																											}
																																											else
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																											}
																																										}
																																										else
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																										}
																																									}
																																									else
																																									{
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																									}
																																								}
																																								else
																																								{
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																								}
																																							}
																																							else
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																							}
																																						}
																																						else
																																						{
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																						}
																																					}
																																					else
																																					{
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																					}
																																				}
																																				else
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																				}
																																			}
																																			else
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																			}
																																		}
																																		else
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																		}
																																	}
																																	else
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																	}
																																}
																																else
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																}
																															}
																															else
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																															}
																														}
																														else
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																														}
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																												}
																											}
																											else
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																											}
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																										}
																									}
																									else
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																									}
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								}
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						}
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																				}
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											goto IL_34c7;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_34c7;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_34c7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_34c7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_34c7;
		IL_3827:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_34c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj51 = default;
		obj6 = obj51;
		goto IL_34de;
		IL_37fb:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			if (obj5 == null)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj52 = default;
					obj6 = obj52;
					goto IL_34de;
				}
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_dirty = false;
												return;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_34c7;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								object obj53 = default;
								obj6 = obj53;
								goto IL_34de;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_34c7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj54 = default;
					obj6 = obj54;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj55 = default;
					obj6 = obj55;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj56 = default;
				obj6 = obj56;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj57 = default;
			obj6 = obj57;
		}
		goto IL_34de;
		IL_34de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj58 = default;
		object obj59 = default;
		if (obj58 == obj59)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj61 = default;
				object obj60 = obj61;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj62 = default;
					if (obj62 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj63 = (nint)0 << 2;
						object obj64 = obj3 + obj63;
						obj64 = obj61;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj65 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj66 = (nint)0 << 2;
						object obj67 = obj66 + obj3;
						object obj68 = obj67 - 4;
						object obj69 = obj68;
						bool flag = obj68 == null;
						string text = null;
						string text2 = "Error saving player info: ";
						if (!flag)
						{
							object obj70 = obj69;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1492 @ S1_v52+D4] (should have been resolved before IL gen)");
							string text3 = default;
							text = text3;
							text2 = "Error saving player info: ";
						}
						string text4 = text2 + text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj71 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj72 = obj61;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj6 = 0;
					if (flag2)
					{
						goto IL_3827;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj73 = default;
			obj6 = obj73;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj73;
			}
		}
		goto IL_3827;
	}

	private void SaveString(Dictionary<Key, string> dict, Key key, string value)
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe string LoadString(Dictionary<Key, string> dict, Key key, string defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Ref, but got Unknown
		//IL_0063: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_flurry_nextKeyToRead = key;
		bool flag = dict.TryGetValue(key, out *(string*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		string result = (string)0;
		if (!flag)
		{
			result = defaultValue;
		}
		return result;
	}

	private unsafe void SaveInt(Dictionary<Key, string> dict, Key key, int value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_0034: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		int num = obj + 12;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		string text = ((int*)num)->ToString(invariantCulture);
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe int LoadInt(Dictionary<Key, string> dict, Key key, int defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Ref, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_004d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_flurry_nextKeyToRead = key;
		int result2 = default;
		if (dict.TryGetValue(key, out *(string*)(obj + 12)))
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			ref int result = ref *(int*)(obj + 8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			bool flag = int.TryParse((string)0, NumberStyles.Integer, invariantCulture, out result);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			result2 = 0;
			if (!flag)
			{
				int num = default;
				result2 = num;
			}
		}
		return result2;
	}

	private unsafe void SaveFloat(Dictionary<Key, string> dict, Key key, float value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Expected Ref, but got F4
		//IL_0034: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		float num = (float)obj + 12f;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		string text = ((float*)num)->ToString(invariantCulture);
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe float LoadFloat(Dictionary<Key, string> dict, Key key, float defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Ref, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_004d: Expected Obj, but got I
		//IL_0061: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_flurry_nextKeyToRead = key;
		float result2 = default;
		if (dict.TryGetValue(key, out *(string*)(obj + 12)))
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			ref float result = ref *(float*)(obj + 8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			bool flag = float.TryParse((string)0, NumberStyles.Float, invariantCulture, out result);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			result2 = 0f;
			if (!flag)
			{
				float num = default;
				result2 = num;
			}
		}
		return result2;
	}

	private unsafe void SaveLong(Dictionary<Key, string> dict, Key key, long value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I8, but got Unknown
		//IL_0034: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		long num = obj + 8;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		string text = ((long*)num)->ToString(invariantCulture);
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe long LoadLong(Dictionary<Key, string> dict, Key key, long defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_003f: Expected Obj, but got I
		object obj = default;
		ref long reference = ref *(long*)(obj - 16);
		_ = 0;
		reference = ref *(long*)null;
		_flurry_nextKeyToRead = key;
		long result = default;
		if (dict.TryGetValue(key, out System.Runtime.CompilerServices.Unsafe.As<long, string>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 12))))
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int64&)+C]");
			bool flag = long.TryParse((string)0, NumberStyles.Integer, invariantCulture, out reference);
			result = reference;
			if (!flag)
			{
				long num = default;
				result = num;
			}
		}
		return result;
	}

	private unsafe void SaveBool(Dictionary<Key, string> dict, Key key, bool value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_004f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = (byte)(obj + 15) != 0;
		string text = (flag ? ((bool*)1) : ((bool*)null))->ToString();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe bool LoadBool(Dictionary<Key, string> dict, Key key, bool defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Ref, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_0036: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_flurry_nextKeyToRead = key;
		if (dict.TryGetValue(key, out *(string*)(obj + 12)))
		{
			ref bool result = ref *(bool*)(obj + 11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if (bool.TryParse((string)0, out result))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B]");
				return (nint)0 != 0;
			}
		}
		bool result2 = default;
		return result2;
	}

	private unsafe void SaveDateTime(Dictionary<Key, string> dict, Key key, DateTime value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected VT, but got Unknown
		//IL_0033: Expected Ref, but got VT
		//IL_0053: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		DateTime dateTime = (DateTime)(obj + 8);
		string text = ((DateTime*)dateTime)->ToString(invariantCulture);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe DateTime LoadDateTime(Dictionary<Key, string> dict, Key key, DateTime defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Ref, but got Unknown
		//IL_0028: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_flurry_nextKeyToRead = key;
		if (dict.TryGetValue(key, out *(string*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			DateTime defaultValue2 = default;
			return Utils.StringToDateTime((string)0, defaultValue2);
		}
		DateTime result = default;
		return result;
	}

	private void SaveEnum<T>(Dictionary<Key, string> dict, Key key, T value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		_ = -1;
		object obj3 = default;
		obj = (Enum)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe T LoadEnum<T>(Dictionary<Key, string> dict, Key key, T defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Ref, but got Unknown
		//IL_0475: Expected VT, but got Obj
		//IL_037b: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_flurry_nextKeyToRead = key;
		if (!dict.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_0470;
		}
		nint num = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_0470;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag = obj3 != obj4;
		object obj6 = default;
		object obj5 = obj6;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = -1;
						goto IL_0470;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj5 = 0;
					if (flag2)
					{
						goto IL_0475;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj15 = default;
			obj5 = obj15;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj5 = obj15;
			}
		}
		goto IL_0475;
		IL_0475:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0470;
		IL_0470:
		object obj16 = default;
		return (T)obj16;
	}

	private void SaveIntArray(Dictionary<Key, string> dict, Key key, int[] value)
	{
		//IL_0021: Expected Obj, but got I
		string[] value2 = Globals.convertAllIntToString(value);
		string text = string.Join(",", value2);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe int[] LoadIntArray(Dictionary<Key, string> dict, Key key, int[] defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Ref, but got Unknown
		//IL_0023: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_flurry_nextKeyToRead = key;
		if (!dict.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_00f7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17+8]");
			if ((nint)0 != 0)
			{
				goto IL_00fc;
			}
		}
		obj4 = 1;
		goto IL_00fc;
		IL_00fc:
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string[] array = ((string)0).Split(',');
			return Globals.convertAllStringToInt(array);
		}
		goto IL_00f7;
		IL_00f7:
		int[] result = default;
		return result;
	}

	private void SaveBoolArray(Dictionary<Key, string> dict, Key key, bool[] value)
	{
		//IL_0021: Expected Obj, but got I
		string[] value2 = Globals.convertAllBoolToString(value);
		string text = string.Join(",", value2);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PlayerInfo+Key, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	private unsafe bool[] LoadBoolArray(Dictionary<Key, string> dict, Key key, bool[] defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Ref, but got Unknown
		//IL_0023: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_flurry_nextKeyToRead = key;
		if (!dict.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_00f7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17+8]");
			if ((nint)0 != 0)
			{
				goto IL_00fc;
			}
		}
		obj4 = 1;
		goto IL_00fc;
		IL_00fc:
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string[] array = ((string)0).Split(',');
			return Globals.convertAllStringToBool(array);
		}
		goto IL_00f7;
		IL_00f7:
		bool[] result = default;
		return result;
	}

	public void Load()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_60e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_60e9: Expected Obj, but got Unknown
		//IL_60f2: Expected Obj, but got I4
		//IL_610d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6112: Expected Obj, but got Unknown
		//IL_5cf6: Expected Obj, but got I
		//IL_5d21: Expected Obj, but got I
		//IL_5d46: Expected Obj, but got I
		//IL_5d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d61: Expected Obj, but got Unknown
		//IL_60ad: Expected Obj, but got I
		//IL_18af: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b4: Expected Obj, but got Unknown
		//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0c: Expected Obj, but got Unknown
		//IL_25cb: Expected Obj, but got I4
		//IL_3e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e41: Expected Obj, but got Unknown
		//IL_3e99: Expected Obj, but got I
		//IL_3efa: Expected Obj, but got I4
		//IL_3eb1: Expected Obj, but got I4
		//IL_3f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f7c: Expected Obj, but got Unknown
		//IL_3fd4: Expected Obj, but got I
		//IL_4035: Expected Obj, but got I4
		//IL_3fec: Expected Obj, but got I4
		//IL_40c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c5: Expected Obj, but got Unknown
		//IL_411d: Expected Obj, but got I
		//IL_4135: Expected Obj, but got I4
		//IL_4358: Expected Obj, but got I4
		//IL_4339: Expected Obj, but got I4
		//IL_4917: Unknown result type (might be due to invalid IL or missing references)
		//IL_491c: Expected Obj, but got Unknown
		//IL_4971: Expected VT, but got I
		//IL_4d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d34: Expected Obj, but got Unknown
		//IL_4d44: Expected Obj, but got I
		//IL_4d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d57: Expected Obj, but got Unknown
		//IL_4d65: Expected Obj, but got I4
		//IL_63d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_63d7: Expected Obj, but got Unknown
		//IL_5102: Unknown result type (might be due to invalid IL or missing references)
		//IL_5107: Expected Obj, but got Unknown
		//IL_5117: Expected Obj, but got I
		//IL_5125: Unknown result type (might be due to invalid IL or missing references)
		//IL_512a: Expected Obj, but got Unknown
		//IL_5138: Expected Obj, but got I4
		//IL_6484: Unknown result type (might be due to invalid IL or missing references)
		//IL_6489: Expected Obj, but got Unknown
		//IL_540c: Expected Obj, but got I4
		//IL_53fe: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		if (!PlayerPrefs.HasKey("gmplayerdata"))
		{
			InitNew();
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj13;
		object obj32 = default;
		object obj33;
		object obj15;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														int num = default;
														if (num != _SecondDayLeft)
														{
															_dirty = true;
															_SecondDayLeft = num;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	string text = default;
																	_dailyWord = text;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			IntMask intMask = default;
																			_dailyWordUnlockedMask = intMask;
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					DateTime dailyWordExpireTime = default;
																					_dailyWordExpireTime = dailyWordExpireTime;
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						bool dailyWordPayedOut = default;
																						_dailyWordPayedOut = dailyWordPayedOut;
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						if ((nint)0 != 1)
																						{
																							int num2 = default;
																							_currentCharacter = num2;
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 != 1)
																							{
																								int num3 = default;
																								_currentMissionSet = num3;
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																								if ((nint)0 != 1)
																								{
																									int num4 = default;
																									_amountOfMysteryBoxesOpened = num4;
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																									if ((nint)0 != 1)
																									{
																										int num5 = default;
																										_amountOfSuperMysteryBoxesOpened = num5;
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																										if ((nint)0 != 1)
																										{
																											bool flag = default;
																											_hasReceivedFirstMBKey = flag;
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																											if ((nint)0 != 1)
																											{
																												bool flag2 = default;
																												_hasReceivedFirstSMBKey = flag2;
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																												if ((nint)0 != 1)
																												{
																													string text2 = default;
																													_lastTopRunResultAwardedID = text2;
																													_ = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																													_ = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																													if ((nint)0 != 1)
																													{
																														string text3 = default;
																														_pendingTopRunResultID = text3;
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																														if ((nint)0 != 1)
																														{
																															int pendingTopRunResultsScore = default;
																															_pendingTopRunResultsScore = pendingTopRunResultsScore;
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																															if ((nint)0 != 1)
																															{
																																int num6 = default;
																																_pendingTopRunResultsRank = num6;
																																_ = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																_ = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																if ((nint)0 != 1)
																																{
																																	int num7 = default;
																																	_pendingTopRunResultsWeek = num7;
																																	_ = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																	_ = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																	if ((nint)0 != 1)
																																	{
																																		int num8 = default;
																																		_lastWeekMedalWasShown = num8;
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																		_ = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																		if ((nint)0 != 1)
																																		{
																																			bool flag3 = default;
																																			if (flag3 != _isTutorialCompleted)
																																			{
																																				_dirty = true;
																																				_isTutorialCompleted = flag3;
																																			}
																																			_ = 0;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																			_ = 0;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																			if ((nint)0 != 1)
																																			{
																																				int num9 = default;
																																				_inAppLegacyPurchaseCount = num9;
																																				_ = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																				_ = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																				if ((nint)0 != 1)
																																				{
																																					int num10 = default;
																																					_inAppConsumablePurchaseCount = num10;
																																					_ = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																					_ = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																					if ((nint)0 != 1)
																																					{
																																						int num11 = default;
																																						_inAppNonconsumablePurchaseCount = num11;
																																						_ = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																						_ = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																						if ((nint)0 != 1)
																																						{
																																							int num12 = default;
																																							_inAppRestoredPurchaseCount = num12;
																																							_ = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																							_ = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																							if ((nint)0 != 1)
																																							{
																																								bool flag4 = default;
																																								_hasMadeOneValidPurchase = flag4;
																																								_ = 0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																								_ = 0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																								if ((nint)0 != 1)
																																								{
																																									bool flag5 = default;
																																									_hasLoggedStaticData = flag5;
																																									_ = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																									_ = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																									if ((nint)0 != 1)
																																									{
																																										bool flag6 = default;
																																										_hasLoggedSyboUserId = flag6;
																																										_ = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																										_ = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																										if ((nint)0 != 1)
																																										{
																																											string text4 = default;
																																											_earnCurrenyData = text4;
																																											_ = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																											_ = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																											if ((nint)0 != 1)
																																											{
																																												bool flag7 = default;
																																												_hasPayedOutFacebook = flag7;
																																												_ = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																												_ = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																												if ((nint)0 != 1)
																																												{
																																													bool flag8 = default;
																																													_hasPayedOutFacebookPack = flag8;
																																													_ = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																													_ = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																													if ((nint)0 != 1)
																																													{
																																														bool flag9 = default;
																																														_hasPayedOutFacebookCharacter = flag9;
																																														_ = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																														_ = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																														if ((nint)0 != 1)
																																														{
																																															bool flag10 = default;
																																															_hasPayedOutGameCenter = flag10;
																																															_ = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																															_ = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																															if ((nint)0 != 1)
																																															{
																																																bool flag11 = default;
																																																if (flag11 != _hasDoubleCoinsUpgrade)
																																																{
																																																	_dirty = true;
																																																	_hasDoubleCoinsUpgrade = flag11;
																																																}
																																																_ = 0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																_ = 0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																if ((nint)0 != 1)
																																																{
																																																	InAppData.BundleTier bundleTier = default;
																																																	_lastPurchasedBundle = bundleTier;
																																																	_ = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																	_ = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																	if ((nint)0 != 1)
																																																	{
																																																		int numberOfRunsSinceLastGuideline = default;
																																																		_numberOfRunsSinceLastGuideline = numberOfRunsSinceLastGuideline;
																																																		_ = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																		_ = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																		if ((nint)0 != 1)
																																																		{
																																																			int num13 = default;
																																																			_ratingAskCounter = num13;
																																																			_ = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																			_ = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																			if ((nint)0 != 1)
																																																			{
																																																				bool flag12 = default;
																																																				_hasShownHoverboardPopup = flag12;
																																																				_ = 0;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																				_ = 0;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																				if ((nint)0 != 1)
																																																				{
																																																					bool flag13 = default;
																																																					_hasShownAwardsIntroductionPopup = flag13;
																																																					_ = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																					_ = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																					if ((nint)0 != 1)
																																																					{
																																																						bool flag14 = default;
																																																						_hasShownTopRunIntroductionPopup = flag14;
																																																						_ = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																						_ = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																						if ((nint)0 != 1)
																																																						{
																																																							int num14 = default;
																																																							_lastShownTopRunIntroPopupVersionNumber = num14;
																																																							_ = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																							_ = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																							if ((nint)0 != 1)
																																																							{
																																																								bool flag15 = default;
																																																								_hasShownHoverboardCustmoizationPopup = flag15;
																																																								_ = 0;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																								_ = 0;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																								if ((nint)0 != 1)
																																																								{
																																																									bool flag16 = default;
																																																									_hasShownTurboHeadstartIntroductionPopup = flag16;
																																																									_ = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																									_ = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																									if ((nint)0 != 1)
																																																									{
																																																										bool flag17 = default;
																																																										_shouldShowHoverboardPopup = flag17;
																																																										_ = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																										_ = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																										if ((nint)0 != 1)
																																																										{
																																																											bool flag18 = default;
																																																											_hasShownFacebookPopup = flag18;
																																																											_ = 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																											_ = 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																											if ((nint)0 != 1)
																																																											{
																																																												bool flag19 = default;
																																																												_shouldShowFacebookPopup = flag19;
																																																												_ = 0;
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																												_ = 0;
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																												if ((nint)0 != 1)
																																																												{
																																																													bool flag20 = default;
																																																													_hasShownDuelIntroductionPopup = flag20;
																																																													_ = 0;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																													_ = 0;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																													if ((nint)0 != 1)
																																																													{
																																																														bool flag21 = default;
																																																														_shouldShowDuelIntroductionPopup = flag21;
																																																														_ = 0;
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																														_ = 0;
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																														if ((nint)0 != 1)
																																																														{
																																																															bool flag22 = default;
																																																															_shouldShowDuelsBreadcrumb = flag22;
																																																															_ = 0;
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																															_ = 0;
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																															if ((nint)0 != 1)
																																																															{
																																																																bool flag23 = default;
																																																																_hasShownMission1Popup = flag23;
																																																																_ = 0;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																_ = 0;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																if ((nint)0 != 1)
																																																																{
																																																																	bool flag24 = default;
																																																																	_shouldShowMission1Popup = flag24;
																																																																	_ = 0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																	_ = 0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																	if ((nint)0 != 1)
																																																																	{
																																																																		bool flag25 = default;
																																																																		_hasShownCollectPopup = flag25;
																																																																		_ = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																		_ = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																		if ((nint)0 != 1)
																																																																		{
																																																																			bool flag26 = default;
																																																																			_shouldShowCollectPopup = flag26;
																																																																			_ = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																			_ = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																			if ((nint)0 != 1)
																																																																			{
																																																																				bool flag27 = default;
																																																																				_hasShownMission2Popup = flag27;
																																																																				_ = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																				_ = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																				if ((nint)0 != 1)
																																																																				{
																																																																					bool flag28 = default;
																																																																					_shouldShowMission2Popup = flag28;
																																																																					_ = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																					_ = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																					if ((nint)0 != 1)
																																																																					{
																																																																						bool flag29 = default;
																																																																						_hasShownKeysPopup = flag29;
																																																																						_ = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																						_ = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																						if ((nint)0 != 1)
																																																																						{
																																																																							bool flag30 = default;
																																																																							_hasCollectedFromFriends = flag30;
																																																																							_ = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																							_ = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																							if ((nint)0 != 1)
																																																																							{
																																																																								int latestAvailableAssetBundlesVersion = default;
																																																																								_latestAvailableAssetBundlesVersion = latestAvailableAssetBundlesVersion;
																																																																								_ = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																								_ = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																								if ((nint)0 != 1)
																																																																								{
																																																																									bool allAssetBundlesDownloaded = default;
																																																																									_allAssetBundlesDownloaded = allAssetBundlesDownloaded;
																																																																									_ = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																									_ = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																									if ((nint)0 != 1)
																																																																									{
																																																																										bool flag31 = default;
																																																																										_dummyFriendCollected = flag31;
																																																																										_ = 0;
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																										_ = 0;
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																										if ((nint)0 != 1)
																																																																										{
																																																																											bool flag32 = default;
																																																																											_dummyFriendShouldShow = flag32;
																																																																											_ = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																											_ = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																											if ((nint)0 != 1)
																																																																											{
																																																																												int num15 = default;
																																																																												_amountOfSeasonalEggs = num15;
																																																																												_ = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																												_ = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																												if ((nint)0 != 1)
																																																																												{
																																																																													string text5 = default;
																																																																													_weeklyChallangeData = text5;
																																																																													_ = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																													_ = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																													if ((nint)0 != 1)
																																																																													{
																																																																														_ = 0;
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																																																																														_ = 0;
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																														if ((nint)0 != 1)
																																																																														{
																																																																															_ = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																															_ = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																															if ((nint)0 != 1)
																																																																															{
																																																																																string text6 = default;
																																																																																_lastPlayDate = text6;
																																																																																_ = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																_ = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																if ((nint)0 != 1)
																																																																																{
																																																																																	string text7 = default;
																																																																																	_lastQuitDate = text7;
																																																																																	_ = 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																	_ = 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																	if ((nint)0 != 1)
																																																																																	{
																																																																																		string text8 = default;
																																																																																		_lastDailyOnlineLog = text8;
																																																																																		_ = 0;
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																		_ = 0;
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																		if ((nint)0 != 1)
																																																																																		{
																																																																																			int num16 = default;
																																																																																			_missionsVersionLastUpdate = num16;
																																																																																			_ = 0;
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																			_ = 0;
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																			if ((nint)0 != 1)
																																																																																			{
																																																																																				_ = 0;
																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																																																																																				_ = 0;
																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																				if ((nint)0 != 1)
																																																																																				{
																																																																																					_ = 0;
																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																					_ = 0;
																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																					if ((nint)0 != 1)
																																																																																					{
																																																																																						List<CelebrationReward> list = default;
																																																																																						_pendingRewards = list;
																																																																																						_ = 0;
																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																						_ = 0;
																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																						if ((nint)0 != 1)
																																																																																						{
																																																																																							long num17 = default;
																																																																																							_lastEventID = num17;
																																																																																							_ = 0;
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																							_ = 0;
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																							if ((nint)0 != 1)
																																																																																							{
																																																																																								string text9 = default;
																																																																																								_lastEventItemID = text9;
																																																																																								_ = 0;
																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																								_ = 0;
																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																								if ((nint)0 != 1)
																																																																																								{
																																																																																									bool flag33 = default;
																																																																																									_shouldRestoreAfterEvent = flag33;
																																																																																									_ = 0;
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																									_ = 0;
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																									if ((nint)0 != 1)
																																																																																									{
																																																																																										long num18 = default;
																																																																																										_lastTimeAnEventHasBeenTried = num18;
																																																																																										_ = 0;
																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																										_ = 0;
																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																										if ((nint)0 != 1)
																																																																																										{
																																																																																											long num19 = default;
																																																																																											_lastTimeAnEventWasStarted = num19;
																																																																																											_ = 0;
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																											_ = 0;
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																											if ((nint)0 != 1)
																																																																																											{
																																																																																												long num20 = default;
																																																																																												_lastTimeEventPopupHasBeenForcedShown = num20;
																																																																																												_ = 0;
																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																												_ = 0;
																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																												if ((nint)0 != 1)
																																																																																												{
																																																																																													bool flag34 = default;
																																																																																													_remoteNotificationsEnabled = flag34;
																																																																																													_ = 0;
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																													_ = 0;
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																													if ((nint)0 != 1)
																																																																																													{
																																																																																														bool flag35 = default;
																																																																																														_isFreshInstall = flag35;
																																																																																														_ = 0;
																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
																																																																																														_ = 0;
																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																														if ((nint)0 != 1)
																																																																																														{
																																																																																															_ = 0;
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																																																																																															_ = 0;
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																															if ((nint)0 != 1)
																																																																																															{
																																																																																																_ = 0;
																																																																																																object obj5 = obj + 88;
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1477");
																																																																																																_ = 0;
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																if ((nint)0 != 1)
																																																																																																{
																																																																																																	_ = 0;
																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																	_ = 0;
																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																	if ((nint)0 != 1)
																																																																																																	{
																																																																																																		DateTime dailyInterstitialExpireTime = default;
																																																																																																		_dailyInterstitialExpireTime = dailyInterstitialExpireTime;
																																																																																																		_ = 0;
																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																		_ = 0;
																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																		if ((nint)0 != 1)
																																																																																																		{
																																																																																																			DateTime dateTime = default;
																																																																																																			_lastTimeInterstitialWasSeen = dateTime;
																																																																																																			_ = 0;
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																			_ = 0;
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																			if ((nint)0 != 1)
																																																																																																			{
																																																																																																				DateTime dateTime2 = default;
																																																																																																				_lastTimeInterstitialProviderHasChanged = dateTime2;
																																																																																																				_ = 0;
																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
																																																																																																				_ = 0;
																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																				if ((nint)0 != 1)
																																																																																																				{
																																																																																																					_ = 0;
																																																																																																					object obj6 = obj + 88;
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1477");
																																																																																																					_ = 0;
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																					if ((nint)0 != 1)
																																																																																																					{
																																																																																																						_ = 0;
																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																						_ = 0;
																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																						if ((nint)0 != 1)
																																																																																																						{
																																																																																																							DateTime hourlyInterstitialExpireTime = default;
																																																																																																							_hourlyInterstitialExpireTime = hourlyInterstitialExpireTime;
																																																																																																							_ = 0;
																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																							_ = 0;
																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																							if ((nint)0 != 1)
																																																																																																							{
																																																																																																								int num21 = default;
																																																																																																								_numberOfInterstitialsPerDay = num21;
																																																																																																								_ = 0;
																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																								_ = 0;
																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																								if ((nint)0 != 1)
																																																																																																								{
																																																																																																									int num22 = default;
																																																																																																									_numberOfInterstitialsPerHour = num22;
																																																																																																									_ = 0;
																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																									_ = 0;
																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																									if ((nint)0 != 1)
																																																																																																									{
																																																																																																										int num23 = default;
																																																																																																										_interstitialProviderListVersion = num23;
																																																																																																										_ = 0;
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																										_ = 0;
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																										if ((nint)0 != 1)
																																																																																																										{
																																																																																																											bool flag36 = default;
																																																																																																											_isSaveMePopupEnabled = flag36;
																																																																																																											_ = 0;
																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																											_ = 0;
																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																											if ((nint)0 != 1)
																																																																																																											{
																																																																																																												bool flag37 = default;
																																																																																																												_hasShownVoucherPopupOnFrontScreen = flag37;
																																																																																																												_ = 0;
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																												_ = 0;
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																												if ((nint)0 != 1)
																																																																																																												{
																																																																																																													bool flag38 = default;
																																																																																																													_hasShownVoucherPopupInShop = flag38;
																																																																																																													_ = 0;
																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																													_ = 0;
																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																													if ((nint)0 != 1)
																																																																																																													{
																																																																																																														string shouldUseAlternativeHuntPrizes = default;
																																																																																																														_shouldUseAlternativeHuntPrizes = shouldUseAlternativeHuntPrizes;
																																																																																																														_ = 0;
																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																														_ = 0;
																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																														if ((nint)0 != 1)
																																																																																																														{
																																																																																																															int num24 = default;
																																																																																																															_numberOfRuns = num24;
																																																																																																															_ = 0;
																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
																																																																																																															_ = 0;
																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																															if ((nint)0 != 1)
																																																																																																															{
																																																																																																																_ = 0;
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																																_ = 0;
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																if ((nint)0 != 1)
																																																																																																																{
																																																																																																																	DateTime dateTime3 = default;
																																																																																																																	_lastKnownServerTime = dateTime3;
																																																																																																																	_ = 0;
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																																	_ = 0;
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																	if ((nint)0 != 1)
																																																																																																																	{
																																																																																																																		DateTime dateTime4 = default;
																																																																																																																		_lastTimeAVideoForKeysWasSeen = dateTime4;
																																																																																																																		_ = 0;
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																																		_ = 0;
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																		if ((nint)0 != 1)
																																																																																																																		{
																																																																																																																			DateTime dateTime5 = default;
																																																																																																																			_weeklyGiftEndTime = dateTime5;
																																																																																																																			_ = 0;
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
																																																																																																																			_ = 0;
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																			if ((nint)0 != 1)
																																																																																																																			{
																																																																																																																				_ = 0;
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																																				_ = 0;
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																				if ((nint)0 != 1)
																																																																																																																				{
																																																																																																																					DateTime dateTime6 = default;
																																																																																																																					_lastTimeAppWasUpdatedOrInstalled = dateTime6;
																																																																																																																					_ = 0;
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																																					_ = 0;
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																					if ((nint)0 != 1)
																																																																																																																					{
																																																																																																																						DateTime dateTime7 = default;
																																																																																																																						_firstInstallDate = dateTime7;
																																																																																																																						_ = 0;
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																						_ = 0;
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																						if ((nint)0 != 1)
																																																																																																																						{
																																																																																																																							string text10 = default;
																																																																																																																							_firstInstalledVersion = text10;
																																																																																																																							_ = 0;
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																							_ = 0;
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																							if ((nint)0 != 1)
																																																																																																																							{
																																																																																																																								_ = 0;
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																																								_ = 0;
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																								if ((nint)0 != 1)
																																																																																																																								{
																																																																																																																									Statistics statistics = default;
																																																																																																																									_stats = statistics;
																																																																																																																									_ = 0;
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																									_ = 0;
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																									if ((nint)0 != 1)
																																																																																																																									{
																																																																																																																										_ = 0;
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																																																																																																																										_ = 0;
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																										if ((nint)0 != 1)
																																																																																																																										{
																																																																																																																											_ = 0;
																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																																																																																																																											_ = 0;
																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																											if ((nint)0 != 1)
																																																																																																																											{
																																																																																																																												HoverboardCustomizationData hoverboardCustomizationData = default;
																																																																																																																												_hoverboardCustomizationData = hoverboardCustomizationData;
																																																																																																																												_ = 0;
																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																												_ = 0;
																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																												if ((nint)0 != 1)
																																																																																																																												{
																																																																																																																													_ = 0;
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																																																																																																																													_ = 0;
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																													if ((nint)0 != 1)
																																																																																																																													{
																																																																																																																														_ = 0;
																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																																																																																																																														_ = 0;
																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																														if ((nint)0 != 1)
																																																																																																																														{
																																																																																																																															CollectCoinsDummyData collectCoinsDummyData = default;
																																																																																																																															_collectCoinsDummyData = collectCoinsDummyData;
																																																																																																																															_ = 0;
																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																															_ = 0;
																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																															if ((nint)0 != 1)
																																																																																																																															{
																																																																																																																																string text11 = default;
																																																																																																																																_trophyMissionData = text11;
																																																																																																																																_ = 0;
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																_ = 0;
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																if ((nint)0 != 1)
																																																																																																																																{
																																																																																																																																	string text12 = default;
																																																																																																																																	_characterNameEventData = text12;
																																																																																																																																	_ = 0;
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																	_ = 0;
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																	if ((nint)0 != 1)
																																																																																																																																	{
																																																																																																																																		bool flag39 = default;
																																																																																																																																		_hasCollectedFirstAwardReward = flag39;
																																																																																																																																		_ = 0;
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																		_ = 0;
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																		if ((nint)0 != 1)
																																																																																																																																		{
																																																																																																																																			bool flag40 = default;
																																																																																																																																			_hasCollectedFacebookWeeklyGiftThisWeek = flag40;
																																																																																																																																			_ = 0;
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																			_ = 0;
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																			if ((nint)0 != 1)
																																																																																																																																			{
																																																																																																																																				int[] currentMissionProgress = default;
																																																																																																																																				_currentMissionProgress = currentMissionProgress;
																																																																																																																																				_ = 0;
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																				_ = 0;
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																				if ((nint)0 != 1)
																																																																																																																																				{
																																																																																																																																					int num25 = default;
																																																																																																																																					_amountOfMiniMysteryBoxesOpened = num25;
																																																																																																																																					_ = 0;
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1EC");
																																																																																																																																					_ = 0;
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																					if ((nint)0 != 1)
																																																																																																																																					{
																																																																																																																																						float num26 = default;
																																																																																																																																						if (!(num26 < 0f))
																																																																																																																																						{
																																																																																																																																							_analyticsSamplingKey = num26;
																																																																																																																																						}
																																																																																																																																						_ = 0;
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																						_ = 0;
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																						if ((nint)0 != 1)
																																																																																																																																						{
																																																																																																																																							string syboAnalyticsUserId = default;
																																																																																																																																							_syboAnalyticsUserId = syboAnalyticsUserId;
																																																																																																																																							_ = 0;
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																							_ = 0;
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																							if ((nint)0 != 1)
																																																																																																																																							{
																																																																																																																																								int syboAnalyticsCurrentSession = default;
																																																																																																																																								_syboAnalyticsCurrentSession = syboAnalyticsCurrentSession;
																																																																																																																																								_ = 0;
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																								_ = 0;
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																								if ((nint)0 != 1)
																																																																																																																																								{
																																																																																																																																									int syboAnalyticsGamesSinceFlush = default;
																																																																																																																																									_syboAnalyticsGamesSinceFlush = syboAnalyticsGamesSinceFlush;
																																																																																																																																									_ = 0;
																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																									_ = 0;
																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																									if ((nint)0 != 1)
																																																																																																																																									{
																																																																																																																																										string syboAnalyticsPreviousClientVersion = default;
																																																																																																																																										_syboAnalyticsPreviousClientVersion = syboAnalyticsPreviousClientVersion;
																																																																																																																																										_ = 0;
																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
																																																																																																																																										_ = 0;
																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																										if ((nint)0 != 1)
																																																																																																																																										{
																																																																																																																																											long syboLastPurchaseNumber = default;
																																																																																																																																											_syboLastPurchaseNumber = syboLastPurchaseNumber;
																																																																																																																																											_ = 0;
																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																											_ = 0;
																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																											if ((nint)0 != 1)
																																																																																																																																											{
																																																																																																																																												string flurryUserId = default;
																																																																																																																																												_flurryUserId = flurryUserId;
																																																																																																																																												_ = 0;
																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																												_ = 0;
																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																												if ((nint)0 != 1)
																																																																																																																																												{
																																																																																																																																													bool flag41 = default;
																																																																																																																																													_allowSellHeadstartDuringRun = flag41;
																																																																																																																																													_ = 0;
																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																													_ = 0;
																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																													if ((nint)0 != 1)
																																																																																																																																													{
																																																																																																																																														bool flag42 = default;
																																																																																																																																														_allowSellScoreboosterDuringRun = flag42;
																																																																																																																																														_ = 0;
																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																														_ = 0;
																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																														if ((nint)0 != 1)
																																																																																																																																														{
																																																																																																																																															int num27 = default;
																																																																																																																																															_ageRestrictionInputVersion = num27;
																																																																																																																																															_ = 0;
																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																															_ = 0;
																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																															if ((nint)0 != 1)
																																																																																																																																															{
																																																																																																																																																int num28 = default;
																																																																																																																																																_ageRestrictionInputMonth = num28;
																																																																																																																																																_ = 0;
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																_ = 0;
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																if ((nint)0 != 1)
																																																																																																																																																{
																																																																																																																																																	int num29 = default;
																																																																																																																																																	_ageRestrictionInputYear = num29;
																																																																																																																																																	_ = 0;
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																	_ = 0;
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																	if ((nint)0 != 1)
																																																																																																																																																	{
																																																																																																																																																		object obj7 = 0;
																																																																																																																																																		int[] collectedCharacterTokens;
																																																																																																																																																		while (true)
																																																																																																																																																		{
																																																																																																																																																			collectedCharacterTokens = _collectedCharacterTokens;
																																																																																																																																																			if (collectedCharacterTokens.Length <= (nint)obj7)
																																																																																																																																																			{
																																																																																																																																																				break;
																																																																																																																																																			}
																																																																																																																																																			object obj8 = obj7 << 2;
																																																																																																																																																			object obj9 = (object)collectedCharacterTokens + obj8;
																																																																																																																																																			_ = 0;
																																																																																																																																																			object obj10 = obj7 + 1;
																																																																																																																																																			obj7 = obj10;
																																																																																																																																																		}
																																																																																																																																																		object obj11 = default;
																																																																																																																																																		if (obj11 != null)
																																																																																																																																																		{
																																																																																																																																																			_ = 0;
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4474 @ S0_v1920+C]");
																																																																																																																																																			bool flag43 = (nint)0 < (nint)collectedCharacterTokens.Length;
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4474 @ S0_v1920+C]");
																																																																																																																																																			object obj12 = 0;
																																																																																																																																																			if (!flag43)
																																																																																																																																																			{
																																																																																																																																																				obj12 = collectedCharacterTokens.Length;
																																																																																																																																																			}
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																																																																																																																																																			_ = 0;
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																			if ((nint)0 == 1)
																																																																																																																																																			{
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																				object obj14 = default;
																																																																																																																																																				obj13 = obj14;
																																																																																																																																																				object obj16 = default;
																																																																																																																																																				obj15 = obj16;
																																																																																																																																																				goto IL_6237;
																																																																																																																																																			}
																																																																																																																																																		}
																																																																																																																																																		_ = 0;
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																		_ = 0;
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																		if ((nint)0 != 1)
																																																																																																																																																		{
																																																																																																																																																			object obj17 = 0;
																																																																																																																																																			bool[] unlockedTrophies;
																																																																																																																																																			while (true)
																																																																																																																																																			{
																																																																																																																																																				unlockedTrophies = _unlockedTrophies;
																																																																																																																																																				if (unlockedTrophies.Length <= (nint)obj17)
																																																																																																																																																				{
																																																																																																																																																					break;
																																																																																																																																																				}
																																																																																																																																																				object obj18 = obj17 + (object)unlockedTrophies;
																																																																																																																																																				_ = 0;
																																																																																																																																																				object obj19 = obj17 + 1;
																																																																																																																																																				obj17 = obj19;
																																																																																																																																																			}
																																																																																																																																																			object obj20 = default;
																																																																																																																																																			if (obj20 != null)
																																																																																																																																																			{
																																																																																																																																																				_ = 0;
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4535 @ S0_v1939+C]");
																																																																																																																																																				bool flag44 = (nint)0 < (nint)unlockedTrophies.Length;
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4535 @ S0_v1939+C]");
																																																																																																																																																				object obj21 = 0;
																																																																																																																																																				if (!flag44)
																																																																																																																																																				{
																																																																																																																																																					obj21 = unlockedTrophies.Length;
																																																																																																																																																				}
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																																																																																																																																																				_ = 0;
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																				if ((nint)0 == 1)
																																																																																																																																																				{
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																					object obj22 = default;
																																																																																																																																																					obj13 = obj22;
																																																																																																																																																					object obj23 = default;
																																																																																																																																																					obj15 = obj23;
																																																																																																																																																					goto IL_6237;
																																																																																																																																																				}
																																																																																																																																																			}
																																																																																																																																																			_ = 0;
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																			_ = 0;
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																			if ((nint)0 != 1)
																																																																																																																																																			{
																																																																																																																																																				object obj24 = 0;
																																																																																																																																																				int[] array;
																																																																																																																																																				while (true)
																																																																																																																																																				{
																																																																																																																																																					array = _achievementProgress;
																																																																																																																																																					if (array.Length <= (nint)obj24)
																																																																																																																																																					{
																																																																																																																																																						break;
																																																																																																																																																					}
																																																																																																																																																					object obj25 = obj24 << 2;
																																																																																																																																																					object obj26 = (object)array + obj25;
																																																																																																																																																					_ = 0;
																																																																																																																																																					object obj27 = obj24 + 1;
																																																																																																																																																					obj24 = obj27;
																																																																																																																																																				}
																																																																																																																																																				object obj28 = default;
																																																																																																																																																				if (obj28 != null)
																																																																																																																																																				{
																																																																																																																																																					_ = 0;
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4599 @ S0_v1958+C]");
																																																																																																																																																					bool flag45 = (nint)0 < (nint)array.Length;
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4599 @ S0_v1958+C]");
																																																																																																																																																					object obj29 = 0;
																																																																																																																																																					if (!flag45)
																																																																																																																																																					{
																																																																																																																																																						obj29 = array.Length;
																																																																																																																																																					}
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																																																																																																																																																					_ = 0;
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																					if ((nint)0 == 1)
																																																																																																																																																					{
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																						object obj30 = default;
																																																																																																																																																						obj13 = obj30;
																																																																																																																																																						object obj31 = default;
																																																																																																																																																						obj15 = obj31;
																																																																																																																																																						goto IL_6237;
																																																																																																																																																					}
																																																																																																																																																				}
																																																																																																																																																				_ = 0;
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																				_ = 0;
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																				if ((nint)0 != 1)
																																																																																																																																																				{
																																																																																																																																																					int num30 = default;
																																																																																																																																																					_dailyWordInRow = num30;
																																																																																																																																																					_ = 0;
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																					_ = 0;
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																					if ((nint)0 != 1)
																																																																																																																																																					{
																																																																																																																																																						int num31 = default;
																																																																																																																																																						_dailyWordLastPayoutDayOfYear = num31;
																																																																																																																																																						_ = 0;
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																						_ = 0;
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																						if ((nint)0 != 1)
																																																																																																																																																						{
																																																																																																																																																							int num32 = default;
																																																																																																																																																							_missionCompletedSum = num32;
																																																																																																																																																							_ = 0;
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																							_ = 0;
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																							if ((nint)0 != 1)
																																																																																																																																																							{
																																																																																																																																																								_ = 0;
																																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																																																																																																																																																								_ = 0;
																																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																								if ((nint)0 != 1)
																																																																																																																																																								{
																																																																																																																																																									_ = 0;
																																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																																																																																																																																																									_ = 0;
																																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																									if ((nint)0 != 1)
																																																																																																																																																									{
																																																																																																																																																										Dictionary<Hoverboards.BoardType, bool> hasHoverboardBeenSeen = default;
																																																																																																																																																										_hasHoverboardBeenSeen = hasHoverboardBeenSeen;
																																																																																																																																																										_ = 0;
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																																																																																																																																																										_ = 0;
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																																																																																																																																																										if ((nint)0 != 1)
																																																																																																																																																										{
																																																																																																																																																											_ = 0;
																																																																																																																																																											if (obj32 != null)
																																																																																																																																																											{
																																																																																																																																																												obj33 = 0;
																																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4777 @ S0_v2052+8]");
																																																																																																																																																												if ((nint)0 != 0)
																																																																																																																																																												{
																																																																																																																																																													goto IL_6398;
																																																																																																																																																												}
																																																																																																																																																											}
																																																																																																																																																											obj33 = 1;
																																																																																																																																																											goto IL_6398;
																																																																																																																																																										}
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																										object obj34 = default;
																																																																																																																																																										obj13 = obj34;
																																																																																																																																																										object obj35 = default;
																																																																																																																																																										obj15 = obj35;
																																																																																																																																																									}
																																																																																																																																																									else
																																																																																																																																																									{
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																										object obj36 = default;
																																																																																																																																																										obj13 = obj36;
																																																																																																																																																										object obj37 = default;
																																																																																																																																																										obj15 = obj37;
																																																																																																																																																									}
																																																																																																																																																									goto IL_6237;
																																																																																																																																																								}
																																																																																																																																																							}
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																							object obj38 = default;
																																																																																																																																																							obj13 = obj38;
																																																																																																																																																							object obj39 = default;
																																																																																																																																																							obj15 = obj39;
																																																																																																																																																						}
																																																																																																																																																						else
																																																																																																																																																						{
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																							object obj40 = default;
																																																																																																																																																							obj13 = obj40;
																																																																																																																																																							object obj41 = default;
																																																																																																																																																							obj15 = obj41;
																																																																																																																																																						}
																																																																																																																																																					}
																																																																																																																																																					else
																																																																																																																																																					{
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																						object obj42 = default;
																																																																																																																																																						obj13 = obj42;
																																																																																																																																																						object obj43 = default;
																																																																																																																																																						obj15 = obj43;
																																																																																																																																																					}
																																																																																																																																																				}
																																																																																																																																																				else
																																																																																																																																																				{
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																					object obj44 = default;
																																																																																																																																																					obj13 = obj44;
																																																																																																																																																					object obj45 = default;
																																																																																																																																																					obj15 = obj45;
																																																																																																																																																				}
																																																																																																																																																			}
																																																																																																																																																			else
																																																																																																																																																			{
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																				object obj46 = default;
																																																																																																																																																				obj13 = obj46;
																																																																																																																																																				object obj47 = default;
																																																																																																																																																				obj15 = obj47;
																																																																																																																																																			}
																																																																																																																																																		}
																																																																																																																																																		else
																																																																																																																																																		{
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																			object obj48 = default;
																																																																																																																																																			obj13 = obj48;
																																																																																																																																																			object obj49 = default;
																																																																																																																																																			obj15 = obj49;
																																																																																																																																																		}
																																																																																																																																																	}
																																																																																																																																																	else
																																																																																																																																																	{
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																		object obj50 = default;
																																																																																																																																																		obj13 = obj50;
																																																																																																																																																		object obj51 = default;
																																																																																																																																																		obj15 = obj51;
																																																																																																																																																	}
																																																																																																																																																}
																																																																																																																																																else
																																																																																																																																																{
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																	object obj52 = default;
																																																																																																																																																	obj13 = obj52;
																																																																																																																																																	object obj53 = default;
																																																																																																																																																	obj15 = obj53;
																																																																																																																																																}
																																																																																																																																															}
																																																																																																																																															else
																																																																																																																																															{
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																																object obj54 = default;
																																																																																																																																																obj13 = obj54;
																																																																																																																																																object obj55 = default;
																																																																																																																																																obj15 = obj55;
																																																																																																																																															}
																																																																																																																																														}
																																																																																																																																														else
																																																																																																																																														{
																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																															object obj56 = default;
																																																																																																																																															obj13 = obj56;
																																																																																																																																															object obj57 = default;
																																																																																																																																															obj15 = obj57;
																																																																																																																																														}
																																																																																																																																													}
																																																																																																																																													else
																																																																																																																																													{
																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																														object obj58 = default;
																																																																																																																																														obj13 = obj58;
																																																																																																																																														object obj59 = default;
																																																																																																																																														obj15 = obj59;
																																																																																																																																													}
																																																																																																																																												}
																																																																																																																																												else
																																																																																																																																												{
																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																													object obj60 = default;
																																																																																																																																													obj13 = obj60;
																																																																																																																																													object obj61 = default;
																																																																																																																																													obj15 = obj61;
																																																																																																																																												}
																																																																																																																																											}
																																																																																																																																											else
																																																																																																																																											{
																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																												object obj62 = default;
																																																																																																																																												obj13 = obj62;
																																																																																																																																												object obj63 = default;
																																																																																																																																												obj15 = obj63;
																																																																																																																																											}
																																																																																																																																										}
																																																																																																																																										else
																																																																																																																																										{
																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																											object obj64 = default;
																																																																																																																																											obj13 = obj64;
																																																																																																																																											object obj65 = default;
																																																																																																																																											obj15 = obj65;
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																									else
																																																																																																																																									{
																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																										object obj66 = default;
																																																																																																																																										obj13 = obj66;
																																																																																																																																										object obj67 = default;
																																																																																																																																										obj15 = obj67;
																																																																																																																																									}
																																																																																																																																								}
																																																																																																																																								else
																																																																																																																																								{
																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																									object obj68 = default;
																																																																																																																																									obj13 = obj68;
																																																																																																																																									object obj69 = default;
																																																																																																																																									obj15 = obj69;
																																																																																																																																								}
																																																																																																																																							}
																																																																																																																																							else
																																																																																																																																							{
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																								object obj70 = default;
																																																																																																																																								obj13 = obj70;
																																																																																																																																								object obj71 = default;
																																																																																																																																								obj15 = obj71;
																																																																																																																																							}
																																																																																																																																						}
																																																																																																																																						else
																																																																																																																																						{
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																							object obj72 = default;
																																																																																																																																							obj13 = obj72;
																																																																																																																																							object obj73 = default;
																																																																																																																																							obj15 = obj73;
																																																																																																																																						}
																																																																																																																																					}
																																																																																																																																					else
																																																																																																																																					{
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																						object obj74 = default;
																																																																																																																																						obj13 = obj74;
																																																																																																																																						object obj75 = default;
																																																																																																																																						obj15 = obj75;
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																				else
																																																																																																																																				{
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																					object obj76 = default;
																																																																																																																																					obj13 = obj76;
																																																																																																																																					object obj77 = default;
																																																																																																																																					obj15 = obj77;
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																			else
																																																																																																																																			{
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																				object obj78 = default;
																																																																																																																																				obj13 = obj78;
																																																																																																																																				object obj79 = default;
																																																																																																																																				obj15 = obj79;
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																		else
																																																																																																																																		{
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																			object obj80 = default;
																																																																																																																																			obj13 = obj80;
																																																																																																																																			object obj81 = default;
																																																																																																																																			obj15 = obj81;
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																	else
																																																																																																																																	{
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																		object obj82 = default;
																																																																																																																																		obj13 = obj82;
																																																																																																																																		object obj83 = default;
																																																																																																																																		obj15 = obj83;
																																																																																																																																	}
																																																																																																																																}
																																																																																																																																else
																																																																																																																																{
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																	object obj84 = default;
																																																																																																																																	obj13 = obj84;
																																																																																																																																	object obj85 = default;
																																																																																																																																	obj15 = obj85;
																																																																																																																																}
																																																																																																																															}
																																																																																																																															else
																																																																																																																															{
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																																object obj86 = default;
																																																																																																																																obj13 = obj86;
																																																																																																																																object obj87 = default;
																																																																																																																																obj15 = obj87;
																																																																																																																															}
																																																																																																																															goto IL_6237;
																																																																																																																														}
																																																																																																																													}
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																													object obj88 = default;
																																																																																																																													obj13 = obj88;
																																																																																																																													object obj89 = default;
																																																																																																																													obj15 = obj89;
																																																																																																																												}
																																																																																																																												else
																																																																																																																												{
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																													object obj90 = default;
																																																																																																																													obj13 = obj90;
																																																																																																																													object obj91 = default;
																																																																																																																													obj15 = obj91;
																																																																																																																												}
																																																																																																																												goto IL_6237;
																																																																																																																											}
																																																																																																																										}
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																										object obj92 = default;
																																																																																																																										obj13 = obj92;
																																																																																																																										object obj93 = default;
																																																																																																																										obj15 = obj93;
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																										object obj94 = default;
																																																																																																																										obj13 = obj94;
																																																																																																																										object obj95 = default;
																																																																																																																										obj15 = obj95;
																																																																																																																									}
																																																																																																																								}
																																																																																																																								else
																																																																																																																								{
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																									object obj96 = default;
																																																																																																																									obj13 = obj96;
																																																																																																																									object obj97 = default;
																																																																																																																									obj15 = obj97;
																																																																																																																								}
																																																																																																																							}
																																																																																																																							else
																																																																																																																							{
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																								object obj98 = default;
																																																																																																																								obj13 = obj98;
																																																																																																																								object obj99 = default;
																																																																																																																								obj15 = obj99;
																																																																																																																							}
																																																																																																																						}
																																																																																																																						else
																																																																																																																						{
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																							object obj100 = default;
																																																																																																																							obj13 = obj100;
																																																																																																																							object obj101 = default;
																																																																																																																							obj15 = obj101;
																																																																																																																						}
																																																																																																																					}
																																																																																																																					else
																																																																																																																					{
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																						object obj102 = default;
																																																																																																																						obj13 = obj102;
																																																																																																																						object obj103 = default;
																																																																																																																						obj15 = obj103;
																																																																																																																					}
																																																																																																																				}
																																																																																																																				else
																																																																																																																				{
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																					object obj104 = default;
																																																																																																																					obj13 = obj104;
																																																																																																																					object obj105 = default;
																																																																																																																					obj15 = obj105;
																																																																																																																				}
																																																																																																																			}
																																																																																																																			else
																																																																																																																			{
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																				object obj106 = default;
																																																																																																																				obj13 = obj106;
																																																																																																																				object obj107 = default;
																																																																																																																				obj15 = obj107;
																																																																																																																			}
																																																																																																																		}
																																																																																																																		else
																																																																																																																		{
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																			object obj108 = default;
																																																																																																																			obj13 = obj108;
																																																																																																																			object obj109 = default;
																																																																																																																			obj15 = obj109;
																																																																																																																		}
																																																																																																																	}
																																																																																																																	else
																																																																																																																	{
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																		object obj110 = default;
																																																																																																																		obj13 = obj110;
																																																																																																																		object obj111 = default;
																																																																																																																		obj15 = obj111;
																																																																																																																	}
																																																																																																																}
																																																																																																																else
																																																																																																																{
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																	object obj112 = default;
																																																																																																																	obj13 = obj112;
																																																																																																																	object obj113 = default;
																																																																																																																	obj15 = obj113;
																																																																																																																}
																																																																																																															}
																																																																																																															else
																																																																																																															{
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																																object obj114 = default;
																																																																																																																obj13 = obj114;
																																																																																																																object obj115 = default;
																																																																																																																obj15 = obj115;
																																																																																																															}
																																																																																																														}
																																																																																																														else
																																																																																																														{
																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																															object obj116 = default;
																																																																																																															obj13 = obj116;
																																																																																																															object obj117 = default;
																																																																																																															obj15 = obj117;
																																																																																																														}
																																																																																																													}
																																																																																																													else
																																																																																																													{
																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																														object obj118 = default;
																																																																																																														obj13 = obj118;
																																																																																																														object obj119 = default;
																																																																																																														obj15 = obj119;
																																																																																																													}
																																																																																																												}
																																																																																																												else
																																																																																																												{
																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																													object obj120 = default;
																																																																																																													obj13 = obj120;
																																																																																																													object obj121 = default;
																																																																																																													obj15 = obj121;
																																																																																																												}
																																																																																																											}
																																																																																																											else
																																																																																																											{
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																												object obj122 = default;
																																																																																																												obj13 = obj122;
																																																																																																												object obj123 = default;
																																																																																																												obj15 = obj123;
																																																																																																											}
																																																																																																										}
																																																																																																										else
																																																																																																										{
																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																											object obj124 = default;
																																																																																																											obj13 = obj124;
																																																																																																											object obj125 = default;
																																																																																																											obj15 = obj125;
																																																																																																										}
																																																																																																									}
																																																																																																									else
																																																																																																									{
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																										object obj126 = default;
																																																																																																										obj13 = obj126;
																																																																																																										object obj127 = default;
																																																																																																										obj15 = obj127;
																																																																																																									}
																																																																																																								}
																																																																																																								else
																																																																																																								{
																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																									object obj128 = default;
																																																																																																									obj13 = obj128;
																																																																																																									object obj129 = default;
																																																																																																									obj15 = obj129;
																																																																																																								}
																																																																																																							}
																																																																																																							else
																																																																																																							{
																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																								object obj130 = default;
																																																																																																								obj13 = obj130;
																																																																																																								object obj131 = default;
																																																																																																								obj15 = obj131;
																																																																																																							}
																																																																																																						}
																																																																																																						else
																																																																																																						{
																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																							object obj132 = default;
																																																																																																							obj13 = obj132;
																																																																																																							object obj133 = default;
																																																																																																							obj15 = obj133;
																																																																																																						}
																																																																																																					}
																																																																																																					else
																																																																																																					{
																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																						object obj134 = default;
																																																																																																						obj13 = obj134;
																																																																																																						object obj135 = default;
																																																																																																						obj15 = obj135;
																																																																																																					}
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																					object obj136 = default;
																																																																																																					obj13 = obj136;
																																																																																																					object obj137 = default;
																																																																																																					obj15 = obj137;
																																																																																																				}
																																																																																																			}
																																																																																																			else
																																																																																																			{
																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																				object obj138 = default;
																																																																																																				obj13 = obj138;
																																																																																																				object obj139 = default;
																																																																																																				obj15 = obj139;
																																																																																																			}
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																			object obj140 = default;
																																																																																																			obj13 = obj140;
																																																																																																			object obj141 = default;
																																																																																																			obj15 = obj141;
																																																																																																		}
																																																																																																	}
																																																																																																	else
																																																																																																	{
																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																		object obj142 = default;
																																																																																																		obj13 = obj142;
																																																																																																		object obj143 = default;
																																																																																																		obj15 = obj143;
																																																																																																	}
																																																																																																}
																																																																																																else
																																																																																																{
																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																	object obj144 = default;
																																																																																																	obj13 = obj144;
																																																																																																	object obj145 = default;
																																																																																																	obj15 = obj145;
																																																																																																}
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																																object obj146 = default;
																																																																																																obj13 = obj146;
																																																																																																object obj147 = default;
																																																																																																obj15 = obj147;
																																																																																															}
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																															object obj148 = default;
																																																																																															obj13 = obj148;
																																																																																															object obj149 = default;
																																																																																															obj15 = obj149;
																																																																																														}
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																														object obj150 = default;
																																																																																														obj13 = obj150;
																																																																																														object obj151 = default;
																																																																																														obj15 = obj151;
																																																																																													}
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																													object obj152 = default;
																																																																																													obj13 = obj152;
																																																																																													object obj153 = default;
																																																																																													obj15 = obj153;
																																																																																												}
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																												object obj154 = default;
																																																																																												obj13 = obj154;
																																																																																												object obj155 = default;
																																																																																												obj15 = obj155;
																																																																																											}
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																											object obj156 = default;
																																																																																											obj13 = obj156;
																																																																																											object obj157 = default;
																																																																																											obj15 = obj157;
																																																																																										}
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																										object obj158 = default;
																																																																																										obj13 = obj158;
																																																																																										object obj159 = default;
																																																																																										obj15 = obj159;
																																																																																									}
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																									object obj160 = default;
																																																																																									obj13 = obj160;
																																																																																									object obj161 = default;
																																																																																									obj15 = obj161;
																																																																																								}
																																																																																							}
																																																																																							else
																																																																																							{
																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																								object obj162 = default;
																																																																																								obj13 = obj162;
																																																																																								object obj163 = default;
																																																																																								obj15 = obj163;
																																																																																							}
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																							object obj164 = default;
																																																																																							obj13 = obj164;
																																																																																							object obj165 = default;
																																																																																							obj15 = obj165;
																																																																																						}
																																																																																					}
																																																																																					else
																																																																																					{
																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																						object obj166 = default;
																																																																																						obj13 = obj166;
																																																																																						object obj167 = default;
																																																																																						obj15 = obj167;
																																																																																					}
																																																																																					goto IL_6237;
																																																																																				}
																																																																																			}
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																			object obj168 = default;
																																																																																			obj13 = obj168;
																																																																																			object obj169 = default;
																																																																																			obj15 = obj169;
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																			object obj170 = default;
																																																																																			obj13 = obj170;
																																																																																			object obj171 = default;
																																																																																			obj15 = obj171;
																																																																																		}
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																		object obj172 = default;
																																																																																		obj13 = obj172;
																																																																																		object obj173 = default;
																																																																																		obj15 = obj173;
																																																																																	}
																																																																																}
																																																																																else
																																																																																{
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																	object obj174 = default;
																																																																																	obj13 = obj174;
																																																																																	object obj175 = default;
																																																																																	obj15 = obj175;
																																																																																}
																																																																															}
																																																																															else
																																																																															{
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																																object obj176 = default;
																																																																																obj13 = obj176;
																																																																																object obj177 = default;
																																																																																obj15 = obj177;
																																																																															}
																																																																															goto IL_6237;
																																																																														}
																																																																													}
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																													object obj178 = default;
																																																																													obj13 = obj178;
																																																																													object obj179 = default;
																																																																													obj15 = obj179;
																																																																												}
																																																																												else
																																																																												{
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																													object obj180 = default;
																																																																													obj13 = obj180;
																																																																													object obj181 = default;
																																																																													obj15 = obj181;
																																																																												}
																																																																											}
																																																																											else
																																																																											{
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																												object obj182 = default;
																																																																												obj13 = obj182;
																																																																												object obj183 = default;
																																																																												obj15 = obj183;
																																																																											}
																																																																										}
																																																																										else
																																																																										{
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																											object obj184 = default;
																																																																											obj13 = obj184;
																																																																											object obj185 = default;
																																																																											obj15 = obj185;
																																																																										}
																																																																									}
																																																																									else
																																																																									{
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																										object obj186 = default;
																																																																										obj13 = obj186;
																																																																										object obj187 = default;
																																																																										obj15 = obj187;
																																																																									}
																																																																								}
																																																																								else
																																																																								{
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																									object obj188 = default;
																																																																									obj13 = obj188;
																																																																									object obj189 = default;
																																																																									obj15 = obj189;
																																																																								}
																																																																							}
																																																																							else
																																																																							{
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																								object obj190 = default;
																																																																								obj13 = obj190;
																																																																								object obj191 = default;
																																																																								obj15 = obj191;
																																																																							}
																																																																						}
																																																																						else
																																																																						{
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																							object obj192 = default;
																																																																							obj13 = obj192;
																																																																							object obj193 = default;
																																																																							obj15 = obj193;
																																																																						}
																																																																					}
																																																																					else
																																																																					{
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																						object obj194 = default;
																																																																						obj13 = obj194;
																																																																						object obj195 = default;
																																																																						obj15 = obj195;
																																																																					}
																																																																				}
																																																																				else
																																																																				{
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																					object obj196 = default;
																																																																					obj13 = obj196;
																																																																					object obj197 = default;
																																																																					obj15 = obj197;
																																																																				}
																																																																			}
																																																																			else
																																																																			{
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																				object obj198 = default;
																																																																				obj13 = obj198;
																																																																				object obj199 = default;
																																																																				obj15 = obj199;
																																																																			}
																																																																		}
																																																																		else
																																																																		{
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																			object obj200 = default;
																																																																			obj13 = obj200;
																																																																			object obj201 = default;
																																																																			obj15 = obj201;
																																																																		}
																																																																	}
																																																																	else
																																																																	{
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																		object obj202 = default;
																																																																		obj13 = obj202;
																																																																		object obj203 = default;
																																																																		obj15 = obj203;
																																																																	}
																																																																}
																																																																else
																																																																{
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																	object obj204 = default;
																																																																	obj13 = obj204;
																																																																	object obj205 = default;
																																																																	obj15 = obj205;
																																																																}
																																																															}
																																																															else
																																																															{
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																																object obj206 = default;
																																																																obj13 = obj206;
																																																																object obj207 = default;
																																																																obj15 = obj207;
																																																															}
																																																														}
																																																														else
																																																														{
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																															object obj208 = default;
																																																															obj13 = obj208;
																																																															object obj209 = default;
																																																															obj15 = obj209;
																																																														}
																																																													}
																																																													else
																																																													{
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																														object obj210 = default;
																																																														obj13 = obj210;
																																																														object obj211 = default;
																																																														obj15 = obj211;
																																																													}
																																																												}
																																																												else
																																																												{
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																													object obj212 = default;
																																																													obj13 = obj212;
																																																													object obj213 = default;
																																																													obj15 = obj213;
																																																												}
																																																											}
																																																											else
																																																											{
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																												object obj214 = default;
																																																												obj13 = obj214;
																																																												object obj215 = default;
																																																												obj15 = obj215;
																																																											}
																																																										}
																																																										else
																																																										{
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																											object obj216 = default;
																																																											obj13 = obj216;
																																																											object obj217 = default;
																																																											obj15 = obj217;
																																																										}
																																																									}
																																																									else
																																																									{
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																										object obj218 = default;
																																																										obj13 = obj218;
																																																										object obj219 = default;
																																																										obj15 = obj219;
																																																									}
																																																								}
																																																								else
																																																								{
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																									object obj220 = default;
																																																									obj13 = obj220;
																																																									object obj221 = default;
																																																									obj15 = obj221;
																																																								}
																																																							}
																																																							else
																																																							{
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																								object obj222 = default;
																																																								obj13 = obj222;
																																																								object obj223 = default;
																																																								obj15 = obj223;
																																																							}
																																																						}
																																																						else
																																																						{
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																							object obj224 = default;
																																																							obj13 = obj224;
																																																							object obj225 = default;
																																																							obj15 = obj225;
																																																						}
																																																					}
																																																					else
																																																					{
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																						object obj226 = default;
																																																						obj13 = obj226;
																																																						object obj227 = default;
																																																						obj15 = obj227;
																																																					}
																																																				}
																																																				else
																																																				{
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																					object obj228 = default;
																																																					obj13 = obj228;
																																																					object obj229 = default;
																																																					obj15 = obj229;
																																																				}
																																																			}
																																																			else
																																																			{
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																				object obj230 = default;
																																																				obj13 = obj230;
																																																				object obj231 = default;
																																																				obj15 = obj231;
																																																			}
																																																		}
																																																		else
																																																		{
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																			object obj232 = default;
																																																			obj13 = obj232;
																																																			object obj233 = default;
																																																			obj15 = obj233;
																																																		}
																																																	}
																																																	else
																																																	{
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																		object obj234 = default;
																																																		obj13 = obj234;
																																																		object obj235 = default;
																																																		obj15 = obj235;
																																																	}
																																																}
																																																else
																																																{
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																	object obj236 = default;
																																																	obj13 = obj236;
																																																	object obj237 = default;
																																																	obj15 = obj237;
																																																}
																																															}
																																															else
																																															{
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																																object obj238 = default;
																																																obj13 = obj238;
																																																object obj239 = default;
																																																obj15 = obj239;
																																															}
																																														}
																																														else
																																														{
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																															object obj240 = default;
																																															obj13 = obj240;
																																															object obj241 = default;
																																															obj15 = obj241;
																																														}
																																													}
																																													else
																																													{
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																														object obj242 = default;
																																														obj13 = obj242;
																																														object obj243 = default;
																																														obj15 = obj243;
																																													}
																																												}
																																												else
																																												{
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																													object obj244 = default;
																																													obj13 = obj244;
																																													object obj245 = default;
																																													obj15 = obj245;
																																												}
																																											}
																																											else
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																												object obj246 = default;
																																												obj13 = obj246;
																																												object obj247 = default;
																																												obj15 = obj247;
																																											}
																																										}
																																										else
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																											object obj248 = default;
																																											obj13 = obj248;
																																											object obj249 = default;
																																											obj15 = obj249;
																																										}
																																									}
																																									else
																																									{
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																										object obj250 = default;
																																										obj13 = obj250;
																																										object obj251 = default;
																																										obj15 = obj251;
																																									}
																																								}
																																								else
																																								{
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																									object obj252 = default;
																																									obj13 = obj252;
																																									object obj253 = default;
																																									obj15 = obj253;
																																								}
																																							}
																																							else
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																								object obj254 = default;
																																								obj13 = obj254;
																																								object obj255 = default;
																																								obj15 = obj255;
																																							}
																																						}
																																						else
																																						{
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																							object obj256 = default;
																																							obj13 = obj256;
																																							object obj257 = default;
																																							obj15 = obj257;
																																						}
																																					}
																																					else
																																					{
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																						object obj258 = default;
																																						obj13 = obj258;
																																						object obj259 = default;
																																						obj15 = obj259;
																																					}
																																				}
																																				else
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																					object obj260 = default;
																																					obj13 = obj260;
																																					object obj261 = default;
																																					obj15 = obj261;
																																				}
																																			}
																																			else
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																				object obj262 = default;
																																				obj13 = obj262;
																																				object obj263 = default;
																																				obj15 = obj263;
																																			}
																																		}
																																		else
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																			object obj264 = default;
																																			obj13 = obj264;
																																			object obj265 = default;
																																			obj15 = obj265;
																																		}
																																	}
																																	else
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																		object obj266 = default;
																																		obj13 = obj266;
																																		object obj267 = default;
																																		obj15 = obj267;
																																	}
																																}
																																else
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																	object obj268 = default;
																																	obj13 = obj268;
																																	object obj269 = default;
																																	obj15 = obj269;
																																}
																															}
																															else
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																																object obj270 = default;
																																obj13 = obj270;
																																object obj271 = default;
																																obj15 = obj271;
																															}
																														}
																														else
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																															object obj272 = default;
																															obj13 = obj272;
																															object obj273 = default;
																															obj15 = obj273;
																														}
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																														object obj274 = default;
																														obj13 = obj274;
																														object obj275 = default;
																														obj15 = obj275;
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																													object obj276 = default;
																													obj13 = obj276;
																													object obj277 = default;
																													obj15 = obj277;
																												}
																											}
																											else
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																												object obj278 = default;
																												obj13 = obj278;
																												object obj279 = default;
																												obj15 = obj279;
																											}
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																											object obj280 = default;
																											obj13 = obj280;
																											object obj281 = default;
																											obj15 = obj281;
																										}
																									}
																									else
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																										object obj282 = default;
																										obj13 = obj282;
																										object obj283 = default;
																										obj15 = obj283;
																									}
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																									object obj284 = default;
																									obj13 = obj284;
																									object obj285 = default;
																									obj15 = obj285;
																								}
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																								object obj286 = default;
																								obj13 = obj286;
																								object obj287 = default;
																								obj15 = obj287;
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																							object obj288 = default;
																							obj13 = obj288;
																							object obj289 = default;
																							obj15 = obj289;
																						}
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																						object obj290 = default;
																						obj13 = obj290;
																						object obj291 = default;
																						obj15 = obj291;
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																					object obj292 = default;
																					obj13 = obj292;
																					object obj293 = default;
																					obj15 = obj293;
																				}
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																				object obj294 = default;
																				obj13 = obj294;
																				object obj295 = default;
																				obj15 = obj295;
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																			object obj296 = default;
																			obj13 = obj296;
																			object obj297 = default;
																			obj15 = obj297;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																		object obj298 = default;
																		obj13 = obj298;
																		object obj299 = default;
																		obj15 = obj299;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																	object obj300 = default;
																	obj13 = obj300;
																	object obj301 = default;
																	obj15 = obj301;
																}
																goto IL_6237;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														object obj302 = default;
														obj13 = obj302;
														object obj303 = default;
														obj15 = obj303;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														object obj304 = default;
														obj13 = obj304;
														object obj305 = default;
														obj15 = obj305;
													}
													goto IL_6237;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
											object obj306 = default;
											obj13 = obj306;
											object obj307 = default;
											obj15 = obj307;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
											object obj308 = default;
											obj13 = obj308;
											object obj309 = default;
											obj15 = obj309;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										object obj310 = default;
										obj13 = obj310;
										object obj311 = default;
										obj15 = obj311;
									}
									goto IL_6237;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							object obj312 = default;
							obj13 = obj312;
							object obj313 = default;
							obj15 = obj313;
							goto IL_6237;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj314 = default;
					obj13 = obj314;
					object obj315 = default;
					obj15 = obj315;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj316 = default;
					obj13 = obj316;
					object obj317 = default;
					obj15 = obj317;
				}
				goto IL_6237;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj318 = default;
		obj13 = obj318;
		object obj319 = default;
		obj15 = obj319;
		goto IL_6237;
		IL_5076:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj324;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+10]");
				_ = 0;
				object obj320 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+8]");
				obj320 = 0;
				object obj321 = obj + 56;
				obj = (Enum)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+18]");
				_ = 0;
				object obj323 = default;
				object obj325 = default;
				object obj326 = default;
				object obj327 = default;
				object obj328 = default;
				object obj329 = default;
				object obj330 = default;
				while (true)
				{
					_ = 0;
					object obj322 = obj + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						if (obj323 == null)
						{
							obj324 = 19;
							goto IL_5444;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+44]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+18]");
							_ = 0;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag46 = obj325 != obj326;
					obj13 = obj325;
					obj15 = obj327;
					if (flag46)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					obj = (Enum)obj328;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						obj324 = 0;
						goto IL_5444;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj13 = obj329;
					obj15 = obj330;
					break;
					IL_5444:
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_548d;
					}
					goto IL_5506;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					goto IL_6452;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj331 = default;
				obj13 = obj331;
				object obj332 = default;
				obj15 = obj332;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj333 = default;
			obj13 = obj333;
			object obj334 = default;
			obj15 = obj334;
		}
		goto IL_6237;
		IL_5506:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj335 = default;
		obj13 = obj335;
		object obj336 = default;
		obj15 = obj336;
		goto IL_6237;
		IL_4635:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Dictionary<Hoverboards.BoardType, bool> hoverboardUnlockStatus = default;
				_hoverboardUnlockStatus = hoverboardUnlockStatus;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Dictionary<string, string> inappHistory = default;
						_inappHistory = inappHistory;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Hoverboards.BoardType boardType = default;
							_currentHoverboard = boardType;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Hoverboards.BoardType boardType2 = default;
								_previousHoverboard = boardType2;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									int num33 = default;
									_numberOfBreadCrumbsShownOnFrontPage = num33;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										int unreportedGames = default;
										_unreportedGames = unreportedGames;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D13");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											_ = 0;
											object obj337 = obj + 24;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5BA");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+18]");
												_unreportedGamesTimestamp = (DateTime)0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														Dictionary<Characters.CharacterType, bool> hasCharacterBeenSeen = default;
														_hasCharacterBeenSeen = hasCharacterBeenSeen;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																Dictionary<Characters.CharacterType, int[]> characterThemesUnlocked = default;
																_characterThemesUnlocked = characterThemesUnlocked;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		Dictionary<Characters.CharacterType, int> lastSelectedThemes = default;
																		_lastSelectedThemes = lastSelectedThemes;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			bool flag47 = default;
																			_neverAskForRating = flag47;
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				string text13 = default;
																				_lastVersionRated = text13;
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						Dictionary<Characters.CharacterType, int[]> characterThemesSeen = default;
																						_characterThemesSeen = characterThemesSeen;
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						if ((nint)0 != 1)
																						{
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 != 1)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+10]");
																								_ = 0;
																								object obj338 = obj - -64;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+8]");
																								obj338 = 0;
																								object obj339 = obj + 56;
																								obj = (Enum)0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+18]");
																								_ = 0;
																								object obj341 = default;
																								object obj342 = default;
																								object obj343 = default;
																								object obj344 = default;
																								object obj345 = default;
																								object obj346 = default;
																								object obj347 = default;
																								while (true)
																								{
																									_ = 0;
																									object obj340 = obj + 56;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																									if ((nint)0 == 1)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																									}
																									else
																									{
																										if (obj341 == null)
																										{
																											goto IL_502d;
																										}
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+44]");
																										_ = 0;
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																										if ((nint)0 != 1)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+18]");
																											_ = 0;
																											_ = 0;
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																											if ((nint)0 != 1)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+30]");
																												if ((nint)0 == 4)
																												{
																													continue;
																												}
																												_ = 0;
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																												if ((nint)0 != 1)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+30]");
																													if ((nint)0 == 2)
																													{
																														continue;
																													}
																													_ = 0;
																													_ = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																													if ((nint)0 != 1)
																													{
																														_ = 0;
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																														if ((nint)0 != 1)
																														{
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																															if ((nint)0 != 1)
																															{
																																continue;
																															}
																														}
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																												}
																											}
																											else
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																											}
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																										}
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
																									bool flag48 = obj342 != obj343;
																									obj13 = obj342;
																									obj15 = obj344;
																									if (flag48)
																									{
																										break;
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
																									obj = (Enum)obj345;
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																									if ((nint)0 != 1)
																									{
																										goto IL_502d;
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																									obj13 = obj346;
																									obj15 = obj347;
																									break;
																									IL_502d:
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																									if ((nint)0 != 1)
																									{
																										goto IL_5076;
																									}
																									goto IL_514a;
																								}
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																								if ((nint)0 == 1)
																								{
																									goto IL_6452;
																								}
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																								object obj348 = default;
																								obj13 = obj348;
																								object obj349 = default;
																								obj15 = obj349;
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																							object obj350 = default;
																							obj13 = obj350;
																							object obj351 = default;
																							obj15 = obj351;
																						}
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																						object obj352 = default;
																						obj13 = obj352;
																						object obj353 = default;
																						obj15 = obj353;
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																					object obj354 = default;
																					obj13 = obj354;
																					object obj355 = default;
																					obj15 = obj355;
																				}
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																				object obj356 = default;
																				obj13 = obj356;
																				object obj357 = default;
																				obj15 = obj357;
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																			object obj358 = default;
																			obj13 = obj358;
																			object obj359 = default;
																			obj15 = obj359;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																		object obj360 = default;
																		obj13 = obj360;
																		object obj361 = default;
																		obj15 = obj361;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																	object obj362 = default;
																	obj13 = obj362;
																	object obj363 = default;
																	obj15 = obj363;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																object obj364 = default;
																obj13 = obj364;
																object obj365 = default;
																obj15 = obj365;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
															object obj366 = default;
															obj13 = obj366;
															object obj367 = default;
															obj15 = obj367;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														object obj368 = default;
														obj13 = obj368;
														object obj369 = default;
														obj15 = obj369;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
													object obj370 = default;
													obj13 = obj370;
													object obj371 = default;
													obj15 = obj371;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
												object obj372 = default;
												obj13 = obj372;
												object obj373 = default;
												obj15 = obj373;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
											object obj374 = default;
											obj13 = obj374;
											object obj375 = default;
											obj15 = obj375;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										object obj376 = default;
										obj13 = obj376;
										object obj377 = default;
										obj15 = obj377;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									object obj378 = default;
									obj13 = obj378;
									object obj379 = default;
									obj15 = obj379;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								object obj380 = default;
								obj13 = obj380;
								object obj381 = default;
								obj15 = obj381;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							object obj382 = default;
							obj13 = obj382;
							object obj383 = default;
							obj15 = obj383;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						object obj384 = default;
						obj13 = obj384;
						object obj385 = default;
						obj15 = obj385;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj386 = default;
					obj13 = obj386;
					object obj387 = default;
					obj15 = obj387;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj388 = default;
				obj13 = obj388;
				object obj389 = default;
				obj15 = obj389;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj390 = default;
			obj13 = obj390;
			object obj391 = default;
			obj15 = obj391;
		}
		goto IL_6237;
		IL_548d:
		bool flag49 = (nint)obj324 != 19;
		if (obj324 == null)
		{
			flag49 = false;
		}
		if (!flag49)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_dataExists = true;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj392 = default;
			obj13 = obj392;
			object obj393 = default;
			obj15 = obj393;
			goto IL_6237;
		}
		return;
		IL_44e5:
		_ = 22;
		_ = -1;
		obj = (Enum)(object)typeof(Hoverboards.BoardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+54]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj394 = default;
				if (obj394 != null)
				{
					goto IL_4635;
				}
				_ = 22;
				_ = -1;
				obj = (Enum)(object)typeof(Hoverboards.BoardType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+54]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag50 = (nint)0 == 1;
					object obj396 = default;
					object obj395 = obj396;
					if (!flag50)
					{
						goto IL_4635;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj397 = default;
					obj13 = obj397;
					object obj398 = default;
					obj15 = obj398;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj399 = default;
					obj13 = obj399;
					object obj400 = default;
					obj15 = obj400;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj401 = default;
				obj13 = obj401;
				object obj402 = default;
				obj15 = obj402;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj403 = default;
			obj13 = obj403;
			object obj404 = default;
			obj15 = obj404;
		}
		goto IL_6237;
		IL_6398:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			object obj395 = obj32;
			if (obj33 != null)
			{
				goto IL_4635;
			}
			_ = 20;
			_ = -1;
			obj = (Enum)(object)typeof(Hoverboards.BoardType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+54]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj405 = default;
					bool flag51 = obj405 == null;
					bool flag52 = !flag51;
					obj395 = obj32;
					if (flag52)
					{
						goto IL_44e5;
					}
					_ = 20;
					_ = -1;
					obj = (Enum)(object)typeof(Hoverboards.BoardType);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+54]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag53 = (nint)0 == 1;
						object obj406 = default;
						obj395 = obj406;
						if (!flag53)
						{
							goto IL_44e5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						object obj407 = default;
						obj13 = obj407;
						object obj408 = default;
						obj15 = obj408;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						object obj409 = default;
						obj13 = obj409;
						object obj410 = default;
						obj15 = obj410;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj411 = default;
					obj13 = obj411;
					object obj412 = default;
					obj15 = obj412;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj413 = default;
				obj13 = obj413;
				object obj414 = default;
				obj15 = obj414;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj415 = default;
			obj13 = obj415;
			object obj416 = default;
			obj15 = obj416;
		}
		goto IL_6237;
		IL_6452:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_514a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj417 = default;
		obj13 = obj417;
		object obj418 = default;
		obj15 = obj418;
		goto IL_6237;
		IL_6237:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj419 = default;
		if (obj419 == obj13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj421 = default;
				object obj420 = obj421;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj422 = default;
					if (obj422 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+4]");
						object obj423 = (nint)0 << 2;
						object obj424 = obj4 + obj423;
						obj424 = obj421;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+4]");
						object obj425 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+4]");
						object obj426 = (nint)0 << 2;
						object obj427 = obj426 + obj4;
						object obj428 = obj427 - 4;
						object obj429 = obj428;
						bool flag54 = obj428 == null;
						string text14 = null;
						string text15 = "Error loading player info: ";
						if (!flag54)
						{
							object obj430 = obj429;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2050 @ S1_v100+D4] (should have been resolved before IL gen)");
							string text16 = default;
							text14 = text16;
							text15 = "Error loading player info: ";
						}
						string text17 = text15 + text14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						InitNew();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
						object obj431 = default;
						if (obj431 != null)
						{
							if (PlayerPrefs.HasKey("playerinfo_filenotfound_once"))
							{
								object obj432 = obj429;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2158 @ S1_v95+E4] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								string stackTrace = Utils.stackTrace;
								string text19 = default;
								string text18 = text19 + " \n Stacktrace: " + stackTrace;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
							}
							else
							{
								PlayerPrefs.SetInt("playerinfo_filenotfound_once", 1);
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+4]");
							object obj433 = -1;
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj434 = obj421;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_6452;
			}
			object obj435 = default;
			obj15 = obj435;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_6452;
	}

	private static string GetStringFromRewards(List<CelebrationReward> rewards)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_020f: Expected I, but got Obj
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_027e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		string text = default;
		string result = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_01ef;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 != obj8;
			object obj9 = obj10;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_01ef;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_01ef:
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2386");
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v26 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			int num2 = text.LastIndexOf(';');
			if (num2 >= 0)
			{
				StringBuilder stringBuilder2 = stringBuilder.Remove(num2, 1);
			}
			nint num3 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ S1_v32 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			return result;
		}
		_ = 0;
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		string result2 = default;
		return result2;
	}

	private static List<CelebrationReward> GetRewardsFromString(string rewardsAsString)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I
		List<CelebrationReward> list = default;
		list._002Ector();
		object obj;
		if (rewardsAsString != null)
		{
			obj = 0;
			if (rewardsAsString._stringLength != 0)
			{
				goto IL_0144;
			}
		}
		obj = 1;
		goto IL_0144;
		IL_0144:
		if (obj == null)
		{
			string[] array = rewardsAsString.Split(';');
			object obj2 = 0;
			CelebrationReward celebrationReward = default;
			while ((nint)obj2 < array.Length)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v19+10]");
				string text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v19+10]");
				object obj5;
				if ((nint)0 != 0)
				{
					obj5 = 0;
					if (text._stringLength != 0)
					{
						goto IL_0157;
					}
				}
				obj5 = 1;
				goto IL_0157;
				IL_0157:
				if (obj5 == null)
				{
					celebrationReward._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v19+10]");
					celebrationReward.PopulateFromString((string)0);
					list.Add(celebrationReward);
				}
				object obj6 = obj2 + 1;
				obj2 = obj6;
			}
		}
		return list;
	}

	public unsafe void InitNew()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ad3: Expected VT, but got I4
		//IL_0022: Expected I4, but got I8
		//IL_00de: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_041f: Expected Obj, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_051a: Expected Obj, but got I
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected Obj, but got Unknown
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected VT, but got Unknown
		//IL_07e9: Expected I8, but got I4
		//IL_07e4: Expected native int or pointer, but got VT
		//IL_0800: Expected VT, but got I
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_0717: Expected Obj, but got I
		//IL_08f9: Expected I8, but got I4
		//IL_090f: Expected I8, but got I4
		//IL_091a: Expected I8, but got I4
		//IL_0925: Expected I8, but got I4
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected VT, but got Unknown
		//IL_0958: Expected Ref, but got VT
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected VT, but got Unknown
		//IL_09af: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		amountOfCoins = 100;
		_highScore = 0;
		_dailyWord = string.Empty;
		_dailyWordUnlockedMask = (IntMask)0;
		DateTime utcNow = CDateTime.UtcNow;
		_dailyWordPayedOut = false;
		_dailyWordExpireTime = utcNow;
		_dailyWordInRow = 0;
		_hasReceivedFirstMBKey = false;
		_amountOfSuperMysteryBoxesOpened = 0;
		_amountOfMysteryBoxesOpened = 0;
		_lastTopRunResultAwardedID = string.Empty;
		_pendingTopRunResultID = string.Empty;
		_lastWeekMedalWasShown = -1;
		_pendingTopRunResultsWeek = -1;
		_pendingTopRunResultsScore = -1;
		_amountOfSeasonalEggs = 0;
		_weeklyChallangeData = string.Empty;
		amountOfKeys = 2;
		_currentMissionSet = -1;
		_currentCharacter = 0;
		if (~(_isTutorialCompleted ? 1u : 0u) == 0)
		{
			_dirty = true;
			_isTutorialCompleted = false;
		}
		_inAppLegacyPurchaseCount = 0;
		_hasMadeOneValidPurchase = false;
		_inAppNonconsumablePurchaseCount = 0;
		_earnCurrenyData = string.Empty;
		_hasPayedOutFacebook = false;
		if (~(_hasDoubleCoinsUpgrade ? 1u : 0u) == 0)
		{
			_dirty = true;
			_hasDoubleCoinsUpgrade = false;
		}
		_lastPurchasedBundle = InAppData.BundleTier.None;
		_hasCollectedFromFriends = false;
		_lastShownTopRunIntroPopupVersionNumber = 0;
		_numberOfRunsSinceLastGuideline = 0;
		_hasShownDuelIntroductionPopup = false;
		_hasShownAwardsIntroductionPopup = false;
		_ratingAskCounter = 0;
		_shouldShowDuelIntroductionPopup = true;
		_hasShownVoucherPopupInShop = false;
		_isSaveMePopupEnabled = false;
		_hasShownMission1Popup = false;
		_hasShownMission2Popup = false;
		_latestAvailableAssetBundlesVersion = 0;
		_ = 0;
		_shouldUseAlternativeHuntPrizes = string.Empty;
		_numberOfRuns = 0;
		DateTime now = CDateTime.Now;
		_lastKnownServerTime = now;
		_lastTimeAVideoForKeysWasSeen = DateTime.MinValue;
		_weeklyGiftEndTime = DateTime.MinValue;
		DateTime now2 = CDateTime.Now;
		_lastTimeAppWasUpdatedOrInstalled = now2;
		_firstInstallDate = DateTime.MinValue;
		_firstInstalledVersion = string.Empty;
		object obj3 = default;
		object obj5 = default;
		while (true)
		{
			int[] collectedCharacterTokens = _collectedCharacterTokens;
			if (collectedCharacterTokens.Length <= (nint)obj3)
			{
				break;
			}
			object obj4 = obj5 << 2;
			object obj6 = (object)collectedCharacterTokens + obj4;
			_ = 0;
			obj3 = obj5 + 1;
		}
		object obj7 = 0;
		while (true)
		{
			bool[] unlockedTrophies = _unlockedTrophies;
			if (unlockedTrophies.Length <= (nint)obj7)
			{
				break;
			}
			object obj8 = obj7 + (object)unlockedTrophies;
			_ = 0;
			object obj9 = obj7 + 1;
			obj7 = obj9;
		}
		object obj10 = 0;
		while (true)
		{
			int[] array = _achievementProgress;
			if (array.Length <= (nint)obj10)
			{
				break;
			}
			object obj11 = obj10 << 2;
			object obj12 = (object)array + obj11;
			_ = 0;
			object obj13 = obj10 + 1;
			obj10 = obj13;
		}
		Dictionary<PowerupType, int> upgradeAmounts = _upgradeAmounts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v87 (System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v87 (System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>)+18]");
		object obj14 = num - 0;
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>>)+4] (should have been resolved before IL gen)");
		object obj15 = obj + 8;
		Dictionary<PowerupType, int>.KeyCollection keys = _upgradeAmounts.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj16 = obj + 32;
		obj = obj16;
		_ = 0;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		object obj22 = default;
		object obj23 = default;
		Dictionary<PowerupType, int> upgradeTiers;
		Dictionary<PowerupType, int> dictionary = default;
		object obj30 = default;
		Dictionary<PowerupType, int> dictionary2 = default;
		object obj31 = default;
		object obj32 = default;
		object obj33 = default;
		object obj34 = default;
		while (true)
		{
			_ = 0;
			object obj17 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj18 == null)
				{
					goto IL_03d6;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					if ((nint)0 == 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj19 != obj20;
			object obj21 = obj22;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_03d6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj21 = obj23;
			}
			_ = 0;
			object obj24 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			PlayerInfo playerInfo = (PlayerInfo)0;
			upgradeTiers = dictionary;
			if (flag2)
			{
				goto IL_072d;
			}
			goto IL_0a89;
			IL_03d6:
			object obj25 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @382D");
			_upgradeAmounts = dictionary;
			Dictionary<PowerupType, int> upgradeTiers2 = _upgradeTiers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v221 (System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>)+10]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v221 (System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>)+18]");
			object obj26 = num4 - 0;
			nint num5 = 0;
			nint num6 = 0;
			IntPtr intPtr2 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v450 @ S4_v49 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Int32>>>)+4] (should have been resolved before IL gen)");
			object obj27 = obj + 8;
			Dictionary<PowerupType, int>.KeyCollection keys2 = _upgradeTiers.Keys;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj28 = obj + 32;
			obj = obj28;
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj29 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					bool flag3 = obj30 == null;
					upgradeTiers = dictionary2;
					if (flag3)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj31 == obj32;
				bool flag5 = !flag4;
				obj21 = obj33;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					upgradeTiers = dictionary2;
					if (flag6)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj21 = obj34;
				}
				goto IL_06c9;
			}
			break;
			IL_072d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_06c9:
			_ = 0;
			object obj35 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			playerInfo = (PlayerInfo)0;
			upgradeTiers = dictionary2;
			if (!flag7)
			{
				goto IL_072d;
			}
			goto IL_0a89;
			IL_0a89:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj36 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @382D");
		_upgradeTiers = upgradeTiers;
		_missionCompletedSum = 0;
		nint num7 = 0;
		nint num8 = 0;
		IntPtr intPtr3 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v698 @ S4_v11 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Hoverboards.BoardType, bool> hasHoverboardBeenSeen = default;
		_hasHoverboardBeenSeen = hasHoverboardBeenSeen;
		nint num9 = 0;
		nint num10 = 0;
		IntPtr intPtr4 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v720 @ S4_v16 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Hoverboards.BoardType, bool> hoverboardUnlockStatus = default;
		_hoverboardUnlockStatus = hoverboardUnlockStatus;
		nint num11 = 0;
		nint num12 = 0;
		IntPtr intPtr5 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v753 @ S4_v21 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> inappHistory = default;
		_inappHistory = inappHistory;
		_numberOfBreadCrumbsShownOnFrontPage = 0;
		_currentHoverboard = Hoverboards.BoardType.normal;
		_unreportedGames = 0;
		_ = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(0L);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_unreportedGamesTimestamp = (DateTime)0;
		nint num13 = 0;
		nint num14 = 0;
		IntPtr intPtr6 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v803 @ S4_v26 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, bool> hasCharacterBeenSeen = default;
		_hasCharacterBeenSeen = hasCharacterBeenSeen;
		_neverAskForRating = false;
		_lastVersionRated = string.Empty;
		nint num15 = 0;
		nint num16 = 0;
		IntPtr intPtr7 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v831 @ S4_v31 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, int[]> characterThemesUnlocked = default;
		_characterThemesUnlocked = characterThemesUnlocked;
		nint num17 = 0;
		nint num18 = 0;
		IntPtr intPtr8 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v851 @ S4_v36 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, int> lastSelectedThemes = default;
		_lastSelectedThemes = lastSelectedThemes;
		nint num19 = 0;
		nint num20 = 0;
		IntPtr intPtr9 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v871 @ S4_v41 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, int[]> characterThemesSeen = default;
		_characterThemesSeen = characterThemesSeen;
		List<CelebrationReward> list = default;
		list._002Ector();
		_pendingRewards = list;
		_remoteNotificationsEnabled = true;
		_shouldRestoreAfterEvent = false;
		_lastEventID = 0L;
		_lastEventItemID = string.Empty;
		_lastTimeEventPopupHasBeenForcedShown = 0L;
		_lastTimeAnEventHasBeenTried = 0L;
		_lastTimeAnEventWasStarted = 0L;
		DateTime utcNow2 = CDateTime.UtcNow;
		DateTime dateTime2 = (DateTime)(obj + 24);
		DateTime dailyInterstitialExpireTime = ((DateTime*)dateTime2)->AddHours(24.0);
		_dailyInterstitialExpireTime = dailyInterstitialExpireTime;
		_lastTimeInterstitialWasSeen = DateTime.MinValue;
		_lastTimeInterstitialProviderHasChanged = DateTime.MinValue;
		DateTime utcNow3 = CDateTime.UtcNow;
		DateTime dateTime3 = (DateTime)(obj + 24);
		DateTime hourlyInterstitialExpireTime = ((DateTime*)dateTime3)->AddHours(1.0);
		_interstitialProviderListVersion = 0;
		_numberOfInterstitialsPerDay = 0;
		_hourlyInterstitialExpireTime = hourlyInterstitialExpireTime;
		Statistics statistics = default;
		statistics._002Ector();
		_stats = statistics;
		HoverboardCustomizationData hoverboardCustomizationData = default;
		hoverboardCustomizationData._002Ector(string.Empty);
		_hoverboardCustomizationData = hoverboardCustomizationData;
		CollectCoinsDummyData collectCoinsDummyData = default;
		collectCoinsDummyData._002Ector(string.Empty);
		_collectCoinsDummyData = collectCoinsDummyData;
		_trophyMissionData = string.Empty;
		_characterNameEventData = string.Empty;
		_hasLoggedStaticData = false;
		_hasCollectedFirstAwardReward = false;
		_hasLoggedSyboUserId = false;
		_flurryUserId = string.Empty;
		_ageRestrictionInputYear = 0;
		_ageRestrictionInputVersion = 0;
		_allowSellHeadstartDuringRun = false;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static PlayerInfo()
	{
		CultureInfo cultureInfo = default;
		cultureInfo._002Ector("da-DK");
		DATETIME_CULTUREINFO = cultureInfo;
	}
}
