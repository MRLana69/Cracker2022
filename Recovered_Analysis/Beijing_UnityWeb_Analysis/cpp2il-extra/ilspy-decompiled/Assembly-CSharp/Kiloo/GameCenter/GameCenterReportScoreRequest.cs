using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;

namespace Kiloo.GameCenter;

public class GameCenterReportScoreRequest : GameCenterRequest
{
	public string category
	{
		get
		{
			return field;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public long scoreValue
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_001c: Expected Obj, but got I4
			//IL_0050: Expected I8, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			obj = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7571");
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			return (long)obj;
		}
		set
		{
			//IL_0008: Expected Obj, but got I8
			//IL_00a5: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I
			//IL_00c5: Expected Obj, but got I
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_003b: Expected Obj, but got I
			//IL_004b: Expected Obj, but got I
			//IL_005b: Expected Obj, but got I
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			object obj = value;
			Dictionary<string, string> syboAnalyticsUnhandledAbTestData = SyboAnalyticsSave.syboAnalyticsUnhandledAbTestData;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v4+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35 @ S3_v4 (should have been resolved before IL gen)");
			object obj7 = default;
			if ((nint)obj7 <= -1)
			{
				Dictionary<string, string> syboAnalyticsUnhandledAbTestData2 = SyboAnalyticsSave.syboAnalyticsUnhandledAbTestData;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D66F");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v5 (Il2CppMethodInfo)+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v6+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S4_v7+48]");
				object obj10 = 0;
				object obj11 = obj10 & 0x7FF;
				object obj12 = obj11 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v5 (should have been resolved before IL gen)");
			}
		}
	}

	public ulong scoreContext
	{
		get
		{
			//IL_0006: Expected I8, but got I4
			return 1uL;
		}
		set
		{
			//IL_0005: Expected I, but got Obj
			//IL_001b: Expected Obj, but got I
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_0041: Expected Obj, but got I
			//IL_0058: Expected I, but got Obj
			//IL_006e: Expected Obj, but got I
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S2_v2 (Il2CppClass<Kiloo.GameCenter.GameCenterReportScoreRequest>)+74]");
			object obj = (nint)0 & (nint)0x3FFF;
			object obj2 = obj + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v10 @ S2_v5 (should have been resolved before IL gen)");
			nint num2 = default;
			object obj3 = num2 & 4;
			bool flag = obj3 != null;
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v9 (Il2CppClass<Kiloo.GameCenter.GameCenterReportScoreRequest>)+C0]");
			object obj4 = (nint)0 & (nint)0x3FFF;
			object obj5 = obj4 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S2_v12 (should have been resolved before IL gen)");
		}
	}
}
