using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer;

public abstract class fsBaseConverter
{
	public fsSerializer Serializer;

	public virtual object CreateInstance(fsData data, Type storageType)
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<FullSerializer.fsBaseConverter>)+E4] (should have been resolved before IL gen)");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		return storageType;
	}

	public virtual bool RequestCycleSupport(Type storageType)
	{
		//IL_005c: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
		bool flag = (object)typeFromHandle == storageType;
		bool result = false;
		if (!flag)
		{
			bool isClass = storageType.IsClass;
			result = true;
			if (!isClass)
			{
				bool isInterface = storageType.IsInterface;
				result = isInterface;
			}
		}
		return result;
	}

	public virtual bool RequestInheritanceSupport(Type storageType)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		nint num = (nint)storageType;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<System.Type>)+274] (should have been resolved before IL gen)");
		object obj2 = default;
		object obj = obj2 & 0x100;
		object obj3 = obj >> 8;
		return obj3 == null;
	}

	public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

	public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

	protected fsResult FailExpectedType(fsData data, fsDataType[] types)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		object obj4 = default;
		object obj3 = obj4 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v3+BC] (should have been resolved before IL gen)");
		throw new ArrayTypeMismatchException();
	}

	protected unsafe fsResult CheckType(fsData data, fsDataType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f4: Expected I4, but got VT
		//IL_01ef: Expected native int or pointer, but got VT
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		fsDataType type2 = data.Type;
		if (type2 != type)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj4 = default;
			object obj3 = obj4 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S2_v4+BC] (should have been resolved before IL gen)");
			throw new ArrayTypeMismatchException();
		}
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		return fsResult2;
	}

	protected unsafe fsResult CheckKey(fsData data, string key, out fsData subitem)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0046: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Dictionary<string, fsData> asDictionary = data.AsDictionary;
		fsResult fsResult2 = CheckKey(asDictionary, key, out subitem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = false;
		return fsResult3;
	}

	protected unsafe fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_012a: Expected I4, but got VT
		//IL_0125: Expected native int or pointer, but got VT
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (!data.TryGetValue(key, out subitem))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj4 = default;
			object obj3 = obj4 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v5+BC] (should have been resolved before IL gen)");
			throw new ArrayTypeMismatchException();
		}
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		return fsResult2;
	}

	protected unsafe fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c8: Expected VT, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Ref, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_00ed: Expected I4, but got Obj
		//IL_00e8: Expected native int or pointer, but got VT
		//IL_00a4: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		object obj3 = obj + 11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object instance = default;
		fsResult fsResult2 = Serializer.TrySerialize(typeFromHandle, overrideConverterType, instance, out *(fsData*)(obj + 12));
		object obj4 = obj & 0xFF;
		if (obj4 != null)
		{
			nint num2 = 0;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		fsResult fsResult3 = default;
		((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
		return fsResult3;
	}

	protected unsafe fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Ref, but got Unknown
		//IL_0072: Expected VT, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Ref, but got Unknown
		//IL_00ac: Expected Obj, but got I
		//IL_00bd: Expected I4, but got Obj
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_0058: Expected I4, but got Obj
		//IL_0053: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		fsResult fsResult3 = default;
		if (!data.TryGetValue(name, out *(fsData*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			string warning = "Unable to find member \"" + name + "\"";
			fsResult fsResult2 = fsResult.Fail(warning);
			((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
			return fsResult3;
		}
		_ = 0;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		ref object result = ref *(object*)(obj + 8);
		fsSerializer serializer = Serializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		fsResult fsResult4 = serializer.TryDeserialize((fsData)0, typeFromHandle, overrideConverterType, ref result);
		((fsResult*)(nint)fsResult3)->_success = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		throw new NullReferenceException();
	}
}
