namespace UI.Screens;

public class LeaderboardScreenManager
{
	public enum LeaderboardScreenState
	{
		Offline = 0,
		Facebook = 1,
		GameCenter = 2,
		FacebookAndGamecenter = 3,
		AgeRestricted = 4,
	}

	private static LeaderboardScreenManager _instance; //Field offset: 0x0
	public Action<LeaderboardScreenState> OnLeaderboardScreenStateChangedEvent; //Field offset: 0x8
	private LeaderboardScreenState _screenState; //Field offset: 0xC

	public static LeaderboardScreenManager Instance
	{
		 get { } //Length: 351
	}

	public static bool isInitialized
	{
		 get { } //Length: 217
	}

	public LeaderboardScreenState screenState
	{
		 get { } //Length: 683
		private set { } //Length: 9
	}

	private static LeaderboardScreenManager() { }

	public LeaderboardScreenManager() { }

	public static LeaderboardScreenManager get_Instance() { }

	public static bool get_isInitialized() { }

	public LeaderboardScreenState get_screenState() { }

	private void ScreenStateChanged(LeaderboardScreenState newState) { }

	private void set_screenState(LeaderboardScreenState value) { }

	private void UpdateScreenState() { }

}

