namespace SYBO.Components.Settings;

public static class StaticSettings
{
	public static BuildSizeMonitorSettings BuildSizeMonitor; //Field offset: 0x0
	public static ComponentsManagerSettings ComponentsManager; //Field offset: 0x4
	public static LogSettings Log; //Field offset: 0x8
	public static RuntimeSettings Runtime; //Field offset: 0xC
	public static bool active; //Field offset: 0x10

	private static StaticSettings() { }

}

