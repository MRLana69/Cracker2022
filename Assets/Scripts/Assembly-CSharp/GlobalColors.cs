using System;
using System.Collections.Generic;
using Cpp2ILInjected;
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

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_TITLE_COINS;

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS;

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS;

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS;

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_TITLE_KEYS;

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_KEYS;

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_DESCRIPTION_KEYS;

	public static readonly Color32 WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_KEYS;

	public static readonly Color32 GIFT_COLOR;

	public static readonly Color32 GIFT_LABEL_COLOR;

	public static readonly Color32 EXPIRE_TIME_COUNTER_TRY_NOT_SELECTED;

	public static readonly Color32 EXPIRE_TIME_COUNTER_TRY_SELECTED;

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

	public static readonly Color32 EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR;

	public static readonly Color32 EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_DESCRIPTION_COLOR;

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

	public static readonly Color32 HOVERBOARD_CUSTOMIZATION_POPUP_BASE_BOARD_CONTAINER_COLOR;

	public static readonly Color32 HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR_LIGHT;

	public static readonly Color32 HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR;

	public static readonly Color32 HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR;

	public static readonly Color32 FACEBOOK_COLOR;

	private static readonly Color32 FACEBOOK_COLOR_LIGHT;

	public static readonly Color32 GAMECENTER_COLOR;

	private static readonly Color32 GAMECENTER_COLOR_LIGHT;

	public static readonly Color32 SOCIAL_GREY;

	private static readonly Color32 SOCIAL_GRAY_OVERLAY;

	public static readonly Color32 WEEKLYHUNT_COLOR_TOPTITLE;

	public static readonly Color32 WEEKLYHUNT_COLOR_TOPSUBTITLE;

	public static readonly Color32 WEEKLYHUNT_COLOR_BOTTITLE;

	public static readonly Color32 WEEKLYHUNT_COLOR_BOTSUBTITLE;

	public static readonly Color32 WEEKLYHUNT_CELEBRATION_TEXT_COLOR_STRIPED_BACKGROUND;

	public static readonly Color32 WEEKLYHUNT_CELEBRATION_TEXT_COLOR;

	public static readonly Color32 WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BASE_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BASE_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRICKY_ARMY_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRICKY_ARMY_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRICKY_COOL_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRICKY_COOL_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_JAKE_KID_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_JAKE_KID_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_JAKE_DARK_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_JAKE_DARK_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TAGBOT_RED_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TAGBOT_RED_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TAGBOT_R2D2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TAGBOT_R2D2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SPIKE_DARK_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SPIKE_DARK_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SPIKE_STAR_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SPIKE_STAR_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRESH_BASKET_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRESH_BASKET_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRESH_SMOOTH_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRESH_SMOOTH_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LUCY_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LUCY_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LUCY_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LUCY_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRANK_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRANK_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRANK_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRANK_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KING_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KING_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KING_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KING_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRIZZY_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRIZZY_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRIZZY_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_FRIZZY_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TASHA_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TASHA_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TASHA_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TASHA_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NICK_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NICK_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NICK_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NICK_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MINA_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MINA_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MINA_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MINA_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BRODY_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BRODY_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BRODY_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BRODY_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TONY_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TONY_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TONY_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TONY_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ROSA_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ROSA_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ROBERTO_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ROBERTO_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ZOE_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ZOE_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ZOE_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ZOE_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_VANCOUVER1_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_VANCOUVER1_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PRINCEK_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PRINCEK_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PRINCEK_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PRINCEK_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SAOPAULO_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SAOPAULO_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SUN_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SUN_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_CAIRO_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_CAIRO_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HARUMI_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HARUMI_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HARUMI_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HARUMI_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NINJA_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NINJA_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NINJA_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NINJA_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_COCO_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_COCO_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_COCO_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_COCO_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NEW_ORLEANS_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_NEW_ORLEANS_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BANGKOK_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BANGKOK_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BANGKOK_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_BANGKOK_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MUMBAI_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MUMBAI_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_CARMEN_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_CARMEN_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_CARMEN_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_CARMEN_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KIM_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KIM_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KIM_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KIM_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_GREECE_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_GREECE_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KENYA_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_KENYA_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PRAGUE_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PRAGUE_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MADAGASCAR_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MADAGASCAR_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME2_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME2_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SINGAPORE_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SINGAPORE_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ICELAND_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ICELAND_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HAVANA_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HAVANA_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_WASHINGTON_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_WASHINGTON_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HOLIDAY_CHARACTER_2016_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_HOLIDAY_CHARACTER_2016_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ELFTRICKY_CHARACTER_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_ELFTRICKY_CHARACTER_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_AMSTERDAM_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_AMSTERDAM_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MONACO_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MONACO_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_COPENHAGEN_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_COPENHAGEN_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MARRAKESH_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_MARRAKESH_CHARACTER_01_THEME1_SKIN_ICON;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SHANGHAI_CHARACTER_01_THEME1_SKIN_FILL;

	public static readonly Color32 CHARACTERS_CUSTOMIZATION_SHANGHAI_CHARACTER_01_THEME1_SKIN_ICON;

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

	public static readonly Color32 HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_ICON;

	public static readonly Color32 HOVERBOARD_THEME_ARABIABOARD01_TRAIL_FILL;

	public static readonly Color32 HOVERBOARD_THEME_ARABIABOARD01_TRAIL_ICON;

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

	public static readonly Color32 COUNTRY_POPUO_NORMAL_CELL_TEXT_COLOUR;

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

	public static readonly Color32 WELCOMEPOPUP_BUBBLE_COLOR;

	public static readonly Color32 WELCOMEPOPUP_BUBBLE_TEXT_COLOR;

	public static Color32 EXCLUSIVE_HALLOWEEN_BACKGROUND_COLOR;

	public static Color32 EXCLUSIVE_HALLOWEEN_LABEL_COLOR;

	public static readonly Dictionary<UIButtonOverlayOff.ButtonType, ButtonColorScheme> buttonColorData;

	public unsafe static ButtonColorScheme GetButtonColorScheme(UIButtonOverlayOff.ButtonType buttonType, GameObject gameObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00da: Expected VT, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_00ef: Expected VT, but got I
		//IL_00ea: Expected native int or pointer, but got VT
		//IL_0104: Expected VT, but got I
		//IL_00ff: Expected native int or pointer, but got VT
		//IL_0119: Expected VT, but got I
		//IL_0114: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + -64;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UIButtonOverlayOff+ButtonType, ButtonColorScheme>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 != null)
		{
			object obj7 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B2E8");
		}
		else
		{
			Enum obj8 = (Enum)(obj + 8);
			_ = -1;
			obj8 = (Enum)(object)typeof(UIButtonOverlayOff.ButtonType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			_ = 0;
			string text = obj8.ToString();
			string name = gameObject.name;
			string text2 = "No color scheme for button type: " + text + ". GameObject: " + name;
			object obj9 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B2E8");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		ButtonColorScheme buttonColorScheme = default;
		((ButtonColorScheme*)(nint)buttonColorScheme)->original = (Color32?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		((ButtonColorScheme*)(nint)buttonColorScheme)->unavailable = (Color32?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		((ButtonColorScheme*)(nint)buttonColorScheme)->selected = (Color32?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		((ButtonColorScheme*)(nint)buttonColorScheme)->light = (Color32?)(object)0;
		return buttonColorScheme;
	}

	unsafe static GlobalColors()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_2602: Unknown result type (might be due to invalid IL or missing references)
		//IL_2607: Expected Obj, but got Unknown
		//IL_2610: Expected Obj, but got I4
		//IL_2619: Unknown result type (might be due to invalid IL or missing references)
		//IL_261e: Expected Obj, but got Unknown
		//IL_2627: Expected Obj, but got I4
		//IL_2630: Unknown result type (might be due to invalid IL or missing references)
		//IL_2635: Expected Obj, but got Unknown
		//IL_263e: Expected Obj, but got I4
		//IL_264e: Expected VT, but got I4
		//IL_2658: Expected VT, but got I4
		//IL_2662: Expected VT, but got I4
		//IL_26a8: Expected VT, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00d9: Expected VT, but got Obj
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01c1: Expected VT, but got Obj
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_02a9: Expected VT, but got Obj
		//IL_02e4: Expected VT, but got I4
		//IL_02ee: Expected VT, but got I4
		//IL_02f8: Expected VT, but got I4
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03d7: Expected VT, but got Obj
		//IL_03ea: Expected VT, but got I4
		//IL_03f4: Expected VT, but got I4
		//IL_03fe: Expected VT, but got I4
		//IL_0408: Expected VT, but got I4
		//IL_0412: Expected VT, but got I4
		//IL_041c: Expected VT, but got I4
		//IL_0426: Expected VT, but got I4
		//IL_0430: Expected VT, but got I4
		//IL_043a: Expected VT, but got I4
		//IL_0444: Expected VT, but got I4
		//IL_044e: Expected VT, but got I4
		//IL_0458: Expected VT, but got I4
		//IL_0462: Expected VT, but got I4
		//IL_046c: Expected VT, but got I4
		//IL_0476: Expected VT, but got I4
		//IL_0480: Expected VT, but got I4
		//IL_048a: Expected VT, but got I4
		//IL_0494: Expected VT, but got I4
		//IL_049e: Expected VT, but got I4
		//IL_04a8: Expected VT, but got I4
		//IL_04b2: Expected VT, but got I4
		//IL_04bc: Expected VT, but got I4
		//IL_04c6: Expected VT, but got I4
		//IL_04d0: Expected VT, but got I4
		//IL_04da: Expected VT, but got I4
		//IL_04e4: Expected VT, but got I4
		//IL_04ee: Expected VT, but got I4
		//IL_04f8: Expected VT, but got I4
		//IL_0502: Expected VT, but got I4
		//IL_050c: Expected VT, but got I4
		//IL_0516: Expected VT, but got I4
		//IL_0520: Expected VT, but got I4
		//IL_052a: Expected VT, but got I4
		//IL_0534: Expected VT, but got I4
		//IL_053e: Expected VT, but got I4
		//IL_0548: Expected VT, but got I4
		//IL_0552: Expected VT, but got I4
		//IL_055c: Expected VT, but got I4
		//IL_0566: Expected VT, but got I4
		//IL_0570: Expected VT, but got I4
		//IL_057a: Expected VT, but got I4
		//IL_0584: Expected VT, but got I4
		//IL_058e: Expected VT, but got I4
		//IL_0598: Expected VT, but got I4
		//IL_05a2: Expected VT, but got I4
		//IL_05ac: Expected VT, but got I4
		//IL_05b6: Expected VT, but got I4
		//IL_05c0: Expected VT, but got I4
		//IL_05ca: Expected VT, but got I4
		//IL_05d4: Expected VT, but got I4
		//IL_05de: Expected VT, but got I4
		//IL_05e8: Expected VT, but got I4
		//IL_05f2: Expected VT, but got I4
		//IL_05fc: Expected VT, but got I4
		//IL_0606: Expected VT, but got I4
		//IL_0610: Expected VT, but got I4
		//IL_061a: Expected VT, but got I4
		//IL_0624: Expected VT, but got I4
		//IL_062e: Expected VT, but got I4
		//IL_0638: Expected VT, but got I4
		//IL_0642: Expected VT, but got I4
		//IL_064c: Expected VT, but got I4
		//IL_0656: Expected VT, but got I4
		//IL_0660: Expected VT, but got I4
		//IL_066a: Expected VT, but got I4
		//IL_0674: Expected VT, but got I4
		//IL_067e: Expected VT, but got I4
		//IL_0688: Expected VT, but got I4
		//IL_0692: Expected VT, but got I4
		//IL_069c: Expected VT, but got I4
		//IL_06a6: Expected VT, but got I4
		//IL_06b0: Expected VT, but got I4
		//IL_06ba: Expected VT, but got I4
		//IL_06c4: Expected VT, but got I4
		//IL_06ce: Expected VT, but got I4
		//IL_06d8: Expected VT, but got I4
		//IL_06e2: Expected VT, but got I4
		//IL_06ec: Expected VT, but got I4
		//IL_06f6: Expected VT, but got I4
		//IL_0700: Expected VT, but got I4
		//IL_070a: Expected VT, but got I4
		//IL_0714: Expected VT, but got I4
		//IL_071e: Expected VT, but got I4
		//IL_0728: Expected VT, but got I4
		//IL_0732: Expected VT, but got I4
		//IL_073c: Expected VT, but got I4
		//IL_0746: Expected VT, but got I4
		//IL_0750: Expected VT, but got I4
		//IL_075a: Expected VT, but got I4
		//IL_0764: Expected VT, but got I4
		//IL_076e: Expected VT, but got I4
		//IL_0778: Expected VT, but got I4
		//IL_0782: Expected VT, but got I4
		//IL_078c: Expected VT, but got I4
		//IL_0796: Expected VT, but got I4
		//IL_07a0: Expected VT, but got I4
		//IL_07aa: Expected VT, but got I4
		//IL_07b4: Expected VT, but got I4
		//IL_07be: Expected VT, but got I4
		//IL_07c8: Expected VT, but got I4
		//IL_07d2: Expected VT, but got I4
		//IL_07dc: Expected VT, but got I4
		//IL_07e6: Expected VT, but got I4
		//IL_07f0: Expected VT, but got I4
		//IL_07fa: Expected VT, but got I4
		//IL_0804: Expected VT, but got I4
		//IL_080e: Expected VT, but got I4
		//IL_0818: Expected VT, but got I4
		//IL_0822: Expected VT, but got I4
		//IL_082c: Expected VT, but got I4
		//IL_0836: Expected VT, but got I4
		//IL_0840: Expected VT, but got I4
		//IL_084a: Expected VT, but got I4
		//IL_0854: Expected VT, but got I4
		//IL_085e: Expected VT, but got I4
		//IL_0868: Expected VT, but got I4
		//IL_0872: Expected VT, but got I4
		//IL_087c: Expected VT, but got I4
		//IL_0886: Expected VT, but got I4
		//IL_0890: Expected VT, but got I4
		//IL_089a: Expected VT, but got I4
		//IL_08a4: Expected VT, but got I4
		//IL_08ae: Expected VT, but got I4
		//IL_08b8: Expected VT, but got I4
		//IL_08c2: Expected VT, but got I4
		//IL_08cc: Expected VT, but got I4
		//IL_08d6: Expected VT, but got I4
		//IL_08e0: Expected VT, but got I4
		//IL_08ea: Expected VT, but got I4
		//IL_08f4: Expected VT, but got I4
		//IL_08fe: Expected VT, but got I4
		//IL_0908: Expected VT, but got I4
		//IL_0912: Expected VT, but got I4
		//IL_091c: Expected VT, but got I4
		//IL_0926: Expected VT, but got I4
		//IL_0930: Expected VT, but got I4
		//IL_093a: Expected VT, but got I4
		//IL_0944: Expected VT, but got I4
		//IL_094e: Expected VT, but got I4
		//IL_0958: Expected VT, but got I4
		//IL_0962: Expected VT, but got I4
		//IL_096c: Expected VT, but got I4
		//IL_0976: Expected VT, but got I4
		//IL_0980: Expected VT, but got I4
		//IL_098a: Expected VT, but got I4
		//IL_0994: Expected VT, but got I4
		//IL_099e: Expected VT, but got I4
		//IL_09a8: Expected VT, but got I4
		//IL_09b2: Expected VT, but got I4
		//IL_09bc: Expected VT, but got I4
		//IL_09c6: Expected VT, but got I4
		//IL_09d0: Expected VT, but got I4
		//IL_09da: Expected VT, but got I4
		//IL_09e4: Expected VT, but got I4
		//IL_09ee: Expected VT, but got I4
		//IL_09f8: Expected VT, but got I4
		//IL_0a02: Expected VT, but got I4
		//IL_0a0c: Expected VT, but got I4
		//IL_0a16: Expected VT, but got I4
		//IL_0a20: Expected VT, but got I4
		//IL_0a2a: Expected VT, but got I4
		//IL_0a34: Expected VT, but got I4
		//IL_0a3e: Expected VT, but got I4
		//IL_0a48: Expected VT, but got I4
		//IL_0a52: Expected VT, but got I4
		//IL_0a5c: Expected VT, but got I4
		//IL_0a66: Expected VT, but got I4
		//IL_0a70: Expected VT, but got I4
		//IL_0a7a: Expected VT, but got I4
		//IL_0a84: Expected VT, but got I4
		//IL_0a8e: Expected VT, but got I4
		//IL_0a98: Expected VT, but got I4
		//IL_0aa2: Expected VT, but got I4
		//IL_0aac: Expected VT, but got I4
		//IL_0ab6: Expected VT, but got I4
		//IL_0ac0: Expected VT, but got I4
		//IL_0aca: Expected VT, but got I4
		//IL_0ad4: Expected VT, but got I4
		//IL_0ade: Expected VT, but got I4
		//IL_0ae8: Expected VT, but got I4
		//IL_0af2: Expected VT, but got I4
		//IL_0afc: Expected VT, but got I4
		//IL_0b06: Expected VT, but got I4
		//IL_0b10: Expected VT, but got I4
		//IL_0b1a: Expected VT, but got I4
		//IL_0b24: Expected VT, but got I4
		//IL_0b2e: Expected VT, but got I4
		//IL_0b38: Expected VT, but got I4
		//IL_0b42: Expected VT, but got I4
		//IL_0b4c: Expected VT, but got I4
		//IL_0b56: Expected VT, but got I4
		//IL_0b60: Expected VT, but got I4
		//IL_0b6a: Expected VT, but got I4
		//IL_0b74: Expected VT, but got I4
		//IL_0b7e: Expected VT, but got I4
		//IL_0b88: Expected VT, but got I4
		//IL_0b92: Expected VT, but got I4
		//IL_0b9c: Expected VT, but got I4
		//IL_0ba6: Expected VT, but got I4
		//IL_0bb0: Expected VT, but got I4
		//IL_0bba: Expected VT, but got I4
		//IL_0bc4: Expected VT, but got I4
		//IL_0bce: Expected VT, but got I4
		//IL_0bd8: Expected VT, but got I4
		//IL_0be2: Expected VT, but got I4
		//IL_0bec: Expected VT, but got I4
		//IL_0bf6: Expected VT, but got I4
		//IL_0c00: Expected VT, but got I4
		//IL_0c0a: Expected VT, but got I4
		//IL_0c14: Expected VT, but got I4
		//IL_0c1e: Expected VT, but got I4
		//IL_0c28: Expected VT, but got I4
		//IL_0c32: Expected VT, but got I4
		//IL_0c3c: Expected VT, but got I4
		//IL_0c46: Expected VT, but got I4
		//IL_0c50: Expected VT, but got I4
		//IL_0c5a: Expected VT, but got I4
		//IL_0c64: Expected VT, but got I4
		//IL_0c6e: Expected VT, but got I4
		//IL_0c78: Expected VT, but got I4
		//IL_0c82: Expected VT, but got I4
		//IL_0c8c: Expected VT, but got I4
		//IL_0c96: Expected VT, but got I4
		//IL_0ca0: Expected VT, but got I4
		//IL_0caa: Expected VT, but got I4
		//IL_0cb4: Expected VT, but got I4
		//IL_0cbe: Expected VT, but got I4
		//IL_0cc8: Expected VT, but got I4
		//IL_0cd2: Expected VT, but got I4
		//IL_0cdc: Expected VT, but got I4
		//IL_0ce6: Expected VT, but got I4
		//IL_0cf0: Expected VT, but got I4
		//IL_0cfa: Expected VT, but got I4
		//IL_0d04: Expected VT, but got I4
		//IL_0d0e: Expected VT, but got I4
		//IL_0d18: Expected VT, but got I4
		//IL_0d22: Expected VT, but got I4
		//IL_0d2c: Expected VT, but got I4
		//IL_0d36: Expected VT, but got I4
		//IL_0d40: Expected VT, but got I4
		//IL_0d4a: Expected VT, but got I4
		//IL_0d54: Expected VT, but got I4
		//IL_0d5e: Expected VT, but got I4
		//IL_0d68: Expected VT, but got I4
		//IL_0d72: Expected VT, but got I4
		//IL_0d7c: Expected VT, but got I4
		//IL_0d86: Expected VT, but got I4
		//IL_0d90: Expected VT, but got I4
		//IL_0d9a: Expected VT, but got I4
		//IL_0da4: Expected VT, but got I4
		//IL_0dae: Expected VT, but got I4
		//IL_0db8: Expected VT, but got I4
		//IL_0dc2: Expected VT, but got I4
		//IL_0dcc: Expected VT, but got I4
		//IL_0dd6: Expected VT, but got I4
		//IL_0de0: Expected VT, but got I4
		//IL_0dea: Expected VT, but got I4
		//IL_0df4: Expected VT, but got I4
		//IL_0dfe: Expected VT, but got I4
		//IL_0e08: Expected VT, but got I4
		//IL_0e12: Expected VT, but got I4
		//IL_0e1c: Expected VT, but got I4
		//IL_0e26: Expected VT, but got I4
		//IL_0e30: Expected VT, but got I4
		//IL_0e3a: Expected VT, but got I4
		//IL_0e44: Expected VT, but got I4
		//IL_0e4e: Expected VT, but got I4
		//IL_0e58: Expected VT, but got I4
		//IL_0e62: Expected VT, but got I4
		//IL_0e6c: Expected VT, but got I4
		//IL_0e76: Expected VT, but got I4
		//IL_0e80: Expected VT, but got I4
		//IL_0e8a: Expected VT, but got I4
		//IL_0e94: Expected VT, but got I4
		//IL_0e9e: Expected VT, but got I4
		//IL_0ea8: Expected VT, but got I4
		//IL_0eb2: Expected VT, but got I4
		//IL_0ebc: Expected VT, but got I4
		//IL_0ec6: Expected VT, but got I4
		//IL_0ed0: Expected VT, but got I4
		//IL_0eda: Expected VT, but got I4
		//IL_0ee4: Expected VT, but got I4
		//IL_0eee: Expected VT, but got I4
		//IL_0ef8: Expected VT, but got I4
		//IL_0f02: Expected VT, but got I4
		//IL_0f0c: Expected VT, but got I4
		//IL_0f16: Expected VT, but got I4
		//IL_0f20: Expected VT, but got I4
		//IL_0f2a: Expected VT, but got I4
		//IL_0f34: Expected VT, but got I4
		//IL_0f3e: Expected VT, but got I4
		//IL_0f48: Expected VT, but got I4
		//IL_0f52: Expected VT, but got I4
		//IL_0f5c: Expected VT, but got I4
		//IL_0f66: Expected VT, but got I4
		//IL_0f70: Expected VT, but got I4
		//IL_0f7a: Expected VT, but got I4
		//IL_0f84: Expected VT, but got I4
		//IL_0f8e: Expected VT, but got I4
		//IL_0f98: Expected VT, but got I4
		//IL_0fa2: Expected VT, but got I4
		//IL_0fac: Expected VT, but got I4
		//IL_0fb6: Expected VT, but got I4
		//IL_0fc0: Expected VT, but got I4
		//IL_0fca: Expected VT, but got I4
		//IL_0fd4: Expected VT, but got I4
		//IL_0fde: Expected VT, but got I4
		//IL_0fe8: Expected VT, but got I4
		//IL_0ff2: Expected VT, but got I4
		//IL_0ffc: Expected VT, but got I4
		//IL_1006: Expected VT, but got I4
		//IL_1010: Expected VT, but got I4
		//IL_101a: Expected VT, but got I4
		//IL_1024: Expected VT, but got I4
		//IL_102e: Expected VT, but got I4
		//IL_1038: Expected VT, but got I4
		//IL_1042: Expected VT, but got I4
		//IL_104c: Expected VT, but got I4
		//IL_1056: Expected VT, but got I4
		//IL_1060: Expected VT, but got I4
		//IL_106a: Expected VT, but got I4
		//IL_1074: Expected VT, but got I4
		//IL_107e: Expected VT, but got I4
		//IL_1088: Expected VT, but got I4
		//IL_1092: Expected VT, but got I4
		//IL_109c: Expected VT, but got I4
		//IL_10a6: Expected VT, but got I4
		//IL_10b0: Expected VT, but got I4
		//IL_10ba: Expected VT, but got I4
		//IL_10c4: Expected VT, but got I4
		//IL_10ce: Expected VT, but got I4
		//IL_10d8: Expected VT, but got I4
		//IL_10e2: Expected VT, but got I4
		//IL_10ec: Expected VT, but got I4
		//IL_10f6: Expected VT, but got I4
		//IL_1100: Expected VT, but got I4
		//IL_110a: Expected VT, but got I4
		//IL_1114: Expected VT, but got I4
		//IL_111e: Expected VT, but got I4
		//IL_1128: Expected VT, but got I4
		//IL_1132: Expected VT, but got I4
		//IL_113c: Expected VT, but got I4
		//IL_1146: Expected VT, but got I4
		//IL_1150: Expected VT, but got I4
		//IL_115a: Expected VT, but got I4
		//IL_1164: Expected VT, but got I4
		//IL_116e: Expected VT, but got I4
		//IL_1178: Expected VT, but got I4
		//IL_1182: Expected VT, but got I4
		//IL_118c: Expected VT, but got I4
		//IL_1196: Expected VT, but got I4
		//IL_11a0: Expected VT, but got I4
		//IL_11aa: Expected VT, but got I4
		//IL_11b4: Expected VT, but got I4
		//IL_11be: Expected VT, but got I4
		//IL_11c8: Expected VT, but got I4
		//IL_11d2: Expected VT, but got I4
		//IL_11dc: Expected VT, but got I4
		//IL_11e6: Expected VT, but got I4
		//IL_11f0: Expected VT, but got I4
		//IL_11fa: Expected VT, but got I4
		//IL_1204: Expected VT, but got I4
		//IL_120e: Expected VT, but got I4
		//IL_1235: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Expected Obj, but got Unknown
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_1257: Expected Obj, but got Unknown
		//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Expected VT, but got Unknown
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d3: Expected Obj, but got Unknown
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1302: Expected VT, but got Unknown
		//IL_130b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1310: Expected VT, but got Unknown
		//IL_1318: Expected native int or pointer, but got VT
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Expected VT, but got Unknown
		//IL_136c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1371: Expected VT, but got Unknown
		//IL_1379: Expected native int or pointer, but got VT
		//IL_1393: Expected Obj, but got I
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c5: Expected VT, but got Unknown
		//IL_13e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e5: Expected Obj, but got Unknown
		//IL_140f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1414: Expected VT, but got Unknown
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Expected VT, but got Unknown
		//IL_142a: Expected native int or pointer, but got VT
		//IL_1470: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Expected VT, but got Unknown
		//IL_147e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1483: Expected VT, but got Unknown
		//IL_148b: Expected native int or pointer, but got VT
		//IL_14a5: Expected Obj, but got I
		//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d7: Expected VT, but got Unknown
		//IL_14f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f7: Expected Obj, but got Unknown
		//IL_1521: Unknown result type (might be due to invalid IL or missing references)
		//IL_1526: Expected VT, but got Unknown
		//IL_152f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1534: Expected VT, but got Unknown
		//IL_153c: Expected native int or pointer, but got VT
		//IL_1569: Unknown result type (might be due to invalid IL or missing references)
		//IL_156e: Expected VT, but got Unknown
		//IL_1577: Unknown result type (might be due to invalid IL or missing references)
		//IL_157c: Expected VT, but got Unknown
		//IL_1584: Expected native int or pointer, but got VT
		//IL_159e: Expected Obj, but got I
		//IL_15c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c8: Expected VT, but got Unknown
		//IL_15d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d6: Expected VT, but got Unknown
		//IL_15de: Expected native int or pointer, but got VT
		//IL_15f8: Expected Obj, but got I
		//IL_1625: Unknown result type (might be due to invalid IL or missing references)
		//IL_162a: Expected VT, but got Unknown
		//IL_1645: Unknown result type (might be due to invalid IL or missing references)
		//IL_164a: Expected Obj, but got Unknown
		//IL_1674: Unknown result type (might be due to invalid IL or missing references)
		//IL_1679: Expected VT, but got Unknown
		//IL_1682: Unknown result type (might be due to invalid IL or missing references)
		//IL_1687: Expected VT, but got Unknown
		//IL_168f: Expected native int or pointer, but got VT
		//IL_16bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c1: Expected VT, but got Unknown
		//IL_16ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cf: Expected VT, but got Unknown
		//IL_16d7: Expected native int or pointer, but got VT
		//IL_16f1: Expected Obj, but got I
		//IL_1716: Unknown result type (might be due to invalid IL or missing references)
		//IL_171b: Expected VT, but got Unknown
		//IL_1724: Unknown result type (might be due to invalid IL or missing references)
		//IL_1729: Expected VT, but got Unknown
		//IL_1731: Expected native int or pointer, but got VT
		//IL_174b: Expected Obj, but got I
		//IL_1778: Unknown result type (might be due to invalid IL or missing references)
		//IL_177d: Expected VT, but got Unknown
		//IL_1798: Unknown result type (might be due to invalid IL or missing references)
		//IL_179d: Expected Obj, but got Unknown
		//IL_17c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cc: Expected VT, but got Unknown
		//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17da: Expected VT, but got Unknown
		//IL_17e2: Expected native int or pointer, but got VT
		//IL_180f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1814: Expected VT, but got Unknown
		//IL_181d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1822: Expected VT, but got Unknown
		//IL_182a: Expected native int or pointer, but got VT
		//IL_1844: Expected Obj, but got I
		//IL_1869: Unknown result type (might be due to invalid IL or missing references)
		//IL_186e: Expected VT, but got Unknown
		//IL_1877: Unknown result type (might be due to invalid IL or missing references)
		//IL_187c: Expected VT, but got Unknown
		//IL_1884: Expected native int or pointer, but got VT
		//IL_189e: Expected Obj, but got I
		//IL_18cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d0: Expected VT, but got Unknown
		//IL_18eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f0: Expected Obj, but got Unknown
		//IL_191a: Unknown result type (might be due to invalid IL or missing references)
		//IL_191f: Expected VT, but got Unknown
		//IL_1928: Unknown result type (might be due to invalid IL or missing references)
		//IL_192d: Expected VT, but got Unknown
		//IL_1935: Expected native int or pointer, but got VT
		//IL_197b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1980: Expected VT, but got Unknown
		//IL_1989: Unknown result type (might be due to invalid IL or missing references)
		//IL_198e: Expected VT, but got Unknown
		//IL_1996: Expected native int or pointer, but got VT
		//IL_19b0: Expected Obj, but got I
		//IL_19dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e2: Expected VT, but got Unknown
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a02: Expected Obj, but got Unknown
		//IL_1a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a31: Expected VT, but got Unknown
		//IL_1a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3f: Expected VT, but got Unknown
		//IL_1a47: Expected native int or pointer, but got VT
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Expected VT, but got Unknown
		//IL_1a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a87: Expected VT, but got Unknown
		//IL_1a8f: Expected native int or pointer, but got VT
		//IL_1aa9: Expected Obj, but got I
		//IL_1ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac9: Expected VT, but got Unknown
		//IL_1ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad7: Expected VT, but got Unknown
		//IL_1adf: Expected native int or pointer, but got VT
		//IL_1af4: Expected Obj, but got I
		//IL_1b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b14: Expected VT, but got Unknown
		//IL_1b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b22: Expected VT, but got Unknown
		//IL_1b2a: Expected native int or pointer, but got VT
		//IL_1b44: Expected Obj, but got I
		//IL_1b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b76: Expected VT, but got Unknown
		//IL_1b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b96: Expected Obj, but got Unknown
		//IL_1bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb3: Expected Obj, but got Unknown
		//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0f: Expected VT, but got Unknown
		//IL_1c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2f: Expected Obj, but got Unknown
		//IL_1c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5e: Expected VT, but got Unknown
		//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6c: Expected VT, but got Unknown
		//IL_1c74: Expected native int or pointer, but got VT
		//IL_1cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbf: Expected VT, but got Unknown
		//IL_1cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Expected VT, but got Unknown
		//IL_1cd5: Expected native int or pointer, but got VT
		//IL_1cef: Expected Obj, but got I
		//IL_1d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d21: Expected VT, but got Unknown
		//IL_1d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d41: Expected Obj, but got Unknown
		//IL_1d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d70: Expected VT, but got Unknown
		//IL_1d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7e: Expected VT, but got Unknown
		//IL_1d86: Expected native int or pointer, but got VT
		//IL_1dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd1: Expected VT, but got Unknown
		//IL_1dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddf: Expected VT, but got Unknown
		//IL_1de7: Expected native int or pointer, but got VT
		//IL_1e01: Expected Obj, but got I
		//IL_1e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e33: Expected VT, but got Unknown
		//IL_1e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e53: Expected Obj, but got Unknown
		//IL_1e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e82: Expected VT, but got Unknown
		//IL_1e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e90: Expected VT, but got Unknown
		//IL_1e98: Expected native int or pointer, but got VT
		//IL_1ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee3: Expected VT, but got Unknown
		//IL_1eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef1: Expected VT, but got Unknown
		//IL_1ef9: Expected native int or pointer, but got VT
		//IL_1f13: Expected Obj, but got I
		//IL_1f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f45: Expected VT, but got Unknown
		//IL_1f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f65: Expected Obj, but got Unknown
		//IL_1f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f94: Expected VT, but got Unknown
		//IL_1f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa2: Expected VT, but got Unknown
		//IL_1faa: Expected native int or pointer, but got VT
		//IL_1fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdc: Expected VT, but got Unknown
		//IL_1fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fea: Expected VT, but got Unknown
		//IL_1ff2: Expected native int or pointer, but got VT
		//IL_200c: Expected Obj, but got I
		//IL_2027: Unknown result type (might be due to invalid IL or missing references)
		//IL_202c: Expected VT, but got Unknown
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_203a: Expected VT, but got Unknown
		//IL_2042: Expected native int or pointer, but got VT
		//IL_2057: Expected Obj, but got I
		//IL_2072: Unknown result type (might be due to invalid IL or missing references)
		//IL_2077: Expected VT, but got Unknown
		//IL_2080: Unknown result type (might be due to invalid IL or missing references)
		//IL_2085: Expected VT, but got Unknown
		//IL_208d: Expected native int or pointer, but got VT
		//IL_20a7: Expected Obj, but got I
		//IL_20d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d9: Expected VT, but got Unknown
		//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f9: Expected Obj, but got Unknown
		//IL_2111: Unknown result type (might be due to invalid IL or missing references)
		//IL_2116: Expected Obj, but got Unknown
		//IL_216d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2172: Expected VT, but got Unknown
		//IL_218d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2192: Expected Obj, but got Unknown
		//IL_21bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c1: Expected VT, but got Unknown
		//IL_21ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cf: Expected VT, but got Unknown
		//IL_21d7: Expected native int or pointer, but got VT
		//IL_221d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2222: Expected VT, but got Unknown
		//IL_222b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2230: Expected VT, but got Unknown
		//IL_2238: Expected native int or pointer, but got VT
		//IL_2252: Expected Obj, but got I
		//IL_227f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2284: Expected VT, but got Unknown
		//IL_229f: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a4: Expected Obj, but got Unknown
		//IL_22ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d3: Expected VT, but got Unknown
		//IL_22dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e1: Expected VT, but got Unknown
		//IL_22e9: Expected native int or pointer, but got VT
		//IL_232f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2334: Expected VT, but got Unknown
		//IL_233d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2342: Expected VT, but got Unknown
		//IL_234a: Expected native int or pointer, but got VT
		//IL_2364: Expected Obj, but got I
		//IL_2391: Unknown result type (might be due to invalid IL or missing references)
		//IL_2396: Expected VT, but got Unknown
		//IL_23b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b6: Expected Obj, but got Unknown
		//IL_23e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e5: Expected VT, but got Unknown
		//IL_23ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f3: Expected VT, but got Unknown
		//IL_23fb: Expected native int or pointer, but got VT
		//IL_2441: Unknown result type (might be due to invalid IL or missing references)
		//IL_2446: Expected VT, but got Unknown
		//IL_244f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2454: Expected VT, but got Unknown
		//IL_245c: Expected native int or pointer, but got VT
		//IL_2476: Expected Obj, but got I
		//IL_2489: Unknown result type (might be due to invalid IL or missing references)
		//IL_248e: Expected Obj, but got Unknown
		//IL_249e: Expected Obj, but got I
		//IL_24b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b9: Expected VT, but got Unknown
		//IL_24d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d9: Expected Obj, but got Unknown
		//IL_2503: Unknown result type (might be due to invalid IL or missing references)
		//IL_2508: Expected VT, but got Unknown
		//IL_2511: Unknown result type (might be due to invalid IL or missing references)
		//IL_2516: Expected VT, but got Unknown
		//IL_251e: Expected native int or pointer, but got VT
		//IL_2564: Unknown result type (might be due to invalid IL or missing references)
		//IL_2569: Expected VT, but got Unknown
		//IL_2572: Unknown result type (might be due to invalid IL or missing references)
		//IL_2577: Expected VT, but got Unknown
		//IL_257f: Expected native int or pointer, but got VT
		//IL_2599: Expected Obj, but got I
		//IL_25a6: Expected VT, but got Obj
		//IL_25a1: Expected native int or pointer, but got VT
		//IL_25b3: Expected VT, but got Obj
		//IL_25ae: Expected native int or pointer, but got VT
		//IL_25c8: Expected VT, but got I
		//IL_25c3: Expected native int or pointer, but got VT
		//IL_25dd: Expected VT, but got I
		//IL_25d8: Expected native int or pointer, but got VT
		object obj = default;
		ButtonColorScheme buttonColorScheme = (ButtonColorScheme)(obj - 1360);
		object obj2 = buttonColorScheme + 1352;
		obj2 = 0;
		object obj3 = buttonColorScheme + 1344;
		obj3 = 0;
		object obj4 = buttonColorScheme + 1336;
		obj4 = 0;
		_ = 0;
		AWARDS_NEW_STICKER_COLOR = (Color32)(-14255873);
		AWARDS_COLLECTIBLE_STICKER_COLOR = (Color32)(-12589057);
		TOP_RUN_STICKER_COLOR = (Color32)(-16558603);
		DISCOUNT_BUTTON_DESCRIPTION2_COLOR = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR;
		DISCOUNT_BUTTON_DESCRIPTION2_SHADOW_COLOR = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR_SHADOW;
		DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_COLOR = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_COLOR;
		DISCOUNT_BUTTON_DESCRIPTION1_ACTIVE_SHADOW_COLOR = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;
		DISCOUNT_BUTTON_LINE_THROUGH_COLOR = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR;
		DISCOUNT_BUTTON_LINE_THROUGH_SHADOW_COLOR = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR_SHADOW;
		WATCH_VIDEO_FOR_COINS_TITLE_COINS = (Color32)(-13447954);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj6 = default;
		object obj5 = obj6 & 0xFF;
		object obj8 = default;
		object obj7 = obj8 << 8;
		object obj9 = obj7 & 0xFF00;
		object obj11 = default;
		object obj10 = obj11 << 16;
		object obj12 = obj10 & 0xFF0000;
		object obj14 = default;
		object obj13 = obj14 << 24;
		object obj15 = obj12 | obj13;
		object obj16 = obj9 | obj15;
		Color32 wATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS = (Color32)(obj5 | obj16);
		WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS = wATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj18 = default;
		object obj17 = obj18 & 0xFF;
		object obj20 = default;
		object obj19 = obj20 << 8;
		object obj21 = obj19 & 0xFF00;
		object obj23 = default;
		object obj22 = obj23 << 16;
		object obj24 = obj22 & 0xFF0000;
		object obj26 = default;
		object obj25 = obj26 << 24;
		object obj27 = obj24 | obj25;
		object obj28 = obj21 | obj27;
		Color32 wATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS = (Color32)(obj17 | obj28);
		WATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS = wATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj30 = default;
		object obj29 = obj30 & 0xFF;
		object obj32 = default;
		object obj31 = obj32 << 8;
		object obj33 = obj31 & 0xFF00;
		object obj35 = default;
		object obj34 = obj35 << 16;
		object obj36 = obj34 & 0xFF0000;
		object obj38 = default;
		object obj37 = obj38 << 24;
		object obj39 = obj36 | obj37;
		object obj40 = obj33 | obj39;
		Color32 wATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS = (Color32)(obj29 | obj40);
		WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS = wATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS;
		WATCH_VIDEO_FOR_COINS_TITLE_KEYS = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR;
		WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_KEYS = GlobalColorsGenerated.DISCOUNT_BUTTON_TITLE_COLOR_SHADOW;
		WATCH_VIDEO_FOR_COINS_DESCRIPTION_KEYS = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_COLOR;
		WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_KEYS = GlobalColorsGenerated.DISCOUNT_BUTTON_DESCRIPTION1_INACTIVE_SHADOW_COLOR;
		GIFT_COLOR = (Color32)(-16738312);
		GIFT_LABEL_COLOR = (Color32)(-1);
		EXPIRE_TIME_COUNTER_TRY_NOT_SELECTED = (Color32)(-4330026);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj42 = default;
		object obj41 = obj42 & 0xFF;
		object obj44 = default;
		object obj43 = obj44 << 8;
		object obj45 = obj43 & 0xFF00;
		object obj47 = default;
		object obj46 = obj47 << 16;
		object obj48 = obj46 & 0xFF0000;
		object obj50 = default;
		object obj49 = obj50 << 24;
		object obj51 = obj48 | obj49;
		object obj52 = obj45 | obj51;
		Color32 eXPIRE_TIME_COUNTER_TRY_SELECTED = (Color32)(obj41 | obj52);
		EXPIRE_TIME_COUNTER_TRY_SELECTED = eXPIRE_TIME_COUNTER_TRY_SELECTED;
		FOOTER_ME_COLOR = (Color32)(-16685823);
		FOOTER_ME_COLOR_LIGHT = (Color32)(-12216202);
		FOOTER_ME_COLOR_SELECTED = (Color32)(-16699391);
		FOOTER_SHOP_COLOR = (Color32)(-5542362);
		FOOTER_SHOP_COLOR_LIGHT = (Color32)(-4023453);
		FOOTER_SHOP_COLOR_SELECTED = (Color32)(-11587313);
		FOOTER_SOCIAL_COLOR = (Color32)(-7656624);
		FOOTER_SOCIAL_COLOR_LIGHT = (Color32)(-3511158);
		FOOTER_SOCIAL_COLOR_SELECTED = (Color32)(-12512732);
		FOOTER_BACK_COLOR = (Color32)(-13092808);
		FOOTER_BACK_COLOR_LIGHT = (Color32)(-8224126);
		FOOTER_BIG_PLAY_RESUME_COLOR = (Color32)(-13984442);
		FOOTER_BIG_WAIT_COLOR = (Color32)(-9013642);
		EVENTS_POPUP_SPLASH_COLOR = (Color32)(-24064);
		EVENTS_POPUP_DESCRIPTION_BOX_JACKPOT_EVENT_COLOR = (Color32)(-94463);
		EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR = (Color32)(-16671234);
		EVENTS_POPUP_GLOW_DEFAULT_COLOR = (Color32)(-1236479523);
		EVENTS_POPUP_GLOW_JACKPOT_COLOR = (Color32)(-924463190);
		EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR = (Color32)(-11917049);
		EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR = (Color32)(-24064);
		EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR = (Color32)(-24064);
		EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR = (Color32)(-11917049);
		EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR = (Color32)(-342909);
		EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR = (Color32)(-7648527);
		EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR = (Color32)(-4489732);
		EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR = (Color32)(-4489732);
		EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_DESCRIPTION_COLOR = (Color32)(-7648527);
		INACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR = (Color32)int.MinValue;
		INACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR = (Color32)int.MinValue;
		ACTIVE_HEADSTART_BUTTON_BACKGROUND_COLOR = (Color32)(-451943939);
		ACTIVE_SCOREBOOSTER_BUTTON_BACKGROUND_COLOR = (Color32)(-436239360);
		ACTIVE_HEADSTART_GEAR_BACKGROUND_COLOR = (Color32)(-16716802);
		ACTIVE_HEADSTART_GEAR_COUNT_COLOR = (Color32)(-16312935);
		ACTIVE_SCOREBOOSTER_GEAR_BACKGROUND_COLOR = (Color32)(-10656);
		ACTIVE_SCOREBOOSTER_GEAR_COUNT_COLOR = (Color32)(-6144486);
		INACTIVE_GEAR_BACKGROUND_COLOR = (Color32)1711276032;
		INACTIVE_GEAR_COUNT_COLOR = (Color32)(-1);
		INITIAL_GEAR_GLOW_COLOR = (Color32)16777215;
		FINAL_GEAR_GLOW_COLOR = (Color32)(-1);
		INITIAL_HEADSTART_BUTTON_GLOW_COLOR = (Color32)16777215;
		FINAL_HEADSTART_BUTTON_GLOW_COLOR = (Color32)(-1593835521);
		PRIMARY_ACTION_COLOR = (Color32)(-13918906);
		PRIMARY_ACTION_COLOR_LIGHT = (Color32)(-12664181);
		PRIMARY_ACTION_COLOR_SELECTED = (Color32)(-4290250);
		PRIMARY_ACTION_COLOR_UNAVAILABLE = (Color32)(-9013642);
		COLOR_WHITE = (Color32)(-1);
		COLOR_PRESSED = (Color32)(-8355712);
		SECONDARY_ACTION_COLOR = (Color32)(-16757516);
		SECONDARY_ACTION_COLOR_LIGHT = (Color32)(-13711361);
		TERTIARY_ACTION_COLOR = (Color32)(-4290250);
		TERTIARY_ACTION_COLOR_LIGHT = (Color32)1895162807;
		TERTIARY_ACTION_COLOR_SELECTED = (Color32)(-4290250);
		TERTIARY_ACTION_COLOR_UNAVAILABLE = (Color32)(-9013642);
		EXIT_COLOR = (Color32)(-16579672);
		EXIT_COLOR_LIGHT = (Color32)(-11447809);
		SEASONAL_COLOR_FILL_NORMAL = (Color32)(-14898597);
		SEASONAL_COLOR_FILL_LIGHT = (Color32)1884677012;
		HOVERBOARD_CUSTOMIZATION_POPUP_BASE_BOARD_CONTAINER_COLOR = (Color32)(-4555718);
		HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR_LIGHT = (Color32)1358935925;
		HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR = (Color32)(-9813481);
		HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR = (Color32)(-16749855);
		FACEBOOK_COLOR = (Color32)(-6726853);
		FACEBOOK_COLOR_LIGHT = (Color32)1023410175;
		GAMECENTER_COLOR = (Color32)(-1);
		GAMECENTER_COLOR_LIGHT = (Color32)1023410175;
		SOCIAL_GREY = (Color32)(-9013641);
		SOCIAL_GRAY_OVERLAY = (Color32)(-6250336);
		WEEKLYHUNT_COLOR_TOPTITLE = (Color32)(-11261689);
		WEEKLYHUNT_COLOR_TOPSUBTITLE = (Color32)(-5868800);
		WEEKLYHUNT_COLOR_BOTTITLE = (Color32)(-11261689);
		WEEKLYHUNT_COLOR_BOTSUBTITLE = (Color32)(-5868800);
		WEEKLYHUNT_CELEBRATION_TEXT_COLOR_STRIPED_BACKGROUND = (Color32)(-16777216);
		WEEKLYHUNT_CELEBRATION_TEXT_COLOR = (Color32)(-16777216);
		WEEKLYHUNT_CELEBRATION_TEXT_SHADOW_COLOR = (Color32)(-1);
		CHARACTERS_CUSTOMIZATION_BASE_SKIN_FILL = (Color32)(-4290250);
		CHARACTERS_CUSTOMIZATION_BASE_SKIN_ICON = (Color32)(-11520498);
		CHARACTERS_CUSTOMIZATION_TRICKY_ARMY_SKIN_FILL = (Color32)(-8011299);
		CHARACTERS_CUSTOMIZATION_TRICKY_ARMY_SKIN_ICON = (Color32)(-16608879);
		CHARACTERS_CUSTOMIZATION_TRICKY_COOL_SKIN_FILL = (Color32)(-4441193);
		CHARACTERS_CUSTOMIZATION_TRICKY_COOL_SKIN_ICON = (Color32)(-10537737);
		CHARACTERS_CUSTOMIZATION_JAKE_KID_SKIN_FILL = (Color32)(-16771365);
		CHARACTERS_CUSTOMIZATION_JAKE_KID_SKIN_ICON = (Color32)(-16724235);
		CHARACTERS_CUSTOMIZATION_JAKE_DARK_SKIN_FILL = (Color32)(-9747144);
		CHARACTERS_CUSTOMIZATION_JAKE_DARK_SKIN_ICON = (Color32)(-7166289);
		CHARACTERS_CUSTOMIZATION_TAGBOT_RED_SKIN_FILL = (Color32)(-13523078);
		CHARACTERS_CUSTOMIZATION_TAGBOT_RED_SKIN_ICON = (Color32)(-16316491);
		CHARACTERS_CUSTOMIZATION_TAGBOT_R2D2_SKIN_FILL = (Color32)(-6703415);
		CHARACTERS_CUSTOMIZATION_TAGBOT_R2D2_SKIN_ICON = (Color32)(-6534384);
		CHARACTERS_CUSTOMIZATION_SPIKE_DARK_SKIN_FILL = (Color32)(-8695762);
		CHARACTERS_CUSTOMIZATION_SPIKE_DARK_SKIN_ICON = (Color32)(-15724524);
		CHARACTERS_CUSTOMIZATION_SPIKE_STAR_SKIN_FILL = (Color32)(-15724524);
		CHARACTERS_CUSTOMIZATION_SPIKE_STAR_SKIN_ICON = (Color32)(-15523403);
		CHARACTERS_CUSTOMIZATION_FRESH_BASKET_SKIN_FILL = (Color32)(-15919758);
		CHARACTERS_CUSTOMIZATION_FRESH_BASKET_SKIN_ICON = (Color32)(-4533012);
		CHARACTERS_CUSTOMIZATION_FRESH_SMOOTH_SKIN_FILL = (Color32)(-16720508);
		CHARACTERS_CUSTOMIZATION_FRESH_SMOOTH_SKIN_ICON = (Color32)(-5957699);
		CHARACTERS_CUSTOMIZATION_LUCY_THEME1_SKIN_FILL = (Color32)(-16777216);
		CHARACTERS_CUSTOMIZATION_LUCY_THEME1_SKIN_ICON = (Color32)(-16776972);
		CHARACTERS_CUSTOMIZATION_LUCY_THEME2_SKIN_FILL = (Color32)(-16765094);
		CHARACTERS_CUSTOMIZATION_LUCY_THEME2_SKIN_ICON = (Color32)(-16341373);
		CHARACTERS_CUSTOMIZATION_FRANK_THEME1_SKIN_FILL = (Color32)(-16708196);
		CHARACTERS_CUSTOMIZATION_FRANK_THEME1_SKIN_ICON = (Color32)(-7355940);
		CHARACTERS_CUSTOMIZATION_FRANK_THEME2_SKIN_FILL = (Color32)(-15526114);
		CHARACTERS_CUSTOMIZATION_FRANK_THEME2_SKIN_ICON = (Color32)(-15174937);
		CHARACTERS_CUSTOMIZATION_KING_THEME1_SKIN_FILL = (Color32)(-16777216);
		CHARACTERS_CUSTOMIZATION_KING_THEME1_SKIN_ICON = (Color32)(-15918399);
		CHARACTERS_CUSTOMIZATION_KING_THEME2_SKIN_FILL = (Color32)(-15557258);
		CHARACTERS_CUSTOMIZATION_KING_THEME2_SKIN_ICON = (Color32)(-16774246);
		CHARACTERS_CUSTOMIZATION_FRIZZY_THEME1_SKIN_FILL = (Color32)(-15819525);
		CHARACTERS_CUSTOMIZATION_FRIZZY_THEME1_SKIN_ICON = (Color32)(-14582011);
		CHARACTERS_CUSTOMIZATION_FRIZZY_THEME2_SKIN_FILL = (Color32)(-13813656);
		CHARACTERS_CUSTOMIZATION_FRIZZY_THEME2_SKIN_ICON = (Color32)(-15549711);
		CHARACTERS_CUSTOMIZATION_TASHA_THEME1_SKIN_FILL = (Color32)(-9554619);
		CHARACTERS_CUSTOMIZATION_TASHA_THEME1_SKIN_ICON = (Color32)(-2143525);
		CHARACTERS_CUSTOMIZATION_TASHA_THEME2_SKIN_FILL = (Color32)(-11585479);
		CHARACTERS_CUSTOMIZATION_TASHA_THEME2_SKIN_ICON = (Color32)(-11907353);
		CHARACTERS_CUSTOMIZATION_NICK_THEME1_SKIN_FILL = (Color32)(-7063236);
		CHARACTERS_CUSTOMIZATION_NICK_THEME1_SKIN_ICON = (Color32)(-203);
		CHARACTERS_CUSTOMIZATION_NICK_THEME2_SKIN_FILL = (Color32)(-6618916);
		CHARACTERS_CUSTOMIZATION_NICK_THEME2_SKIN_ICON = (Color32)(-14419276);
		CHARACTERS_CUSTOMIZATION_MINA_THEME1_SKIN_FILL = (Color32)(-14999250);
		CHARACTERS_CUSTOMIZATION_MINA_THEME1_SKIN_ICON = (Color32)(-13229385);
		CHARACTERS_CUSTOMIZATION_MINA_THEME2_SKIN_FILL = (Color32)(-8109601);
		CHARACTERS_CUSTOMIZATION_MINA_THEME2_SKIN_ICON = (Color32)(-3039745);
		CHARACTERS_CUSTOMIZATION_BRODY_THEME1_SKIN_FILL = (Color32)(-16251132);
		CHARACTERS_CUSTOMIZATION_BRODY_THEME1_SKIN_ICON = (Color32)(-12695437);
		CHARACTERS_CUSTOMIZATION_BRODY_THEME2_SKIN_FILL = (Color32)(-9814997);
		CHARACTERS_CUSTOMIZATION_BRODY_THEME2_SKIN_ICON = (Color32)(-16726146);
		CHARACTERS_CUSTOMIZATION_TONY_THEME1_SKIN_FILL = (Color32)(-14574387);
		CHARACTERS_CUSTOMIZATION_TONY_THEME1_SKIN_ICON = (Color32)(-15593458);
		CHARACTERS_CUSTOMIZATION_TONY_THEME2_SKIN_FILL = (Color32)(-5142976);
		CHARACTERS_CUSTOMIZATION_TONY_THEME2_SKIN_ICON = (Color32)(-3021070);
		CHARACTERS_CUSTOMIZATION_ROSA_THEME1_SKIN_FILL = (Color32)(-15918154);
		CHARACTERS_CUSTOMIZATION_ROSA_THEME1_SKIN_ICON = (Color32)(-16250864);
		CHARACTERS_CUSTOMIZATION_ROBERTO_THEME1_SKIN_FILL = (Color32)(-15263975);
		CHARACTERS_CUSTOMIZATION_ROBERTO_THEME1_SKIN_ICON = (Color32)(-16570688);
		CHARACTERS_CUSTOMIZATION_ZOE_THEME1_SKIN_FILL = (Color32)(-7652452);
		CHARACTERS_CUSTOMIZATION_ZOE_THEME1_SKIN_ICON = (Color32)(-9843731);
		CHARACTERS_CUSTOMIZATION_ZOE_THEME2_SKIN_FILL = (Color32)(-14343127);
		CHARACTERS_CUSTOMIZATION_ZOE_THEME2_SKIN_ICON = (Color32)(-14449425);
		CHARACTERS_CUSTOMIZATION_VANCOUVER1_THEME1_SKIN_FILL = (Color32)(-13884456);
		CHARACTERS_CUSTOMIZATION_VANCOUVER1_THEME1_SKIN_ICON = (Color32)(-3156260);
		CHARACTERS_CUSTOMIZATION_PRINCEK_THEME1_SKIN_FILL = (Color32)(-13613474);
		CHARACTERS_CUSTOMIZATION_PRINCEK_THEME1_SKIN_ICON = (Color32)(-13255436);
		CHARACTERS_CUSTOMIZATION_PRINCEK_THEME2_SKIN_FILL = (Color32)(-7753011);
		CHARACTERS_CUSTOMIZATION_PRINCEK_THEME2_SKIN_ICON = (Color32)(-1049940);
		CHARACTERS_CUSTOMIZATION_SAOPAULO_THEME1_SKIN_FILL = (Color32)(-10137345);
		CHARACTERS_CUSTOMIZATION_SAOPAULO_THEME1_SKIN_ICON = (Color32)(-9316865);
		CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME1_SKIN_FILL = (Color32)(-9249551);
		CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME1_SKIN_ICON = (Color32)(-15390549);
		CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME2_SKIN_FILL = (Color32)(-8888768);
		CHARACTERS_CUSTOMIZATION_LOSANGELES_THEME2_SKIN_ICON = (Color32)(-11554333);
		CHARACTERS_CUSTOMIZATION_SUN_SKIN_FILL = (Color32)(-15680260);
		CHARACTERS_CUSTOMIZATION_SUN_SKIN_ICON = (Color32)(-15190809);
		CHARACTERS_CUSTOMIZATION_CAIRO_THEME1_SKIN_FILL = (Color32)(-10251605);
		CHARACTERS_CUSTOMIZATION_CAIRO_THEME1_SKIN_ICON = (Color32)(-10887988);
		CHARACTERS_CUSTOMIZATION_HARUMI_THEME1_SKIN_FILL = (Color32)(-7778070);
		CHARACTERS_CUSTOMIZATION_HARUMI_THEME1_SKIN_ICON = (Color32)(-67999);
		CHARACTERS_CUSTOMIZATION_HARUMI_THEME2_SKIN_FILL = (Color32)(-15855591);
		CHARACTERS_CUSTOMIZATION_HARUMI_THEME2_SKIN_ICON = (Color32)(-14670656);
		CHARACTERS_CUSTOMIZATION_NINJA_THEME1_SKIN_FILL = (Color32)(-6771779);
		CHARACTERS_CUSTOMIZATION_NINJA_THEME1_SKIN_ICON = (Color32)(-2235158);
		CHARACTERS_CUSTOMIZATION_NINJA_THEME2_SKIN_FILL = (Color32)(-3446740);
		CHARACTERS_CUSTOMIZATION_NINJA_THEME2_SKIN_ICON = (Color32)(-13285534);
		CHARACTERS_CUSTOMIZATION_COCO_THEME1_SKIN_FILL = (Color32)(-10269376);
		CHARACTERS_CUSTOMIZATION_COCO_THEME1_SKIN_ICON = (Color32)(-14635452);
		CHARACTERS_CUSTOMIZATION_COCO_THEME2_SKIN_FILL = (Color32)(-6272099);
		CHARACTERS_CUSTOMIZATION_COCO_THEME2_SKIN_ICON = (Color32)(-2957333);
		CHARACTERS_CUSTOMIZATION_NEW_ORLEANS_THEME1_SKIN_FILL = (Color32)(-15986393);
		CHARACTERS_CUSTOMIZATION_NEW_ORLEANS_THEME1_SKIN_ICON = (Color32)(-15917112);
		CHARACTERS_CUSTOMIZATION_BANGKOK_THEME1_SKIN_FILL = (Color32)(-7721020);
		CHARACTERS_CUSTOMIZATION_BANGKOK_THEME1_SKIN_ICON = (Color32)(-10432257);
		CHARACTERS_CUSTOMIZATION_BANGKOK_THEME2_SKIN_FILL = (Color32)(-14733625);
		CHARACTERS_CUSTOMIZATION_BANGKOK_THEME2_SKIN_ICON = (Color32)(-12403738);
		CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME1_SKIN_FILL = (Color32)(-16249146);
		CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME1_SKIN_ICON = (Color32)(-6238246);
		CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME2_SKIN_FILL = (Color32)(-10131969);
		CHARACTERS_CUSTOMIZATION_LONDON_CHARACTER_02_THEME2_SKIN_ICON = (Color32)(-1974020);
		CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-10871266);
		CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-16777026);
		CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME2_SKIN_FILL = (Color32)(-14408408);
		CHARACTERS_CUSTOMIZATION_LAS_VEGAS_CHARACTER_01_THEME2_SKIN_ICON = (Color32)(-2889738);
		CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-3221674);
		CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-8049458);
		CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME2_SKIN_FILL = (Color32)(-14173970);
		CHARACTERS_CUSTOMIZATION_HAWAII_CHARACTER_01_THEME2_SKIN_ICON = (Color32)(-5756771);
		CHARACTERS_CUSTOMIZATION_MUMBAI_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-5849382);
		CHARACTERS_CUSTOMIZATION_MUMBAI_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-4761844);
		CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-998770);
		CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-7121466);
		CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME2_SKIN_FILL = (Color32)(-10632725);
		CHARACTERS_CUSTOMIZATION_ARABIA_CHARACTER_01_THEME2_SKIN_ICON = (Color32)(-5876432);
		CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-6666646);
		CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-11552518);
		CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME2_SKIN_FILL = (Color32)(-10670169);
		CHARACTERS_CUSTOMIZATION_VENICE_CHARACTER_01_THEME2_SKIN_ICON = (Color32)(-1971721);
		CHARACTERS_CUSTOMIZATION_CARMEN_THEME1_SKIN_FILL = (Color32)(-6545536);
		CHARACTERS_CUSTOMIZATION_CARMEN_THEME1_SKIN_ICON = (Color32)(-4964098);
		CHARACTERS_CUSTOMIZATION_CARMEN_THEME2_SKIN_FILL = (Color32)(-11552746);
		CHARACTERS_CUSTOMIZATION_CARMEN_THEME2_SKIN_ICON = (Color32)(-16003086);
		CHARACTERS_CUSTOMIZATION_KIM_THEME1_SKIN_FILL = (Color32)(-7023564);
		CHARACTERS_CUSTOMIZATION_KIM_THEME1_SKIN_ICON = (Color32)(-1443073);
		CHARACTERS_CUSTOMIZATION_KIM_THEME2_SKIN_FILL = (Color32)(-12967782);
		CHARACTERS_CUSTOMIZATION_KIM_THEME2_SKIN_ICON = (Color32)(-1590070);
		CHARACTERS_CUSTOMIZATION_GREECE_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-16002817);
		CHARACTERS_CUSTOMIZATION_GREECE_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-15394638);
		CHARACTERS_CUSTOMIZATION_KENYA_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-14238736);
		CHARACTERS_CUSTOMIZATION_KENYA_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-16351368);
		CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-14669354);
		CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-16777161);
		CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME2_SKIN_FILL = (Color32)(-13529142);
		CHARACTERS_CUSTOMIZATION_TRANSYLVANIA_CHARACTER_01_THEME2_SKIN_ICON = (Color32)(-15719056);
		CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-12328194);
		CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-13095707);
		CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME2_SKIN_FILL = (Color32)(-2403762);
		CHARACTERS_CUSTOMIZATION_SANFRANCISCO_CHARACTER_01_THEME2_SKIN_ICON = (Color32)(-197460);
		CHARACTERS_CUSTOMIZATION_PRAGUE_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-14276304);
		CHARACTERS_CUSTOMIZATION_PRAGUE_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-2596452);
		CHARACTERS_CUSTOMIZATION_MADAGASCAR_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-1592129);
		CHARACTERS_CUSTOMIZATION_MADAGASCAR_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-8573031);
		CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-2825175);
		CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-15911463);
		CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME2_SKIN_FILL = (Color32)(-12179226);
		CHARACTERS_CUSTOMIZATION_PERU_CHARACTER_01_THEME2_SKIN_ICON = (Color32)(-15418881);
		CHARACTERS_CUSTOMIZATION_SINGAPORE_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-13396994);
		CHARACTERS_CUSTOMIZATION_SINGAPORE_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-10203251);
		CHARACTERS_CUSTOMIZATION_ICELAND_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-620717);
		CHARACTERS_CUSTOMIZATION_ICELAND_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-16048959);
		CHARACTERS_CUSTOMIZATION_HAVANA_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-2536206);
		CHARACTERS_CUSTOMIZATION_HAVANA_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-1061759);
		CHARACTERS_CUSTOMIZATION_WASHINGTON_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-5554905);
		CHARACTERS_CUSTOMIZATION_WASHINGTON_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-15329567);
		CHARACTERS_CUSTOMIZATION_HOLIDAY_CHARACTER_2016_THEME1_SKIN_FILL = (Color32)(-14780205);
		CHARACTERS_CUSTOMIZATION_HOLIDAY_CHARACTER_2016_THEME1_SKIN_ICON = (Color32)(-3219473);
		CHARACTERS_CUSTOMIZATION_ELFTRICKY_CHARACTER_THEME1_SKIN_FILL = (Color32)(-2107577);
		CHARACTERS_CUSTOMIZATION_ELFTRICKY_CHARACTER_THEME1_SKIN_ICON = (Color32)(-1245697);
		CHARACTERS_CUSTOMIZATION_AMSTERDAM_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-7255751);
		CHARACTERS_CUSTOMIZATION_AMSTERDAM_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-9324202);
		CHARACTERS_CUSTOMIZATION_MONACO_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-16777036);
		CHARACTERS_CUSTOMIZATION_MONACO_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-16723201);
		CHARACTERS_CUSTOMIZATION_COPENHAGEN_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-4609202);
		CHARACTERS_CUSTOMIZATION_COPENHAGEN_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-12490453);
		CHARACTERS_CUSTOMIZATION_MARRAKESH_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-7597011);
		CHARACTERS_CUSTOMIZATION_MARRAKESH_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-7594286);
		CHARACTERS_CUSTOMIZATION_SHANGHAI_CHARACTER_01_THEME1_SKIN_FILL = (Color32)(-14467886);
		CHARACTERS_CUSTOMIZATION_SHANGHAI_CHARACTER_01_THEME1_SKIN_ICON = (Color32)(-12129281);
		HOVERBOARD_CUSTOMIZATION_BASE_SKIN_FILL = (Color32)(-4290250);
		HOVERBOARD_CUSTOMIZATION_BASE_SKIN_ICON = (Color32)(-11520498);
		HOVERBOARD_THEME_HERO_SUPER_JUMP_FILL = (Color32)(-16753711);
		HOVERBOARD_THEME_HERO_SUPER_JUMP_ICON = (Color32)(-12846637);
		HOVERBOARD_THEME_HERO_TELEPORT_FILL = (Color32)(-9282304);
		HOVERBOARD_THEME_HERO_TELEPORT_ICON = (Color32)(-4826);
		HOVERBOARD_THEME_STARBOARD_TRAIL_FILL = (Color32)(-16160943);
		HOVERBOARD_THEME_STARBOARD_TRAIL_ICON = (Color32)(-13698817);
		HOVERBOARD_THEME_STARBOARD_DOUBLE_JUMP_FILL = (Color32)(-6875003);
		HOVERBOARD_THEME_STARBOARD_DOUBLE_JUMP_ICON = (Color32)(-13309441);
		HOVERBOARD_THEME_GREAT_WHITE_SPEEDUP_FILL = (Color32)(-15000655);
		HOVERBOARD_THEME_GREAT_WHITE_SPEEDUP_ICON = (Color32)(-12980225);
		HOVERBOARD_THEME_GREAT_WHITE_GLIDER_FILL = (Color32)(-11961575);
		HOVERBOARD_THEME_GREAT_WHITE_GLIDER_ICON = (Color32)(-7667968);
		HOVERBOARD_THEME_SURF_BOARD_LOWRIDER_FILL = (Color32)(-5020110);
		HOVERBOARD_THEME_SURF_BOARD_LOWRIDER_ICON = (Color32)(-11403329);
		HOVERBOARD_THEME_SURF_BOARD_GLIDER_FILL = (Color32)(-11961575);
		HOVERBOARD_THEME_SURF_BOARD_GLIDER_ICON = (Color32)(-7667968);
		HOVERBOARD_THEME_MONSTER_SPEEDUP_FILL = (Color32)(-15000655);
		HOVERBOARD_THEME_MONSTER_SPEEDUP_ICON = (Color32)(-12980225);
		HOVERBOARD_THEME_MONSTER_JUMPER_FILL = (Color32)(-16753711);
		HOVERBOARD_THEME_MONSTER_JUMPER_ICON = (Color32)(-12846637);
		HOVERBOARD_THEME_FREESTYLER_DOUBLE_JUMP_FILL = (Color32)(-6875003);
		HOVERBOARD_THEME_FREESTYLER_DOUBLE_JUMP_ICON = (Color32)(-13309441);
		HOVERBOARD_THEME_FREESTYLER_SUPER_JUMP_FILL = (Color32)(-16753711);
		HOVERBOARD_THEME_FREESTYLER_SUPER_JUMP_ICON = (Color32)(-12846637);
		HOVERBOARD_THEME_MIAMI_PINK_TRAIL_FILL = (Color32)(-6993176);
		HOVERBOARD_THEME_MIAMI_PINK_TRAIL_ICON = (Color32)(-2508289);
		HOVERBOARD_THEME_MIAMI_SMOOTHDRIFT_FILL = (Color32)(-11961575);
		HOVERBOARD_THEME_MIAMI_SMOOTHDRIFT_ICON = (Color32)(-7667968);
		HOVERBOARD_THEME_SKULLFIRE_DOUBLE_JUMP_FILL = (Color32)(-6875003);
		HOVERBOARD_THEME_SKULLFIRE_DOUBLE_JUMP_ICON = (Color32)(-13309441);
		HOVERBOARD_THEME_SKULLFIRE_SPEEDUP_FILL = (Color32)(-15000655);
		HOVERBOARD_THEME_SKULLFIRE_SPEEDUP_ICON = (Color32)(-12980225);
		HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_FILL = (Color32)(-9282304);
		HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_ICON = (Color32)(-4826);
		HOVERBOARD_THEME_ROME_SPEEDUP_FILL = (Color32)(-15000655);
		HOVERBOARD_THEME_ROME_SPEEDUP_ICON = (Color32)(-12980225);
		HOVERBOARD_THEME_LUMBERJACK_DOUBLE_JUMP_FILL = (Color32)(-6875003);
		HOVERBOARD_THEME_LUMBERJACK_DOUBLE_JUMP_ICON = (Color32)(-13309441);
		HOVERBOARD_THEME_LUMBERJACK_LOWRIDER_FILL = (Color32)(-5020110);
		HOVERBOARD_THEME_LUMBERJACK_LOWRIDER_ICON = (Color32)(-11403329);
		HOVERBOARD_THEME_LONDONBOARD01_TRAIL_FILL = (Color32)(-7325409);
		HOVERBOARD_THEME_LONDONBOARD01_TRAIL_ICON = (Color32)(-598877);
		HOVERBOARD_THEME_LONDONBOARD01_SUPER_JUMP_FILL = (Color32)(-16753711);
		HOVERBOARD_THEME_LONDONBOARD01_SUPER_JUMP_ICON = (Color32)(-12846637);
		HOVERBOARD_THEME_CHICK_TRAIL_FILL = (Color32)(-15867141);
		HOVERBOARD_THEME_CHICK_TRAIL_ICON = (Color32)(-16757303);
		HOVERBOARD_THEME_CHICK_SPEEDUP_FILL = (Color32)(-15000655);
		HOVERBOARD_THEME_CHICK_SPEEDUP_ICON = (Color32)(-12980225);
		HOVERBOARD_THEME_VENICEBOARD02_GLIDER_FILL = (Color32)(-11961575);
		HOVERBOARD_THEME_VENICEBOARD02_GLIDER_ICON = (Color32)(-7667968);
		HOVERBOARD_THEME_SANFRANCISCOBOARD01_TRAIL_FILL = (Color32)(-6069779);
		HOVERBOARD_THEME_SANFRANCISCOBOARD01_TRAIL_ICON = (Color32)(-2836744);
		HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_FILL = (Color32)(-6069779);
		HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_ICON = (Color32)(-2836744);
		HOVERBOARD_THEME_ARABIABOARD01_TRAIL_FILL = (Color32)(-10386532);
		HOVERBOARD_THEME_ARABIABOARD01_TRAIL_ICON = (Color32)(-5323308);
		EVENTS_POPUP_STRIPES_JACKPOT = (Color32)1275068415;
		EVENTS_POPUP_STRIPES_NORMAL = (Color32)1262678783;
		COINS_ORIGINAL_COLOR = (Color32)(-1);
		COINS_LIGHT_PURPLE = (Color32)(-22832);
		COINS_DARK_PURPLE = (Color32)(-4579442);
		MULTIPLIER_LIGHT_PURPLE = (Color32)(-22832);
		MULTIPLIER_DARK_PURPLE = (Color32)(-4579442);
		COUNTRY_POPUP_TITLE_COLOUR = (Color32)(-8369664);
		COUNTRY_POPUP_SUBTITLE_COLOUR = (Color32)(-5934077);
		COUNTRY_POPUP_INFO_TEXT_COLOUR = (Color32)(-5934077);
		COUNTRY_POPUO_NORMAL_CELL_TEXT_COLOUR = (Color32)(-11326709);
		COUNTRY_POPUP_SELECTED_CELL_TEXT_COLOUR = (Color32)(-5934077);
		TOPRUN_ME_PLAYER_BACKGROUND_COLOUR = (Color32)(-866964725);
		TOPRUN_NORMAL_PLAYER_TEXT_COLOUR = (Color32)(-11326709);
		TOPRUN_SCREEN_TITLE_COLOUR = (Color32)(-8369664);
		TOPRUN_COUNTRY_NAME_COLOUR = (Color32)(-5934077);
		TOPRUN_PLAYER_TEXT_COLOUR = (Color32)(-11326709);
		TOPRUN_POPUP_TEXT_BACKGROUND_PURPLE = (Color32)(-6924433);
		TOPRUN_POPUP_DIAMOND_BACKGROUND = (Color32)(-3900008);
		TOPRUN_POPUP_GOLD_BACKGROUND = (Color32)(-14829057);
		TOPRUN_POPUP_SILVER_BACKGROUND = (Color32)(-1463979);
		TOPRUN_POPUP_BRONZE_BACKGROUND = (Color32)(-11104520);
		TOPRUN_RANK_HEADER_00_BACKGROUND_COLOUR = (Color32)(-6531984);
		TOPRUN_RANK_HEADER_00_TITLE_COLOUR = (Color32)(-5133);
		TOPRUN_RANK_HEADER_00_TITLE_SHADOW_COLOUR = (Color32)(-12582880);
		TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR = (Color32)2141737858;
		TOPRUN_PLAYER_BACKGOURD_00_LIGHT_COLOUR = (Color32)2145230795;
		TOPRUN_RANK_HEADER_10_BACKGROUND_COLOUR = (Color32)(-12012050);
		TOPRUN_RANK_HEADER_10_TITLE_COLOUR = (Color32)(-1705473);
		TOPRUN_RANK_HEADER_10_TITLE_SHADOW_COLOUR = (Color32)(-16745283);
		TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR = (Color32)2131803903;
		TOPRUN_PLAYER_BACKGOURD_10_LIGHT_COLOUR = (Color32)2140727551;
		TOPRUN_RANK_HEADER_20_BACKGROUND_COLOUR = (Color32)(-5407684);
		TOPRUN_RANK_HEADER_20_TITLE_COLOUR = (Color32)(-525);
		TOPRUN_RANK_HEADER_20_TITLE_SHADOW_COLOUR = (Color32)(-7910142);
		TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR = (Color32)2147460657;
		TOPRUN_PLAYER_BACKGOURD_20_LIGHT_COLOUR = (Color32)2146026634;
		TOPRUN_RANK_HEADER_30_BACKGROUND_COLOUR = (Color32)(-10448404);
		TOPRUN_RANK_HEADER_30_TITLE_COLOUR = (Color32)(-1);
		TOPRUN_RANK_HEADER_30_TITLE_SHADOW_COLOUR = (Color32)(-14526535);
		TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR = (Color32)2138416124;
		TOPRUN_PLAYER_BACKGOURD_30_LIGHT_COLOUR = (Color32)2144592639;
		TOPRUN_RANK_HEADER_40_BACKGROUND_COLOUR = (Color32)(-7240592);
		TOPRUN_RANK_HEADER_40_TITLE_COLOUR = (Color32)(-723724);
		TOPRUN_RANK_HEADER_40_TITLE_SHADOW_COLOUR = (Color32)(-9544898);
		TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR = (Color32)2142804333;
		TOPRUN_PLAYER_BACKGOURD_40_LIGHT_COLOUR = (Color32)2145372586;
		CHARACTERWORDEVENT_CELEBRATION_BLUE = (Color32)(-11326967);
		CHARACTERWORDEVENT_CELEBRATION_WHITE = (Color32)(-1);
		CHARACTERWORDEVENT_CELEBRATION_BLUESHADOW = (Color32)(-8432610);
		CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW = (Color32)(-10850);
		CHARACTERWORDEVENT_POPUP_NAME_ACTIVE = (Color32)(-1);
		CHARACTERWORDEVENT_POPUP_NAME_INACTIVE = (Color32)(-15569995);
		CHARACTERWORDEVENT_POPUP_NAME_SHADOW_ACTIVE = (Color32)(-16759409);
		CHARACTERWORDEVENT_POPUP_NAME_SHADOW_INACTIVE = (Color32)(-7543042);
		WELCOMEPOPUP_BUBBLE_COLOR = (Color32)(-2705865);
		WELCOMEPOPUP_BUBBLE_TEXT_COLOR = (Color32)(-4063746);
		EXCLUSIVE_HALLOWEEN_BACKGROUND_COLOR = (Color32)(-15248385);
		EXCLUSIVE_HALLOWEEN_LABEL_COLOR = (Color32)(-16194820);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1788 @ S4_v20 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UIButtonOverlayOff+ButtonType, ButtonColorScheme>>>)+4] (should have been resolved before IL gen)");
		object obj53 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		object obj54 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value = (ButtonColorScheme)(buttonColorScheme + 704);
		Dictionary<UIButtonOverlayOff.ButtonType, ButtonColorScheme> dictionary = default;
		dictionary.Add(UIButtonOverlayOff.ButtonType.Custom, value);
		object obj55 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FACEBOOK_COLOR_LIGHT;
		_ = FACEBOOK_COLOR_LIGHT;
		_ = 0;
		Color32? color = (Color32?)(object)(buttonColorScheme + 1320);
		Color32 value2 = (Color32)(buttonColorScheme + 700);
		*(Color32?*)(nint)color = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+528]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FACEBOOK_COLOR;
		_ = FACEBOOK_COLOR;
		_ = 0;
		Color32? color2 = (Color32?)(object)(buttonColorScheme + 1304);
		Color32 value3 = (Color32)(buttonColorScheme + 696);
		*(Color32?*)(nint)color2 = value3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+518]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+518]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value4 = (ButtonColorScheme)(buttonColorScheme + 664);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Facebook, value4);
		object obj56 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_BACK_COLOR_LIGHT;
		_ = FOOTER_BACK_COLOR_LIGHT;
		_ = 0;
		Color32? color3 = (Color32?)(object)(buttonColorScheme + 1288);
		Color32 value5 = (Color32)(buttonColorScheme + 660);
		*(Color32?*)(nint)color3 = value5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+508]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_BACK_COLOR;
		_ = FOOTER_BACK_COLOR;
		_ = 0;
		Color32? color4 = (Color32?)(object)(buttonColorScheme + 1272);
		Color32 value6 = (Color32)(buttonColorScheme + 656);
		*(Color32?*)(nint)color4 = value6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4F8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value7 = (ButtonColorScheme)(buttonColorScheme + 624);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Footer_back, value7);
		object obj57 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_SOCIAL_COLOR_LIGHT;
		_ = FOOTER_SOCIAL_COLOR_LIGHT;
		_ = 0;
		Color32? color5 = (Color32?)(object)(buttonColorScheme + 1256);
		Color32 value8 = (Color32)(buttonColorScheme + 620);
		*(Color32?*)(nint)color5 = value8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4E8]");
		_ = 0;
		_ = FOOTER_SOCIAL_COLOR_SELECTED;
		_ = FOOTER_SOCIAL_COLOR_SELECTED;
		_ = 0;
		Color32? color6 = (Color32?)(object)(buttonColorScheme + 1240);
		Color32 value9 = (Color32)(buttonColorScheme + 616);
		*(Color32?*)(nint)color6 = value9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4D8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_SOCIAL_COLOR;
		_ = FOOTER_SOCIAL_COLOR;
		_ = 0;
		Color32? color7 = (Color32?)(object)(buttonColorScheme + 1224);
		Color32 value10 = (Color32)(buttonColorScheme + 612);
		*(Color32?*)(nint)color7 = value10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4C8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value11 = (ButtonColorScheme)(buttonColorScheme + 576);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Footer_friends, value11);
		object obj58 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_ME_COLOR_LIGHT;
		_ = FOOTER_ME_COLOR_LIGHT;
		_ = 0;
		Color32? color8 = (Color32?)(object)(buttonColorScheme + 1208);
		Color32 value12 = (Color32)(buttonColorScheme + 572);
		*(Color32?*)(nint)color8 = value12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4B8]");
		_ = 0;
		_ = FOOTER_ME_COLOR_SELECTED;
		_ = FOOTER_ME_COLOR_SELECTED;
		_ = 0;
		Color32? color9 = (Color32?)(object)(buttonColorScheme + 1192);
		Color32 value13 = (Color32)(buttonColorScheme + 568);
		*(Color32?*)(nint)color9 = value13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+4A8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_ME_COLOR;
		_ = FOOTER_ME_COLOR;
		_ = 0;
		Color32? color10 = (Color32?)(object)(buttonColorScheme + 1176);
		Color32 value14 = (Color32)(buttonColorScheme + 564);
		*(Color32?*)(nint)color10 = value14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+498]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+498]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value15 = (ButtonColorScheme)(buttonColorScheme + 528);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Footer_me, value15);
		object obj59 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_SHOP_COLOR_LIGHT;
		_ = FOOTER_SHOP_COLOR_LIGHT;
		_ = 0;
		Color32? color11 = (Color32?)(object)(buttonColorScheme + 1160);
		Color32 value16 = (Color32)(buttonColorScheme + 524);
		*(Color32?*)(nint)color11 = value16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+488]");
		_ = 0;
		_ = FOOTER_SHOP_COLOR_SELECTED;
		_ = FOOTER_SHOP_COLOR_SELECTED;
		_ = 0;
		Color32? color12 = (Color32?)(object)(buttonColorScheme + 1144);
		Color32 value17 = (Color32)(buttonColorScheme + 520);
		*(Color32?*)(nint)color12 = value17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+478]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = FOOTER_SHOP_COLOR;
		_ = FOOTER_SHOP_COLOR;
		_ = 0;
		Color32? color13 = (Color32?)(object)(buttonColorScheme + 1128);
		Color32 value18 = (Color32)(buttonColorScheme + 516);
		*(Color32?*)(nint)color13 = value18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+468]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+468]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value19 = (ButtonColorScheme)(buttonColorScheme + 480);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Footer_shop, value19);
		object obj60 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GAMECENTER_COLOR_LIGHT;
		_ = GAMECENTER_COLOR_LIGHT;
		_ = 0;
		Color32? color14 = (Color32?)(object)(buttonColorScheme + 1112);
		Color32 value20 = (Color32)(buttonColorScheme + 476);
		*(Color32?*)(nint)color14 = value20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+458]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GAMECENTER_COLOR;
		_ = GAMECENTER_COLOR;
		_ = 0;
		Color32? color15 = (Color32?)(object)(buttonColorScheme + 1096);
		Color32 value21 = (Color32)(buttonColorScheme + 472);
		*(Color32?*)(nint)color15 = value21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+448]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+448]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value22 = (ButtonColorScheme)(buttonColorScheme + 440);
		dictionary.Add(UIButtonOverlayOff.ButtonType.GameCenter, value22);
		object obj61 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = PRIMARY_ACTION_COLOR_LIGHT;
		_ = PRIMARY_ACTION_COLOR_LIGHT;
		_ = 0;
		Color32? color16 = (Color32?)(object)(buttonColorScheme + 1080);
		Color32 value23 = (Color32)(buttonColorScheme + 436);
		*(Color32?*)(nint)color16 = value23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+438]");
		_ = 0;
		_ = PRIMARY_ACTION_COLOR_SELECTED;
		_ = PRIMARY_ACTION_COLOR_SELECTED;
		_ = 0;
		Color32? color17 = (Color32?)(object)(buttonColorScheme + 1064);
		Color32 value24 = (Color32)(buttonColorScheme + 432);
		*(Color32?*)(nint)color17 = value24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+428]");
		obj4 = 0;
		_ = PRIMARY_ACTION_COLOR_UNAVAILABLE;
		_ = PRIMARY_ACTION_COLOR_UNAVAILABLE;
		_ = 0;
		Color32? color18 = (Color32?)(object)(buttonColorScheme + 1048);
		Color32 value25 = (Color32)(buttonColorScheme + 428);
		*(Color32?*)(nint)color18 = value25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+418]");
		obj3 = 0;
		_ = PRIMARY_ACTION_COLOR;
		_ = PRIMARY_ACTION_COLOR;
		_ = 0;
		Color32? color19 = (Color32?)(object)(buttonColorScheme + 1032);
		Color32 value26 = (Color32)(buttonColorScheme + 424);
		*(Color32?*)(nint)color19 = value26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+408]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+408]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value27 = (ButtonColorScheme)(buttonColorScheme + 392);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Primary, value27);
		object obj62 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		object obj63 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value28 = (ButtonColorScheme)(buttonColorScheme + 360);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Primary_inactive, value28);
		object obj64 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = SEASONAL_COLOR_FILL_LIGHT;
		_ = SEASONAL_COLOR_FILL_LIGHT;
		_ = 0;
		Color32? color20 = (Color32?)(object)(buttonColorScheme + 1016);
		Color32 value29 = (Color32)(buttonColorScheme + 356);
		*(Color32?*)(nint)color20 = value29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = SEASONAL_COLOR_FILL_NORMAL;
		_ = SEASONAL_COLOR_FILL_NORMAL;
		_ = 0;
		Color32? color21 = (Color32?)(object)(buttonColorScheme + 1000);
		Color32 value30 = (Color32)(buttonColorScheme + 352);
		*(Color32?*)(nint)color21 = value30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3E8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value31 = (ButtonColorScheme)(buttonColorScheme + 320);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Seasonal, value31);
		object obj65 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = SECONDARY_ACTION_COLOR_LIGHT;
		_ = SECONDARY_ACTION_COLOR_LIGHT;
		_ = 0;
		Color32? color22 = (Color32?)(object)(buttonColorScheme + 984);
		Color32 value32 = (Color32)(buttonColorScheme + 316);
		*(Color32?*)(nint)color22 = value32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = SECONDARY_ACTION_COLOR;
		_ = SECONDARY_ACTION_COLOR;
		_ = 0;
		Color32? color23 = (Color32?)(object)(buttonColorScheme + 968);
		Color32 value33 = (Color32)(buttonColorScheme + 312);
		*(Color32?*)(nint)color23 = value33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3C8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value34 = (ButtonColorScheme)(buttonColorScheme + 280);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Secondary, value34);
		object obj66 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = SOCIAL_GRAY_OVERLAY;
		_ = SOCIAL_GRAY_OVERLAY;
		_ = 0;
		Color32? color24 = (Color32?)(object)(buttonColorScheme + 952);
		Color32 value35 = (Color32)(buttonColorScheme + 276);
		*(Color32?*)(nint)color24 = value35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = SOCIAL_GREY;
		_ = SOCIAL_GREY;
		_ = 0;
		Color32? color25 = (Color32?)(object)(buttonColorScheme + 936);
		Color32 value36 = (Color32)(buttonColorScheme + 272);
		*(Color32?*)(nint)color25 = value36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3A8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+3A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value37 = (ButtonColorScheme)(buttonColorScheme + 240);
		dictionary.Add(UIButtonOverlayOff.ButtonType.SocialGrey, value37);
		object obj67 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = TERTIARY_ACTION_COLOR_LIGHT;
		_ = TERTIARY_ACTION_COLOR_LIGHT;
		_ = 0;
		Color32? color26 = (Color32?)(object)(buttonColorScheme + 920);
		Color32 value38 = (Color32)(buttonColorScheme + 236);
		*(Color32?*)(nint)color26 = value38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+398]");
		_ = 0;
		_ = TERTIARY_ACTION_COLOR_SELECTED;
		_ = TERTIARY_ACTION_COLOR_SELECTED;
		_ = 0;
		Color32? color27 = (Color32?)(object)(buttonColorScheme + 904);
		Color32 value39 = (Color32)(buttonColorScheme + 232);
		*(Color32?*)(nint)color27 = value39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+388]");
		obj4 = 0;
		_ = TERTIARY_ACTION_COLOR_UNAVAILABLE;
		_ = TERTIARY_ACTION_COLOR_UNAVAILABLE;
		_ = 0;
		Color32? color28 = (Color32?)(object)(buttonColorScheme + 888);
		Color32 value40 = (Color32)(buttonColorScheme + 228);
		*(Color32?*)(nint)color28 = value40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+378]");
		obj3 = 0;
		_ = TERTIARY_ACTION_COLOR;
		_ = TERTIARY_ACTION_COLOR;
		_ = 0;
		Color32? color29 = (Color32?)(object)(buttonColorScheme + 872);
		Color32 value41 = (Color32)(buttonColorScheme + 224);
		*(Color32?*)(nint)color29 = value41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+368]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+368]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value42 = (ButtonColorScheme)(buttonColorScheme + 192);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Tertiary, value42);
		object obj68 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		object obj69 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value43 = (ButtonColorScheme)(buttonColorScheme + 160);
		dictionary.Add(UIButtonOverlayOff.ButtonType.Tertiary_inactive, value43);
		object obj70 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GlobalColorsGenerated.WEEKLYHUNT_MENU_BUTTON_OVERLAY;
		_ = GlobalColorsGenerated.WEEKLYHUNT_MENU_BUTTON_OVERLAY;
		_ = 0;
		Color32? color30 = (Color32?)(object)(buttonColorScheme + 856);
		Color32 value44 = (Color32)(buttonColorScheme + 156);
		*(Color32?*)(nint)color30 = value44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GlobalColorsGenerated.WEEKLYHUNT_MENU_BUTTON;
		_ = GlobalColorsGenerated.WEEKLYHUNT_MENU_BUTTON;
		_ = 0;
		Color32? color31 = (Color32?)(object)(buttonColorScheme + 840);
		Color32 value45 = (Color32)(buttonColorScheme + 152);
		*(Color32?*)(nint)color31 = value45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+348]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+348]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value46 = (ButtonColorScheme)(buttonColorScheme + 120);
		dictionary.Add(UIButtonOverlayOff.ButtonType.WeeklyHunt, value46);
		object obj71 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GlobalColorsGenerated.LIMITED_CHARACTER_POPUP_BUTTON_OVERLAY;
		_ = GlobalColorsGenerated.LIMITED_CHARACTER_POPUP_BUTTON_OVERLAY;
		_ = 0;
		Color32? color32 = (Color32?)(object)(buttonColorScheme + 824);
		Color32 value47 = (Color32)(buttonColorScheme + 116);
		*(Color32?*)(nint)color32 = value47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+338]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GlobalColorsGenerated.LIMITED_CHARACTER_POPUP_BUTTON;
		_ = GlobalColorsGenerated.LIMITED_CHARACTER_POPUP_BUTTON;
		_ = 0;
		Color32? color33 = (Color32?)(object)(buttonColorScheme + 808);
		Color32 value48 = (Color32)(buttonColorScheme + 112);
		*(Color32?*)(nint)color33 = value48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+328]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+328]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value49 = (ButtonColorScheme)(buttonColorScheme + 80);
		dictionary.Add(UIButtonOverlayOff.ButtonType.LimitedCharacterPopup, value49);
		object obj72 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GlobalColorsGenerated.LIMITED_BOARD_POPUP_BUTTON_OVERLAY;
		_ = GlobalColorsGenerated.LIMITED_BOARD_POPUP_BUTTON_OVERLAY;
		_ = 0;
		Color32? color34 = (Color32?)(object)(buttonColorScheme + 792);
		Color32 value50 = (Color32)(buttonColorScheme + 76);
		*(Color32?*)(nint)color34 = value50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+318]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = GlobalColorsGenerated.LIMITED_BOARD_POPUP_BUTTON;
		_ = GlobalColorsGenerated.LIMITED_BOARD_POPUP_BUTTON;
		_ = 0;
		Color32? color35 = (Color32?)(object)(buttonColorScheme + 776);
		Color32 value51 = (Color32)(buttonColorScheme + 72);
		*(Color32?*)(nint)color35 = value51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+308]");
		obj2 = 0;
		object obj73 = buttonColorScheme - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+308]");
		obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		_ = 0;
		ButtonColorScheme value52 = (ButtonColorScheme)(buttonColorScheme + 40);
		dictionary.Add(UIButtonOverlayOff.ButtonType.LimitedBoardPopup, value52);
		object obj74 = buttonColorScheme + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = EXIT_COLOR_LIGHT;
		_ = EXIT_COLOR_LIGHT;
		_ = 0;
		Color32? color36 = (Color32?)(object)(buttonColorScheme + 760);
		Color32 value53 = (Color32)(buttonColorScheme + 36);
		*(Color32?*)(nint)color36 = value53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+2F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = EXIT_COLOR;
		_ = EXIT_COLOR;
		_ = 0;
		Color32? color37 = (Color32?)(object)(buttonColorScheme + 744);
		Color32 value54 = (Color32)(buttonColorScheme + 32);
		*(Color32?*)(nint)color37 = value54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+2E8]");
		obj2 = 0;
		((ButtonColorScheme*)(nint)buttonColorScheme)->selected = (Color32?)obj4;
		((ButtonColorScheme*)(nint)buttonColorScheme)->unavailable = (Color32?)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+2E8]");
		((ButtonColorScheme*)(nint)buttonColorScheme)->original = (Color32?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ButtonColorScheme)+530]");
		((ButtonColorScheme*)(nint)buttonColorScheme)->light = (Color32?)(object)0;
		dictionary.Add(UIButtonOverlayOff.ButtonType.Exit, buttonColorScheme);
		buttonColorData = dictionary;
	}
}
