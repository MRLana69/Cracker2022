namespace Info;

public static class FacebookRewardsInfo
{
	public enum FacebookRewardType
	{
		Coins = 0,
	}

	public static int POPUP_DISPLAY_TIME_LIMIT; //Field offset: 0x0
	public static int POPUP_DISPLAY_RUN_LIMIT; //Field offset: 0x4
	public static string FACEBOOK_REWARD_RUN_LIMIT_KEY; //Field offset: 0x8
	public static string FACEBOOK_REWARD_TIME_LIMIT_KEY; //Field offset: 0xC
	public static int characterTheme; //Field offset: 0x10
	public static DateTime connectPopupLastShownOnGameOver; //Field offset: 0x18
	public static DateTime connectPopupLastShownOnFriendsScreen; //Field offset: 0x20
	public static Dictionary<FacebookRewardType, int> facebookRewardPack; //Field offset: 0x28

	private static FacebookRewardsInfo() { }

	public static bool ShouldShowConnectPopupOnFriendsScreen() { }

	public static bool ShouldShowConnectPopupOnGameOver(int showCounter) { }

}

