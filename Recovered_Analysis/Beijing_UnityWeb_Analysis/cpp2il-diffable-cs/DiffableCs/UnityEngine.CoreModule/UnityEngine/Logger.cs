namespace UnityEngine;

public class Logger : ILogger, ILogHandler
{
	private ILogHandler <logHandler>k__BackingField; //Field offset: 0x8
	private bool <logEnabled>k__BackingField; //Field offset: 0xC
	private LogType <filterLogType>k__BackingField; //Field offset: 0x10

	public LogType filterLogType
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool logEnabled
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public ILogHandler logHandler
	{
		 get { } //Length: 29
		 set { } //Length: 25
	}

	public Logger(ILogHandler logHandler) { }

	public LogType get_filterLogType() { }

	public bool get_logEnabled() { }

	public ILogHandler get_logHandler() { }

	private static string GetString(object message) { }

	public bool IsLogTypeAllowed(LogType logType) { }

	public void Log(LogType logType, object message) { }

	public void Log(LogType logType, object message, Object context) { }

	public void LogException(Exception exception, Object context) { }

	public void LogFormat(LogType logType, string format, object[] args) { }

	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	public void set_filterLogType(LogType value) { }

	public void set_logEnabled(bool value) { }

	public void set_logHandler(ILogHandler value) { }

}

