using System;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsTypeConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0014: Expected VT, but got Obj
		//IL_0020: Expected I, but got Obj
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Type));
		nint num = (nint)typeFromHandle;
		object obj = typeFromHandle + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v2 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public override bool RequestCycleSupport(Type type)
	{
		return false;
	}

	public override bool RequestInheritanceSupport(Type type)
	{
		return false;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0013: Expected I4, but got VT
		//IL_000e: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		object obj2 = default;
		object obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v5+18C] (should have been resolved before IL gen)");
		object obj3 = default;
		ref fsData reference = ref *(fsData*)obj3;
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		return fsResult2;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ee: Expected I4, but got VT
		//IL_00e9: Expected native int or pointer, but got VT
		//IL_0036: Expected native int or pointer, but got VT
		//IL_00d6: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult3 = default;
		if (!data.IsString)
		{
			fsResult fsResult2 = fsResult.Fail("Type converter requires a string");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		else
		{
			string asString = data.AsString;
			Type type = fsTypeCache.GetType(asString);
			ref object reference = ref *(object*)type;
			if (instance == null)
			{
				string asString2 = data.AsString;
				string warning = "Unable to find type " + asString2;
				fsResult fsResult4 = fsResult.Fail(warning);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
			else
			{
				((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
			}
		}
		return fsResult3;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		return storageType;
	}
}
