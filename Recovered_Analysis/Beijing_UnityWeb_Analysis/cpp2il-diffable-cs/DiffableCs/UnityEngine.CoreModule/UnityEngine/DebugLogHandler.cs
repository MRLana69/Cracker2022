namespace UnityEngine;

internal sealed class DebugLogHandler : ILogHandler
{

	public DebugLogHandler() { }

	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	internal static void Internal_LogException(Exception exception, Object obj) { }

	public void LogException(Exception exception, Object context) { }

	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

}

