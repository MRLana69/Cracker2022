namespace System.Diagnostics.Tracing;

public sealed class EventAttribute : Attribute
{
	private int <EventId>k__BackingField; //Field offset: 0x8
	private EventLevel <Level>k__BackingField; //Field offset: 0xC

	private int EventId
	{
		 set { } //Length: 8
	}

	public EventLevel Level
	{
		 set { } //Length: 8
	}

	public EventAttribute(int eventId) { }

	private void set_EventId(int value) { }

	public void set_Level(EventLevel value) { }

}

