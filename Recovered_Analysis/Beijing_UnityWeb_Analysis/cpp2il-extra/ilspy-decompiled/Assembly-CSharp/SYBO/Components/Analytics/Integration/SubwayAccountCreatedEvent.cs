using System;

namespace SYBO.Components.Analytics.Integration;

public class SubwayAccountCreatedEvent : AccountCreatedEvent, ISubwayBaseEvent
{
	protected string KilooUserID;

	protected string FirstStartupAt;

	public string KilooId => "game_continued";

	public SubwayAccountCreatedEvent(string kilooUserID, string platformConfig, DateTime firstStartupAt)
	{
	}
}
