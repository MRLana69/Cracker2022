using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using UnityEngine;

public static class Flurry
{
	public const string EVENT_UISCREEN_CHANGED_PREFIX = "UI Screen ";

	public const string EVENT_POPUPSCREEN_CHANGED_PREFIX = "POPUP Screen ";

	public const string EVENT_10_SOCIAL_ACTIONS_TAKEN = "10 social actions taken";

	public const string EVENT_FIRST_GAMECENTER_LOGIN = "First GameCenter Login";

	public const string EVENT_FIRST_FACEBOOK_LOGIN = "First Facebook Login";

	public const string EVENT_SOCIAL_POKE = "Social friend poked";

	public const string EVENT_SOCIAL_DUELPOKE = "Social duel poked";

	public const string EVENT_SOCIAL_BRAG = "Social bragged";

	public const string EVENT_SOCIAL_BRAGFACEBOOK = "Social bragged Facebook";

	public const string EVENT_SOCIAL_FACEBOOK_FRIENDS_RETRIEVED = "Social Facebook Friends Retrieved";

	public const string EVENT_SOCIAL_GC_FRIENDS_RETRIEVED = "Social GameCenter Friends Retrieved";

	public const string EVENT_SOCIAL_FRIENDS_CONSOLIDATED = "Social Friends Consolidated";

	public const string EVENT_FACEBOOK_STATUS = "Facebook status";

	public const string EVENT_MYSTERY_BOX_OPENED = "Mystery Box opened";

	public const string EVENT_MINIMYSTERY_BOX_OPENED = "Mini Mystery Box opened";

	public const string EVENT_SUPER_MYSTERY_BOX_OPENED = "Super mystery box opened";

	public const string EVENT_INAPPPURCHASE_COMPLETED = "InApp purchase completed";

	public const string EVENT_INAPPPURCHASE_COINPACK1 = "InApp Coin Pack 1 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK2 = "InApp Coin Pack 2 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK3 = "InApp Coin Pack 3 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK4 = "InApp Coin Pack 4 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK5 = "InApp Coin Pack 5 purchased";

	public const string EVENT_INAPPPURCHASE_KEYPACK1 = "InApp Key Pack 1 purchased";

	public const string EVENT_INAPPPURCHASE_KEYPACK2 = "InApp Key Pack 2 purchased";

	public const string EVENT_INAPPPURCHASE_KEYPACK3 = "InApp Key Pack 3 purchased";

	public const string EVENT_INAPPPURCHASE_KEYPACK4 = "InApp Key Pack 4 purchased";

	public const string EVENT_INAPPPURCHASE_DOUBLECOINS = "Double Coin purchased";

	public const string EVENT_INAPPPURCHASE_DOUBLECOINS_POPUP = "Double Coin purchased GameOver";

	public const string EVENT_INAPPPURCHASE_BUNDLE1 = "InApp Bundle 1 purchased";

	public const string EVENT_INAPPPURCHASE_BUNDLE2 = "InApp Bundle 2 purchased";

	public const string EVENT_INAPPPURCHASE_BUNDLE3 = "InApp Bundle 3 purchased";

	public const string EVENT_INAPPPURCHASE_BUNDLE4 = "InApp Bundle 4 purchased";

	public const string EVENT_INAPPPURCHASE_BUNDLE5 = "InApp Bundle 5 purchased";

	public const string EVENT_CHARACTER_UNLOCKED = "Character unlocked";

	public const string EVENT_AUTOMESSAGE_TURNED_OFF = "AutoBrag turned off";

	public const string EVENT_DAYS_PASSED_SINCE_LAST_PLAY = "Days passed since last play";

	public const string EVENT_BUY_HOVERBOARD_FROM_POPUP = "Purchase hoverboard from popup";

	public const string EVENT_APPLICATION_AUTHENTICITY = "Application Authenticity";

	public const string EVENT_START_DUEL = "Start duel request";

	public const string EVENT_UNKNOWN_GPU = "Unknown GPU";

	public const string EVENT_DEVICE_PERFORMANCE = "Device performance";

	public const string EVENT_END_OF_RUN_AVG_FPS = "InRunAvgFPS";

	public const string EVENT_END_OF_RUN_POWERUPS_USED = "Powerups used in run";

	public const string EVENT_DEVICE_MEMORY = "Device Memory";

	public const string EVENT_CHARACTERS_OWNED = "Characters owned";

	public const string EVENT_HOVERBOARDS_OWNED = "Hoverboards owned";

	public const string EVENT_CHARACTER_OUTFITS_OWNED = "Character outfits owned";

	public const string EVENT_HOVERBOARD_ABILITIES_OWNED = "Hoverboard abilities owned";

	public const string EVENT_ACTIVATED_HOVERBOARD = "Boost hoverboard activated";

	public const string EVENT_ACTIVATED_HEADSTART = "Boost headstart activated";

	public const string EVENT_ACTIVATED_SCOREBOOSTER = "Boost scorebooster activated";

	public const string EVENT_DAILY_BUNDLEIDENTIFIER = "The current bundle identifier";

	public const string EVENT_MISSIONSET_COMPLETED = "Mission Set completed";

	public const string EVENT_DAILY_CHALLENGE_COMPLETED = "Daily Challenge completed";

	public const string EVENT_UPDATE_APP_POPUP_RESULT = "New Version Popup Result";

	public const string EVENT_FILEUTIL_LOAD_CORRUPTED = "FileUtil load corrupted";

	public const string EVENT_PLAYERINFO_LOAD_EMPTYPATH = "PlayerInfo.Load Empty path";

	public const string EVENT_PLAYERINFO_LOAD_FILENOTFOUND = "PlayerInfo.Load FileNotFound";

	public const string EVENT_PLAYERINFO_LOAD_EXCEPTION = "PlayerInfo.Load Exception";

	public const string EVENT_VIDEOADS_ATTEMPT_TO_PLAY = "VideoAds attempt to play";

	public const string EVENT_VIDEOADS_PROVIDER_REQUEST = "VideoAds {0} request";

	public const string EVENT_FRIENDREWARD_COLLECTED = "Friend reward collect";

	public const string EVENT_EARNCOINS_ITEM_CLICKED = "Earn Coins item clicked";

	public const string EVENT_VIDEO_ADS_CLICKED = "Video Ads button clicked";

	public const string EVENT_QUICKVIDEO_ADS_CLICKED = "Quick Video Ads button clicked";

	public const string EVENT_EARNCOINS_SCREEN_OPENED = "Earn coins screen opened";

	public const string EVENT_OLD_DEVICE_TOKEN_UNREGISTERED = "Old Device Token Unregistered";

	public const string EVENT_CHARACTER_THEME_UNLOCKED = "Outfit bought";

	public const string EVENT_HOVERBOARD_BOUGHT = "Hoverboard bought";

	public const string EVENT_FACEBOOK_SHARE = "Share link on Facebook";

	public const string EVENT_BREADCRUMBS_BEFORE_FREE_HOVERBOARD = "Bread crumbs before purchasing the free hoverboard";

	public const string EVENT_MORE_COINS_CLICKED = "More coins button clicked";

	public const string EVENT_BACK_BTN_PRESSED = "Back button pressed";

	public const string EVENT_HOME_BUTTON_PRESSED = "Home button pressed";

	public const string EVENT_RATING_POPUP = "Rate the app popup";

	public const string EVENT_AMOUNT_OF_COINS = "Daily report of coins";

	public const string EVENT_AMOUNT_OF_KEYS = "Daily keys report";

	public const string EVENT_AMOUNT_OF_CONSUMABLE_HOVERBOARDS = "Daily report of consumable hoverboards";

	public const string EVENT_AMOUNT_OF_HEADSTARTS = "Daily report of headstarts owned";

	public const string EVENT_AMOUNT_OF_SCOREBOOSTERS = "Daily report of score boosters owned";

	public const string EVENT_ONLINE_STATUS = "Daily online status";

	public const string EVENT_DAILY_ONLINE_STATUS = "Daily Check of Online Status";

	public const string EVENT_NOTIFICATIONS_STATE = "State of notifications";

	public const string EVENT_REMINDERS_STATE = "State of reminders";

	public const string EVENT_SSEVENT_POPUP_SHOWN = "Event Popup was shown";

	public const string EVENT_HOVERBOARD_TRIED = "Event Popup was shown";

	public const string EVENT_ACTIVE_CHARACTER = "Currently active character";

	public const string EVENT_ACTIVE_BOARD = "Currently active board";

	public const string EVENT_SKIPPED_CHARACTER_FOR_CHARACTER_NAME_EVENT = "Skipped character for Wordy Weekend";

	public const string EVENT_UNLOCKED_CHARACTER_FOR_CHARACTER_NAME_EVENT_WITH_PARAMETERS = "Unlocked character for Wordy Weekend";

	public const string EVENT_UNLOCKED_CHARACTER_FOR_CHARACTER_NAME_EVENT = "{0} unlocked for Wordy Weekend";

	public const string EVENT_ATTEMPT_TO_BUY_COINS_FOR_CHARACTER_NAME_EVENT = "Attempt to buy coins for Wordy Weekend";

	public const string EVENT_ATTEMPT_TO_BUY_KEYS_FOR_CHARACTER_NAME_EVENT = "Attempt to buy keys for the Wordy Weekend";

	public const string EVENT_BOUGHT_COINS_FOR_CHARACTER_NAME_EVENT = "Bought coins for Wordy Weekend";

	public const string EVENT_BOUGHT_KEYS_FOR_CHARACTER_NAME_EVENT = "Bought keys for Wordy Weekend";

	public const string EVENT_CANCELED_BUYING_COINS_FOR_CHARACTER_NAME_EVENT = "Canceled buying coins for Wordy Weekend";

	public const string EVENT_CANCELED_BUYING_KEYS_FOR_CHARACTER_NAME_EVENT = "Canceled buying keys for Wordy Weekend";

	public const string EVENT_UNABLE_TO_BUY_COINS_FOR_CHARACTER_NAME_EVENT = "Unable to buy coins for Wordy Weekend";

	public const string EVENT_UNABLE_TO_BUY_KEYS_FOR_CHARACTER_NAME_EVENT = "Unable to buy keys for Wordy Weekend";

	public const string EVENT_ATTEMPTED_TO_SHOW_DOUBLE_UP_BUTTON = "Attempted to show double up button";

	public const string EVENT_DOUBLE_UP_CHOICE_RESULT = "Double up choice";

	public const string EVENT_DOUBLE_UP_BUTTON_SHOWN = "Double up button shown";

	public const string EVENT_DOUBLE_UP_BUTTON_CLICKED = "Double up button clicked";

	public const string EVENT_VIDEOADS_END_OF_WATERFALL = "VideoAds end of waterfall";

	public const string EVENT_NO_FILL_FOR_DOUBLE_BUTTON = "No fill for double button";

	public const string EVENT_VIDEOADS_CACHE_REQUEST_ENDED = "VideoAds Cache Request Ended";

	public const string EVENT_VIDEOADS_CACHE_REQUEST_ENDED_COUNTRY_INFO = "VideoAds Cache Request Ended (Country Info)";

	public const string EVENT_LIMITED_CHARACTER_POPUP_CLOSED = "Limited character popup closed";

	public const string EVENT_VIDEOADS_CACHING_TIME = "VideoAds Caching Time(2)";

	public const string EVENT_LIMITED_BOARD_POPUP_CLOSED = "Limited board popup closed";

	public const string EVENT_FIRST_INSTALL_DATE = "First install date";

	public const string EVENT_CONSUMABLES_SOLD_DURING_RUN = "Consumables Sold During Run";

	public const string EVENT_OFFER_REDEEMED = "Offerwall Offer Redeemed";

	public const string EVENT_OFFERS_REQUESTED = "Offerwall Offers Requested and Returned";

	public const string EVENT_OFFER_CLICKED = "Offerwall Offer Clicked";

	public const string EVENT_OFFERWALL_POPUP_ATTEMPT_TO_SHOW = "Attempt showing OfferWall Popup Button";

	public const string EVENT_OFFERWALL_POPUP_CLOSED = "OfferWall Popup Closed";

	public const string EVENT_OFFERWALL_POPUP_OFFER_CLICKED = "OfferWall Popup Offer Clicked";

	public const string EVENT_HOVERBOARD_THEME_BOUGHT = "Hoverboard Theme bought";

	public const string EVENT_HOVERBOARD_THEME_ACTIVATED = "Hoverboard Theme activated";

	public const string EVENT_HOVERBOARD_THEME_DEACTIVATED = "Hoverboard Theme deactivated";

	public const string EVENT_BOOST_SCOREBOOSTER_PURCHASED = "Boost Scorebooster purchased";

	public const string EVENT_BOOST_HEADSTART500_PURCHASED = "Boost Headstart500 purchased";

	public const string EVENT_BOOST_HEADSTART2000_PURCHASED = "Boost Headstart2000 purchased";

	public const string EVENT_BOOST_HOVERBOARD_PURCHASED = "Boost Hoverboard purchased";

	public const string EVENT_BOOST_COINMAGNET_PURCHASED = "Boost Coinmagnet purchased";

	public const string EVENT_BOOST_DOUBLEMULTIPLIER_PURCHASED = "Boost 2x multiplier purchased";

	public const string EVENT_BOOST_JETPACK_PURCHASED = "Boost jetpack purchased";

	public const string EVENT_BOOST_LETTERS_PURCHASED = "Boost letters purchased";

	public const string EVENT_BOOST_SUPERSNEAKERS_PURCHASED = "Boost supersneakers purchased";

	public const string EVENT_BOOST_MYSTERYBOX_PURCHASED = "Boost MysteryBox purchased";

	public const string EVENT_BOOST_MISSION_SKIP_PURCHASED = "Boost Mission Skip purchased";

	public const string EVENT_BOOST_MYSTERYBOX_VIEW_PRIZES = "Mysterybox view prices";

	public const string EVENT_SUPER_MYSTERYBOX_VIEW_PRIZES = "Super Mystery Box prizes";

	public const string EVENT_MINI_MYSTERYBOX_VIEW_PRIZES = "Mini Mystery Box prizes";

	public const string EVENT_SAVE_ME_PERFORMED = "Save Me performed";

	public const string EVENT_WEEKLY_CHALLENGE_COMPLETED = "Weekly Challenge Completed";

	public const string EVENT_INTERSTITIAL_PROVIDER_REQUEST = "Interstitial Providers Request";

	public const string EVENT_INTERSTITIAL_PROVIDER_SHOW = "Interstitial Providers Show {0}";

	public const string EVENT_INTERSTITIAL_SHOW_DAILY_LIMIT_REACHED = "Interstitials Show Daily Limit Reached";

	public const string EVENT_INTERSTITIAL_SHOW_HOURLY_LIMIT_REACHED = "Interstitials Show Hourly Limit Reached";

	public const string EVENT_INTERSTITIAL_GAME_OVER_COUNTER = "Interstitial Game Over Counter";

	public const string EVENT_INTERSTITIAL_NATIVE_ADVIEW_AD_INVALID = "Native Ad Invalid";

	public const string EVENT_AWARD_TIER_COMPLETED = "Award tier completed";

	public const string EVENT_AWARD_COMPLETED = "Award completed";

	public const string EVENT_AWARD_TIER_COMPLETED_TIME = "Award tier completed time";

	public const string EVENT_AWARD_TIER_COLLECTED_TIME = "Award tier collected time";

	public const string EVENT_AMOUNT_OF_GOLD_AWARDS_FINISHED = "Total amount of gold awards finished";

	public const string EVENT_AMOUNT_OF_SILVER_AWARDS_FINISHED = "Total amount of silver awards finished";

	public const string EVENT_ASSET_BUNDLE_FAILED_TO_CACHE = "Asset Bundle Failed to be Cached";

	public const string EVENT_ASSET_BUNDLE_FAILED_LOAD_FROM_CACHE = "Asset Bundle Failed to be loaded from Cache";

	public const string EVENT_ASSET_BUNDLE_FAILED_DOWNLOAD = "Asset Bundle Failed to Download";

	public const string EVENT_ASSET_BUNDLE_AVAILABILITY_CHECK_FAILED = "Asset Bundles Availability Check Failed";

	public const string EVENT_ASSET_BUNDLES_ALL_DOWNLOADED = "All Asset Bundle Downloads completed";

	public const string EVENT_PLAYER_BIRTHDAY = "Player Birthday entered";

	public const string EVENT_ARGKEY_ID = "Id";

	public const string EVENT_ARGKEY_TIER = "Tier";

	public const string EVENT_ARGKEY_UI_SCREENNAME = "Screen Name";

	public const string EVENT_ARGKEY_MISSIONSET = "Mission Set";

	public const string EVENT_ARGKEY_MISSIONSET_AND_INDEX = "Mission Set and Index";

	public const string EVENT_ARGKEY_TOTAL = "Total";

	public const string EVENT_ARGKEY_POPUPRESULT = "Result";

	public const string EVENT_ARGKEY_FILENAME = "Filename";

	public const string EVENT_ARGKEY_VIDEOADRESULT = "Result";

	public const string EVENT_ARGKEY_ITEM_IAP = "Item tiggered iap";

	public const string EVENT_ARGKEYS_SOCIAL_FRIENDS_RETRIEVED = "Total friends;Installed friends";

	public const string EVENT_ARGKEYS_SOCIAL_FRIENDS_CONSOLIDATED = "Total;Facebook;GameCenter";

	public const string EVENT_ARGKEY_IS_FROM_DAILY_CHALLENGE = "SMB from daily challenge";

	public const string EVENT_ARGKEY_RATE_ASKAGAIN = "Should ask again";

	public const string EVENT_ARGKEY_AMOUNT = "Amount";

	public const string EVENT_ARGKEY_NOTIFICATIONS_ENABLED = "Enabled";

	public const string EVENT_ARGKEY_APPLICATION_AUTHENTICITY = "Type";

	public const string EVENT_ARGKEY_RESULT = "Result";

	public const string EVENT_ARGKEY_STATE = "State";

	public const string EVENT_ARGKEY_STATUS = "Status";

	public const string EVENT_ARGKEY_VALUE = "Value";

	public const string EVENT_ARGKEY_AWARD = "Award";

	public const string EVENT_ARGKEY_TIME = "Time";

	public const string EVENT_ARGKEY_DEVICE = "Device";

	public const string EVENT_ARGKEY_ERRORCODE = "Error code";

	public const string EVENT_ARGKEY_EXCEPTION = "Exception";

	public const string EVENT_ARGKEY_STACKTRACE = "Stacktrace";

	public const string EVENT_ARGKEY_OFFERWALL_OFFER_COIN_AMOUNT = "Coin amount";

	public const string EVENT_ARGKEY_OFFERWALL_OFFERS_REQUESTED = "Returned for {0} requested";

	public const string EVENT_ARGKEY_OFFERWALL_OFFERS_RETURNED = "Valid for {0} returned";

	public const string EVENT_ARGKEY_CHARACTER_NAME_ACTION_PRICE = "Price";

	public const string EVENT_ARGKEY_CHARACTER_NAME_CHARACTER = "Character";

	public const string EVENT_ARGKEY_CHARACTER_NAME_SKIPPED_WITH_AD = "Watched ad";

	public const string EVENT_ARGKEY_GPU_NAME = "GPU name";

	public const string EVENT_ARGKEY_PERFOMRNACE_LEVEL = "Level";

	public const string EVENT_ARGKEY_FPS_RANGE = "FPS range {0}";

	public const string EVENT_ARGKEY_DEVICE_MEMORY_AMOUNT = "Amount";

	public const string EVENT_ARGKEY_ITEMS_OWNED_REGULAR = "regular";

	public const string EVENT_ARGKEY_ITEMS_OWNED_LIMITED = "limited";

	public const string EVENT_ARGKEY_ITEMS_OWNED_TOKEN = "token";

	public const string EVENT_ARGKEY_ITEMS_OWNED_FACEBOOK = "facebook";

	public const string EVENT_ARGKEY_ITEMS_OWNED_TOTAL = "total";

	public const string EVENT_ARGKEY_ACTIVATED_BOOST_SUCCESSFULLY = "successfully";

	public const string EVENT_ARGKEY_AWARDS_GOLD_COMPLETED = "Completed Gold Awards";

	public const string EVENT_ARGKEY_AWARDS_SILVER_COMPLETED = "Completed Silver Awards";

	public const string EVENT_ARGKEY_COUNTRY = "Country";

	public const string EVENT_ARGKEY_ONLINE_COUNTRY = "Online Country";

	public const string EVENT_ARGKEY_OFFLINE_COUNTRY = "Offline Country";

	public const string EVENT_ARGKEY_LIMITED_CHARACTER_POPUP_CHARACTER_BOUGHT = "Character {0} bought";

	public const string EVENT_ARGKEY_LIMITED_CHARACTER_POPUP_OUTFIT_BOUGHT = "{0}_{1} bought";

	public const string EVENT_ARGKEY_ASSET_BUNDLE_NAME = "Asset Bundle Name";

	public const string EVENT_ARGKEY_ASSET_BUNDLE_VERSION = "Asset Bundle Version";

	public const string EVENT_ARGKEY_ASSET_BUNDLE_DOWNLOAD_ERROR = "Asset Bundle Download Error";

	public const string EVENT_ARGKEY_ALL_ASSET_BUNDLES_DOWNLOADED = "All Bundles Downloaded?";

	public const string EVENT_ARGKEY_ALL_ASSET_BUNDLES_DOWNLOADED_COUNTRY = "All Bundles Downloaded {0} in Country";

	public const string EVENT_ARGKEY_LIMITED_BOARD_POPUP_BOARD_BOUGHT = "Board {0} bought";

	public const string EVENT_ARGKEY_LIMITED_BOARD_POPUP_OUTFIT_BOUGHT = "{0}_{1} bought";

	public const string EVENT_ARGKEY_DAILT_BUNDLEIDENTIFIER = "Daily bundle identifier";

	public const string EVENT_ARGKEY_UNIX_TIME_IN_MILLIS = "Unix time in millis";

	public const string EVENT_ARGKEY_NATIVE_DOWNLOAD_KEY = "ad_download";

	public const string EVENT_ARGKEY_NATIVE_TEXT_KEY_FORMAT = "text_{0}";

	public const string EVENT_ARGKEY_NATIVE_IMAGE_KEY_FORMAT = "image_{0}";

	public const string EVENT_ARGKEY_HEADSTART = "Headstart";

	public const string EVENT_ARGKEY_SCOREBOOST = "Scoreboost";

	public const string EVENT_ARGKEY_HOVERBOARD = "Hoverboard";

	public const string EVENT_ARGKEY_POWERUP = "Powerup";

	public const string EVENT_ARGKEY_REVIVE = "Revive";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_ATTEMPT = "Result";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_OFFERS_AT_OPEN = "Offers At Open";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_OFFERS_CLICKED = "Offers Clicked in Session";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_OFFERS_AT_CLOSE = "Offers At Close";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_CLICKED_INDEX = "Offer Clicked Index";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_CLICKED_REWARD = "Offer Clicked Reward";

	public const string EVENT_ARGKEY_PLAYER_BIRTHDAY = "Player birthday";

	public const string EVENT_ARGKEY_POPUPRESULT_OK = "Ok";

	public const string EVENT_ARGKEY_POPUPRESULT_CANCEL = "Cancel";

	public const string EVENT_ARGKEY_VIDEOADRESULT_OK = "Ok";

	public const string EVENT_ARGKEY_VIDEOADRESULT_NOVIDEO = "No video";

	public const string EVENT_ARGKEY_ASKRATE = "Ask again";

	public const string EVENT_ARGKEY_DONTASKRATE = "Do not ask again";

	public const string EVENT_ARGKEY_INTERSTITIAL_REQUEST_SUCCESS = "Request Success";

	public const string EVENT_ARGKEY_INTERSTITIAL_REQUEST_TIMEOUT = "Request TimeOut";

	public const string EVENT_ARGKEY_INTERSTITIAL_REQUEST_FAILED = "Request Failed";

	public const string EVENT_ARGKEY_INTERSTITIAL_REQUEST_FAILED_TO_INIT = "Request Failed To Init";

	public const string EVENT_ARGKEY_INTERSTITIAL_REQUEST_FAILED_TO_SHOW = "Request Failed To Show";

	public const string EVENT_ARGKEY_INTERSTITIAL_SHOWN = "Show Ad";

	public const string EVENT_ARGKEY_INTERSTITIAL_CLICKED = "Click";

	public const string EVENT_ARGKEY_INTERSTITIAL_LIMIT = "Limit";

	public const string EVENT_ARGKEY_PERFORMANCE_LEVEL_LOW = "Low";

	public const string EVENT_ARGKEY_PERFORMANCE_LEVEL_HIGH = "High";

	public const string EVENT_ARGKEY_GPU_NAME_WITH_VALUE = "GPU name {0}";

	public const string EVENT_ARGKEY_YES = "yes";

	public const string EVENT_ARGKEY_NO = "no";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_CHANCE = "Chance";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_FILL = "Fill";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_NO_CHANCE = "No Chance";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_NO_FILL = "No Fill";

	public const string EVENT_ARGKEY_DOUBLE_UP_OPTION_RESULT_DOUBLED = "Doubled";

	public const string EVENT_ARGKEY_DOUBLE_UP_OPTION_RESULT_NOT_DOUBLED = "Not Doubled";

	public const string EVENT_ARGKEY_SUCCESS = "Success";

	public const string EVENT_ARGKEY_FAILED = "Failed";

	public const string EVENT_ARGKEY_TIMEDOUT = "Timedout";

	public const string EVENT_ARGKEY_NOTCURRENT = "Notcurrent";

	public const string EVENT_ARGKEY_NATIVE_DOWNLOAD_VALUE = "ad download failed";

	public const string EVENT_ARGKEY_NATIVE_TEXT_VALUE_FORMAT = "total: {0} after: {1} - country:{2}";

	public const string EVENT_ARGKEY_NATIVE_IMAGE_VALUE_FORMAT = "ratio: {0} - country:{1}";

	public const string EVENT_ARGKEY_NATIVE_IMAGE_NAME_COVER = "Cover";

	public const string EVENT_ARGKEY_NATIVE_IMAGE_NAME_ICON = "Icon";

	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_TITLE = "Title";

	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_BODY = "Body";

	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_CTA = "Call To Action";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_ATTEMPT_SUCCESS = "Success";

	public const string EVENT_ARGKEY_OFFERWALL_POPUP_ATTEMPT_FAILED = "Failure";

	public const string EVENT_ARGKEY_PLAYER_BIRTHDAY_VALUE = "{0}-{1}";

	private static readonly int[][] FRIEND_BRACKETS;

	private static char[] PARAMETER_SPLITTERS;

	private const string VALIDATION_SUFFIX = " VALIDATED";

	public static void LogGameCenterLogin()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer && !PlayerPrefs.HasKey("flurry_has_logged_gc"))
		{
			PlayerPrefs.SetInt("flurry_has_logged_gc", 1);
		}
	}

	public static void LogFacebookLogin()
	{
		if (!PlayerPrefs.HasKey("flurry_has_logged_fb"))
		{
			PlayerPrefs.SetInt("flurry_has_logged_fb", 1);
		}
	}

	public static void LogOkPressedOnPopup(string eventName)
	{
		bool flag = eventName != string.Empty;
	}

	public static void LogClosePressedOnPopup(string eventName)
	{
		bool flag = eventName != string.Empty;
	}

	public unsafe static string ConvertFriendCountToBracket(int count)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected I4, but got Unknown
		//IL_0044: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected I4, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected I4, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = 0;
		object obj4 = default;
		object obj18 = default;
		while (true)
		{
			int[][] fRIEND_BRACKETS = FRIEND_BRACKETS;
			if ((nint)obj4 >= fRIEND_BRACKETS.Length)
			{
				break;
			}
			object obj5 = obj4 << 2;
			object obj6 = (object)FRIEND_BRACKETS + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v29+10]");
			object obj7 = 0;
			object obj8 = obj4 << 2;
			object obj9 = (object)FRIEND_BRACKETS + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v36+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v37+10]");
			bool flag = (nint)0 <= (nint)count;
			object obj11 = obj4 << 2;
			object obj12 = (object)FRIEND_BRACKETS + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v9+10]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S2_v10+14]");
			if ((nint)0 < (nint)count)
			{
				flag = false;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v37+10]");
				obj3 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v37+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S2_v10+14]");
				bool flag2 = num > 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v37+10]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v37+10]");
				obj3 = 0;
				if (!flag2)
				{
					bool flag3;
					do
					{
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v30+18]");
						object obj16 = obj15 + 0;
						if (count >= (nint)obj14 && count < (nint)obj16)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v30+18]");
							if ((nint)0 == 1)
							{
								int num2 = obj + 12;
								return ((int*)num2)->ToString();
							}
							int num3 = obj + 8;
							string text = ((int*)num3)->ToString();
							object obj17 = obj16 - 1;
							int num4 = obj + 4;
							string text2 = ((int*)num4)->ToString();
							return text + "-" + text2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S2_v10+14]");
						flag3 = 0 >= (nint)obj16;
						obj14 = obj16;
						obj3 = obj16;
					}
					while (flag3);
				}
			}
			obj4 = obj18 + 1;
		}
		int num5 = obj + 12;
		return ((int*)num5)->ToString();
	}

	public unsafe static bool ShouldLogDailyEvent(string eventName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected VT, but got Unknown
		//IL_00c2: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime now = CDateTime.Now;
		DateTime dateTime = (DateTime)(obj + 8);
		int dayOfYear = ((DateTime*)dateTime)->DayOfYear;
		string key = "socflurdaily" + eventName;
		bool result;
		if (PlayerPrefs.HasKey(key))
		{
			int num = PlayerPrefs.GetInt(key);
			bool flag = num == dayOfYear;
			result = false;
			if (flag)
			{
				goto IL_00cb;
			}
		}
		PlayerPrefs.SetInt(key, dayOfYear);
		result = true;
		goto IL_00cb;
		IL_00cb:
		return result;
	}

	public static void StartSession(string apiKey, string userId)
	{
	}

	public static void EndSession()
	{
	}

	public static void LogEvent(string eventName)
	{
	}

	public static void LogEventWithAParameter(string eventName, string argKey, string argValue)
	{
	}

	public static void LogEventWithSeveralParameters(string eventName, Dictionary<string, string> parameters)
	{
	}

	public static void LogEventWithSeveralParameters(string eventName, string argKeys, string argValues)
	{
	}

	private static Dictionary<string, string> ToDictionary(string argKeys, string argValues)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		string[] array = argKeys.Split(PARAMETER_SPLITTERS);
		string[] array2 = argValues.Split(PARAMETER_SPLITTERS);
		object obj = 0;
		while ((nint)obj < array.Length && (nint)obj < array2.Length)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			object obj4 = obj << 2;
			object obj5 = (object)array2 + obj4;
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S5_v5+4] (should have been resolved before IL gen)");
			object obj7 = obj + 1;
			obj = obj7;
		}
		Dictionary<string, string> result = default;
		return result;
	}

	public unsafe static void LogInAppPurchase(string productId, string itemRequested, bool validationCallback = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected I4, but got Unknown
		//IL_0b3f: Expected Obj, but got I4
		//IL_0fbe: Expected Obj, but got I4
		//IL_0cbf: Expected Obj, but got I4
		//IL_115e: Expected Obj, but got I4
		//IL_0b23: Expected Obj, but got I4
		//IL_0fa2: Expected Obj, but got I4
		//IL_11f3: Expected Obj, but got I4
		//IL_0a7f: Expected Obj, but got I4
		//IL_0dc1: Expected Obj, but got I4
		//IL_0ca3: Expected Obj, but got I4
		//IL_1142: Expected Obj, but got I4
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Expected I4, but got Unknown
		//IL_0bff: Expected Obj, but got I4
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Expected I4, but got Unknown
		//IL_107e: Expected Obj, but got I4
		//IL_11d7: Expected Obj, but got I4
		//IL_0a63: Expected Obj, but got I4
		//IL_0da5: Expected Obj, but got I4
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected I4, but got Unknown
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected I4, but got Unknown
		//IL_0be3: Expected Obj, but got I4
		//IL_08ff: Expected Obj, but got I4
		//IL_1062: Expected Obj, but got I4
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1210: Expected I4, but got Unknown
		//IL_09bf: Expected Obj, but got I4
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected I4, but got Unknown
		//IL_0756: Expected Obj, but got I4
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected I4, but got Unknown
		//IL_08e3: Expected Obj, but got I4
		//IL_1096: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Expected I4, but got Unknown
		//IL_09a3: Expected Obj, but got I4
		//IL_073a: Expected Obj, but got I4
		//IL_0592: Expected Obj, but got I4
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected I4, but got Unknown
		//IL_03a3: Expected Obj, but got I4
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected I4, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected I4, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected I4, but got Unknown
		//IL_0576: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected I4, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected I4, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eea: Expected I4, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected I4, but got Unknown
		//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (validationCallback)
		{
		}
		string text = "InApp purchase completed" + string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752");
		object obj3 = default;
		object obj4;
		object obj5;
		object obj6;
		object obj7;
		if ((nint)obj3 <= 1541374300)
		{
			if ((nint)obj3 <= 918133839)
			{
				if ((nint)obj3 <= 867800982)
				{
					if ((nint)obj3 != 28465165)
					{
						if ((nint)obj3 != 861109786)
						{
							if ((nint)obj3 == 867800982 && !(productId != "com.kiloo.subways.coinstier4"))
							{
								goto IL_097d;
							}
						}
						else if (!(productId != "com.kiloo.subways.coinstier5discount"))
						{
							goto IL_0a3d;
						}
					}
					else if (!(productId != "com.kiloo.subways.keystier2discount"))
					{
						goto IL_0bbd;
					}
				}
				else if ((nint)obj3 != 884578601)
				{
					if ((nint)obj3 != 901356220)
					{
						if ((nint)obj3 == 918133839 && !(productId != "com.kiloo.subways.coinstier3"))
						{
							goto IL_0714;
						}
					}
					else if (productId == "com.kiloo.subways.coinstier2")
					{
						goto IL_08bd;
					}
				}
				else if (productId == "com.kiloo.subways.coinstier5")
				{
					goto IL_0a3d;
				}
			}
			else if ((nint)obj3 <= 1491041443)
			{
				if ((nint)obj3 != 951689077)
				{
					if ((nint)obj3 != 1373233265)
					{
						if ((nint)obj3 == 1491041443 && productId == "com.kiloo.subways.bundletier1")
						{
							if (itemRequested != null)
							{
								obj4 = 0;
								if (itemRequested._stringLength != 0)
								{
									goto IL_1288;
								}
							}
							obj4 = 1;
							goto IL_1288;
						}
					}
					else if (productId == "com.kiloo.subways.coinstier4discount")
					{
						goto IL_097d;
					}
				}
				else if (!(productId != "com.kiloo.subways.coinstier1"))
				{
					goto IL_11b1;
				}
			}
			else if ((nint)obj3 != 1507819062)
			{
				if ((nint)obj3 != 1524596681)
				{
					if ((nint)obj3 == 1541374300 && productId == "com.kiloo.subways.bundletier4")
					{
						if (itemRequested != null)
						{
							obj5 = 0;
							if (itemRequested._stringLength != 0)
							{
								goto IL_12a9;
							}
						}
						obj5 = 1;
						goto IL_12a9;
					}
				}
				else if (productId == "com.kiloo.subways.bundletier3")
				{
					if (itemRequested != null)
					{
						obj6 = 0;
						if (itemRequested._stringLength != 0)
						{
							goto IL_1410;
						}
					}
					obj6 = 1;
					goto IL_1410;
				}
			}
			else if (productId == "com.kiloo.subways.bundletier2")
			{
				if (itemRequested != null)
				{
					obj7 = 0;
					if (itemRequested._stringLength != 0)
					{
						goto IL_13ef;
					}
				}
				obj7 = 1;
				goto IL_13ef;
			}
		}
		else if ((nint)obj3 <= -752946264)
		{
			if ((nint)obj3 <= 1932373299)
			{
				if ((nint)obj3 != 1650900398)
				{
					if ((nint)obj3 != 1844237098)
					{
						if ((nint)obj3 == 1932373299 && !(productId != "com.kiloo.subways.keystier4discount"))
						{
							goto IL_0550;
						}
					}
					else if (!(productId != "com.kiloo.subways.coinstier2_discount"))
					{
						goto IL_08bd;
					}
				}
				else if (productId == "com.kiloo.subways.coinstier1discount")
				{
					goto IL_11b1;
				}
			}
			else if ((nint)obj3 != -896110176)
			{
				if ((nint)obj3 != -860494863)
				{
					if ((nint)obj3 == -752946264 && productId == "com.kiloo.subways.keystier4")
					{
						goto IL_0550;
					}
				}
				else if (productId == "com.kiloo.subways.doublecoins")
				{
					goto IL_0d3d;
				}
			}
			else if (!(productId != "com.kiloo.subways.keystier1discount"))
			{
				goto IL_0afd;
			}
		}
		else if ((nint)obj3 <= -635502931)
		{
			if ((nint)obj3 != -669058169)
			{
				if ((nint)obj3 != -652280550)
				{
					if ((nint)obj3 == -635502931 && !(productId != "com.kiloo.subways.keystier3"))
					{
						goto IL_0c7d;
					}
				}
				else if (productId == "com.kiloo.subways.keystier2")
				{
					goto IL_0bbd;
				}
			}
			else if (productId == "com.kiloo.subways.keystier1")
			{
				goto IL_0afd;
			}
		}
		else if ((nint)obj3 != -382292046)
		{
			if ((nint)obj3 != -381867850)
			{
				if ((nint)obj3 == -129943528 && productId == "com.kiloo.subways.coinstier3discount")
				{
					goto IL_0714;
				}
			}
			else if (productId == "com.kiloo.subways.keystier3discount")
			{
				goto IL_0c7d;
			}
		}
		else if (productId == "com.kiloo.subways.doublecoinsdiscount")
		{
			goto IL_0d3d;
		}
		if (!(productId == "com.kiloo.subways.bundletier5"))
		{
			return;
		}
		object obj8;
		if (itemRequested != null)
		{
			obj8 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_1431;
			}
		}
		obj8 = 1;
		goto IL_1431;
		IL_13ef:
		string text2 = "InApp Bundle 2 purchased" + string.Empty;
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._currentMissionSet;
		int num = obj + 12;
		string text3 = ((int*)num)->ToString();
		if (obj7 == null)
		{
			string text4 = text3 + ";" + itemRequested;
		}
		return;
		IL_132d:
		string text5 = "InApp Coin Pack 4 purchased" + string.Empty;
		PlayerInfo instance2 = PlayerInfo.Instance;
		_ = instance2._currentMissionSet;
		int num2 = obj + 12;
		string text6 = ((int*)num2)->ToString();
		object obj9;
		if (obj9 == null)
		{
			string text7 = text6 + ";" + itemRequested;
		}
		return;
		IL_11b1:
		object obj10;
		if (itemRequested != null)
		{
			obj10 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_1452;
			}
		}
		obj10 = 1;
		goto IL_1452;
		IL_0a3d:
		object obj11;
		if (itemRequested != null)
		{
			obj11 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_134e;
			}
		}
		obj11 = 1;
		goto IL_134e;
		IL_1410:
		string text8 = "InApp Bundle 3 purchased" + string.Empty;
		PlayerInfo instance3 = PlayerInfo.Instance;
		_ = instance3._currentMissionSet;
		int num3 = obj + 12;
		string text9 = ((int*)num3)->ToString();
		if (obj6 == null)
		{
			string text10 = text9 + ";" + itemRequested;
		}
		return;
		IL_12ca:
		string text11 = "InApp Key Pack 4 purchased" + string.Empty;
		PlayerInfo instance4 = PlayerInfo.Instance;
		_ = instance4._currentMissionSet;
		int num4 = obj + 12;
		string text12 = ((int*)num4)->ToString();
		object obj12;
		if (obj12 == null)
		{
			string text13 = text12 + ";" + itemRequested;
		}
		return;
		IL_0714:
		object obj13;
		if (itemRequested != null)
		{
			obj13 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_12eb;
			}
		}
		obj13 = 1;
		goto IL_12eb;
		IL_1452:
		string text14 = "InApp Coin Pack 1 purchased" + string.Empty;
		PlayerInfo instance5 = PlayerInfo.Instance;
		_ = instance5._currentMissionSet;
		int num5 = obj + 12;
		string text15 = ((int*)num5)->ToString();
		if (obj10 == null)
		{
			string text16 = text15 + ";" + itemRequested;
		}
		return;
		IL_0550:
		if (itemRequested != null)
		{
			obj12 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_12ca;
			}
		}
		obj12 = 1;
		goto IL_12ca;
		IL_12a9:
		string text17 = "InApp Bundle 4 purchased" + string.Empty;
		PlayerInfo instance6 = PlayerInfo.Instance;
		_ = instance6._currentMissionSet;
		int num6 = obj + 12;
		string text18 = ((int*)num6)->ToString();
		if (obj5 == null)
		{
			string text19 = text18 + ";" + itemRequested;
		}
		return;
		IL_08bd:
		object obj14;
		if (itemRequested != null)
		{
			obj14 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_130c;
			}
		}
		obj14 = 1;
		goto IL_130c;
		IL_1288:
		string text20 = "InApp Bundle 1 purchased" + string.Empty;
		PlayerInfo instance7 = PlayerInfo.Instance;
		_ = instance7._currentMissionSet;
		int num7 = obj + 12;
		string text21 = ((int*)num7)->ToString();
		if (obj4 == null)
		{
			string text22 = text21 + ";" + itemRequested;
		}
		return;
		IL_136f:
		string text23 = "InApp Key Pack 1 purchased" + string.Empty;
		PlayerInfo instance8 = PlayerInfo.Instance;
		_ = instance8._currentMissionSet;
		int num8 = obj + 12;
		string text24 = ((int*)num8)->ToString();
		object obj15;
		if (obj15 == null)
		{
			string text25 = text24 + ";" + itemRequested;
		}
		return;
		IL_134e:
		string text26 = "InApp Coin Pack 5 purchased" + string.Empty;
		PlayerInfo instance9 = PlayerInfo.Instance;
		_ = instance9._currentMissionSet;
		int num9 = obj + 12;
		string text27 = ((int*)num9)->ToString();
		if (obj11 == null)
		{
			string text28 = text27 + ";" + itemRequested;
		}
		return;
		IL_130c:
		string text29 = "InApp Coin Pack 2 purchased" + string.Empty;
		PlayerInfo instance10 = PlayerInfo.Instance;
		_ = instance10._currentMissionSet;
		int num10 = obj + 12;
		string text30 = ((int*)num10)->ToString();
		if (obj14 == null)
		{
			string text31 = text30 + ";" + itemRequested;
		}
		return;
		IL_0c7d:
		object obj16;
		if (itemRequested != null)
		{
			obj16 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_13b1;
			}
		}
		obj16 = 1;
		goto IL_13b1;
		IL_12eb:
		string text32 = "InApp Coin Pack 3 purchased" + string.Empty;
		PlayerInfo instance11 = PlayerInfo.Instance;
		_ = instance11._currentMissionSet;
		int num11 = obj + 12;
		string text33 = ((int*)num11)->ToString();
		if (obj13 == null)
		{
			string text34 = text33 + ";" + itemRequested;
		}
		return;
		IL_1431:
		string text35 = "InApp Bundle 5 purchased" + string.Empty;
		PlayerInfo instance12 = PlayerInfo.Instance;
		_ = instance12._currentMissionSet;
		int num12 = obj + 12;
		string text36 = ((int*)num12)->ToString();
		if (obj8 == null)
		{
			string text37 = text36 + ";" + itemRequested;
		}
		return;
		IL_13b1:
		string text38 = "InApp Key Pack 3 purchased" + string.Empty;
		PlayerInfo instance13 = PlayerInfo.Instance;
		_ = instance13._currentMissionSet;
		int num13 = obj + 12;
		string text39 = ((int*)num13)->ToString();
		if (obj16 == null)
		{
			string text40 = text39 + ";" + itemRequested;
		}
		return;
		IL_097d:
		if (itemRequested != null)
		{
			obj9 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_132d;
			}
		}
		obj9 = 1;
		goto IL_132d;
		IL_0d3d:
		object obj17;
		if (UIScreenController.IsInstanced)
		{
			UIScreenController instance14 = UIScreenController.Instance;
			string currentPopupName = instance14.GetCurrentPopupName();
			if (currentPopupName != null)
			{
				obj17 = 0;
				if (currentPopupName._stringLength != 0)
				{
					goto IL_13d2;
				}
			}
			obj17 = 1;
			goto IL_13d2;
		}
		string text41 = "Double Coin purchased" + string.Empty;
		PlayerInfo instance15 = PlayerInfo.Instance;
		_ = instance15._currentMissionSet;
		int num14 = obj + 12;
		string text42 = ((int*)num14)->ToString();
		return;
		IL_13d2:
		if (obj17 != null)
		{
			string text43 = "Double Coin purchased" + string.Empty;
			PlayerInfo instance16 = PlayerInfo.Instance;
			_ = instance16._currentMissionSet;
			int num15 = obj + 12;
			string text44 = ((int*)num15)->ToString();
			return;
		}
		UIScreenController instance17 = UIScreenController.Instance;
		string currentPopupName2 = instance17.GetCurrentPopupName();
		if (currentPopupName2 == "TutorialDoubleCoinsPopup")
		{
			string text45 = "Double Coin purchased GameOver" + string.Empty;
			PlayerInfo instance18 = PlayerInfo.Instance;
			_ = instance18._currentMissionSet;
			int num16 = obj + 12;
			string text46 = ((int*)num16)->ToString();
		}
		else
		{
			string text47 = "Double Coin purchased" + string.Empty;
			PlayerInfo instance19 = PlayerInfo.Instance;
			_ = instance19._currentMissionSet;
			int num17 = obj + 12;
			string text48 = ((int*)num17)->ToString();
		}
		return;
		IL_0bbd:
		object obj18;
		if (itemRequested != null)
		{
			obj18 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_1390;
			}
		}
		obj18 = 1;
		goto IL_1390;
		IL_0afd:
		if (itemRequested != null)
		{
			obj15 = 0;
			if (itemRequested._stringLength != 0)
			{
				goto IL_136f;
			}
		}
		obj15 = 1;
		goto IL_136f;
		IL_1390:
		string text49 = "InApp Key Pack 2 purchased" + string.Empty;
		PlayerInfo instance20 = PlayerInfo.Instance;
		_ = instance20._currentMissionSet;
		int num18 = obj + 12;
		string text50 = ((int*)num18)->ToString();
		if (obj18 == null)
		{
			string text51 = text50 + ";" + itemRequested;
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "[Flurry] " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static Flurry()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.AB7543477046058BEAF60462687B2688215D3435EF0517AC5D9B29D91110FBDA));
		throw new ArrayTypeMismatchException();
	}
}
