using System.Runtime.InteropServices;

namespace FirebaseWebGL.Scripts.FirebaseAnalytics;

public static class FirebaseAnalytics
{
	[PreserveSig]
	public static extern void SetUserProperties(string props);

	[PreserveSig]
	public static extern void LogEvent(string eventName);

	[PreserveSig]
	public static extern void LogEventParameter(string eventName, string eventParam);
}
