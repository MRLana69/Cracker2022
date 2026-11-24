using System;

namespace SYBO.Components.Analytics.Integration;

public class JoinedABTestEvent : SubwayBaseSessionEvent
{
	public readonly string Tag;

	public readonly int SegmentIndex;

	public override string EventName => "offer_initiated";

	public JoinedABTestEvent(string tag, int segmentIndex)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		object obj = tag + 8;
		obj = tag;
		throw new ArrayTypeMismatchException();
	}
}
