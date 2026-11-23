using System.Runtime.InteropServices;

namespace FirebaseWebGL.Scripts.FirebaseBridge;

public static class FirebaseDatabase
{
	[PreserveSig]
	public static extern void GetJSON(string path, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void PostJSON(string path, string value, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void PushJSON(string path, string value, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void UpdateJSON(string path, string value, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void DeleteJSON(string path, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void ListenForValueChanged(string path, string objectName, string onValueChanged, string fallback);

	[PreserveSig]
	public static extern void StopListeningForValueChanged(string path, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void ListenForChildAdded(string path, string objectName, string onChildAdded, string fallback);

	[PreserveSig]
	public static extern void StopListeningForChildAdded(string path, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void ListenForChildChanged(string path, string objectName, string onChildChanged, string fallback);

	[PreserveSig]
	public static extern void StopListeningForChildChanged(string path, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void ListenForChildRemoved(string path, string objectName, string onChildRemoved, string fallback);

	[PreserveSig]
	public static extern void StopListeningForChildRemoved(string path, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void ModifyNumberWithTransaction(string path, float amount, string objectName, string callback, string fallback);

	[PreserveSig]
	public static extern void ToggleBooleanWithTransaction(string path, string objectName, string callback, string fallback);
}
