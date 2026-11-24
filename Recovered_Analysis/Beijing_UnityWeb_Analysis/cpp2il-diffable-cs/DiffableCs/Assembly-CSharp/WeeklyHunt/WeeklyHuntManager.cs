namespace WeeklyHunt;

public static class WeeklyHuntManager
{
	private static bool _hasInited; //Field offset: 0x0
	private static Action itemCountUpdated; //Field offset: 0x4
	public static Vector3 HUNT_ITEM_POSITION_OFFSET; //Field offset: 0x8
	public static Vector3 HUNT_ITEM_ROTATION; //Field offset: 0x14
	public static Vector3 HUNT_ITEM_SCALE_OFFSET; //Field offset: 0x20
	public static bool canCollectAllTokensInOneRun; //Field offset: 0x2C

	public static event Action itemCountUpdated
	{
		 add { } //Length: 619
		 remove { } //Length: 209
	}

	private static Dictionary<int, WeeklyHuntPeriodData> huntPeriodData
	{
		 get { } //Length: 99
	}

	private static WeeklyHuntManager() { }

	public static void add_itemCountUpdated(Action value) { }

	public static bool CanSpawnToken() { }

	public static WeeklyHuntPrize DeterminePrize(PrizeData prizeData) { }

	public static string Get(PrizeData prizeData) { }

	private static Dictionary<int, WeeklyHuntPeriodData> get_huntPeriodData() { }

	public static DateTime GetEndTimeForActivePeriod() { }

	public static bool GetHiddenUntilUnlockedForPeriod(PrizePeriodId period) { }

	public static PeriodStatus GetPeriodStatus(PrizePeriodId period) { }

	public static int GetPrizeDataCount() { }

	public static WeeklyHuntPeriodData GetPrizeDataForPeriod(PrizePeriodId period) { }

	public static PrizeData GetPrizeForPeriod(PrizePeriodId periodId) { }

	public static string GetPrizeTitle(PrizeData prizeData) { }

	public static string GetPrizeTitleShort(PrizeData prizeData) { }

	private static CelebrationReward GetRewardForPeriod(PrizePeriodId period) { }

	public static TimeSpan GetTimeLeftForActivePeriod() { }

	private static void InitIfNeeded() { }

	public static bool IsAnyPeriodActive() { }

	public static bool IsBoardAwardedInCurrentPeriod(BoardId boardId) { }

	public static bool IsHuntStillActive() { }

	public static void ItemPickedUp() { }

	public static int ItemsCollectedForBoardType(BoardId boardId) { }

	public static int ItemsToCollectForBoardType(BoardId boardId) { }

	private static void OnRunEnded() { }

	private static void OnRunStarted() { }

	private static void OnWeekCompleted() { }

	public static void remove_itemCountUpdated(Action value) { }

}

