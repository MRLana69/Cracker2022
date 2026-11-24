namespace SYBO.Subway.Level;

public struct EnvironmentBaseKind
{
	public static readonly EnvironmentBaseKind None; //Field offset: 0x0
	public static readonly EnvironmentBaseKind Empty; //Field offset: 0xC
	public static readonly EnvironmentBaseKind Tracks0; //Field offset: 0x18
	public static readonly EnvironmentBaseKind Tracks1; //Field offset: 0x24
	public static readonly EnvironmentBaseKind Tracks1ShadowStart; //Field offset: 0x30
	public static readonly EnvironmentBaseKind Tracks1ShadowMid; //Field offset: 0x3C
	public static readonly EnvironmentBaseKind Tracks1ShadowEnd; //Field offset: 0x48
	public static readonly EnvironmentBaseKind Tracks2; //Field offset: 0x54
	public static readonly EnvironmentBaseKind Tracks2ShadowStart; //Field offset: 0x60
	public static readonly EnvironmentBaseKind Tracks2ShadowMid; //Field offset: 0x6C
	public static readonly EnvironmentBaseKind Tracks2ShadowEnd; //Field offset: 0x78
	public static readonly EnvironmentBaseKind Tracks3; //Field offset: 0x84
	public static readonly EnvironmentBaseKind Tracks3ShadowStart; //Field offset: 0x90
	public static readonly EnvironmentBaseKind Tracks3ShadowMid; //Field offset: 0x9C
	public static readonly EnvironmentBaseKind Tracks3ShadowEnd; //Field offset: 0xA8
	public static readonly EnvironmentBaseKind Tracks3Gates; //Field offset: 0xB4
	public static readonly EnvironmentBaseKind Tracks3GatesShadow; //Field offset: 0xC0
	public static readonly EnvironmentBaseKind Tracks3Special; //Field offset: 0xCC
	public readonly EnvironmentBaseType Type; //Field offset: 0x0
	public readonly EnvironmentBaseShadowSequence ShadowSequence; //Field offset: 0x4
	public readonly int NumTracks; //Field offset: 0x8

	private static EnvironmentBaseKind() { }

	private EnvironmentBaseKind(EnvironmentBaseType envBaseType, EnvironmentBaseShadowSequence shadowSequence, int numTracks) { }

	public override bool Equals(object other) { }

	public bool Equals(EnvironmentBaseKind other) { }

	public override int GetHashCode() { }

	public static bool op_Equality(EnvironmentBaseKind c1, EnvironmentBaseKind c2) { }

	public static bool op_Inequality(EnvironmentBaseKind c1, EnvironmentBaseKind c2) { }

	public override string ToString() { }

}

