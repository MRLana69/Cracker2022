namespace AppRefresh;

public static class AppRefreshHandler
{
	private sealed class <PerformRefresh>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RefreshType restartType; //Field offset: 0x10
		public Action callback; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 315
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PerformRefresh>d__15(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static bool <refreshInProgress>k__BackingField; //Field offset: 0x0
	private static Action<RefreshType> willRefresh; //Field offset: 0x4
	private static Action<RefreshType> refresh; //Field offset: 0x8
	private static Action<RefreshType> hasRefreshed; //Field offset: 0xC

	public static event Action<RefreshType> hasRefreshed
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<RefreshType> refresh
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static event Action<RefreshType> willRefresh
	{
		 add { } //Length: 54
		 remove { } //Length: 129
	}

	public static bool refreshInProgress
	{
		 get { } //Length: 137
		private set { } //Length: 122
	}

	public static void add_hasRefreshed(Action<RefreshType> value) { }

	public static void add_refresh(Action<RefreshType> value) { }

	public static void add_willRefresh(Action<RefreshType> value) { }

	public static bool get_refreshInProgress() { }

	public static bool HasFlag(RefreshType obj, RefreshType flag) { }

	private static void InvokeIfFlagged(Action<RefreshType> action, RefreshType requestedType, RefreshType flag) { }

	private static IEnumerator PerformRefresh(RefreshType restartType, Action callback = null) { }

	public static void remove_hasRefreshed(Action<RefreshType> value) { }

	public static void remove_refresh(Action<RefreshType> value) { }

	public static void remove_willRefresh(Action<RefreshType> value) { }

	private static void set_refreshInProgress(bool value) { }

	public static void StartRefresh(RefreshType restartType, Action callback = null) { }

}

