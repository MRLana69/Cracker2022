namespace SYBO.Subway.Level;

public class EnvironmentModelAssets
{
	public const string FieldPatternEnvironment = "Environment"; //Field offset: 0x0
	public const string FieldPatternSequenceVariations = "SequenceVariations"; //Field offset: 0x0
	public string Name; //Field offset: 0x8
	public EnvironmentKind Environment; //Field offset: 0xC
	public EnvironmentSegmentSequence[] SequenceVariations; //Field offset: 0x10

	public EnvironmentModelAssets() { }

}

