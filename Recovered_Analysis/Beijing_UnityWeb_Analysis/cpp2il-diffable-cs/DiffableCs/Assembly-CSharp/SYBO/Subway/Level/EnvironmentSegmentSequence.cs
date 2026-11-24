namespace SYBO.Subway.Level;

public struct EnvironmentSegmentSequence
{
	public const string FieldPatternStart = "Start"; //Field offset: 0x0
	public const string FieldPatternMid = "Mid"; //Field offset: 0x0
	public const string FieldPatternEnd = "End"; //Field offset: 0x0
	public EnvironmentSegmentParts Start; //Field offset: 0x0
	public EnvironmentSegmentParts Mid; //Field offset: 0xC
	public EnvironmentSegmentParts End; //Field offset: 0x18

}

