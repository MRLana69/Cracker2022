namespace SYBO.Components.Logging;

public class LogCategorySettings
{
	public string categoryText; //Field offset: 0x8
	public string categoryClassName; //Field offset: 0xC
	public bool pauseOnError; //Field offset: 0x10
	public bool pauseOnWarning; //Field offset: 0x11
	public int logLevel; //Field offset: 0x14
	public int hideStackLevel; //Field offset: 0x18
	public string messagePrefix; //Field offset: 0x1C
	public bool hasInitializedMessagePrefix; //Field offset: 0x20

	public LogCategorySettings() { }

}

