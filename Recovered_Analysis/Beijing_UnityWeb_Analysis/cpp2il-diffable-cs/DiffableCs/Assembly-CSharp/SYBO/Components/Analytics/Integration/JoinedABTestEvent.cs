namespace SYBO.Components.Analytics.Integration;

public class JoinedABTestEvent : SubwayBaseSessionEvent
{
	public readonly string Tag; //Field offset: 0x24
	public readonly int SegmentIndex; //Field offset: 0x28

	public override string EventName
	{
		 get { } //Length: 43
	}

	public JoinedABTestEvent(string tag, int segmentIndex) { }

	public override string get_EventName() { }

}

