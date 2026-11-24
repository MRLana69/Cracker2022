namespace SYBO.Components.Settings;

public static class SettingsEngine
{
	private static readonly string _rootResourceName; //Field offset: 0x0
	private static readonly string _resourceLoadPath; //Field offset: 0x4
	private static object _loadLock; //Field offset: 0x8
	private static bool _isLoaded; //Field offset: 0xC
	private static ISettingsProvider _settingsProvider; //Field offset: 0x10

	private static SettingsEngine() { }

	public static void Backup() { }

	public static ISettingsProvider GetSettingsProvider() { }

	public static void Load() { }

	private static string ReadFileText(string filename) { }

	public static void Reload() { }

	public static void Restore() { }

	public static void Save() { }

}

