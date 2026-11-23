using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway.Info;
using UnityEngine;

public class Globals
{
	public enum BuildPurpose
	{
		UNDEFINED,
		DEV,
		QA,
		LIVE
	}

	public enum LogInState
	{
		Offline,
		Facebook,
		GameCenter,
		Both
	}

	private class AddedAnimationEventInfo(Animation animation, string clipName, float time, string functionName)
	{
		public Animation animation = animation;

		public string clipName = clipName;

		public float time = time;

		public string functionName = functionName;
	}

	public static readonly bool DEBUG;

	public static readonly bool DEBUG_POPUP;

	public const bool DEBUG_SOCIAL_MANAGER_SERVER = false;

	public static BuildPurpose BUILD_PURPOSE;

	public static int DEFAULT_BUNDLES_VERSION;

	public static readonly bool DEBUG_POPUP_TESTOLOGY;

	public static bool DEBUG_USE_ONLINESETTINGS_TESTTIME;

	public static bool DEBUG_USE_ONLINESETTINGS_SET;

	public static string ONLINESETTINGS_SET;

	public static readonly bool DEBUG_FREE_PURCHASES;

	public static bool DEBUG_ALL_CHARS;

	public static bool DEBUG_ALL_BOARDS;

	public static bool DEBUG_DISPLAY_ALL_CHARS;

	public static bool DEBUG_DISPLAY_ALL_BOARDS;

	public static bool DEBUG_FREE_INAPP_PURCHASE;

	public static bool DEBUG_SKIP_VIDEO_ADS;

	public static readonly bool DEBUG_DISABLE_HOVERBOARD;

	public static readonly bool DEBUG_DISABLE_JETPACK;

	public static readonly bool DEBUG_SKIP_TUTORIAL_IN_EDITOR;

	public static readonly bool DEBUG_USE_DEBUG_LOGIN_STATE;

	public static readonly bool DEBUG_USE_FAKE_ONLINE_SETTINGS;

	public static readonly bool DEBUG_OVERRIDE_ONLINE_SETTINGS_URL;

	public static readonly bool DEBUG_USE_TEST_AD_CONSTANTS;

	public static bool DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_INMOBI;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_MDOTM;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES;

	public static bool DEBUG_VIDEOADS_PROVIDERS;

	public static bool DEBUG_VIDEOADS_PROVIDERS_ADCOLONY;

	public static bool DEBUG_VIDEOADS_PROVIDERS_FLURRY;

	public static bool DEBUG_VIDEOADS_PROVIDERS_VUNGLE;

	public static bool DEBUG_VIDEOADS_PROVIDERS_TABJOY;

	public static bool DEBUG_VIDEOADS_PROVIDERS_INMOBI;

	public static bool DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST;

	public static bool DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC;

	public static bool DEBUG_VIDEOADS_PROVIDERS_FACEBOOK;

	public static bool DEBUG_USE_CELEBRATION_TESTER;

	public static bool DEBUG_USE_EVENT_TESTER;

	public static bool DEBUG_SHOW_PERFORMANCE_INFO;

	public static bool DEBUG_USE_TIMESCALE_PAUSE_BUTTON;

	public static bool DEBUG_ENABLE_SALES;

	public static bool DEBUG_DISABLE_NOTIFICATION_REQUEST;

	public static bool DEBUG_FACEBOOK_SESSION_WARNINGS;

	public static bool DEBUG_DEVICE_UTILITY_WARNINGS;

	public static bool DEBUG_STRINGS_CLASS_WARNINGS;

	public static bool DEBUG_SHADERS;

	public static bool DEBUG_CHARACTER_INVINCIBLE;

	public static bool DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS;

	public static bool DEBUG_LIMITED_CHARACTER_POPUP;

	public static bool DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE;

	public static bool DEBUG_LIMITED_BOARD_POPUP;

	public static bool DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE;

	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___SUPER_MYSTERY_BOX;

	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___MYSTERY_POWER_UP;

	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER;

	public static bool DEBUG_SKIP_DAILY_LETTERS;

	public static readonly bool DEBUG_USE_ENABLE_PLAYER_INFO___IS_ACTIVE_DAILY_LETTER_EVENT;

	public static readonly bool DEBUG_USE_ENABLE_PLAYER_INFO___HAS_DAILY_WORD_TIME_LEFT;

	public static bool DEBUG_USE_DEBUG_DAILYWORD;

	public static readonly bool DEBUG_IS_HOVERBOARD_ALWAYS_REWARDED_FOR_MYSERY_POWERUP;

	public const string OVERRIDEN_ONLINE_SETTINGS_BASE_URL = "http://10.0.0.169/hoodrunner";

	public const string DEBUG_DAILYWORD = "Day";

	public const LogInState DEBUG_LOGIN_STATE = LogInState.Facebook;

	public static Characters.CharacterType DEBUG_LIMITED_CHARACTER_POPUP_TYPE;

	public static Hoverboards.BoardType DEBUG_LIMITED_BOARD_POPUP_TYPE;

	public const Characters.CharacterType DEBUG_LIMITED_CHARACTER_TYPE = Characters.CharacterType.mumbaiCharacter01;

	public const Hoverboards.BoardType DEBUG_LIMITED_BOARD_TYPE = Hoverboards.BoardType.cherry;

	public const string fakeOnlineSettings = "efe40d19b11ddd485b4188664e9969f4bc89de0d\n[latestversion] 1.7.4\n[latestversion_changelist] \n\n\n* Subway Surfers in the Snow!\n* Limited Holiday character\n* Discover special Boards\n* Receive a free GIFT!\n* Optimized for iPhone 5!\n[in_app_tier_1] 2500\n[in_app_tier_2] 15000\n[in_app_tier_3] -40\n[in_app_tier_4] 250000\n[in_app_tier_5] -30\n[in_app_tier_6] -30\n[in_app_tier_7] -30\n[in_app_tier_8] -30\n[in_app_double_coins] -5\n[discount_end_time] 1496318400\n[videoads_providerlist] vungleclips\n[hoverboard_expiretime_liberty] 23-12-2012 22:00:00\n[hoverboard_starttime_liberty] 20-11-2012 22:00:00\n[character_expiretime_nychar] 23-12-2012 22:00:00\n[character_starttime_nychar] 13-10-2012 22:00:00\n[character_expiretime_elftricky] 23-11-2012 22:00:00\n[character_starttime_elftricky] 23-11-2012 22:00:00\n[enable_local_notifications] true[save_me_locales] en_US;en_UK;[offerwall_number_of_offers] 4[offerwall_session_timeout] 24[offerwall_offers_timeout] 24[offerwall_balance_timeout] 24[offerwal_min_reward_allowed] 10[offerwall_max_reward_allowed] 10000[offerwall_filter_free] true[save_me_locales] all[event_id]1496318400[event_value] 0;0[event_type] CharacterName[event_start] 1404694800[event_end] 1496318400[event_ribbon_text]ad3;3;6[number_of_fails_for_interstitial] 1[interstitials_limit_per_hour] 10[interstitials_limit_per_day] 40[intesrtitials_delay_seconds] 10[keys_rewarded_for_video_ad] 2[sybo_analytics_enabled] true[sybo_analytics_endpoint_baseurl] https://subwaysurf.dev.bladesofbrim.com[sybo_analytics_sampling_threshold] 1[sybo_analytics_max_games_without_flush] 1[sybo_analytics_games_in_session_before_first_flush] 1";

	public const int MAX_MULTIPLIER = 30;

	public const int MAX_RANK = 1;

	public const int BONUS_FACEBOOK = 5000;

	public const int BONUS_GAMECENTER = 250;

	public const int INITIAL_AMOUNT_OF_KEYS = 5;

	public const int MIN_FRIEND_SCORE_REQUEST_INTERVAL = 15;

	public const int GIFT_BREADCRUMBS_TO_SHOW = 30;

	public const string LAST_SEEN_BUNDLE_VERSION_KEY = "lastSeenBundleVersionKey";

	public const string BASE_URL = "http://hoodrunner.kiloo.com";

	public const string URL_FOR_FACEBOOK_POST = "http://redirect.kiloo.com/subwayapp.php";

	public const string ICON_URL_FOR_FACEBOOK_POST = "http://hoodrunner.kiloo.com/fblogo_miami2017.png";

	public const int PLAYERINFO_REDUNDANT_FILES = 1;

	public const int PLAYERINFO_BACKUP_SLOTS = 5;

	public const int PLAYERINFO_ALTERNATE_REDUNDANT_FILES = 0;

	public const int PLAYERINFO_ALTERNATE_BACKUP_SLOTS = 0;

	public const int DAILY_QUEST_MIN_REQUEST_INTERVAL = 120;

	public const string DAILY_QUEST_SECRET = "aIN0UXP4NNoANVGi5w3raGAFN1n5OLQZFDhwjs6HoX";

	public const string DAILY_QUEST_URL = "http://hoodrunner.kiloo.com/hr_dailyquests2.php";

	public const string PRIVACY_POLICY_URL = "http://www.kiloo.com/privacy/";

	public const string CONTACT_SUPPORT_URL = "http://kiloo.com/support/subway-surfers/";

	public const int LAYER_2DGUI = 30;

	public const int LAYER_3DGUI = 31;

	public const int LAYER_2DOVERLAY = 28;

	public const int LAYER_3DCLIP = 29;

	public const int LAYER_2DOVERLAY_CLIP = 26;

	public const float DRAG_THRESHOLD = 0.1f;

	public const float BUTTON_TWEEN_DURATION = 0f;

	private static List<AddedAnimationEventInfo> addedAnimEvents;

	public static string RatingURL
	{
		get
		{
			RuntimePlatform platform3;
			do
			{
				RuntimePlatform platform = Application.platform;
				if (platform == RuntimePlatform.IPhonePlayer)
				{
					break;
				}
				RuntimePlatform platform2 = Application.platform;
				if (platform2 == RuntimePlatform.Android)
				{
					if (!DeviceUtility.isKindleDevice && DeviceUtility.isFlexionDevice)
					{
					}
					break;
				}
				platform3 = Application.platform;
			}
			while (platform3 != RuntimePlatform.MetroPlayerARM);
			return string.Empty;
		}
	}

	public static string AppStoreURL
	{
		get
		{
			RuntimePlatform platform = Application.platform;
			bool flag = platform == RuntimePlatform.IPhonePlayer;
			object result = "http://itunes.apple.com/app/subway-surfers/id512939461";
			if (!flag)
			{
				RuntimePlatform platform2 = Application.platform;
				if (platform2 == RuntimePlatform.Android)
				{
					bool isKindleDevice = DeviceUtility.isKindleDevice;
					result = "http://www.amazon.com/gp/mas/dl/android?p=com.kiloo.subwaysurf";
					if (!isKindleDevice)
					{
						bool isFlexionDevice = DeviceUtility.isFlexionDevice;
						result = "http://subwaysurfers.kiloo.flexionmobile.com";
						if (!isFlexionDevice)
						{
							result = "https://play.google.com/store/apps/details?id=com.kiloo.subwaysurf";
						}
					}
				}
				else
				{
					RuntimePlatform platform3 = Application.platform;
					bool flag2 = platform3 == RuntimePlatform.MetroPlayerARM;
					result = "https://www.microsoft.com/store/apps/9wzdncrfhz73";
					if (!flag2)
					{
						result = "test";
					}
				}
			}
			return (string)result;
		}
	}

	static Globals()
	{
		DEBUG = false;
		DEBUG_POPUP = false;
		BUILD_PURPOSE = BuildPurpose.LIVE;
		DEFAULT_BUNDLES_VERSION = 1;
		if (~(DEBUG ? 1u : 0u) != 0)
		{
			DEBUG_POPUP_TESTOLOGY = false;
			DEBUG_USE_ONLINESETTINGS_TESTTIME = false;
			DEBUG_USE_ONLINESETTINGS_SET = false;
			ONLINESETTINGS_SET = string.Empty;
			DEBUG_FREE_PURCHASES = false;
			DEBUG_ALL_CHARS = false;
			DEBUG_ALL_BOARDS = false;
			DEBUG_DISPLAY_ALL_CHARS = false;
			DEBUG_DISPLAY_ALL_BOARDS = false;
			DEBUG_FREE_INAPP_PURCHASE = false;
			DEBUG_SKIP_VIDEO_ADS = false;
			DEBUG_DISABLE_HOVERBOARD = false;
			DEBUG_DISABLE_JETPACK = false;
			DEBUG_SKIP_TUTORIAL_IN_EDITOR = false;
			DEBUG_USE_DEBUG_LOGIN_STATE = false;
			DEBUG_USE_FAKE_ONLINE_SETTINGS = false;
			DEBUG_OVERRIDE_ONLINE_SETTINGS_URL = false;
			DEBUG_USE_TEST_AD_CONSTANTS = false;
			DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER = false;
			DEBUG_INTERSTITIAL_PROVIDERS = false;
			if (~(DEBUG ? 1u : 0u) == 0)
			{
				goto IL_0308;
			}
		}
		DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST = false;
		if (~(DEBUG ? 1u : 0u) == 0)
		{
			goto IL_005d;
		}
		goto IL_0308;
		IL_010c:
		DEBUG_VIDEOADS_PROVIDERS_FACEBOOK = false;
		DEBUG_USE_CELEBRATION_TESTER = false;
		DEBUG_USE_EVENT_TESTER = false;
		DEBUG_SHOW_PERFORMANCE_INFO = false;
		DEBUG_USE_TIMESCALE_PAUSE_BUTTON = false;
		DEBUG_ENABLE_SALES = false;
		DEBUG_DISABLE_NOTIFICATION_REQUEST = false;
		DEBUG_FACEBOOK_SESSION_WARNINGS = false;
		DEBUG_DEVICE_UTILITY_WARNINGS = false;
		DEBUG_STRINGS_CLASS_WARNINGS = false;
		DEBUG_SHADERS = false;
		DEBUG_CHARACTER_INVINCIBLE = false;
		DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS = false;
		DEBUG_LIMITED_CHARACTER_POPUP = false;
		DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE = false;
		DEBUG_LIMITED_BOARD_POPUP = false;
		DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE = false;
		DEBUG_USE_ENABLE_SS_EVENT_TYPE___SUPER_MYSTERY_BOX = false;
		DEBUG_USE_ENABLE_SS_EVENT_TYPE___MYSTERY_POWER_UP = false;
		DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER = false;
		DEBUG_SKIP_DAILY_LETTERS = false;
		DEBUG_USE_ENABLE_PLAYER_INFO___IS_ACTIVE_DAILY_LETTER_EVENT = false;
		DEBUG_USE_ENABLE_PLAYER_INFO___HAS_DAILY_WORD_TIME_LEFT = false;
		DEBUG_USE_DEBUG_DAILYWORD = false;
		DEBUG_IS_HOVERBOARD_ALWAYS_REWARDED_FOR_MYSERY_POWERUP = false;
		DEBUG_LIMITED_CHARACTER_POPUP_TYPE = Characters.CharacterType.slick;
		DEBUG_LIMITED_BOARD_POPUP_TYPE = Hoverboards.BoardType.normal;
		List<AddedAnimationEventInfo> list = default;
		list._002Ector();
		addedAnimEvents = list;
		return;
		IL_0399:
		DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC = false;
		if (~(DEBUG ? 1u : 0u) == 0)
		{
			/*Error: End of method reached without returning.*/;
		}
		goto IL_010c;
		IL_0308:
		DEBUG_INTERSTITIAL_PROVIDER_INMOBI = false;
		if (~(DEBUG ? 1u : 0u) != 0)
		{
			goto IL_005d;
		}
		goto IL_0325;
		IL_005d:
		DEBUG_INTERSTITIAL_PROVIDER_MDOTM = false;
		if (~(DEBUG ? 1u : 0u) == 0)
		{
			goto IL_007a;
		}
		goto IL_0325;
		IL_0325:
		DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC = false;
		if (~(DEBUG ? 1u : 0u) != 0)
		{
			goto IL_007a;
		}
		goto IL_0342;
		IL_007a:
		DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK = false;
		DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT = false;
		DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES = false;
		DEBUG_VIDEOADS_PROVIDERS = false;
		if (~(DEBUG ? 1u : 0u) == 0)
		{
			goto IL_00b5;
		}
		goto IL_0342;
		IL_0342:
		DEBUG_VIDEOADS_PROVIDERS_ADCOLONY = false;
		if (~(DEBUG ? 1u : 0u) != 0)
		{
			goto IL_00b5;
		}
		goto IL_035f;
		IL_00b5:
		DEBUG_VIDEOADS_PROVIDERS_FLURRY = false;
		if (~(DEBUG ? 1u : 0u) == 0)
		{
			goto IL_00d2;
		}
		goto IL_035f;
		IL_035f:
		DEBUG_VIDEOADS_PROVIDERS_VUNGLE = false;
		if (~(DEBUG ? 1u : 0u) != 0)
		{
			goto IL_00d2;
		}
		goto IL_037c;
		IL_00d2:
		DEBUG_VIDEOADS_PROVIDERS_TABJOY = false;
		if (~(DEBUG ? 1u : 0u) == 0)
		{
			goto IL_00ef;
		}
		goto IL_037c;
		IL_037c:
		DEBUG_VIDEOADS_PROVIDERS_INMOBI = false;
		if (~(DEBUG ? 1u : 0u) != 0)
		{
			goto IL_00ef;
		}
		goto IL_0399;
		IL_00ef:
		DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST = false;
		if (~(DEBUG ? 1u : 0u) == 0)
		{
			goto IL_010c;
		}
		goto IL_0399;
	}

	public static Friend[] GetDebugFriends(int numberOfFriends = 10)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Friend[] result = default;
		return result;
	}

	public static LogInState GetLoginState()
	{
		LogInState result;
		if (~(DEBUG_USE_DEBUG_LOGIN_STATE ? 1u : 0u) == 0)
		{
			result = LogInState.Facebook;
		}
		else
		{
			SocialManager instance = SocialManager.instance;
			bool gamecenterIsLoggedIn = instance.gamecenterIsLoggedIn;
			SocialManager instance2 = SocialManager.instance;
			if (instance2.facebookIsLoggedIn)
			{
				LogInState result2 = LogInState.Both;
				if (!gamecenterIsLoggedIn)
				{
					result2 = LogInState.Facebook;
				}
				return result2;
			}
			result = LogInState.GameCenter;
			if (!gamecenterIsLoggedIn)
			{
				result = LogInState.Offline;
			}
		}
		return result;
	}

	public static Dictionary<T, int> convertStringToEnumIntDictionary<T>(string sourceString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I
		//IL_0061: Expected VT, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] array = sourceString.Split(',');
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		object obj3 = array.Length / 2;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v3 (Il2CppMethodRgctx<Globals::convertStringToEnumIntDictionary>)+4]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S3_v4+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v15 (Il2CppMethodRgctx<Globals::convertStringToEnumIntDictionary>)+8]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object obj5 = 0;
		while (true)
		{
			object obj6 = array.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				break;
			}
			object obj7 = obj5 << 2;
			object obj8 = (object)array + obj7;
			object obj9 = obj5 + 1;
			object obj10 = obj9 << 2;
			object obj11 = (object)array + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29+10]");
			if (Enum.IsDefined(typeFromHandle, 0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v29+10]");
				object obj12 = Enum.Parse(typeFromHandle, (string)0, ignoreCase: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				throw new NullReferenceException();
			}
			object obj13 = obj5 + 2;
			obj5 = obj13;
		}
		Dictionary<T, int> result = default;
		return result;
	}

	public static string convertEnumIntDictionaryToString<T>(Dictionary<T, int> sourceDict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_0593: Expected Obj, but got I4
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_05de: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_065b: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_046c: Expected Obj, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_04df: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I4
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected I4, but got Unknown
		//IL_008b: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj4 = obj + 8;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v2 (Il2CppMethodRgctx<Globals::convertEnumIntDictionaryToString>)+4]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S3_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = obj + 76;
		object obj7 = obj + 48;
		obj = obj7;
		_ = 0;
		object obj11 = default;
		object obj16 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		string result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v28+1C]");
			object obj9 = 0;
			_ = 0;
			object obj10 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj11 == null)
				{
					goto IL_043d;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v101+1C]");
					object obj13 = 0;
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
								object obj14 = 0;
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
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
													_ = 0;
													object obj15 = obj + 36;
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
											goto IL_03ae;
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
			goto IL_03ae;
			IL_03ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj16 != obj17;
			object obj18 = obj19;
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
				goto IL_043d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj18 = obj20;
			break;
			IL_043d:
			object obj21 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10B3");
			object obj22 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
			if ((nint)obj22 >= 1)
			{
				object obj23 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
				int startIndex = obj23 - 1;
				StringBuilder stringBuilder2 = stringBuilder.Remove(startIndex, 1);
			}
			nint num3 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ S1_v39 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			return result;
		}
		_ = 0;
		object obj24 = obj + 8;
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

	public static Dictionary<T, bool> convertStringToEnumBoolDictionary<T>(string sourceString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I
		//IL_0061: Expected VT, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] array = sourceString.Split(',');
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		object obj3 = array.Length / 2;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v3 (Il2CppMethodRgctx<Globals::convertStringToEnumBoolDictionary>)+4]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S3_v4+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v15 (Il2CppMethodRgctx<Globals::convertStringToEnumBoolDictionary>)+8]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object obj5 = 0;
		while (true)
		{
			object obj6 = array.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				break;
			}
			object obj7 = obj5 << 2;
			object obj8 = (object)array + obj7;
			object obj9 = obj5 + 1;
			object obj10 = obj9 << 2;
			object obj11 = (object)array + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v29+10]");
			if (Enum.IsDefined(typeFromHandle, 0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v29+10]");
				object obj12 = Enum.Parse(typeFromHandle, (string)0, ignoreCase: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				throw new NullReferenceException();
			}
			object obj13 = obj5 + 2;
			obj5 = obj13;
		}
		Dictionary<T, bool> result = default;
		return result;
	}

	public static string convertEnumBoolDictionaryToString<T>(Dictionary<T, bool> sourceDict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got I4
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_0619: Expected Obj, but got I
		//IL_0633: Expected Obj, but got I
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_0696: Expected Obj, but got I
		//IL_06a6: Expected Obj, but got I
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_04a7: Expected Obj, but got I4
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_051a: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I4
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected I4, but got Unknown
		//IL_008b: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj4 = obj + 8;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v2 (Il2CppMethodRgctx<Globals::convertEnumBoolDictionaryToString>)+4]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S3_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = obj + 76;
		object obj7 = obj + 48;
		obj = obj7;
		_ = 0;
		object obj11 = default;
		object obj16 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		string result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v28+1C]");
			object obj9 = 0;
			_ = 0;
			object obj10 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj11 == null)
				{
					goto IL_0478;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v101+1C]");
					object obj13 = 0;
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
								object obj14 = 0;
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
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														object obj15 = obj + 39;
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
																continue;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_03e9;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											goto IL_03e9;
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
			goto IL_03e9;
			IL_03e9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj16 != obj17;
			object obj18 = obj19;
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
				goto IL_0478;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj18 = obj20;
			break;
			IL_0478:
			object obj21 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10B3");
			object obj22 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
			if ((nint)obj22 >= 1)
			{
				object obj23 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
				int startIndex = obj23 - 1;
				StringBuilder stringBuilder2 = stringBuilder.Remove(startIndex, 1);
			}
			nint num3 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v243 @ S1_v39 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			return result;
		}
		_ = 0;
		object obj24 = obj + 8;
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

	public static Dictionary<string, string> convertStringToStringStringDictionary(string sourceString)
	{
		//IL_00b6: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		string[] array = sourceString.Split(',');
		object obj = array.Length / 2;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		object obj2 = 0;
		while (true)
		{
			object obj3 = array.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				break;
			}
			object obj4 = obj2 << 2;
			object obj5 = (object)array + obj4;
			object obj6 = obj2 + 1;
			object obj7 = obj6 << 2;
			object obj8 = (object)array + obj7;
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ S5_v5+4] (should have been resolved before IL gen)");
			object obj10 = obj2 + 2;
			obj2 = obj10;
		}
		Dictionary<string, string> result = default;
		return result;
	}

	public static string convertStringStringDictionaryToString(Dictionary<string, string> sourceDict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0271: Expected Obj, but got I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_02e4: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
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
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		string result = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_0242;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
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
				goto IL_0242;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_0242:
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8F8");
			object obj13 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
			if ((nint)obj13 >= 1)
			{
				object obj14 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
				int startIndex = obj14 - 1;
				StringBuilder stringBuilder2 = stringBuilder.Remove(startIndex, 1);
			}
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ S1_v34 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			return result;
		}
		_ = 0;
		object obj15 = obj + 8;
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

	public static Dictionary<T, int[]> convertStringToEnumIntArrayDictionary<T>(string sourceString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0051: Expected VT, but got I
		//IL_0085: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] array = sourceString.Split(';');
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v3 (Il2CppMethodRgctx<Globals::convertStringToEnumIntArrayDictionary>)+4]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v4+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v15 (Il2CppMethodRgctx<Globals::convertStringToEnumIntArrayDictionary>)+8]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object obj4 = default;
		object obj12 = default;
		while (array.Length > (nint)obj4)
		{
			object obj5 = obj4 << 2;
			object obj6 = (object)array + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v29+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v29+10]");
			object obj8;
			if ((nint)0 != 0)
			{
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v30+8]");
				if ((nint)0 != 0)
				{
					goto IL_02f5;
				}
			}
			obj8 = 1;
			goto IL_02f5;
			IL_02f5:
			if (obj8 == null)
			{
				object obj9 = obj4 << 2;
				object obj10 = (object)array + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v36+10]");
				string[] array2 = ((string)0).Split('-');
				if (array2.Length == 2 && Enum.IsDefined(typeFromHandle, array2[0]))
				{
					object obj11 = Enum.Parse(typeFromHandle, array2[0], ignoreCase: true);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
					throw new NullReferenceException();
				}
			}
			obj4 = obj12 + 1;
		}
		Dictionary<T, int[]> result = default;
		return result;
	}

	public static string convertEnumIntArrayDictionaryToString<T>(Dictionary<T, int[]> sourceDict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_0804: Expected Obj, but got I4
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_0849: Expected Obj, but got I
		//IL_0863: Expected Obj, but got I
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_090c: Expected Obj, but got I
		//IL_091c: Expected Obj, but got I
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06dd: Expected Obj, but got I4
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_0750: Expected I, but got Obj
		//IL_071f: Expected Obj, but got I4
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected I4, but got Unknown
		//IL_009e: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_02eb: Expected Obj, but got I4
		//IL_08d1: Expected Obj, but got I
		//IL_04ab: Expected Obj, but got I
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj4 = obj + 16;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v2 (Il2CppMethodRgctx<Globals::convertEnumIntArrayDictionaryToString>)+4]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S3_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = obj + 76;
		object obj7 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj11 = default;
		string result = default;
		object obj27 = default;
		object obj28 = default;
		object obj30 = default;
		object obj31 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v27+1C]");
			object obj9 = 0;
			_ = 0;
			object obj10 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj11 == null)
				{
					goto IL_06ae;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v100+1C]");
					object obj13 = 0;
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
								object obj14 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj15 = obj + 8;
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
														object obj16 = 0;
														while (true)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
															object obj17 = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 == 1)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S0_v202+C]");
															if (0 <= (nint)obj16)
															{
																goto IL_0488;
															}
															_ = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 == 1)
															{
																goto IL_05a7;
															}
															object obj18 = obj16 << 2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
															object obj19 = 0 + obj18;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v269+10]");
															_ = 0;
															object obj20 = obj + 8;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 == 1)
															{
																goto IL_05b6;
															}
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																object obj21 = obj16 + 1;
																obj16 = obj21;
																continue;
															}
															goto IL_05c5;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														goto IL_061f;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
											goto IL_061f;
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
			goto IL_061f;
			IL_0488:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v178+14]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v178+10]");
			object obj22 = num3 + 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				object obj23 = obj22 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
			goto IL_061f;
			IL_06ae:
			object obj24 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10B3");
			object obj25 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
			if ((nint)obj25 >= 1)
			{
				object obj26 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
				int startIndex = obj26 - 1;
				StringBuilder stringBuilder2 = stringBuilder.Remove(startIndex, 1);
			}
			nint num4 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v292 @ S1_v38 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			return result;
			IL_061f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj27 != obj28;
			object obj29 = obj30;
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
				goto IL_06ae;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj29 = obj31;
			break;
			IL_05b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_061f;
			IL_05c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_061f;
			IL_05a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_061f;
		}
		_ = 0;
		object obj32 = obj + 16;
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

	public static int[] convertAllStringToInt(string[] array)
	{
		//IL_0088: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj = 0;
		int[] array2 = default;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array2 + obj2;
			object obj4 = obj << 2;
			object obj5 = (object)array + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v9+10]");
			int num = int.Parse((string)0);
			object obj6 = obj + 1;
			obj = obj6;
		}
		return array2;
	}

	public static bool[] convertAllStringToBool(string[] array)
	{
		//IL_007f: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj = 0;
		bool[] array2 = default;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			object obj4 = obj + (object)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v15+10]");
			bool flag = bool.Parse((string)0);
			object obj5 = obj + 1;
			obj = obj5;
		}
		return array2;
	}

	public unsafe static string[] convertAllIntToString(int[] array)
	{
		//IL_0099: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj = 0;
		if (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			int num = obj3 + 16;
			string text = ((int*)num)->ToString();
			throw new ArrayTypeMismatchException();
		}
		string[] result = default;
		return result;
	}

	public unsafe static string[] convertAllBoolToString(bool[] array)
	{
		//IL_008b: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj = 0;
		if (array.Length > (nint)obj)
		{
			object obj2 = (object)array + obj;
			bool flag = (byte)(obj2 + 16) != 0;
			string text = (flag ? ((bool*)1) : ((bool*)null))->ToString();
			throw new ArrayTypeMismatchException();
		}
		string[] result = default;
		return result;
	}

	public static bool TryAddAnimationEvent(Animation animation, string clipName, AnimationEvent aniEvent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected Obj, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_01a2: Invalid comparison between I and F4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
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
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		bool result;
		object obj12 = default;
		object obj13 = default;
		bool flag2 = default;
		bool flag3 = default;
		AddedAnimationEventInfo addedAnimationEventInfo = default;
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
					goto IL_036f;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
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
							if (obj8 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj9 == null)
								{
									continue;
								}
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v97+10]");
									if (0f != aniEvent.m_Time)
									{
										continue;
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
											if (obj10 != null)
											{
												object obj11 = obj + 16;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @594B");
												result = false;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj12 != obj13;
			result = flag2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_036f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag3;
			}
			_ = 0;
			object obj14 = obj + 16;
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
			IL_036f:
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @594B");
			addedAnimationEventInfo.animation = animation;
			addedAnimationEventInfo.clipName = clipName;
			addedAnimationEventInfo.functionName = aniEvent.m_FunctionName;
			addedAnimationEventInfo.time = aniEvent.m_Time;
			addedAnimEvents.Add(addedAnimationEventInfo);
			bool flag4 = animation.IsPlaying(clipName);
			AnimationClip clip = animation.GetClip(clipName);
			animation.RemoveClip(clip);
			clip.AddEvent(aniEvent);
			animation.AddClip(clip, clipName);
			bool flag5 = !flag4;
			result = true;
			if (!flag5)
			{
				bool flag6 = animation.Play(clipName);
				result = true;
			}
			break;
		}
		return result;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "GlobalDebug: " + msg;
	}
}
