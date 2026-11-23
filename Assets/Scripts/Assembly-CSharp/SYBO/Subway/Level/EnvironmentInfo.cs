using System;
using Cpp2ILInjected;

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

	public static int DefaultMaxMidPieceCount = 100;

	public static int DefaultMidPieceLengthInBlocks = 2;

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

	public int MidPieceLength => MidPieceLengthInBlocks * 90;

	public int StartEndPieceLength => StartEndPieceLengthInBlocks * 90;

	public int MinLengthInBlocks
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

	public int LengthMin
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

	public int MidLengthMax => MaxMidPieceCount * MidPieceLengthInBlocks;

	public int MaxLengthInBlocks
	{
		get
		{
			//IL_002a: Expected Obj, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected I4, but got Unknown
			if (~(HasStartEnd ? 1u : 0u) == 0)
			{
				object obj = MaxMidPieceCount * MidPieceLengthInBlocks;
				int num = StartEndPieceLengthInBlocks << 1;
				return obj + num;
			}
			return MaxMidPieceCount * MidPieceLengthInBlocks;
		}
	}

	public int MaxLength
	{
		get
		{
			//IL_005d: Expected Obj, but got I4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected I4, but got Unknown
			//IL_002a: Expected Obj, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			object obj2;
			if (~(HasStartEnd ? 1u : 0u) == 0)
			{
				object obj = MaxMidPieceCount * MidPieceLengthInBlocks;
				int num = StartEndPieceLengthInBlocks << 1;
				obj2 = obj + num;
			}
			else
			{
				obj2 = MaxMidPieceCount * MidPieceLengthInBlocks;
			}
			return obj2 * 90;
		}
	}

	public EnvironmentInfo(EnvironmentKind envKind, bool hasStartEnd, bool hasSides, bool useSameVariationPerSequence, bool useSameVariationForSides, int maxMidPieceCount, int lengthMidPieceInBlocks, int lengthStartEndPieceInBlocks)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Kind = envKind;
		UseSameVariationForSides = useSameVariationForSides;
		UseSameVariationPerSequence = useSameVariationPerSequence;
		HasSides = hasSides;
		HasStartEnd = hasStartEnd;
		if (maxMidPieceCount > DefaultMaxMidPieceCount)
		{
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			_ = DefaultMaxMidPieceCount;
			object obj4 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			string text = $"[EnvironmentInfo] Kind {envKind} : Max mid piece count {arg} larger than allowed {arg2}";
		}
		StartEndPieceLengthInBlocks = lengthStartEndPieceInBlocks;
		MidPieceLengthInBlocks = lengthMidPieceInBlocks;
		MaxMidPieceCount = maxMidPieceCount;
	}

	public int GetSequenceLengthInBlocks(EnvironmentSequence sequence)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a8: Expected I4, but got Obj
		//IL_0027: Expected Obj, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		object obj2;
		if (~(HasStartEnd ? 1u : 0u) == 0)
		{
			object obj = sequence - 1;
			if (sequence == EnvironmentSequence.Start || ((nint)obj != 1 && (nint)obj == 2))
			{
				obj2 = this + 24;
				goto IL_00a3;
			}
		}
		obj2 = this + 20;
		goto IL_00a3;
		IL_00a3:
		return (int)obj2;
	}

	public static EnvironmentInfo GetByKind(EnvironmentKind envKind)
	{
		//IL_0161: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I
		//IL_00eb: Expected VT, but got Obj
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_0131: Expected I, but got Obj
		EnvironmentInfo[] all = All;
		object obj = 0;
		EnvironmentInfo environmentInfo = None;
		object obj4 = default;
		object obj5 = default;
		while (all.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)all + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v36+10]");
			EnvironmentInfo environmentInfo2 = (EnvironmentInfo)0;
			EnvironmentKind kind = environmentInfo2.Kind;
			bool flag = kind._type == envKind._type && kind._density == envKind._density;
			if (!flag)
			{
				environmentInfo2 = environmentInfo;
			}
			obj4 = flag | obj5;
			object obj6 = obj + 1;
			obj = obj6;
			environmentInfo = environmentInfo2;
		}
		object obj7 = obj4 & 1;
		if (obj7 == null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(EnvironmentInfo));
			object obj8 = typeFromHandle - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S1_v9+BC] (should have been resolved before IL gen)");
			string text = default;
			if ((object)envKind != null)
			{
				nint num = (nint)envKind;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ S4_v5 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string text3 = default;
			string text2 = "Could not find " + text3 + " for EnvironmentKind " + text;
		}
		return environmentInfo;
	}

	static EnvironmentInfo()
	{
		int defaultMaxMidLengthInBlocks = DefaultMidPieceLengthInBlocks * DefaultMaxMidPieceCount;
		DefaultMaxMidLengthInBlocks = defaultMaxMidLengthInBlocks;
		EnvironmentKind none = EnvironmentKind.None;
		EnvironmentInfo environmentInfo = default;
		environmentInfo._002Ector(none, hasStartEnd: false, hasSides: false, useSameVariationPerSequence: false, useSameVariationForSides: false, 0, 0, 0);
		None = environmentInfo;
		EnvironmentInfo environmentInfo2 = default;
		environmentInfo2._002Ector(EnvironmentKind.Empty, hasStartEnd: false, hasSides: false, useSameVariationPerSequence: false, useSameVariationForSides: false, 0, 0, 0);
		Empty = environmentInfo2;
		EnvironmentInfo environmentInfo3 = default;
		environmentInfo3._002Ector(EnvironmentKind.FillersLow, hasStartEnd: false, hasSides: true, useSameVariationPerSequence: false, useSameVariationForSides: false, DefaultMaxMidPieceCount, 2, 0);
		FillersLow = environmentInfo3;
		EnvironmentInfo environmentInfo4 = default;
		environmentInfo4._002Ector(EnvironmentKind.FillersMedium, hasStartEnd: false, hasSides: true, useSameVariationPerSequence: false, useSameVariationForSides: false, DefaultMaxMidPieceCount, 2, 0);
		FillersMedium = environmentInfo4;
		EnvironmentInfo environmentInfo5 = default;
		environmentInfo5._002Ector(EnvironmentKind.FillersHigh, hasStartEnd: false, hasSides: true, useSameVariationPerSequence: false, useSameVariationForSides: false, DefaultMaxMidPieceCount, 2, 0);
		FillersHigh = environmentInfo5;
		EnvironmentInfo environmentInfo6 = default;
		environmentInfo6._002Ector(EnvironmentKind.Gates, hasStartEnd: false, hasSides: false, useSameVariationPerSequence: false, useSameVariationForSides: false, 1, 4, 0);
		Gates = environmentInfo6;
		EnvironmentInfo environmentInfo7 = default;
		environmentInfo7._002Ector(EnvironmentKind.Tube, hasStartEnd: false, hasSides: false, useSameVariationPerSequence: true, useSameVariationForSides: false, DefaultMaxMidPieceCount, 2, 0);
		Tube = environmentInfo7;
		EnvironmentInfo environmentInfo8 = default;
		environmentInfo8._002Ector(EnvironmentKind.Pillars, hasStartEnd: true, hasSides: false, useSameVariationPerSequence: true, useSameVariationForSides: false, DefaultMaxMidPieceCount, 2, 1);
		Pillars = environmentInfo8;
		EnvironmentInfo environmentInfo9 = default;
		environmentInfo9._002Ector(EnvironmentKind.Station, hasStartEnd: true, hasSides: false, useSameVariationPerSequence: true, useSameVariationForSides: false, DefaultMaxMidPieceCount, 2, 1);
		Station = environmentInfo9;
		EnvironmentInfo environmentInfo10 = default;
		environmentInfo10._002Ector(EnvironmentKind.Epic, hasStartEnd: true, hasSides: false, useSameVariationPerSequence: true, useSameVariationForSides: false, DefaultMaxMidPieceCount, 4, 4);
		Epic = environmentInfo10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
