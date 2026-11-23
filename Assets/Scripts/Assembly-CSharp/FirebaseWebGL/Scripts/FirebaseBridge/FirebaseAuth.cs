using System.Runtime.InteropServices;

namespace FirebaseWebGL.Scripts.FirebaseBridge;

public static class FirebaseAuth
{
	[PreserveSig]
	public static extern void SignInAnonymously(string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void CreateUserWithEmailAndPassword(string email, string password, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void SignInWithEmailAndPassword(string email, string password, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void SignInWithGoogle(string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void SignInWithFacebook(string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void OnAuthStateChanged(string objectName, string onUserSignedIn, string onUserSignedOut);
}
