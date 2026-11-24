namespace SYBO.Components.Analytics;

public class AppLeavesForegroundEvent : BaseSessionEvent
{

	public override string EventName
	{
		 get { } //Length: 43
	}

	public AppLeavesForegroundEvent() { }

	public AppLeavesForegroundEvent(DateTime eventTime, int sessionDelta) { }

	public override string get_EventName() { }

}

