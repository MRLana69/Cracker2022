namespace SYBO.Components.Settings;

public class DefaultSettingsProvider : ISettingsProvider
{
	private ISettingsParser _reader; //Field offset: 0x8

	public DefaultSettingsProvider(ISettingsParser reader) { }

	private object SYBO.Components.Settings.ISettingsProvider.ReflectionGetSettings(Type settingsType) { }

}

