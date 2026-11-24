using System;
using Cpp2ILInjected;
using SYBO.Subway.Level;

namespace SYBO.Subway.Routes;

public struct RouteConstraint
{
	public readonly EnvironmentKind[] AllowedEnvironmentKinds;

	public static RouteConstraint None;

	public RouteConstraint(EnvironmentKind[] allowedEnvironmentKinds)
	{
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0046: Expected I, but got Obj
		//IL_0559: Expected Obj, but got I
		//IL_0536: Expected Obj, but got VT
		//IL_01bb: Expected I, but got Obj
		//IL_01eb: Expected I, but got Obj
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_0062: Expected I, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_058b: Expected Obj, but got I
		//IL_0211: Expected I, but got Obj
		//IL_0273: Expected I, but got Obj
		//IL_02a3: Expected I, but got Obj
		//IL_02dc: Expected I, but got Obj
		//IL_02f2: Expected Obj, but got I
		//IL_030f: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_05bd: Expected Obj, but got I
		//IL_02c9: Expected I, but got Obj
		//IL_032b: Expected I, but got Obj
		//IL_035b: Expected I, but got Obj
		//IL_0394: Expected I, but got Obj
		//IL_03aa: Expected Obj, but got I
		//IL_03c7: Expected I, but got Obj
		//IL_05ef: Expected Obj, but got I
		//IL_0381: Expected I, but got Obj
		//IL_03e3: Expected I, but got Obj
		//IL_0413: Expected I, but got Obj
		//IL_044c: Expected I, but got Obj
		//IL_0462: Expected Obj, but got I
		//IL_047f: Expected I, but got Obj
		//IL_0626: Expected Obj, but got VT
		//IL_0439: Expected I, but got Obj
		//IL_049b: Expected I, but got Obj
		//IL_04cb: Expected I, but got Obj
		//IL_04f1: Expected I, but got Obj
		if (allowedEnvironmentKinds.Length != 0)
		{
			nint num = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v77 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			nint num2 = (nint)typeof(EnvironmentBaseKind);
			if (!flag)
			{
				nint num3 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v82 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num2 = (nint)typeof(EnvironmentBaseKind);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ L1_v24 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num4 = (nint)0 + (nint)12;
			AllowedEnvironmentKinds = (EnvironmentKind[])EnvironmentBaseKind.None;
			IntPtr intPtr = num4;
		}
		else
		{
			if ((object)allowedEnvironmentKinds[0] == null)
			{
				nint num5 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v13 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag4 = obj2 == null;
				nint num6 = (nint)typeof(EnvironmentBaseKind);
				if (!flag4)
				{
					nint num7 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v19 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag5 = (nint)0 == 0;
					bool flag6 = !flag5;
					num6 = (nint)typeof(EnvironmentBaseKind);
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num6 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ L1_v4 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object allowedEnvironmentKinds2 = (nint)0 + (nint)24;
				AllowedEnvironmentKinds = (EnvironmentKind[])allowedEnvironmentKinds2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v9+8]");
				_ = 0;
				return;
			}
			if ((nint)allowedEnvironmentKinds[0] == 1)
			{
				nint num8 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v26 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag7 = obj3 == null;
				nint num9 = (nint)typeof(EnvironmentBaseKind);
				if (!flag7)
				{
					nint num10 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v32 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag8 = (nint)0 == 0;
					bool flag9 = !flag8;
					num9 = (nint)typeof(EnvironmentBaseKind);
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num9 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ L1_v8 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object allowedEnvironmentKinds3 = (nint)0 + (nint)36;
				AllowedEnvironmentKinds = (EnvironmentKind[])allowedEnvironmentKinds3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v16+8]");
				_ = 0;
				return;
			}
			if ((nint)allowedEnvironmentKinds[0] == 2)
			{
				nint num11 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v39 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag10 = obj4 == null;
				nint num12 = (nint)typeof(EnvironmentBaseKind);
				if (!flag10)
				{
					nint num13 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v45 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag11 = (nint)0 == 0;
					bool flag12 = !flag11;
					num12 = (nint)typeof(EnvironmentBaseKind);
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num12 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ L1_v12 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object allowedEnvironmentKinds4 = (nint)0 + (nint)84;
				AllowedEnvironmentKinds = (EnvironmentKind[])allowedEnvironmentKinds4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v23+8]");
				_ = 0;
				return;
			}
			if ((nint)allowedEnvironmentKinds[0] == 3)
			{
				nint num14 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v52 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				bool flag13 = obj5 == null;
				nint num15 = (nint)typeof(EnvironmentBaseKind);
				if (!flag13)
				{
					nint num16 = (nint)typeof(EnvironmentBaseKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v58 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
					bool flag14 = (nint)0 == 0;
					bool flag15 = !flag14;
					num15 = (nint)typeof(EnvironmentBaseKind);
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num15 = (nint)typeof(EnvironmentBaseKind);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ L1_v16 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
				object allowedEnvironmentKinds5 = (nint)0 + (nint)132;
				AllowedEnvironmentKinds = (EnvironmentKind[])allowedEnvironmentKinds5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v30+8]");
				_ = 0;
				return;
			}
			nint num17 = (nint)typeof(EnvironmentBaseKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v65 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			bool flag16 = obj6 == null;
			nint num18 = (nint)typeof(EnvironmentBaseKind);
			if (!flag16)
			{
				nint num19 = (nint)typeof(EnvironmentBaseKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v70 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+74]");
				bool flag17 = (nint)0 == 0;
				bool flag18 = !flag17;
				num18 = (nint)typeof(EnvironmentBaseKind);
				if (!flag18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num18 = (nint)typeof(EnvironmentBaseKind);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ L1_v20 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseKind>)+5C]");
			nint num20 = 0;
			AllowedEnvironmentKinds = (EnvironmentKind[])EnvironmentBaseKind.None;
			IntPtr intPtr = num20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ L1_v2 (Il2CppStaticFields<SYBO.Subway.Level.EnvironmentBaseKind>)+8]");
		_ = 0;
	}
}
