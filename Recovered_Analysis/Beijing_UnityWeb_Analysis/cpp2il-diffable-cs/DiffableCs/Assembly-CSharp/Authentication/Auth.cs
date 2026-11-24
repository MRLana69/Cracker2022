namespace Authentication;

public class Auth
{
	private sealed class <>c__DisplayClass30_0
	{
		public AuthResult result; //Field offset: 0x8

		public <>c__DisplayClass30_0() { }

		internal void <InitRoutine>b__0(bool success, Error error) { }

		internal void <InitRoutine>b__1(bool success, Error error) { }

	}

	private sealed class <InitNativeAndLoginAsync>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Auth <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 153
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <InitNativeAndLoginAsync>d__31(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <InitRoutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Auth <>4__this; //Field offset: 0x10
		private <>c__DisplayClass30_0 <>8__1; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 526
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <InitRoutine>d__30(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LogoutAsync>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Auth <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 91
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LogoutAsync>d__32(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class AuthResult
	{
		private bool <success>k__BackingField; //Field offset: 0x8
		private Error <error>k__BackingField; //Field offset: 0xC

		public Error error
		{
			 get { } //Length: 9
			 set { } //Length: 11
		}

		public bool success
		{
			 get { } //Length: 6
			 set { } //Length: 8
		}

		public AuthResult() { }

		public Error get_error() { }

		public bool get_success() { }

		public void set_error(Error value) { }

		public void set_success(bool value) { }

	}

	private static Auth _instance; //Field offset: 0x0
	private const string DEFAULT_AUTH_BASE_URL = "https://auth.kiloo-games.com/"; //Field offset: 0x0
	private const string ONLINESETTINGS_AUTH_URL_KEY = "kilooauth_url"; //Field offset: 0x0
	private const string AUTH_FILENAME = "kilooauth"; //Field offset: 0x0
	private const bool ALLOW_ANONYMOUS_IN_EDITOR = True; //Field offset: 0x0
	private NativeLogin _native; //Field offset: 0x8
	private KilooAuth _kilooAuth; //Field offset: 0xC
	private Action authenticatedEvent; //Field offset: 0x10

	public static event Action authenticated
	{
		 add { } //Length: 2
		 remove { } //Length: 85
	}

	private event Action authenticatedEvent
	{
		 add { } //Length: 278
		 remove { } //Length: 111
	}

	private bool allowAnonymous
	{
		 get { } //Length: 500
	}

	public static string displayName
	{
		 get { } //Length: 80
	}

	private static Auth instance
	{
		 get { } //Length: 77
	}

	public static bool isAuthorized
	{
		 get { } //Length: 134
	}

	public static bool isInitialized
	{
		 get { } //Length: 201
	}

	public static bool isLoggedIn
	{
		 get { } //Length: 134
	}

	public static KilooAuth kilooAuth
	{
		 get { } //Length: 137
	}

	public static string kilooTag
	{
		 get { } //Length: 171
	}

	private static Auth() { }

	public Auth() { }

	public static void add_authenticated(Action value) { }

	private void add_authenticatedEvent(Action value) { }

	public static void DeleteKilooAuthDebug() { }

	private bool get_allowAnonymous() { }

	public static string get_displayName() { }

	private static Auth get_instance() { }

	public static bool get_isAuthorized() { }

	public static bool get_isInitialized() { }

	public static bool get_isLoggedIn() { }

	public static KilooAuth get_kilooAuth() { }

	public static string get_kilooTag() { }

	public static Coroutine Init() { }

	private void InitKilooAuth() { }

	private IEnumerator InitNativeAndLoginAsync() { }

	private IEnumerator InitRoutine() { }

	private static void Log(string msg, Object obj = null) { }

	private static void LogError(string msg, Object obj = null) { }

	private IEnumerator LogoutAsync() { }

	public static void remove_authenticated(Action value) { }

	private void remove_authenticatedEvent(Action value) { }

}

