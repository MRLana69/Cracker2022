namespace SYBO.Components.Analytics.Integration;

public class SubwayAppEntersForegroundEvent : AppEntersForegroundEvent, ISubwayBaseEvent
{
	public string Uid => UserId;

	public string Id => EventId;

	public int SessionId => SessionID;

	public int EventNumber => SessionEventID;
}
