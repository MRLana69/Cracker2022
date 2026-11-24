namespace Kiloo.Google.Internal;

internal sealed class AndroidGoogleSignInBridge : GoogleSignInBridge
{

	public AndroidGoogleSignInBridge() { }

	public static GoogleSignInBridge Create() { }

	public static bool IsSupported() { }

	protected override void PluginConnect() { }

	private bool PluginInit() { }

	protected override bool PluginIsConnected() { }

	protected override bool PluginSignIn(bool silent) { }

	protected override bool PluginSignOut() { }

}

