namespace Authentication.Internal;

public class EditorLogin : ILoginService
{
	private sealed class <Login>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public EditorLogin <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 135
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Login>d__13(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Logout>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public EditorLogin <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 135
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Logout>d__14(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float SIMULATED_LOGIN_TIME = 1; //Field offset: 0x0
	private const float SIMULATED_LOGOUT_TIME = 0.5; //Field offset: 0x0
	private const bool SIMULATE_LOGIN_FAIL = False; //Field offset: 0x0
	private const string SIMULATED_USER_NAME = "EditorUser"; //Field offset: 0x0
	private const string SIMULATED_USER_ALIAS = "EditorAlias"; //Field offset: 0x0
	private bool <isLoggedIn>k__BackingField; //Field offset: 0x8

	public string alias
	{
		 get { } //Length: 66
	}

	public string displayName
	{
		 get { } //Length: 9
	}

	public bool isLoggedIn
	{
		 get { } //Length: 66
		private set { } //Length: 59
	}

	public EditorLogin() { }

	public string get_alias() { }

	public string get_displayName() { }

	public bool get_isLoggedIn() { }

	public IEnumerator Login() { }

	public IEnumerator Logout() { }

	private void set_isLoggedIn(bool value) { }

}

