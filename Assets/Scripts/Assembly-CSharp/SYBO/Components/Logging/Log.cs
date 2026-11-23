using SYBO.Components.Analytics;
using SYBO.Components.BuildSizeMonitor;
using SYBO.Components.ComponentsManager;
using SYBO.Components.Compression;
using SYBO.Components.Crypt;
using SYBO.Components.Json;
using SYBO.Components.Settings;
using SYBO.Components.Utilities;

namespace SYBO.Components.Logging;

public static class Log
{
	public static AnalyticsLogCategory Analytics;

	public static BuildSizeMonitorLogCategory BuildSizeMonitor;

	public static ComponentsManagerLogCategory ComponentsManager;

	public static CompressionLogCategory Compression;

	public static CryptLogCategory Crypt;

	public static JsonLogCategory Json;

	public static LogAlbatrossFlow Flow;

	public static LogEveryPlay EveryPlay;

	public static LogGameState GameState;

	public static LogGameStateMachine StateMachine;

	public static LogLevenGeneration LevelGen;

	public static LogSponsorPay SponsorPay;

	public static LogUIFSMFlow FSM;

	public static LogDefault Default;

	public static LogSystemLogCategory LogSystem;

	public static SettingsLogCategory Settings;

	public static PoolManagerLogCategory PoolManager;

	public static UtilitiesCategory Utilities;

	static Log()
	{
		//IL_000e: Expected VT, but got Obj
		_00210 val = (_00210)Singleton<>.Instance;
	}
}
