using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cloud.Internal;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UI.VideoAdPrizes;
using UnityEngine;

public class Globals
{
	public enum BuildPurpose
	{
		UNDEFINED,
		DEV,
		QA,
		LIVE,
		REGRESSION
	}

	public enum LogInState
	{
		Offline,
		Facebook,
		GameCenter,
		Both
	}

	private class AddedAnimationEventInfo
	{
		public Animation animation;

		public string clipName;

		public float time;

		public string functionName;

		public AddedAnimationEventInfo(Animation animation, string clipName, float time, string functionName)
		{
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a7: Expected Obj, but got Unknown
			//IL_04b0: Expected Obj, but got I4
			//IL_04ca: Expected I, but got Obj
			//IL_04e0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_051d: Expected Obj, but got Unknown
			//IL_0526: Expected Obj, but got I4
			//IL_053d: Expected Obj, but got F4
			//IL_0551: Expected I, but got F4
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Expected Obj, but got Unknown
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_040b: Expected VT, but got Obj
			//IL_0419: Expected I, but got Obj
			//IL_042f: Expected Obj, but got I
			//IL_0506: Expected Obj, but got I4
			//IL_0743: Expected VT, but got Obj
			//IL_00bd: Expected I, but got Obj
			//IL_045a: Expected I, but got Obj
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_05f3: Expected I, but got Obj
			//IL_0609: Expected Obj, but got I
			//IL_01be: Expected I, but got Obj
			//IL_0664: Unknown result type (might be due to invalid IL or missing references)
			//IL_0669: Expected Obj, but got Unknown
			//IL_020b: Expected I, but got Obj
			//IL_0258: Expected I, but got Obj
			//IL_026e: Expected Obj, but got I
			//IL_0299: Expected I, but got Obj
			//IL_02e2: Expected VT, but got Obj
			//IL_02f0: Expected I, but got Obj
			//IL_0306: Expected Obj, but got I
			//IL_0331: Expected I, but got Obj
			//IL_06e9: Expected I, but got Obj
			//IL_06ff: Expected Obj, but got I
			//IL_07bd: Expected VT, but got Obj
			//IL_03c2: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 24;
			obj = 0;
			_ = 0;
			_ = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v127 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string modelCamera;
			if ((UnityEngine.Object)(object)clipName != null)
			{
				string tag = ((Component)this).tag;
				bool activeSelf = ((GameObject)(object)tag).activeSelf;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v80 (Il2CppClass<NGUITools>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v85 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				modelCamera = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
			}
			else
			{
				modelCamera = clipName;
			}
			Transform transform = (Transform)(obj2 + 12);
			transform = (Transform)0;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
			transform = (Transform)5000f;
			_ = 5000f;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)5000f;
			Transform transform2 = (Transform)(obj2 + 48);
			transform2 = transform;
			((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			((Transform)this).parent = transform2;
			object obj5 = default;
			object obj11 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref functionName))
			{
				UIExtensions.FitToWidget(transform2, (UIWidget)(object)this, (Camera)(object)modelCamera);
				obj = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (UnityEngine.Transform)+10]");
				_ = 0;
				string tag2 = animation.tag;
				nint num5 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v11 (Il2CppClass<UIRoot>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(UIRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v22 (Il2CppClass<UIRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float pixelSize = ((UISprite)(object)tag2).pixelSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animation @ L1 (UnityEngine.Animation)+64]");
				float num7 = 0f / pixelSize;
				float num8 = (float)transform * 2f;
				float num9 = num7 / num8;
				float num10 = num9 * 0.95f;
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v60 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v116 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num13 = Math.Abs(num10);
				if (num13 > Mathf.Epsilon)
				{
					nint num14 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v71 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num15 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v112 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float value = num10 - 1f;
					float num16 = Math.Abs(value);
					if (num16 > 0.01f)
					{
						transform.localScale = (Vector3)this;
						nint num17 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v81 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num18 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v108 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (num10 < 0f)
						{
							num10 = 0f;
						}
						else if (num10 > 2.1474836E+09f)
						{
							num10 = 2.1474836E+09f;
						}
						nint num19 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v89 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num20 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v99 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						transform2 = transform;
						((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
						Vector3 vector = (Vector3)transform2 / num10;
						transform2 = (Transform)obj2;
						Transform transform3 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						((Transform)this).parent = transform2;
					}
				}
				obj5 = obj11 + 1;
			}
			transform.localScale = (Vector3)this;
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num22 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform2 = transform;
			((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			Vector3 vector2 = (Vector3)transform2 / time;
			transform2 = (Transform)obj2;
			Transform transform4 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)this).parent = transform2;
		}
	}

	public static readonly bool DEBUG;

	public static readonly bool DEBUG_POPUP;

	public const bool DEBUG_SOCIAL_MANAGER_SERVER = false;

	public static BuildPurpose BUILD_PURPOSE;

	public static int DEFAULT_BUNDLES_VERSION;

	public static readonly bool DEBUG_SETTINGS;

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

	public static readonly bool DEBUG_USE_FAKE_NEW_ONLINE_SETTINGS;

	public static readonly bool DEBUG_OVERRIDE_ONLINE_SETTINGS_URL;

	public static readonly bool DEBUG_OVERRIDE_NEW_ONLINE_SETTINGS_URL;

	public static readonly bool DEBUG_USE_TEST_AD_CONSTANTS;

	public static bool DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_INMOBI;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK;

	public static bool DEBUG_INTERSTITIAL_PROVIDER_YEAHMOBI;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT;

	public static bool DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES;

	public static bool DEBUG_INTERSTITIAL_IN_EDITOR;

	public static bool DEBUG_VIDEOADS_PROVIDERS;

	public static bool DEBUG_VIDEOADS_PROVIDERS_ADCOLONY;

	public static bool DEBUG_VIDEOADS_PROVIDERS_FLURRY;

	public static bool DEBUG_VIDEOADS_PROVIDERS_VUNGLE;

	public static bool DEBUG_VIDEOADS_PROVIDERS_TAPJOY;

	public static bool DEBUG_VIDEOADS_PROVIDERS_INMOBI;

	public static bool DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST;

	public static bool DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC;

	public static bool DEBUG_VIDEOADS_PROVIDERS_FACEBOOK;

	public static bool DEBUG_VIDEOADS_PROVIDERS_MOBVISTA;

	public static bool DEBUG_VIDEOADS_PROVIDERS_YEAH_MOBI;

	public static bool DEBUG_USE_CELEBRATION_TESTER;

	public static bool DEBUG_USE_EVENT_TESTER;

	public static bool DEBUG_SHOW_PERFORMANCE_INFO;

	public static bool DEBUG_USE_TIMESCALE_PAUSE_BUTTON;

	public static bool DEBUG_ENABLE_SALES;

	public static bool DEBUG_ENABLE_HOLIDAY_SALES;

	public static bool DEBUG_ENABLE_NEW_YEAR_SALES;

	public static bool DEBUG_DISABLE_NOTIFICATION_REQUEST;

	public static bool DEBUG_TEST_FPS_SPIKES;

	public static bool DEBUG_USE_DEBUG_AD_PROVIDER;

	public static bool DEBUG_ENABLE_BOARD_BUNDLE;

	public static bool DEBUG_AD_SYSTEM_SINGLE_IMPRESSION;

	public static bool DEBUG_IGNORE_PROMOTION_EXPIRATION;

	public static readonly bool DEBUG_FORCE_SPECIFIC_LOCALE;

	public const string DEBUG_FORCED_LOCALE = "pt-BR";

	public static bool DEBUG_ENABLE_LOADING_DELAY;

	public const float DEBUG_LOADING_DELAY_SECONDS = 0.5f;

	public static bool DEBUG_USE_DEBUG_LOGS_INSTEAD_OF_FLURRY;

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

	public static bool DEBUG_FIRST_PURCHASE_BONUS;

	public static bool DEBUG_ENABLE_WELCOME_PACK;

	public static int DEBUG_WELCOME_PACK_ABTEST_DEFAULT_PAYLOAD;

	public static bool DEBUG_ENABLE_GET_2_KEYS;

	public static int DEBUG_INTRO_VIDEO_AD_PRIZE_INDEX;

	public static int DEBUG_RANDOM_VIDEO_AD_PRIZE_INDEX;

	public static int DEBUG_RANDOM_VIDEO_AD_PRIZE_SEED;

	public static VideoAdPrizeType DEBUG_VIDEO_AD_PRIZE_TYPE;

	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___SUPER_MYSTERY_BOX;

	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___MYSTERY_POWER_UP;

	public static readonly bool DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER;

	public static bool DEBUG_SKIP_DAILY_LETTERS;

	public static readonly bool DEBUG_USE_ENABLE_PLAYER_INFO___IS_ACTIVE_DAILY_LETTER_EVENT;

	public static readonly bool DEBUG_USE_ENABLE_PLAYER_INFO___HAS_DAILY_WORD_TIME_LEFT;

	public static bool DEBUG_USE_DEBUG_DAILYWORD;

	public static readonly bool DEBUG_IS_HOVERBOARD_ALWAYS_REWARDED_FOR_MYSERY_POWERUP;

	public const string OVERRIDEN_ONLINE_SETTINGS_BASE_URL = "http://10.0.0.169/hoodrunner";

	public const string OVERRIDEN_NEW_ONLINE_SETTINGS_BASE_URL = "";

	public const string DEBUG_DAILYWORD = "Day";

	public const LogInState DEBUG_LOGIN_STATE = LogInState.Facebook;

	public static Characters.CharacterId debugLimitedCharacterPopupId;

	public static Boards.BoardId debugLimitedBoardPopupId;

	public const string fakeOnlineSettings = "efe40d19b11ddd485b4188664e9969f4bc89de0d\n[latestversion] 1.7.4\n[latestversion_changelist] \n\n\n* Subway Surfers in the Snow!\n* Limited Holiday character\n* Discover special Boards\n* Receive a free GIFT!\n* Optimized for iPhone 5!\n[in_app_tier_1] 2500\n[in_app_tier_2] 15000\n[in_app_tier_3] -40\n[in_app_tier_4] 250000\n[in_app_tier_5] -30\n[in_app_tier_6] -30\n[in_app_tier_7] -30\n[in_app_tier_8] -30\n[in_app_double_coins] -5\n[discount_end_time] 1496318400\n[videoads_providerlist] vungleclips\n[hoverboard_expiretime_liberty] 23-12-2012 22:00:00\n[hoverboard_starttime_liberty] 20-11-2012 22:00:00\n[character_expiretime_nychar] 23-12-2012 22:00:00\n[character_starttime_nychar] 13-10-2012 22:00:00\n[character_expiretime_elftricky] 23-11-2012 22:00:00\n[character_starttime_elftricky] 23-11-2012 22:00:00\n[enable_local_notifications] true[save_me_locales] en_US;en_UK;[offerwall_number_of_offers] 4[offerwall_session_timeout] 24[offerwall_offers_timeout] 24[offerwall_balance_timeout] 24[offerwal_min_reward_allowed] 10[offerwall_max_reward_allowed] 10000[offerwall_filter_free] true[save_me_locales] all[event_id]1496318400[event_value] 0;0[event_type] CharacterName[event_start] 1404694800[event_end] 1496318400[event_ribbon_text]ad3;3;6[number_of_fails_for_interstitial] 1[interstitials_limit_per_hour] 10[interstitials_limit_per_day] 40[intesrtitials_delay_seconds] 10[keys_rewarded_for_video_ad] 2[sybo_analytics_enabled] true[sybo_analytics_endpoint_baseurl] https://subwaysurf.dev.bladesofbrim.com[sybo_analytics_sampling_threshold] 1[sybo_analytics_max_games_without_flush] 1[sybo_analytics_games_in_session_before_first_flush] 1[home_interstitials_list] supersonic:1_100,inmobi:2_100,chartboost:3_100,supersonic:4_100,facebook:5_100[home_videos_list] supersonic:1_100,adcolony:2_100,tapjoy:3_100,inmobi:4_100,flurry:5_100,chartboost:7_100[default_interstitial_list] supersonic:1_100,inmobi:2_100,chartboost:3_100,supersonic:4_100,facebook:5_100[default_video_list] supersonic:1_100,adcolony:2_100,tapjoy:3_100,inmobi:4_100,flurry:5_100,chartboost:7_100[ad_location_home_videos_enabled] true[ad_location_earn_coins_videos_enabled] true[ad_location_double_up_videos_enabled] true[ad_location_home_interstitials_enabled] true[ad_location_game_over_interstitials_enabled] true[loadscreen_allow_usertips] true[loadscreen_title] Player Tip[loadscreen_usertip_list]Abdennor, Mascara, Algeria;Earn Coins for your Facebook friends by making multiple runs!/Bayezed, Dhaka, Bangladesh;Activate your Hoverboard when you see obstacles in front of you and don't know what to do!/Jonathan, Sarawak, Malaysia;Play the Wordy Weekend event to unlock limited Characters!/Tyler, Rhode Island, USA;If you keep opening Mystery Boxes you might win the grand prize!/Amber, Cambridge, England;Complete the Weekly Hunt to win cool prizes!/Lukas, Copenhagen, Denmark;Double tap to activate your Hoverboards!/Ahmad, Selangor, Malaysia;Login to Facebook to earn more rewards!/Mikael, Kumasi, Ghana;Use Hoverboards to survive a crash!/Daniel, Vicensa, Italy;Remember to Double Up your items whenever possible!/Amar, Gothenburg, Sweden;Use Trains and other objects to stay as high in the air as possible!/Roberto, Knokke, Belgium;Try to stay as high in the air as possible!/Cooper, Dubbo, Australia;Use Hoverboards! If things get too hectic an explosion will clear the stage!/Meighan, Alberta, Canada;Super Jump with Hoverboards and Super Sneakers to get over the Trains!/Mostafa, Alexandria, Egypt;Invite your friends to play Subway Surfers for more fun!/Eelis, Hämeenlinna, Finland;Try to be on the roof of every Train as long as possible!/Amber, Cambridge, England;Use the Power Jumper to jump up onto the tunnels!/Thomas, Colorado, USA;Fully upgrade the Freestyler Board to get both Double Jump and Super Jump!/Musthapa, Sarawak, Malaysia;With the upgraded Monster board you can jump over the Trains, and it is also really fast!/Lasse, Birkelse, Denmark;Some Hoverboards have upgrades that make them faster!/Mansoor, Sindh, Pakistan;Open more Mystery Boxes in the Terrific Tuesday event and win mega prizes!/Sunil, Mumbai, India;Use the Bouncer board to pick up Coins from below!/Fakhry, Victoria, Malaysia;Get the Bouncer board to enjoy Super Sneakers and Hoverboard features at the same time!/Joshua, Maine, USA;You can cancel jumps by rolling in mid air!/Joshua, Maine, USA;You can hop on barriers to get onto trains!/Rachel, Ho Chi Minh City, Vietnam;To collect the High Jumper Awards get help from the Bouncer board!/Salman, Hyderabad, India;Don't forget the Daily Challenge! It rewards Super Mystery Boxes!/Liliane, Yaoundé, Cameroun;Earn Awards to get more Key";

	public const string FAKE_NEW_ONLINE_SETTINGS = "";

	public const int MAX_MULTIPLIER = 30;

	public const int MAX_RANK = 1;

	public const int BONUS_FACEBOOK = 5000;

	public const int INITIAL_AMOUNT_OF_KEYS = 5;

	public const int MIN_FRIEND_SCORE_REQUEST_INTERVAL = 15;

	public const int GIFT_BREADCRUMBS_TO_SHOW = 30;

	public const string BASE_URL = "http://hoodrunner.kiloo.com";

	public const string URL_FOR_FACEBOOK_POST = "http://redirect.kiloo.com/subwayapp.php";

	public const int PLAYERINFO_REDUNDANT_FILES = 1;

	public const int PLAYERINFO_BACKUP_SLOTS = 5;

	public const int PLAYERINFO_ALTERNATE_REDUNDANT_FILES = 0;

	public const int PLAYERINFO_ALTERNATE_BACKUP_SLOTS = 0;

	public const int DAILY_QUEST_MIN_REQUEST_INTERVAL = 120;

	public const string DAILY_QUEST_SECRET = "aIN0UXP4NNoANVGi5w3raGAFN1n5OLQZFDhwjs6HoX";

	public const string DAILY_QUEST_URL = "http://hoodrunner.kiloo.com/hr_dailyquests2.php";

	private const string PRIVACY_POLICY_URL = "https://poki.com/en/c/privacy-policy";

	private const string ONLINESETTINGS_PRIVACY_POLICY_KEY = "privacy_policy_url";

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
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00af: Expected I4, but got Obj
			//IL_00b3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			return (string)((OnlineSettings)(object)saveDataPath).GetValue("privacy_policy_url", (byte)(int)"https://poki.com/en/c/privacy-policy" != 0);
		}
	}

	public static string AppStoreURL
	{
		get
		{
			//IL_0052: Expected I, but got Obj
			//IL_0068: Expected Obj, but got I
			//IL_0093: Expected I, but got Obj
			string dataPath = Application.dataPath;
			if ((nint)dataPath == 8)
			{
				return "itms-apps://itunes.apple.com/app/id512939461";
			}
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 == 11)
			{
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v24 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (DeviceUtility.GetIOSOtherAudioPlaying())
				{
					return "http://www.amazon.com/review/create-review/ref=cm_cr_dp_wrt_btm?ie=UTF8&asin=B009UX2YAC";
				}
				return "market://details?id=com.kiloo.subwaysurf";
			}
			return "";
		}
	}

	static Globals()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0075: Expected VT, but got Obj
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d7: Expected VT, but got Obj
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0139: Expected VT, but got Obj
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_019b: Expected VT, but got Obj
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01fd: Expected VT, but got Obj
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_025f: Expected VT, but got Obj
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02c1: Expected VT, but got Obj
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0323: Expected VT, but got Obj
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0385: Expected VT, but got Obj
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03e7: Expected VT, but got Obj
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0449: Expected VT, but got Obj
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0460: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04ab: Expected VT, but got Obj
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04c2: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_050d: Expected VT, but got Obj
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got I4
		//IL_052d: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I4
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_056f: Expected VT, but got Obj
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected Obj, but got Unknown
		//IL_0586: Expected Obj, but got I4
		//IL_058f: Expected Obj, but got I4
		//IL_0598: Expected Obj, but got I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05d1: Expected VT, but got Obj
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05e8: Expected Obj, but got I4
		//IL_05f1: Expected Obj, but got I4
		//IL_05fa: Expected Obj, but got I4
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0633: Expected VT, but got Obj
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got Unknown
		//IL_064a: Expected Obj, but got I4
		//IL_0653: Expected Obj, but got I4
		//IL_065c: Expected Obj, but got I4
		//IL_067c: Expected I, but got Obj
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_06b0: Expected Obj, but got I
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_06cf: Expected Obj, but got I4
		//IL_06d8: Expected Obj, but got I4
		//IL_06e1: Expected Obj, but got I4
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_071a: Expected VT, but got Obj
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_0731: Expected Obj, but got I4
		//IL_073a: Expected Obj, but got I4
		//IL_0743: Expected Obj, but got I4
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_077c: Expected VT, but got Obj
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected Obj, but got Unknown
		//IL_0793: Expected Obj, but got I4
		//IL_079c: Expected Obj, but got I4
		//IL_07a5: Expected Obj, but got I4
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected Obj, but got Unknown
		//IL_07de: Expected VT, but got Obj
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_07f5: Expected Obj, but got I4
		//IL_07fe: Expected Obj, but got I4
		//IL_0807: Expected Obj, but got I4
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_0840: Expected VT, but got Obj
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_0857: Expected Obj, but got I4
		//IL_0860: Expected Obj, but got I4
		//IL_0869: Expected Obj, but got I4
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_08a2: Expected VT, but got Obj
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected Obj, but got Unknown
		//IL_08b9: Expected Obj, but got I4
		//IL_08c2: Expected Obj, but got I4
		//IL_08cb: Expected Obj, but got I4
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected Obj, but got Unknown
		//IL_0904: Expected VT, but got Obj
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_091b: Expected Obj, but got I4
		//IL_0924: Expected Obj, but got I4
		//IL_092d: Expected Obj, but got I4
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected Obj, but got Unknown
		//IL_0966: Expected VT, but got Obj
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_097d: Expected Obj, but got I4
		//IL_0986: Expected Obj, but got I4
		//IL_098f: Expected Obj, but got I4
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected Obj, but got Unknown
		//IL_09c8: Expected VT, but got Obj
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected Obj, but got Unknown
		//IL_09df: Expected Obj, but got I4
		//IL_09e8: Expected Obj, but got I4
		//IL_09f1: Expected Obj, but got I4
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Expected Obj, but got Unknown
		//IL_0a2a: Expected VT, but got Obj
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected Obj, but got Unknown
		//IL_0a41: Expected Obj, but got I4
		//IL_0a4a: Expected Obj, but got I4
		//IL_0a53: Expected Obj, but got I4
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected Obj, but got Unknown
		//IL_0a8c: Expected VT, but got Obj
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0aa3: Expected Obj, but got I4
		//IL_0aac: Expected Obj, but got I4
		//IL_0ab5: Expected Obj, but got I4
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected Obj, but got Unknown
		//IL_0aee: Expected VT, but got Obj
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_0b05: Expected Obj, but got I4
		//IL_0b0e: Expected Obj, but got I4
		//IL_0b17: Expected Obj, but got I4
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0b50: Expected VT, but got Obj
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected Obj, but got Unknown
		//IL_0b67: Expected Obj, but got I4
		//IL_0b70: Expected Obj, but got I4
		//IL_0b79: Expected Obj, but got I4
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected Obj, but got Unknown
		//IL_0bb2: Expected VT, but got Obj
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected Obj, but got Unknown
		//IL_0bc9: Expected Obj, but got I4
		//IL_0bd2: Expected Obj, but got I4
		//IL_0bdb: Expected Obj, but got I4
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected Obj, but got Unknown
		//IL_0c14: Expected VT, but got Obj
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected Obj, but got Unknown
		//IL_0c2b: Expected Obj, but got I4
		//IL_0c34: Expected Obj, but got I4
		//IL_0c3d: Expected Obj, but got I4
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5d: Expected Obj, but got Unknown
		//IL_0c76: Expected VT, but got Obj
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0c8d: Expected Obj, but got I4
		//IL_0c96: Expected Obj, but got I4
		//IL_0c9f: Expected Obj, but got I4
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected Obj, but got Unknown
		//IL_0cd8: Expected VT, but got Obj
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Expected Obj, but got Unknown
		//IL_0cef: Expected Obj, but got I4
		//IL_0cf8: Expected Obj, but got I4
		//IL_0d01: Expected Obj, but got I4
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got Unknown
		//IL_0d3a: Expected VT, but got Obj
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Expected Obj, but got Unknown
		//IL_0d51: Expected Obj, but got I4
		//IL_0d5a: Expected Obj, but got I4
		//IL_0d63: Expected Obj, but got I4
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected Obj, but got Unknown
		//IL_0d9c: Expected VT, but got Obj
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected Obj, but got Unknown
		//IL_0db3: Expected Obj, but got I4
		//IL_0dbc: Expected Obj, but got I4
		//IL_0dc5: Expected Obj, but got I4
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected Obj, but got Unknown
		//IL_0dfe: Expected VT, but got Obj
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected Obj, but got Unknown
		//IL_0e15: Expected Obj, but got I4
		//IL_0e1e: Expected Obj, but got I4
		//IL_0e27: Expected Obj, but got I4
		//IL_0e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Expected Obj, but got Unknown
		//IL_0e60: Expected VT, but got Obj
		//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected Obj, but got Unknown
		//IL_0e77: Expected Obj, but got I4
		//IL_0e80: Expected Obj, but got I4
		//IL_0e89: Expected Obj, but got I4
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Expected Obj, but got Unknown
		//IL_0ec2: Expected VT, but got Obj
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Expected Obj, but got Unknown
		//IL_0ed9: Expected Obj, but got I4
		//IL_0ee2: Expected Obj, but got I4
		//IL_0eeb: Expected Obj, but got I4
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected Obj, but got Unknown
		//IL_0f24: Expected VT, but got Obj
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f32: Expected Obj, but got Unknown
		//IL_0f3b: Expected Obj, but got I4
		//IL_0f44: Expected Obj, but got I4
		//IL_0f4d: Expected Obj, but got I4
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Expected Obj, but got Unknown
		//IL_0f86: Expected VT, but got Obj
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected Obj, but got Unknown
		//IL_0f9d: Expected Obj, but got I4
		//IL_0fa6: Expected Obj, but got I4
		//IL_0faf: Expected Obj, but got I4
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Expected Obj, but got Unknown
		//IL_0fe8: Expected VT, but got Obj
		//IL_0ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Expected Obj, but got Unknown
		//IL_0fff: Expected Obj, but got I4
		//IL_1008: Expected Obj, but got I4
		//IL_1011: Expected Obj, but got I4
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Expected Obj, but got Unknown
		//IL_104a: Expected VT, but got Obj
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected Obj, but got Unknown
		//IL_1061: Expected Obj, but got I4
		//IL_106a: Expected Obj, but got I4
		//IL_1073: Expected Obj, but got I4
		//IL_109e: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 256;
		obj = 0;
		obj = 0;
		obj = -37;
		_ = -1;
		_ = 77;
		_ = -1;
		object obj3 = obj2 + 340;
		obj3 = obj;
		object obj4 = obj2 + 344;
		obj4 = obj3;
		GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR = (Color32)obj4;
		object obj5 = obj2 + 248;
		obj5 = 0;
		obj5 = 0;
		obj5 = 33;
		_ = 117;
		_ = 0;
		_ = -1;
		object obj6 = obj2 + 336;
		obj6 = obj5;
		obj4 = obj6;
		GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR_SHADOW = (Color32)obj4;
		object obj7 = obj2 + 244;
		obj7 = 0;
		obj7 = 0;
		obj7 = 27;
		_ = 88;
		_ = 0;
		_ = -1;
		object obj8 = obj2 + 332;
		obj8 = obj7;
		obj4 = obj8;
		GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_COLOR = (Color32)obj4;
		object obj9 = obj2 + 240;
		obj9 = 0;
		obj9 = 0;
		obj9 = 55;
		_ = -74;
		_ = 0;
		_ = 0;
		object obj10 = obj2 + 328;
		obj10 = obj9;
		obj4 = obj10;
		GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR = (Color32)obj4;
		object obj11 = obj2 + 232;
		obj11 = 0;
		obj11 = 0;
		obj11 = -1;
		_ = -10;
		_ = 106;
		_ = -1;
		object obj12 = obj2 + 324;
		obj12 = obj11;
		obj4 = obj12;
		GlobalColorsGenerated.DISCOUNT_BUTTON_PRICE_COLOR = (Color32)obj4;
		object obj13 = obj2 + 224;
		obj13 = 0;
		obj13 = 0;
		obj13 = 53;
		_ = 0;
		_ = 100;
		_ = -1;
		object obj14 = obj2 + 320;
		obj14 = obj13;
		obj4 = obj14;
		GlobalColorsGenerated.DISCOUNT_BUTTON_PRICE_SHADOW_COLOR = (Color32)obj4;
		object obj15 = obj2 + 220;
		obj15 = 0;
		obj15 = 0;
		obj15 = -1;
		_ = -83;
		_ = 106;
		_ = -1;
		object obj16 = obj2 + 316;
		obj16 = obj15;
		obj4 = obj16;
		GlobalColorsGenerated.DISCOUNT_BUTTON_LIMITED_TIME_COLOR = (Color32)obj4;
		object obj17 = obj2 + 212;
		obj17 = 0;
		obj17 = 0;
		obj17 = 75;
		_ = 5;
		_ = -128;
		_ = -1;
		object obj18 = obj2 + 312;
		obj18 = obj17;
		obj4 = obj18;
		GlobalColorsGenerated.DISCOUNT_BUTTON_LIMITED_TIME_SHADOW_COLOR = (Color32)obj4;
		object obj19 = obj2 + 208;
		obj19 = 0;
		obj19 = 0;
		obj19 = -1;
		_ = 124;
		_ = 0;
		_ = -1;
		object obj20 = obj2 + 308;
		obj20 = obj19;
		obj4 = obj20;
		GlobalColorsGenerated.DISCOUNT_STICKER_COLOR = (Color32)obj4;
		object obj21 = obj2 + 204;
		obj21 = 0;
		obj21 = 0;
		obj21 = -1;
		_ = -10;
		_ = 106;
		_ = -1;
		object obj22 = obj2 + 304;
		obj22 = obj21;
		obj4 = obj22;
		GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR = (Color32)obj4;
		object obj23 = obj2 + 196;
		obj23 = 0;
		obj23 = 0;
		obj23 = 117;
		_ = 17;
		_ = -83;
		_ = -1;
		object obj24 = obj2 + 300;
		obj24 = obj23;
		obj4 = obj24;
		GlobalColorsGenerated.WEEKLYHUNT_CITY_NAME = (Color32)obj4;
		object obj25 = obj2 + 192;
		obj25 = 0;
		obj25 = 0;
		obj25 = -1;
		_ = 124;
		_ = 0;
		_ = -1;
		object obj26 = obj2 + 296;
		obj26 = obj25;
		obj4 = obj26;
		GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG = (Color32)obj4;
		object obj27 = obj2 + 184;
		obj27 = 0;
		obj27 = 0;
		obj27 = -1;
		_ = -10;
		_ = 106;
		_ = -1;
		object obj28 = obj2 + 292;
		obj28 = obj27;
		obj4 = obj28;
		GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT = (Color32)obj4;
		object obj29 = obj2 + 180;
		obj29 = 0;
		obj29 = 0;
		obj29 = -1;
		_ = 124;
		_ = 0;
		_ = -1;
		object obj30 = obj2 + 288;
		obj30 = obj29;
		obj4 = obj30;
		GlobalColorsGenerated.WEEKLYHUNT_SPLASH = (Color32)obj4;
		object obj31 = obj2 + 172;
		obj31 = 0;
		obj31 = 0;
		obj31 = -91;
		_ = 58;
		_ = 0;
		_ = -1;
		object obj32 = obj2 + 284;
		obj32 = obj31;
		obj4 = obj32;
		GlobalColorsGenerated.WEEKLYHUNT_SPLASH_SHADOW = (Color32)obj4;
		object obj33 = obj2 + 168;
		obj33 = 0;
		obj33 = 0;
		obj33 = -124;
		_ = 20;
		_ = -62;
		_ = -1;
		object obj34 = obj2 + 280;
		obj34 = obj33;
		obj4 = obj34;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_BG_GRADIENT_TOP = (Color32)obj4;
		object obj35 = obj2 + 160;
		obj35 = 0;
		obj35 = 0;
		obj35 = 85;
		_ = 9;
		_ = 127;
		_ = -1;
		nint num = (nint)typeof(GlobalColorsGenerated);
		object obj36 = obj2 + 276;
		obj36 = obj35;
		obj4 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v176 (Il2CppClass<GlobalColorsGenerated>)+5C]");
		object obj37 = -(-64);
		obj37 = obj4;
		object obj38 = obj2 + 152;
		obj38 = 0;
		obj38 = 0;
		obj38 = -1;
		_ = 124;
		_ = 0;
		_ = -1;
		object obj39 = obj2 + 272;
		obj39 = obj38;
		obj4 = obj39;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_PROGRESSBAR_BG = (Color32)obj4;
		object obj40 = obj2 + 148;
		obj40 = 0;
		obj40 = 0;
		obj40 = -1;
		_ = -10;
		_ = 106;
		_ = -1;
		object obj41 = obj2 + 268;
		obj41 = obj40;
		obj4 = obj41;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_PROGRESSBAR_FG = (Color32)obj4;
		object obj42 = obj2 + 144;
		obj42 = 0;
		obj42 = 0;
		obj42 = -100;
		_ = 49;
		_ = 0;
		_ = -1;
		object obj43 = obj2 + 264;
		obj43 = obj42;
		obj4 = obj43;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_PROGRESSBAR_TEXT = (Color32)obj4;
		object obj44 = obj2 + 136;
		obj44 = 0;
		obj44 = 0;
		obj44 = -1;
		_ = -10;
		_ = 106;
		_ = -1;
		object obj45 = obj2 + 260;
		obj45 = obj44;
		obj4 = obj45;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_TITLE_TEXT = (Color32)obj4;
		object obj46 = obj2 + 132;
		obj46 = 0;
		obj46 = 0;
		obj46 = 53;
		_ = 0;
		_ = 100;
		_ = -1;
		object obj47 = obj2 + 252;
		obj47 = obj46;
		obj4 = obj47;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_TITLE_TEXT_SHADOW = (Color32)obj4;
		object obj48 = obj2 + 124;
		obj48 = 0;
		obj48 = 0;
		obj48 = -21;
		_ = -56;
		_ = -1;
		_ = -1;
		object obj49 = obj2 + 236;
		obj49 = obj48;
		obj4 = obj49;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_GOAL_TEXT = (Color32)obj4;
		object obj50 = obj2 + 120;
		obj50 = 0;
		obj50 = 0;
		obj50 = 52;
		_ = 0;
		_ = 97;
		_ = -1;
		object obj51 = obj2 + 228;
		obj51 = obj50;
		obj4 = obj51;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_GOAL_TEXT_SHADOW = (Color32)obj4;
		object obj52 = obj2 + 112;
		obj52 = 0;
		obj52 = 0;
		obj52 = -37;
		_ = -1;
		_ = 77;
		_ = -1;
		object obj53 = obj2 + 216;
		obj53 = obj52;
		obj4 = obj53;
		GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_TITLE_TEXT = (Color32)obj4;
		object obj54 = obj2 + 108;
		obj54 = 0;
		obj54 = 0;
		obj54 = 33;
		_ = 117;
		_ = 0;
		_ = -1;
		object obj55 = obj2 + 200;
		obj55 = obj54;
		obj4 = obj55;
		GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_TITLE_TEXT_SHADOW = (Color32)obj4;
		object obj56 = obj2 + 100;
		obj56 = 0;
		obj56 = 0;
		obj56 = -14;
		_ = -1;
		_ = -76;
		_ = -1;
		object obj57 = obj2 + 188;
		obj57 = obj56;
		obj4 = obj57;
		GlobalColorsGenerated.WEEKLYHUNT_REWARD_HEADLINE = (Color32)obj4;
		object obj58 = obj2 + 96;
		obj58 = 0;
		obj58 = 0;
		obj58 = 80;
		_ = -113;
		_ = 0;
		_ = -1;
		object obj59 = obj2 + 176;
		obj59 = obj58;
		obj4 = obj59;
		GlobalColorsGenerated.WEEKLYHUNT_REWARD_HEADLINE_SHADOW = (Color32)obj4;
		object obj60 = obj2 + 88;
		obj60 = 0;
		obj60 = 0;
		obj60 = -127;
		_ = 19;
		_ = -66;
		_ = -1;
		object obj61 = obj2 + 164;
		obj61 = obj60;
		obj4 = obj61;
		GlobalColorsGenerated.WEEKLYHUNT_REWARD_AND_AMOUNT_TEXT = (Color32)obj4;
		object obj62 = obj2 + 84;
		obj62 = 0;
		obj62 = 0;
		obj62 = -16;
		_ = -9;
		_ = -19;
		_ = -1;
		object obj63 = obj2 + 156;
		obj63 = obj62;
		obj4 = obj63;
		GlobalColorsGenerated.WEEKLYHUNT_REWARD_AND_AMOUNT_TEXT_SHADOW = (Color32)obj4;
		object obj64 = obj2 + 76;
		obj64 = 0;
		obj64 = 0;
		obj64 = -47;
		_ = 102;
		_ = 0;
		_ = -1;
		object obj65 = obj2 + 140;
		obj65 = obj64;
		obj4 = obj65;
		GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_PROGRESSBAR_TEXT = (Color32)obj4;
		object obj66 = obj2 + 68;
		obj66 = 0;
		obj66 = 0;
		obj66 = -1;
		_ = -85;
		_ = 40;
		_ = -1;
		object obj67 = obj2 + 128;
		obj67 = obj66;
		obj4 = obj67;
		GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_PROGRESSBAR_FG = (Color32)obj4;
		object obj68 = obj2 - -64;
		obj68 = 0;
		obj68 = 0;
		obj68 = -1;
		_ = 124;
		_ = 0;
		_ = -1;
		object obj69 = obj2 + 116;
		obj69 = obj68;
		obj4 = obj69;
		GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_PROGRESSBAR_BG = (Color32)obj4;
		object obj70 = obj2 + 60;
		obj70 = 0;
		obj70 = 0;
		obj70 = 61;
		_ = -56;
		_ = 0;
		_ = -1;
		object obj71 = obj2 + 104;
		obj71 = obj70;
		obj4 = obj71;
		GlobalColorsGenerated.WEEKLYHUNT_REWARD_BG_GRADIENT_TOP = (Color32)obj4;
		object obj72 = obj2 + 52;
		obj72 = 0;
		obj72 = 0;
		obj72 = 46;
		_ = -99;
		_ = 0;
		_ = -1;
		object obj73 = obj2 + 92;
		obj73 = obj72;
		obj4 = obj73;
		GlobalColorsGenerated.WEEKLYHUNT_REWARD_BG_GRADIENT_BOTTOM = (Color32)obj4;
		object obj74 = obj2 + 44;
		obj74 = 0;
		obj74 = 0;
		obj74 = -98;
		_ = 57;
		_ = -44;
		_ = -1;
		object obj75 = obj2 + 80;
		obj75 = obj74;
		obj4 = obj75;
		GlobalColorsGenerated.WEEKLYHUNT_DIVIDER = (Color32)obj4;
		object obj76 = obj2 + 40;
		obj76 = 0;
		obj76 = 0;
		obj76 = -1;
		_ = -83;
		_ = 106;
		_ = -1;
		object obj77 = obj2 + 72;
		obj77 = obj76;
		obj4 = obj77;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_STATUS_TEXT = (Color32)obj4;
		object obj78 = obj2 + 36;
		obj78 = 0;
		obj78 = 0;
		obj78 = 72;
		_ = 9;
		_ = 126;
		_ = -1;
		object obj79 = obj2 + 56;
		obj79 = obj78;
		obj4 = obj79;
		GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_STATUS_TEXT_SHADOW = (Color32)obj4;
		object obj80 = obj2 + 28;
		obj80 = 0;
		obj80 = 0;
		obj80 = -16;
		_ = -1;
		_ = -85;
		_ = -1;
		object obj81 = obj2 + 48;
		obj81 = obj80;
		obj4 = obj81;
		GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_STATUS_TEXT = (Color32)obj4;
		object obj82 = obj2 + 20;
		obj82 = 0;
		obj82 = 0;
		obj82 = 34;
		_ = 121;
		_ = 0;
		_ = -1;
		object obj83 = obj2 + 32;
		obj83 = obj82;
		obj4 = obj83;
		GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_STATUS_TEXT_SHADOW = (Color32)obj4;
		object obj84 = obj2 + 16;
		obj84 = 0;
		obj84 = 0;
		obj84 = 61;
		_ = -56;
		_ = 0;
		_ = -1;
		object obj85 = obj2 + 24;
		obj85 = obj84;
		obj4 = obj85;
		GlobalColorsGenerated.WEEKLYHUNT_REWARD_BG = (Color32)obj4;
		object obj86 = obj2 + 8;
		obj86 = 0;
		obj86 = 0;
		obj86 = -1;
		_ = -1;
		_ = -1;
		_ = -1;
		object obj87 = obj2 + 12;
		obj87 = obj86;
		obj4 = obj87;
		GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR_STRIPED_BACKGROUND = (Color32)obj4;
		object obj88 = obj2 + 4;
		obj88 = 0;
		obj88 = 0;
		obj88 = -1;
		_ = -55;
		_ = 125;
		_ = -1;
		obj2 = obj88;
		obj4 = obj2;
		GlobalColorsGenerated.WEEKLYHUNT_CELEBRATION_STRIPE_COLOR = (Color32)obj4;
	}

	public static string GetPrivacyPolicyUrl()
	{
		bool flag = GameStats.instance == null;
		bool flag2 = !flag;
		GameStats result = GameStats.instance;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameStats gameStats = default;
			gameStats.CoinsSpawnedIncrement();
			GameStats.instance = gameStats;
			result = gameStats;
		}
		return (string)(object)result;
	}

	public static Friend[] GetDebugFriends(int numberOfFriends = 10)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
		int num3 = numberOfFriends << 1;
		return (Friend[])((allowSellConsumablesDuringRun ? 1 : 0) * num3);
	}

	public static LogInState GetLoginState()
	{
		//IL_0132: Expected I4, but got Obj
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		string dataPath = Application.dataPath;
		object obj;
		if ((nint)dataPath == 8)
		{
			obj = "http://itunes.apple.com/app/subway-surfers/id512939461";
		}
		else
		{
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 == 11)
			{
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v24 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = ((!DeviceUtility.GetIOSOtherAudioPlaying()) ? "https://play.google.com/store/apps/details?id=com.kiloo.subwaysurf" : "http://www.amazon.com/gp/mas/dl/android?p=com.kiloo.subwaysurf");
			}
			else
			{
				obj = "test";
			}
		}
		return (LogInState)obj;
	}

	public unsafe static Dictionary<T, int> convertStringToEnumIntDictionary<T>(string sourceString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected I, but got Unknown
		//IL_03b4: Expected I, but got Obj
		//IL_03ca: Expected Obj, but got I4
		//IL_03d3: Expected Obj, but got I4
		//IL_00a8: Expected I, but got Obj
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I4
		//IL_014f: Expected I, but got Obj
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = default;
		object obj4 = num + 24;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v2+4]");
		object obj7 = 0;
		object obj8 = obj7 & 0x3FFF;
		object obj9 = obj8 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v250 @ S3_v6 (should have been resolved before IL gen)");
		object obj10 = obj4;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26 (Il2CppClass<System.Type>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v126 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v23+8]");
		obj2 = 0;
		nint num4 = (nint)(obj2 + 16);
		((IntPtr*)num4)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num4);
		object obj12 = 0;
		object obj13 = 97173;
		object obj14 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		object obj22 = default;
		object obj23 = default;
		int totalLength = default;
		object obj27 = default;
		Dictionary<T, int> result = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v46 (Il2CppClass<System.Enum>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num6 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v115 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj13 = 0;
				obj9 = 1;
				object obj16 = obj17;
				object obj18 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj26;
				if (obj18 == obj20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj21 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj23 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						string msg = string.ConcatArray((string[])(object)"Enum Parse Failed ", totalLength);
						FileUtil.LogWarning(msg);
						object obj24 = obj12 + 1;
						obj12 = obj24;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
					object obj25 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					obj26 = obj27;
					break;
				}
				obj26 = obj16;
				break;
			}
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return null;
	}

	public unsafe static string convertEnumIntDictionaryToString<T>(Dictionary<T, int> sourceDict)
	{
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I4
		//IL_039d: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_03ec: Expected Obj, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected I, but got Unknown
		//IL_0407: Expected I, but got Obj
		//IL_041d: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I4
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_00c0: Expected I, but got Obj
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_01a0: Expected I, but got Obj
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I4
		//IL_022e: Expected I, but got Obj
		//IL_02e9: Expected I, but got Obj
		//IL_02ff: Expected Obj, but got I
		//IL_04b6: Expected I4, but got Obj
		//IL_04bf: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_032a: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 4);
		formatProvider = (IFormatProvider)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj2 = num + 16;
		obj2 = 44;
		string text = ((string)(object)sourceDict).Substring(num);
		nint num2 = default;
		object obj3 = num2 + 24;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+4]");
		object obj6 = 0;
		object obj7 = text + 12;
		object obj8 = obj7 / 2;
		object obj9 = obj6 & 0x3FFF;
		object obj10 = obj9 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v116 @ S3_v5 (should have been resolved before IL gen)");
		object obj11 = obj3;
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (Il2CppClass<System.Type>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v94 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28+8]");
		obj = 0;
		nint num5 = (nint)(obj + 8);
		((IntPtr*)num5)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num5);
		object obj13 = 97173;
		object obj14 = 0;
		while (true)
		{
			object obj15 = obj7 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
			{
				break;
			}
			object obj16 = text + 16;
			object obj17 = obj14 << 2;
			object obj18 = obj16 + obj17;
			object obj19 = obj14 << 2;
			object obj20 = text + obj19;
			object obj21 = obj20 + 20;
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v55 (Il2CppClass<System.Enum>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num7 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v90 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((Enum)(object)type).InternalHasFlag((Enum)obj18))
			{
				nint num8 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v65 (Il2CppClass<System.Enum>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num9 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v86 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = ((Enum)(object)type).ToString((string)obj18, (IFormatProvider)1);
				object obj24 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
				if (((int*)obj21)->System_002EIConvertible_002EToBoolean(formatProvider))
				{
					object obj25 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S3_v8+10]");
					obj10 = 0;
					object obj26 = obj10 & 0x1FFF;
					obj13 = obj26 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S4_v4 (should have been resolved before IL gen)");
				}
				else
				{
					nint num10 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v75 (Il2CppClass<Globals>)+BA]");
					object obj27 = (nint)0 & (nint)0x200;
					if (obj27 != null)
					{
						nint num11 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v81 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MysteryBox.TestRolls((int)"Source string could not parse int");
					obj10 = 0;
				}
			}
			object obj28 = obj14 + 2;
			obj14 = obj28;
		}
		string result = default;
		return result;
	}

	public unsafe static Dictionary<T, bool> convertStringToEnumBoolDictionary<T>(string sourceString)
	{
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_051d: Expected Obj, but got I4
		//IL_0535: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0584: Expected Obj, but got I
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected I, but got Unknown
		//IL_059f: Expected I, but got Obj
		//IL_05b5: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_00b2: Expected I, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_0261: Expected I, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I4
		//IL_02ef: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 4);
		formatProvider = (IFormatProvider)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj2 = num + 16;
		obj2 = 59;
		string text = sourceString.Substring(num);
		nint num2 = default;
		object obj3 = num2 + 24;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj5 = text + 12;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v4+4]");
		object obj7 = 0;
		object obj8 = obj7 & 0x3FFF;
		object obj9 = obj8 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v119 @ S3_v6 (should have been resolved before IL gen)");
		object obj10 = obj3;
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v26 (Il2CppClass<System.Type>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v128 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23+8]");
		obj = 0;
		nint num5 = (nint)(obj + 8);
		((IntPtr*)num5)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num5);
		object obj12 = 97173;
		object obj13 = 0;
		int num6 = default;
		object obj22;
		Dictionary<T, bool> result = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj14 = text + 16;
				object obj15 = obj13 << 2;
				object obj16 = obj14 + obj15;
				object obj17 = obj16;
				bool flag;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v44+8]");
					flag = (nint)0 == 0;
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					object obj18 = text + 16;
					object obj19 = obj13 << 2;
					object obj20 = obj18 + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj21 = num6 + 16;
					obj21 = 45;
					string text2 = ((string)obj20).Substring(num6);
					if (text2.m_firstChar == '\u0002')
					{
						obj22 = text2 + 16;
						object obj23 = text2 + 20;
						nint num7 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v64 (Il2CppClass<System.Enum>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num8 = (nint)typeof(Enum);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v120 (Il2CppClass<System.Enum>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((Enum)(object)type).InternalHasFlag((Enum)obj22))
						{
							nint num9 = (nint)typeof(Enum);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v71 (Il2CppClass<System.Enum>)+BA]");
							object obj25 = (nint)0 & (nint)0x200;
							if (obj25 != null)
							{
								nint num10 = (nint)typeof(Enum);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v116 (Il2CppClass<System.Enum>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							break;
						}
					}
				}
				object obj26 = obj13 + 1;
				obj13 = obj26;
				continue;
			}
			return result;
		}
		string text3 = ((Enum)(object)type).ToString((string)obj22, (IFormatProvider)1);
		object obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		throw new NullReferenceException();
	}

	public unsafe static string convertEnumBoolDictionaryToString<T>(Dictionary<T, bool> sourceDict)
	{
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fb: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected I, but got Unknown
		//IL_047d: Expected I, but got Obj
		//IL_0493: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_00c0: Expected I, but got Obj
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_01a0: Expected I, but got Obj
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I4
		//IL_027b: Expected I, but got Obj
		//IL_0291: Expected Obj, but got I
		//IL_022e: Expected I, but got Obj
		//IL_035f: Expected I, but got Obj
		//IL_0375: Expected Obj, but got I
		//IL_02bc: Expected I, but got Obj
		//IL_0556: Expected I4, but got Obj
		//IL_055f: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_03a0: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 8);
		formatProvider = (IFormatProvider)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj2 = num + 16;
		obj2 = 44;
		string text = ((string)(object)sourceDict).Substring(num);
		nint num2 = default;
		object obj3 = num2 + 24;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+4]");
		object obj6 = 0;
		object obj7 = text + 12;
		object obj8 = obj7 / 2;
		object obj9 = obj6 & 0x3FFF;
		object obj10 = obj9 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v116 @ S3_v5 (should have been resolved before IL gen)");
		object obj11 = obj3;
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (Il2CppClass<System.Type>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v103 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28+8]");
		obj = 0;
		nint num5 = (nint)(obj + 4);
		((IntPtr*)num5)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num5);
		object obj13 = 97173;
		object obj14 = 0;
		while (true)
		{
			object obj15 = obj7 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
			{
				break;
			}
			object obj16 = text + 16;
			object obj17 = obj14 << 2;
			object obj18 = obj16 + obj17;
			object obj19 = obj14 << 2;
			object obj20 = text + obj19;
			object obj21 = obj20 + 20;
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v55 (Il2CppClass<System.Enum>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num7 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v99 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((Enum)(object)type).InternalHasFlag((Enum)obj18))
			{
				nint num8 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v65 (Il2CppClass<System.Enum>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num9 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v95 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = ((Enum)(object)type).ToString((string)obj18, (IFormatProvider)1);
				object obj24 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
				nint num10 = (nint)typeof(bool);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v73 (Il2CppClass<System.Boolean>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num11 = (nint)typeof(bool);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v91 (Il2CppClass<System.Boolean>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((bool*)obj21)->System_002EIConvertible_002EToBoolean(formatProvider))
				{
					bool flag = formatProvider != null;
					object obj26 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S3_v9+10]");
					obj10 = 0;
					object obj27 = obj10 & 0x1FFF;
					obj13 = obj27 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S4_v4 (should have been resolved before IL gen)");
				}
				else
				{
					nint num12 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v80 (Il2CppClass<Globals>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num13 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v86 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					MysteryBox.TestRolls((int)"Source string could not parse bool");
					obj10 = 0;
				}
			}
			object obj29 = obj14 + 2;
			obj14 = obj29;
		}
		string result = default;
		return result;
	}

	public static Dictionary<string, string> convertStringToStringStringDictionary(string sourceString)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Dictionary<string, string> result = default;
		return result;
	}

	public static string convertStringStringDictionaryToString(Dictionary<string, string> sourceDict)
	{
		//IL_0169: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 44;
		string text = ((string)(object)sourceDict).Substring(num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = text + 12;
		object obj3 = obj2 / 2;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v3+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S4_v4 (should have been resolved before IL gen)");
		object obj9 = 0;
		while (true)
		{
			object obj10 = obj2 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				break;
			}
			object obj11 = text + 16;
			object obj12 = obj9 << 2;
			object obj13 = obj11 + obj12;
			object obj14 = obj9 << 2;
			object obj15 = text + obj14;
			object obj16 = obj15 + 20;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v8 (Il2CppMethodInfo)+C]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v9+60]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v10+48]");
			object obj19 = 0;
			object obj20 = obj19 & 0x7FF;
			object obj21 = obj20 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S5_v7 (should have been resolved before IL gen)");
			object obj22 = obj9 + 2;
			obj9 = obj22;
		}
		string result = default;
		return result;
	}

	public static Dictionary<T, int[]> convertStringToEnumIntArrayDictionary<T>(string sourceString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = sourceString + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DF86");
		Dictionary<T, int[]> result = default;
		return result;
	}

	public unsafe static string convertEnumIntArrayDictionaryToString<T>(Dictionary<T, int[]> sourceDict)
	{
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_051d: Expected Obj, but got I4
		//IL_0535: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0584: Expected Obj, but got I
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected I, but got Unknown
		//IL_059f: Expected I, but got Obj
		//IL_05b5: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_00b2: Expected I, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_0261: Expected I, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		//IL_02ef: Expected I, but got Obj
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected I4, but got Unknown
		//IL_0386: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_0422: Expected I, but got Obj
		//IL_0438: Expected Obj, but got I
		//IL_0657: Expected I4, but got Obj
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_0463: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 4);
		formatProvider = (IFormatProvider)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj2 = num + 16;
		obj2 = 59;
		string text = ((string)(object)sourceDict).Substring(num);
		nint num2 = default;
		object obj3 = num2 + 24;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj5 = text + 12;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v4+4]");
		object obj7 = 0;
		object obj8 = obj7 & 0x3FFF;
		object obj9 = obj8 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v119 @ S3_v6 (should have been resolved before IL gen)");
		object obj10 = obj3;
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v26 (Il2CppClass<System.Type>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v127 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23+8]");
		obj = 0;
		nint num5 = (nint)(obj + 8);
		((IntPtr*)num5)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num5);
		object obj12 = 97173;
		object obj13 = 0;
		int num6 = default;
		int num11 = default;
		string text5 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj14 = text + 16;
			object obj15 = obj13 << 2;
			object obj16 = obj14 + obj15;
			object obj17 = obj16;
			bool flag;
			if (obj16 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v44+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				object obj18 = text + 16;
				object obj19 = obj13 << 2;
				object obj20 = obj18 + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj21 = num6 + 16;
				obj21 = 45;
				string text2 = ((string)obj20).Substring(num6);
				if (text2.m_firstChar == '\u0002')
				{
					object obj22 = text2 + 16;
					object obj23 = text2 + 20;
					nint num7 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v64 (Il2CppClass<System.Enum>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num8 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v119 (Il2CppClass<System.Enum>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((Enum)(object)type).InternalHasFlag((Enum)obj22))
					{
						nint num9 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v71 (Il2CppClass<System.Enum>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num10 = (nint)typeof(Enum);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v115 (Il2CppClass<System.Enum>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text3 = ((Enum)(object)type).ToString((string)obj22, (IFormatProvider)1);
						object obj26 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						object obj27 = num11 + 16;
						obj27 = 44;
						string text4 = ((string)obj23).Substring(num11);
						int num12 = (int)(text4 + 12);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						object obj28 = 0;
						while ((nint)obj28 < ((int*)num12)->m_value)
						{
							object obj29 = text4 + 16;
							object obj30 = obj28 << 2;
							object obj31 = obj29 + obj30;
							if (((int*)obj31)->System_002EIConvertible_002EToBoolean(formatProvider))
							{
								object obj32 = text5 + 16;
								object obj33 = obj28 << 2;
								object obj34 = obj32 + obj33;
								obj34 = formatProvider;
							}
							else
							{
								nint num13 = (nint)typeof(Globals);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v102 (Il2CppClass<Globals>)+BA]");
								object obj35 = (nint)0 & (nint)0x200;
								if (obj35 != null)
								{
									nint num14 = (nint)typeof(Globals);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v108 (Il2CppClass<Globals>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								MysteryBox.TestRolls((int)"Source string could not parse int");
							}
							object obj36 = obj28 + 1;
							obj28 = obj36;
						}
						object obj37 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S3_v9+10]");
						obj9 = 0;
						object obj38 = obj9 & 0x1FFF;
						obj12 = obj38 + 113696;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v117 @ S4_v4 (should have been resolved before IL gen)");
					}
				}
			}
			object obj39 = obj13 + 1;
			obj13 = obj39;
		}
		string result = default;
		return result;
	}

	public static int[] convertAllStringToInt(string[] array)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_027e: Expected Obj, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected I4, but got Unknown
		//IL_024f: Expected Obj, but got I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		}
		object obj7 = obj5 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj5 + obj9;
		obj10 = 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj5 + obj11;
			if ((nint)obj12 == 80)
			{
				object obj13 = obj5 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0349;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0349;
		IL_0349:
		object obj16 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
		if ((nint)obj16 >= 1)
		{
			object obj17 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
			int index = obj17 - 1;
			StringBuilder stringBuilder2 = stringBuilder.Insert(index, (string)1);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int[] result = default;
		return result;
	}

	public unsafe static bool[] convertAllStringToBool(string[] array)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		object obj = array + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = 0;
		bool[] array2 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = array2 + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = array + 16;
			object obj7 = obj2 << 2;
			object obj8 = obj6 + obj7;
			TypeCode typeCode = ((int*)obj8)->GetTypeCode();
			obj5 = typeCode;
			object obj9 = obj2 + 1;
			obj2 = obj9;
		}
		return array2;
	}

	public static string[] convertAllIntToString(int[] array)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_007d: Expected I, but got Obj
		object obj = array + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = 0;
		string[] array2 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = array + 16;
			object obj4 = obj2 << 2;
			object value = obj3 + obj4;
			nint num = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v18 (Il2CppClass<System.Boolean>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(bool);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27 (Il2CppClass<System.Boolean>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = array2 + 16;
			object obj7 = obj6 + obj2;
			string text = bool.TrimWhiteSpaceAndNull((string)value);
			object obj8 = text & 1;
			obj7 = obj8;
			object obj9 = obj2 + 1;
			obj2 = obj9;
		}
		return array2;
	}

	public static string[] convertAllBoolToString(bool[] array)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj = array + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = array + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			throw new ArrayTypeMismatchException();
		}
		string[] result = default;
		return result;
	}

	public unsafe static bool TryAddAnimationEvent(Animation animation, string clipName, AnimationEvent aniEvent)
	{
		//IL_0379: Expected I4, but got Obj
		//IL_0379: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_043c: Expected I, but got Obj
		//IL_0452: Expected Obj, but got I
		//IL_0491: Expected Obj, but got I
		//IL_001e: Expected I4, but got Obj
		//IL_001e: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00ac: Expected I, but got Obj
		//IL_016c: Expected I4, but got Obj
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_01ca: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_022d: Expected Obj, but got I
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_0545: Expected I, but got Obj
		//IL_055b: Expected Obj, but got I
		//IL_0258: Expected I, but got Obj
		ref int reference = ref *(int*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animation @ L0 (UnityEngine.Animation)+8C]");
		bool flag = ((Dictionary<int, int>)0).TryGetValue((int)clipName, out reference);
		object obj = reference + 1;
		reference = ref *(int*)obj;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S4_v4+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S5_v4 (should have been resolved before IL gen)");
		if (aniEvent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animation @ L0 (UnityEngine.Animation)+90]");
			bool flag2 = ((Dictionary<int, int>)0).TryGetValue((int)clipName, out reference);
			object obj7 = reference + 1;
			reference = ref *(int*)obj7;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S4_v9 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S4_v10+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S4_v11+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S5_v9 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		nint num3 = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v23 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v82 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float recommendationEvaluation = ((CloudSaveConflictResolver)(object)clipName).recommendationEvaluation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animation @ L0 (UnityEngine.Animation)+94]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v31+C]");
		int num5 = 0;
		while (true)
		{
			int num6 = num5 - 1;
			if (num6 < 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animation @ L0 (UnityEngine.Animation)+94]");
			ActivePowerup activePowerup = ((List<ActivePowerup>)0).get_Item(num6);
			UpgradeType type = activePowerup.type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v20 (System.Boolean)+8]");
			if ((nint)type == (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animation @ L0 (UnityEngine.Animation)+94]");
				((List<ActivePowerup>)0).RemoveAt(num6);
			}
			num5 = num6;
		}
		((GameStats)(object)animation).AddScoreForPickup((byte)(int)clipName != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		nint num7 = (nint)typeof(GameStats._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v22 (Il2CppClass<GameStats+<>c>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(GameStats._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v73 (Il2CppClass<GameStats+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (GameStats._003C_003Ec._003C_003E9__116_0 == null)
		{
			nint num9 = (nint)typeof(GameStats._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v47 (Il2CppClass<GameStats+<>c>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num10 = (nint)typeof(GameStats._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v67 (Il2CppClass<GameStats+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			object obj18 = default;
			object obj17 = obj18 + 16;
			obj17 = GameStats._003C_003Ec._003C_003E9;
			nint num12 = (nint)typeof(GameStats._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v64 (Il2CppClass<GameStats+<>c>)+5C]");
			object obj19 = (nint)0 + (nint)4;
			obj19 = obj18;
		}
		throw new NullReferenceException();
	}

	private unsafe static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01a9: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected VT, but got Unknown
		//IL_0252: Expected F4, but got Obj
		//IL_024d: Expected native int or pointer, but got VT
		//IL_00e3: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 12;
		obj = context;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v29 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj & 0xFF;
		object obj5 = obj4 - 30;
		if ((nint)obj5 < 0)
		{
			obj5 = 0;
		}
		else if ((nint)obj5 > 255)
		{
			obj5 = 255;
		}
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		object obj7 = obj2 + 8;
		obj7 = context;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v19+1]");
		object obj8 = -30;
		if ((nint)obj8 < 0)
		{
			obj8 = 0;
		}
		else if ((nint)obj8 > 255)
		{
			obj8 = 255;
		}
		object obj9 = obj2 + 4;
		obj9 = context;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22+2]");
		object obj10 = -30;
		if ((nint)obj10 < 0)
		{
			obj10 = 0;
		}
		else if ((nint)obj10 > 255)
		{
			obj10 = 255;
		}
		obj2 = context;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 16);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
	}
}
