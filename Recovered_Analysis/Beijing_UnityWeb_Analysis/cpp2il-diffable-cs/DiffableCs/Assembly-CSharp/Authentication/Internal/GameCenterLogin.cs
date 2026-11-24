namespace Authentication.Internal;

public class GameCenterLogin : ILoginService
{
	private sealed class <Login>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLogin <>4__this; //Field offset: 0x10
		private float <timeout>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 347
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Login>d__10(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Logout>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLogin <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 78
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Logout>d__11(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float LOGIN_TIMEOUT = 5; //Field offset: 0x0
	private LocalPlayer _user; //Field offset: 0x8
	private bool _isConsideredLoggedIn; //Field offset: 0x18

	public string alias
	{
		 get { } //Length: 82
	}

	public string displayName
	{
		 get { } //Length: 23
	}

	public bool isLoggedIn
	{
		 get { } //Length: 66
	}

	public GameCenterLogin() { }

	public string get_alias() { }

	public string get_displayName() { }

	public bool get_isLoggedIn() { }

	public IEnumerator Login() { }

	public IEnumerator Logout() { }

	private void OnAuthenticateHandler(bool view, string error) { }

}

