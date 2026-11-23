using System;

namespace SYBO.Components.Analytics.Integration;

public class SubwayClientUpdatedEvent : ClientUpdatedEvent, ISubwayBaseEvent
{
	protected string KilooUserID;

	protected string PlatformConfig;

	protected string FirstStartupAt;

	public string Uid => UserId;

	public string Id => EventId;

	public int SessionId => SessionID;

	public int EventNumber => SessionEventID;

	public SubwayClientUpdatedEvent(string kilooUserID, string platformConfig, DateTime firstStartupAt)
	{
		KilooUserID = kilooUserID;
		PlatformConfig = platformConfig;
		string timeText = AnalyticsEvent.GetTimeText(firstStartupAt);
		FirstStartupAt = timeText;
	}
}
