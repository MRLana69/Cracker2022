namespace SYBO.Subway.Level;

public class EnvironmentBaseInfo : IEquatable<EnvironmentBaseInfo>
{
	public static readonly EnvironmentBaseInfo Tracks0; //Field offset: 0x0
	public static readonly EnvironmentBaseInfo Tracks1; //Field offset: 0x4
	public static readonly EnvironmentBaseInfo Tracks1ShadowMid; //Field offset: 0x8
	public static readonly EnvironmentBaseInfo Tracks1ShortShadowStart; //Field offset: 0xC
	public static readonly EnvironmentBaseInfo Tracks1ShortShadowEnd; //Field offset: 0x10
	public static readonly EnvironmentBaseInfo Tracks2; //Field offset: 0x14
	public static readonly EnvironmentBaseInfo Tracks2ShadowMid; //Field offset: 0x18
	public static readonly EnvironmentBaseInfo Tracks2ShortShadowStart; //Field offset: 0x1C
	public static readonly EnvironmentBaseInfo Tracks2ShortShadowEnd; //Field offset: 0x20
	public static readonly EnvironmentBaseInfo Tracks3; //Field offset: 0x24
	public static readonly EnvironmentBaseInfo Tracks3ShadowStart; //Field offset: 0x28
	public static readonly EnvironmentBaseInfo Tracks3ShadowMid; //Field offset: 0x2C
	public static readonly EnvironmentBaseInfo Tracks3ShadowEnd; //Field offset: 0x30
	public static readonly EnvironmentBaseInfo Tracks3ShortShadowStart; //Field offset: 0x34
	public static readonly EnvironmentBaseInfo Tracks3ShortShadowEnd; //Field offset: 0x38
	public static readonly EnvironmentBaseInfo Tracks3Gates; //Field offset: 0x3C
	public static readonly EnvironmentBaseInfo Tracks3GatesShadow; //Field offset: 0x40
	public static readonly EnvironmentBaseInfo Tracks3Special; //Field offset: 0x44
	private static readonly Dictionary<EnvironmentBaseInfo, string> AllGroundKinds; //Field offset: 0x48
	public readonly EnvironmentBaseKind EnvironmentBaseKind; //Field offset: 0x8
	public readonly int LengthInBlocks; //Field offset: 0x14

	private static EnvironmentBaseInfo() { }

	public EnvironmentBaseInfo(EnvironmentBaseKind environmentBaseType, int lengthInBlocks) { }

	public override bool Equals(object other) { }

	public bool Equals(EnvironmentBaseInfo other) { }

	public override int GetHashCode() { }

	public static string GetName(EnvironmentBaseInfo groundInfo) { }

	public static bool op_Equality(EnvironmentBaseInfo c1, EnvironmentBaseInfo c2) { }

	public static bool op_Inequality(EnvironmentBaseInfo c1, EnvironmentBaseInfo c2) { }

	public override string ToString() { }

}

