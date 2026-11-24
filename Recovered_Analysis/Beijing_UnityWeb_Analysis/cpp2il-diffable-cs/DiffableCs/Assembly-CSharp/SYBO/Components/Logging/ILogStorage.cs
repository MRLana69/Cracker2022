namespace SYBO.Components.Logging;

public interface ILogStorage
{

	public event Action<LogEntry> OnLogAdded
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action OnLogCleared
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public string FpsText
	{
		 get { } //Length: 0
	}

	public float GcTotalMemoryMB
	{
		 get { } //Length: 0
	}

	public string LogDate
	{
		 get { } //Length: 0
	}

	public float LogsMemUsageMB
	{
		 get { } //Length: 0
	}

	public int NumberOfCollapsedLogs
	{
		 get { } //Length: 0
	}

	public int NumberOfCollapsedLogsError
	{
		 get { } //Length: 0
	}

	public int NumberOfCollapsedLogsWarning
	{
		 get { } //Length: 0
	}

	public int NumberOfLogs
	{
		 get { } //Length: 0
	}

	public int NumberOfLogsError
	{
		 get { } //Length: 0
	}

	public int NumberOfLogsWarning
	{
		 get { } //Length: 0
	}

	public void add_OnLogAdded(Action<LogEntry> value) { }

	public void add_OnLogCleared(Action value) { }

	public void AddLogEntry(LogEntry entry) { }

	public bool Clear() { }

	public string get_FpsText() { }

	public float get_GcTotalMemoryMB() { }

	public string get_LogDate() { }

	public float get_LogsMemUsageMB() { }

	public int get_NumberOfCollapsedLogs() { }

	public int get_NumberOfCollapsedLogsError() { }

	public int get_NumberOfCollapsedLogsWarning() { }

	public int get_NumberOfLogs() { }

	public int get_NumberOfLogsError() { }

	public int get_NumberOfLogsWarning() { }

	public LogEntry GetCollapsedEntry(LogEntry selectedLog) { }

	public IList<LogEntry> GetCollapsedLogs() { }

	public IList<LogEntry> GetLogs() { }

	public Sample GetSample(int sampleId) { }

	public int GetSampleCount() { }

	public void remove_OnLogAdded(Action<LogEntry> value) { }

	public void remove_OnLogCleared(Action value) { }

	public bool StoreLogs() { }

	public void Tick() { }

}

