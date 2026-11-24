using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public class Variable<T> where T : IComparable
{
	public delegate void OnChangeDelegate(T value);

	private T value;

	public OnChangeDelegate OnChange;

	public T Value
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @919E");
			T result = default;
			return result;
		}
		set
		{
			//IL_00f9: Expected Obj, but got I
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			//IL_019c: Expected Obj, but got VT
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected Obj, but got Unknown
			//IL_01bf: Expected Obj, but got I
			//IL_01cf: Expected Obj, but got I
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected Obj, but got Unknown
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected Obj, but got Unknown
			//IL_020b: Expected Obj, but got I
			//IL_0226: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected Obj, but got Unknown
			//IL_0114: Expected Obj, but got I
			//IL_012c: Expected Obj, but got I
			//IL_013c: Expected Obj, but got I
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected Obj, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected Obj, but got Unknown
			//IL_00de: Expected Obj, but got I
			T val = this.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Variable`1<T>)+14]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2 (T)+C]");
			nint num2 = default;
			object obj12;
			if (num == 0)
			{
				T val2 = this.value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v15 (T)+C]");
				object obj = (nint)0 + (nint)4;
				T val3 = this.value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v20 (T)+C]");
				object obj2 = (nint)0 * (nint)200;
				object obj3 = obj2 / 100;
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				bool flag2 = !flag;
				object obj4 = obj3;
				if (!flag2)
				{
					T val4 = this.value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v22 (T)+C]");
					object obj5 = (nint)0 + (nint)4;
					obj4 = obj5;
				}
				object obj6 = num2 + 12;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v13+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v14+C]");
				object obj9 = 0;
				object obj10 = obj9 & 0x3FFF;
				object obj11 = obj10 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S3_v10 (should have been resolved before IL gen)");
				obj12 = obj6;
			}
			else
			{
				object obj13 = num2 + 12;
				obj12 = obj13;
			}
			object obj14 = this.value + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Variable`1<T>)+10]");
			object obj15 = obj14 + 0;
			obj15 = value;
			object obj16 = this + 16;
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v4+60]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v5+10]");
			object obj19 = 0;
			object obj20 = obj19 & 0x3FFF;
			object obj21 = obj20 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S3_v5 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Variable`1<T>)+14]");
			object obj22 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Variable`1<T>)+18]");
			object obj23 = (nint)0 + (nint)1;
		}
	}

	public Variable(T initialValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 40;
		object obj3 = obj2 + 24;
		object obj4 = initialValue + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [initialValue @ L1 (T)+4]");
		if ((nint)0 == -1)
		{
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9+8]");
			_ = 0;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9+10]");
			bool flag = (nint)0 != 0;
		}
		else
		{
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9+8]");
			_ = 0;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8778");
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
	}

	public void FireOnChange()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v4+60]");
		object obj4 = 0;
		object obj5 = obj3 & 0x3FFF;
		object obj6 = obj5 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S2_v3 (should have been resolved before IL gen)");
	}

	private void NotifyOnChange()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
	}
}
