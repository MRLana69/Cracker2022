using System.Runtime.InteropServices;

namespace FirebaseWebGL.Scripts.FirebaseBridge;

public static class FirebaseStorage
{
	[PreserveSig]
	public static extern void UploadFile(string path, string data, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void DownloadFile(string path, string objectName, string callback, string fallback);
}
