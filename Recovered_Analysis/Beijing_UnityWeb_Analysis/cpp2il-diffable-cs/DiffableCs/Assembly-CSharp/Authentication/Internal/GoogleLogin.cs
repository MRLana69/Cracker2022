namespace Authentication.Internal;

public class GoogleLogin : ILoginService
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<GoogleSignInPluginRequest> <>9__9_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Logout>b__9_0(GoogleSignInPluginRequest result) { }

	}

	private sealed class <>c__DisplayClass8_0
	{
		public GoogleSignInPluginRequest requestResult; //Field offset: 0x8

		public <>c__DisplayClass8_0() { }

		internal void <Login>b__0(GoogleSignInPluginRequest result) { }

		internal void <Login>b__1(GoogleSignInPluginRequest result) { }

	}

	private sealed class <Login>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleLogin <>4__this; //Field offset: 0x10
		private <>c__DisplayClass8_0 <>8__1; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 454
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Login>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Logout>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleLogin <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 331
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Logout>d__9(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private GoogleSignInPlugin _google; //Field offset: 0x8

	public string alias
	{
		 get { } //Length: 99
	}

	public string displayName
	{
		 get { } //Length: 26
	}

	public bool isLoggedIn
	{
		 get { } //Length: 66
	}

	public GoogleLogin() { }

	public string get_alias() { }

	public string get_displayName() { }

	public bool get_isLoggedIn() { }

	public IEnumerator Login() { }

	public IEnumerator Logout() { }

}

