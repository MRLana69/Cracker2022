namespace SYBO.Components.Analytics.Integration;

public class SubwayAccountCreatedEvent : AccountCreatedEvent, ISubwayBaseEvent
{
	protected string KilooUserID; //Field offset: 0x2C
	protected string FirstStartupAt; //Field offset: 0x30

	public string KilooId
	{
		 get { } //Length: 43
	}

	public SubwayAccountCreatedEvent(string kilooUserID, string platformConfig, DateTime firstStartupAt) { }

	public string get_KilooId() { }

}

