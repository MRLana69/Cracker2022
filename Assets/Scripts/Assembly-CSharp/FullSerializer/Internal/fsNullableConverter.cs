using System;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsNullableConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0066: Expected I, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0034: Expected VT, but got Obj
		nint num = (nint)type;
		object obj = type + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v3 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			nint num2 = (nint)type;
			object obj3 = type + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S1_v8 (Il2CppClass<System.Type>)+23C] (should have been resolved before IL gen)");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Nullable<>));
			object obj4 = default;
			return typeFromHandle == obj4;
		}
		return false;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004b: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Type underlyingType = Nullable.GetUnderlyingType(storageType);
		fsResult fsResult2 = Serializer.TrySerialize(underlyingType, instance, out serialized);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = false;
		return fsResult3;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004b: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Type underlyingType = Nullable.GetUnderlyingType(storageType);
		fsResult fsResult2 = Serializer.TryDeserialize(data, underlyingType, ref instance);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = false;
		return fsResult3;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		return storageType;
	}
}
