//Type is in global namespace

public static class Flurry
{
	public const string EVENT_UISCREEN_CHANGED_PREFIX = "UI Screen "; //Field offset: 0x0
	public const string EVENT_ARGKEY_KEYS_VIDEO = "KeysVideo"; //Field offset: 0x0
	public const string EVENT_ARGKEY_KEYS_NO_VIDEO = "KeysNoVideo"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SAVE_ME_POPUP_COUNT = "Count"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VIDEO_STATUS = "Video status"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NOT_CURRENT = "NotCurrent"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SCREEN_NAME_WATER_FALL_REACH = "screen_name;waterfall reach"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CLICK = "Click"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FINISHED = "Finished"; //Field offset: 0x0
	public const string EVENT_ARGKEY_EARLY = "Early"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NO_CLICK_INFO = "NoClickInfo"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NO_CACHED_AD = "No cached ad"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NO_FILL_END_OF_WATERFALL = "NoFillEndOfWaterfall"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NO_FILL_BUTTON_TIMEOUT = "NoFillButtonTimeout"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ALREADY_CACHED = "AlreadyCached"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SHOWED_AD = "ShowedAd"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FAILED_SHOWING_AD = "FailedShowingAd"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NO_FILL_CACHE_TIMEOUT = "NoFillCacheTimeout"; //Field offset: 0x0
	public const string EVENT_ARGKEY_TIMED_OUT = "Timedout"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NO_AD_AVAILABLE = "NoAdAvailable"; //Field offset: 0x0
	public const string EVENT_ARGKEY_AD_AVAILABLE = "AdAvailable"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FILL_REQUEST = "Fill Request"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FAILED = "Failed"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SUCCESS = "Success"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ATTEMPT_TO_SHOW_AD = "Attempt to show ad"; //Field offset: 0x0
	public const string EVENT_ARG_AD_LOCATION_EVENT_OUTCOME = "{0};{1}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VIDEO = "Video"; //Field offset: 0x0
	public const string EVENT_ARGKEY_AD_LOCATION_EVENT_OUTCOME = "Outcome"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ACTION = "Action"; //Field offset: 0x0
	public const string EVENT_ARGKEY_USED_VIDEO = "Used video"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_UP_OPTION_RESULT_DOUBLED = "Doubled"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_NO_FILL = "No Fill"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_NO_CHANCE = "No Chance"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_FILL = "Fill"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_UP_BUTTON_CHANCE = "Chance"; //Field offset: 0x0
	public const string EVENT_ARG_NO = "no"; //Field offset: 0x0
	public const string EVENT_ARG_YES = "yes"; //Field offset: 0x0
	public const string EVENT_ARGKEY_GPU_NAME_WITH_VALUE = "GPU name {0}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_PERFORMANCE_LEVEL_HIGH = "High"; //Field offset: 0x0
	public const string EVENT_ARGKEY_PERFORMANCE_LEVEL_LOW = "Low"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DONTASKRATE = "Do not ask again"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ASKRATE = "Ask again"; //Field offset: 0x0
	public const string EVENT_ARGKEY_POPUPRESULT_CANCEL = "Cancel"; //Field offset: 0x0
	public const string EVENT_ARGKEY_POPUPRESULT_OK = "Ok"; //Field offset: 0x0
	public const string EVENT_ARG_POPUP_VIDEO_COINS_COOLDOWN = "Cooldown_step"; //Field offset: 0x0
	public const string EVENT_ARG_POPUP_VIDEO_COINS_REWARD = "Video_Reward"; //Field offset: 0x0
	public const string EVENT_ARG_POPUP_VIDEO_COINS_CLICKED = "Button_Name"; //Field offset: 0x0
	public const string EVENT_ARG_VIDEO_COINS_AVAILABLE = "Video_Available"; //Field offset: 0x0
	public const string EVENT_ARG_SHOW_COINS_VIDEO_NO_FILL = "No_Fill;"; //Field offset: 0x0
	public const string EVENT_ARG_SHOW_COINS_VIDEO_FILL = "Fill;"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SHOW_COINS_VIDEO_RESULT = "Result"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ONLINE_SETTINGS_PARSING_FAILED_EXCEPTION = "Exception thrown deserializing JSon OnlineSettings"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BOUGHT_IN_RUN = "Bought in run"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SOURCE_OF_PURCHASE = "source_of_purchase"; //Field offset: 0x0
	public const string EVENT_ARGKEY_REVIVE_VIDEO_NOT_AVAILABLE = "Video not available"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NUMBER_OF_REVIVES = "Number of revives"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VIDEO_FILL = "Fill"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VIDEO_NO_FILL = "NoFill"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VIDEO_AVAILABLE = "Available"; //Field offset: 0x0
	public const string EVENT_ARGKEY_UNIX_TIME_IN_MILLIS = "Unix time in millis"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DAILT_BUNDLEIDENTIFIER = "Daily bundle identifier"; //Field offset: 0x0
	public const string EVENT_ARGKEY_LIMITED_BOARD_POPUP_OUTFIT_BOUGHT = "{0}_{1} bought"; //Field offset: 0x0
	public const string EVENT_ARGKEY_LIMITED_BOARD_POPUP_BOARD_BOUGHT = "Board {0} bought"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ALL_ASSET_BUNDLES_DOWNLOADED_COUNTRY = "All Bundles Downloaded {0} in Country"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ALL_ASSET_BUNDLES_DOWNLOADED = "All Bundles Downloaded?"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ASSET_BUNDLE_DOWNLOAD_ERROR = "Asset Bundle Download Error"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ASSET_BUNDLE_VERSION = "Asset Bundle Version"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ASSET_BUNDLE_NAME = "Asset Bundle Name"; //Field offset: 0x0
	public const string EVENT_ARGKEY_LIMITED_CHARACTER_POPUP_OUTFIT_BOUGHT = "{0}_{1} bought"; //Field offset: 0x0
	public const string EVENT_ARGKEY_LIMITED_CHARACTER_POPUP_CHARACTER_BOUGHT = "Character {0} bought"; //Field offset: 0x0
	public const string EVENT_ARGKEY_OFFLINE_COUNTRY = "Offline Country"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ONLINE_COUNTRY = "Online Country"; //Field offset: 0x0
	public const string EVENT_ARGKEY_COUNTRY = "Country"; //Field offset: 0x0
	public const string EVENT_ARGKEY_AWARDS_SILVER_COMPLETED = "Completed Silver Awards"; //Field offset: 0x0
	public const string EVENT_ARGKEY_AWARDS_GOLD_COMPLETED = "Completed Gold Awards"; //Field offset: 0x0
	public const string EVENT_ARGKEY_AWARDS_DIAMOND_COMPLETED = "Completed Diamond Awards"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ACTIVATED_BOOST_SUCCESSFULLY = "successfully"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ITEMS_OWNED_TOTAL = "total"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ITEMS_OWNED_FACEBOOK = "facebook"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ITEMS_OWNED_TOKEN = "token"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ITEMS_OWNED_LIMITED = "limited"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ITEMS_OWNED_REGULAR = "regular"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FPS_RANGE = "FPS range {0}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_PERFOMRNACE_LEVEL = "Level"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_DOWNLOAD_KEY = "ad_download"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_TEXT_KEY_FORMAT = "text_{0}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_IMAGE_KEY_FORMAT = "image_{0}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_HEADSTART = "Headstart"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VIDEO_NOT_SHOWN = "NotShown"; //Field offset: 0x0
	public const string EVENT_ARGKEY_JOBID = "JobID"; //Field offset: 0x0
	public const string EVENT_ARGKEY_TYPE = "Type"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MESSAGE = "Message"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BIRTHDAY_BOARD_DID_WATCH = "Did watch ad"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BIRTHDAY_BOARD_RETRIES = "Number of retries"; //Field offset: 0x0
	public const string EVENT_ARGKEY_REWARD = "Reward"; //Field offset: 0x0
	public const string EVENT_ARGKEY_LOCATION = "Location"; //Field offset: 0x0
	public const string EVENT_ARGKEY_PROVIDER = "Provider"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FIRST_VALID_PURCHASE_PRODUCT_ID = "Product ID"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FACEBOOK_LOGIN_SOURCE = "Facebook Login Source"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SHOW_OUTCOME = "show_outcome"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_UP_OPTION_RESULT_NOT_DOUBLED = "Not Doubled"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SHOW_SOURCE = "show_source"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BOOST_VISITS = "boosts_visits"; //Field offset: 0x0
	public const string EVENT_ARGKEY_EARN_COINS_VISITS = "earn_coins_visits"; //Field offset: 0x0
	public const string EVENT_ARGKEY_STORE_VISITS = "store_visits"; //Field offset: 0x0
	public const string EVENT_ARGKEY_INAPP_SCREEN = "screen"; //Field offset: 0x0
	public const string EVENT_ARGKEY_INAPP_ID = "productID"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DEVICE_LOCALE = "Locale"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ABTEST_TAG = "Tag"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ABTEST_PAYLOAD = "Payload"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ABTEST_IDENTIFIER = "Identifier"; //Field offset: 0x0
	public const string EVENT_ARGKEY_PLAYER_BIRTHDAY = "Player birthday"; //Field offset: 0x0
	public const string EVENT_ARGKEY_REVIVE = "Revive"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SCOREBOOST = "Scoreboost"; //Field offset: 0x0
	public const string EVENT_ARGKEY_QUICK_STORE_VISITS = "quick_store_visits"; //Field offset: 0x0
	public const string EVENT_ARGKEY_GPU_NAME = "GPU name"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_DOWNLOAD_VALUE = "ad download failed"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_IMAGE_VALUE_FORMAT = "ratio: {0} - country:{1}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_REMINDER_FIX = "Fix"; //Field offset: 0x0
	public const string EVENT_ARGKEY_REMINDER_CLOSE = "Close"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DISCONNECT = "Disconnect"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SOURCE = "Source"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_LOGGED_OUT = "NativeLoggedOut"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_LOGGED_IN = "NativeLoggedIn"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FROM_COMPARISON_POPUP = "FromComparisonPopup"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_PROMOTION_POPUP = "FromPromotionPopup"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_SETTINGS_POPUP = "FromSettingsPopup"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_REMINDER_POPUP = "FromReminderPopup"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_STATUS_POPUP = "FromStatusPopup"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_INTRODUCTION_POPUP = "FromIntroductionPopup"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_DISABLED_POPUP = "FromDisabledPopup"; //Field offset: 0x0
	public const string EVENT_ARG_BUTTON_CLICKED = "ButtonClicked"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FAIL_ASYNC_TIME = "AsyncFailTime"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SUCCESS_ASYNC_TIME = "AsyncSuccessTime"; //Field offset: 0x0
	public const string EVENT_ARGKEY_COMMIT_ASYNC_STARTED = "AsyncStarted"; //Field offset: 0x0
	public const string EVENT_ARGKEY_COMMIT_STARTED = "Started"; //Field offset: 0x0
	public const string EVENT_ARGKEY_UPDATE_CONFLICT_TIME = "ConflictTime"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FAIL_TIME = "FailTime"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SUCCESS_TIME = "SuccessTime"; //Field offset: 0x0
	public const string EVENT_ARGKEY_KILOOTAG = "KilooTag"; //Field offset: 0x0
	public const string EVENT_ARGKEY_REMINDER_STATE_WHEN_SHOWN = "State"; //Field offset: 0x0
	public const string EVENT_ARGKEY_INTRODUCTION_SHOWN_COUNT = "ShownCount"; //Field offset: 0x0
	public const string EVENT_ARGKEY_INTRODUCTION_CLOSE_CLICKED = "CloseClicked"; //Field offset: 0x0
	public const string EVENT_ARG_CONFIRMATION_KEEP_LOCAL = "KeepLocal"; //Field offset: 0x0
	public const string EVENT_ARGKEY_COMPLETED_LOGIN = "CompletedLogin"; //Field offset: 0x0
	public const string EVENT_ARG_CONFIRMATION_KEEP_CLOUD = "KeepCloud"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CONFIRMATION_STATE = "state"; //Field offset: 0x0
	private static readonly int[][] FRIEND_BRACKETS; //Field offset: 0x0
	private const string PLAYER_PREFS_FLURRY_USER_ID_KEY = "FLURRY_USER_ID_KEY"; //Field offset: 0x0
	public const string EVENT_ARG_HEADSTART_NAME = "Headstart"; //Field offset: 0x0
	public const string EVENT_ARG_SCORE_BOOSTER_NAME = "Score Booster"; //Field offset: 0x0
	public const string EVENT_ARG_COINS_NAME = "Coins"; //Field offset: 0x0
	public const string EVENT_ARG_HOVERBOARD_NAME = "Hoverboards"; //Field offset: 0x0
	public const string EVENT_ARG_FREE_STUFF_VIDEO_BUTTON_NO_FILL = "NoFill"; //Field offset: 0x0
	public const string EVENT_ARG_FREE_STUFF_VIDEO_BUTTON_CLICKED = "Clicked"; //Field offset: 0x0
	public const string EVENT_ARG_FREE_STUFF_VIDEO_BUTTON_SHOWN = "Shown"; //Field offset: 0x0
	public const string EVENT_FREE_STUFF_VIDEO_BUTTON = "Free Stuff Video Button"; //Field offset: 0x0
	public const string EVENT_ARG_FREESTUFF_QUICKVIDEO_SINCE_DAILY_KEYS = "SinceDailyKeys"; //Field offset: 0x0
	public const string EVENT_ARG_FREESTUFF_QUICKVIDEO_VALUE_FORMAT = "step{0}|sinceDailyKeys{1}|{2}"; //Field offset: 0x0
	public const string EVENT_FREESTUFF_QUICKVIDEO_BUTTON_SHOWN = "Free Stuff Quick Video Ads Button Shown"; //Field offset: 0x0
	public const string EVENT_ARG_USING_MINE = "UsingMine"; //Field offset: 0x0
	public const string EVENT_ARG_USING_THEIRS = "UsingTheirs"; //Field offset: 0x0
	public const string EVENT_ARG_AUTO_RESOLVED = "AutoResolved"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_COMPARISON_RECOMMENDING_NONE = "FromComparisonRecommendingNone"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_COMPARISON_RECOMMENDING_MINE = "FromComparisonRecommendingMine"; //Field offset: 0x0
	public const string EVENT_ARG_FROM_COMPARISON_RECOMMENDING_THEIRS = "FromComparisonRecommendingTheirs"; //Field offset: 0x0
	public const string EVENT_ARG_CONSUMABLE_VIDEO_STATE_NOFILL = "NoFill-{0}"; //Field offset: 0x0
	public const string EVENT_ARG_CONSUMABLE_VIDEO_STATE_FILL = "Fill-{0}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CONSUMABLE_TYPE = "consumable"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CONSUMABLE_VIDEO_STATE = "video status"; //Field offset: 0x0
	public const string EVENT_ARG_CONFIRMATION_BAD = "Bad"; //Field offset: 0x0
	public const string EVENT_ARG_CONFIRMATION_GOOD = "Good"; //Field offset: 0x0
	public const string EVENT_ARG_CONFIRMATION_LOAD_PROGRESS = "LoadProgress"; //Field offset: 0x0
	public const string EVENT_NATIVE_LOGIN = "Native Login"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_CONFIRMATION_POPUP = "CloudSave Confirmation Popup"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_ADVANCED_COMPARISON_POPUP = "CloudSave Advanced Comparison Popup"; //Field offset: 0x0
	public const string EVENT_ARGKEY_OFFERWALL_RESULT_FAILED = "Failed"; //Field offset: 0x0
	public const string EVENT_ARGKEY_OFFERWALL_MESSAGE = "Message"; //Field offset: 0x0
	public const string EVENT_ARGKEY_OFFERWALL_RESULT = "Result"; //Field offset: 0x0
	public const string EVENT_ARGKEY_OFFERWALL_AMOUNT = "Amount"; //Field offset: 0x0
	public const string EVENT_ARGKEY_OFFERWALL_ORIGIN = "Origin"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NOT_ENOUGH_COINS = "not enough coins"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BOUGHT_WITH_COINS = "bought using coins"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BOUGHT_WITH_IAP_FAIL = "bought using iap fail"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BOUGHT_WITH_IAP = "bought using iap"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NOT_ENOUGH_KEYS = "not enough keys"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BOUGHT_WITH_KEYS = "bought using keys"; //Field offset: 0x0
	public const string EVENT_ARGKEY_BUTTON_NAME = "button_name"; //Field offset: 0x0
	public const string EVENT_ARGKEY_PURCHASED = "Purchased"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CLOSED = "Closed"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MOVED_TO_STORE = "Moved to store"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SKIPPED_MISSIONS = "Skipped missions"; //Field offset: 0x0
	public const string EVENT_ARGKEY_TUTORIAL_SCREEN_FLOW = "Screen order"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MISSION_RUNS = "Runs completed"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CONSENT_WITHDRAWN_RESULT = "Result"; //Field offset: 0x0
	public const string EVENT_ARGKEY_PLAYER_BIRTHDAY_VALUE = "{0}-{1}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_CTA = "Call To Action"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_BODY = "Body"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_TEXT_NAME_TITLE = "Title"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_IMAGE_NAME_ICON = "Icon"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_IMAGE_NAME_COVER = "Cover"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MIGRATION_ERROR_TYPE = "Exception Type"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MIGRATION_ERROR_LAST_KEY = "Last loaded key"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SAVE_DATA_ERROR_TYPE = "Exception Type"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MIGRATION_SOURCE_VERSION = "Migrated from"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_REMINDER_POPUP = "CloudSave Reminder Popup"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_INTRODUCTION_POPUP = "CloudSave Introduction Popup"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_STATUS_POPUP = "CloudSave Status Popup"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_CONFLICT_RESOLVED = "CloudSave Conflict Resolved"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_DISCONNECTED = "CloudSave Disconnected"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_ENABLED = "CloudSave Enabled"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_COMMIT = "CloudSave Commit"; //Field offset: 0x0
	public const string EVENT_CLOUDSAVE_UPDATE = "CloudSave Update"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SECOND_ITEM_ID = "item_id_2"; //Field offset: 0x0
	public const string EVENT_ARGKEY_SOURCE_ID = "source_id"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ITEM_ID = "item_id"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_ID = "currency_id"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NATIVE_TEXT_VALUE_FORMAT = "total: {0} after: {1} - country:{2}"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_CHARACTERNAMESKIP = "WordyWeekendSkip"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_DOUBLECOINS_VIDEO = "DoubleCoinsVideo"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_PLAYER_INFO_MIGRATION = "PlayerInfoMigration"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_MISSION_SET = "MissionSet"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_OPEN_URL = "OpenUrl"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_FRIEND_REWARD = "FriendReward"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_WEEKLY_HUNT = "WeeklyHunt"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_REVIVE = "Revive"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_FACEBOOK_GIFT = "FacebookGift"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_INRUN = "InRun"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_MYSTERYBOX = "MysteryBox"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_OFFERWALL = "Offerwall"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MIGRATION_UNHANDLED_UPGRADES = "Unhandled powerup"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CURRENCY_SOURCE_SKIPMISSION = "SkipMission"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CHARACTER_NAME_SKIPPED_WITH_AD = "Watched ad"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CHARACTER_NAME_CHARACTER = "Character"; //Field offset: 0x0
	public const string EVENT_RESTORED_VALIDATED_ITEM = "Restored item"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_HEADSTARTS = "Daily report of headstarts owned"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_CONSUMABLE_HOVERBOARDS = "Daily report of consumable hoverboards"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_KEYS = "Daily keys report"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_COINS = "Daily report of coins"; //Field offset: 0x0
	public const string EVENT_RATING_POPUP = "Rate the app popup"; //Field offset: 0x0
	public const string EVENT_HOME_BUTTON_PRESSED = "Home button pressed"; //Field offset: 0x0
	public const string EVENT_BACK_BTN_PRESSED = "Back button pressed"; //Field offset: 0x0
	public const string EVENT_MORE_COINS_CLICKED = "More coins button clicked"; //Field offset: 0x0
	public const string EVENT_BREADCRUMBS_BEFORE_FREE_HOVERBOARD = "Bread crumbs before purchasing the free hoverboard"; //Field offset: 0x0
	public const string EVENT_FACEBOOK_SHARE = "Share link on Facebook"; //Field offset: 0x0
	public const string EVENT_HOVERBOARD_BOUGHT = "Hoverboard bought"; //Field offset: 0x0
	public const string EVENT_CHARACTER_THEME_UNLOCKED = "Outfit bought"; //Field offset: 0x0
	public const string EVENT_OLD_DEVICE_TOKEN_UNREGISTERED = "Old Device Token Unregistered"; //Field offset: 0x0
	public const string EVENT_EARNCOINS_SCREEN_OPENED = "Earn coins screen opened"; //Field offset: 0x0
	public const string EVENT_QUICKVIDEO_ADS_CLICKED = "Quick Video Ads button clicked"; //Field offset: 0x0
	public const string EVENT_VIDEO_ADS_CLICKED = "Video Ads button clicked"; //Field offset: 0x0
	public const string EVENT_EARNCOINS_ITEM_CLICKED = "Earn Coins item clicked"; //Field offset: 0x0
	public const string EVENT_FRIENDREWARD_COLLECTED = "Friend reward collect"; //Field offset: 0x0
	public const string EVENT_FILEUTIL_SAFE_SAVE_EXCEPTION = "FileUtil SafeSave Exception"; //Field offset: 0x0
	public const string EVENT_FILEUTIL_SAVE_EXCEPTION = "FileUtil Save Exception"; //Field offset: 0x0
	public const string EVENT_FILEUTIL_LOAD_CORRUPTED = "FileUtil load corrupted"; //Field offset: 0x0
	public const string EVENT_DAILY_CHALLENGE_COMPLETED = "Daily Challenge completed"; //Field offset: 0x0
	public const string EVENT_MISSIONSET_COMPLETED = "Mission Set completed"; //Field offset: 0x0
	public const string EVENT_FRONT_SCREEN_PROMOTION_POPUP = "Front Screen Promotion Popup"; //Field offset: 0x0
	public const string EVENT_WELCOME_PACK_PURCHASED = "welcome_pack_purchased"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_SCOREBOOSTERS = "Daily report of score boosters owned"; //Field offset: 0x0
	public const string EVENT_DAILY_ONLINE_STATUS = "Daily Check of Online Status"; //Field offset: 0x0
	public const string EVENT_NOTIFICATIONS_STATE = "State of notifications"; //Field offset: 0x0
	public const string EVENT_REMINDERS_STATE = "State of reminders"; //Field offset: 0x0
	public const string EVENT_ABTEST_SCREEN_OPENED = "A/B Screen Opened"; //Field offset: 0x0
	public const string EVENT_ABTEST_INAPP_OPENED = "A/B Product Click"; //Field offset: 0x0
	public const string EVENT_ABTEST_DAILY_REPORT = "A/B test daily report"; //Field offset: 0x0
	public const string EVENT_CONSUMABLES_SOLD_DURING_RUN = "Consumables Sold During Run"; //Field offset: 0x0
	public const string EVENT_FIRST_INSTALL_DATE = "First install date"; //Field offset: 0x0
	public const string EVENT_LIMITED_BOARD_POPUP_CLOSED = "Limited board popup closed"; //Field offset: 0x0
	public const string EVENT_LIMITED_CHARACTER_POPUP_CLOSED = "Limited character popup closed"; //Field offset: 0x0
	public const string EVENT_NO_FILL_FOR_DOUBLE_BUTTON = "No fill for double button"; //Field offset: 0x0
	public const string EVENT_DOUBLE_UP_BUTTON_CLICKED = "Double up button clicked"; //Field offset: 0x0
	public const string EVENT_DOUBLE_UP_BUTTON_SHOWN = "Double up button shown"; //Field offset: 0x0
	public const string EVENT_DOUBLE_UP_CHOICE_RESULT = "Double up choice"; //Field offset: 0x0
	public const string EVENT_ATTEMPTED_TO_SHOW_DOUBLE_UP_BUTTON = "Attempted to show double up button"; //Field offset: 0x0
	public const string EVENT_PUSH_NOTIFICATION_OPENED = "PushNotificationOpen"; //Field offset: 0x0
	public const string EVENT_UNABLE_TO_BUY_KEYS_FOR_CHARACTER_NAME_EVENT = "Unable to buy keys for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_CANCELED_BUYING_KEYS_FOR_CHARACTER_NAME_EVENT = "Canceled buying keys for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_CANCELED_BUYING_COINS_FOR_CHARACTER_NAME_EVENT = "Canceled buying coins for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_BOUGHT_KEYS_FOR_CHARACTER_NAME_EVENT = "Bought keys for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_BOUGHT_COINS_FOR_CHARACTER_NAME_EVENT = "Bought coins for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_ATTEMPT_TO_BUY_KEYS_FOR_CHARACTER_NAME_EVENT = "Attempt to buy keys for the Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_ATTEMPT_TO_BUY_COINS_FOR_CHARACTER_NAME_EVENT = "Attempt to buy coins for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_UNLOCKED_CHARACTER_FOR_CHARACTER_NAME_EVENT_WITH_PARAMETERS = "Unlocked character for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_SKIPPED_CHARACTER_FOR_CHARACTER_NAME_EVENT = "Skipped character for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_ACTIVE_BOARD = "Currently active board"; //Field offset: 0x0
	public const string EVENT_ACTIVE_CHARACTER = "Currently active character"; //Field offset: 0x0
	public const string EVENT_HOVERBOARD_TRIED = "Event Popup was shown"; //Field offset: 0x0
	public const string EVENT_SSEVENT_POPUP_SHOWN = "Event Popup was shown"; //Field offset: 0x0
	public const string EVENT_UNABLE_TO_BUY_COINS_FOR_CHARACTER_NAME_EVENT = "Unable to buy coins for Wordy Weekend"; //Field offset: 0x0
	public const string EVENT_ABTEST_AD_REMOVAL_POPUP_SHOWN = "A/B Ad Removal Popup Shown"; //Field offset: 0x0
	public const string EVENT_FIRST_PURCHASE_POPUP = "First purchase popup"; //Field offset: 0x0
	public const string EVENT_GAMEOVER_DOUBLECOINS_PRESSED = "Double Coin button pressed"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_KEYPACK3 = "InApp Key Pack 3 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_KEYPACK2 = "InApp Key Pack 2 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_KEYPACK1_5 = "InApp Key Pack 1.5 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_KEYPACK1 = "InApp Key Pack 1 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_COINPACK5 = "InApp Coin Pack 5 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_COINPACK4 = "InApp Coin Pack 4 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_COINPACK3 = "InApp Coin Pack 3 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_COINPACK2_5 = "InApp Coin Pack 2.5 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_COINPACK2 = "InApp Coin Pack 2 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_COINPACK1 = "InApp Coin Pack 1 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_COMPLETED = "InApp purchase completed"; //Field offset: 0x0
	public const string EVENT_SUPER_MYSTERY_BOX_OPENED = "Super mystery box opened"; //Field offset: 0x0
	public const string EVENT_MINIMYSTERY_BOX_OPENED = "Mini Mystery Box opened"; //Field offset: 0x0
	public const string EVENT_MYSTERY_BOX_OPENED = "Mystery Box opened"; //Field offset: 0x0
	private const string HAS_LOGGED_DAILY_EVENT_SOCIAL_PREFIX = "socflurdaily"; //Field offset: 0x0
	public const string EVENT_FACEBOOK_STATUS = "Facebook status"; //Field offset: 0x0
	public const string EVENT_SOCIAL_FRIENDS_CONSOLIDATED = "Social Friends Consolidated"; //Field offset: 0x0
	public const string EVENT_SOCIAL_GC_FRIENDS_RETRIEVED = "Social GameCenter Friends Retrieved"; //Field offset: 0x0
	public const string EVENT_SOCIAL_FACEBOOK_FRIENDS_RETRIEVED = "Social Facebook Friends Retrieved"; //Field offset: 0x0
	public const string EVENT_SOCIAL_BRAGFACEBOOK = "Social bragged Facebook"; //Field offset: 0x0
	public const string EVENT_SOCIAL_BRAG = "Social bragged"; //Field offset: 0x0
	public const string EVENT_SOCIAL_POKE = "Social friend poked"; //Field offset: 0x0
	public const string EVENT_FIRST_FACEBOOK_LOGIN = "First Facebook Login"; //Field offset: 0x0
	public const string EVENT_FIRST_GAMECENTER_LOGIN = "First GameCenter Login"; //Field offset: 0x0
	public const string EVENT_POPUPSCREEN_CHANGED_PREFIX = "POPUP Screen "; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_KEYPACK4 = "InApp Key Pack 4 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_DOUBLECOINS = "Double Coin purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_DOUBLECOINS_POPUP = "Double Coin purchased GameOver"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_BUNDLE1 = "InApp Bundle 1 purchased"; //Field offset: 0x0
	public const string EVENT_STORAGE_PROVIDER_FOLDER_SIZE = "Provider Storage Sizes"; //Field offset: 0x0
	public const string EVENT_STORAGE_MAIN_FOLDER_SIZE = "Main Storage Sizes"; //Field offset: 0x0
	public const string EVENT_BOARD_BUNDLE_POPUP_SHOWN = "Board bundle popup shown"; //Field offset: 0x0
	public const string EVENT_DEVICE_LOCALE = "Device locale"; //Field offset: 0x0
	public const string EVENT_DAILY_BUNDLEIDENTIFIER = "The current bundle identifier"; //Field offset: 0x0
	public const string EVENT_ACTIVATED_SCOREBOOSTER = "Boost scorebooster activated"; //Field offset: 0x0
	public const string EVENT_ACTIVATED_HEADSTART = "Boost headstart activated"; //Field offset: 0x0
	public const string EVENT_ACTIVATED_HOVERBOARD = "Boost hoverboard activated"; //Field offset: 0x0
	public const string EVENT_HOVERBOARD_ABILITIES_OWNED = "Hoverboard abilities owned"; //Field offset: 0x0
	public const string EVENT_CHARACTER_OUTFITS_OWNED = "Character outfits owned"; //Field offset: 0x0
	public const string EVENT_HOVERBOARDS_OWNED = "Hoverboards owned"; //Field offset: 0x0
	public const string EVENT_CHARACTERS_OWNED = "Characters owned"; //Field offset: 0x0
	public const string EVENT_FIRST_VALIDATED_PURCHASE = "First Validated Purchase"; //Field offset: 0x0
	public const string EVENT_END_OF_RUN_POWERUPS_USED = "Powerups used in run"; //Field offset: 0x0
	public const string EVENT_DEVICE_PERFORMANCE = "Device performance"; //Field offset: 0x0
	public const string EVENT_UNKNOWN_GPU = "Unknown GPU"; //Field offset: 0x0
	public const string EVENT_APPLICATION_AUTHENTICITY = "Application Authenticity"; //Field offset: 0x0
	public const string EVENT_BUY_HEADSTART_FROM_POPUP = "Purchase headstart from popup"; //Field offset: 0x0
	public const string EVENT_BUY_SCOREBOOSTER_FROM_POPUP = "Purchase scorebooster from popup"; //Field offset: 0x0
	public const string EVENT_BUY_HOVERBOARD_FROM_POPUP = "Purchase hoverboard from popup"; //Field offset: 0x0
	public const string EVENT_DAYS_PASSED_SINCE_LAST_PLAY = "Days passed since last play"; //Field offset: 0x0
	public const string EVENT_CHARACTER_UNLOCKED = "Character unlocked"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_BUNDLE5 = "InApp Bundle 5 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_BUNDLE4 = "InApp Bundle 4 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_BUNDLE3 = "InApp Bundle 3 purchased"; //Field offset: 0x0
	public const string EVENT_INAPPPURCHASE_BUNDLE2 = "InApp Bundle 2 purchased"; //Field offset: 0x0
	public const string EVENT_END_OF_RUN_AVG_FPS = "InRunAvgFPS"; //Field offset: 0x0
	public const string EVENT_ARGKEY_CHARACTER_NAME_ACTION_PRICE = "Price"; //Field offset: 0x0
	private const string VALIDATION_SUFFIX = " VALIDATED"; //Field offset: 0x0
	public const string EVENT_FIRST_TIME_FRONT_SCREEN = "First front screen"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_ELEMENT_TYPE = "ElementType"; //Field offset: 0x0
	public const string EVENT_ARGKEY_IS_FACEBOOK_LOGGED_IN = "IsFacebookLoggedin"; //Field offset: 0x0
	public const string EVENT_ARGKEY_HAS_FILL = "HasFill"; //Field offset: 0x0
	public const string EVENT_ATTEMPT_TO_SHOW_AD = "Attempt to show ad"; //Field offset: 0x0
	public const string EVENT_WATERFALL_REACH = "WaterfallReach"; //Field offset: 0x0
	public const string EVENT_ATTEMPT_TO_CACHE_RESULT = "AttemptToCacheResult"; //Field offset: 0x0
	public const string EVENT_VIDEO_AD_BUTTON_CLICK = "{0}_generic"; //Field offset: 0x0
	public const string EVENT_ATTEMPT_TO_SHOW_BUTTON = "Attempt to show button"; //Field offset: 0x0
	public const string EVENT_RESULT_OF_AD_SHOWN = "Result of ad shown"; //Field offset: 0x0
	public const string EVENT_DOUBLE_COINS_VIDEO_RESULT = "DoubleCoinsVideoResult"; //Field offset: 0x0
	public const string EVENT_DOUBLE_COINS_VIDEO_ATTEMPT = "DoubleCoinsVideoAttempt"; //Field offset: 0x0
	public const string EVENT_CONSUMABLE_VIDEO_FILL_ATTEMPT = "Consumable video fill attempt"; //Field offset: 0x0
	public const string EVENT_FOOTER_BUTTON_CLICKED = "FooterButtonClicked"; //Field offset: 0x0
	public const string EVENT_FRONT_SCREEN_BUTTON_WITH_FOOTER_CLICKED = "FrontScreenButtonWithFooterClicked"; //Field offset: 0x0
	public const string EVENT_SOFT_CURRENCY_EARNED = "Soft currency earned"; //Field offset: 0x0
	public const string EVENT_SOFT_CURRENCY_SPENT = "Soft currency spent"; //Field offset: 0x0
	public const string EVENT_SAVE_DATA_SAVE_ERRORS = "SaveData save error"; //Field offset: 0x0
	public const string EVENT_SAVE_DATA_LOAD_ERRORS = "SaveData load error"; //Field offset: 0x0
	public const string EVENT_MIGRATION_UNHANDLED_UPGRADES = "Migration unhandled upgrades"; //Field offset: 0x0
	public const string EVENT_MIGRATION_ERROR_PLAYERPREFS = "PlayerPrefs Migration error"; //Field offset: 0x0
	public const string EVENT_MIGRATION_ERROR_PLAYERINFO = "PlayerInfo Migration error"; //Field offset: 0x0
	public const string EVENT_ONLINE_SETTINGS_PARSING_FAILED = "Error deserializing JSon OnlineSettings"; //Field offset: 0x0
	public const string EVENT_BIRTHDAY_BOARD_POPUP_SHOWED = "Birthday Board showed in popup"; //Field offset: 0x0
	public const string EVENT_BIRTHDAY_BOARD_BOARD_SCREEN_SHOWED = "Birthday Board showed on Board screen"; //Field offset: 0x0
	public const string EVENT_CONSENT_PRIVACY_POLICY_OPENED = "Consent Privacy Policy link opened"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_CLICKED = "IsDoubleCoinsVideoClicked"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_PAYOUT_AMOUNT = "VideoPayoutAmount"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_CHARGE = "IsCharged"; //Field offset: 0x0
	public const string EVENT_ARGKEY_DOUBLE_COINS_VIDEO_WAS_SHOWN = "ElementShown"; //Field offset: 0x0
	public const string EVENT_ARGKEY_TIME = "Time"; //Field offset: 0x0
	public const string EVENT_ARGKEY_AWARD = "Award"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VALUE = "Value"; //Field offset: 0x0
	public const string EVENT_ARGKEY_STATUS = "Status"; //Field offset: 0x0
	public const string EVENT_ARGKEY_STATE = "State"; //Field offset: 0x0
	public const string EVENT_ARGKEY_RESULT = "Result"; //Field offset: 0x0
	public const string EVENT_ARGKEY_APPLICATION_AUTHENTICITY = "Type"; //Field offset: 0x0
	public const string EVENT_ARGKEY_NOTIFICATIONS_ENABLED = "Enabled"; //Field offset: 0x0
	public const string EVENT_ARGKEY_AMOUNT = "Amount"; //Field offset: 0x0
	public const string EVENT_ARGKEY_RATE_ASKAGAIN = "Should ask again"; //Field offset: 0x0
	public const string EVENT_ARGKEY_IS_FROM_DAILY_CHALLENGE = "SMB from daily challenge"; //Field offset: 0x0
	public const string EVENT_ARGKEYS_SOCIAL_FRIENDS_CONSOLIDATED = "Total;Facebook;GameCenter"; //Field offset: 0x0
	public const string EVENT_CONSENT_WITHDRAWN = "Consent withdrawn"; //Field offset: 0x0
	public const string EVENT_ARGKEYS_SOCIAL_FRIENDS_RETRIEVED = "Total friends;Installed friends"; //Field offset: 0x0
	public const string EVENT_ARGKEY_VIDEOADRESULT = "Result"; //Field offset: 0x0
	public const string EVENT_ARGKEY_FILENAME = "Filename"; //Field offset: 0x0
	public const string EVENT_ARGKEY_POPUPRESULT = "Result"; //Field offset: 0x0
	public const string EVENT_ARGKEY_TOTAL = "Total"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MISSION_SKIP_WITH_VIDEO = "Video"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MISSION_CAN_SKIP_FROM_PAUSE = "Can skip from pause"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MISSION_SKIPPED_FROM = "Mission Skipped From"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MISSIONSET_AND_INDEX = "Mission Set and Index"; //Field offset: 0x0
	public const string EVENT_ARGKEY_MISSIONSET = "Mission Set"; //Field offset: 0x0
	public const string EVENT_ARGKEY_UI_SCREENNAME = "Screen Name"; //Field offset: 0x0
	public const string EVENT_ARGKEY_TIER = "Tier"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ID = "Id"; //Field offset: 0x0
	public const string EVENT_ARGKEY_ITEM_IAP = "Item tiggered iap"; //Field offset: 0x0
	public const string EVENT_EXIT_TUTORIAL_AREA = "Tutorial exit"; //Field offset: 0x0
	public const string EVENT_CONSENT_GIVEN = "Consent given"; //Field offset: 0x0
	public const string EVENT_MISSIONS_VIDEO_BUTTON_PAUSE_BUTTON_FILL = "Mission video game pause fill attempt"; //Field offset: 0x0
	public const string EVENT_BOOST_JETPACK_PURCHASED = "Boost jetpack purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_DOUBLEMULTIPLIER_PURCHASED = "Boost 2x multiplier purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_COINMAGNET_PURCHASED = "Boost Coinmagnet purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_HOVERBOARD_PURCHASED = "Boost Hoverboard purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_HEADSTART2000_PURCHASED = "Boost Headstart2000 purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_SCOREBOOSTER_PURCHASED = "Boost Scorebooster purchased"; //Field offset: 0x0
	public const string EVENT_HOVERBOARD_THEME_DEACTIVATED = "Hoverboard Theme deactivated"; //Field offset: 0x0
	public const string EVENT_HOVERBOARD_THEME_ACTIVATED = "Hoverboard Theme activated"; //Field offset: 0x0
	public const string EVENT_HOVERBOARD_THEME_BOUGHT = "Hoverboard Theme bought"; //Field offset: 0x0
	public const string EVENT_OFFERWALL_SPEND_POINTS = "OfferWall Spend Points"; //Field offset: 0x0
	public const string EVENT_OFFERWALL_GET_POINTS = "OfferWall Get Points"; //Field offset: 0x0
	public const string EVENT_OFFERWALL_EARNED_POINTS = "OfferWall Earned Points"; //Field offset: 0x0
	public const string EVENT_OFFERWALL_CLOSED = "OfferWall Closed"; //Field offset: 0x0
	public const string EVENT_OFFERWALL_SHOWN = "OfferWall Shown"; //Field offset: 0x0
	public const string EVENT_OFFERWALL_LOADING = "Attempt loading OfferWall"; //Field offset: 0x0
	public const string EVENT_ADSYSTEM_AD_LOCATION_EVENT_NAME = "Ad Location: {0}"; //Field offset: 0x0
	public const string EVENT_ATTEMPT_TO_FILL = "Attempt to fill {0}"; //Field offset: 0x0
	public const string EVENT_ADSYSTEM_PROVIDER_TIME_LIMIT_REACHED = "Provider Time Limit Reached"; //Field offset: 0x0
	public const string EVENT_UI_SCREEN_NOT_ENOUGH_CURRENCY_POPUP = "NotEnoughCurrencyPopup"; //Field offset: 0x0
	public const string EVENT_SHOW_COINS_VIDEO_BUTTON = "Attempt to show not enough coin video button"; //Field offset: 0x0
	public const string EVENT_MANUALLY_CLOSED_AD_OVERLAY = "Manually closed ad overlay"; //Field offset: 0x0
	public const string EVENT_GAMEOVER_SCREEN_FLOW = "Game over screen flow"; //Field offset: 0x0
	public const string EVENT_FRONT_SCREEN_FLOW = "Front screen flow"; //Field offset: 0x0
	public const string EVENT_RUNS_FOR_MISSION = "Runs completed for mission"; //Field offset: 0x0
	public const string EVENT_TUTORIAL_HOVERBOARD = "Tutorial hoverboard activated"; //Field offset: 0x0
	public const string EVENT_BOOST_LETTERS_PURCHASED = "Boost letters purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_SUPERSNEAKERS_PURCHASED = "Boost supersneakers purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_MYSTERYBOX_PURCHASED = "Boost MysteryBox purchased"; //Field offset: 0x0
	public const string EVENT_BOOST_MISSION_SKIP_PURCHASED = "Boost Mission Skip purchased"; //Field offset: 0x0
	public const string EVENT_MISSIONS_VIDEO_BUTTON_FILL = "Mission video fill attempt"; //Field offset: 0x0
	public const string EVENT_CHALLENGES_SCREEN_PAGE_SHOWN = "Challenges screen shown"; //Field offset: 0x0
	public const string EVENT_ASSET_BUNDLES_ALL_DOWNLOADED = "All Asset Bundle Downloads completed"; //Field offset: 0x0
	public const string EVENT_ASSET_BUNDLE_AVAILABILITY_CHECK_FAILED = "Asset Bundles Availability Check Failed"; //Field offset: 0x0
	public const string EVENT_ASSET_BUNDLE_FAILED_DOWNLOAD = "Asset Bundle Failed to Download"; //Field offset: 0x0
	public const string EVENT_ASSET_BUNDLE_FAILED_LOAD_FROM_CACHE = "Asset Bundle Failed to be loaded from Cache"; //Field offset: 0x0
	public const string EVENT_ASSET_BUNDLE_FAILED_TO_CACHE = "Asset Bundle Failed to be Cached"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_SILVER_AWARDS_FINISHED = "Total amount of silver awards finished"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_GOLD_AWARDS_FINISHED = "Total amount of gold awards finished"; //Field offset: 0x0
	public const string EVENT_AMOUNT_OF_DIAMOND_AWARDS_FINISHED = "Total amount of diamond awards finished"; //Field offset: 0x0
	public const string EVENT_AWARD_TIER_COLLECTED_TIME = "Award tier collected time"; //Field offset: 0x0
	public const string EVENT_AWARD_TIER_COMPLETED_TIME = "Award tier completed time"; //Field offset: 0x0
	public const string EVENT_PLAYER_BIRTHDAY = "Player Birthday entered"; //Field offset: 0x0
	public const string EVENT_AWARD_COMPLETED = "Award completed"; //Field offset: 0x0
	public const string EVENT_INTERSTITIAL_NATIVE_ADVIEW_AD_INVALID = "Native Ad Invalid"; //Field offset: 0x0
	public const string EVENT_INTERSTITIAL_GAME_OVER_COUNTER = "Interstitial Game Over Counter"; //Field offset: 0x0
	public const string EVENT_WEEKLY_CHALLENGE_PERIOD_PROGRESS = "WeeklyHunt Progress"; //Field offset: 0x0
	public const string EVENT_WEEKLY_CHALLENGE_COMPLETED = "Weekly Challenge Completed"; //Field offset: 0x0
	public const string EVENT_END_OF_RUN = "End of run"; //Field offset: 0x0
	public const string EVENT_RESUMED_AFTER_REVIVE_WITH_VIDEO = "Resumed run after revive with video"; //Field offset: 0x0
	public const string EVENT_SAVE_ME_SHOWN = "Save Me shown"; //Field offset: 0x0
	public const string EVENT_SAVE_ME_CLICKED = "Save Me clicked"; //Field offset: 0x0
	public const string EVENT_MINI_MYSTERYBOX_VIEW_PRIZES = "Mini Mystery Box prizes"; //Field offset: 0x0
	public const string EVENT_SUPER_MYSTERYBOX_VIEW_PRIZES = "Super Mystery Box prizes"; //Field offset: 0x0
	public const string EVENT_BOOST_MYSTERYBOX_VIEW_PRIZES = "Mysterybox view prices"; //Field offset: 0x0
	public const string EVENT_BOOST_MISSION_SKIP_INFO = "Boost Mission Skip info"; //Field offset: 0x0
	public const string EVENT_AWARD_TIER_COMPLETED = "Award tier completed"; //Field offset: 0x0
	private static char[] PARAMETER_SPLITTERS; //Field offset: 0x4

	public static string flurryUserId
	{
		 get { } //Length: 226
		 set { } //Length: 8
	}

	public static bool wasInitialized
	{
		 get { } //Length: 93
	}

	private static Flurry() { }

	public static string ConvertFriendCountToBracket(int count) { }

	public static void EndSession() { }

	public static string get_flurryUserId() { }

	public static bool get_wasInitialized() { }

	public static string GetFlurryUserIdHash() { }

	public static void HandleFlurryUserIDBackup() { }

	private static void Log(string msg, Object context = null) { }

	public static void LogClosePressedOnPopup(string eventName) { }

	private static void LogError(string msg, Object context = null) { }

	public static void LogEvent(string eventName) { }

	public static void LogEventWithAParameter(string eventName, string argKey, string argValue) { }

	public static void LogEventWithSeveralParameters(string eventName, Dictionary<string, string> parameters) { }

	public static void LogEventWithSeveralParameters(string eventName, string argKeys, string argValues) { }

	public static void LogFacebookLogin(string facebookLoginSource) { }

	public static void LogGameCenterLogin() { }

	public static void LogInAppPurchase(string productId, string itemRequested, bool validationCallback = false) { }

	public static void LogOkPressedOnPopup(string eventName) { }

	private static void LogWarning(string msg, Object context = null) { }

	public static void set_flurryUserId(string value) { }

	public static void SetUserId() { }

	public static bool ShouldLogDailyEvent(string eventName) { }

	public static void StartSession(string apiKey) { }

	private static Dictionary<string, string> ToDictionary(string argKeys, string argValues) { }

}

