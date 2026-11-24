namespace SYBO.Components.Analytics;

public class SessionStartedEvent : AnalyticsEvent
{
	public static Func<int> GetIncrementedSessionID; //Field offset: 0x0
	protected int _sessionID; //Field offset: 0x18

	public override string EventName
	{
		 get { } //Length: 6
	}

	public int SessionId
	{
		 get { } //Length: 70
	}

	public SessionStartedEvent() { }

	public override string get_EventName() { }

	public int get_SessionId() { }

}

