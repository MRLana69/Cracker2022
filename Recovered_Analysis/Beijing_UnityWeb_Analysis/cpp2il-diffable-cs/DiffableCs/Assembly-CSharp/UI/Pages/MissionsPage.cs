namespace UI.Pages;

public class MissionsPage : Page
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MissionInfo, bool> <>9__22_0; //Field offset: 0x4
		public static Func<MissionCell, bool> <>9__24_0; //Field offset: 0x8
		public static Action<MissionCell> <>9__32_0; //Field offset: 0xC
		public static Action<MissionCell> <>9__33_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <DestroyOtherMissionCells>b__33_0(MissionCell cell) { }

		internal bool <DisplayCelebrationPopupIfNeeded>b__24_0(MissionCell x) { }

		internal void <ResetCellPositions>b__32_0(MissionCell c) { }

		internal bool <Show>b__22_0(MissionInfo m) { }

	}

	private sealed class <>c__DisplayClass35_0
	{
		public MissionsPage <>4__this; //Field offset: 0x8
		public List<MissionCell> newMissionCells; //Field offset: 0xC
		public float inStartPosition; //Field offset: 0x10
		public float mainPosition; //Field offset: 0x14
		public List<MissionCell> oldMissionsCells; //Field offset: 0x18
		public float outEndPosition; //Field offset: 0x1C
		public Action onComplete; //Field offset: 0x20

		public <>c__DisplayClass35_0() { }

		internal void <AnimateNewMissionSet>b__0() { }

		internal void <AnimateNewMissionSet>b__1() { }

		internal void <AnimateNewMissionSet>b__2() { }

		internal void <AnimateNewMissionSet>b__3() { }

	}

	private sealed class <AnimateCell>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MissionsPage <>4__this; //Field offset: 0x10
		public Transform cellTransform; //Field offset: 0x14
		public float startX; //Field offset: 0x18
		public float endX; //Field offset: 0x1C
		public Action onComplete; //Field offset: 0x20
		private float <currentDuration>5__2; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 307
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateCell>d__36(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DelayedQueueCelebrationPopup>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 146
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedQueueCelebrationPopup>d__25(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <MissionCompleteAnimation>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int completedMissionsCount; //Field offset: 0x10
		public MissionsPage <>4__this; //Field offset: 0x14
		private int <currentMissionsSet>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 661
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MissionCompleteAnimation>d__29(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const int PAGE_INDEX = 1; //Field offset: 0x0
	private const int MISSION_COUNT_IN_SET = 3; //Field offset: 0x0
	private const int MAX_MULTIPLIER = 30; //Field offset: 0x0
	private PageTop _topPrefab; //Field offset: 0x10
	private PageTop _top; //Field offset: 0x14
	private GameObject _missionCellPrefab; //Field offset: 0x18
	private Layout[] _missionCellLayouts; //Field offset: 0x1C
	private float _cellAnimationDuration; //Field offset: 0x20
	private float _cellAnimationDelay; //Field offset: 0x24
	private int _currentSet; //Field offset: 0x28
	private MissionSetProgress _missionSetProgressPrefab; //Field offset: 0x2C
	private MissionSetProgress _missionSetProgress; //Field offset: 0x30
	private int _cellHeight; //Field offset: 0x34
	private MissionInfo[][] _missionInfos; //Field offset: 0x38
	private List<MissionCell>[] _missionCells; //Field offset: 0x3C
	private int _currentMissionSetCompletedSum; //Field offset: 0x40
	private bool _missionCompleteAnimationInProgress; //Field offset: 0x44
	private EventsPageTopPayload _topPayload; //Field offset: 0x48

	public MissionsPage() { }

	private GameObject <Init>b__21_0(UIWidget w) { }

	private IEnumerator AnimateCell(Transform cellTransform, float startX, float endX, Action onComplete = null) { }

	private void AnimateNewMissionSet() { }

	private int CalculateCellHeight(UIWidget pageGuideWidget) { }

	private void CreateNewMissionCells() { }

	private IEnumerator DelayedQueueCelebrationPopup() { }

	private void DestroyOtherMissionCells() { }

	private void DisplayCelebrationPopupIfNeeded() { }

	public override FooterPayload GetButtonPayload() { }

	private int GetCurrentSetIndex() { }

	private int GetOtherSetIndex() { }

	private float GetTotalMissionCellAnimationTime() { }

	public override void Hide() { }

	public override void Init(UIWidget pageGuideWidget) { }

	private IEnumerator MissionCompleteAnimation(int completedMissionsCount) { }

	private void OnMissionCellAnimationComplete(int completedMissionsCount) { }

	private void RefreshCurrentCells() { }

	private void RefreshMissionInfos() { }

	private void RefreshPageTitles(bool useEffect = false) { }

	private void ResetCellPositions() { }

	public override void Show() { }

}

