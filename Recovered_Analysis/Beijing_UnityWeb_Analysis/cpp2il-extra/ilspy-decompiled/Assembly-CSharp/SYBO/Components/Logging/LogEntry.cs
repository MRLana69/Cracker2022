using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Logging;

public class LogEntry
{
	public int Count;

	public LogType EntryType;

	public string Condition;

	public string Stacktrace;

	public int SampleId;

	public int CategoryId;

	public bool WasDuplicate;

	public float time;

	public byte loadedScene;

	public float memory;

	public float fps;

	public string fpsText;

	public LogEntry()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public LogEntry CreateCopy()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		LogEntry result = default;
		return result;
	}

	public float GetMemoryUsage()
	{
		return time;
	}
}
