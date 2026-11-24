namespace UI.Screens;

public class PauseScreen : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MissionInfo, bool> <>9__56_0; //Field offset: 0x4
		public static Action<MissionCell> <>9__74_0; //Field offset: 0x8
		public static Action<MissionCell> <>9__75_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal void <DestroyOtherMissionCells>b__75_0(MissionCell cell) { }

		internal void <ResetCellPositions>b__74_0(MissionCell c) { }

		internal bool <Show>b__56_0(MissionInfo m) { }

	}

	private sealed class <>c__DisplayClass79_0
	{
		public PauseScreen <>4__this; //Field offset: 0x8
		public List<MissionCell> newMissionCells; //Field offset: 0xC
		public float inStartPosition; //Field offset: 0x10
		public float mainPosition; //Field offset: 0x14
		public List<MissionCell> oldMissionsCells; //Field offset: 0x18
		public float outEndPosition; //Field offset: 0x1C

		public <>c__DisplayClass79_0() { }

		internal void <AnimateNewMissionSet>b__0() { }

		internal void <AnimateNewMissionSet>b__1() { }

		internal void <AnimateNewMissionSet>b__2() { }

		internal void <AnimateNewMissionSet>b__3() { }

	}

	private sealed class <AnimateCell>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PauseScreen <>4__this; //Field offset: 0x10
		public Transform cellTransform; //Field offset: 0x14
		public float startX; //Field offset: 0x18
		public float endX; //Field offset: 0x1C
		public Action onComplete; //Field offset: 0x20
		private float <currentDuration>5__2; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 309
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateCell>d__80(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <MissionCompleteAnimation>d__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int completedMissionsCount; //Field offset: 0x10
		public PauseScreen <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 432
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MissionCompleteAnimation>d__78(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const int NUMBER_OF_MISSIONS_IN_SET = 3; //Field offset: 0x0
	private const int MAX_MULTIPLIER = 30; //Field offset: 0x0
	private static readonly Vector3 DIAMOND_POSITION; //Field offset: 0x0
	private const float MODEL_SCALE = 0.75; //Field offset: 0x0
	private static readonly Vector3 DIAMOND_ROTATION; //Field offset: 0xC
	private static readonly Vector3 DIAMOND_SCALE; //Field offset: 0x18
	private static readonly Vector3 GOLD_POSITION; //Field offset: 0x24
	private static readonly Vector3 GOLD_ROTATION; //Field offset: 0x30
	private static readonly Vector3 GOLD_SCALE; //Field offset: 0x3C
	private static readonly Vector3 SILVER_POSITION; //Field offset: 0x48
	private static readonly Vector3 SILVER_ROTATION; //Field offset: 0x54
	private static readonly Vector3 SILVER_SCALE; //Field offset: 0x60
	private static readonly Vector3 BRONZE_POSITION; //Field offset: 0x6C
	private static readonly Vector3 BRONZE_ROTATION; //Field offset: 0x78
	private static readonly Vector3 BRONZE_SCALE; //Field offset: 0x84
	public static bool pauseScreenIsShown; //Field offset: 0x90
	private UIWidget _guideWidget; //Field offset: 0x28
	private GameObject _dailyChallenge; //Field offset: 0x2C
	private UILabel _dailyChallengeMainTitle; //Field offset: 0x30
	private UILabel _dailyChallengeSubTitle; //Field offset: 0x34
	private UIWidget _slotForDailyChallengeItemLoad; //Field offset: 0x38
	private DailyChallengeRewardHelper _dailyChallengeRewardHelper; //Field offset: 0x3C
	private TimerHelper _timerPrefab; //Field offset: 0x40
	private TimerHelper _timer; //Field offset: 0x44
	private GameObject _topRun; //Field offset: 0x48
	private UILabel _topRunMainTitle; //Field offset: 0x4C
	private UILabel _topRunSubTitle; //Field offset: 0x50
	private UILabel _topRunWeekLabel; //Field offset: 0x54
	private UILabel _topRunDaysLeftLabel; //Field offset: 0x58
	private UISprite _countryFlag; //Field offset: 0x5C
	private Layout _topRunLayot; //Field offset: 0x60
	private bool _topRunReady; //Field offset: 0x64
	private GameObject _topRunMedalGuideSprite; //Field offset: 0x68
	private GameObject _diamondMedalPrefab; //Field offset: 0x6C
	private GameObject _goldMedalPrefab; //Field offset: 0x70
	private GameObject _silverMedalPrefab; //Field offset: 0x74
	private GameObject _bronzeMedalPrefab; //Field offset: 0x78
	private readonly GameObject[] _topRunMedals; //Field offset: 0x7C
	private UILabel _missionsMainTitle; //Field offset: 0x80
	private UILabel _missionSubTitle; //Field offset: 0x84
	private UIWidget _slotForMissionItemLoad; //Field offset: 0x88
	private GameObject _missionCellPrefab; //Field offset: 0x8C
	private MissionSetProgress _missionSetProgressPrefab; //Field offset: 0x90
	private MissionSetProgress _missionSetProgress; //Field offset: 0x94
	private Layout[] _missionCellLayouts; //Field offset: 0x98
	private int _missionCellHeight; //Field offset: 0x9C
	private float _cellAnimationDuration; //Field offset: 0xA0
	private float _cellAnimationDelay; //Field offset: 0xA4
	private int _currentSet; //Field offset: 0xA8
	private UIWidget _footerGuide; //Field offset: 0xAC
	private ResumeButtonHelper _resumeButtonHelper; //Field offset: 0xB0
	private UILabel _homeButtonLabel; //Field offset: 0xB4
	private UILabel _settingsButtonLabel; //Field offset: 0xB8
	private UILabel _resumeButtonLabel; //Field offset: 0xBC
	private MissionInfo[][] _missionInfos; //Field offset: 0xC0
	private List<MissionCell>[] _missionCells; //Field offset: 0xC4

	private static PauseScreen() { }

	public PauseScreen() { }

	private void Add3DModel(int index, GameObject prefab, Vector3 position, Vector3 rotation, Vector3 scale) { }

	private void Add3DModels() { }

	private IEnumerator AnimateCell(Transform cellTransform, float startX, float endX, Action onComplete = null) { }

	private void AnimateNewMissionSet() { }

	private int CalculateCellHeight(UIWidget guideWidget) { }

	private void CreateNewMissionCells() { }

	private void Destroy3DMedals() { }

	private void DestroyOtherMissionCells() { }

	private static string FormatTopRunTimeLeft(TimeSpan ts) { }

	private int GetCurrentSetIndex() { }

	private int GetOtherSetIndex() { }

	private float GetTotalMissionCellAnimationTime() { }

	public override void Hide() { }

	public void HomeButtonClicked() { }

	public override void Init() { }

	public bool IsWaiting() { }

	private void MedalIconPositioning(GameObject medalGameObject, Vector3 positionOffset, Vector3 rotation, Vector3 scale) { }

	private IEnumerator MissionCompleteAnimation(int completedMissionsCount) { }

	private void OnApplicationPause(bool paused) { }

	private void OnMissionCellAnimationComplete(int completedMissionsCount) { }

	private void RefreshCurrentCells() { }

	private void RefreshDailyChallenge() { }

	private void RefreshMissionInfos() { }

	private void RefreshMissionSubtitle() { }

	private void RefreshTopRun() { }

	private void ResetCellPositions() { }

	private void ResetTransform(Transform trans, Vector3 newPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale) { }

	private void SelectTopSection() { }

	public override void Show() { }

}

