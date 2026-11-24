namespace SYBO.Subway.Level;

public class EnvironmentKind
{
	public const string FieldPatternType = "_type"; //Field offset: 0x0
	public static readonly EnvironmentKind Empty; //Field offset: 0x0
	public static readonly EnvironmentKind FillersLow; //Field offset: 0x4
	public static readonly EnvironmentKind FillersMedium; //Field offset: 0x8
	public static readonly EnvironmentKind FillersHigh; //Field offset: 0xC
	public static readonly EnvironmentKind Gates; //Field offset: 0x10
	public static readonly EnvironmentKind Tube; //Field offset: 0x14
	public static readonly EnvironmentKind Pillars; //Field offset: 0x18
	public static readonly EnvironmentKind Station; //Field offset: 0x1C
	public static readonly EnvironmentKind Epic; //Field offset: 0x20
	public static readonly EnvironmentKind[] All; //Field offset: 0x24
	public static readonly EnvironmentKind[] AllUnconstrained; //Field offset: 0x28
	public static readonly EnvironmentKind[] AllWithSplitPieces; //Field offset: 0x2C
	private EnvironmentType _type; //Field offset: 0x8
	private EnvironmentDensity _density; //Field offset: 0xC

	public EnvironmentDensity Density
	{
		 get { } //Length: 6
	}

	public bool IsRepeatable
	{
		 get { } //Length: 6
	}

	public static EnvironmentKind None
	{
		 get { } //Length: 101
	}

	public EnvironmentType Type
	{
		 get { } //Length: 469
	}

	private static EnvironmentKind() { }

	public EnvironmentKind(EnvironmentType type, EnvironmentDensity density) { }

	public override bool Equals(object other) { }

	public bool Equals(EnvironmentKind other) { }

	public EnvironmentDensity get_Density() { }

	public bool get_IsRepeatable() { }

	public static EnvironmentKind get_None() { }

	public EnvironmentType get_Type() { }

	public static EnvironmentDensity GetDefaultDensity(EnvironmentType envType) { }

	public override int GetHashCode() { }

	public EnvironmentKind GetValidated() { }

	public static bool IsValidDensity(EnvironmentKind envKind) { }

	public static bool op_Equality(EnvironmentKind c1, EnvironmentKind c2) { }

	public static bool op_Inequality(EnvironmentKind c1, EnvironmentKind c2) { }

	public override string ToString() { }

}

