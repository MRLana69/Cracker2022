namespace UI.Screens;

public class PromotionManager
{
	private sealed class <ExpireTimer>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PromotionManager <>4__this; //Field offset: 0x10
		public long endTime; //Field offset: 0x18
		private long <currentTime>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 211
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ExpireTimer>d__23(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <StartTimer>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public PromotionManager <>4__this; //Field offset: 0x10
		public long endTime; //Field offset: 0x18
		private long <currentTime>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 211
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartTimer>d__22(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const string PromotionFolder = "Promotions"; //Field offset: 0x0
	private static Action onPromotionStartedHandler; //Field offset: 0x0
	private static Action onPromotionExpiredHandler; //Field offset: 0x4
	private static PromotionManager instance; //Field offset: 0x8
	private IEnumerator _startTimerCoroutine; //Field offset: 0x8
	private IEnumerator _endTimerCoroutine; //Field offset: 0xC
	private bool promotionsLoaded; //Field offset: 0x10
	private PromotionDefinition currentPromotion; //Field offset: 0x14

	public static event Action onPromotionExpiredHandler
	{
		 add { } //Length: 206
		 remove { } //Length: 209
	}

	public static event Action onPromotionStartedHandler
	{
		 add { } //Length: 134
		 remove { } //Length: 206
	}

	public static PromotionManager Instance
	{
		 get { } //Length: 92
	}

	public bool IsCurrentPromotionActive
	{
		 get { } //Length: 25
	}

	private static PromotionManager() { }

	private PromotionManager() { }

	public static void add_onPromotionExpiredHandler(Action value) { }

	public static void add_onPromotionStartedHandler(Action value) { }

	private IEnumerator ExpireTimer(long endTime) { }

	public static PromotionManager get_Instance() { }

	public bool get_IsCurrentPromotionActive() { }

	private long GetCurrentTimestamp() { }

	public void LoadPromotion(bool forceReload = false) { }

	private void OnPopupClosed(string window) { }

	public void OnPromotionPurchaseFailed() { }

	public void OnPromotionPurchaseSuccess() { }

	public static void remove_onPromotionExpiredHandler(Action value) { }

	public static void remove_onPromotionStartedHandler(Action value) { }

	private void StartTimer() { }

	private IEnumerator StartTimer(long endTime) { }

	public PromotionDefinition TryGetCurrentPromotion() { }

	public T TryGetCurrentPromotion() { }

}

