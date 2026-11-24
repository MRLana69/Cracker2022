namespace UI.Screens;

public static class FirstPurchaseBonusManager
{
	private sealed class <StateCheckCoroutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 579
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StateCheckCoroutine>d__19(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static bool _lastIsFirstPurchaseBonusActive; //Field offset: 0x0
	private static bool <running>k__BackingField; //Field offset: 0x1
	private static FirstPurchaseBonusBecameInactive onFirstPurchaseBonusBecameInactive; //Field offset: 0x4
	private static IEnumerator _stateCheckCoroutine; //Field offset: 0x8

	public static event FirstPurchaseBonusBecameInactive onFirstPurchaseBonusBecameInactive
	{
		 add { } //Length: 94
		 remove { } //Length: 209
	}

	public static bool isCollectingFirstPurchaseBonus
	{
		 get { } //Length: 3
	}

	public static bool isFirstPurchaseBonusActive
	{
		 get { } //Length: 92
	}

	public static bool running
	{
		 get { } //Length: 217
		private set { } //Length: 334
	}

	private static FirstPurchaseBonusManager() { }

	public static void ActivateCollectState() { }

	public static void add_onFirstPurchaseBonusBecameInactive(FirstPurchaseBonusBecameInactive value) { }

	private static void AppHasRefreshed(RefreshType obj) { }

	private static void AppWillRefresh(RefreshType obj) { }

	public static bool get_isCollectingFirstPurchaseBonus() { }

	public static bool get_isFirstPurchaseBonusActive() { }

	public static bool get_running() { }

	public static void remove_onFirstPurchaseBonusBecameInactive(FirstPurchaseBonusBecameInactive value) { }

	public static void ResetFirstPurchaseBonus() { }

	private static void set_running(bool value) { }

	public static void StartStateCheckCoroutine() { }

	private static IEnumerator StateCheckCoroutine() { }

}

