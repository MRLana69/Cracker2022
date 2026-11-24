namespace Kiloo.Google.Internal;

internal interface IGoogleSignInBridge : IDisposable
{

	public Coroutine Connect(GoogleSignInBridgeRequest<IGoogleConnectResult> request) { }

	public bool IsConnected() { }

	public Coroutine SignIn(GoogleSignInBridgeRequest<IGoogleSignInResult> request, bool silent) { }

	public Coroutine SignOut(GoogleSignInBridgeRequest<IGoogleSignOutResult> request) { }

}

