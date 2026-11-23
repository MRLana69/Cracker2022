using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsReflectedConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0050: Expected I, but got Obj
		//IL_0014: Expected VT, but got Obj
		//IL_0025: Expected I, but got Obj
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v3 (Il2CppClass<System.Type>)+1BC] (should have been resolved before IL gen)");
		object obj = default;
		if (obj == null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ICollection));
			nint num2 = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v4 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
			object obj2 = default;
			return (byte)(obj2 ^ 1) != 0;
		}
		return false;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_01dd: Expected native int or pointer, but got VT
		//IL_0094: Expected Obj, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Ref, but got Unknown
		//IL_011a: Expected native int or pointer, but got VT
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected VT, but got Unknown
		//IL_0147: Expected Ref, but got VT
		//IL_0196: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 48);
		_ = 0;
		_ = 0;
		_ = 0;
		fsData fsData2 = fsData.CreateDictionary();
		ref fsData reference = ref *(fsData*)fsData2;
		_ = fsResult.Success;
		fsSerializer serializer = Serializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type type = default;
		fsMetaType fsMetaType2 = fsMetaType.Get(serializer.Config, type);
		fsMetaType2.EmitAotData(throwException: false);
		object obj2 = 0;
		while (true)
		{
			fsMetaProperty[] array = fsMetaType2.Properties__BackingField;
			if (array.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)array + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v35+10]");
			fsMetaProperty fsMetaProperty2 = (fsMetaProperty)0;
			if (~(fsMetaProperty2.CanRead__BackingField ? 1u : 0u) == 0)
			{
				object instance2 = fsMetaProperty2.Read(instance);
				fsResult fsResult3 = Serializer.TrySerialize(fsMetaProperty2.StorageType__BackingField, fsMetaProperty2.OverrideConverterType__BackingField, instance2, out *(fsData*)(fsResult2 + 36));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+10]");
				((fsResult*)(nint)fsResult2)->_success = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+10]");
				_ = 0;
				fsResult fsResult4 = fsResult2 + 40;
				((fsResult*)fsResult4)->AddMessages(fsResult2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+18]");
				if ((nint)0 != 0)
				{
					Dictionary<string, fsData> asDictionary = serialized.AsDictionary;
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S4_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
					instance2 = 0;
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S5_v9+4]");
					ref fsData reference2 = ref *(fsData*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ S5_v9+4] (should have been resolved before IL gen)");
				}
			}
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+28]");
		fsResult fsResult5 = default;
		((fsResult*)(nint)fsResult5)->_success = false;
		return fsResult5;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I, but got Unknown
		//IL_0272: Expected VT, but got I
		//IL_0280: Expected VT, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_006d: Expected native int or pointer, but got VT
		//IL_020a: Expected native int or pointer, but got VT
		//IL_00e5: Expected Obj, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_02d6: Expected Obj, but got I
		//IL_030f: Expected VT, but got I
		//IL_031d: Expected VT, but got I
		//IL_032a: Expected Ref, but got VT
		//IL_01a1: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I
		object obj = default;
		nint num = (nint)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = fsResult.Success;
		fsResult fsResult2 = CheckType(data, fsDataType.Object);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+28]");
		_ = 0;
		fsResult fsResult3 = (fsResult)(num + 24);
		fsResult fsResult4 = (fsResult)(num + 16);
		fsResult fsResult5 = fsResult3 + fsResult4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+50]");
		fsResult fsResult6 = default;
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+38]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		else
		{
			fsSerializer serializer = Serializer;
			fsMetaType fsMetaType2 = fsMetaType.Get(serializer.Config, storageType);
			fsMetaType2.EmitAotData(throwException: false);
			object obj2 = 0;
			while (true)
			{
				fsMetaProperty[] array = fsMetaType2.Properties__BackingField;
				if (array.Length <= (nint)obj2)
				{
					break;
				}
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v45+10]");
				fsMetaProperty fsMetaProperty2 = (fsMetaProperty)0;
				if (~(fsMetaProperty2.CanWrite__BackingField ? 1u : 0u) == 0)
				{
					Dictionary<string, fsData> asDictionary = data.AsDictionary;
					if (asDictionary.TryGetValue(fsMetaProperty2.JsonName__BackingField, out *(fsData*)(num + 76)))
					{
						_ = 0;
						if (~(fsMetaProperty2.CanRead__BackingField ? 1u : 0u) == 0)
						{
							object obj5 = fsMetaProperty2.Read(instance);
						}
						ref object result = ref *(object*)(num + 72);
						fsSerializer serializer2 = Serializer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+4C]");
						fsResult5 = serializer2.TryDeserialize((fsData)0, fsMetaProperty2.StorageType__BackingField, fsMetaProperty2.OverrideConverterType__BackingField, ref result);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+38]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+38]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+38]");
						_ = 0;
						fsResult fsResult7 = (fsResult)(num + 88);
						fsResult result2 = (fsResult)(num + 8);
						((fsResult*)fsResult7)->AddMessages(result2);
						object obj6 = num - -64;
						if (obj6 != null)
						{
							object context = instance;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+48]");
							fsMetaProperty2.Write(context, 0);
						}
					}
				}
				object obj7 = obj2 + 1;
				obj2 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Il2CppMethodInfo)+58]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		return fsResult6;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		fsSerializer serializer = Serializer;
		fsMetaType fsMetaType2 = fsMetaType.Get(serializer.Config, storageType);
		return fsMetaType2.CreateInstance();
	}
}
