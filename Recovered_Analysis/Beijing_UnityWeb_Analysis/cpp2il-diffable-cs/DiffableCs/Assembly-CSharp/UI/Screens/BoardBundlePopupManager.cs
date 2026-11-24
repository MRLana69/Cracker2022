namespace UI.Screens;

public class BoardBundlePopupManager
{
	private sealed class <ExpireTimer>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BoardBundlePopupManager <>4__this; //Field offset: 0x10
		public long endTime; //Field offset: 0x18
		private long <currentTime>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 128
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ExpireTimer>d__33(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <StartTimer>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BoardBundlePopupManager <>4__this; //Field offset: 0x10
		public long endTime; //Field offset: 0x18
		private long <currentTime>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 128
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartTimer>d__32(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const string BUNDLE_TIER_01 = "com.kiloo.subwayboard.mumbai.bundletier1"; //Field offset: 0x0
	public const string BUNDLE_TIER_02 = "com.kiloo.subwayboard.mumbai.bundletier2"; //Field offset: 0x0
	private const bool BOARD_BUNDLE_ACTIVE = False; //Field offset: 0x0
	private static BoardBundlePopupManager _instance; //Field offset: 0x0
	private Action onBoardBundleStartedHandler; //Field offset: 0x8
	private Action onBoardBundleExpiredHandler; //Field offset: 0xC
	public readonly string BUNDLE_BOARD; //Field offset: 0x10
	public readonly ThemeIdentifier firstCustomSet; //Field offset: 0x14
	public readonly ThemeIdentifier secondCustomSet; //Field offset: 0x18
	private readonly BoardId BOARD_TYPE; //Field offset: 0x1C
	private IEnumerator _startTimerCoroutine; //Field offset: 0x20
	private IEnumerator _endTimerCoroutine; //Field offset: 0x24
	private Action _onSuccess; //Field offset: 0x28

	public event Action onBoardBundleExpiredHandler
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action onBoardBundleStartedHandler
	{
		 add { } //Length: 285
		 remove { } //Length: 111
	}

	public static BoardBundlePopupManager instance
	{
		 get { } //Length: 93
	}

	private static BoardBundlePopupManager() { }

	private BoardBundlePopupManager() { }

	public void add_onBoardBundleExpiredHandler(Action value) { }

	public void add_onBoardBundleStartedHandler(Action value) { }

	public void DebugModeChanged() { }

	private IEnumerator ExpireTimer(long endTime) { }

	public static BoardBundlePopupManager get_instance() { }

	public long GetBoardBundleExpireTimestamp() { }

	public long GetBoardBundleStartTimestamp() { }

	public BoardId GetBoardType() { }

	public string GetBundleIconName() { }

	private long GetCurrentTimestamp() { }

	public TimeSpan GetTimeLeft() { }

	public bool IsBoardBundleSaleActive() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogErr(string msg, Object context = null) { }

	private void OnPurchaseFailedOrCancelled(string id, PurchaseResult result) { }

	private void OnPurchaseSuccess(string productid, bool wasrestored, IPurchaseValidationResult validationresult) { }

	public void PurchaseBoardBundle(string productId, Action onSuccess) { }

	public void remove_onBoardBundleExpiredHandler(Action value) { }

	public void remove_onBoardBundleStartedHandler(Action value) { }

	public bool ShouldButtonBeVisible() { }

	private void StartTimer() { }

	private IEnumerator StartTimer(long endTime) { }

}

