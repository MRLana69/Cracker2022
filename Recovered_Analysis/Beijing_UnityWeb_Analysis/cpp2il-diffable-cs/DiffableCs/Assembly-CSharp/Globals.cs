//Type is in global namespace

public class Globals
{
	private class AddedAnimationEventInfo
	{
		public Animation animation; //Field offset: 0x8
		public string clipName; //Field offset: 0xC
		public float time; //Field offset: 0x10
		public string functionName; //Field offset: 0x14

		public AddedAnimationEventInfo(Animation animation, string clipName, float time, string functionName) { }

	}

	public enum BuildPurpose
	{
		UNDEFINED = 0,
		DEV = 1,
		QA = 2,
		LIVE = 3,
		REGRESSION = 4,
	}

	public enum LogInState
	{
		Offline = 0,
		Facebook = 1,
		GameCenter = 2,
		Both = 3,
	}

	public static readonly bool DEBUG; //Field offset: 0x0
	public const string OVERRIDEN_ONLINE_SETTINGS_BASE_URL = "http://10.0.0.169/hoodrunner"; //Field offset: 0x0
	public const string OVERRIDEN_NEW_ONLINE_SETTINGS_BASE_URL = ""; //Field offset: 0x0
	public const string DEBUG_DAILYWORD = "Day"; //Field offset: 0x0
	public const LogInState DEBUG_LOGIN_STATE = 1; //Field offset: 0x0
	public const string fakeOnlineSettings = "efe40d19b11ddd485b4188664e9969f4bc89de0d
[latestversion] 1.7.4
[latestversion_changelist] 


* Subway Surfers in the Snow!
* Limited Holiday character
* Discover special Boards
* Receive a free GIFT!
* Optimized for iPhone 5!
[in_app_tier_1] 2500
[in_app_tier_2] 15000
[in_app_tier_3] -40
[in_app_tier_4] 250000
[in_app_tier_5] -30
[in_app_tier_6] -30
[in_app_tier_7] -30
[in_app_tier_8] -30
[in_app_double_coins] -5
[discount_end_time] 1496318400
[videoads_providerlist] vungleclips
[hoverboard_expiretime_liberty] 23-12-2012 22:00:00
[hoverboard_starttime_liberty] 20-11-2012 22:00:00
[character_expiretime_nychar] 23-12-2012 22:00:00
[character_starttime_nychar] 13-10-2012 22:00:00
[character_expiretime_elftricky] 23-11-2012 22:00:00
[character_starttime_elftricky] 23-11-2012 22:00:00
[enable_local_notifications] true[save_me_locales] en_US;en_UK;[offerwall_number_of_offers] 4[offerwall_session_timeout] 24[offerwall_offers_timeout] 24[offerwall_balance_timeout] 24[offerwal_min_reward_allowed] 10[offerwall_max_reward_allowed] 10000[offerwall_filter_free] true[save_me_locales] all[event_id]1496318400[event_value] 0;0[event_type] CharacterName[event_start] 1404694800[event_end] 1496318400[event_ribbon_text]ad3;3;6[number_of_fails_for_interstitial] 1[interstitials_limit_per_hour] 10[interstitials_limit_per_day] 40[intesrtitials_delay_seconds] 10[keys_rewarded_for_video_ad] 2[sybo_analytics_enabled] true[sybo_analytics_endpoint_baseurl] https://subwaysurf.dev.bladesofbrim.com[sybo_analytics_sampling_threshold] 1[sybo_analytics_max_games_without_flush] 1[sybo_analytics_games_in_session_before_first_flush] 1[home_interstitials_list] supersonic:1_100,inmobi:2_100,chartboost:3_100,supersonic:4_100,facebook:5_100[home_videos_list] supersonic:1_100,adcolony:2_100,tapjoy:3_100,inmobi:4_100,flurry:5_100,chartboost:7_100[default_interstitial_list] supersonic:1_100,inmobi:2_100,chartboost:3_100,supersonic:4_100,facebook:5_100[default_video_list] supersonic:1_100,adcolony:2_100,tapjoy:3_100,inmobi:4_100,flurry:5_100,chartboost:7_100[ad_location_home_videos_enabled] true[ad_location_earn_coins_videos_enabled] true[ad_location_double_up_videos_enabled] true[ad_location_home_interstitials_enabled] true[ad_location_game_over_interstitials_enabled] true[loadscreen_allow_usertips] true[loadscreen_title] Player Tip[loadscreen_usertip_list]Abdennor, Mascara, Algeria;Earn Coins for your Facebook friends by making multiple runs!/Bayezed, Dhaka, Bangladesh;Activate your Hoverboard when you see obstacles in front of you and don't know what to do!/Jonathan, Sarawak, Malaysia;Play the Wordy Weekend event to unlock limited Characters!/Tyler, Rhode Island, USA;If you keep opening Mystery Boxes you might win the grand prize!/Amber, Cambridge, England;Complete the Weekly Hunt to win cool prizes!/Lukas, Copenhagen, Denmark;Double tap to activate your Hoverboards!/Ahmad, Selangor, Malaysia;Login to Facebook to earn more rewards!/Mikael, Kumasi, Ghana;Use Hoverboards to survive a crash!/Daniel, Vicensa, Italy;Remember to Double Up your items whenever possible!/Amar, Gothenburg, Sweden;Use Trains and other objects to stay as high in the air as possible!/Roberto, Knokke, Belgium;Try to stay as high in the air as possible!/Cooper, Dubbo, Australia;Use Hoverboards! If things get too hectic an explosion will clear the stage!/Meighan, Alberta, Canada;Super Jump with Hoverboards and Super Sneakers to get over the Trains!/Mostafa, Alexandria, Egypt;Invite your friends to play Subway Surfers for more fun!/Eelis, Hämeenlinna, Finland;Try to be on the roof of every Train as long as possible!/Amber, Cambridge, England;Use the Power Jumper to jump up onto the tunnels!/Thomas, Colorado, USA;Fully upgrade the Freestyler Board to get both Double Jump and Super Jump!/Musthapa, Sarawak, Malaysia;With the upgraded Monster board you can jump over the Trains, and it is also really fast!/Lasse, Birkelse, Denmark;Some Hoverboards have upgrades that make them faster!/Mansoor, Sindh, Pakistan;Open more Mystery Boxes in the Terrific Tuesday event and win mega prizes!/Sunil, Mumbai, India;Use the Bouncer board to pick up Coins from below!/Fakhry, Victoria, Malaysia;Get the Bouncer board to enjoy Super Sneakers and Hoverboard features at the same time!/Joshua, Maine, USA;You can cancel jumps by rolling in mid air!/Joshua, Maine, USA;You can hop on barriers to get onto trains!/Rachel, Ho Chi Minh City, Vietnam;To collect the High Jumper Awards get help from the Bouncer board!/Salman, Hyderabad, India;Don't forget the Daily Challenge! It rewards Super Mystery Boxes!/Liliane, Yaoundé, Cameroun;Earn Awards to get more Key"; //Field offset: 0x0
	public const string FAKE_NEW_ONLINE_SETTINGS = ""; //Field offset: 0x0
	public const int MAX_MULTIPLIER = 30; //Field offset: 0x0
	public const int MAX_RANK = 1; //Field offset: 0x0
	public const int BONUS_FACEBOOK = 5000; //Field offset: 0x0
	public const int INITIAL_AMOUNT_OF_KEYS = 5; //Field offset: 0x0
	public const int MIN_FRIEND_SCORE_REQUEST_INTERVAL = 15; //Field offset: 0x0
	public const int GIFT_BREADCRUMBS_TO_SHOW = 30; //Field offset: 0x0
	public const string BASE_URL = "http://hoodrunner.kiloo.com"; //Field offset: 0x0
	public const string URL_FOR_FACEBOOK_POST = "http://redirect.kiloo.com/subwayapp.php"; //Field offset: 0x0
	public const float DEBUG_LOADING_DELAY_SECONDS = 0.5; //Field offset: 0x0
	public const int PLAYERINFO_REDUNDANT_FILES = 1; //Field offset: 0x0
	public const int PLAYERINFO_ALTERNATE_REDUNDANT_FILES = 0; //Field offset: 0x0
	public const int PLAYERINFO_ALTERNATE_BACKUP_SLOTS = 0; //Field offset: 0x0
	public const int DAILY_QUEST_MIN_REQUEST_INTERVAL = 120; //Field offset: 0x0
	public const string DAILY_QUEST_SECRET = "aIN0UXP4NNoANVGi5w3raGAFN1n5OLQZFDhwjs6HoX"; //Field offset: 0x0
	public const string DAILY_QUEST_URL = "http://hoodrunner.kiloo.com/hr_dailyquests2.php"; //Field offset: 0x0
	private const string PRIVACY_POLICY_URL = "https://poki.com/en/c/privacy-policy"; //Field offset: 0x0
	private const string ONLINESETTINGS_PRIVACY_POLICY_KEY = "privacy_policy_url"; //Field offset: 0x0
	public const string CONTACT_SUPPORT_URL = "http://kiloo.com/support/subway-surfers/"; //Field offset: 0x0
	public const int LAYER_2DGUI = 30; //Field offset: 0x0
	public const int LAYER_3DGUI = 31; //Field offset: 0x0
	public const int LAYER_2DOVERLAY = 28; //Field offset: 0x0
	public const int LAYER_3DCLIP = 29; //Field offset: 0x0
	public const int LAYER_2DOVERLAY_CLIP = 26; //Field offset: 0x0
	public const float DRAG_THRESHOLD = 0.1; //Field offset: 0x0
	public const int PLAYERINFO_BACKUP_SLOTS = 5; //Field offset: 0x0
	public const float BUTTON_TWEEN_DURATION = 0; //Field offset: 0x0
	public const string DEBUG_FORCED_LOCALE = "pt-BR"; //Field offset: 0x0
	public const bool DEBUG_SOCIAL_MANAGER_SERVER = False; //Field offset: 0x0
	public static readonly bool DEBUG_POPUP; //Field offset: 0x1
	public static BuildPurpose BUILD_PURPOSE; //Field offset: 0x4
	public static int DEFAULT_BUNDLES_VERSION; //Field offset: 0x8
	public static readonly bool DEBUG_SETTINGS; //Field offset: 0xC
	public static readonly bool DEBUG_POPUP_TESTOLOGY; //Field offset: 0xD
	public static bool DEBUG_USE_ONLINESETTINGS_TESTTIME; //Field offset: 0xE
	public static bool DEBUG_USE_ONLINESETTINGS_SET; //Field offset: 0xF
	public static string ONLINESETTINGS_SET; //Field offset: 0x10
	public static readonly bool DEBUG_FREE_PURCHASES; //Field offset: 0x14
	public static bool DEBUG_ALL_CHARS; //Field offset: 0x15
	public static bool DEBUG_ALL_BOARDS; //Field offset: 0x16
	public static bool DEBUG_DISPLAY_ALL_CHARS; //Field offset: 0x17
	public static bool DEBUG_DISPLAY_ALL_BOARDS; //Field offset: 0x18
	public static bool DEBUG_FREE_INAPP_PURCHASE; //Field offset: 0x19
	public static bool DEBUG_SKIP_VIDEO_ADS; //Field offset: 0x1A
	public static readonly bool DEBUG_DISABLE_HOVERBOARD; //Field offset: 0x1B
	public static readonly bool DEBUG_DISABLE_JETPACK; //Field offset: 0x1C
	public static readonly bool DEBUG_SKIP_TUTORIAL_IN_EDITOR; //Field offset: 0x1D
	public static readonly bool DEBUG_USE_DEBUG_LOGIN_STATE; //Field offset: 0x1E
	public static readonly bool DEBUG_USE_FAKE_ONLINE_SETTINGS; //Field offset: 0x1F
	public static readonly bool DEBUG_USE_FAKE_NEW_ONLINE_SETTINGS; //Field offset: 0x20
	public static readonly bool DEBUG_OVERRIDE_ONLINE_SETTINGS_URL; //Field offset: 0x21
	public static readonly bool DEBUG_OVERRIDE_NEW_ONLINE_SETTINGS_URL; //Field offset: 0x22
	public static readonly bool DEBUG_USE_TEST_AD_CONSTANTS; //Field offset: 0x23
	public static bool DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER; //Field offset: 0x24
	public static bool DEBUG_INTERSTITIAL_PROVIDERS; //Field offset: 0x25
	public static bool DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST; //Field offset: 0x26
	public static bool DEBUG_INTERSTITIAL_PROVIDER_INMOBI; //Field offset: 0x27
	public static bool DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC; //Field offset: 0x28
	public static bool DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK; //Field offset: 0x29
	public static bool DEBUG_INTERSTITIAL_PROVIDER_YEAHMOBI; //Field offset: 0x2A
	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD; //Field offset: 0x2B
	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT; //Field offset: 0x2C
	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT; //Field offset: 0x2D
	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES; //Field offset: 0x2E
	public static bool DEBUG_INTERSTITIAL_IN_EDITOR; //Field offset: 0x2F
	public static bool DEBUG_VIDEOADS_PROVIDERS; //Field offset: 0x30
	public static bool DEBUG_VIDEOADS_PROVIDERS_ADCOLONY; //Field offset: 0x31
	public static bool DEBUG_VIDEOADS_PROVIDERS_FLURRY; //Field offset: 0x32
	public static bool DEBUG_VIDEOADS_PROVIDERS_VUNGLE; //Field offset: 0x33
	public static bool DEBUG_VIDEOADS_PROVIDERS_TAPJOY; //Field offset: 0x34
	public static bool DEBUG_VIDEOADS_PROVIDERS_INMOBI; //Field offset: 0x35
	public static bool DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST; //Field offset: 0x36
	public static bool DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC; //Field offset: 0x37
	public static bool DEBUG_VIDEOADS_PROVIDERS_FACEBOOK; //Field offset: 0x38
	public static bool DEBUG_VIDEOADS_PROVIDERS_MOBVISTA; //Field offset: 0x39
	public static bool DEBUG_VIDEOADS_PROVIDERS_YEAH_MOBI; //Field offset: 0x3A
	public static bool DEBUG_USE_CELEBRATION_TESTER; //Field offset: 0x3B
	public static bool DEBUG_USE_EVENT_TESTER; //Field offset: 0x3C
	public static bool DEBUG_SHOW_PERFORMANCE_INFO; //Field offset: 0x3D
	public static bool DEBUG_USE_TIMESCALE_PAUSE_BUTTON; //Field offset: 0x3E
	public static bool DEBUG_ENABLE_SALES; //Field offset: 0x3F
	public static bool DEBUG_ENABLE_HOLIDAY_SALES; //Field offset: 0x40
	public static bool DEBUG_ENABLE_NEW_YEAR_SALES; //Field offset: 0x41
	public static bool DEBUG_DISABLE_NOTIFICATION_REQUEST; //Field offset: 0x42
	public static bool DEBUG_TEST_FPS_SPIKES; //Field offset: 0x43
	public static bool DEBUG_USE_DEBUG_AD_PROVIDER; //Field offset: 0x44
	public static bool DEBUG_ENABLE_BOARD_BUNDLE; //Field offset: 0x45
	public static bool DEBUG_AD_SYSTEM_SINGLE_IMPRESSION; //Field offset: 0x46
	public static bool DEBUG_IGNORE_PROMOTION_EXPIRATION; //Field offset: 0x47
	public static readonly bool DEBUG_FORCE_SPECIFIC_LOCALE; //Field offset: 0x48
	public static bool DEBUG_ENABLE_LOADING_DELAY; //Field offset: 0x49
	public static bool DEBUG_USE_DEBUG_LOGS_INSTEAD_OF_FLURRY; //Field offset: 0x4A
	public static bool DEBUG_FACEBOOK_SESSION_WARNINGS; //Field offset: 0x4B
	public static bool DEBUG_DEVICE_UTILITY_WARNINGS; //Field offset: 0x4C
	public static bool DEBUG_STRINGS_CLASS_WARNINGS; //Field offset: 0x4D
	public static bool DEBUG_SHADERS; //Field offset: 0x4E
	public static bool DEBUG_CHARACTER_INVINCIBLE; //Field offset: 0x4F
	public static bool DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS; //Field offset: 0x50
	public static bool DEBUG_LIMITED_CHARACTER_POPUP; //Field offset: 0x51
	public static bool DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE; //Field offset: 0x52
	public static bool DEBUG_LIMITED_BOARD_POPUP; //Field offset: 0x53
	public static bool DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE; //Field offset: 0x54
	public static bool DEBUG_FIRST_PURCHASE_BONUS; //Field offset: 0x55
	public static bool DEBUG_ENABLE_WELCOME_PACK; //Field offset: 0x56
	public static int DEBUG_WELCOME_PACK_ABTEST_DEFAULT_PAYLOAD; //Field offset: 0x58
	public static bool DEBUG_ENABLE_GET_2_KEYS; //Field offset: 0x5C
	public static int DEBUG_INTRO_VIDEO_AD_PRIZE_INDEX; //Field offset: 0x60
	public static int DEBUG_RANDOM_VIDEO_AD_PRIZE_INDEX; //Field offset: 0x64
	public static int DEBUG_RANDOM_VIDEO_AD_PRIZE_SEED; //Field offset: 0x68
	public static VideoAdPrizeType DEBUG_VIDEO_AD_PRIZE_TYPE; //Field offset: 0x6C
	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___SUPER_MYSTERY_BOX; //Field offset: 0x70
	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___MYSTERY_POWER_UP; //Field offset: 0x71
	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER; //Field offset: 0x72
	public static bool DEBUG_SKIP_DAILY_LETTERS; //Field offset: 0x73
	public static readonly bool DEBUG_USE_ENABLE_PLAYER_INFO___IS_ACTIVE_DAILY_LETTER_EVENT; //Field offset: 0x74
	public static readonly bool DEBUG_USE_ENABLE_PLAYER_INFO___HAS_DAILY_WORD_TIME_LEFT; //Field offset: 0x75
	public static bool DEBUG_USE_DEBUG_DAILYWORD; //Field offset: 0x76
	public static readonly bool DEBUG_IS_HOVERBOARD_ALWAYS_REWARDED_FOR_MYSERY_POWERUP; //Field offset: 0x77
	public static CharacterId debugLimitedCharacterPopupId; //Field offset: 0x78
	public static BoardId debugLimitedBoardPopupId; //Field offset: 0x7C
	private static List<AddedAnimationEventInfo> addedAnimEvents; //Field offset: 0x80

	public static string AppStoreURL
	{
		 get { } //Length: 130
	}

	public static string RatingURL
	{
		 get { } //Length: 99
	}

	private static Globals() { }

	public Globals() { }

	public static string[] convertAllBoolToString(bool[] array) { }

	public static string[] convertAllIntToString(int[] array) { }

	public static bool[] convertAllStringToBool(string[] array) { }

	public static int[] convertAllStringToInt(string[] array) { }

	public static string convertEnumBoolDictionaryToString(Dictionary<T, bool> sourceDict) { }

	public static string convertEnumIntArrayDictionaryToString(Dictionary<T, int[]> sourceDict) { }

	public static string convertEnumIntDictionaryToString(Dictionary<T, int> sourceDict) { }

	public static string convertStringStringDictionaryToString(Dictionary<string, string> sourceDict) { }

	public static Dictionary<T, bool> convertStringToEnumBoolDictionary(string sourceString) { }

	public static Dictionary<T, int[]> convertStringToEnumIntArrayDictionary(string sourceString) { }

	public static Dictionary<T, int> convertStringToEnumIntDictionary(string sourceString) { }

	public static Dictionary<string, string> convertStringToStringStringDictionary(string sourceString) { }

	public static string get_AppStoreURL() { }

	public static string get_RatingURL() { }

	public static Friend[] GetDebugFriends(int numberOfFriends = 10) { }

	public static LogInState GetLoginState() { }

	public static string GetPrivacyPolicyUrl() { }

	private static void LogError(string msg, Object context = null) { }

	public static bool TryAddAnimationEvent(Animation animation, string clipName, AnimationEvent aniEvent) { }

}

