using Cpp2ILInjected;

namespace SYBO.Common.Utilities.Flags;

public static class FlagsHelper
{
	public static bool IsSet<T>(T flags, T flag) where T : struct
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got VT
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v14+60]");
		object obj5 = (nint)0 + (nint)16;
		object obj6 = obj5;
		object obj7 = flag;
		object obj8 = obj7 + 8;
		obj8 = obj7;
		object obj9 = obj6 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S4_v3 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flags @ L0 (T)+8]");
		if ((nint)0 != 0)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S3_v8+60]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S3_v9+18]");
			object obj13 = 0;
			object obj14 = obj13 & 0x1FFF;
			object obj15 = obj14 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S4_v10 (should have been resolved before IL gen)");
		}
		else
		{
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v4+60]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v5+14]");
			object obj18 = 0;
			object obj19 = obj18 & 0x3FFF;
			object obj20 = obj19 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S3_v6 (should have been resolved before IL gen)");
		}
		bool result = default;
		return result;
	}

	public unsafe static void Set<T>(ref T flags, T flag) where T : struct
	{
		//IL_001f: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		ref T reference = ref *(T*)null;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S2_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B5D8");
	}

	public static void SetEverything<T>(ref T flags) where T : struct
	{
	}

	public static void SetNothing<T>(ref T flags) where T : struct
	{
	}

	public static void Unset<T>(ref T flags, T flag) where T : struct
	{
	}
}
