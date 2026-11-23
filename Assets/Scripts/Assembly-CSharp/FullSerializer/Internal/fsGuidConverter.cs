using System;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsGuidConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0014: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Guid));
		return (object)typeFromHandle == type;
	}

	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Expected native int or pointer, but got VT
		//IL_004a: Expected native int or pointer, but got VT
		//IL_006a: Expected I4, but got Obj
		//IL_0065: Expected native int or pointer, but got VT
		//IL_0077: Expected I4, but got Obj
		//IL_0072: Expected native int or pointer, but got VT
		//IL_0080: Expected Ref, but got VT
		//IL_002e: Expected I4, but got VT
		//IL_0029: Expected native int or pointer, but got VT
		object obj = default;
		Guid guid = (Guid)(obj - 16);
		((Guid*)(nint)guid)->_d = 0;
		((Guid*)(nint)guid)->_a = 0;
		NullReferenceException ex = new NullReferenceException();
		((Guid*)(nint)guid)->_d = (byte)(int)((Exception)ex)._className;
		((Guid*)(nint)guid)->_a = (int)ex;
		string text = ((Guid*)guid)->ToString();
		object obj2 = default;
		ref fsData reference = ref *(fsData*)obj2;
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		return fsResult2;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b6: Expected native int or pointer, but got VT
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0042: Expected native int or pointer, but got VT
		//IL_0069: Expected Obj, but got I
		//IL_008e: Expected I4, but got VT
		//IL_0089: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		fsResult fsResult2 = default;
		if (data.IsString)
		{
			string asString = data.AsString;
			_ = 0;
			_ = 0;
			Guid guid = (Guid)(obj + 16);
			*(Guid*)(nint)guid = new Guid(asString);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj3 = default;
			ref object reference = ref *(object*)obj3;
			((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			fsResult fsResult3 = fsResult.Fail("fsGuidConverter encountered an unknown JSON data type");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			((fsResult*)(nint)fsResult2)->_success = false;
		}
		return fsResult2;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object result = default;
		return result;
	}
}
