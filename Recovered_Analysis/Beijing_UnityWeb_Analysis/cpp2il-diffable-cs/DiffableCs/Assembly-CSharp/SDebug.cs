//Type is in global namespace

public static class SDebug
{
	private const int UNITY_LOG_MAXIMUM_CHAR_LIMIT = 15500; //Field offset: 0x0

	public static void Log(object message, Object context = null) { }

	public static void LogAssertion(object message, Object context) { }

	public static void LogAssertion(object message) { }

	public static void LogAssertionFormat(Object context, string format, object[] args) { }

	public static void LogAssertionFormat(string format, object[] args) { }

	public static void LogError(object message, Object context = null) { }

	public static void LogErrorFormat(string msg, object[] args) { }

	public static void LogErrorFormat(Object context, string msg, object[] args) { }

	public static void LogException(Exception exception, Object context) { }

	public static void LogException(Exception exception) { }

	private static void LogExtendedMessage(string fullLog, Object context = null) { }

	public static void LogFormat(string msg, object[] args) { }

	public static void LogFormat(Object context, string msg, object[] args) { }

	public static void LogWarning(object message, Object context = null) { }

	public static void LogWarningFormat(Object context, string msg, object[] args) { }

	public static void LogWarningFormat(string msg, object[] args) { }

	private static bool MessageExceedsLimit(string fullLog) { }

}

