namespace Kiloo.Google.Internal;

internal abstract class GoogleSignInBridge : MonoBehaviour, IGoogleSignInBridge, IDisposable
{
	private sealed class <ConnectCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleSignInBridgeRequest<IGoogleConnectResult> request; //Field offset: 0x10
		public GoogleSignInBridge <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 265
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ConnectCoroutine>d__13(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <SignInCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleSignInBridgeRequest<IGoogleSignInResult> request; //Field offset: 0x10
		public GoogleSignInBridge <>4__this; //Field offset: 0x14
		public bool silent; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 253
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SignInCoroutine>d__14(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <SignOutCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleSignInBridgeRequest<IGoogleSignOutResult> request; //Field offset: 0x10
		public GoogleSignInBridge <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 245
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SignOutCoroutine>d__15(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class ConnectionFailedPayload
	{
		public string errorMessage; //Field offset: 0x8
		public int errorCode; //Field offset: 0xC

		public ConnectionFailedPayload() { }

	}

	private class ConnectionSuspendedPayload
	{
		public int cause; //Field offset: 0x8

		public ConnectionSuspendedPayload() { }

	}

	private class ConnectResult : IGoogleConnectResult
	{
		private string <errorMessage>k__BackingField; //Field offset: 0x8
		private int <errorCode>k__BackingField; //Field offset: 0xC

		public int errorCode
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public string errorMessage
		{
			 get { } //Length: 6
			 set { } //Length: 8
		}

		public ConnectResult() { }

		public int get_errorCode() { }

		public string get_errorMessage() { }

		public void set_errorCode(int value) { }

		public void set_errorMessage(string value) { }

	}

	private class GoogleProfile : IGoogleProfile
	{
		private string <displayName>k__BackingField; //Field offset: 0x8
		private string <photoUrl>k__BackingField; //Field offset: 0xC
		private string <idToken>k__BackingField; //Field offset: 0x10
		private string <userId>k__BackingField; //Field offset: 0x14

		public string displayName
		{
			 get { } //Length: 6
			 set { } //Length: 8
		}

		public string idToken
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public string photoUrl
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public string userId
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public GoogleProfile() { }

		public string get_displayName() { }

		public string get_idToken() { }

		public string get_photoUrl() { }

		public string get_userId() { }

		public void set_displayName(string value) { }

		public void set_idToken(string value) { }

		public void set_photoUrl(string value) { }

		public void set_userId(string value) { }

	}

	private class GoogleSignInResult : IGoogleSignInResult
	{
		private IGoogleProfile <profile>k__BackingField; //Field offset: 0x8
		private string <errorMessage>k__BackingField; //Field offset: 0xC
		private int <errorCode>k__BackingField; //Field offset: 0x10

		public int errorCode
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public string errorMessage
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public IGoogleProfile profile
		{
			 get { } //Length: 6
			 set { } //Length: 8
		}

		public GoogleSignInResult() { }

		public int get_errorCode() { }

		public string get_errorMessage() { }

		public IGoogleProfile get_profile() { }

		public void set_errorCode(int value) { }

		public void set_errorMessage(string value) { }

		public void set_profile(IGoogleProfile value) { }

	}

	private class ProfilePayload
	{
		public string displayName; //Field offset: 0x8
		public string photoUrl; //Field offset: 0xC
		public string idToken; //Field offset: 0x10
		public string userId; //Field offset: 0x14

		public ProfilePayload() { }

	}

	private class SignInResultReceivedPayload
	{
		public ProfilePayload profile; //Field offset: 0x8
		public string errorMessage; //Field offset: 0xC
		public int errorCode; //Field offset: 0x10

		public SignInResultReceivedPayload() { }

	}

	private bool _connectionIsSuspended; //Field offset: 0xC
	private GoogleSignInBridgeRequest<IGoogleConnectResult> _pendingConnectRequest; //Field offset: 0x10
	private GoogleSignInBridgeRequest<IGoogleSignInResult> _pendingSignInRequest; //Field offset: 0x14
	private GoogleSignInBridgeRequest<IGoogleSignOutResult> _pendingSignOutRequest; //Field offset: 0x18

	protected GoogleSignInBridge() { }

	public Coroutine Connect(GoogleSignInBridgeRequest<IGoogleConnectResult> request) { }

	private IEnumerator ConnectCoroutine(GoogleSignInBridgeRequest<IGoogleConnectResult> request) { }

	public void Dispose() { }

	public bool IsConnected() { }

	private void OnGoogleConnected() { }

	private void OnGoogleConnectionFailed(string payload) { }

	private void OnGoogleConnectionSuspended(string payload) { }

	private void OnGoogleSignedOut() { }

	private void OnGoogleSignInResultReceived(string payload) { }

	protected abstract void PluginConnect() { }

	protected abstract bool PluginIsConnected() { }

	protected abstract bool PluginSignIn(bool silent) { }

	protected abstract bool PluginSignOut() { }

	public Coroutine SignIn(GoogleSignInBridgeRequest<IGoogleSignInResult> request, bool silent) { }

	private IEnumerator SignInCoroutine(GoogleSignInBridgeRequest<IGoogleSignInResult> request, bool silent) { }

	public Coroutine SignOut(GoogleSignInBridgeRequest<IGoogleSignOutResult> request) { }

	private IEnumerator SignOutCoroutine(GoogleSignInBridgeRequest<IGoogleSignOutResult> request) { }

	private IGoogleProfile ToGoogleProfile(ProfilePayload profile) { }

	private IGoogleSignInResult ToGoogleSignInResult(SignInResultReceivedPayload signInResultReceivedPayload) { }

}

