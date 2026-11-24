namespace WeeklyHunt;

public static class WeeklyHuntData
{
	public enum PeriodStatus
	{
		Unstarted = 0,
		Expired = 1,
		Current = 2,
	}

	public struct PrizeData
	{
		public int amount; //Field offset: 0x0
		public CelebrationRewardOrigin celebrationRewardOrigin; //Field offset: 0x4
		public CelebrationRewardType rewardType; //Field offset: 0x8
		public UpgradeType upgradeType; //Field offset: 0xC
		public CharacterId characterId; //Field offset: 0x10
		public BoardId boardId; //Field offset: 0x14
		public Trophy trophyType; //Field offset: 0x18

	}

	public enum PrizePeriodId
	{
		None = 0,
		PeriodOne = 1,
		PeriodTwo = 2,
		PeriodThree = 3,
		PeriodFour = 4,
	}

	public class WeeklyHuntPeriodData
	{
		public int itemsToCollect; //Field offset: 0x8
		public int itemsCollected; //Field offset: 0xC
		public bool hiddenUntilUnlocked; //Field offset: 0x10
		public string periodTitle; //Field offset: 0x14
		public DateTime periodStartDate; //Field offset: 0x18
		public DateTime periodEndDate; //Field offset: 0x20
		public PrizeData mainPrize; //Field offset: 0x28

		public WeeklyHuntPeriodData() { }

	}

	public enum WeeklyHuntPrize
	{
		NotAvailable = 0,
		Key = 1,
		SuperMysteryBox = 2,
		Hoverboard = 3,
		ScoreBooster = 4,
		Headstart = 5,
		ChristmasBoard = 6,
		RioBoard2 = 7,
		NorthpoleBoard2016 = 8,
		CherryBoard = 9,
	}

	public static bool hideLastPeriod; //Field offset: 0x0
	private const string DEBUG_TIME_OFFSET_PLAYER_PREFS_KEY = "WEEKLY_HUNT_TIME_OFFSET"; //Field offset: 0x0
	private static bool _hasInited; //Field offset: 0x1
	private static Dictionary<int, WeeklyHuntPeriodData> _huntPeriodData; //Field offset: 0x4

	public static DateTime startChallengeDateTime
	{
		 get { } //Length: 63
	}

	private static WeeklyHuntData() { }

	private static void ApplyDebugTimeOffset() { }

	public static void DebugJumpToWeek(int period, int additionalOffset) { }

	public static void DebugResetWeeklyHuntData() { }

	public static void DebugSetProgress(int period, int progress) { }

	private static void FlurryLogCurrentUpdatesWeeklyHuntPeriodProgress() { }

	private static void FlurryLogPreviousUpdatesWeeklyHuntPeriodProgress() { }

	public static DateTime get_startChallengeDateTime() { }

	public static PrizePeriodId GetActivePeriod() { }

	public static Dictionary<int, WeeklyHuntPeriodData> GetHuntData() { }

	private static void Init() { }

	public static void LoadProgressFromResources() { }

	public static void SaveNewProgress(bool shouldStartNewProgress) { }

	private static bool ShouldResetChallengeData(string currentStartDate) { }

}

