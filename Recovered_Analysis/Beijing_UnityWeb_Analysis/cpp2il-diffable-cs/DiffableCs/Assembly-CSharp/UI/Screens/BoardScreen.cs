namespace UI.Screens;

public class BoardScreen : UIScreen
{
	private sealed class <DelayedInitCenterBoard>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BoardScreen <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 270
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedInitCenterBoard>d__62(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DelayedRefreshEventBoardAndUI>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BoardScreen <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 123
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedRefreshEventBoardAndUI>d__50(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class BoardState
	{
		public Quaternion defaultRotation; //Field offset: 0x8
		public GameObject boardRoot; //Field offset: 0x18
		public Transform boardTransform; //Field offset: 0x1C

		public BoardState() { }

	}

	private const float DEFAULT_SCALE_FACTOR = 7; //Field offset: 0x0
	private const int SCROLL_BOARD_VISIBILITY_COUNT = 4; //Field offset: 0x0
	private const int SCALE_MODEL_COUNT = 4; //Field offset: 0x0
	private const float SCALE_SCROLL_TOLERANCE = 1; //Field offset: 0x0
	private const float FOCUSED_SCALE_FACTOR = 10; //Field offset: 0x0
	private GameObject scrollAnchor; //Field offset: 0x28
	private UIGrid scrollGrid; //Field offset: 0x2C
	private GameObject overlayParent; //Field offset: 0x30
	private UIPanel scrollPanel; //Field offset: 0x34
	private GameObject scroll2dElements; //Field offset: 0x38
	private GameObject _centerAnchor; //Field offset: 0x3C
	private GameObject dummyObject; //Field offset: 0x40
	private UILabel nameLabel; //Field offset: 0x44
	private UILabel staticPowerupLabel; //Field offset: 0x48
	private UILabel descriptionLabel; //Field offset: 0x4C
	private UISprite powerIcon; //Field offset: 0x50
	private UILabel themeLimitedLabel; //Field offset: 0x54
	private GameObject eventRibbon; //Field offset: 0x58
	private UILabel[] ribbonLabels; //Field offset: 0x5C
	private GameObject _scrollHorizontalParent; //Field offset: 0x60
	public UIHoverboardThemeShifter _hoverboardThemeShifter; //Field offset: 0x64
	private GameObject _hoverboardSelectButtonPrefab; //Field offset: 0x68
	private AudioClip selectSound; //Field offset: 0x6C
	private GameObject themePower; //Field offset: 0x70
	private UILabel themePowerStaticLabel; //Field offset: 0x74
	private UILabel themePowerLabel; //Field offset: 0x78
	private TimerHelper _timerPrefab; //Field offset: 0x7C
	private UIWidget _timerContainer; //Field offset: 0x80
	private TimerHelper _timer; //Field offset: 0x84
	private bool _hasInited; //Field offset: 0x88
	private CenterOnChild _centerer; //Field offset: 0x8C
	public BoardSelectButton _hoverboardSelectButton; //Field offset: 0x90
	private bool _refreshingThemeInScrollList; //Field offset: 0x94
	private SSEventType _cachedActiveEventType; //Field offset: 0x98
	private bool _hasSetupScroll; //Field offset: 0x9C
	private float _cellWidth; //Field offset: 0xA0
	public List<KeyValuePair<BoardId, Board>> _boardList; //Field offset: 0xA4
	private Quaternion[] _previousBoardQuaternions; //Field offset: 0xA8
	private bool hasEnabledScrollElements; //Field offset: 0xAC
	private float _cachedScaleScrollPosition; //Field offset: 0xB0
	private float _cachedScrollPosition; //Field offset: 0xB4
	private bool _hasSetiPhoneXOffsetsIfNecessary; //Field offset: 0xB8
	private bool _refreshOnLastPopupClosed; //Field offset: 0xB9
	private List<BoardState> scrollBoards; //Field offset: 0xBC
	public List<HoverboardOverlayHelper> boardHelpers; //Field offset: 0xC0
	public List<OverlayIndex> boardIndices; //Field offset: 0xC4
	private bool _oldHoverboardOwned; //Field offset: 0xC8
	private bool _inappOverlayActive; //Field offset: 0xC9
	private bool _popupActive; //Field offset: 0xCA
	private bool _modelsEnabled; //Field offset: 0xCB

	public BoardScreen() { }

	private void ActivateEventRibbon(bool active) { }

	private BoardId BoardTypeToCenterOn() { }

	public void ClickedHoverboardTheme(int index) { }

	private IEnumerator DelayedInitCenterBoard() { }

	private IEnumerator DelayedRefreshEventBoardAndUI() { }

	private T ElementToCenterOn(List<T> elements, BoardId board) { }

	public override void Hide() { }

	public override void Init() { }

	private void InitBoards() { }

	private void InitializeSelectButton() { }

	private void InitializeTimer() { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	private void OnLastPopupClosed() { }

	private void OnThemeActiveStateChanged(BoardAbility boardAbility) { }

	public void RefreshBoards() { }

	public void RefreshEventBoardAndUI() { }

	private void RefreshIfPopupNotActive() { }

	private void ScaleScrollModels(bool forceUpdate = false) { }

	public void ScrollClicked(Vector2 pos) { }

	private void SetupThemes() { }

	public override void Show() { }

	public void ShowHoverboardInMenu(bool willUpdateAnimation, bool willAllowSignatureAnimation, BoardAbility ability = 0) { }

	public void ShowHoverboardInScrollList() { }

	private void ShowTimer(bool showTimer, TimeSpan timeLeft) { }

	private void ToggleScrollElements(bool enable) { }

	private void Update() { }

	private void UpdateBoardEnabledState() { }

	public void UpdateDisplayedModelWithTheme(BoardId boardId, int themeIndex) { }

	public void UpdateUIElements() { }

	private void VerifyBoardAmount() { }

}

