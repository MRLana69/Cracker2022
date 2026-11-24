using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UI.VideoAdPrizes;
using UnityEngine;

public class HoverboardThemes
{
	public class HoverboardTheme
	{
		public int price;

		public PurchaseData.UnlockType unlockType;

		public Color32 buttonBgColor;

		public Color32 buttonIconColor;

		public bool isNewInThisUpdate;

		public string title;

		public UIOrder uiOrder;

		public Hoverboard.BoardAbility power;

		public ThemeIdentifier identifier;

		public string iconName;

		public string GetAnalyticsReadablePowerName()
		{
			//IL_0007: Expected Obj, but got I4
			return (string)unlockType;
		}
	}

	public enum UIOrder
	{
		First,
		Second
	}

	public enum ThemeIdentifier
	{
		none,
		heroboardTheme01,
		heroboardTheme02,
		starboardTheme01,
		starboardTheme02,
		greatWhiteTheme01,
		greatWhiteTheme02,
		surfboardTheme01,
		surfboardTheme02,
		monsterTheme1,
		monsterTheme2,
		snowboardTheme1,
		snowboardTheme2,
		miamiTheme1,
		miamiTheme2,
		skullfireTheme1,
		romeTheme01,
		skullfireTheme02,
		lumberjackTheme01,
		lumberjackTheme02,
		romeTheme02,
		londonBoard01Theme01,
		londonBoard01Theme02,
		chicky01Theme01,
		chicky01Theme02,
		veniceBoard02Theme01,
		transylvaniaBoard01Theme01,
		sanfranciscoBoard01Theme01,
		arabiaBoard01Theme01,
		bangkokBoard01Theme01,
		cairoBoard02Theme01,
		cairoBoard02Theme02,
		starterPackBoard01Theme01,
		starterPackBoard01Theme02,
		mumbaiBoard02Theme01,
		mumbaiBoard02Theme02,
		hongKongBoard01Theme01
	}

	public static readonly Dictionary<Boards.BoardId, List<HoverboardTheme>> hoverboardCustomThemes;

	public static string GetBoardPowerName(Boards.BoardId board, Hoverboard.BoardAbility power)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = default;
		obj = obj3;
		NullReferenceException ex = new NullReferenceException();
		bool flag = ex != null;
		return (string)flag;
	}

	public static int GetIndexForTheme(Boards.BoardId boardId, ThemeIdentifier themeIdentifier)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_04fa: Expected Obj, but got I4
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_052a: Expected I, but got Obj
		//IL_0540: Expected Obj, but got I
		//IL_0604: Expected Obj, but got I
		//IL_0614: Expected Obj, but got I
		//IL_0624: Expected Obj, but got I
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_0037: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_056b: Expected I4, but got Obj
		//IL_00c5: Expected I, but got Obj
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I4
		//IL_01a6: Expected I, but got Obj
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		Boards.BoardId boardId2 = default;
		obj3 = boardId2;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v150 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S2_v3+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v4+44]");
		object obj9 = 0;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v77 @ S3_v4 (should have been resolved before IL gen)");
		object obj12 = default;
		if ((nint)obj12 > -1)
		{
			nint num4 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v44 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num5 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v144 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<HoverboardTheme> list = hoverboardCustomThemes.get_Item((Boards.BoardId)obj3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj14 = default;
			int result = default;
			int num8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v121+24]");
					if ((nint)0 != (nint)themeIdentifier)
					{
						continue;
					}
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v130 (Il2CppClass<Strings>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num7 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v137 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj16 = obj5 + 4;
					object obj17 = obj16 + 1;
					obj16 = obj17;
					object obj18 = obj17 << 2;
					object obj19 = obj5 + obj18;
					obj19 = 168;
					result = num8;
					break;
				}
				object obj20 = obj5 + 4;
				object obj21 = obj20 + 1;
				obj20 = obj21;
				object obj22 = obj21 << 2;
				object obj23 = obj5 + obj22;
				obj23 = 88;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
				object obj24 = (nint)0 << 2;
				object obj25 = obj5 + obj24;
				if ((nint)obj25 == 168)
				{
					object obj26 = obj5 + 4;
					if ((nint)obj26 > -1)
					{
						object obj27 = obj26 + -1;
						obj26 = obj27;
					}
					return result;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+4]");
				object obj28 = (nint)0 << 2;
				object obj29 = obj5 + obj28;
				if ((nint)obj29 == 88)
				{
					object obj30 = obj5 + 4;
					if ((nint)obj30 > -1)
					{
						object obj31 = obj30 + -1;
						obj30 = obj31;
					}
					goto IL_069c;
				}
			}
			object obj32 = default;
			if (obj32 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_069c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
		IL_069c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public static ThemeIdentifier GetThemeIdentifier(Boards.BoardId bId, int tIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0359: Expected Obj, but got I4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v109 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<HoverboardTheme> list = hoverboardCustomThemes.get_Item(bId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		ThemeIdentifier result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v92+28]");
				if ((nint)0 == tIndex)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v92+20]");
					result = (ThemeIdentifier)((nint)0 + (nint)1);
					object obj7 = obj4 + 4;
					object obj8 = obj7 + 1;
					obj7 = obj8;
					object obj9 = obj8 << 2;
					object obj10 = obj4 + obj9;
					obj10 = 74;
					break;
				}
				continue;
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 72;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 74)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_044d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 72)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_044d;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_044d;
		IL_044d:
		return result;
	}

	public static List<HoverboardTheme> TryGetCustomThemesForBoard(Boards.BoardId boardId)
	{
		//IL_0094: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		object obj = boardId + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = boardId + 16;
			object obj4 = obj3 + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
			throw new ArrayTypeMismatchException();
		}
		List<HoverboardTheme> result = default;
		return result;
	}

	public static void VerifyData()
	{
		//IL_03b5: Expected I, but got Obj
		//IL_03cb: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_036a: Expected I, but got Obj
		//IL_0380: Expected Obj, but got I
		Globals.DEBUG = false;
		bool dEBUG = Globals.DEBUG;
		Globals.DEBUG_POPUP = dEBUG;
		Globals.BUILD_PURPOSE = Globals.BuildPurpose.UNDEFINED;
		Globals.DEFAULT_BUNDLES_VERSION = 1;
		Globals.DEBUG_SETTINGS = false;
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			Globals.DEBUG_POPUP_TESTOLOGY = false;
			Globals.DEBUG_USE_ONLINESETTINGS_TESTTIME = false;
			Globals.DEBUG_USE_ONLINESETTINGS_SET = false;
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v47 (Il2CppClass<Globals>)+5C]");
			object obj = (nint)0 + (nint)16;
			obj = "";
			Globals.DEBUG_FREE_PURCHASES = false;
			Globals.DEBUG_ALL_CHARS = false;
			Globals.DEBUG_ALL_BOARDS = false;
			Globals.DEBUG_DISPLAY_ALL_CHARS = false;
			Globals.DEBUG_DISPLAY_ALL_BOARDS = false;
			Globals.DEBUG_FREE_INAPP_PURCHASE = false;
			Globals.DEBUG_SKIP_VIDEO_ADS = false;
			Globals.DEBUG_DISABLE_HOVERBOARD = false;
			Globals.DEBUG_DISABLE_JETPACK = false;
			Globals.DEBUG_SKIP_TUTORIAL_IN_EDITOR = false;
			Globals.DEBUG_USE_DEBUG_LOGIN_STATE = false;
			Globals.DEBUG_USE_FAKE_ONLINE_SETTINGS = false;
			Globals.DEBUG_USE_FAKE_NEW_ONLINE_SETTINGS = false;
			Globals.DEBUG_OVERRIDE_ONLINE_SETTINGS_URL = false;
			Globals.DEBUG_OVERRIDE_NEW_ONLINE_SETTINGS_URL = false;
			Globals.DEBUG_USE_TEST_AD_CONSTANTS = false;
			Globals.DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER = false;
			Globals.DEBUG_INTERSTITIAL_PROVIDERS = false;
			if (~(Globals.DEBUG ? 1u : 0u) == 0)
			{
				goto IL_049b;
			}
		}
		Globals.DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			goto IL_0079;
		}
		goto IL_049b;
		IL_0163:
		Globals.DEBUG_VIDEOADS_PROVIDERS_YEAH_MOBI = false;
		Globals.DEBUG_USE_CELEBRATION_TESTER = false;
		Globals.DEBUG_USE_EVENT_TESTER = false;
		Globals.DEBUG_SHOW_PERFORMANCE_INFO = false;
		Globals.DEBUG_USE_TIMESCALE_PAUSE_BUTTON = false;
		Globals.DEBUG_ENABLE_SALES = false;
		nint num2 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S0_v378 (Il2CppClass<Globals>)+5C]");
		object obj2 = -(-64);
		obj2 = 0;
		Globals.DEBUG_ENABLE_NEW_YEAR_SALES = false;
		Globals.DEBUG_DISABLE_NOTIFICATION_REQUEST = false;
		Globals.DEBUG_TEST_FPS_SPIKES = false;
		Globals.DEBUG_USE_DEBUG_AD_PROVIDER = false;
		Globals.DEBUG_ENABLE_BOARD_BUNDLE = false;
		Globals.DEBUG_AD_SYSTEM_SINGLE_IMPRESSION = false;
		Globals.DEBUG_IGNORE_PROMOTION_EXPIRATION = false;
		Globals.DEBUG_FORCE_SPECIFIC_LOCALE = false;
		Globals.DEBUG_ENABLE_LOADING_DELAY = false;
		Globals.DEBUG_USE_DEBUG_LOGS_INSTEAD_OF_FLURRY = false;
		Globals.DEBUG_FACEBOOK_SESSION_WARNINGS = false;
		Globals.DEBUG_DEVICE_UTILITY_WARNINGS = false;
		Globals.DEBUG_STRINGS_CLASS_WARNINGS = false;
		Globals.DEBUG_SHADERS = false;
		Globals.DEBUG_CHARACTER_INVINCIBLE = false;
		Globals.DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS = false;
		Globals.DEBUG_LIMITED_CHARACTER_POPUP = false;
		Globals.DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE = false;
		Globals.DEBUG_LIMITED_BOARD_POPUP = false;
		Globals.DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE = false;
		Globals.DEBUG_FIRST_PURCHASE_BONUS = false;
		Globals.DEBUG_ENABLE_WELCOME_PACK = false;
		Globals.DEBUG_WELCOME_PACK_ABTEST_DEFAULT_PAYLOAD = 0;
		Globals.DEBUG_ENABLE_GET_2_KEYS = false;
		Globals.DEBUG_INTRO_VIDEO_AD_PRIZE_INDEX = -1;
		Globals.DEBUG_RANDOM_VIDEO_AD_PRIZE_INDEX = -1;
		Globals.DEBUG_RANDOM_VIDEO_AD_PRIZE_SEED = -1;
		Globals.DEBUG_VIDEO_AD_PRIZE_TYPE = VideoAdPrizeType.NotSet;
		Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___SUPER_MYSTERY_BOX = false;
		Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___MYSTERY_POWER_UP = false;
		Globals.DEBUG_USE_ENABLE_SS_EVENT_TYPE___LETTER_HUNT_CHARACTER = false;
		Globals.DEBUG_SKIP_DAILY_LETTERS = false;
		Globals.DEBUG_USE_ENABLE_PLAYER_INFO___IS_ACTIVE_DAILY_LETTER_EVENT = false;
		Globals.DEBUG_USE_ENABLE_PLAYER_INFO___HAS_DAILY_WORD_TIME_LEFT = false;
		Globals.DEBUG_USE_DEBUG_DAILYWORD = false;
		Globals.DEBUG_IS_HOVERBOARD_ALWAYS_REWARDED_FOR_MYSERY_POWERUP = false;
		Globals.debugLimitedCharacterPopupId = Characters.CharacterId.slick;
		Globals.debugLimitedBoardPopupId = Boards.BoardId.normal;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S0_v611 (Il2CppClass<Globals>)+5C]");
		object obj3 = (nint)0 + (nint)128;
		object obj4 = default;
		obj3 = obj4;
		return;
		IL_0549:
		Globals.DEBUG_VIDEOADS_PROVIDERS_MOBVISTA = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			/*Error: End of method reached without returning.*/;
		}
		goto IL_0163;
		IL_049b:
		Globals.DEBUG_INTERSTITIAL_PROVIDER_INMOBI = false;
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			goto IL_0079;
		}
		goto IL_04b8;
		IL_0079:
		Globals.DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			goto IL_0096;
		}
		goto IL_04b8;
		IL_04b8:
		Globals.DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK = false;
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			goto IL_0096;
		}
		goto IL_04d5;
		IL_0096:
		Globals.DEBUG_INTERSTITIAL_PROVIDER_YEAHMOBI = false;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD = false;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT = false;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT = false;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES = false;
		Globals.DEBUG_INTERSTITIAL_IN_EDITOR = false;
		Globals.DEBUG_VIDEOADS_PROVIDERS = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			goto IL_00ef;
		}
		goto IL_04d5;
		IL_04d5:
		Globals.DEBUG_VIDEOADS_PROVIDERS_ADCOLONY = false;
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			goto IL_00ef;
		}
		goto IL_04f2;
		IL_00ef:
		Globals.DEBUG_VIDEOADS_PROVIDERS_FLURRY = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			goto IL_010c;
		}
		goto IL_04f2;
		IL_04f2:
		Globals.DEBUG_VIDEOADS_PROVIDERS_VUNGLE = false;
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			goto IL_010c;
		}
		goto IL_050f;
		IL_010c:
		Globals.DEBUG_VIDEOADS_PROVIDERS_TAPJOY = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			goto IL_0129;
		}
		goto IL_050f;
		IL_050f:
		Globals.DEBUG_VIDEOADS_PROVIDERS_INMOBI = false;
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			goto IL_0129;
		}
		goto IL_052c;
		IL_0129:
		Globals.DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			goto IL_0146;
		}
		goto IL_052c;
		IL_052c:
		Globals.DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC = false;
		if (~(Globals.DEBUG ? 1u : 0u) != 0)
		{
			goto IL_0146;
		}
		goto IL_0549;
		IL_0146:
		Globals.DEBUG_VIDEOADS_PROVIDERS_FACEBOOK = false;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			goto IL_0163;
		}
		goto IL_0549;
	}

	private static void ValidateUIOrder(KeyValuePair<Boards.BoardId, List<HoverboardTheme>> themeSet)
	{
	}

	public unsafe HoverboardThemes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_037d: Expected Obj, but got I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03ad: Expected I, but got Obj
		//IL_03c3: Expected Obj, but got I
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected I, but got Unknown
		//IL_04be: Expected I, but got Obj
		//IL_04d9: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v149 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(UIOrder);
		nint num3 = (nint)(obj2 + 32);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type enumType = Type.internal_from_handle((IntPtr)num3);
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v17 (Il2CppClass<System.Enum>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v85 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ulong[] source = Enum.InternalGetValues((System.RuntimeType)enumType);
		IEnumerable<UIOrder> source2 = Enumerable.Cast<UIOrder>(source);
		List<UIOrder> list = Enumerable.ToList(source2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = (object)((IntPtr*)num3)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26 (System.IntPtr)+8]");
		_ = 0;
		object obj7 = default;
		object obj8 = default;
		void* value = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			((IntPtr*)num3)->m_value = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj9 = obj4 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj4 + obj11;
		obj12 = 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj4 + obj13;
			if ((nint)obj14 == 136)
			{
				object obj15 = obj4 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				return;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static HoverboardThemes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02b0: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02e6: Expected I, but got Obj
		//IL_02fc: Expected Obj, but got I
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v101 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26+10]");
		_ = 0;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num3 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v83 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v94 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj6 = obj2;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj10 = obj4 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj4 + obj12;
		obj13 = 50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj4 + obj14;
			if ((nint)obj15 == 50)
			{
				object obj16 = obj4 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				return;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
