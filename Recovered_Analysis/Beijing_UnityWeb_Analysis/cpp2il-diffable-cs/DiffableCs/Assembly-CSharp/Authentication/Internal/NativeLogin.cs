namespace Authentication.Internal;

public class NativeLogin
{
	private sealed class <LoginRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public NativeLogin <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 139
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoginRoutine>d__11(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LogoutRoutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public NativeLogin <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 139
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LogoutRoutine>d__12(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const bool SIMULATE_IN_EDITOR = True; //Field offset: 0x0
	private readonly ILoginService _service; //Field offset: 0x8

	public string displayName
	{
		 get { } //Length: 65
	}

	private bool isInitialized
	{
		 get { } //Length: 66
	}

	public bool isLoggedIn
	{
		 get { } //Length: 9
	}

	public NativeLogin() { }

	public string get_displayName() { }

	private bool get_isInitialized() { }

	public bool get_isLoggedIn() { }

	private static void Log(string msg, Object obj = null) { }

	private static void LogError(string msg, Object obj = null) { }

	public Coroutine LoginAsync() { }

	private IEnumerator LoginRoutine() { }

	public Coroutine LogoutAsync() { }

	private IEnumerator LogoutRoutine() { }

}

