//Type is in global namespace

public static class AdLocations
{
	public static readonly AdLocationInfo POOL1_VIDEOS; //Field offset: 0x0
	public static readonly AdLocationInfo POOL2_VIDEOS; //Field offset: 0x4
	public static readonly AdLocationInfo POOL3_VIDEOS; //Field offset: 0x8
	public static readonly AdLocationInfo HOME_INTERSTITIALS; //Field offset: 0xC
	public static readonly AdLocationInfo HOME_VIDEOS; //Field offset: 0x10
	public static readonly AdLocationInfo GAME_OVER_INTERSTITIALS; //Field offset: 0x14
	public static readonly AdLocationInfo EARN_COINS_VIDEOS; //Field offset: 0x18
	public static readonly AdLocationInfo DOUBLE_UP_VIDEOS; //Field offset: 0x1C
	public static readonly AdLocationInfo WORDY_WEEKEND_VIDEOS; //Field offset: 0x20
	public static readonly AdLocationInfo BOARD_BUTTON_VIDEOS; //Field offset: 0x24
	public static readonly AdLocationInfo REVIVAL_VIDEOS; //Field offset: 0x28
	public static readonly AdLocationInfo GAMEOVER_DOUBLE_COINS_VIDEOS; //Field offset: 0x2C
	public static readonly AdLocationInfo HOVERBOARD_POPUP_VIDEOS; //Field offset: 0x30
	public static readonly AdLocationInfo HOVERBOARD_FREE_VIDEOS; //Field offset: 0x34
	public static readonly AdLocationInfo HOVERBOARD_RUN_VIDEOS; //Field offset: 0x38
	public static readonly AdLocationInfo SKIP_MISSION_PAUSE_VIDEOS; //Field offset: 0x3C
	public static readonly AdLocationInfo SKIP_MISSION_TOUR_VIDEOS; //Field offset: 0x40
	public static readonly AdLocationInfo FREE_COINS_FREE_VIDEOS; //Field offset: 0x44
	public static readonly AdLocationInfo FREE_COINS_POPUP_VIDEOS; //Field offset: 0x48
	public static readonly AdLocationInfo HEADSTART_FREE_VIDEOS; //Field offset: 0x4C
	public static readonly AdLocationInfo HEADSTART_RUN_VIDEOS; //Field offset: 0x50
	public static readonly AdLocationInfo SCOREBOOSTER_FREE_VIDEOS; //Field offset: 0x54
	public static readonly AdLocationInfo SCOREBOOSTER_RUN_VIDEOS; //Field offset: 0x58
	public static ICollection<AdLocationInfo> adLocations; //Field offset: 0x5C

	private static AdLocations() { }

	private static AdLocationInfo NewAdLocation(string id, AdType type, bool isPoolLocation) { }

}

