namespace Data.Save;

public class PlayerSave
{
	private static Action highScoreChanged; //Field offset: 0x0
	private static int <bragScoreThreshold>k__BackingField; //Field offset: 0x4
	private static Action<Stat, int> statChanged; //Field offset: 0x8

	public static event Action highScoreChanged
	{
		 add { } //Length: 95
		 remove { } //Length: 126
	}

	public static event Action<Stat, int> statChanged
	{
		 add { } //Length: 96
		 remove { } //Length: 129
	}

	public static Dictionary<AwardId, bool> awardHasPayedOut
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static Dictionary<AwardId, bool> awardIsNew
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static bool awardsFirstLoaded
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static Dictionary<AwardId, PersistentAwardProgress> awardsProgress
	{
		 get { } //Length: 95
		 set { } //Length: 61
	}

	public static int bragScoreThreshold
	{
		 get { } //Length: 50
		 set { } //Length: 72
	}

	public static int completedRunCount
	{
		 get { } //Length: 51
		 set { } //Length: 73
	}

	public static BoardId currentBoardId
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static CharacterId currentCharacterId
	{
		 get { } //Length: 83
		 set { } //Length: 85
	}

	public static int currentMissionSet
	{
		 get { } //Length: 50
		 set { } //Length: 52
	}

	public static int currentOutfitIndex
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static DateTime currentSkipForVideoIndexSetAt
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int currentSkipForVideoMissionIndex
	{
		 get { } //Length: 53
		 set { } //Length: 55
	}

	public static bool hasSkippedMissionForVideoThisSet
	{
		 get { } //Length: 50
		 set { } //Length: 95
	}

	public static int highScore
	{
		 get { } //Length: 50
	}

	public static DateTime lastTimeMissionWasSkippedForVideo
	{
		 get { } //Length: 50
		 set { } //Length: 53
	}

	public static int missionSetCompletedCount
	{
		 get { } //Length: 53
		 set { } //Length: 73
	}

	public static int missionsVersion
	{
		 get { } //Length: 101
		 set { } //Length: 52
	}

	public static BoardId previousBoardId
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int runsCompletedInCurrentMissionsSet
	{
		 get { } //Length: 43
		 set { } //Length: 49
	}

	public static int unreportedGames
	{
		 get { } //Length: 50
		 set { } //Length: 52
	}

	public static DateTime unreportedGamesTimeStamp
	{
		 get { } //Length: 50
		 set { } //Length: 53
	}

	public static DateTime weeklyGiftUnlockTime
	{
		 get { } //Length: 50
		 set { } //Length: 53
	}

	public PlayerSave() { }

	public static void add_highScoreChanged(Action value) { }

	public static void add_statChanged(Action<Stat, int> value) { }

	public static Dictionary<AwardId, bool> get_awardHasPayedOut() { }

	public static Dictionary<AwardId, bool> get_awardIsNew() { }

	public static bool get_awardsFirstLoaded() { }

	public static Dictionary<AwardId, PersistentAwardProgress> get_awardsProgress() { }

	public static int get_bragScoreThreshold() { }

	public static int get_completedRunCount() { }

	public static BoardId get_currentBoardId() { }

	public static CharacterId get_currentCharacterId() { }

	public static int get_currentMissionSet() { }

	public static int get_currentOutfitIndex() { }

	public static DateTime get_currentSkipForVideoIndexSetAt() { }

	public static int get_currentSkipForVideoMissionIndex() { }

	public static bool get_hasSkippedMissionForVideoThisSet() { }

	public static int get_highScore() { }

	public static DateTime get_lastTimeMissionWasSkippedForVideo() { }

	public static int get_missionSetCompletedCount() { }

	public static int get_missionsVersion() { }

	public static BoardId get_previousBoardId() { }

	public static int get_runsCompletedInCurrentMissionsSet() { }

	public static int get_unreportedGames() { }

	public static DateTime get_unreportedGamesTimeStamp() { }

	public static DateTime get_weeklyGiftUnlockTime() { }

	public static int GetAchievementProgress(int index) { }

	public static int GetCurrentMissionProgress(int index) { }

	public static int GetMysteryBoxesOpened(Type type) { }

	public static int GetStatValue(Stat stat) { }

	public static int GetTrophyAchievementProgressCount() { }

	public static bool HasSkippedMission(int index) { }

	public static void IncrementMysteryBoxesOpened(Type type) { }

	public static void InitializeCurrentMissionProgress(int count) { }

	public static void LoadAchievementProgress(int[] savedArray) { }

	public static void LoadCurrentMissionProgress(int[] savedArray) { }

	public static void MigrateMysteryBoxOpened(Type type, int value) { }

	public static void remove_highScoreChanged(Action value) { }

	public static void remove_statChanged(Action<Stat, int> value) { }

	public static void ResetSkipMissions() { }

	public static void set_awardHasPayedOut(Dictionary<AwardId, bool> value) { }

	public static void set_awardIsNew(Dictionary<AwardId, bool> value) { }

	public static void set_awardsFirstLoaded(bool value) { }

	public static void set_awardsProgress(Dictionary<AwardId, PersistentAwardProgress> value) { }

	public static void set_bragScoreThreshold(int value) { }

	public static void set_completedRunCount(int value) { }

	public static void set_currentBoardId(BoardId value) { }

	public static void set_currentCharacterId(CharacterId value) { }

	public static void set_currentMissionSet(int value) { }

	public static void set_currentOutfitIndex(int value) { }

	public static void set_currentSkipForVideoIndexSetAt(DateTime value) { }

	public static void set_currentSkipForVideoMissionIndex(int value) { }

	public static void set_hasSkippedMissionForVideoThisSet(bool value) { }

	public static void set_lastTimeMissionWasSkippedForVideo(DateTime value) { }

	public static void set_missionSetCompletedCount(int value) { }

	public static void set_missionsVersion(int value) { }

	public static void set_previousBoardId(BoardId value) { }

	public static void set_runsCompletedInCurrentMissionsSet(int value) { }

	public static void set_unreportedGames(int value) { }

	public static void set_unreportedGamesTimeStamp(DateTime value) { }

	public static void set_weeklyGiftUnlockTime(DateTime value) { }

	public static void SetCurrentMissionProgress(int index, int value) { }

	public static void SetHighScore(int value) { }

	public static void SetSkipMission(int index, bool skip) { }

	public static void SetStatValue(Stat stat, int value) { }

	public static void UnlockTrophy(Trophy trophy) { }

}

