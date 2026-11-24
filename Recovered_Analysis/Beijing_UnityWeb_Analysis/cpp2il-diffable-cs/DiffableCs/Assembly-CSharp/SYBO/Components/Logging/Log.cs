namespace SYBO.Components.Logging;

public static class Log
{
	public static AnalyticsLogCategory Analytics; //Field offset: 0x0
	public static BuildSizeMonitorLogCategory BuildSizeMonitor; //Field offset: 0x4
	public static ComponentsManagerLogCategory ComponentsManager; //Field offset: 0x8
	public static CompressionLogCategory Compression; //Field offset: 0xC
	public static CryptLogCategory Crypt; //Field offset: 0x10
	public static EditorExtensionsLogCategory EditorExtensions; //Field offset: 0x14
	public static JsonLogCategory Json; //Field offset: 0x18
	public static LogDefault Default; //Field offset: 0x1C
	public static LogSystemLogCategory LogSystem; //Field offset: 0x20
	public static NativeLogCategory Native; //Field offset: 0x24
	public static SettingsLogCategory Settings; //Field offset: 0x28
	public static SingletonsLogCategory Singletons; //Field offset: 0x2C
	public static PoolManagerLogCategory PoolManager; //Field offset: 0x30
	public static UtilitiesCategory Utilities; //Field offset: 0x34

	private static Log() { }

}

