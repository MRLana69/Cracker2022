using System;
using SYBO.Components.BuildSizeMonitor;
using SYBO.Components.ComponentsManager;
using SYBO.Components.Logging;

namespace SYBO.Components.Settings;

public static class StaticSettings
{
	public static BuildSizeMonitorSettings BuildSizeMonitor;

	public static ComponentsManagerSettings ComponentsManager;

	public static LogSettings Log;

	public static RuntimeSettings Runtime;

	[NonSerialized]
	public static bool active;

	static StaticSettings()
	{
		BuildSizeMonitorSettings buildSizeMonitorSettings = default;
		buildSizeMonitorSettings._002Ector();
		BuildSizeMonitor = buildSizeMonitorSettings;
		ComponentsManagerSettings componentsManagerSettings = default;
		componentsManagerSettings._002Ector();
		ComponentsManager = componentsManagerSettings;
		RuntimeSettings runtime = default;
		Runtime = runtime;
		SettingsEngine.Load();
	}
}
