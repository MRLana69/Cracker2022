using System;

namespace SYBO.Components.Analytics.Integration;

public class SubwayClientUpdatedEvent : ClientUpdatedEvent, ISubwayBaseEvent
{
	protected string KilooUserID;

	protected string FirstStartupAt;

	public SubwayClientUpdatedEvent(string kilooUserID, string platformConfig, DateTime firstStartupAt)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got VT
		object obj = this + 8;
		obj = kilooUserID;
		_eventID = platformConfig;
		_gameVersion = (string)firstStartupAt;
	}
}
