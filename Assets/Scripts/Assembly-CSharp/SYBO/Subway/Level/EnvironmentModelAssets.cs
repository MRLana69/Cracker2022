using System;

namespace SYBO.Subway.Level;

[Serializable]
public class EnvironmentModelAssets
{
	public string Name;

	public const string FieldPatternEnvironment = "Environment";

	public EnvironmentKind Environment;

	public const string FieldPatternSequenceVariations = "SequenceVariations";

	public EnvironmentSegmentSequence[] SequenceVariations;
}
