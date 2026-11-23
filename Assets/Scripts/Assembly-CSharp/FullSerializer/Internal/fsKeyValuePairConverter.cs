using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsKeyValuePairConverter : fsConverter
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
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(KeyValuePair<, >));
			object obj4 = default;
			return typeFromHandle == obj4;
		}
		return false;
	}

	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Ref, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected VT, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected VT, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Ref, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected VT, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected VT, but got Unknown
		//IL_006d: Expected native int or pointer, but got VT
		//IL_016e: Expected I, but got Obj
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Ref, but got Unknown
		//IL_01b9: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected VT, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected VT, but got Unknown
		//IL_0205: Expected Ref, but got VT
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Ref, but got Unknown
		//IL_023a: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_015c: Expected native int or pointer, but got VT
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected VT, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected VT, but got Unknown
		//IL_0279: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = fsResult.Success;
		fsResult fsResult2 = CheckKey(data, "Key", out *(fsData*)(obj + 132));
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		fsResult fsResult3 = (fsResult)(obj + 48);
		fsResult fsResult4 = (fsResult)(obj + 40);
		fsResult fsResult5 = fsResult3 + fsResult4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		fsResult fsResult6 = default;
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		else
		{
			fsResult fsResult7 = CheckKey(data, "Value", out *(fsData*)(obj + 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			fsResult fsResult8 = (fsResult)(obj + 32);
			fsResult fsResult9 = (fsResult)(obj + 24);
			fsResult fsResult10 = fsResult8 + fsResult9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			if ((nint)0 != 0)
			{
				nint num = (nint)storageType;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S1_v40 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
				_ = 0;
				_ = 0;
				ref object result = ref *(object*)(obj + 124);
				fsSerializer serializer = Serializer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v49+10]");
				fsResult fsResult11 = serializer.TryDeserialize((fsData)num2, (Type)0, ref result);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				fsResult fsResult12 = (fsResult)(obj + 136);
				fsResult result2 = (fsResult)(obj + 16);
				((fsResult*)fsResult12)->AddMessages(result2);
				ref object result3 = ref *(object*)(obj + 120);
				fsSerializer serializer2 = Serializer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v49+14]");
				fsResult fsResult13 = serializer2.TryDeserialize((fsData)num3, (Type)0, ref result3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				fsResult fsResult14 = (fsResult)(obj + 136);
				fsResult result4 = (fsResult)(obj + 8);
				((fsResult*)fsResult14)->AddMessages(result4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		return fsResult6;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_002d: Expected I, but got Obj
		//IL_003f: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Ref, but got Unknown
		//IL_007c: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected VT, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected VT, but got Unknown
		//IL_00bb: Expected Ref, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Ref, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_0101: Expected native int or pointer, but got VT
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected VT, but got Unknown
		//IL_0121: Expected Ref, but got VT
		//IL_0149: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_0257: Expected native int or pointer, but got VT
		//IL_0195: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 48);
		_ = 0;
		_ = 0;
		_ = 0;
		PropertyInfo declaredProperty = fsPortableReflection.GetDeclaredProperty(storageType, "Key");
		PropertyInfo declaredProperty2 = fsPortableReflection.GetDeclaredProperty(storageType, "Value");
		nint num = (nint)declaredProperty;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S3_v2 (Il2CppClass<System.Reflection.PropertyInfo>)+18C] (should have been resolved before IL gen)");
		nint num2 = (nint)declaredProperty2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S3_v5 (Il2CppClass<System.Reflection.PropertyInfo>)+18C] (should have been resolved before IL gen)");
		nint num3 = (nint)storageType;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S1_v13 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
		_ = fsResult.Success;
		ref fsData data = ref *(fsData*)(fsResult2 + 36);
		fsSerializer serializer = Serializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21+10]");
		object instance2 = default;
		fsResult fsResult3 = serializer.TrySerialize((Type)0, instance2, out data);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+18]");
		_ = 0;
		fsResult fsResult4 = fsResult2 + 40;
		fsResult result = fsResult2 + 8;
		((fsResult*)fsResult4)->AddMessages(result);
		ref fsData data2 = ref *(fsData*)(fsResult2 + 32);
		fsSerializer serializer2 = Serializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21+14]");
		object instance3 = default;
		fsResult fsResult5 = serializer2.TrySerialize((Type)0, instance3, out data2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+10]");
		((fsResult*)(nint)fsResult2)->_success = false;
		fsResult fsResult6 = fsResult2 + 40;
		((fsResult*)fsResult6)->AddMessages(fsResult2);
		fsData fsData2 = fsData.CreateDictionary();
		ref fsData reference = ref *(fsData*)fsData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+24]");
		if ((fsData)0 != null)
		{
			Dictionary<string, fsData> asDictionary = serialized.AsDictionary;
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S5_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ S5_v15+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+20]");
		if ((fsData)0 != null)
		{
			Dictionary<string, fsData> asDictionary2 = serialized.AsDictionary;
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+28]");
		fsResult fsResult7 = default;
		((fsResult*)(nint)fsResult7)->_success = false;
		return fsResult7;
	}
}
