using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsWeakReferenceConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0014: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(WeakReference));
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
		//IL_000e: Expected Obj, but got Unknown
		//IL_0201: Expected I4, but got VT
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Ref, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected VT, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected VT, but got Unknown
		//IL_011f: Expected VT, but got I
		//IL_0157: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I
		//IL_01d4: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		fsData fsData2 = fsData.CreateDictionary();
		ref fsData reference = ref *(fsData*)fsData2;
		object obj4 = default;
		object obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S1_v10+E4] (should have been resolved before IL gen)");
		object obj5 = default;
		bool flag = obj5 == null;
		fsResult fsResult2 = fsResult.Success;
		if (!flag)
		{
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S3_v3+EC] (should have been resolved before IL gen)");
			_0021_00210 instance2 = default;
			fsResult fsResult3 = Serializer.TrySerialize<T>((T)instance2, out *(fsData*)(obj + 60));
			_ = fsResult.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			_ = fsResult.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			fsResult fsResult4 = (fsResult)(obj + 16);
			fsResult fsResult5 = (fsResult)(obj + 8);
			fsResult fsResult6 = fsResult4 + fsResult5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			bool flag2 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			fsResult2 = (fsResult)0;
			if (!flag2)
			{
				Dictionary<string, fsData> asDictionary = serialized.AsDictionary;
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S5_v5+4] (should have been resolved before IL gen)");
				Dictionary<string, fsData> asDictionary2 = serialized.AsDictionary;
				object obj8 = obj4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v167 @ S1_v33+BC] (should have been resolved before IL gen)");
				fsData fsData3 = default;
				bool boolean = default;
				fsData3._002Ector(boolean);
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+5C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ S5_v10+4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				fsResult2 = (fsResult)0;
			}
		}
		fsResult fsResult7 = default;
		((fsResult*)(nint)fsResult7)->_success = (byte)(int)fsResult2 != 0;
		return fsResult7;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected VT, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected VT, but got Unknown
		//IL_038f: Expected native int or pointer, but got VT
		//IL_007e: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_010a: Expected VT, but got Obj
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Ref, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected VT, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected VT, but got Unknown
		//IL_020d: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_02fb: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		fsResult fsResult2 = CheckType(data, fsDataType.Object);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		fsResult fsResult3 = (fsResult)(obj + 32);
		fsResult fsResult4 = (fsResult)(obj + 24);
		fsResult fsResult5 = fsResult3 + fsResult4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		bool flag = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		bool success = false;
		if (!flag)
		{
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S3_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S3_v8+4] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 ^ -1;
			object obj6 = obj4 >> 31;
			bool flag2 = obj6 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			success = false;
			if (!flag2)
			{
				Dictionary<string, fsData> asDictionary2 = data.AsDictionary;
				fsData data2 = asDictionary2.get_Item("Target");
				_ = 0;
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(object));
				fsResult fsResult6 = Serializer.TryDeserialize(data2, typeFromHandle, ref *(object*)(obj + 84));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				fsResult fsResult7 = (fsResult)(obj + 16);
				fsResult fsResult8 = (fsResult)(obj + 8);
				fsResult fsResult9 = fsResult7 + fsResult8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				bool flag3 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				success = false;
				if (!flag3)
				{
					Dictionary<string, fsData> asDictionary3 = data.AsDictionary;
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S4_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, FullSerializer.fsData>>)+54]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ S4_v9+4] (should have been resolved before IL gen)");
					object obj9 = default;
					object obj8 = obj9 ^ -1;
					object obj10 = obj8 >> 31;
					bool flag4 = obj10 == null;
					bool trackResurrection = false;
					if (!flag4)
					{
						Dictionary<string, fsData> asDictionary4 = data.AsDictionary;
						fsData fsData2 = asDictionary4.get_Item("TrackResurrection");
						bool isBool = fsData2.IsBool;
						bool flag5 = !isBool;
						trackResurrection = false;
						if (!flag5)
						{
							Dictionary<string, fsData> asDictionary5 = data.AsDictionary;
							fsData fsData3 = asDictionary5.get_Item("TrackResurrection");
							trackResurrection = fsData3.AsBool;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
					WeakReference weakReference = default;
					weakReference._002Ector(0, trackResurrection);
					ref object reference = ref *(object*)weakReference;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
					success = false;
				}
			}
		}
		fsResult fsResult10 = default;
		((fsResult*)(nint)fsResult10)->_success = success;
		return fsResult10;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		WeakReference weakReference = default;
		weakReference._002Ector(null);
		return weakReference;
	}
}
