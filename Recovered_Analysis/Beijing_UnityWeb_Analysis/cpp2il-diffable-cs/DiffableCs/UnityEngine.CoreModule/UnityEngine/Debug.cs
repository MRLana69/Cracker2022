namespace UnityEngine;

public class Debug
{
	internal static ILogger s_Logger; //Field offset: 0x0

	public static bool isDebugBuild
	{
		 get { } //Length: 89
	}

	public static ILogger unityLogger
	{
		 get { } //Length: 89
	}

	private static Debug() { }

	public static void Break() { }

	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	public static bool get_isDebugBuild() { }

	public static ILogger get_unityLogger() { }

	public static void Log(object message, Object context) { }

	public static void Log(object message) { }

	public static void LogAssertion(object message) { }

	public static void LogError(object message) { }

	public static void LogError(object message, Object context) { }

	public static void LogErrorFormat(string format, object[] args) { }

	public static void LogErrorFormat(Object context, string format, object[] args) { }

	public static void LogException(Exception exception) { }

	public static void LogException(Exception exception, Object context) { }

	public static void LogFormat(string format, object[] args) { }

	public static void LogFormat(Object context, string format, object[] args) { }

	public static void LogWarning(object message) { }

	public static void LogWarning(object message, Object context) { }

	public static void LogWarningFormat(string format, object[] args) { }

	public static void LogWarningFormat(Object context, string format, object[] args) { }

}

