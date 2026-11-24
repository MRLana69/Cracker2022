namespace SYBO.Components.Logging;

public interface IWriteLog
{

	public void LogErrorFormat(Object context, int level, string format, object[] args) { }

	public void LogErrorFormat(Object context, int level, string format, object arg1, object arg2) { }

	public void LogErrorFormat(Object context, int level, string format, object arg1) { }

	public void LogErrorFormat(Object context, int level, string format) { }

	public void LogErrorFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(int level, string format, object[] args) { }

	public void LogErrorFormat(int level, string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(int level, string format, object arg1, object arg2) { }

	public void LogErrorFormat(int level, string format, object arg1) { }

	public void LogErrorFormat(int level, string format) { }

	public void LogException(int level, Exception exception) { }

	public void LogException(Exception exception) { }

	public void LogFormat(Object context, int level, string format, object[] args) { }

	public void LogFormat(int level, string format, object arg1) { }

	public void LogFormat(int level, string format, object arg1, object arg2) { }

	public void LogFormat(int level, string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(Object context, int level, string format, object arg1, object arg2) { }

	public void LogFormat(Object context, int level, string format, object arg1) { }

	public void LogFormat(int level, string format) { }

	public void LogFormat(int level, string format, object[] args) { }

	public void LogFormat(Object context, int level, string format) { }

	public void LogLongString(int level, string data) { }

	public void LogWarningFormat(int level, string format, object[] args) { }

	public void LogWarningFormat(Object context, int level, string format) { }

	public void LogWarningFormat(Object context, int level, string format, object arg1) { }

	public void LogWarningFormat(Object context, int level, string format, object arg1, object arg2) { }

	public void LogWarningFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	public void LogWarningFormat(Object context, int level, string format, object[] args) { }

	public void LogWarningFormat(int level, string format) { }

	public void LogWarningFormat(int level, string format, object arg1) { }

	public void LogWarningFormat(int level, string format, object arg1, object arg2) { }

	public void LogWarningFormat(int level, string format, object arg1, object arg2, object arg3) { }

}

