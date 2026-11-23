using System;
using Cpp2ILInjected;

public class Variable<T> where T : IComparable
{
	public delegate void OnChangeDelegate(T value);

	private T value;

	public OnChangeDelegate OnChange;

	public unsafe T Value
	{
		get
		{
			return value;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected I4, but got Unknown
			//IL_004a: Expected VT, but got I
			//IL_0083: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_ = this.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj3 = obj + 14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			bool flag = (byte)(obj + 15) != 0;
			object obj4 = default;
			int num = (flag ? ((bool*)1) : ((bool*)null))->CompareTo(obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
			this.value = (T)0;
			if (num != 0)
			{
				nint num2 = 0;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v9 (Il2CppRgctx<Variable`1>)+8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S2_v10+4] (should have been resolved before IL gen)");
			}
		}
	}

	public Variable(T initialValue)
	{
		value = initialValue;
	}

	public void FireOnChange()
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S2_v3 (Il2CppRgctx<Variable`1>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v4+4] (should have been resolved before IL gen)");
	}

	private void NotifyOnChange()
	{
		//IL_003b: Expected Obj, but got I
		if (OnChange != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S3_v4 (Il2CppRgctx<Variable`1>)+10]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}
}
