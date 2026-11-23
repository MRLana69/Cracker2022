using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Subway.Level;

public class EnvironmentBaseInfo : IEquatable<EnvironmentBaseInfo>
{
	public readonly EnvironmentBaseKind EnvironmentBaseKind;

	public readonly int LengthInBlocks;

	public static readonly EnvironmentBaseInfo Tracks0;

	public static readonly EnvironmentBaseInfo Tracks1;

	public static readonly EnvironmentBaseInfo Tracks1ShadowStart;

	public static readonly EnvironmentBaseInfo Tracks1ShadowMid;

	public static readonly EnvironmentBaseInfo Tracks1ShadowEnd;

	public static readonly EnvironmentBaseInfo Tracks1ShortShadowStart;

	public static readonly EnvironmentBaseInfo Tracks1ShortShadowEnd;

	public static readonly EnvironmentBaseInfo Tracks2;

	public static readonly EnvironmentBaseInfo Tracks2ShadowStart;

	public static readonly EnvironmentBaseInfo Tracks2ShadowMid;

	public static readonly EnvironmentBaseInfo Tracks2ShadowEnd;

	public static readonly EnvironmentBaseInfo Tracks2ShortShadowStart;

	public static readonly EnvironmentBaseInfo Tracks2ShortShadowEnd;

	public static readonly EnvironmentBaseInfo Tracks3;

	public static readonly EnvironmentBaseInfo Tracks3ShadowStart;

	public static readonly EnvironmentBaseInfo Tracks3ShadowMid;

	public static readonly EnvironmentBaseInfo Tracks3ShadowEnd;

	public static readonly EnvironmentBaseInfo Tracks3ShortShadowStart;

	public static readonly EnvironmentBaseInfo Tracks3ShortShadowEnd;

	public static readonly EnvironmentBaseInfo Tracks3Gates;

	public static readonly EnvironmentBaseInfo Tracks3GatesShadow;

	public static readonly EnvironmentBaseInfo Tracks3Special;

	private static readonly Dictionary<EnvironmentBaseInfo, string> AllGroundKinds;

	public EnvironmentBaseInfo(EnvironmentBaseKind environmentBaseType, int lengthInBlocks)
	{
		//IL_0019: Expected VT, but got I4
		_ = environmentBaseType.NumTracks;
		EnvironmentBaseKind = (EnvironmentBaseKind)environmentBaseType.Type;
		LengthInBlocks = lengthInBlocks;
	}

	public static bool operator ==(EnvironmentBaseInfo c1, EnvironmentBaseInfo c2)
	{
		return c1.Equals(c2);
	}

	public static bool operator !=(EnvironmentBaseInfo c1, EnvironmentBaseInfo c2)
	{
		bool flag = c1.Equals(c2);
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public override int GetHashCode()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got VT
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseInfo)+10]");
		_ = 0;
		obj = EnvironmentBaseKind;
		object obj3 = obj * 29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		object obj4 = 0 + obj3;
		object obj5 = obj4 * 29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj6 = 0 + obj5;
		object obj7 = obj6 + 415106;
		object obj8 = obj7 * 29;
		return LengthInBlocks + obj8;
	}

	public override bool Equals(object other)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			EnvironmentBaseInfo other2 = default;
			return Equals(other2);
		}
		return false;
	}

	public unsafe bool Equals(EnvironmentBaseInfo other)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0075: Expected native int or pointer, but got VT
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		object obj = default;
		EnvironmentBaseKind environmentBaseKind = (EnvironmentBaseKind)(obj + -64);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseInfo)+10]");
		_ = 0;
		_ = EnvironmentBaseKind;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (SYBO.Subway.Level.EnvironmentBaseInfo)+10]");
		_ = 0;
		_ = other.EnvironmentBaseKind;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+28]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
		((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = EnvironmentBaseType.None;
		EnvironmentBaseKind environmentBaseKind2 = (EnvironmentBaseKind)(environmentBaseKind + 16);
		if (environmentBaseKind2 == environmentBaseKind)
		{
			return LengthInBlocks == other.LengthInBlocks;
		}
		bool result = default;
		return result;
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseInfo)+10]");
		_ = 0;
		_ = EnvironmentBaseKind;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = LengthInBlocks;
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		return $"EnvironmentBaseInfo: kind=[{arg}] lengthInBlocks={arg2}";
	}

	public unsafe static string GetName(EnvironmentBaseInfo groundInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object result = obj + 12;
		if (!AllGroundKinds.TryGetValue(groundInfo, out *(string*)(obj + 12)))
		{
			result = "UNDEFINED";
		}
		return (string)result;
	}

	static EnvironmentBaseInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0e63: Expected I, but got Obj
		//IL_0ec2: Expected VT, but got I
		//IL_0ee7: Expected I, but got Obj
		//IL_004f: Expected VT, but got I
		//IL_0074: Expected I, but got Obj
		//IL_00d3: Expected VT, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_015c: Expected VT, but got I
		//IL_0181: Expected I, but got Obj
		//IL_01e0: Expected VT, but got I
		//IL_0205: Expected I, but got Obj
		//IL_0269: Expected VT, but got I
		//IL_028e: Expected I, but got Obj
		//IL_02ed: Expected VT, but got I
		//IL_0312: Expected I, but got Obj
		//IL_0376: Expected VT, but got I
		//IL_039b: Expected I, but got Obj
		//IL_03fa: Expected VT, but got I
		//IL_041f: Expected I, but got Obj
		//IL_0483: Expected VT, but got I
		//IL_04a8: Expected I, but got Obj
		//IL_0507: Expected VT, but got I
		//IL_052c: Expected I, but got Obj
		//IL_0590: Expected VT, but got I
		//IL_05b5: Expected I, but got Obj
		//IL_0614: Expected VT, but got I
		//IL_0639: Expected I, but got Obj
		//IL_069d: Expected VT, but got I
		//IL_06c2: Expected I, but got Obj
		//IL_0721: Expected VT, but got I
		//IL_0746: Expected I, but got Obj
		//IL_07aa: Expected VT, but got I
		//IL_07cf: Expected I, but got Obj
		//IL_082e: Expected VT, but got I
		//IL_0853: Expected I, but got Obj
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected Obj, but got Unknown
		//IL_08bd: Expected VT, but got Obj
		//IL_08e2: Expected I, but got Obj
		//IL_0941: Expected VT, but got I
		//IL_0966: Expected I, but got Obj
		//IL_09ca: Expected VT, but got I
		//IL_09ef: Expected I, but got Obj
		//IL_0a4e: Expected VT, but got I
		//IL_0a73: Expected I, but got Obj
		//IL_0ab8: Expected Obj, but got I
		//IL_0ad2: Expected VT, but got Obj
		//IL_0b23: Expected Obj, but got I
		//IL_0b49: Expected Obj, but got I
		//IL_0b6f: Expected Obj, but got I
		//IL_0b95: Expected Obj, but got I
		//IL_0bbb: Expected Obj, but got I
		//IL_0be1: Expected Obj, but got I
		//IL_0c07: Expected Obj, but got I
		//IL_0c2d: Expected Obj, but got I
		//IL_0c53: Expected Obj, but got I
		//IL_0c79: Expected Obj, but got I
		//IL_0c9f: Expected Obj, but got I
		//IL_0cc5: Expected Obj, but got I
		//IL_0ceb: Expected Obj, but got I
		//IL_0d11: Expected Obj, but got I
		//IL_0d37: Expected Obj, but got I
		//IL_0d5d: Expected Obj, but got I
		//IL_0d83: Expected Obj, but got I
		//IL_0da9: Expected Obj, but got I
		//IL_0dcf: Expected Obj, but got I
		//IL_0df5: Expected Obj, but got I
		//IL_0e1b: Expected Obj, but got I
		//IL_0e41: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 704;
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+20]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+150]");
		EnvironmentBaseInfo environmentBaseInfo = default;
		environmentBaseInfo.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo.LengthInBlocks = 2;
		Tracks0 = environmentBaseInfo;
		nint num3 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v20 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v21 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+2C]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+140]");
		EnvironmentBaseInfo environmentBaseInfo2 = default;
		environmentBaseInfo2.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo2.LengthInBlocks = 2;
		Tracks1 = environmentBaseInfo2;
		nint num5 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v36 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v37 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+38]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks1ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+130]");
		EnvironmentBaseInfo environmentBaseInfo3 = default;
		environmentBaseInfo3.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo3.LengthInBlocks = 2;
		Tracks1ShadowStart = environmentBaseInfo3;
		nint num7 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v52 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v53 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+44]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks1ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+280]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
		EnvironmentBaseInfo environmentBaseInfo4 = default;
		environmentBaseInfo4.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo4.LengthInBlocks = 2;
		Tracks1ShadowMid = environmentBaseInfo4;
		nint num9 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v68 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v69 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+50]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks1ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+110]");
		EnvironmentBaseInfo environmentBaseInfo5 = default;
		environmentBaseInfo5.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo5.LengthInBlocks = 2;
		Tracks1ShadowEnd = environmentBaseInfo5;
		nint num11 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v84 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v85 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+38]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks1ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+268]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+260]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
		EnvironmentBaseInfo environmentBaseInfo6 = default;
		environmentBaseInfo6.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo6.LengthInBlocks = 1;
		Tracks1ShortShadowStart = environmentBaseInfo6;
		nint num13 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v100 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v101 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+50]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks1ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+258]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+250]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
		EnvironmentBaseInfo environmentBaseInfo7 = default;
		environmentBaseInfo7.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo7.LengthInBlocks = 1;
		Tracks1ShortShadowEnd = environmentBaseInfo7;
		nint num15 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v116 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v117 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+248]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+240]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
		EnvironmentBaseInfo environmentBaseInfo8 = default;
		environmentBaseInfo8.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo8.LengthInBlocks = 2;
		Tracks2 = environmentBaseInfo8;
		nint num17 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v132 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v133 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+68]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks2ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+238]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+230]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
		EnvironmentBaseInfo environmentBaseInfo9 = default;
		environmentBaseInfo9.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo9.LengthInBlocks = 2;
		Tracks2ShadowStart = environmentBaseInfo9;
		nint num19 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v148 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S1_v149 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks2ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+228]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+220]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		EnvironmentBaseInfo environmentBaseInfo10 = default;
		environmentBaseInfo10.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo10.LengthInBlocks = 2;
		Tracks2ShadowMid = environmentBaseInfo10;
		nint num21 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v164 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S1_v165 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+80]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks2ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+218]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+210]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
		EnvironmentBaseInfo environmentBaseInfo11 = default;
		environmentBaseInfo11.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo11.LengthInBlocks = 2;
		Tracks2ShadowEnd = environmentBaseInfo11;
		nint num23 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v180 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S1_v181 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+68]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks2ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+208]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+200]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
		EnvironmentBaseInfo environmentBaseInfo12 = default;
		environmentBaseInfo12.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo12.LengthInBlocks = 1;
		Tracks2ShortShadowStart = environmentBaseInfo12;
		nint num25 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S1_v196 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S1_v197 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+80]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks2ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		EnvironmentBaseInfo environmentBaseInfo13 = default;
		environmentBaseInfo13.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo13.LengthInBlocks = 1;
		Tracks2ShortShadowEnd = environmentBaseInfo13;
		nint num27 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S1_v212 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S1_v213 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8C]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		EnvironmentBaseInfo environmentBaseInfo14 = default;
		environmentBaseInfo14.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo14.LengthInBlocks = 2;
		Tracks3 = environmentBaseInfo14;
		nint num29 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S1_v228 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S1_v229 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+98]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		EnvironmentBaseInfo environmentBaseInfo15 = default;
		environmentBaseInfo15.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo15.LengthInBlocks = 2;
		Tracks3ShadowStart = environmentBaseInfo15;
		nint num31 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S1_v244 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S1_v245 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+A4]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		EnvironmentBaseInfo environmentBaseInfo16 = default;
		environmentBaseInfo16.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo16.LengthInBlocks = 2;
		Tracks3ShadowMid = environmentBaseInfo16;
		nint num33 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S1_v260 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S1_v261 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+B0]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		EnvironmentBaseInfo environmentBaseInfo17 = default;
		environmentBaseInfo17.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo17.LengthInBlocks = 2;
		Tracks3ShadowEnd = environmentBaseInfo17;
		nint num35 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S1_v276 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S1_v277 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+98]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A0]");
		_ = 0;
		object obj3 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ S1_v286+8]");
		_ = 0;
		EnvironmentBaseInfo environmentBaseInfo18 = default;
		environmentBaseInfo18.EnvironmentBaseKind = (EnvironmentBaseKind)obj3;
		environmentBaseInfo18.LengthInBlocks = 1;
		Tracks3ShortShadowStart = environmentBaseInfo18;
		nint num37 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S1_v293 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S1_v294 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+B0]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+198]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+190]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		EnvironmentBaseInfo environmentBaseInfo19 = default;
		environmentBaseInfo19.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo19.LengthInBlocks = 1;
		Tracks3ShortShadowEnd = environmentBaseInfo19;
		nint num39 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ S1_v309 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S1_v310 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+BC]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3Gates;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+180]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		EnvironmentBaseInfo environmentBaseInfo20 = default;
		environmentBaseInfo20.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo20.LengthInBlocks = 2;
		Tracks3Gates = environmentBaseInfo20;
		nint num41 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S1_v325 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ S1_v326 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+C8]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3GatesShadow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		EnvironmentBaseInfo environmentBaseInfo21 = default;
		environmentBaseInfo21.EnvironmentBaseKind = (EnvironmentBaseKind)0;
		environmentBaseInfo21.LengthInBlocks = 4;
		Tracks3GatesShadow = environmentBaseInfo21;
		nint num43 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S1_v341 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S1_v342 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+D4]");
		_ = 0;
		_ = EnvironmentBaseKind.Tracks3Special;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+168]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+160]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		EnvironmentBaseInfo environmentBaseInfo22 = default;
		environmentBaseInfo22.EnvironmentBaseKind = (EnvironmentBaseKind)obj;
		environmentBaseInfo22.LengthInBlocks = 1;
		Tracks3Special = environmentBaseInfo22;
		nint num45 = 0;
		nint num46 = 0;
		IntPtr intPtr = num46;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v807 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>>)+4] (should have been resolved before IL gen)");
		nint num47 = 0;
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v827 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num49 = 0;
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v847 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num51 = 0;
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v867 @ S5_v14+4] (should have been resolved before IL gen)");
		nint num53 = 0;
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v887 @ S5_v19+4] (should have been resolved before IL gen)");
		nint num55 = 0;
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v907 @ S5_v24+4] (should have been resolved before IL gen)");
		nint num57 = 0;
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v927 @ S5_v29+4] (should have been resolved before IL gen)");
		nint num59 = 0;
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v947 @ S5_v34+4] (should have been resolved before IL gen)");
		nint num61 = 0;
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v967 @ S5_v39+4] (should have been resolved before IL gen)");
		nint num63 = 0;
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v987 @ S5_v44+4] (should have been resolved before IL gen)");
		nint num65 = 0;
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1007 @ S5_v49+4] (should have been resolved before IL gen)");
		nint num67 = 0;
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ S5_v53 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1027 @ S5_v54+4] (should have been resolved before IL gen)");
		nint num69 = 0;
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ S5_v58 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1047 @ S5_v59+4] (should have been resolved before IL gen)");
		nint num71 = 0;
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ S5_v63 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1067 @ S5_v64+4] (should have been resolved before IL gen)");
		nint num73 = 0;
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ S5_v68 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1087 @ S5_v69+4] (should have been resolved before IL gen)");
		nint num75 = 0;
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ S5_v73 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1107 @ S5_v74+4] (should have been resolved before IL gen)");
		nint num77 = 0;
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ S5_v78 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1127 @ S5_v79+4] (should have been resolved before IL gen)");
		nint num79 = 0;
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ S5_v83 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1147 @ S5_v84+4] (should have been resolved before IL gen)");
		nint num81 = 0;
		nint num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1166 @ S5_v88 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1167 @ S5_v89+4] (should have been resolved before IL gen)");
		nint num83 = 0;
		nint num84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ S5_v93 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1187 @ S5_v94+4] (should have been resolved before IL gen)");
		nint num85 = 0;
		nint num86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ S5_v98 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1207 @ S5_v99+4] (should have been resolved before IL gen)");
		nint num87 = 0;
		nint num88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ S5_v103 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1227 @ S5_v104+4] (should have been resolved before IL gen)");
		nint num89 = 0;
		nint num90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ S5_v108 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Level.EnvironmentBaseInfo, System.String>>)+5C]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1247 @ S5_v109+4] (should have been resolved before IL gen)");
		Dictionary<EnvironmentBaseInfo, string> allGroundKinds = default;
		AllGroundKinds = allGroundKinds;
	}
}
