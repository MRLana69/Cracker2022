namespace SYBO.Components.Logging;

public interface ILogPlatform
{

	public void LogErrorFormat(LogCategory logCategory, int logLevel, Object context, string format, object[] args) { }

	public void LogErrorFormat(LogCategory logCategory, int logLevel, string format, object[] args) { }

	public void LogException(LogCategory logCategory, int logLevel, Exception exception) { }

	public void LogFormat(LogCategory logCategory, int logLevel, Object context, string format, object[] args) { }

	public void LogFormat(LogCategory logCategory, int logLevel, string format, object[] args) { }

	public void LogLongString(LogCategory logCategory, int level, string data) { }

	public void LogWarningFormat(LogCategory logCategory, int logLevel, Object context, string format, object[] args) { }

	public void LogWarningFormat(LogCategory logCategory, int logLevel, string format, object[] args) { }

}

