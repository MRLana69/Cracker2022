namespace SYBO.Components.Logging;

public class LogSettings
{
	public float MemoryBudget; //Field offset: 0x8
	public Dictionary<string, LogCategorySettings> Categories; //Field offset: 0xC
	public string LogsPathWin; //Field offset: 0x10
	public LogFTPSettings Ftp; //Field offset: 0x14
	public UnityEvent Changed; //Field offset: 0x18
	public bool ClearOnNewSceneLoaded; //Field offset: 0x1C

	public LogSettings() { }

	public int GetLogLevel(string categoryName) { }

	public bool HasLogLevel(string categoryName) { }

}

