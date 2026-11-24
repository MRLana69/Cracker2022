using System;
using Cpp2ILInjected;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level;

[Serializable]
public class EnvironmentInfo
{
	public readonly EnvironmentKind Kind;

	public readonly bool HasStartEnd;

	public readonly bool HasSides;

	public readonly bool UseSameVariationPerSequence;

	public readonly bool UseSameVariationForSides;

	public readonly int MaxMidPieceCount;

	public readonly int MidPieceLengthInBlocks;

	public readonly int StartEndPieceLengthInBlocks;

	public static int DefaultMaxMidPieceCount;

	public static int DefaultMidPieceLengthInBlocks;

	public static int DefaultMaxMidLengthInBlocks;

	public static readonly EnvironmentInfo None;

	public static readonly EnvironmentInfo Empty;

	public static readonly EnvironmentInfo FillersLow;

	public static readonly EnvironmentInfo FillersMedium;

	public static readonly EnvironmentInfo FillersHigh;

	public static readonly EnvironmentInfo Gates;

	public static readonly EnvironmentInfo Tube;

	public static readonly EnvironmentInfo Pillars;

	public static readonly EnvironmentInfo Station;

	public static readonly EnvironmentInfo Epic;

	public static readonly EnvironmentInfo[] All;

	public int MidPieceLength
	{
		get
		{
			//IL_007f: Expected Obj, but got I4
			//IL_008d: Expected I, but got Obj
			//IL_00a3: Expected Obj, but got I
			//IL_0071: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_005a: Expected I4, but got Obj
			object obj = 0;
			nint num = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(EnvironmentBaseInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v24 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			object obj3 = default;
			if (obj3 != null)
			{
				return (int)obj;
			}
			obj = "UNDEFINED";
			return (int)"UNDEFINED";
		}
	}

	public int StartEndPieceLength => MidPieceLengthInBlocks * 90;

	public int MinLengthInBlocks => StartEndPieceLengthInBlocks * 90;

	public int LengthMin
	{
		get
		{
			if (~(HasStartEnd ? 1u : 0u) == 0)
			{
				int num = StartEndPieceLengthInBlocks << 1;
				return MidPieceLengthInBlocks + num;
			}
			return MidPieceLengthInBlocks;
		}
	}

	public int MidLengthMax
	{
		get
		{
			int num2;
			if (~(HasStartEnd ? 1u : 0u) == 0)
			{
				int num = StartEndPieceLengthInBlocks << 1;
				num2 = MidPieceLengthInBlocks + num;
			}
			else
			{
				num2 = MidPieceLengthInBlocks;
			}
			return num2 * 90;
		}
	}

	public int MaxLengthInBlocks => MidPieceLengthInBlocks * MaxMidPieceCount;

	public int MaxLength
	{
		get
		{
			//IL_002a: Expected Obj, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected I4, but got Unknown
			if (~(HasStartEnd ? 1u : 0u) == 0)
			{
				object obj = MidPieceLengthInBlocks * MaxMidPieceCount;
				int num = StartEndPieceLengthInBlocks << 1;
				return obj + num;
			}
			return MidPieceLengthInBlocks * MaxMidPieceCount;
		}
	}

	public unsafe EnvironmentInfo(EnvironmentKind envKind, bool hasStartEnd, bool hasSides, bool useSameVariationPerSequence, bool useSameVariationForSides, int maxMidPieceCount, int lengthMidPieceInBlocks, int lengthStartEndPieceInBlocks)
	{
		//IL_0b66: Expected I, but got Obj
		//IL_0b7c: Expected Obj, but got I
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected Obj, but got Unknown
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Expected VT, but got Unknown
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fff: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00c1: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_0bcb: Expected Obj, but got VT
		//IL_104e: Expected Obj, but got I
		//IL_00dd: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_02ba: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I
		//IL_0202: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I
		//IL_0235: Expected I, but got Obj
		//IL_0133: Expected I, but got Obj
		//IL_02fb: Expected I, but got Obj
		//IL_0c44: Expected Obj, but got I
		//IL_0c5e: Expected Obj, but got I
		//IL_0ca8: Expected Obj, but got I4
		//IL_0251: Expected I, but got Obj
		//IL_0281: Expected I, but got Obj
		//IL_02a7: Expected I, but got Obj
		//IL_1061: Expected Obj, but got I4
		//IL_0656: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_03a7: Expected I, but got Obj
		//IL_03bd: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I4
		//IL_0697: Expected I, but got Obj
		//IL_03e8: Expected I, but got Obj
		//IL_082d: Expected Obj, but got I4
		//IL_08c6: Expected Obj, but got I4
		//IL_08e9: Expected Obj, but got I
		//IL_083f: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I
		//IL_093e: Expected I, but got Obj
		//IL_0954: Expected Obj, but got I
		//IL_0971: Expected I, but got Obj
		//IL_0891: Expected Obj, but got I4
		//IL_0463: Expected I, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_075f: Expected Obj, but got I4
		//IL_077a: Expected I, but got Obj
		//IL_0790: Expected Obj, but got I
		//IL_07ad: Expected I, but got Obj
		//IL_0f55: Expected Obj, but got I
		//IL_0f6f: Expected Obj, but got I
		//IL_0ede: Expected Obj, but got VT
		//IL_0ef8: Expected I4, but got Obj
		//IL_0ef3: Expected native int or pointer, but got VT
		//IL_0f08: Expected native int or pointer, but got VT
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected Obj, but got Unknown
		//IL_074d: Expected Obj, but got I4
		//IL_098d: Expected I, but got Obj
		//IL_09bd: Expected I, but got Obj
		//IL_09f6: Expected I, but got Obj
		//IL_0a0c: Expected Obj, but got I
		//IL_0a29: Expected I, but got Obj
		//IL_04a4: Expected I, but got Obj
		//IL_07c9: Expected I, but got Obj
		//IL_07f9: Expected I, but got Obj
		//IL_0f8a: Expected Obj, but got I
		//IL_0fa4: Expected Obj, but got I
		//IL_09e3: Expected I, but got Obj
		//IL_0a45: Expected I, but got Obj
		//IL_0a75: Expected I, but got Obj
		//IL_0aae: Expected I, but got Obj
		//IL_0ac4: Expected Obj, but got I
		//IL_0ae1: Expected I, but got Obj
		//IL_081f: Expected I, but got Obj
		//IL_0fc8: Expected Obj, but got VT
		//IL_051e: Expected Obj, but got I4
		//IL_0539: Expected I, but got Obj
		//IL_054f: Expected Obj, but got I
		//IL_056c: Expected I, but got Obj
		//IL_0a9b: Expected I, but got Obj
		//IL_0afd: Expected I, but got Obj
		//IL_0b2d: Expected I, but got Obj
		//IL_0de4: Expected Obj, but got VT
		//IL_0dfe: Expected I4, but got Obj
		//IL_0df9: Expected native int or pointer, but got VT
		//IL_0e0e: Expected native int or pointer, but got VT
		//IL_0e35: Expected Ref, but got VT
		//IL_0617: Expected Obj, but got I
		//IL_0630: Expected VT, but got I4
		//IL_0588: Expected I, but got Obj
		//IL_05b8: Expected I, but got Obj
		//IL_0b53: Expected I, but got Obj
		//IL_05f0: Expected Obj, but got I4
		//IL_0602: Expected Obj, but got I
		//IL_05de: Expected I, but got Obj
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v143 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 36;
		EnvironmentBaseKind environmentBaseKind = (EnvironmentBaseKind)(obj3 + 24);
		object obj4 = obj3 + 12;
		EnvironmentKind epic = EnvironmentKind.Epic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+8]");
		bool flag;
		if ((nint)0 == (nint)epic._type)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+C]");
			flag = (nint)0 == (nint)epic._density;
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			nint num3 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v128 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag2 = obj5 == null;
			nint num4 = (nint)typeof(EnvironmentBaseKind);
			if (!flag2)
			{
				nint num5 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v133 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag3 = (nint)0 == 0;
				bool flag4 = !flag3;
				num4 = (nint)typeof(EnvironmentBaseKind);
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ L1_v27 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num6 = 0;
			EnvironmentInfo environmentInfo = (EnvironmentInfo)EnvironmentBaseKind.None;
			IntPtr intPtr = num6;
		}
		else
		{
			nint num7 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v28 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v121 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EnvironmentKind gates = EnvironmentKind.Gates;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+8]");
			bool flag5;
			if ((nint)0 == (nint)gates._type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+C]");
				flag5 = (nint)0 == (nint)gates._density;
			}
			else
			{
				flag5 = false;
			}
			EnvironmentInfo environmentInfo;
			if (flag5)
			{
				nint num9 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v105 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				bool flag6 = obj7 == null;
				nint num10 = (nint)typeof(EnvironmentBaseKind);
				if (!flag6)
				{
					nint num11 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v111 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag7 = (nint)0 == 0;
					bool flag8 = !flag7;
					num10 = (nint)typeof(EnvironmentBaseKind);
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num10 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ L1_v23 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object obj8 = (nint)0 + (nint)192;
				environmentInfo = (EnvironmentInfo)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v190+8]");
				Kind = (EnvironmentKind)0;
				return;
			}
			nint num12 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v37 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num13 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v100 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+8]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasSides @ L3 (System.Boolean)+8]");
			bool flag9;
			if (num14 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+C]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasSides @ L3 (System.Boolean)+C]");
				flag9 = num15 == 0;
			}
			else
			{
				flag9 = false;
			}
			object obj10 = (flag9 ? 1 : 0) ^ 1;
			EnvironmentKind tube = EnvironmentKind.Tube;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+8]");
			bool flag10;
			if ((nint)0 == (nint)tube._type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+C]");
				flag10 = (nint)0 == (nint)tube._density;
			}
			else
			{
				flag10 = false;
			}
			if (!flag10)
			{
				nint num16 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S1_v117 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num17 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v175 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EnvironmentKind pillars = EnvironmentKind.Pillars;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+8]");
				bool flag11;
				if ((nint)0 == (nint)pillars._type)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+C]");
					flag11 = (nint)0 == (nint)pillars._density;
				}
				else
				{
					flag11 = false;
				}
				if (!flag11)
				{
					nint num18 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v127 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num19 = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S1_v165 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					EnvironmentKind station = EnvironmentKind.Station;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+8]");
					bool flag12;
					if ((nint)0 == (nint)station._type)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+C]");
						flag12 = (nint)0 == (nint)station._density;
					}
					else
					{
						flag12 = false;
					}
					if (!flag12)
					{
						obj4 = ((bool*)(useSameVariationForSides ? 1 : 0))->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useSameVariationForSides @ L5 (System.Boolean)+8]");
						_ = 0;
						nint num20 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S1_v139 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						bool flag13 = obj13 == null;
						nint num21 = (nint)typeof(EnvironmentBaseKind);
						if (!flag13)
						{
							nint num22 = (nint)typeof(EnvironmentBaseKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S1_v155 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
							bool flag14 = (nint)0 == 0;
							bool flag15 = !flag14;
							num21 = (nint)typeof(EnvironmentBaseKind);
							if (!flag15)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num21 = (nint)typeof(EnvironmentBaseKind);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ L2_v3 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
						nint num23 = 0;
						obj3 = EnvironmentBaseKind.None;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S2_v67 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
						_ = 0;
						((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
						obj2 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						if (((EnvironmentBaseKind*)environmentBaseKind)->Equals(obj2))
						{
							environmentInfo = (EnvironmentInfo)((bool*)(useSameVariationForSides ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useSameVariationForSides @ L5 (System.Boolean)+8]");
							Kind = (EnvironmentKind)0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L1 (SYBO.Subway.Level.EnvironmentKind)+74]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							Color color = default;
							((RouteCollection)this).DrawBounds((Bounds)0, color);
						}
						return;
					}
				}
			}
			object obj15 = lengthStartEndPieceInBlocks - 1;
			object obj16;
			if ((nint)obj15 > lengthMidPieceInBlocks)
			{
				obj16 = 0;
			}
			else
			{
				nint num24 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v72 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num25 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S1_v111 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useSameVariationPerSequence @ L4 (System.Boolean)+8]");
				nint num26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+8]");
				bool flag16;
				if (num26 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useSameVariationPerSequence @ L4 (System.Boolean)+C]");
					nint num27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hasStartEnd @ L2 (System.Boolean)+C]");
					flag16 = num27 == 0;
				}
				else
				{
					flag16 = false;
				}
				if (flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L1 (SYBO.Subway.Level.EnvironmentKind)+20]");
					object obj18 = (nint)0 * (nint)90;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					object obj19 = default;
					if (obj19 != null)
					{
						obj16 = 1;
					}
					else
					{
						obj4 = ((int*)maxMidPieceCount)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxMidPieceCount @ L6 (System.Int32)+8]");
						_ = 0;
						nint num28 = (nint)typeof(EnvironmentBaseKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v87 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						bool flag17 = obj20 == null;
						nint num29 = (nint)typeof(EnvironmentBaseKind);
						if (!flag17)
						{
							nint num30 = (nint)typeof(EnvironmentBaseKind);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S1_v100 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
							bool flag18 = (nint)0 == 0;
							bool flag19 = !flag18;
							num29 = (nint)typeof(EnvironmentBaseKind);
							if (!flag19)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num29 = (nint)typeof(EnvironmentBaseKind);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ L1_v19 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
						nint num31 = 0;
						obj3 = EnvironmentBaseKind.None;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S2_v33 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
						_ = 0;
						((EnvironmentBaseKind*)(nint)environmentBaseKind)->Type = (EnvironmentBaseType)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
						((EnvironmentBaseKind*)(nint)environmentBaseKind)->NumTracks = 0;
						obj2 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8656");
						object obj21 = default;
						obj16 = obj21 ^ 1;
					}
				}
				else
				{
					obj16 = 1;
				}
			}
			if (obj10 != null)
			{
				obj2 = ((bool*)(useSameVariationForSides ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useSameVariationForSides @ L5 (System.Boolean)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (System.Object)+8]");
				EnvironmentBaseKind endEnvironmentBase = ((RouteChunk)null).GetEndEnvironmentBase(0);
				return;
			}
			if (obj16 != null)
			{
				obj2 = ((bool*)(useSameVariationForSides ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useSameVariationForSides @ L5 (System.Boolean)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (System.Object)+8]");
				EnvironmentBaseKind defaultEnvironmentBaseKind = ((RouteChunk)null).GetDefaultEnvironmentBaseKind(RouteType.None);
				return;
			}
			obj2 = ((bool*)(useSameVariationForSides ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useSameVariationForSides @ L5 (System.Boolean)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (System.Object)+8]");
			object obj22 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (System.Object)+8]");
			if ((nint)0 == 1)
			{
				nint num32 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v53 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				bool flag20 = obj23 == null;
				nint num33 = (nint)typeof(EnvironmentBaseKind);
				if (!flag20)
				{
					nint num34 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v59 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag21 = (nint)0 == 0;
					bool flag22 = !flag21;
					num33 = (nint)typeof(EnvironmentBaseKind);
					if (!flag22)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num33 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ L1_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object obj24 = (nint)0 + (nint)60;
				environmentInfo = (EnvironmentInfo)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S1_v45+8]");
				Kind = (EnvironmentKind)0;
				return;
			}
			if ((nint)obj22 == 1)
			{
				nint num35 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v66 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				bool flag23 = obj25 == null;
				nint num36 = (nint)typeof(EnvironmentBaseKind);
				if (!flag23)
				{
					nint num37 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v72 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag24 = (nint)0 == 0;
					bool flag25 = !flag24;
					num36 = (nint)typeof(EnvironmentBaseKind);
					if (!flag25)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num36 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ L1_v10 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object obj26 = (nint)0 + (nint)108;
				environmentInfo = (EnvironmentInfo)obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S1_v52+8]");
				Kind = (EnvironmentKind)0;
				return;
			}
			nint num38 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S0_v79 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			bool flag26 = obj27 == null;
			nint num39 = (nint)typeof(EnvironmentBaseKind);
			if (!flag26)
			{
				nint num40 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S0_v84 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag27 = (nint)0 == 0;
				bool flag28 = !flag27;
				num39 = (nint)typeof(EnvironmentBaseKind);
				if (!flag28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num39 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ L1_v14 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num41 = (nint)0 + (nint)156;
			environmentInfo = (EnvironmentInfo)EnvironmentBaseKind.None;
			IntPtr intPtr = num41;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ L1_v1 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
		Kind = (EnvironmentKind)0;
	}

	public int GetSequenceLengthInBlocks(EnvironmentSequence sequence)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		object obj3 = this + 8;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
		_ = 0;
		object obj4 = sequence + 8;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10+8]");
		_ = 0;
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v31 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 24;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj7 = obj2 + 36;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8656");
		object obj8 = default;
		if (obj8 != null)
		{
			int midPieceLengthInBlocks = MidPieceLengthInBlocks;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sequence @ L1 (SYBO.Subway.Level.EnvironmentSequence)+14]");
			return ((nint)midPieceLengthInBlocks == 0) ? 1 : 0;
		}
		return 0;
	}

	public static EnvironmentInfo GetByKind(EnvironmentKind envKind)
	{
		//IL_0084: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		object obj3;
		if (envKind._density != EnvironmentDensity.Default)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L0 (SYBO.Subway.Level.EnvironmentKind)+14]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L0 (SYBO.Subway.Level.EnvironmentKind)+10]");
			object obj = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L0 (SYBO.Subway.Level.EnvironmentKind)+18]");
			object obj2 = (nint)0 << 1;
			obj3 = obj + obj2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L0 (SYBO.Subway.Level.EnvironmentKind)+14]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envKind @ L0 (SYBO.Subway.Level.EnvironmentKind)+10]");
			obj3 = num2 * 0;
		}
		return (EnvironmentInfo)(obj3 * 90);
	}

	unsafe static EnvironmentInfo()
	{
		//IL_12d2: Expected I, but got Obj
		//IL_12e8: Expected Obj, but got I
		//IL_1305: Expected I, but got Obj
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Expected Obj, but got Unknown
		//IL_1337: Expected Obj, but got I
		//IL_135f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1364: Expected I4, but got Unknown
		//IL_1371: Expected I4, but got Obj
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Expected Obj, but got Unknown
		//IL_13b5: Expected I, but got Obj
		//IL_13cb: Expected Obj, but got I
		//IL_007b: Expected I4, but got Obj
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0129: Expected I4, but got Obj
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_01d7: Expected I4, but got Obj
		//IL_0204: Expected I, but got Obj
		//IL_021a: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		//IL_0285: Expected I4, but got Obj
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02ec: Expected I, but got Obj
		//IL_0302: Expected Obj, but got I
		//IL_0333: Expected I4, but got Obj
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_039a: Expected I, but got Obj
		//IL_03b0: Expected Obj, but got I
		//IL_03e1: Expected I4, but got Obj
		//IL_040e: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0448: Expected I, but got Obj
		//IL_045e: Expected Obj, but got I
		//IL_048f: Expected I4, but got Obj
		//IL_04bc: Expected I, but got Obj
		//IL_04d2: Expected Obj, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_04f6: Expected I, but got Obj
		//IL_050c: Expected Obj, but got I
		//IL_053d: Expected I4, but got Obj
		//IL_056a: Expected I, but got Obj
		//IL_0580: Expected Obj, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05a4: Expected I, but got Obj
		//IL_05ba: Expected Obj, but got I
		//IL_05eb: Expected I4, but got Obj
		//IL_0618: Expected I, but got Obj
		//IL_062e: Expected Obj, but got I
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_0652: Expected I, but got Obj
		//IL_0668: Expected Obj, but got I
		//IL_0699: Expected I4, but got Obj
		//IL_06c6: Expected I, but got Obj
		//IL_06dc: Expected Obj, but got I
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_0700: Expected I, but got Obj
		//IL_0716: Expected Obj, but got I
		//IL_0747: Expected I4, but got Obj
		//IL_0774: Expected I, but got Obj
		//IL_078a: Expected Obj, but got I
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07ae: Expected I, but got Obj
		//IL_07c4: Expected Obj, but got I
		//IL_07f5: Expected I4, but got Obj
		//IL_0822: Expected I, but got Obj
		//IL_0838: Expected Obj, but got I
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected Obj, but got Unknown
		//IL_085c: Expected I, but got Obj
		//IL_0872: Expected Obj, but got I
		//IL_08a3: Expected I4, but got Obj
		//IL_08d0: Expected I, but got Obj
		//IL_08e6: Expected Obj, but got I
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected Obj, but got Unknown
		//IL_090a: Expected I, but got Obj
		//IL_0920: Expected Obj, but got I
		//IL_0951: Expected I4, but got Obj
		//IL_097e: Expected I, but got Obj
		//IL_0994: Expected Obj, but got I
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected Obj, but got Unknown
		//IL_09b8: Expected I, but got Obj
		//IL_09ce: Expected Obj, but got I
		//IL_09ff: Expected I4, but got Obj
		//IL_0a2c: Expected I, but got Obj
		//IL_0a42: Expected Obj, but got I
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected Obj, but got Unknown
		//IL_0a66: Expected I, but got Obj
		//IL_0a7c: Expected Obj, but got I
		//IL_0aad: Expected I4, but got Obj
		//IL_0ada: Expected I, but got Obj
		//IL_0af0: Expected Obj, but got I
		//IL_0b06: Expected I, but got Obj
		//IL_0b1c: Expected Obj, but got I
		//IL_0b4d: Expected I4, but got Obj
		//IL_0b7a: Expected I, but got Obj
		//IL_0b90: Expected Obj, but got I
		//IL_0bbd: Expected Obj, but got I
		//IL_0bcd: Expected Obj, but got I
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected Obj, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got Unknown
		//IL_0c11: Expected Obj, but got I
		//IL_0c21: Expected Obj, but got I
		//IL_0c31: Expected Obj, but got I
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3f: Expected Obj, but got Unknown
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Expected Obj, but got Unknown
		//IL_0c6d: Expected Obj, but got I
		//IL_0c7d: Expected Obj, but got I
		//IL_0c8d: Expected Obj, but got I
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Expected Obj, but got Unknown
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected Obj, but got Unknown
		//IL_0cc9: Expected Obj, but got I
		//IL_0cd9: Expected Obj, but got I
		//IL_0ce9: Expected Obj, but got I
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected Obj, but got Unknown
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected Obj, but got Unknown
		//IL_0d25: Expected Obj, but got I
		//IL_0d35: Expected Obj, but got I
		//IL_0d45: Expected Obj, but got I
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected Obj, but got Unknown
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected Obj, but got Unknown
		//IL_0d81: Expected Obj, but got I
		//IL_0d91: Expected Obj, but got I
		//IL_0da1: Expected Obj, but got I
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected Obj, but got Unknown
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected Obj, but got Unknown
		//IL_0ddd: Expected Obj, but got I
		//IL_0ded: Expected Obj, but got I
		//IL_0dfd: Expected Obj, but got I
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Expected Obj, but got Unknown
		//IL_0e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e19: Expected Obj, but got Unknown
		//IL_0e39: Expected Obj, but got I
		//IL_0e49: Expected Obj, but got I
		//IL_0e59: Expected Obj, but got I
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e67: Expected Obj, but got Unknown
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Expected Obj, but got Unknown
		//IL_0e95: Expected Obj, but got I
		//IL_0ea5: Expected Obj, but got I
		//IL_0eb5: Expected Obj, but got I
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected Obj, but got Unknown
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed1: Expected Obj, but got Unknown
		//IL_0ef1: Expected Obj, but got I
		//IL_0f01: Expected Obj, but got I
		//IL_0f11: Expected Obj, but got I
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected Obj, but got Unknown
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2d: Expected Obj, but got Unknown
		//IL_0f4d: Expected Obj, but got I
		//IL_0f5d: Expected Obj, but got I
		//IL_0f6d: Expected Obj, but got I
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Expected Obj, but got Unknown
		//IL_0f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f89: Expected Obj, but got Unknown
		//IL_0fa9: Expected Obj, but got I
		//IL_0fb9: Expected Obj, but got I
		//IL_0fc9: Expected Obj, but got I
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected Obj, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe5: Expected Obj, but got Unknown
		//IL_1005: Expected Obj, but got I
		//IL_1015: Expected Obj, but got I
		//IL_1025: Expected Obj, but got I
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Expected Obj, but got Unknown
		//IL_103c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected Obj, but got Unknown
		//IL_1061: Expected Obj, but got I
		//IL_1071: Expected Obj, but got I
		//IL_1081: Expected Obj, but got I
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_108f: Expected Obj, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Expected Obj, but got Unknown
		//IL_10bd: Expected Obj, but got I
		//IL_10cd: Expected Obj, but got I
		//IL_10dd: Expected Obj, but got I
		//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10eb: Expected Obj, but got Unknown
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected Obj, but got Unknown
		//IL_1119: Expected Obj, but got I
		//IL_1129: Expected Obj, but got I
		//IL_1139: Expected Obj, but got I
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_1147: Expected Obj, but got Unknown
		//IL_1150: Unknown result type (might be due to invalid IL or missing references)
		//IL_1155: Expected Obj, but got Unknown
		//IL_1175: Expected Obj, but got I
		//IL_1185: Expected Obj, but got I
		//IL_1195: Expected Obj, but got I
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a3: Expected Obj, but got Unknown
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b1: Expected Obj, but got Unknown
		//IL_11c9: Expected I, but got Obj
		//IL_11df: Expected Obj, but got I
		//IL_11f5: Expected Obj, but got I
		//IL_1205: Expected Obj, but got I
		//IL_1215: Expected Obj, but got I
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1223: Expected Obj, but got Unknown
		//IL_122c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Expected Obj, but got Unknown
		//IL_1251: Expected Obj, but got I
		//IL_1261: Expected Obj, but got I
		//IL_1271: Expected Obj, but got I
		//IL_127a: Unknown result type (might be due to invalid IL or missing references)
		//IL_127f: Expected Obj, but got Unknown
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Expected Obj, but got Unknown
		//IL_12a5: Expected I, but got Obj
		//IL_12bb: Expected Obj, but got I
		nint num = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(EnvironmentBaseKind);
		if (!flag)
		{
			nint num3 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v290 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(EnvironmentBaseKind);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(EnvironmentBaseKind);
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 204;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L0_v2 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj4 = (nint)0 + (nint)24;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EnvironmentType environmentType = (EnvironmentType)(obj3 + 216);
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14+8]");
		_ = 0;
		EnvironmentKind environmentKind = default;
		environmentKind._002Ector(environmentType, EnvironmentDensity.Medium);
		EnvironmentBaseInfo.Tracks0 = (EnvironmentBaseInfo)(object)environmentKind;
		object obj5 = obj3 + 192;
		nint num4 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v20 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj6 = (nint)0 + (nint)36;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v22+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27+8]");
		_ = 0;
		EnvironmentKind environmentKind2 = default;
		environmentKind2._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num5 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v36 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj7 = (nint)0 + (nint)4;
		obj7 = environmentKind2;
		object obj8 = obj3 + 180;
		nint num6 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v35 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj9 = (nint)0 + (nint)60;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v37+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v40+8]");
		_ = 0;
		EnvironmentKind environmentKind3 = default;
		environmentKind3._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num7 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v49 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = environmentKind3;
		object obj11 = obj3 + 168;
		nint num8 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v50 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj12 = (nint)0 + (nint)48;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v52+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v53+8]");
		_ = 0;
		EnvironmentKind environmentKind4 = default;
		environmentKind4._002Ector(environmentType, EnvironmentDensity.Low);
		nint num9 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v62 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj13 = (nint)0 + (nint)12;
		obj13 = environmentKind4;
		object obj14 = obj3 + 156;
		nint num10 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v65 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj15 = (nint)0 + (nint)72;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v67+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v66+8]");
		_ = 0;
		EnvironmentKind environmentKind5 = default;
		environmentKind5._002Ector(environmentType, EnvironmentDensity.Low);
		nint num11 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v75 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj16 = (nint)0 + (nint)16;
		obj16 = environmentKind5;
		object obj17 = obj3 + 144;
		nint num12 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v80 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj18 = (nint)0 + (nint)84;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v82+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v79+8]");
		_ = 0;
		EnvironmentKind environmentKind6 = default;
		environmentKind6._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num13 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v88 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj19 = (nint)0 + (nint)20;
		obj19 = environmentKind6;
		object obj20 = obj3 + 132;
		nint num14 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v95 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj21 = (nint)0 + (nint)108;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v97+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v92+8]");
		_ = 0;
		EnvironmentKind environmentKind7 = default;
		environmentKind7._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num15 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v101 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj22 = (nint)0 + (nint)24;
		obj22 = environmentKind7;
		object obj23 = obj3 + 120;
		nint num16 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v110 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj24 = (nint)0 + (nint)96;
		obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v112+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v105+8]");
		_ = 0;
		EnvironmentKind environmentKind8 = default;
		environmentKind8._002Ector(environmentType, EnvironmentDensity.Low);
		nint num17 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v114 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj25 = (nint)0 + (nint)28;
		obj25 = environmentKind8;
		object obj26 = obj3 + 108;
		nint num18 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v125 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj27 = (nint)0 + (nint)120;
		obj26 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S1_v127+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v118+8]");
		_ = 0;
		EnvironmentKind environmentKind9 = default;
		environmentKind9._002Ector(environmentType, EnvironmentDensity.Low);
		nint num19 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v127 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj28 = (nint)0 + (nint)32;
		obj28 = environmentKind9;
		object obj29 = obj3 + 96;
		nint num20 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v140 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj30 = (nint)0 + (nint)132;
		obj29 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v142+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v131+8]");
		_ = 0;
		EnvironmentKind environmentKind10 = default;
		environmentKind10._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num21 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v140 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj31 = (nint)0 + (nint)36;
		obj31 = environmentKind10;
		object obj32 = obj3 + 84;
		nint num22 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v155 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj33 = (nint)0 + (nint)144;
		obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S1_v157+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v144+8]");
		_ = 0;
		EnvironmentKind environmentKind11 = default;
		environmentKind11._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num23 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v153 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj34 = (nint)0 + (nint)40;
		obj34 = environmentKind11;
		object obj35 = obj3 + 72;
		nint num24 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S1_v170 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj36 = (nint)0 + (nint)156;
		obj35 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S1_v172+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v157+8]");
		_ = 0;
		EnvironmentKind environmentKind12 = default;
		environmentKind12._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num25 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v166 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj37 = (nint)0 + (nint)44;
		obj37 = environmentKind12;
		object obj38 = obj3 + 60;
		nint num26 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S1_v185 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj39 = (nint)0 + (nint)168;
		obj38 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S1_v187+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S0_v170+8]");
		_ = 0;
		EnvironmentKind environmentKind13 = default;
		environmentKind13._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num27 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v179 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj40 = (nint)0 + (nint)48;
		obj40 = environmentKind13;
		object obj41 = obj3 + 48;
		nint num28 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v200 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj42 = (nint)0 + (nint)144;
		obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S1_v202+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v183+8]");
		_ = 0;
		EnvironmentKind environmentKind14 = default;
		environmentKind14._002Ector(environmentType, EnvironmentDensity.Low);
		nint num29 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v192 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj43 = (nint)0 + (nint)52;
		obj43 = environmentKind14;
		object obj44 = obj3 + 36;
		nint num30 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S1_v215 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj45 = (nint)0 + (nint)168;
		obj44 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S1_v217+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v196+8]");
		_ = 0;
		EnvironmentKind environmentKind15 = default;
		environmentKind15._002Ector(environmentType, EnvironmentDensity.Low);
		nint num31 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ S0_v205 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj46 = (nint)0 + (nint)56;
		obj46 = environmentKind15;
		object obj47 = obj3 + 24;
		nint num32 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S1_v230 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj48 = (nint)0 + (nint)180;
		obj47 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S1_v232+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S0_v209+8]");
		_ = 0;
		EnvironmentKind environmentKind16 = default;
		environmentKind16._002Ector(environmentType, EnvironmentDensity.Medium);
		nint num33 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v218 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj49 = (nint)0 + (nint)60;
		obj49 = environmentKind16;
		object obj50 = obj3 + 12;
		nint num34 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S1_v245 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj51 = (nint)0 + (nint)192;
		obj50 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S1_v247+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v222+8]");
		_ = 0;
		EnvironmentKind environmentKind17 = default;
		environmentKind17._002Ector(environmentType, EnvironmentDensity.High);
		nint num35 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ S0_v231 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj52 = -(-64);
		obj52 = environmentKind17;
		nint num36 = (nint)typeof(EnvironmentBaseKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S1_v259 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
		object obj53 = (nint)0 + (nint)204;
		obj3 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S1_v261+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((EnvironmentType*)(int)environmentType)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		EnvironmentKind environmentKind18 = default;
		environmentKind18._002Ector(environmentType, EnvironmentDensity.Low);
		nint num37 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v243 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj54 = (nint)0 + (nint)68;
		obj54 = environmentKind18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S3_v20 (Il2CppMethodInfo)+C]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S3_v21+60]");
		object obj56 = 0;
		object obj57 = obj56;
		object obj58 = obj57 & 0x1FFF;
		object obj59 = obj58 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v678 @ S4_v4 (should have been resolved before IL gen)");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S4_v7+60]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S4_v8+48]");
		object obj62 = 0;
		object obj63 = obj62 & 0x7FF;
		object obj64 = obj63 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v699 @ S5_v6 (should have been resolved before IL gen)");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S4_v12+60]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ S4_v13+48]");
		object obj67 = 0;
		object obj68 = obj67 & 0x7FF;
		object obj69 = obj68 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v720 @ S5_v10 (should have been resolved before IL gen)");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S4_v17+60]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ S4_v18+48]");
		object obj72 = 0;
		object obj73 = obj72 & 0x7FF;
		object obj74 = obj73 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v741 @ S5_v14 (should have been resolved before IL gen)");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S4_v22+60]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ S4_v23+48]");
		object obj77 = 0;
		object obj78 = obj77 & 0x7FF;
		object obj79 = obj78 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v762 @ S5_v18 (should have been resolved before IL gen)");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S4_v27+60]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S4_v28+48]");
		object obj82 = 0;
		object obj83 = obj82 & 0x7FF;
		object obj84 = obj83 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v783 @ S5_v22 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S4_v32+60]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S4_v33+48]");
		object obj87 = 0;
		object obj88 = obj87 & 0x7FF;
		object obj89 = obj88 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v804 @ S5_v26 (should have been resolved before IL gen)");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S4_v37+60]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ S4_v38+48]");
		object obj92 = 0;
		object obj93 = obj92 & 0x7FF;
		object obj94 = obj93 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v825 @ S5_v30 (should have been resolved before IL gen)");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ S4_v42+60]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ S4_v43+48]");
		object obj97 = 0;
		object obj98 = obj97 & 0x7FF;
		object obj99 = obj98 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v846 @ S5_v34 (should have been resolved before IL gen)");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ S4_v47+60]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S4_v48+48]");
		object obj102 = 0;
		object obj103 = obj102 & 0x7FF;
		object obj104 = obj103 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v867 @ S5_v38 (should have been resolved before IL gen)");
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ S4_v52+60]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ S4_v53+48]");
		object obj107 = 0;
		object obj108 = obj107 & 0x7FF;
		object obj109 = obj108 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v888 @ S5_v42 (should have been resolved before IL gen)");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S4_v57+60]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ S4_v58+48]");
		object obj112 = 0;
		object obj113 = obj112 & 0x7FF;
		object obj114 = obj113 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v909 @ S5_v46 (should have been resolved before IL gen)");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj115 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ S4_v62+60]");
		object obj116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ S4_v63+48]");
		object obj117 = 0;
		object obj118 = obj117 & 0x7FF;
		object obj119 = obj118 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v930 @ S5_v50 (should have been resolved before IL gen)");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ S4_v67+60]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ S4_v68+48]");
		object obj122 = 0;
		object obj123 = obj122 & 0x7FF;
		object obj124 = obj123 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v951 @ S5_v54 (should have been resolved before IL gen)");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ S4_v71 (Il2CppMethodInfo)+C]");
		object obj125 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ S4_v72+60]");
		object obj126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ S4_v73+48]");
		object obj127 = 0;
		object obj128 = obj127 & 0x7FF;
		object obj129 = obj128 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v972 @ S5_v58 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ S4_v76 (Il2CppMethodInfo)+C]");
		object obj130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v984 @ S4_v77+60]");
		object obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ S4_v78+48]");
		object obj132 = 0;
		object obj133 = obj132 & 0x7FF;
		object obj134 = obj133 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v993 @ S5_v62 (should have been resolved before IL gen)");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ S4_v81 (Il2CppMethodInfo)+C]");
		object obj135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ S4_v82+60]");
		object obj136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ S4_v83+48]");
		object obj137 = 0;
		object obj138 = obj137 & 0x7FF;
		object obj139 = obj138 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1014 @ S5_v66 (should have been resolved before IL gen)");
		nint num55 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ S1_v338 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj140 = -(-64);
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ S4_v86 (Il2CppMethodInfo)+C]");
		object obj141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ S4_v87+60]");
		object obj142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ S4_v88+48]");
		object obj143 = 0;
		object obj144 = obj143 & 0x7FF;
		object obj145 = obj144 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1037 @ S5_v70 (should have been resolved before IL gen)");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1048 @ S4_v91 (Il2CppMethodInfo)+C]");
		object obj146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ S4_v92+60]");
		object obj147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S4_v93+48]");
		object obj148 = 0;
		object obj149 = obj148 & 0x7FF;
		object obj150 = obj149 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1058 @ S5_v74 (should have been resolved before IL gen)");
		nint num58 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ S0_v286 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj151 = (nint)0 + (nint)72;
		object obj152 = default;
		obj151 = obj152;
	}
}
