using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer;

public abstract class fsDirectConverter : fsBaseConverter
{
	public abstract Type ModelType { get; }
}
public abstract class fsDirectConverter<TModel> : fsDirectConverter
{
	public override Type ModelType
	{
		get
		{
			//IL_0014: Expected VT, but got I
			nint num = 0;
			return Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		}
	}

	public unsafe sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0042: Expected I, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I
		//IL_00a4: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		NullReferenceException ex = new NullReferenceException();
		_ = ((Exception)ex)._data;
		_ = ((Exception)ex)._className;
		obj = ex;
		object obj3 = obj - 32;
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 24;
		object obj5 = obj3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S0_v16 (Il2CppClass<FullSerializer.fsDirectConverter`1<TModel>>)+10C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		object obj6 = 0;
		fsResult fsResult2 = default;
		ref fsData reference = ref *(fsData*)fsResult2;
		return fsResult2;
	}

	public unsafe sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected VT, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected VT, but got Unknown
		//IL_0218: Expected native int or pointer, but got VT
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00b4: Expected I, but got Obj
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected VT, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected VT, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		fsResult fsResult2 = CheckType(data, fsDataType.Object);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		fsResult fsResult3 = (fsResult)(obj + 32);
		fsResult fsResult4 = (fsResult)(obj + 24);
		fsResult fsResult5 = fsResult3 + fsResult4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		bool flag = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		bool success = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			NullReferenceException ex = new NullReferenceException();
			_ = ((Exception)ex)._data;
			_ = ((Exception)ex)._className;
			object obj3 = obj + 40;
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			object obj4 = obj + 104;
			nint num = (nint)this;
			object obj5 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S4_v5 (Il2CppClass<FullSerializer.fsDirectConverter`1<TModel>>)+114] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			fsResult fsResult6 = (fsResult)(obj + 16);
			fsResult fsResult7 = (fsResult)(obj + 8);
			fsResult fsResult8 = fsResult6 + fsResult7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj6 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj7 = default;
			ref object reference = ref *(object*)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			success = false;
		}
		fsResult fsResult9 = default;
		((fsResult*)(nint)fsResult9)->_success = success;
		return fsResult9;
	}

	protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);

	protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);
}
