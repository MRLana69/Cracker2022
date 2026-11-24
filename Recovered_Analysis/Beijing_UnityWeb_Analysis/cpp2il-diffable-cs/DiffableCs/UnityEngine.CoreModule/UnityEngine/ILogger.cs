namespace UnityEngine;

public interface ILogger : ILogHandler
{

	public ILogHandler logHandler
	{
		 get { } //Length: 0
	}

	public ILogHandler get_logHandler() { }

	public void Log(LogType logType, object message) { }

	public void Log(LogType logType, object message, Object context) { }

	public void LogFormat(LogType logType, string format, object[] args) { }

}

