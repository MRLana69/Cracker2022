using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Missions;
using UnityEngine;

public class GlobalColors
{
	public const int COLOR_BUTTON_PRESSED_OFFSET = 30;

	public static readonly Color32 AWARDS_NEW_STICKER_COLOR;

	public static readonly Color32 AWARDS_COLLECTIBLE_STICKER_COLOR;

	public static readonly Color32 TOP_RUN_STICKER_COLOR;

	public static readonly Color32 DISCOUNT_BUTTON_DESCRIPTION2_COLOR;

	public static readonly Color32 DISCOUNT_BUTTON_DESCRIPTION2_SHADOW_COLOR;

	public static readonly Color32 DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_COLOR;

	public static readonly Color32 DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR;

	public static readonly Color32 DISCOUNT_BUTTON_LINE_THROUGH_COLOR;

	public static readonly Color32 DISCOUNT_BUTTON_LINE_THROUGH_SHADOW_COLOR;

	public static readonly Color32 GIFT_COLOR;

	public static readonly Color32 GIFT_LABEL_COLOR;

	public static readonly Color32 FOOTER_ME_COLOR;

	private static readonly Color32 FOOTER_ME_COLOR_LIGHT;

	private static readonly Color32 FOOTER_ME_COLOR_SELECTED;

	public static readonly Color32 FOOTER_SHOP_COLOR;

	private static readonly Color32 FOOTER_SHOP_COLOR_LIGHT;

	private static readonly Color32 FOOTER_SHOP_COLOR_SELECTED;

	public static readonly Color32 FOOTER_SOCIAL_COLOR;

	private static readonly Color32 FOOTER_SOCIAL_COLOR_LIGHT;

	private static readonly Color32 FOOTER_SOCIAL_COLOR_SELECTED;

	public static readonly Color32 FOOTER_BACK_COLOR;

	private static readonly Color32 FOOTER_BACK_COLOR_LIGHT;

	public static readonly Color32 FOOTER_BIG_PLAY_RESUME_COLOR;

	public static readonly Color32 FOOTER_BIG_WAIT_COLOR;

	public static readonly Color32 EVENTS_POPUP_SPLASH_COLOR;

	public static readonly Color32 EVENTS_POPUP_DESCRIPTION_BOX_JACKPOT_EVENT_COLOR;

	public static readonly Color32 EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR;

	public static readonly Color32 EVENTS_POPUP_GLOW_DEFAULT_COLOR;

	public static readonly Color32 EVENTS_POPUP_GLOW_JACKPOT_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_CONTENT_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR;

	public static readonly Color32 INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;

	public static readonly Color32 INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;

	public static readonly Color32 ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR;

	public static readonly Color32 ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR;

	public static readonly Color32 ACTIVE_HEADSTART_GEAR_BACKGROUND_COLOR;

	public static readonly Color32 ACTIVE_HEADSTART_GEAR_COUNT_COLOR;

	public static readonly Color32 ACTIVE_SCOREBOOSTER_GEAR_BACKGROUND_COLOR;

	public static readonly Color32 ACTIVE_SCOREBOOSTER_GEAR_COUNT_COLOR;

	public static readonly Color32 INACTIVE_GEAR_BACKGROUND_COLOR;

	public static readonly Color32 INACTIVE_GEAR_COUNT_COLOR;

	public static readonly Color32 INITIAL_GEAR_GLOW_COLOR;

	public static readonly Color32 FINAL_GEAR_GLOW_COLOR;

	public static readonly Color32 INITIAL_HEADSTART_BUTTON_GLOW_COLOR;

	public static readonly Color32 FINAL_HEADSTART_BUTTON_GLOW_COLOR;

	public static readonly Color32 PRIMARY_ACTION_COLOR;

	private static readonly Color32 PRIMARY_ACTION_COLOR_LIGHT;

	private static readonly Color32 PRIMARY_ACTION_COLOR_SELECTED;

	public static readonly Color32 PRIMARY_ACTION_COLOR_UNAVAILABLE;

	public static readonly Color32 COLOR_WHITE;

	public static readonly Color32 COLOR_PRESSED;

	public static readonly Color32 SECONDARY_ACTION_COLOR;

	private static readonly Color32 SECONDARY_ACTION_COLOR_LIGHT;

	public static readonly Color32 TERTIARY_ACTION_COLOR;

	private static readonly Color32 TERTIARY_ACTION_COLOR_LIGHT;

	private static readonly Color32 TERTIARY_ACTION_COLOR_SELECTED;

	public static readonly Color32 TERTIARY_ACTION_COLOR_UNAVAILABLE;

	public static readonly Color32 EXIT_COLOR;

	private static readonly Color32 EXIT_COLOR_LIGHT;

	public static readonly Color32 SEASONAL_COLOR_FILL_NORMAL;

	public static readonly Color32 SEASONAL_COLOR_FILL_LIGHT;

	public static readonly Color32 FACEBOOK_COLOR;

	private static readonly Color32 FACEBOOK_COLOR_LIGHT;

	public static readonly Color32 SOCIAL_GREY;

	private static readonly Color32 SOCIAL_GRAY_OVERLAY;

	public static readonly Color32 WEEKLYHUNT_CELEBRATION_TEXT_COLOR_STRIPED_BACKGROUND;

	public static readonly Color32 WEEKLYHUNT_STRIPE_COLOR;

	public static readonly Color32 WEEKLYHUNT_CELEBRATION_TEXT_COLOR;

	public static readonly Color32 WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BASE_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BASE_SKIN_ICON;

	public static readonly Color32 HOVERBOARD_CUSTOMIZATION_BASE_SKIN_FILL;

	public static readonly Color32 HOVERBOARD_CUSTOMIZATION_BASE_SKIN_ICON;

	public static readonly Color32 HOVERBOARD_THEME_HERO_SUPER_JUMP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_HERO_SUPER_JUMP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_HERO_TELEPORT_FILL;

	public static readonly Color32 HOVERBOARD_THEME_HERO_TELEPORT_ICON;

	public static readonly Color32 HOVERBOARD_THEME_STARBOARD_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_STARBOARD_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_STARBOARD_DOUBLE_JUMP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_STARBOARD_DOUBLE_JUMP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_GREAT_WHITE_SPEEDUP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_GREAT_WHITE_SPEEDUP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_GREAT_WHITE_GLIDER_FILL;

	public static readonly Color32 HOVERBOARD_THEME_GREAT_WHITE_GLIDER_ICON;

	public static readonly Color32 HOVERBOARD_THEME_SURF_BOARD_LOWRIDER_FILL;

	public static readonly Color32 HOVERBOARD_THEME_SURF_BOARD_LOWRIDER_ICON;

	public static readonly Color32 HOVERBOARD_THEME_SURF_BOARD_GLIDER_FILL;

	public static readonly Color32 HOVERBOARD_THEME_SURF_BOARD_GLIDER_ICON;

	public static readonly Color32 HOVERBOARD_THEME_MONSTER_SPEEDUP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_MONSTER_SPEEDUP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_MONSTER_JUMPER_FILL;

	public static readonly Color32 HOVERBOARD_THEME_MONSTER_JUMPER_ICON;

	public static readonly Color32 HOVERBOARD_THEME_FREESTYLER_DOUBLE_JUMP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_FREESTYLER_DOUBLE_JUMP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_FREESTYLER_SUPER_JUMP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_FREESTYLER_SUPER_JUMP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_MIAMI_PINK_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_MIAMI_PINK_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_MIAMI_SMOOTHDRIFT_FILL;

	public static readonly Color32 HOVERBOARD_THEME_MIAMI_SMOOTHDRIFT_ICON;

	public static readonly Color32 HOVERBOARD_THEME_SKULLFIRE_DOUBLE_JUMP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_SKULLFIRE_DOUBLE_JUMP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_SKULLFIRE_SPEEDUP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_SKULLFIRE_SPEEDUP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_FILL;

	public static readonly Color32 HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_ICON;

	public static readonly Color32 HOVERBOARD_THEME_ROME_SPEEDUP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_ROME_SPEEDUP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_LUMBERJACK_DOUBLE_JUMP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_LUMBERJACK_DOUBLE_JUMP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_LUMBERJACK_LOWRIDER_FILL;

	public static readonly Color32 HOVERBOARD_THEME_LUMBERJACK_LOWRIDER_ICON;

	public static readonly Color32 HOVERBOARD_THEME_LONDONBOARD01_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_LONDONBOARD01_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_LONDONBOARD01_SUPER_JUMP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_LONDONBOARD01_SUPER_JUMP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_CHICK_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_CHICK_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_CHICK_SPEEDUP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_CHICK_SPEEDUP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_VENICEBOARD02_GLIDER_FILL;

	public static readonly Color32 HOVERBOARD_THEME_VENICEBOARD02_GLIDER_ICON;

	public static readonly Color32 HOVERBOARD_THEME_SANFRANCISCOBOARD01_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_SANFRANCISCOBOARD01_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_HONGKONG_GLIDE_FILL;

	public static readonly Color32 HOVERBOARD_THEME_HONGKONG_GLIDE_ICON;

	public static readonly Color32 HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_ARABIABOARD01_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_ARABIABOARD01_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_CAIROBOARD02_SPEEDUP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_CAIROBOARD02_SPEEDUP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_CAIROBOARD02_GLIDER_FILL;

	public static readonly Color32 HOVERBOARD_THEME_CAIROBOARD02_GLIDER_ICON;

	public static readonly Color32 HOVERBOARD_THEME_MUMBAIBOARD02_SPEEDUP_FILL;

	public static readonly Color32 HOVERBOARD_THEME_MUMBAIBOARD02_SPEEDUP_ICON;

	public static readonly Color32 HOVERBOARD_THEME_MUMBAIBOARD02_ZAPSIDEWAYS_FILL;

	public static readonly Color32 HOVERBOARD_THEME_MUMBAIBOARD02_ZAPSIDEWAYS_ICON;

	public static readonly Color32 HOVERBOARD_THEME_STARTER_PACK_BOARD_01_MUSIC_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_STARTER_PACK_BOARD_01_MUSIC_TRAIL_FILL;

	public static readonly Color32 EVENTS_POPUP_STRIPES_JACKPOT;

	public static readonly Color32 EVENTS_POPUP_STRIPES_NORMAL;

	public static readonly Color32 COINS_ORIGINAL_COLOR;

	public static readonly Color32 COINS_LIGHT_PURPLE;

	public static readonly Color32 COINS_DARK_PURPLE;

	public static readonly Color32 MULTIPLIER_LIGHT_PURPLE;

	public static readonly Color32 MULTIPLIER_DARK_PURPLE;

	public static readonly Color32 COUNTRY_POPUP_TITLE_COLOUR;

	public static readonly Color32 COUNTRY_POPUP_SUBTITLE_COLOUR;

	public static readonly Color32 COUNTRY_POPUP_INFO_TEXT_COLOUR;

	public static readonly Color32 COUNTRY_POPUP_NORMAL_CELL_TEXT_COLOUR;

	public static readonly Color32 COUNTRY_POPUP_SELECTED_CELL_TEXT_COLOUR;

	public static readonly Color32 TOPRUN_ME_PLAYER_BACKGROUND_COLOUR;

	public static readonly Color32 TOPRUN_NORMAL_PLAYER_TEXT_COLOUR;

	public static readonly Color32 TOPRUN_SCREEN_TITLE_COLOUR;

	public static readonly Color32 TOPRUN_COUNTRY_NAME_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_TEXT_COLOUR;

	public static readonly Color32 TOPRUN_POPUP_TEXT_BACKGROUND_PURPLE;

	public static readonly Color32 TOPRUN_POPUP_DIAMOND_BACKGROUND;

	public static readonly Color32 TOPRUN_POPUP_GOLD_BACKGROUND;

	public static readonly Color32 TOPRUN_POPUP_SILVER_BACKGROUND;

	public static readonly Color32 TOPRUN_POPUP_BRONZE_BACKGROUND;

	public static readonly Color32 TOPRUN_RANK_HEADER_00_BACKGROUND_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_00_TITLE_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_00_TITLE_SHADOW_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_00_LIGHT_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_10_BACKGROUND_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_10_TITLE_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_10_TITLE_SHADOW_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_10_LIGHT_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_20_BACKGROUND_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_20_TITLE_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_20_TITLE_SHADOW_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_20_LIGHT_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_30_BACKGROUND_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_30_TITLE_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_30_TITLE_SHADOW_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_30_LIGHT_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_40_BACKGROUND_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_40_TITLE_COLOUR;

	public static readonly Color32 TOPRUN_RANK_HEADER_40_TITLE_SHADOW_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR;

	public static readonly Color32 TOPRUN_PLAYER_BACKGOURD_40_LIGHT_COLOUR;

	public static readonly Color32 CHARACTERWORDEVENT_CELEBRATION_BLUE;

	public static readonly Color32 CHARACTERWORDEVENT_CELEBRATION_WHITE;

	public static readonly Color32 CHARACTERWORDEVENT_CELEBRATION_BLUESHADOW;

	public static readonly Color32 CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW;

	public static readonly Color32 CHARACTERWORDEVENT_POPUP_NAME_ACTIVE;

	public static readonly Color32 CHARACTERWORDEVENT_POPUP_NAME_INACTIVE;

	public static readonly Color32 CHARACTERWORDEVENT_POPUP_NAME_SHADOW_ACTIVE;

	public static readonly Color32 CHARACTERWORDEVENT_POPUP_NAME_SHADOW_INACTIVE;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_TITLE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_TITLE_COLOR_SHADOW;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_ACTIVE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_INACTIVE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_PRICE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_PRICE_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LIMITED_TIME_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LIMITED_TIME_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION2_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_DESCRIPTION2_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LINE_THROUGH_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_BUTTON_LINE_THROUGH_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_STICKER_LABEL_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_WINTER_HOLIDAY_STICKER_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_TITLE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_TITLE_COLOR_SHADOW;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_ACTIVE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_INACTIVE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_PRICE_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_PRICE_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LIMITED_TIME_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LIMITED_TIME_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION2_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_DESCRIPTION2_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LINE_THROUGH_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_BUTTON_LINE_THROUGH_SHADOW_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_STICKER_COLOR;

	public static readonly Color32 SPECIAL_DISCOUNT_NEW_YEAR_STICKER_LABEL_COLOR;

	public static readonly Color32 FIRST_PURCHASE_BONUS_BREADCRUMP_BUBBLE_COLOR;

	public static readonly Dictionary<UIButtonOverlayOff.ButtonType, ButtonColorScheme> buttonColorData;

	public static Color ApplyButtonPressColorOffset(Color32 col)
	{
		//IL_0164: Expected Obj, but got I4
		//IL_0164: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_009e: Expected I4, but got VT
		//IL_009e: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected VT, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		Color result = default;
		if (MissionsManager.IsOneOf((MissionTarget)instance, (MissionTarget[])66))
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v6+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 > -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Color)+98]");
				if (!((Dictionary<UpgradeType, bool>)0).get_Item((UpgradeType)col))
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v5 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v6+60]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v7+48]");
					result = (Color)0;
					object obj9 = result.r & 0x7FF;
					object obj10 = obj9 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S5_v5 (should have been resolved before IL gen)");
					StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
					((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)66, (PersistentAwardProgress)1, (Action<Award>)(-1));
				}
			}
		}
		return result;
	}

	public unsafe static ButtonColorScheme GetButtonColorScheme(UIButtonOverlayOff.ButtonType buttonType, GameObject gameObject)
	{
		//IL_001e: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		ref int reference = ref *(int*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [gameObject @ L2 (UIButtonOverlayOff+ButtonType)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (ButtonColorScheme)+88]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+8]");
		bool flag = ((Dictionary<int, int>)num).TryGetValue(0, out reference);
		object obj2 = reference + 1;
		reference = ref *(int*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [gameObject @ L2 (UIButtonOverlayOff+ButtonType)+C]");
		object obj3 = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v3+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v4+48]");
		object obj6 = 0;
		object obj7 = obj6 & 0x7FF;
		object obj8 = obj7 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S5_v4 (should have been resolved before IL gen)");
		ButtonColorScheme result = default;
		return result;
	}

	public GlobalColors()
	{
		//IL_020e: Expected I, but got Obj
		//IL_0224: Expected Obj, but got I
		//IL_0339: Expected I, but got Obj
		//IL_034f: Expected Obj, but got I
		//IL_0639: Expected Obj, but got I4
		//IL_024f: Expected I, but got Obj
		//IL_0424: Expected I, but got Obj
		//IL_043a: Expected Obj, but got I
		//IL_037a: Expected I, but got Obj
		//IL_029c: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_0734: Expected Obj, but got I4
		//IL_04c0: Expected I, but got Obj
		//IL_04d6: Expected Obj, but got I
		//IL_0465: Expected I, but got Obj
		//IL_02dd: Expected I, but got Obj
		//IL_0763: Expected Obj, but got I4
		//IL_0501: Expected I, but got Obj
		bool shouldShowCollectPopup = OnboardingSave.shouldShowCollectPopup;
		bool shouldShowCollectPopup2 = (byte)((shouldShowCollectPopup ? 1u : 0u) + 1u) != 0;
		OnboardingSave.shouldShowCollectPopup = shouldShowCollectPopup2;
		int currentOutfitIndex = PlayerSave.currentOutfitIndex;
		int currentOutfitIndex2 = currentOutfitIndex + 1;
		PlayerSave.currentOutfitIndex = currentOutfitIndex2;
		int currentMissionSet = PlayerSave.currentMissionSet;
		if (currentMissionSet != -1)
		{
			int currentMissionSet2 = PlayerSave.currentMissionSet;
			int currentMissionSet3 = currentMissionSet2 + 1;
			PlayerSave.currentMissionSet = currentMissionSet3;
		}
		bool shouldShowCollectPopup3 = OnboardingSave.shouldShowCollectPopup;
		if ((shouldShowCollectPopup3 ? 1 : 0) <= 4)
		{
			return;
		}
		OnboardingSave.shouldShowCollectPopup = false;
		if (!OnboardingSave.hasShownMissionIntroPopup && OnboardingSave.shouldShowMissionIntroPopup)
		{
			return;
		}
		if (!OnboardingSave.hasShownMissionIntroPopup)
		{
			CollectCoinsDummy[] defaultDummyList = CollectCoinsDummyData.GetDefaultDummyList();
			if (((GameStats)(object)defaultDummyList).CoinsSpawned != 0)
			{
				int tier = InventorySave.GetTier(UpgradeType.hoverboard);
				CollectCoinsDummy[] defaultDummyList2 = CollectCoinsDummyData.GetDefaultDummyList();
				int coinsSpawned = ((GameStats)(object)defaultDummyList2).CoinsSpawned;
				object obj = 3 - coinsSpawned;
				if (tier != (nint)obj)
				{
					OnboardingSave.hasShownMissionIntroPopup = true;
					OnboardingSave.shouldShowMissionIntroPopup = false;
					goto IL_05cd;
				}
			}
			OnboardingSave.shouldShowMissionIntroPopup = true;
			OnboardingSave.shouldShowHoverboardPopup = false;
			OnboardingSave.shouldShowFacebookPopup = false;
			OnboardingSave.shouldShowEndGameMissionPopup = false;
			OnboardingSave.lastShownTopRunIntroPopupVersionNumber = 0;
			return;
		}
		goto IL_05cd;
		IL_05cd:
		if (!OnboardingSave.hasShownHoverboardPopup)
		{
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v91 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v112 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			if (!((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
			{
				nint num3 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v100 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v108 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!UserSave.allAssetBundlesDownloaded)
				{
					OnboardingSave.shouldShowHoverboardPopup = true;
					return;
				}
			}
		}
		if (!OnboardingSave.hasShownEndGameMissionPopup)
		{
			nint num5 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v76 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v86 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
			if ((allowSellConsumablesDuringRun ? 1 : 0) <= 4)
			{
				OnboardingSave.shouldShowEndGameMissionPopup = true;
				return;
			}
			OnboardingSave.hasShownEndGameMissionPopup = true;
			OnboardingSave.shouldShowEndGameMissionPopup = false;
		}
		if (OnboardingSave.hasShownFacebookPopup)
		{
			return;
		}
		bool shouldShowFacebookPopup;
		if (OnboardingSave.hasShownCollectPopup)
		{
			shouldShowFacebookPopup = false;
		}
		else
		{
			nint num7 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v50 (Il2CppClass<SocialManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v70 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			if (((SocialManager)facebookDialogsSupported2).HasFacebookAccessToken())
			{
				shouldShowFacebookPopup = true;
			}
			else
			{
				nint num9 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v58 (Il2CppClass<SocialManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num10 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v65 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
				shouldShowFacebookPopup = ((SocialManager)facebookDialogsSupported3).gamecenterIsLoggedOut;
			}
		}
		OnboardingSave.shouldShowFacebookPopup = shouldShowFacebookPopup;
		if (!OnboardingSave.shouldShowFacebookPopup && OnboardingSave.hasShownCollectPopup)
		{
			OnboardingSave.hasShownFacebookPopup = true;
			OnboardingSave.shouldShowFacebookPopup = false;
		}
	}

	static GlobalColors()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I4
		//IL_0056: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_0078: Unsupported input type for neg.
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected F4, but got Unknown
		HouseKeeper.waitForCloudSave = false;
		HouseKeeper._onlineServicesInitialized = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v21 (Il2CppClass<HouseKeeper>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = obj2;
		object obj4 = default;
		float onlineSettingsLastDownloadTime = 0 - obj4;
		HouseKeeper._onlineSettingsLastDownloadTime = onlineSettingsLastDownloadTime;
	}
}
