namespace UI.Popups.LimitedBoardPopupInternal;

public class LimitedBoardPopupManager
{
	private sealed class <Timer>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float timeLeft; //Field offset: 0x10
		public Action handler; //Field offset: 0x14
		private float <startPoint>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 195
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Timer>d__28(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static Action OnLimitedBoardStartedHandler; //Field offset: 0x0
	private const BoardId CURRENT_BOARD_TYPE = 0; //Field offset: 0x0
	private static Action OnLimitedBoardExpiredHandler; //Field offset: 0x4
	private static LimitedBoardPopupManager _instance; //Field offset: 0x8
	private bool _overwrittenBoardForNextShowing; //Field offset: 0x8
	private BoardId _overwrittenBoard; //Field offset: 0xC
	private int <currentlyShownThemeIndex>k__BackingField; //Field offset: 0x10
	private bool _isInitialized; //Field offset: 0x14
	private IEnumerator _startTimerCoroutine; //Field offset: 0x18
	private IEnumerator _endTimerCoroutine; //Field offset: 0x1C

	public static event Action OnLimitedBoardExpiredHandler
	{
		 add { } //Length: 206
		 remove { } //Length: 209
	}

	public static event Action OnLimitedBoardStartedHandler
	{
		 add { } //Length: 764
		 remove { } //Length: 206
	}

	public BoardId currentBoardId
	{
		 get { } //Length: 273
	}

	public int currentlyShownThemeIndex
	{
		 get { } //Length: 163
		 set { } //Length: 15
	}

	public static LimitedBoardPopupManager instance
	{
		 get { } //Length: 226
	}

	private static LimitedBoardPopupManager() { }

	private LimitedBoardPopupManager() { }

	public static void add_OnLimitedBoardExpiredHandler(Action value) { }

	public static void add_OnLimitedBoardStartedHandler(Action value) { }

	public BoardId get_currentBoardId() { }

	public int get_currentlyShownThemeIndex() { }

	public static LimitedBoardPopupManager get_instance() { }

	private void Initialize() { }

	public bool IsBoardAvailable() { }

	private void OnPopupClosed(string s) { }

	public void OverrideNextShowingWithBoard(BoardId board) { }

	public static void remove_OnLimitedBoardExpiredHandler(Action value) { }

	public static void remove_OnLimitedBoardStartedHandler(Action value) { }

	public void set_currentlyShownThemeIndex(int value) { }

	public bool ShouldButtonBeVisible() { }

	private void StartTimer() { }

	private IEnumerator Timer(float timeLeft, Action handler) { }

}

