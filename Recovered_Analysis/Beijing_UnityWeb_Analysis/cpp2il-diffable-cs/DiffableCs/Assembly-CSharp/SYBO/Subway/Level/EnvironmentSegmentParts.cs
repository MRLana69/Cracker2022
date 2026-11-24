namespace SYBO.Subway.Level;

public struct EnvironmentSegmentParts
{
	public const string FieldPatternLeft = "Left"; //Field offset: 0x0
	public const string FieldPatternRight = "Right"; //Field offset: 0x0
	public const string FieldPatternJoint = "Joint"; //Field offset: 0x0
	public Transform Left; //Field offset: 0x0
	public Transform Right; //Field offset: 0x4
	public Transform Joint; //Field offset: 0x8

}

