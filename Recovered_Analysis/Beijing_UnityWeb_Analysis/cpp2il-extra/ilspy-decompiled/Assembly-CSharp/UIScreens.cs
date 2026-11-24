using System.Collections.Generic;
using Cloud;
using Cpp2ILInjected;
using UnityEngine;

public class UIScreens
{
	public const string CHARACTER_SCREEN = "CharacterScreen";

	public const string COINS_SCREEN = "CoinsUI_shop";

	public const string COINS_POPUP = "CoinsUI_quick";

	public const string WELCOME_POPUP = "WelcomePopup";

	public const string FRIENDS_SCREEN = "FriendsUI";

	public const string FRONT_SCREEN = "FrontScreen";

	public const string GAMEOVER_SCREEN = "GameOverScreen";

	public const string PRIVACY_POLICY_POPUP = "PrivacyPolicyPopup";

	public const string LEADERBOARD_SCREEN = "LeaderboardUI";

	public const string TOPRUN_SCREEN = "TopRunUI";

	public const string CELEBRATION_POPUP = "CelebrationPopup";

	public const string PRIZE_MB_POPUP_KEYS = "PrizeMBPopup_Keys";

	public const string PRIZE_SMB_POPUP_KEYS = "PrizeSMBPopup_Keys";

	public const string PRIZE_MMB_POPUP = "PrizeMMBPopup";

	public const string SETTINGS_POPUP = "SettingsPopup";

	public const string AWARDS_SCREEN = "AwardsScreen";

	public const string TUTORIAL_COLLECT_FROM_FRIENDS = "TutorialCollectFromFriendsPopup";

	public const string TUTORIAL_DOUBLE_COINS = "TutorialDoubleCoinsPopup";

	public const string TUTORIAL_END_GAME_MISSIONS = "TutorialEndGameMissionsPopup";

	public const string TUTORIAL_FACEBOOK_POPUP = "TutorialFacebookPopup";

	public const string TUTORIAL_HOVERBOARDS = "TutorialHoverboardsPopup";

	public const string TUTORIAL_MISSION = "TutorialMissionPopup";

	public const string UPDATE_APP_POPUP = "UpdateAppPopup";

	public const string UPGRADE_SCREEN = "UpgradesUI_shop";

	public const string UPGRADE_POPUP = "UpgradesUI_quick";

	public const string NOTEBOOK_BACKGROUND = "NotebookScreen";

	public const string BOARD_SCREEN = "BoardScreen";

	public const string EARN_COINS_SCREEN = "EarnCoinsScreen";

	public const string RATING_POPUP = "RatingPopup";

	public const string EVENTS_POPUP = "EventsPopup";

	public const string NOT_ENOUGH_CURRENCY_POPUP = "NotEnoughCurrencyPopup";

	public const string COUNTRY_POPUP = "CountryPopup";

	public const string TOPRUN_POPUP = "TopRunPopup";

	public const string SECRET_POPUP = "SecretPopup";

	public const string OFFERWALL_POPUP = "CoinsUI_earn";

	public const string LIMITED_CHARACTER_POPUP = "LimitedCharacterPopup";

	public const string LIMITED_BOARD_POPUP = "LimitedBoardPopup";

	public const string CHARACTER_PROMOTION_POPUP = "CharacterPromotionPopup";

	public const string BOARD_BUNDLE_POPUP = "BoardBundlePopup";

	public const string CONSUMABLES_POPUP = "ConsumablesPopup";

	public const string AGE_RESTRICTION_POPUP = "AgeRestrictionPopup";

	public const string HOME_CONFIRMATION_POPUP = "HomeConfirmationPopup";

	public const string QUIT_APPLICATION_POPUP = "QuitApplicationPopup";

	public const string CONTACT_SUPPORT_POPUP = "ContactSupportPopup";

	public const string LANGUAGE_SELECTION_POPUP = "LanguageSelectionPopup";

	public const string LANGUAGE_SELECTION_CONFIRMATION_POPUP = "LanguageSelectionConfirmationPopup";

	public const string CHALLENGES_SCREEN = "ChallengesScreen";

	public const string FIRST_PURCHASE_BONUS_POPUP = "FirstPurchaseBonusPopup";

	public const string CONSENT_POPUP = "ConsentPopup";

	public const string WITHDRAW_CONSENT_POPUP = "WithdrawConsentPopup";

	public const string COUNTDOWN_POPUP = "CountdownPopup";

	public const string WELCOME_PACK_POPUP = "WelcomePackPopup";

	public const string FACEBOOK_PROMOTION_POPUP = "FBPromotionPopup";

	public const string CLOUDSAVE_INTRODUCTION_POPUP = "CloudSaveIntroductionPopup";

	public const string CLOUDSAVE_CELEBRATION_POPUP = "CloudSaveCelebrationPopup";

	public const string CLOUDSAVE_COMPARISON_POPUP = "CloudSaveComparisonPopup";

	public const string CLOUDSAVE_ADVANCED_COMPARISON_POPUP = "CloudSaveAdvancedComparisonPopup";

	public const string CLOUDSAVE_REMINDER_POPUP = "CloudSaveReminderPopup";

	public const string CLOUDSAVE_STATUS_POPUP = "CloudSaveStatusPopup";

	public const string CLOUDSAVE_DISABLED_STATUS_POPUP = "CloudSaveDisabledStatusPopup";

	public const string PAUSE_SCREEN = "PauseUI";

	public const string PURCHASE_ERROR_POPUP = "PurchaseErrorPopup";

	public const string BOARD_PROMOTION_POPUP = "BoardPromotionPopup";

	public const string CLOUDSAVE_PROMOTION_POPUP = "CloudSavePromotionPopup";

	public const string CLOUDSAVE_CONFIRMATION_POPUP = "CloudSaveConfirmationPopup";

	public const string CHARACTER_NAME_EVENT_POPUP = "CharacterNameEventPopup";

	public const string SAVE_ME_POPUP = "SaveMePopup";

	public const string TUTORIAL_AD_REMOVAL = "TutorialAdRemovalPopup";

	public const string INGAME_SCREEN = "IngameUI";

	public const string EVENT_TESTER_POPUP = "EventTesterPopup";

	public const string CELEBRATION_TESTER_POPUP = "CelebrationTesterPopup";

	public const string WEEKLY_HUNT_TESTER_POPUP = "WeeklyHuntTesterPopup";

	public const string DEBUGSETTINGSPOPUP = "DebugSettingsPopup";

	public const string SCROLL_LIST_SELECT_POPUP = "ScrollListSelectPopup";

	public const string AD_SYSTEM_TESTER_POPUP = "AdSystemTesterPopup";

	public const string AB_TEST_TESTER_POPUP = "ABTestTesterPopup";

	public static readonly string[] SCREENS;

	public static readonly string[] POPUPS;

	public static string friendsMenu_lastScreen;

	public static string meMenu_lastScreen;

	public static string shopMenu_lastScreen;

	public static string GetFlurryPopUpWithOkAndCloseName(string goName)
	{
		//IL_0011: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [goName @ L0 (System.String)+FC]");
		return ((GameObject)0).tag;
	}

	public UIScreens()
	{
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj2 = default;
		if ((nint)obj2 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 19;
			((UIScreenController)this)._QueueMessage(text);
		}
	}

	static UIScreens()
	{
		//IL_0197: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I4
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got F4
		//IL_007b: Expected I, but got Obj
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got F4
		//IL_0109: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got F4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0188: Expected VT, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = 0;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<UIScreenController>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = 0;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<UIScreenController>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = 0;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<UIScreenController>)+5C]");
		object obj4 = (nint)0 + (nint)16;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		list.Add("IngameUI");
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v29 (Il2CppClass<UIScreenController>)+5C]");
		object obj5 = (nint)0 + (nint)20;
		obj5 = list;
		UIScreenController._facebookPayoutPopupQueued = false;
		object obj7 = default;
		object obj6 = obj7 + 28;
		obj6 = 0;
		_ = 0;
		obj6 = -70f;
		_ = -25f;
		_ = 0f;
		nint num6 = (nint)typeof(UIScreenController);
		object obj8 = obj7 + 40;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v36+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v42 (Il2CppClass<UIScreenController>)+5C]");
		object obj9 = (nint)0 + (nint)52;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v25+8]");
		_ = 0;
		object obj10 = obj7 + 16;
		obj10 = 0;
		_ = 0;
		obj10 = 20f;
		_ = 16f;
		_ = -1f;
		nint num7 = (nint)typeof(UIScreenController);
		obj8 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v47+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v53 (Il2CppClass<UIScreenController>)+5C]");
		object obj11 = -(-64);
		obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v25+8]");
		_ = 0;
		obj7 = 0;
		obj7 = 20f;
		_ = 3.5f;
		object obj12 = obj7 + 8;
		obj12 = obj7;
		obj8 = obj12;
		UIScreenController.savemePopupPosition = (Vector2)obj8;
	}
}
