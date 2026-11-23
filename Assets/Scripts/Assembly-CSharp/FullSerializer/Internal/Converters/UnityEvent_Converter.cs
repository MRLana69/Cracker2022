using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace FullSerializer.Internal.Converters;

public class UnityEvent_Converter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0076: Expected VT, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_003c: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UnityEvent));
		nint num = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S2_v2 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		object obj = default;
		if (obj != null)
		{
			nint num2 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S1_v6 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
			object obj2 = default;
			return (byte)(obj2 ^ 1) != 0;
		}
		return false;
	}

	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_003b: Expected I4, but got VT
		//IL_0036: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		string json = fsJsonPrinter.CompressedJson(data);
		Type type = default;
		object obj = JsonUtility.FromJson(json, type);
		ref object reference = ref *(object*)obj;
		return fsResult2;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0020: Expected I4, but got VT
		//IL_001b: Expected native int or pointer, but got VT
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		string input = JsonUtility.ToJson(instance);
		fsData fsData2 = fsJsonParser.Parse(input);
		ref fsData reference = ref *(fsData*)fsData2;
		return fsResult2;
	}
}
