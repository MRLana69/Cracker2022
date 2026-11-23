using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsArrayConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0008: Expected I, but got Obj
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+1BC] (should have been resolved before IL gen)");
		bool result = default;
		return result;
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
		//IL_0168: Expected I, but got Obj
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I4
		//IL_013a: Expected native int or pointer, but got VT
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Ref, but got Unknown
		//IL_009e: Expected native int or pointer, but got VT
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected VT, but got Unknown
		//IL_00cb: Expected Ref, but got VT
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I
		object obj = default;
		fsResult fsResult2 = (fsResult)(obj - 48);
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		nint num = (nint)storageType;
		object obj2 = storageType + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v9 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int capacity = default;
		fsData fsData2 = fsData.CreateList(capacity);
		ref fsData reference = ref *(fsData*)fsData2;
		List<fsData> asList = serialized.AsList;
		object obj3 = 0;
		object obj4 = default;
		Type storageType2 = default;
		object instance2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			fsResult fsResult3 = Serializer.TrySerialize(storageType2, instance2, out *(fsData*)(fsResult2 + 36));
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+24]");
				asList.Add((fsData)0);
			}
			object obj5 = obj3 + 1;
			obj3 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsResult)+28]");
		fsResult fsResult5 = default;
		((fsResult*)(nint)fsResult5)->_success = false;
		return fsResult5;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected VT, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected VT, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_006d: Expected native int or pointer, but got VT
		//IL_01ba: Expected I, but got Obj
		//IL_01dc: Expected native int or pointer, but got VT
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Ref, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected VT, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected VT, but got Unknown
		//IL_02e0: Expected Ref, but got VT
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0121: Expected I, but got Obj
		//IL_01a3: Expected I, but got Obj
		//IL_018c: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = fsResult.Success;
		fsResult fsResult2 = CheckType(data, fsDataType.Array);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		fsResult fsResult3 = (fsResult)(obj + 24);
		fsResult fsResult4 = (fsResult)(obj + 16);
		fsResult fsResult5 = fsResult3 + fsResult4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		fsResult fsResult6 = default;
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		else
		{
			nint num = (nint)storageType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v26 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
			List<fsData> asList = data.AsList;
			ArrayList arrayList = default;
			arrayList._002Ector(asList._size);
			nint num2 = (nint)arrayList;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ S1_v31 (Il2CppClass<System.Collections.ArrayList>)+16C] (should have been resolved before IL gen)");
			int num3 = 0;
			object obj3 = default;
			Type storageType2 = default;
			while (num3 < asList._size)
			{
				fsData data2 = asList.get_Item(num3);
				_ = 0;
				bool flag = num3 >= (nint)obj3;
				if (!flag)
				{
					nint num4 = (nint)arrayList;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ S3_v18 (Il2CppClass<System.Collections.ArrayList>)+194] (should have been resolved before IL gen)");
				}
				fsResult fsResult7 = Serializer.TryDeserialize(data2, storageType2, ref *(object*)(obj + 76));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				fsResult fsResult8 = (fsResult)(obj + 88);
				fsResult result = (fsResult)(obj + 8);
				((fsResult*)fsResult8)->AddMessages(result);
				object obj4 = obj - -64;
				if (obj4 != null)
				{
					if (!flag)
					{
						nint num5 = (nint)arrayList;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ S3_v15 (Il2CppClass<System.Collections.ArrayList>)+19C] (should have been resolved before IL gen)");
					}
					else
					{
						nint num6 = (nint)arrayList;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ S2_v21 (Il2CppClass<System.Collections.ArrayList>)+1A4] (should have been resolved before IL gen)");
					}
				}
				int num7 = num3 + 1;
				num3 = num7;
			}
			nint num8 = (nint)arrayList;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ S3_v7 (Il2CppClass<System.Collections.ArrayList>)+234] (should have been resolved before IL gen)");
			object obj5 = default;
			ref object reference = ref *(object*)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
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
