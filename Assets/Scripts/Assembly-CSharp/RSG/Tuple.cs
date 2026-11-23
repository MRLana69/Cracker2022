using System;
using Cpp2ILInjected;

namespace RSG;

public class Tuple
{
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		//IL_002b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S4_v2 (Il2CppMethodRgctx<RSG.Tuple::Create>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S4_v3+4] (should have been resolved before IL gen)");
		Tuple<T1, T2> result = default;
		return result;
	}

	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		//IL_002b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S5_v2 (Il2CppMethodRgctx<RSG.Tuple::Create>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S5_v3+4] (should have been resolved before IL gen)");
		Tuple<T1, T2, T3> result = default;
		return result;
	}

	public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		//IL_002b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S6_v2 (Il2CppMethodRgctx<RSG.Tuple::Create>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S6_v3+4] (should have been resolved before IL gen)");
		Tuple<T1, T2, T3, T4> result = default;
		return result;
	}
}
public class Tuple<T1, T2>
{
	public T1 Item1
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public T2 Item2
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	internal Tuple(T1 item1, T2 item2)
	{
		//IL_003a: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S3_v4 (Il2CppClass<Il2CppRgctx<RSG.Tuple`2>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v8 (Il2CppRgctx<RSG.Tuple`2>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v9+4] (should have been resolved before IL gen)");
	}
}
public class Tuple<T1, T2, T3>
{
	public T1 Item1
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public T2 Item2
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public T3 Item3
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	internal Tuple(T1 item1, T2 item2, T3 item3)
	{
		//IL_003a: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S3_v4 (Il2CppClass<Il2CppRgctx<RSG.Tuple`3>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v8 (Il2CppRgctx<RSG.Tuple`3>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v9+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v13 (Il2CppRgctx<RSG.Tuple`3>)+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S3_v14+4] (should have been resolved before IL gen)");
	}
}
public class Tuple<T1, T2, T3, T4>
{
	public T1 Item1
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public T2 Item2
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public T3 Item3
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public T4 Item4
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	internal Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		//IL_003a: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S3_v4 (Il2CppClass<Il2CppRgctx<RSG.Tuple`4>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v8 (Il2CppRgctx<RSG.Tuple`4>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v9+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v13 (Il2CppRgctx<RSG.Tuple`4>)+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S3_v14+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S3_v18 (Il2CppRgctx<RSG.Tuple`4>)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S3_v19+4] (should have been resolved before IL gen)");
	}
}
