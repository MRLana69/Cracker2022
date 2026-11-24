namespace UnityEngine.Networking;

public class LogFilter
{
	public enum FilterLevel
	{
		Developer = 0,
		Debug = 1,
		Info = 2,
		Warn = 3,
		Error = 4,
		Fatal = 5,
		SetInScripting = -1,
	}

	internal const int Developer = 0; //Field offset: 0x0
	internal const int SetInScripting = -1; //Field offset: 0x0
	public const int Debug = 1; //Field offset: 0x0
	public const int Info = 2; //Field offset: 0x0
	public const int Warn = 3; //Field offset: 0x0
	public const int Error = 4; //Field offset: 0x0
	public const int Fatal = 5; //Field offset: 0x0
	public static FilterLevel current; //Field offset: 0x0
	private static int s_CurrentLogLevel; //Field offset: 0x4

	public static int currentLogLevel
	{
		 get { } //Length: 115
		 set { } //Length: 174
	}

	public static bool logDebug
	{
		 get { } //Length: 92
	}

	internal static bool logDev
	{
		 get { } //Length: 89
	}

	public static bool logError
	{
		 get { } //Length: 92
	}

	public static bool logFatal
	{
		 get { } //Length: 92
	}

	public static bool logInfo
	{
		 get { } //Length: 92
	}

	public static bool logWarn
	{
		 get { } //Length: 92
	}

	private static LogFilter() { }

	public LogFilter() { }

	public static int get_currentLogLevel() { }

	public static bool get_logDebug() { }

	internal static bool get_logDev() { }

	public static bool get_logError() { }

	public static bool get_logFatal() { }

	public static bool get_logInfo() { }

	public static bool get_logWarn() { }

	public static void set_currentLogLevel(int value) { }

}

