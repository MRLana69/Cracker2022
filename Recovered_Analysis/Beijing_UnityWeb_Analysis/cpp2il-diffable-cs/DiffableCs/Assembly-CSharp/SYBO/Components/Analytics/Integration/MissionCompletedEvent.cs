namespace SYBO.Components.Analytics.Integration;

public class MissionCompletedEvent : SubwayBaseSessionEvent
{
	public readonly string MissionSet; //Field offset: 0x24
	public readonly short MissionIndex; //Field offset: 0x28
	public readonly long SourceId; //Field offset: 0x30

	public override string EventName
	{
		 get { } //Length: 43
	}

	public MissionCompletedEvent(string missionSet, short missionIndex, long sourceId) { }

	public override string get_EventName() { }

}

