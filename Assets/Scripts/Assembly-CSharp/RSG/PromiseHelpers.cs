using System;
using Cpp2ILInjected;

namespace RSG;

public static class PromiseHelpers
{
	public static IPromise<Tuple<T1, T2>> All<T1, T2>(IPromise<T1> p1, IPromise<T2> p2)
	{
		//IL_0186: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v2 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v3+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		object obj4 = obj3 + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 0;
		_ = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v6 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v7+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num5 = 0;
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S4_v2 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S4_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		throw new ArgumentException();
	}

	public static IPromise<Tuple<T1, T2, T3>> All<T1, T2, T3>(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3)
	{
		//IL_003a: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<RSG.PromiseHelpers::All>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v6 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S3_v7+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v9+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v10+4]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v10+4]");
		object obj3 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v23+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			nint num5 = 0;
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v3 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+14]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S4_v4+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v32+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj7 = default;
			obj3 = obj7;
		}
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
		IPromise<Tuple<T1, T2, T3>> result = default;
		return result;
	}

	public static IPromise<Tuple<T1, T2, T3, T4>> All<T1, T2, T3, T4>(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4)
	{
		//IL_003a: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<RSG.PromiseHelpers::All>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S4_v2 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S4_v3+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v9 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v10+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v9+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v10+4]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v10+4]");
		object obj4 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			nint num7 = 0;
			nint num8 = 0;
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S4_v7 (Il2CppMethodRgctx<RSG.PromiseHelpers::All>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S4_v8+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v32+5C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj8 = default;
			obj4 = obj8;
		}
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
		IPromise<Tuple<T1, T2, T3, T4>> result = default;
		return result;
	}
}
