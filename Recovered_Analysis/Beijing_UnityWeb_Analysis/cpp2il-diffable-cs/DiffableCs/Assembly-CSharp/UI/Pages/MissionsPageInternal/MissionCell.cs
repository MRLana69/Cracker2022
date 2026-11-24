namespace UI.Pages.MissionsPageInternal;

public class MissionCell : MonoBehaviour, IBuyButton
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MissionInfo, bool> <>9__62_0; //Field offset: 0x4
		public static Func<MissionInfo, bool> <>9__72_0; //Field offset: 0x8
		public static Action<UISprite> <>9__75_0; //Field offset: 0xC
		public static Action<UISprite> <>9__75_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <AnimateBackgroundProgress>b__72_0(MissionInfo m) { }

		internal void <AnimateBottomPanelCoroutine>b__75_0(UISprite s) { }

		internal void <AnimateBottomPanelCoroutine>b__75_1(UISprite s) { }

		internal bool <AnimateSkip>b__62_0(MissionInfo m) { }

	}

	private sealed class <>c__DisplayClass45_0
	{
		public bool wasComplete; //Field offset: 0x8
		public MissionCell <>4__this; //Field offset: 0xC

		public <>c__DisplayClass45_0() { }

		internal void <AlignCompletedText>b__0() { }

	}

	private sealed class <>c__DisplayClass68_0
	{
		public bool missionComplete; //Field offset: 0x8

		public <>c__DisplayClass68_0() { }

		internal void <RefreshState>b__0(UISprite s) { }

	}

	private sealed class <>c__DisplayClass75_0
	{
		public float alphaPlot; //Field offset: 0x8

		public <>c__DisplayClass75_0() { }

		internal void <AnimateBottomPanelCoroutine>b__2(UISprite s) { }

	}

	private sealed class <AnimateBackgroundProgress>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int finalProgress; //Field offset: 0x10
		public MissionCell <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 456
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateBackgroundProgress>d__72(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateBottomPanelCoroutine>d__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MissionCell <>4__this; //Field offset: 0x10
		private float <currentDuration>5__2; //Field offset: 0x14
		private float <firstInterval>5__3; //Field offset: 0x18
		private float <secondInterval>5__4; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1515
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateBottomPanelCoroutine>d__75(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateProgressBarCoroutine>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MissionCell <>4__this; //Field offset: 0x10
		public int finalProgress; //Field offset: 0x14
		private float <currentDuration>5__2; //Field offset: 0x18
		private float <startProgress>5__3; //Field offset: 0x1C
		private int <goal>5__4; //Field offset: 0x20
		private float <firstInterval>5__5; //Field offset: 0x24
		private float <secondInterval>5__6; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 706
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateProgressBarCoroutine>d__74(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <CompleteAnimationInternal>d__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MissionCell <>4__this; //Field offset: 0x10
		public int completedMissionsCount; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 312
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CompleteAnimationInternal>d__73(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class MissionCellPayload
	{
		public int cellHeight; //Field offset: 0x8
		public int missionIndex; //Field offset: 0xC
		public int headerHeight; //Field offset: 0x10
		public MissionInfo missionInfo; //Field offset: 0x14
		public Action<int> onMissionCellAnimationComplete; //Field offset: 0x3C
		public PayloadSource source; //Field offset: 0x40

		public MissionCellPayload() { }

	}

	public enum PayloadSource
	{
		PauseMenu = 0,
		ChallengesScreen = 1,
	}

	public const int MAX_HEADER_HEIGHT = 50; //Field offset: 0x0
	private const int BG_TRIGGER_HEIGHT = 88; //Field offset: 0x0
	private const int MIN_BG_HEIGHT_FOR_CHALLENGES_SCREEN = 109; //Field offset: 0x0
	private const int MIN_BG_HEIGHT = 80; //Field offset: 0x0
	private const int MIN_HEADER_HEIGHT = 45; //Field offset: 0x0
	private GameObject[] _hideWhenPopupsActive; //Field offset: 0xC
	private UISprite _headerSprite; //Field offset: 0x10
	private UILabel _missionText; //Field offset: 0x14
	private UILabel _missionSkipText; //Field offset: 0x18
	private UILabel _skipCost; //Field offset: 0x1C
	private UILabel _videoLabel; //Field offset: 0x20
	private UILabel _missionProgress; //Field offset: 0x24
	private UISlider _progressSlider; //Field offset: 0x28
	private GameObject _progressComplete; //Field offset: 0x2C
	private UISprite _progressFlashSprite; //Field offset: 0x30
	private UILabel _completedLabel; //Field offset: 0x34
	private UISprite _checkmarkSprite; //Field offset: 0x38
	private List<UISprite> _completedGlows; //Field offset: 0x3C
	private UIButton _skipWithKeysButton; //Field offset: 0x40
	private UIButton _skipWithVideoButton; //Field offset: 0x44
	private UISprite _backgroundSprite; //Field offset: 0x48
	private UIWidget _inProgressDisplay; //Field offset: 0x4C
	private UIWidget _completedDisplay; //Field offset: 0x50
	private GameObject _animatedTVIconPrefab; //Field offset: 0x54
	private UIWidget _animatedTVIconContainer; //Field offset: 0x58
	private bool <hasSkippedMission>k__BackingField; //Field offset: 0x5C
	private bool <isVideoPlaying>k__BackingField; //Field offset: 0x5D
	private MissionCellPayload _payload; //Field offset: 0x60
	private int _currentProgress; //Field offset: 0x64
	private bool _hasHookedUpEvents; //Field offset: 0x68
	private bool _isNewlyCreated; //Field offset: 0x69

	public bool hasSkippedMission
	{
		 get { } //Length: 6
		private set { } //Length: 1363
	}

	public bool isVideoPlaying
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public MissionCell() { }

	private static string AddNumberColor(int number) { }

	private void AlignCompletedText() { }

	private IEnumerator AnimateBackgroundProgress(int finalProgress) { }

	private IEnumerator AnimateBottomPanelCoroutine() { }

	private IEnumerator AnimateProgressBarCoroutine(int finalProgress) { }

	public void AnimateSkip() { }

	private int CalculateHeaderHeight() { }

	private bool CanShowBottomPanel() { }

	private IEnumerator CompleteAnimationInternal(int completedMissionsCount) { }

	private void CreateTVIcon() { }

	public bool get_hasSkippedMission() { }

	public bool get_isVideoPlaying() { }

	private int GetSkipCost() { }

	private void HookEvents() { }

	public void Init(MissionCellPayload payload) { }

	private bool IsBottomBoxActive() { }

	private void LogAttemptToShowButtonFlow() { }

	public void OnBuyClicked() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnFinishedWatchingVideo() { }

	private void OnLastPopupClosed() { }

	private void OnMissionProgress(int missionIndex, float completionFactor) { }

	private void OnPopupShown(string popupName) { }

	public void OnPurchaseFailure() { }

	public void OnPurchaseSuccessful() { }

	private void OnShowVideoFailure(string locationID) { }

	public void OnSkipWithVideoClicked() { }

	private void OnVideoOverlayClosed() { }

	public void Refresh(MissionInfo info) { }

	public void Refresh() { }

	public void RefreshIfNotNewlyCreated(MissionInfo info) { }

	private void RefreshState() { }

	private void ResetAnimations() { }

	private void set_hasSkippedMission(bool value) { }

	private void set_isVideoPlaying(bool value) { }

	private void ShowSkipButton() { }

	private void TrackSuccessfulSkipFlurry(bool skippedWithVideo = false) { }

	private void UnhookEvents() { }

	private void UpdateProgress() { }

	private void UpdateText() { }

}

