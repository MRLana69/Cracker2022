namespace SYBO.Components.Logging;

public abstract class LogCategory : IWriteLog
{
	protected static object[] _singleArgThreadStatic; //Field offset: 0x80000000
	protected static object[] _twoArgsThreadStatic; //Field offset: 0x80000004
	protected static object[] _threeArgsThreadStatic; //Field offset: 0x80000008
	private static ILogPlatform <LogEngine>k__BackingField; //Field offset: 0x0
	protected static readonly object[] _zeroArgs; //Field offset: 0x4
	public readonly int CategoryId; //Field offset: 0x8
	public string CategoryText; //Field offset: 0xC
	public string MessagePrefix; //Field offset: 0x10
	public int Level; //Field offset: 0x14
	public int HideStackLevel; //Field offset: 0x18

	protected static object[] _singleArg
	{
		 get { } //Length: 89
	}

	protected static object[] _threeArgs
	{
		 get { } //Length: 225
	}

	protected static object[] _twoArgs
	{
		 get { } //Length: 222
	}

	public static ILogPlatform LogEngine
	{
		 get { } //Length: 92
		 set { } //Length: 9
	}

	private static LogCategory() { }

	public LogCategory(int categoryId) { }

	public bool ApplySetting(LogCategorySettings setting) { }

	protected static object[] get__singleArg() { }

	protected static object[] get__threeArgs() { }

	protected static object[] get__twoArgs() { }

	public static ILogPlatform get_LogEngine() { }

	public virtual string[] GetCallstackPrefixes() { }

	public void LogErrorFormat(Enum level, string format, object[] args) { }

	public void LogErrorFormat(string format, object arg1) { }

	public void LogErrorFormat(string format, object arg1, object arg2) { }

	public void LogErrorFormat(string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(string format, object[] args) { }

	public void LogErrorFormat(int level, string format) { }

	public void LogErrorFormat(Enum level, string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(int level, string format, object arg1) { }

	public void LogErrorFormat(int level, string format, object arg1, object arg2) { }

	public void LogErrorFormat(int level, string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(int level, string format, object[] args) { }

	public void LogErrorFormat(Enum level, string format) { }

	public void LogErrorFormat(Enum level, string format, object arg1) { }

	public void LogErrorFormat(Object context, string format) { }

	public void LogErrorFormat(Enum level, string format, object arg1, object arg2) { }

	public void LogErrorFormat(Object context, string format, object arg1, object arg2) { }

	public void LogErrorFormat(Object context, Enum level, string format, object[] args) { }

	public void LogErrorFormat(Object context, Enum level, string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(Object context, Enum level, string format, object arg1, object arg2) { }

	public void LogErrorFormat(Object context, Enum level, string format, object arg1) { }

	public void LogErrorFormat(Object context, Enum level, string format) { }

	public void LogErrorFormat(Object context, string format, object arg1) { }

	public void LogErrorFormat(Object context, int level, string format, object[] args) { }

	public void LogErrorFormat(Object context, int level, string format, object arg1, object arg2) { }

	public void LogErrorFormat(Object context, int level, string format, object arg1) { }

	public void LogErrorFormat(Object context, int level, string format) { }

	public void LogErrorFormat(Object context, string format, object[] args) { }

	public void LogErrorFormat(Object context, string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	public void LogErrorFormat(string format) { }

	public void LogException(Exception exception) { }

	public void LogException(Enum level, Exception exception) { }

	public void LogException(int level, Exception exception) { }

	public void LogFormat(Object context, int level, string format, object arg1) { }

	public void LogFormat(Object context, string format, object arg1) { }

	public void LogFormat(Object context, string format, object arg1, object arg2) { }

	public void LogFormat(Object context, string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(Object context, int level, string format) { }

	public void LogFormat(Object context, int level, string format, object arg1, object arg2) { }

	public void LogFormat(Object context, int level, string format, object[] args) { }

	public void LogFormat(Object context, Enum level, string format) { }

	public void LogFormat(Object context, Enum level, string format, object arg1) { }

	public void LogFormat(Object context, Enum level, string format, object arg1, object arg2) { }

	public void LogFormat(Object context, Enum level, string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(Object context, Enum level, string format, object[] args) { }

	public void LogFormat(Object context, string format) { }

	public void LogFormat(string format) { }

	public void LogFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(Enum level, string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(string format, object arg1) { }

	public void LogFormat(string format, object arg1, object arg2) { }

	public void LogFormat(string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(string format, object[] args) { }

	public void LogFormat(int level, string format) { }

	public void LogFormat(int level, string format, object arg1) { }

	public void LogFormat(int level, string format, object arg1, object arg2) { }

	public void LogFormat(int level, string format, object arg1, object arg2, object arg3) { }

	public void LogFormat(int level, string format, object[] args) { }

	public void LogFormat(Enum level, string format) { }

	public void LogFormat(Enum level, string format, object arg1) { }

	public void LogFormat(Enum level, string format, object arg1, object arg2) { }

	public void LogFormat(Enum level, string format, object[] args) { }

	public void LogFormat(Object context, string format, object[] args) { }

	public void LogLongString(Enum level, string data) { }

	public void LogLongString(int level, string data) { }

	public void LogWarningFormat(string format) { }

	public void LogWarningFormat(Enum level, string format, object arg1, object arg2) { }

	public void LogWarningFormat(Enum level, string format, object arg1) { }

	public void LogWarningFormat(Enum level, string format) { }

	public void LogWarningFormat(int level, string format, object[] args) { }

	public void LogWarningFormat(int level, string format, object arg1, object arg2, object arg3) { }

	public void LogWarningFormat(string format, object arg1) { }

	public void LogWarningFormat(int level, string format, object arg1, object arg2) { }

	public void LogWarningFormat(int level, string format, object arg1) { }

	public void LogWarningFormat(int level, string format) { }

	public void LogWarningFormat(string format, object[] args) { }

	public void LogWarningFormat(string format, object arg1, object arg2, object arg3) { }

	public void LogWarningFormat(Enum level, string format, object[] args) { }

	public void LogWarningFormat(string format, object arg1, object arg2) { }

	public void LogWarningFormat(Enum level, string format, object arg1, object arg2, object arg3) { }

	public void LogWarningFormat(Object context, Enum level, string format, object arg1, object arg2, object arg3) { }

	public void LogWarningFormat(Object context, Enum level, string format, object[] args) { }

	public void LogWarningFormat(Object context, string format) { }

	public void LogWarningFormat(Object context, string format, object arg1) { }

	public void LogWarningFormat(Object context, string format, object arg1, object arg2) { }

	public void LogWarningFormat(Object context, string format, object arg1, object arg2, object arg3) { }

	public void LogWarningFormat(Object context, int level, string format) { }

	public void LogWarningFormat(Object context, int level, string format, object arg1) { }

	public void LogWarningFormat(Object context, string format, object[] args) { }

	public void LogWarningFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	public void LogWarningFormat(Object context, int level, string format, object[] args) { }

	public void LogWarningFormat(Object context, Enum level, string format) { }

	public void LogWarningFormat(Object context, Enum level, string format, object arg1) { }

	public void LogWarningFormat(Object context, Enum level, string format, object arg1, object arg2) { }

	public void LogWarningFormat(Object context, int level, string format, object arg1, object arg2) { }

	public static void set_LogEngine(ILogPlatform value) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(Object context, int level, string format, object arg1) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(Object context, int level, string format, object[] args) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(Object context, int level, string format, object arg1, object arg2) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(Object context, int level, string format) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(int level, string format, object arg1, object arg2, object arg3) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(int level, string format, object[] args) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(int level, string format, object arg1, object arg2) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(int level, string format, object arg1) { }

	private void SYBO.Components.Logging.IWriteLog.LogFormat(int level, string format) { }

	private void SYBO.Components.Logging.IWriteLog.LogLongString(int level, string data) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(int level, string format, object arg1) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(int level, string format, object arg1, object arg2) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(int level, string format, object arg1, object arg2, object arg3) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(int level, string format, object[] args) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(Object context, int level, string format) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(Object context, int level, string format, object arg1) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(Object context, int level, string format, object arg1, object arg2) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(Object context, int level, string format, object arg1, object arg2, object arg3) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(int level, string format) { }

	private void SYBO.Components.Logging.IWriteLog.LogWarningFormat(Object context, int level, string format, object[] args) { }

}

