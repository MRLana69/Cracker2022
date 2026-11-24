namespace SYBO.Components.Analytics.Integration;

public class SubwayClientUpdatedEvent : ClientUpdatedEvent, ISubwayBaseEvent
{
	protected string KilooUserID; //Field offset: 0x2C
	protected string FirstStartupAt; //Field offset: 0x30

	public SubwayClientUpdatedEvent(string kilooUserID, string platformConfig, DateTime firstStartupAt) { }

}

