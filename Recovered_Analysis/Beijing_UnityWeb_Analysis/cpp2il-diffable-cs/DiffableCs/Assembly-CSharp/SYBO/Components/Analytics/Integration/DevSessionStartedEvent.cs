namespace SYBO.Components.Analytics.Integration;

public class DevSessionStartedEvent : SubwayBaseSessionEvent
{
	public readonly string OnlineSettings; //Field offset: 0x24
	public readonly string Branch; //Field offset: 0x28
	public readonly int Revision; //Field offset: 0x2C
	public readonly int Modifications; //Field offset: 0x30

	public override string EventName
	{
		 get { } //Length: 43
	}

	public DevSessionStartedEvent(string onlineSettings, string branch, int revision, bool modifications) { }

	public override string get_EventName() { }

}

