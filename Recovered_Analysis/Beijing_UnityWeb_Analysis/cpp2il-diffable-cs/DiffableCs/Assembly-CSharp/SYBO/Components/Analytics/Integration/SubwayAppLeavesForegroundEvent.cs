namespace SYBO.Components.Analytics.Integration;

public class SubwayAppLeavesForegroundEvent : SubwayBaseSessionEvent
{

	public override string EventName
	{
		 get { } //Length: 3
	}

	public SubwayAppLeavesForegroundEvent() { }

	public SubwayAppLeavesForegroundEvent(DateTime eventTime, int sessionDelta) { }

	public override string get_EventName() { }

}

