using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Info;

public static class Trophies
{
	public enum Trophy
	{
		diamond,
		goldbar,
		goldChainClock,
		goldChainDollar,
		goldSkull,
		headphones,
		lpBlack,
		tapeBlack
	}

	public const int NUMBER_OF_TROPHIES_FOR_FIRST_ACHIEVEMENT = 8;

	public static readonly Dictionary<Trophy, TrophyData> trophyData;

	static Trophies()
	{
		//IL_01a2: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>>)+4] (should have been resolved before IL gen)");
		_ = 4294967356L;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S5_v4+4] (should have been resolved before IL gen)");
		_ = 4294967358L;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S5_v9+4] (should have been resolved before IL gen)");
		_ = 64;
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S5_v14+4] (should have been resolved before IL gen)");
		_ = 4294967362L;
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S5_v19+4] (should have been resolved before IL gen)");
		_ = 4294967364L;
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ S5_v24+4] (should have been resolved before IL gen)");
		_ = 70;
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S5_v29+4] (should have been resolved before IL gen)");
		_ = 72;
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S5_v34+4] (should have been resolved before IL gen)");
		_ = 74;
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Info.Trophies+Trophy, Info.TrophyData>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ S5_v39+4] (should have been resolved before IL gen)");
		Dictionary<Trophy, TrophyData> dictionary = default;
		trophyData = dictionary;
	}
}
