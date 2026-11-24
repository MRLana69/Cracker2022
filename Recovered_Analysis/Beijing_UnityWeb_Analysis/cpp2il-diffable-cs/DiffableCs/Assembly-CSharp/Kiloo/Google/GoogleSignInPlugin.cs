namespace Kiloo.Google;

public sealed class GoogleSignInPlugin
{
	private sealed class <SignInCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleSignInPlugin <>4__this; //Field offset: 0x10
		public GoogleSignInPluginRequest request; //Field offset: 0x14
		public Action<GoogleSignInPluginRequest> onComplete; //Field offset: 0x18
		private GoogleSignInBridgeRequest<IGoogleSignInResult> <signInRequest>5__2; //Field offset: 0x1C
		private GoogleSignInBridgeRequest<IGoogleConnectResult> <connectRequest>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 759
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SignInCoroutine>d__27(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <SignOutCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleSignInPlugin <>4__this; //Field offset: 0x10
		public GoogleSignInPluginRequest request; //Field offset: 0x14
		public Action<GoogleSignInPluginRequest> onComplete; //Field offset: 0x18
		private GoogleSignInBridgeRequest<IGoogleConnectResult> <connectRequest>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 417
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SignOutCoroutine>d__28(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public delegate ProfileUpdatedHandler
	{

		public ProfileUpdatedHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(IGoogleProfile oldProfile, IGoogleProfile newProfile, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(IGoogleProfile oldProfile, IGoogleProfile newProfile) { }

	}

	private static GoogleSignInPlugin <instance>k__BackingField; //Field offset: 0x0
	private ProfileUpdatedHandler profileUpdated; //Field offset: 0x8
	private bool <profileIsUpdated>k__BackingField; //Field offset: 0xC
	private IGoogleProfile <profile>k__BackingField; //Field offset: 0x10
	private readonly IGoogleSignInBridge _bridge; //Field offset: 0x14

	public event ProfileUpdatedHandler profileUpdated
	{
		 add { } //Length: 2
		 remove { } //Length: 111
	}

	public static GoogleSignInPlugin instance
	{
		 get { } //Length: 7
		private set { } //Length: 2
	}

	public static bool isInitialized
	{
		 get { } //Length: 49
	}

	public bool isSignedIn
	{
		 get { } //Length: 6
	}

	public static bool isSupported
	{
		 get { } //Length: 121
	}

	public IGoogleProfile profile
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public bool profileIsUpdated
	{
		 get { } //Length: 66
		private set { } //Length: 111
	}

	private GoogleSignInPlugin() { }

	public void add_profileUpdated(ProfileUpdatedHandler value) { }

	private static bool AreEqual(IGoogleProfile a, IGoogleProfile b) { }

	private void CompleteRequest(GoogleSignInPluginRequest request, Action<GoogleSignInPluginRequest> onComplete, string context, IGoogleProfile profile = null, int errorCode = 0, string errorMessage = null) { }

	public static GoogleSignInPlugin get_instance() { }

	public static bool get_isInitialized() { }

	public bool get_isSignedIn() { }

	public static bool get_isSupported() { }

	public IGoogleProfile get_profile() { }

	public bool get_profileIsUpdated() { }

	public static void Init() { }

	private static void Log(string msg, object[] args) { }

	private static void LogError(string msg) { }

	public void remove_profileUpdated(ProfileUpdatedHandler value) { }

	private static void set_instance(GoogleSignInPlugin value) { }

	private void set_profile(IGoogleProfile value) { }

	private void set_profileIsUpdated(bool value) { }

	public Coroutine SignIn(GoogleSignInPluginRequest request = null, Action<GoogleSignInPluginRequest> onComplete = null) { }

	private IEnumerator SignInCoroutine(GoogleSignInPluginRequest request, Action<GoogleSignInPluginRequest> onComplete) { }

	public Coroutine SignOut(GoogleSignInPluginRequest request = null, Action<GoogleSignInPluginRequest> onComplete = null) { }

	private IEnumerator SignOutCoroutine(GoogleSignInPluginRequest request, Action<GoogleSignInPluginRequest> onComplete) { }

	private void UpdateProfile(IGoogleProfile newProfile) { }

}

