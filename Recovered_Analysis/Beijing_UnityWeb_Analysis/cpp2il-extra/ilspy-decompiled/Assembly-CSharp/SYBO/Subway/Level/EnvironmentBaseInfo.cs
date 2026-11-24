using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Level;

public class EnvironmentBaseInfo : IEquatable<EnvironmentBaseInfo>
{
	public readonly EnvironmentBaseKind EnvironmentBaseKind;

	public readonly int LengthInBlocks;

	public static readonly EnvironmentBaseInfo Tracks0;

	public static readonly EnvironmentBaseInfo Tracks1;

	public static readonly EnvironmentBaseInfo Tracks1ShadowMid;

	public static readonly EnvironmentBaseInfo Tracks1ShortShadowStart;

	public static readonly EnvironmentBaseInfo Tracks1ShortShadowEnd;

	public static readonly EnvironmentBaseInfo Tracks2;

	public static readonly EnvironmentBaseInfo Tracks2ShadowMid;

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
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_010e: Expected VT, but got Obj
		//IL_010e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		nint num3 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v5 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v12 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		GameObject gameObject = ((Component)this).gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
	}

	public static bool operator ==(EnvironmentBaseInfo c1, EnvironmentBaseInfo c2)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		_ = c2.EnvironmentBaseKind;
		object obj = c1 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8649");
		bool result = default;
		return result;
	}

	public static bool operator !=(EnvironmentBaseInfo c1, EnvironmentBaseInfo c2)
	{
		//IL_000d: Expected I4, but got Obj
		return (byte)((EnvironmentInfo)(object)c1).GetSequenceLengthInBlocks((EnvironmentSequence)c2) != 0;
	}

	public override int GetHashCode()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @980F");
		int result = default;
		return result;
	}

	public override bool Equals(object other)
	{
		//IL_000a: Expected I4, but got Obj
		int sequenceLengthInBlocks = ((EnvironmentInfo)this).GetSequenceLengthInBlocks((EnvironmentSequence)other);
		return (byte)(sequenceLengthInBlocks ^ 1) != 0;
	}

	public bool Equals(EnvironmentBaseInfo other)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			EnvironmentSequence sequence = default;
			return (byte)((EnvironmentInfo)this).GetSequenceLengthInBlocks(sequence) != 0;
		}
		return false;
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		object obj3 = this + 8;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v6+8]");
		_ = 0;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9806");
		object obj4 = obj2 + 12;
		obj4 = LengthInBlocks;
		object obj6 = default;
		object obj5 = obj6 + 493;
		object obj7 = obj5 * 29;
		return obj4 + obj7;
	}

	public static string GetName(EnvironmentBaseInfo groundInfo)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = groundInfo + 8;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		object obj4 = obj2 + 4;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = groundInfo.LengthInBlocks;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		return string.Format((IFormatProvider)(object)"EnvironmentBaseInfo: kind=[{0}] lengthInBlocks={1}", format, arg);
	}

	static EnvironmentBaseInfo()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_0045: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00ce: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_01ce: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I4
		//IL_024e: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I4
		//IL_02ce: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I4
		//IL_034e: Expected I, but got Obj
		//IL_0379: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I4
		//IL_03ce: Expected I, but got Obj
		//IL_03f9: Expected Obj, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I4
		//IL_044e: Expected I, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got I4
		//IL_04ce: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got I4
		//IL_054e: Expected I, but got Obj
		//IL_0579: Expected Obj, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05a5: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_05ce: Expected I, but got Obj
		//IL_05f9: Expected Obj, but got I
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_0625: Expected Obj, but got I4
		//IL_0634: Expected Obj, but got I4
		//IL_064e: Expected I, but got Obj
		//IL_0679: Expected Obj, but got I
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_06a5: Expected Obj, but got I4
		//IL_06b4: Expected Obj, but got I4
		//IL_06ce: Expected I, but got Obj
		//IL_06f9: Expected Obj, but got I
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected Obj, but got Unknown
		//IL_0725: Expected Obj, but got I4
		//IL_0734: Expected Obj, but got I4
		//IL_074e: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_07a5: Expected Obj, but got I4
		//IL_07b4: Expected Obj, but got I4
		//IL_07ce: Expected I, but got Obj
		//IL_07f9: Expected Obj, but got I
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I4
		//IL_0834: Expected Obj, but got I4
		//IL_084e: Expected I, but got Obj
		//IL_0879: Expected Obj, but got I
		//IL_0897: Expected Obj, but got I4
		//IL_08a6: Expected Obj, but got I4
		//IL_08c0: Expected I, but got Obj
		//IL_08eb: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 204;
		obj = 0;
		_ = 0;
		obj = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		nint num2 = 0;
		object obj3 = obj2 + 216;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		EnvironmentBaseKind.None = (EnvironmentBaseKind)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj4 = obj2 + 192;
		obj4 = 0;
		_ = 0;
		obj4 = 1;
		_ = 0;
		_ = 0;
		nint num3 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj6 = obj2 + 180;
		obj6 = 0;
		_ = 0;
		obj6 = 2;
		_ = 0;
		_ = 0;
		nint num4 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v40 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj7 = (nint)0 + (nint)24;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj8 = obj2 + 168;
		obj8 = 0;
		_ = 0;
		obj8 = 2;
		_ = 0;
		_ = 1;
		nint num5 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v45+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v51 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj10 = obj2 + 156;
		obj10 = 0;
		_ = 0;
		obj10 = 2;
		_ = 1;
		_ = 1;
		nint num6 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v56+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v62 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj11 = (nint)0 + (nint)48;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj12 = obj2 + 144;
		obj12 = 0;
		_ = 0;
		obj12 = 2;
		_ = 2;
		_ = 1;
		nint num7 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v67+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v73 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj13 = (nint)0 + (nint)60;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj14 = obj2 + 132;
		obj14 = 0;
		_ = 0;
		obj14 = 2;
		_ = 3;
		_ = 1;
		nint num8 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v84 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj15 = (nint)0 + (nint)72;
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj16 = obj2 + 120;
		obj16 = 0;
		_ = 0;
		obj16 = 2;
		_ = 0;
		_ = 2;
		nint num9 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v89+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v95 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj17 = (nint)0 + (nint)84;
		obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj18 = obj2 + 108;
		obj18 = 0;
		_ = 0;
		obj18 = 2;
		_ = 1;
		_ = 2;
		nint num10 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v100+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v106 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj19 = (nint)0 + (nint)96;
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj20 = obj2 + 96;
		obj20 = 0;
		_ = 0;
		obj20 = 2;
		_ = 2;
		_ = 2;
		nint num11 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v111+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v117 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj21 = (nint)0 + (nint)108;
		obj21 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj22 = obj2 + 84;
		obj22 = 0;
		_ = 0;
		obj22 = 2;
		_ = 3;
		_ = 2;
		nint num12 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v122+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v128 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj23 = (nint)0 + (nint)120;
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj24 = obj2 + 72;
		obj24 = 0;
		_ = 0;
		obj24 = 2;
		_ = 0;
		_ = 3;
		nint num13 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v133+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v139 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj25 = (nint)0 + (nint)132;
		obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj26 = obj2 + 60;
		obj26 = 0;
		_ = 0;
		obj26 = 2;
		_ = 1;
		_ = 3;
		nint num14 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v144+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v150 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj27 = (nint)0 + (nint)144;
		obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj28 = obj2 + 48;
		obj28 = 0;
		_ = 0;
		obj28 = 2;
		_ = 2;
		_ = 3;
		nint num15 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v155+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v161 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj29 = (nint)0 + (nint)156;
		obj29 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj30 = obj2 + 36;
		obj30 = 0;
		_ = 0;
		obj30 = 2;
		_ = 3;
		_ = 3;
		nint num16 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S0_v166+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S0_v172 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj31 = (nint)0 + (nint)168;
		obj31 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj32 = obj2 + 24;
		obj32 = 0;
		_ = 0;
		obj32 = 3;
		_ = 0;
		_ = 3;
		nint num17 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v177+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v183 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj33 = (nint)0 + (nint)180;
		obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj34 = obj2 + 12;
		obj34 = 0;
		_ = 0;
		obj34 = 3;
		_ = 4;
		_ = 3;
		nint num18 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v188+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v194 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj35 = (nint)0 + (nint)192;
		obj35 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 4;
		_ = 0;
		_ = 3;
		nint num19 = (nint)typeof(EnvironmentBaseKind);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v204 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj36 = (nint)0 + (nint)204;
		obj36 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
	}
}
