using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.Rendering;

public static class Flurry
{
	public const string EVENT_UISCREEN_CHANGED_PREFIX = "UI Screen ";

	public const string EVENT_POPUPSCREEN_CHANGED_PREFIX = "POPUP Screen ";

	public const string EVENT_FIRST_GAMECENTER_LOGIN = "First GameCenter Login";

	public const string EVENT_FIRST_FACEBOOK_LOGIN = "First Facebook Login";

	public const string EVENT_SOCIAL_POKE = "Social friend poked";

	public const string EVENT_SOCIAL_BRAG = "Social bragged";

	public const string EVENT_SOCIAL_BRAGFACEBOOK = "Social bragged Facebook";

	public const string EVENT_SOCIAL_FACEBOOK_FRIENDS_RETRIEVED = "Social Facebook Friends Retrieved";

	public const string EVENT_SOCIAL_GC_FRIENDS_RETRIEVED = "Social GameCenter Friends Retrieved";

	public const string EVENT_SOCIAL_FRIENDS_CONSOLIDATED = "Social Friends Consolidated";

	public const string EVENT_FACEBOOK_STATUS = "Facebook status";

	private const string HAS_LOGGED_DAILY_EVENT_SOCIAL_PREFIX = "socflurdaily";

	public const string EVENT_MYSTERY_BOX_OPENED = "Mystery Box opened";

	public const string EVENT_MINIMYSTERY_BOX_OPENED = "Mini Mystery Box opened";

	public const string EVENT_SUPER_MYSTERY_BOX_OPENED = "Super mystery box opened";

	public const string EVENT_INAPPPURCHASE_COMPLETED = "InApp purchase completed";

	public const string EVENT_INAPPPURCHASE_COINPACK1 = "InApp Coin Pack 1 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK2 = "InApp Coin Pack 2 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK2_5 = "InApp Coin Pack 2.5 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK3 = "InApp Coin Pack 3 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK4 = "InApp Coin Pack 4 purchased";

	public const string EVENT_INAPPPURCHASE_COINPACK5 = "InApp Coin Pack 5 purchased";

	public const string EVENT_INAPPPURCHASE_KEYPACK1 = "InApp Key Pack 1 purchased";

	public const string EVENT_INAPPPURCHASE_KEYPACK1_5 = "InApp Key Pack 1.5 purchased";

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

	public const string EVENT_DAYS_PASSED_SINCE_LAST_PLAY = "Days passed since last play";

	public const string EVENT_BUY_HOVERBOARD_FROM_POPUP = "Purchase hoverboard from popup";

	public const string EVENT_BUY_SCOREBOOSTER_FROM_POPUP = "Purchase scorebooster from popup";

	public const string EVENT_BUY_HEADSTART_FROM_POPUP = "Purchase headstart from popup";

	public const string EVENT_APPLICATION_AUTHENTICITY = "Application Authenticity";

	public const string EVENT_UNKNOWN_GPU = "Unknown GPU";

	public const string EVENT_DEVICE_PERFORMANCE = "Device performance";

	public const string EVENT_END_OF_RUN_AVG_FPS = "InRunAvgFPS";

	public const string EVENT_END_OF_RUN_POWERUPS_USED = "Powerups used in run";

	public const string EVENT_CHARACTERS_OWNED = "Characters owned";

	public const string EVENT_HOVERBOARDS_OWNED = "Hoverboards owned";

	public const string EVENT_CHARACTER_OUTFITS_OWNED = "Character outfits owned";

	public const string EVENT_HOVERBOARD_ABILITIES_OWNED = "Hoverboard abilities owned";

	public const string EVENT_ACTIVATED_HOVERBOARD = "Boost hoverboard activated";

	public const string EVENT_ACTIVATED_HEADSTART = "Boost headstart activated";

	public const string EVENT_ACTIVATED_SCOREBOOSTER = "Boost scorebooster activated";

	public const string EVENT_DAILY_BUNDLEIDENTIFIER = "The current bundle identifier";

	public const string EVENT_DEVICE_LOCALE = "Device locale";

	public const string EVENT_BOARD_BUNDLE_POPUP_SHOWN = "Board bundle popup shown";

	public const string EVENT_STORAGE_MAIN_FOLDER_SIZE = "Main Storage Sizes";

	public const string EVENT_STORAGE_PROVIDER_FOLDER_SIZE = "Provider Storage Sizes";

	public const string EVENT_GAMEOVER_DOUBLECOINS_PRESSED = "Double Coin button pressed";

	public const string EVENT_FIRST_VALIDATED_PURCHASE = "First Validated Purchase";

	public const string EVENT_FIRST_PURCHASE_POPUP = "First purchase popup";

	public const string EVENT_PUSH_NOTIFICATION_OPENED = "PushNotificationOpen";

	public const string EVENT_WELCOME_PACK_PURCHASED = "welcome_pack_purchased";

	public const string EVENT_FRONT_SCREEN_PROMOTION_POPUP = "Front Screen Promotion Popup";

	public const string EVENT_MISSIONSET_COMPLETED = "Mission Set completed";

	public const string EVENT_DAILY_CHALLENGE_COMPLETED = "Daily Challenge completed";

	public const string EVENT_FILEUTIL_LOAD_CORRUPTED = "FileUtil load corrupted";

	public const string EVENT_FILEUTIL_SAVE_EXCEPTION = "FileUtil Save Exception";

	public const string EVENT_FILEUTIL_SAFE_SAVE_EXCEPTION = "FileUtil SafeSave Exception";

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

	public const string EVENT_DAILY_ONLINE_STATUS = "Daily Check of Online Status";

	public const string EVENT_NOTIFICATIONS_STATE = "State of notifications";

	public const string EVENT_REMINDERS_STATE = "State of reminders";

	public const string EVENT_SSEVENT_POPUP_SHOWN = "Event Popup was shown";

	public const string EVENT_HOVERBOARD_TRIED = "Event Popup was shown";

	public const string EVENT_ACTIVE_CHARACTER = "Currently active character";

	public const string EVENT_ACTIVE_BOARD = "Currently active board";

	public const string EVENT_SKIPPED_CHARACTER_FOR_CHARACTER_NAME_EVENT = "Skipped character for Wordy Weekend";

	public const string EVENT_UNLOCKED_CHARACTER_FOR_CHARACTER_NAME_EVENT_WITH_PARAMETERS = "Unlocked character for Wordy Weekend";

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

	public const string EVENT_NO_FILL_FOR_DOUBLE_BUTTON = "No fill for double button";

	public const string EVENT_LIMITED_CHARACTER_POPUP_CLOSED = "Limited character popup closed";

	public const string EVENT_LIMITED_BOARD_POPUP_CLOSED = "Limited board popup closed";

	public const string EVENT_FIRST_INSTALL_DATE = "First install date";

	public const string EVENT_CONSUMABLES_SOLD_DURING_RUN = "Consumables Sold During Run";

	public const string EVENT_ABTEST_DAILY_REPORT = "A/B test daily report";

	public const string EVENT_ABTEST_INAPP_OPENED = "A/B Product Click";

	public const string EVENT_ABTEST_SCREEN_OPENED = "A/B Screen Opened";

	public const string EVENT_ABTEST_AD_REMOVAL_POPUP_SHOWN = "A/B Ad Removal Popup Shown";

	public const string EVENT_RESTORED_VALIDATED_ITEM = "Restored item";

	public const string EVENT_EXIT_TUTORIAL_AREA = "Tutorial exit";

	public const string EVENT_FIRST_TIME_FRONT_SCREEN = "First front screen";

	public const string EVENT_TUTORIAL_HOVERBOARD = "Tutorial hoverboard activated";

	public const string EVENT_RUNS_FOR_MISSION = "Runs completed for mission";

	public const string EVENT_FRONT_SCREEN_FLOW = "Front screen flow";

	public const string EVENT_GAMEOVER_SCREEN_FLOW = "Game over screen flow";

	public const string EVENT_MANUALLY_CLOSED_AD_OVERLAY = "Manually closed ad overlay";

	public const string EVENT_SHOW_COINS_VIDEO_BUTTON = "Attempt to show not enough coin video button";

	public const string EVENT_UI_SCREEN_NOT_ENOUGH_CURRENCY_POPUP = "NotEnoughCurrencyPopup";

	public const string EVENT_ADSYSTEM_PROVIDER_TIME_LIMIT_REACHED = "Provider Time Limit Reached";

	public const string EVENT_ATTEMPT_TO_FILL = "Attempt to fill {0}";

	public const string EVENT_ADSYSTEM_AD_LOCATION_EVENT_NAME = "Ad Location: {0}";

	public const string EVENT_OFFERWALL_LOADING = "Attempt loading OfferWall";

	public const string EVENT_OFFERWALL_SHOWN = "OfferWall Shown";

	public const string EVENT_OFFERWALL_CLOSED = "OfferWall Closed";

	public const string EVENT_OFFERWALL_EARNED_POINTS = "OfferWall Earned Points";

	public const string EVENT_OFFERWALL_GET_POINTS = "OfferWall Get Points";

	public const string EVENT_OFFERWALL_SPEND_POINTS = "OfferWall Spend Points";

	public const string EVENT_HOVERBOARD_THEME_BOUGHT = "Hoverboard Theme bought";

	public const string EVENT_HOVERBOARD_THEME_ACTIVATED = "Hoverboard Theme activated";

	public const string EVENT_HOVERBOARD_THEME_DEACTIVATED = "Hoverboard Theme deactivated";

	public const string EVENT_BOOST_SCOREBOOSTER_PURCHASED = "Boost Scorebooster purchased";

	public const string EVENT_BOOST_HEADSTART2000_PURCHASED = "Boost Headstart2000 purchased";

	public const string EVENT_BOOST_HOVERBOARD_PURCHASED = "Boost Hoverboard purchased";

	public const string EVENT_BOOST_COINMAGNET_PURCHASED = "Boost Coinmagnet purchased";

	public const string EVENT_BOOST_DOUBLEMULTIPLIER_PURCHASED = "Boost 2x multiplier purchased";

	public const string EVENT_BOOST_JETPACK_PURCHASED = "Boost jetpack purchased";

	public const string EVENT_BOOST_LETTERS_PURCHASED = "Boost letters purchased";

	public const string EVENT_BOOST_SUPERSNEAKERS_PURCHASED = "Boost supersneakers purchased";

	public const string EVENT_BOOST_MYSTERYBOX_PURCHASED = "Boost MysteryBox purchased";

	public const string EVENT_BOOST_MISSION_SKIP_PURCHASED = "Boost Mission Skip purchased";

	public const string EVENT_BOOST_MISSION_SKIP_INFO = "Boost Mission Skip info";

	public const string EVENT_BOOST_MYSTERYBOX_VIEW_PRIZES = "Mysterybox view prices";

	public const string EVENT_SUPER_MYSTERYBOX_VIEW_PRIZES = "Super Mystery Box prizes";

	public const string EVENT_MINI_MYSTERYBOX_VIEW_PRIZES = "Mini Mystery Box prizes";

	public const string EVENT_SAVE_ME_CLICKED = "Save Me clicked";

	public const string EVENT_SAVE_ME_SHOWN = "Save Me shown";

	public const string EVENT_RESUMED_AFTER_REVIVE_WITH_VIDEO = "Resumed run after revive with video";

	public const string EVENT_END_OF_RUN = "End of run";

	public const string EVENT_WEEKLY_CHALLENGE_COMPLETED = "Weekly Challenge Completed";

	public const string EVENT_WEEKLY_CHALLENGE_PERIOD_PROGRESS = "WeeklyHunt Progress";

	public const string EVENT_INTERSTITIAL_GAME_OVER_COUNTER = "Interstitial Game Over Counter";

	public const string EVENT_INTERSTITIAL_NATIVE_ADVIEW_AD_INVALID = "Native Ad Invalid";

	public const string EVENT_AWARD_TIER_COMPLETED = "Award tier completed";

	public const string EVENT_AWARD_COMPLETED = "Award completed";

	public const string EVENT_AWARD_TIER_COMPLETED_TIME = "Award tier completed time";

	public const string EVENT_AWARD_TIER_COLLECTED_TIME = "Award tier collected time";

	public const string EVENT_AMOUNT_OF_DIAMOND_AWARDS_FINISHED = "Total amount of diamond awards finished";

	public const string EVENT_AMOUNT_OF_GOLD_AWARDS_FINISHED = "Total amount of gold awards finished";

	public const string EVENT_AMOUNT_OF_SILVER_AWARDS_FINISHED = "Total amount of silver awards finished";

	public const string EVENT_ASSET_BUNDLE_FAILED_TO_CACHE = "Asset Bundle Failed to be Cached";

	public const string EVENT_ASSET_BUNDLE_FAILED_LOAD_FROM_CACHE = "Asset Bundle Failed to be loaded from Cache";

	public const string EVENT_ASSET_BUNDLE_FAILED_DOWNLOAD = "Asset Bundle Failed to Download";

	public const string EVENT_ASSET_BUNDLE_AVAILABILITY_CHECK_FAILED = "Asset Bundles Availability Check Failed";

	public const string EVENT_ASSET_BUNDLES_ALL_DOWNLOADED = "All Asset Bundle Downloads completed";

	public const string EVENT_CHALLENGES_SCREEN_PAGE_SHOWN = "Challenges screen shown";

	public const string EVENT_MISSIONS_VIDEO_BUTTON_FILL = "Mission video fill attempt";

	public const string EVENT_MISSIONS_VIDEO_BUTTON_PAUSE_BUTTON_FILL = "Mission video game pause fill attempt";

	public const string EVENT_PLAYER_BIRTHDAY = "Player Birthday entered";

	public const string EVENT_CONSENT_GIVEN = "Consent given";

	public const string EVENT_CONSENT_WITHDRAWN = "Consent withdrawn";

	public const string EVENT_CONSENT_PRIVACY_POLICY_OPENED = "Consent Privacy Policy link opened";

	public const string EVENT_BIRTHDAY_BOARD_BOARD_SCREEN_SHOWED = "Birthday Board showed on Board screen";

	public const string EVENT_BIRTHDAY_BOARD_POPUP_SHOWED = "Birthday Board showed in popup";

	public const string EVENT_ONLINE_SETTINGS_PARSING_FAILED = "Error deserializing JSon OnlineSettings";

	public const string EVENT_MIGRATION_ERROR_PLAYERINFO = "PlayerInfo Migration error";

	public const string EVENT_MIGRATION_ERROR_PLAYERPREFS = "PlayerPrefs Migration error";

	public const string EVENT_MIGRATION_UNHANDLED_UPGRADES = "Migration unhandled upgrades";

	public const string EVENT_SAVE_DATA_LOAD_ERRORS = "SaveData load error";

	public const string EVENT_SAVE_DATA_SAVE_ERRORS = "SaveData save error";

	public const string EVENT_SOFT_CURRENCY_SPENT = "Soft currency spent";

	public const string EVENT_SOFT_CURRENCY_EARNED = "Soft currency earned";

	public const string EVENT_FRONT_SCREEN_BUTTON_WITH_FOOTER_CLICKED = "FrontScreenButtonWithFooterClicked";

	public const string EVENT_FOOTER_BUTTON_CLICKED = "FooterButtonClicked";

	public const string EVENT_CONSUMABLE_VIDEO_FILL_ATTEMPT = "Consumable video fill attempt";

	public const string EVENT_DOUBLE_COINS_VIDEO_ATTEMPT = "DoubleCoinsVideoAttempt";

	public const string EVENT_DOUBLE_COINS_VIDEO_RESULT = "DoubleCoinsVideoResult";

	public const string EVENT_RESULT_OF_AD_SHOWN = "Result of ad shown";

	public const string EVENT_ATTEMPT_TO_SHOW_BUTTON = "Attempt to show button";

	public const string EVENT_VIDEO_AD_BUTTON_CLICK = "{0}_generic";

	public const string EVENT_ATTEMPT_TO_CACHE_RESULT = "AttemptToCacheResult";

	public const string EVENT_WATERFALL_REACH = "WaterfallReach";

	public const string EVENT_ATTEMPT_TO_SHOW_AD = "Attempt to show ad";

	public const string EVENT_ARGKEY_HAS_FILL = "HasFill";

	public const string EVENT_ARGKEY_IS_FACEBOOK_LOGGED_IN = "IsFacebookLoggedin";

	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_ELEMENT_TYPE = "ElementType";

	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_CLICKED = "IsDoubleCoinsVideoClicked";

	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_PAYOUT_AMOUNT = "VideoPayoutAmount";

	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_CHARGE = "IsCharged";

	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_WAS_SHOWN = "ElementShown";

	public const string EVENT_ARGKEY_ID = "Id";

	public const string EVENT_ARGKEY_TIER = "Tier";

	public const string EVENT_ARGKEY_UI_SCREENNAME = "Screen Name";

	public const string EVENT_ARGKEY_MISSIONSET = "Mission Set";

	public const string EVENT_ARGKEY_MISSIONSET_AND_INDEX = "Mission Set and Index";

	public const string EVENT_ARGKEY_MISSION_SKIPPED_FROM = "Mission Skipped From";

	public const string EVENT_ARGKEY_MISSION_CAN_SKIP_FROM_PAUSE = "Can skip from pause";

	public const string EVENT_ARGKEY_MISSION_SKIP_WITH_VIDEO = "Video";

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

	public const string EVENT_ARGKEY_CHARACTER_NAME_ACTION_PRICE = "Price";

	public const string EVENT_ARGKEY_CHARACTER_NAME_CHARACTER = "Character";

	public const string EVENT_ARGKEY_CHARACTER_NAME_SKIPPED_WITH_AD = "Watched ad";

	public const string EVENT_ARGKEY_GPU_NAME = "GPU name";

	public const string EVENT_ARGKEY_PERFOMRNACE_LEVEL = "Level";

	public const string EVENT_ARGKEY_FPS_RANGE = "FPS range {0}";

	public const string EVENT_ARGKEY_ITEMS_OWNED_REGULAR = "regular";

	public const string EVENT_ARGKEY_ITEMS_OWNED_LIMITED = "limited";

	public const string EVENT_ARGKEY_ITEMS_OWNED_TOKEN = "token";

	public const string EVENT_ARGKEY_ITEMS_OWNED_FACEBOOK = "facebook";

	public const string EVENT_ARGKEY_ITEMS_OWNED_TOTAL = "total";

	public const string EVENT_ARGKEY_ACTIVATED_BOOST_SUCCESSFULLY = "successfully";

	public const string EVENT_ARGKEY_AWARDS_DIAMOND_COMPLETED = "Completed Diamond Awards";

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

	public const string EVENT_ARGKEY_REVIVE = "Revive";

	public const string EVENT_ARGKEY_PLAYER_BIRTHDAY = "Player birthday";

	public const string EVENT_ARGKEY_ABTEST_IDENTIFIER = "Identifier";

	public const string EVENT_ARGKEY_ABTEST_PAYLOAD = "Payload";

	public const string EVENT_ARGKEY_ABTEST_TAG = "Tag";

	public const string EVENT_ARGKEY_DEVICE_LOCALE = "Locale";

	public const string EVENT_ARGKEY_INAPP_ID = "productID";

	public const string EVENT_ARGKEY_INAPP_SCREEN = "screen";

	public const string EVENT_ARGKEY_STORE_VISITS = "store_visits";

	public const string EVENT_ARGKEY_EARN_COINS_VISITS = "earn_coins_visits";

	public const string EVENT_ARGKEY_BOOST_VISITS = "boosts_visits";

	public const string EVENT_ARGKEY_QUICK_STORE_VISITS = "quick_store_visits";

	public const string EVENT_ARGKEY_SHOW_SOURCE = "show_source";

	public const string EVENT_ARGKEY_SHOW_OUTCOME = "show_outcome";

	public const string EVENT_ARGKEY_FACEBOOK_LOGIN_SOURCE = "Facebook Login Source";

	public const string EVENT_ARGKEY_FIRST_VALID_PURCHASE_PRODUCT_ID = "Product ID";

	public const string EVENT_ARGKEY_PROVIDER = "Provider";

	public const string EVENT_ARGKEY_LOCATION = "Location";

	public const string EVENT_ARGKEY_REWARD = "Reward";

	public const string EVENT_ARGKEY_BIRTHDAY_BOARD_RETRIES = "Number of retries";

	public const string EVENT_ARGKEY_BIRTHDAY_BOARD_DID_WATCH = "Did watch ad";

	public const string EVENT_ARGKEY_MESSAGE = "Message";

	public const string EVENT_ARGKEY_TYPE = "Type";

	public const string EVENT_ARGKEY_JOBID = "JobID";

	public const string EVENT_ARGKEY_VIDEO_NOT_SHOWN = "NotShown";

	public const string EVENT_ARGKEY_VIDEO_AVAILABLE = "Available";

	public const string EVENT_ARGKEY_VIDEO_NO_FILL = "NoFill";

	public const string EVENT_ARGKEY_VIDEO_FILL = "Fill";

	public const string EVENT_ARGKEY_AD_LOCATION_EVENT_OUTCOME = "Outcome";

	public const string EVENT_ARG_AD_LOCATION_EVENT_OUTCOME = "{0};{1}";

	public const string EVENT_ARGKEY_ATTEMPT_TO_SHOW_AD = "Attempt to show ad";

	public const string EVENT_ARGKEY_SUCCESS = "Success";

	public const string EVENT_ARGKEY_FAILED = "Failed";

	public const string EVENT_ARGKEY_FILL_REQUEST = "Fill Request";

	public const string EVENT_ARGKEY_AD_AVAILABLE = "AdAvailable";

	public const string EVENT_ARGKEY_NO_AD_AVAILABLE = "NoAdAvailable";

	public const string EVENT_ARGKEY_TIMED_OUT = "Timedout";

	public const string EVENT_ARGKEY_NO_FILL_CACHE_TIMEOUT = "NoFillCacheTimeout";

	public const string EVENT_ARGKEY_FAILED_SHOWING_AD = "FailedShowingAd";

	public const string EVENT_ARGKEY_SHOWED_AD = "ShowedAd";

	public const string EVENT_ARGKEY_ALREADY_CACHED = "AlreadyCached";

	public const string EVENT_ARGKEY_NO_FILL_BUTTON_TIMEOUT = "NoFillButtonTimeout";

	public const string EVENT_ARGKEY_NO_FILL_END_OF_WATERFALL = "NoFillEndOfWaterfall";

	public const string EVENT_ARGKEY_NO_CACHED_AD = "No cached ad";

	public const string EVENT_ARGKEY_NO_CLICK_INFO = "NoClickInfo";

	public const string EVENT_ARGKEY_EARLY = "Early";

	public const string EVENT_ARGKEY_FINISHED = "Finished";

	public const string EVENT_ARGKEY_CLICK = "Click";

	public const string EVENT_ARGKEY_SCREEN_NAME_WATER_FALL_REACH = "screen_name;waterfall reach";

	public const string EVENT_ARGKEY_NOT_CURRENT = "NotCurrent";

	public const string EVENT_ARGKEY_VIDEO_STATUS = "Video status";

	public const string EVENT_ARGKEY_SAVE_ME_POPUP_COUNT = "Count";

	public const string EVENT_ARGKEY_KEYS_NO_VIDEO = "KeysNoVideo";

	public const string EVENT_ARGKEY_KEYS_VIDEO = "KeysVideo";

	public const string EVENT_ARGKEY_VIDEO = "Video";

	public const string EVENT_ARGKEY_ACTION = "Action";

	public const string EVENT_ARGKEY_NUMBER_OF_REVIVES = "Number of revives";

	public const string EVENT_ARGKEY_USED_VIDEO = "Used video";

	public const string EVENT_ARGKEY_REVIVE_VIDEO_NOT_AVAILABLE = "Video not available";

	public const string EVENT_ARGKEY_SOURCE_OF_PURCHASE = "source_of_purchase";

	public const string EVENT_ARGKEY_BOUGHT_IN_RUN = "Bought in run";

	public const string EVENT_ARGKEY_ONLINE_SETTINGS_PARSING_FAILED_EXCEPTION = "Exception thrown deserializing JSon OnlineSettings";

	public const string EVENT_ARGKEY_SHOW_COINS_VIDEO_RESULT = "Result";

	public const string EVENT_ARG_SHOW_COINS_VIDEO_FILL = "Fill;";

	public const string EVENT_ARG_SHOW_COINS_VIDEO_NO_FILL = "No_Fill;";

	public const string EVENT_ARG_VIDEO_COINS_AVAILABLE = "Video_Available";

	public const string EVENT_ARG_POPUP_VIDEO_COINS_CLICKED = "Button_Name";

	public const string EVENT_ARG_POPUP_VIDEO_COINS_REWARD = "Video_Reward";

	public const string EVENT_ARG_POPUP_VIDEO_COINS_COOLDOWN = "Cooldown_step";

	public const string EVENT_ARGKEY_POPUPRESULT_OK = "Ok";

	public const string EVENT_ARGKEY_POPUPRESULT_CANCEL = "Cancel";

	public const string EVENT_ARGKEY_ASKRATE = "Ask again";

	public const string EVENT_ARGKEY_DONTASKRATE = "Do not ask again";

	public const string EVENT_ARGKEY_PERFORMANCE_LEVEL_LOW = "Low";

	public const string EVENT_ARGKEY_PERFORMANCE_LEVEL_HIGH = "High";

	public const string EVENT_ARGKEY_GPU_NAME_WITH_VALUE = "GPU name {0}";

	public const string EVENT_ARG_YES = "yes";

	public const string EVENT_ARG_NO = "no";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_CHANCE = "Chance";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_FILL = "Fill";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_NO_CHANCE = "No Chance";

	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_NO_FILL = "No Fill";

	public const string EVENT_ARGKEY_DOUBLE_UP_OPTION_RESULT_DOUBLED = "Doubled";

	public const string EVENT_ARGKEY_DOUBLE_UP_OPTION_RESULT_NOT_DOUBLED = "Not Doubled";

	public const string EVENT_ARGKEY_NATIVE_DOWNLOAD_VALUE = "ad download failed";

	public const string EVENT_ARGKEY_NATIVE_TEXT_VALUE_FORMAT = "total: {0} after: {1} - country:{2}";

	public const string EVENT_ARGKEY_NATIVE_IMAGE_VALUE_FORMAT = "ratio: {0} - country:{1}";

	public const string EVENT_ARGKEY_NATIVE_IMAGE_NAME_COVER = "Cover";

	public const string EVENT_ARGKEY_NATIVE_IMAGE_NAME_ICON = "Icon";

	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_TITLE = "Title";

	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_BODY = "Body";

	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_CTA = "Call To Action";

	public const string EVENT_ARGKEY_PLAYER_BIRTHDAY_VALUE = "{0}-{1}";

	public const string EVENT_ARGKEY_CONSENT_WITHDRAWN_RESULT = "Result";

	public const string EVENT_ARGKEY_MISSION_RUNS = "Runs completed";

	public const string EVENT_ARGKEY_TUTORIAL_SCREEN_FLOW = "Screen order";

	public const string EVENT_ARGKEY_SKIPPED_MISSIONS = "Skipped missions";

	public const string EVENT_ARGKEY_MOVED_TO_STORE = "Moved to store";

	public const string EVENT_ARGKEY_CLOSED = "Closed";

	public const string EVENT_ARGKEY_PURCHASED = "Purchased";

	public const string EVENT_ARGKEY_BUTTON_NAME = "button_name";

	public const string EVENT_ARGKEY_BOUGHT_WITH_KEYS = "bought using keys";

	public const string EVENT_ARGKEY_NOT_ENOUGH_KEYS = "not enough keys";

	public const string EVENT_ARGKEY_BOUGHT_WITH_IAP = "bought using iap";

	public const string EVENT_ARGKEY_BOUGHT_WITH_IAP_FAIL = "bought using iap fail";

	public const string EVENT_ARGKEY_BOUGHT_WITH_COINS = "bought using coins";

	public const string EVENT_ARGKEY_NOT_ENOUGH_COINS = "not enough coins";

	public const string EVENT_ARGKEY_OFFERWALL_ORIGIN = "Origin";

	public const string EVENT_ARGKEY_OFFERWALL_AMOUNT = "Amount";

	public const string EVENT_ARGKEY_OFFERWALL_RESULT = "Result";

	public const string EVENT_ARGKEY_OFFERWALL_MESSAGE = "Message";

	public const string EVENT_ARGKEY_OFFERWALL_RESULT_FAILED = "Failed";

	public const string EVENT_ARGKEY_MIGRATION_ERROR_TYPE = "Exception Type";

	public const string EVENT_ARGKEY_MIGRATION_ERROR_LAST_KEY = "Last loaded key";

	public const string EVENT_ARGKEY_SAVE_DATA_ERROR_TYPE = "Exception Type";

	public const string EVENT_ARGKEY_MIGRATION_SOURCE_VERSION = "Migrated from";

	public const string EVENT_ARGKEY_MIGRATION_UNHANDLED_UPGRADES = "Unhandled powerup";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_OFFERWALL = "Offerwall";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_MYSTERYBOX = "MysteryBox";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_INRUN = "InRun";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_FACEBOOK_GIFT = "FacebookGift";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_REVIVE = "Revive";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_WEEKLY_HUNT = "WeeklyHunt";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_FRIEND_REWARD = "FriendReward";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_OPEN_URL = "OpenUrl";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_MISSION_SET = "MissionSet";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_PLAYER_INFO_MIGRATION = "PlayerInfoMigration";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_DOUBLECOINS_VIDEO = "DoubleCoinsVideo";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_SKIPMISSION = "SkipMission";

	public const string EVENT_ARGKEY_CURRENCY_SOURCE_CHARACTERNAMESKIP = "WordyWeekendSkip";

	public const string EVENT_ARGKEY_CURRENCY_ID = "currency_id";

	public const string EVENT_ARGKEY_ITEM_ID = "item_id";

	public const string EVENT_ARGKEY_SOURCE_ID = "source_id";

	public const string EVENT_ARGKEY_SECOND_ITEM_ID = "item_id_2";

	public const string EVENT_CLOUDSAVE_UPDATE = "CloudSave Update";

	public const string EVENT_CLOUDSAVE_COMMIT = "CloudSave Commit";

	public const string EVENT_CLOUDSAVE_ENABLED = "CloudSave Enabled";

	public const string EVENT_CLOUDSAVE_DISCONNECTED = "CloudSave Disconnected";

	public const string EVENT_CLOUDSAVE_CONFLICT_RESOLVED = "CloudSave Conflict Resolved";

	public const string EVENT_CLOUDSAVE_STATUS_POPUP = "CloudSave Status Popup";

	public const string EVENT_CLOUDSAVE_INTRODUCTION_POPUP = "CloudSave Introduction Popup";

	public const string EVENT_CLOUDSAVE_REMINDER_POPUP = "CloudSave Reminder Popup";

	public const string EVENT_CLOUDSAVE_ADVANCED_COMPARISON_POPUP = "CloudSave Advanced Comparison Popup";

	public const string EVENT_CLOUDSAVE_CONFIRMATION_POPUP = "CloudSave Confirmation Popup";

	public const string EVENT_NATIVE_LOGIN = "Native Login";

	public const string EVENT_ARGKEY_COMPLETED_LOGIN = "CompletedLogin";

	public const string EVENT_ARGKEY_INTRODUCTION_CLOSE_CLICKED = "CloseClicked";

	public const string EVENT_ARGKEY_INTRODUCTION_SHOWN_COUNT = "ShownCount";

	public const string EVENT_ARGKEY_REMINDER_STATE_WHEN_SHOWN = "State";

	public const string EVENT_ARGKEY_KILOOTAG = "KilooTag";

	public const string EVENT_ARGKEY_SUCCESS_TIME = "SuccessTime";

	public const string EVENT_ARGKEY_FAIL_TIME = "FailTime";

	public const string EVENT_ARGKEY_UPDATE_CONFLICT_TIME = "ConflictTime";

	public const string EVENT_ARGKEY_COMMIT_STARTED = "Started";

	public const string EVENT_ARGKEY_COMMIT_ASYNC_STARTED = "AsyncStarted";

	public const string EVENT_ARGKEY_SUCCESS_ASYNC_TIME = "AsyncSuccessTime";

	public const string EVENT_ARGKEY_FAIL_ASYNC_TIME = "AsyncFailTime";

	public const string EVENT_ARG_BUTTON_CLICKED = "ButtonClicked";

	public const string EVENT_ARG_FROM_DISABLED_POPUP = "FromDisabledPopup";

	public const string EVENT_ARG_FROM_INTRODUCTION_POPUP = "FromIntroductionPopup";

	public const string EVENT_ARG_FROM_STATUS_POPUP = "FromStatusPopup";

	public const string EVENT_ARG_FROM_REMINDER_POPUP = "FromReminderPopup";

	public const string EVENT_ARG_FROM_SETTINGS_POPUP = "FromSettingsPopup";

	public const string EVENT_ARG_FROM_PROMOTION_POPUP = "FromPromotionPopup";

	public const string EVENT_ARGKEY_FROM_COMPARISON_POPUP = "FromComparisonPopup";

	public const string EVENT_ARGKEY_NATIVE_LOGGED_IN = "NativeLoggedIn";

	public const string EVENT_ARGKEY_NATIVE_LOGGED_OUT = "NativeLoggedOut";

	public const string EVENT_ARGKEY_SOURCE = "Source";

	public const string EVENT_ARGKEY_DISCONNECT = "Disconnect";

	public const string EVENT_ARGKEY_REMINDER_CLOSE = "Close";

	public const string EVENT_ARGKEY_REMINDER_FIX = "Fix";

	public const string EVENT_ARG_CONFIRMATION_KEEP_LOCAL = "KeepLocal";

	public const string EVENT_ARG_CONFIRMATION_KEEP_CLOUD = "KeepCloud";

	public const string EVENT_ARG_CONFIRMATION_LOAD_PROGRESS = "LoadProgress";

	public const string EVENT_ARGKEY_CONFIRMATION_STATE = "state";

	public const string EVENT_ARG_CONFIRMATION_GOOD = "Good";

	public const string EVENT_ARG_CONFIRMATION_BAD = "Bad";

	public const string EVENT_ARGKEY_CONSUMABLE_VIDEO_STATE = "video status";

	public const string EVENT_ARGKEY_CONSUMABLE_TYPE = "consumable";

	public const string EVENT_ARG_CONSUMABLE_VIDEO_STATE_FILL = "Fill-{0}";

	public const string EVENT_ARG_CONSUMABLE_VIDEO_STATE_NOFILL = "NoFill-{0}";

	public const string EVENT_ARG_FROM_COMPARISON_RECOMMENDING_THEIRS = "FromComparisonRecommendingTheirs";

	public const string EVENT_ARG_FROM_COMPARISON_RECOMMENDING_MINE = "FromComparisonRecommendingMine";

	public const string EVENT_ARG_FROM_COMPARISON_RECOMMENDING_NONE = "FromComparisonRecommendingNone";

	public const string EVENT_ARG_AUTO_RESOLVED = "AutoResolved";

	public const string EVENT_ARG_USING_THEIRS = "UsingTheirs";

	public const string EVENT_ARG_USING_MINE = "UsingMine";

	public const string EVENT_FREESTUFF_QUICKVIDEO_BUTTON_SHOWN = "Free Stuff Quick Video Ads Button Shown";

	public const string EVENT_ARG_FREESTUFF_QUICKVIDEO_VALUE_FORMAT = "step{0}|sinceDailyKeys{1}|{2}";

	public const string EVENT_ARG_FREESTUFF_QUICKVIDEO_SINCE_DAILY_KEYS = "SinceDailyKeys";

	public const string EVENT_FREE_STUFF_VIDEO_BUTTON = "Free Stuff Video Button";

	public const string EVENT_ARG_FREE_STUFF_VIDEO_BUTTON_SHOWN = "Shown";

	public const string EVENT_ARG_FREE_STUFF_VIDEO_BUTTON_CLICKED = "Clicked";

	public const string EVENT_ARG_FREE_STUFF_VIDEO_BUTTON_NO_FILL = "NoFill";

	public const string EVENT_ARG_HOVERBOARD_NAME = "Hoverboards";

	public const string EVENT_ARG_COINS_NAME = "Coins";

	public const string EVENT_ARG_SCORE_BOOSTER_NAME = "Score Booster";

	public const string EVENT_ARG_HEADSTART_NAME = "Headstart";

	private const string PLAYER_PREFS_FLURRY_USER_ID_KEY = "FLURRY_USER_ID_KEY";

	private static readonly int[][] FRIEND_BRACKETS;

	private static char[] PARAMETER_SPLITTERS;

	private const string VALIDATION_SUFFIX = " VALIDATED";

	public static string flurryUserId
	{
		get
		{
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_0210: Expected I, but got Obj
			//IL_0226: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0130: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_01c6: Expected Obj, but got I
			//IL_00c7: Expected I, but got Obj
			//IL_00f7: Expected I, but got Obj
			//IL_011d: Expected I, but got Obj
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (SSEventsManagerController._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SuperMysteryBoxEventManager superMysteryBoxEventManager = default;
				superMysteryBoxEventManager.SaveProgress();
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 == null;
				nint num4 = (nint)typeof(SSEventsManagerController);
				if (!flag)
				{
					nint num5 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<SSEventsManagerController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SSEventsManagerController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SSEventsManagerController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v8 (Il2CppClass<SSEventsManagerController>)+5C]");
				object obj3 = (nint)0 + (nint)24;
				obj3 = superMysteryBoxEventManager;
			}
			nint num6 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string)(object)SSEventsManagerController._instance;
		}
		set
		{
			value.m_stringLength = 2;
		}
	}

	public unsafe static bool wasInitialized
	{
		get
		{
			//IL_0065: Expected I, but got Obj
			//IL_007b: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserIdHash = GetFlurryUserIdHash();
			Coroutine str = CoroutineUtil.WaitForAll((IEnumerable<YieldInstruction>)(object)flurryUserIdHash);
			return TimeUtility.TryParseSortableNumber((string)(object)str, out *(DateTime*)null);
		}
	}

	public static void LogGameCenterLogin()
	{
	}

	public static void LogFacebookLogin(string facebookLoginSource)
	{
		((TooltipAttribute)(object)"FLURRY_USER_ID_KEY")._002Ector(facebookLoginSource);
		RenderPipelineManager.CleanupRenderPipeline();
	}

	public static void LogOkPressedOnPopup(string eventName)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		Dictionary<string, int> hasLoggedFlurryDailyEventSocial = AnalyticsSave.hasLoggedFlurryDailyEventSocial;
		if (hasLoggedFlurryDailyEventSocial != null)
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v10 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnalyticsSave.hasLoggedFlurryDailyEventSocial = (Dictionary<string, int>)1;
	}

	public static void LogClosePressedOnPopup(string eventName)
	{
		//IL_00a1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (eventName.get_Chars((int)string.Empty) == '\0')
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public static string ConvertFriendCountToBracket(int count)
	{
		//IL_001c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [count @ L0 (System.Int32)+10]");
		bool flag = (nint)0 > (nint)0;
		return (string)flag;
	}

	public static bool ShouldLogDailyEvent(string eventName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_0029: Expected I, but got Obj
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02c8: Expected Obj, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_00b7: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01da: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = eventName;
		object obj3 = obj2 + 4;
		object obj5 = default;
		object obj22 = default;
		object obj25 = default;
		string text2 = default;
		string text3 = default;
		while (true)
		{
			nint num = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v73 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int[][] fRIEND_BRACKETS = FRIEND_BRACKETS;
			object obj10;
			object obj20;
			object obj23;
			if ((nint)obj5 < fRIEND_BRACKETS.Length)
			{
				nint num3 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v24 (Il2CppClass<Flurry>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v67 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = FRIEND_BRACKETS + 16;
				object obj8 = obj5 << 2;
				object obj9 = obj7 + obj8;
				obj10 = obj9 + 24;
				object obj11 = FRIEND_BRACKETS + 16;
				object obj12 = obj5 << 2;
				object obj13 = obj11 + obj12;
				object obj14 = obj13 + 16;
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref eventName);
				object obj15 = FRIEND_BRACKETS + 16;
				object obj16 = obj5 << 2;
				object obj17 = obj15 + obj16;
				object obj18 = obj17 + 20;
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref eventName);
				object obj19 = flag | flag2;
				bool flag3 = obj19 == null;
				bool flag4 = !flag3;
				obj20 = obj14;
				object obj21 = obj22;
				if (!flag4)
				{
					while (true)
					{
						bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
						obj21 = obj22;
						if (flag5)
						{
							break;
						}
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) <= System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref eventName);
						obj23 = obj10 + obj20;
						bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) > System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref eventName);
						object obj24 = flag6 & flag7;
						if (obj24 == null)
						{
							obj22 = obj23;
							obj20 = obj23;
							continue;
						}
						goto IL_031b;
					}
				}
				obj5 = obj25 + 1;
				obj22 = obj21;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			break;
			IL_031b:
			if ((nint)obj10 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				break;
			}
			obj3 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj26 = obj23 - 1;
			obj2 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = text2 + "-" + text3;
			return (byte)(int)text != 0;
		}
		bool result = default;
		return result;
	}

	public static void StartSession(string apiKey)
	{
		//IL_00a1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (apiKey.get_Chars((int)string.Empty) == '\0')
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public unsafe static string GetFlurryUserIdHash()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		IndexOutOfRangeException ex = default;
		object obj = ex + 16;
		obj = 0;
		_ = 0;
		if (((LODParameters*)"FLURRY_USER_ID_KEY")->GetHashCode() == 0)
		{
			nint num = (nint)typeof(Guid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<System.Guid>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Guid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v32 (Il2CppClass<System.Guid>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ex._002Ector();
			obj = ex;
			_ = ((Exception)ex)._className;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EF7B");
			string tooltip = default;
			((TooltipAttribute)(object)"FLURRY_USER_ID_KEY")._002Ector(tooltip);
			RenderPipelineManager.CleanupRenderPipeline();
		}
		return (string)PlayerPrefs.HasKey("FLURRY_USER_ID_KEY");
	}

	public static void SetUserId()
	{
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath != 8 || AnalyticsSave.hasLoggedFacebookLogin)
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnalyticsSave.hasLoggedFacebookLogin = true;
	}

	public static void EndSession()
	{
	}

	public static void LogEvent(string eventName)
	{
	}

	public static void HandleFlurryUserIDBackup()
	{
	}

	public unsafe static void LogEventWithAParameter(string eventName, string argKey, string argValue)
	{
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_00f5: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_EVENT_TESTER = Globals.DEBUG_USE_EVENT_TESTER;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		string text2;
		string text4;
		if (dEBUG_USE_EVENT_TESTER)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v35 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_SMB");
			text2 = text;
			string text3 = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_SMB");
			text4 = text3;
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text5 = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_TITLE_SMB");
		bool flag2 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_first", out *(string*)text5);
		text2 = (string)flag2;
		string text6 = Strings.GetDefault("EVENTS_POPUP_DESCRIPTION_SECOND_TITLE_SMB");
		bool flag3 = Strings.TryGetLocalizedOnlineSettings("event_popup_description_second", out *(string*)text6);
		text4 = (string)flag3;
	}

	public static void LogEventWithSeveralParameters(string eventName, Dictionary<string, string> parameters)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = parameters;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			object obj4 = eventName + 8;
			obj4 = 0;
			((SSEventsManagerController)(object)eventName).SetCurrentEventManager();
		}
	}

	public static void LogEventWithSeveralParameters(string eventName, string argKeys, string argValues)
	{
	}

	private static Dictionary<string, string> ToDictionary(string argKeys, string argValues)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = 0;
		if (((SSEventsManagerController)(object)argKeys).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			object obj4 = obj5 - 3;
			if ((nint)obj5 != 3 && ((nint)obj4 == 1 || (nint)obj4 == 2 || (nint)obj4 == 3 || (nint)obj4 != 4))
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
			_ = 1;
			object obj6 = default;
			obj3 = obj6;
			if (obj != null)
			{
				obj2 = obj3;
				bool flag = obj2 == argValues;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				bool flag2 = (nint)0 != 0;
				return (Dictionary<string, string>)(flag & flag2);
			}
			return null;
		}
		return null;
	}

	public static void LogInAppPurchase(string productId, string itemRequested, bool validationCallback = false)
	{
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[Flurry] ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static Flurry()
	{
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_027d: Expected I4, but got Obj
		//IL_027d: Expected Obj, but got I4
		//IL_0087: Expected I, but got Obj
		//IL_01b7: Expected I, but got Obj
		//IL_01cd: Expected Obj, but got I
		//IL_00dd: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_02d8: Expected I4, but got Obj
		//IL_02a7: Expected Obj, but got I4
		//IL_01f8: Expected I, but got Obj
		//IL_011e: Expected I, but got Obj
		bool flag;
		if (AnalyticsSave.hasLoggedGameCenterLogin)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			bool hasLoggedGameCenterLogin = AnalyticsSave.hasLoggedGameCenterLogin;
			nint num = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v7 (Il2CppClass<Flurry>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v23 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserIdHash = GetFlurryUserIdHash();
			if (((string)hasLoggedGameCenterLogin).get_Chars((int)flurryUserIdHash) != '\0')
			{
				bool hasLoggedGameCenterLogin2 = AnalyticsSave.hasLoggedGameCenterLogin;
				nint num3 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v14 (Il2CppClass<Flurry>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogFacebookLogin((string)hasLoggedGameCenterLogin2);
				return;
			}
		}
		bool flag2;
		if (AnalyticsSave.hasLoggedGameCenterLogin)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (!flag2)
		{
			return;
		}
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v20 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserIdHash2 = GetFlurryUserIdHash();
		AnalyticsSave.hasLoggedGameCenterLogin = (byte)(int)flurryUserIdHash2 != 0;
	}
}
