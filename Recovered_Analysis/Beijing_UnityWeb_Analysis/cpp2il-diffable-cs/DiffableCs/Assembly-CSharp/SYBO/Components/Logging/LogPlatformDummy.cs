namespace SYBO.Components.Logging;

public class LogPlatformDummy : ILogPlatform
{

	public LogPlatformDummy() { }

	private void SYBO.Components.Logging.ILogPlatform.LogErrorFormat(LogCategory logCategory, int logLevel, Object context, string format, object[] args) { }

	private void SYBO.Components.Logging.ILogPlatform.LogErrorFormat(LogCategory logCategory, int logLevel, string format, object[] args) { }

	private void SYBO.Components.Logging.ILogPlatform.LogException(LogCategory logCategory, int logLevel, Exception exception) { }

	private void SYBO.Components.Logging.ILogPlatform.LogFormat(LogCategory logCategory, int logLevel, Object context, string format, object[] args) { }

	private void SYBO.Components.Logging.ILogPlatform.LogFormat(LogCategory logCategory, int logLevel, string format, object[] args) { }

	private void SYBO.Components.Logging.ILogPlatform.LogLongString(LogCategory logCategory, int level, string data) { }

	private void SYBO.Components.Logging.ILogPlatform.LogWarningFormat(LogCategory logCategory, int logLevel, Object context, string format, object[] args) { }

	private void SYBO.Components.Logging.ILogPlatform.LogWarningFormat(LogCategory logCategory, int logLevel, string format, object[] args) { }

}

