namespace SYBO.Components.Analytics.Integration;

public class SubwaySessionStartedEvent : SessionStartedEvent, ISubwayBaseEvent
{
	public long HighScore;

	public long CoinBalance;

	public long KeyBalance;

	public string Uid => UserId;

	public string Id => EventId;

	public int SessionId => SessionID;

	public int EventNumber => -1;

	public string Version => GameVersion;
}
