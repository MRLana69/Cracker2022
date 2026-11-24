namespace System.Diagnostics.Tracing;

public class EventSource : IDisposable
{
	private string <Name>k__BackingField; //Field offset: 0x8

	private string Name
	{
		 set { } //Length: 8
	}

	protected EventSource() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public bool IsEnabled() { }

	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	private void set_Name(string value) { }

	protected void WriteEvent(int eventId, int arg1) { }

	protected void WriteEvent(int eventId, object[] args) { }

}

