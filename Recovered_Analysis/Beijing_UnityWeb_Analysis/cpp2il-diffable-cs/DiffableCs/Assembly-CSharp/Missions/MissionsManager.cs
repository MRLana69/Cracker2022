namespace Missions;

public class MissionsManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair<UpgradeType, int>, int> <>9__37_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <SyncAchievements>b__37_0(KeyValuePair<UpgradeType, int> x) { }

	}

	public delegate MissionCompleteHandler
	{

		public MissionCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string msg, int missionIndex, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string msg, int missionIndex) { }

	}

	public delegate MissionProgressHandler
	{

		public MissionProgressHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int missionIndex, float progressFactor, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(int missionIndex, float progressFactor) { }

	}

	public delegate MissionSetCompleteHandler
	{

		public MissionSetCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public enum VideoButtonTrackingState
	{
		NotSet = 0,
		Fill = 1,
		NoFill = 2,
		Cooldown = 3,
		AlreadyUsedForSet = 4,
	}

	private const int MISSION_COUNT_IN_SET = 3; //Field offset: 0x0
	private const string OS_SKIP_WITH_VIDEO_COOLDOWN_VALUE_KEY = "mission_skip_with_video_cooldown_seconds"; //Field offset: 0x0
	private static MissionSetCompleteHandler onMissionSetComplete; //Field offset: 0x0
	private const string OS_MISSION_INDEX_UPDATE_INTERVAL = "mission_skip_with_video_index_update_interval_seconds"; //Field offset: 0x0
	private static MissionCompleteHandler onMissionComplete; //Field offset: 0x4
	private static MissionsManager _instance; //Field offset: 0x8
	private int _currentMissionTemplateSetLoaded; //Field offset: 0x8
	private MissionTemplate[] _templates; //Field offset: 0xC
	private int _defaultSkipWithVideoCooldownSeconds; //Field offset: 0x10
	private int _defaultMissionIndexUpdateInterval; //Field offset: 0x14
	private VideoButtonTrackingState <videoButtonState>k__BackingField; //Field offset: 0x18
	public Action<bool, int> OnMissionSkipped; //Field offset: 0x1C
	private int[] _currentRunProgress; //Field offset: 0x20
	private int _currentMissionSetLoaded; //Field offset: 0x24
	private Mission[] _combinedArray; //Field offset: 0x28
	public MissionProgressHandler onMissionProgressed; //Field offset: 0x2C
	private Mission[][] _missions; //Field offset: 0x30

	public static event MissionCompleteHandler onMissionComplete
	{
		 add { } //Length: 126
		 remove { } //Length: 129
	}

	public static event MissionSetCompleteHandler onMissionSetComplete
	{
		 add { } //Length: 1287
		 remove { } //Length: 126
	}

	private Mission[] combinedArray
	{
		 get { } //Length: 346
	}

	public int currentMissionSet
	{
		 get { } //Length: 98
		 set { } //Length: 67
	}

	public bool inRun
	{
		 get { } //Length: 490
		 set { } //Length: 8
	}

	public static MissionsManager Instance
	{
		 get { } //Length: 223
	}

	private Mission[][] missions
	{
		 get { } //Length: 556
	}

	public int missionSetCount
	{
		 get { } //Length: 92
	}

	public int missionSetStoryCount
	{
		 get { } //Length: 12
	}

	private MissionTemplate[] templates
	{
		 get { } //Length: 6
	}

	public VideoButtonTrackingState videoButtonState
	{
		 get { } //Length: 144
		private set { } //Length: 8
	}

	private MissionsManager() { }

	private void <.ctor>b__71_0(RefreshType type) { }

	public static void add_onMissionComplete(MissionCompleteHandler value) { }

	public static void add_onMissionSetComplete(MissionSetCompleteHandler value) { }

	private void ApplyChangesForVersion(int versionNumber) { }

	private void ApplyChangesToProgressIfNecessary() { }

	private static int ApplyCoinDoublers(int value) { }

	public bool CanThisMissionSkipWithVideo(MissionCellPayload payload) { }

	private void CheckAllCompleteAndIncrement() { }

	private void Complete(int index, float completedFactor = 1, bool sendEvenIfInRun = false) { }

	private void DetermineNewSkipForVideoMissionIndex() { }

	private Mission[] get_combinedArray() { }

	public int get_currentMissionSet() { }

	public bool get_inRun() { }

	public static MissionsManager get_Instance() { }

	private Mission[][] get_missions() { }

	public int get_missionSetCount() { }

	public int get_missionSetStoryCount() { }

	private MissionTemplate[] get_templates() { }

	public VideoButtonTrackingState get_videoButtonState() { }

	public static AdLocationInfo GetCurrentLocationInfo(bool isInGame) { }

	public MissionInfo[] GetMissionInfo() { }

	public MissionInfo GetMissionInfo(int missionNumber) { }

	private void GetMissionInfo(int missionNumber, ref MissionInfo info) { }

	public MissionInfo[] GetNextMissionInfos() { }

	public int GetNumberOfBasicMission() { }

	public void InitCurrentMissionSet(int missionSet, int missionCount, bool resetProgress) { }

	public bool IsMissionTargetActive(MissionTarget target) { }

	private static bool IsOneOf(MissionTarget needle, MissionTarget[] haystack) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private void LogMissionSetRuns() { }

	private static void LogWarning(string msg, Object context = null) { }

	private bool MissionIndexNeedsUpdating() { }

	public void OnChangeIsCharacterOnGround(Character character) { }

	private void OverWriteAchievementsProgress(MissionTarget myTask, int value) { }

	public void PlayerDidThis(MissionTarget myTask, int value = 1, int missionToIgnore = -1) { }

	public static void remove_onMissionComplete(MissionCompleteHandler value) { }

	public static void remove_onMissionSetComplete(MissionSetCompleteHandler value) { }

	public void RemoveProgressForThis(MissionTarget myTask) { }

	private void ResetProgressForMissionIndex(int questIndex) { }

	public void set_currentMissionSet(int value) { }

	public void set_inRun(bool value) { }

	private void set_videoButtonState(VideoButtonTrackingState value) { }

	private void SetupDefaultMissionSetIfNeeded() { }

	public void SkipMission(int missionNumber, bool skippedWithVideo) { }

	private void SyncAchievements() { }

	private void TestGoToMissionSum(int mission) { }

	private static void ValidateMissions() { }

}

