namespace Kiloo.Google.Internal;

internal sealed class SimulatedGoogleSignInBridge : GoogleSignInBridge
{
	private sealed class <>c__DisplayClass12_0
	{
		public SimulatedGoogleSignInBridge <>4__this; //Field offset: 0x8
		public string payload; //Field offset: 0xC

		public <>c__DisplayClass12_0() { }

		internal void <PluginSignIn>b__0() { }

	}

	private sealed class <WaitAndDo>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float wait; //Field offset: 0x10
		public Action action; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 147
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitAndDo>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class Profile
	{
		public string displayName; //Field offset: 0x8
		public string userId; //Field offset: 0xC
		public string photoUrl; //Field offset: 0x10
		public string idToken; //Field offset: 0x14

		public Profile() { }

	}

	public class SignInResult
	{
		public Profile profile; //Field offset: 0x8
		public int errorCode; //Field offset: 0xC
		public string errorMessage; //Field offset: 0x10

		public SignInResult() { }

	}

	private const string PHOTO_URL_FORMAT = "http://imaginary-photo-cdn.com/{0}/picture"; //Field offset: 0x0
	public string userId; //Field offset: 0x1C
	public string displayName; //Field offset: 0x20
	public int signInError; //Field offset: 0x24
	public string signInErrorMessage; //Field offset: 0x28
	public float latency; //Field offset: 0x2C
	private bool _connected; //Field offset: 0x30
	private bool _signedIn; //Field offset: 0x31

	public SimulatedGoogleSignInBridge() { }

	private void <PluginConnect>b__9_0() { }

	private void <PluginSignOut>b__13_0() { }

	public static GoogleSignInBridge Create() { }

	public static bool IsSupported() { }

	private string MakeIdToken() { }

	protected override void PluginConnect() { }

	protected override bool PluginIsConnected() { }

	protected override bool PluginSignIn(bool silent) { }

	protected override bool PluginSignOut() { }

	private IEnumerator WaitAndDo(float wait, Action action) { }

}

