namespace SYBO.Components.Analytics.Integration;

public abstract class SubwayBaseSessionEvent : BaseSessionEvent, ISubwayBaseEvent
{
	public string Uid => UserId;

	public string Id => EventId;

	public int SessionId => SessionID;

	public int EventNumber => SessionEventID;
}
