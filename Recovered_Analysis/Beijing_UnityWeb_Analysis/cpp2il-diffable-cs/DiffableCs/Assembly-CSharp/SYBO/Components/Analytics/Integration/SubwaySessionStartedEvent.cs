namespace SYBO.Components.Analytics.Integration;

public class SubwaySessionStartedEvent : SessionStartedEvent, ISubwayBaseEvent
{
	public long HighScore; //Field offset: 0x20
	public long CoinBalance; //Field offset: 0x28
	public long KeyBalance; //Field offset: 0x30

	public int SessionEventId
	{
		 get { } //Length: 6
	}

	public SubwaySessionStartedEvent() { }

	public int get_SessionEventId() { }

}

