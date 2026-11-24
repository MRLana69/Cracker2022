namespace SYBO.Components.Logging;

public class LogEntry
{
	public int Count; //Field offset: 0x8
	public LogType EntryType; //Field offset: 0xC
	public string Condition; //Field offset: 0x10
	public string Stacktrace; //Field offset: 0x14
	public int SampleId; //Field offset: 0x18
	public int CategoryId; //Field offset: 0x1C
	public bool WasDuplicate; //Field offset: 0x20
	public float time; //Field offset: 0x24
	public byte loadedScene; //Field offset: 0x28
	public float memory; //Field offset: 0x2C
	public float fps; //Field offset: 0x30
	public string fpsText; //Field offset: 0x34

	public LogEntry() { }

	public LogEntry CreateCopy() { }

	public float GetMemoryUsage() { }

}

