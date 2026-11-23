using System;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsForwardConverter(fsForwardAttribute attribute) : fsConverter
{
	private string _memberName = attribute.MemberName;

	public override bool CanProcess(Type type)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotSupportedException ex = default;
		ex._002Ector("Please use the [fsForward(...)] attribute.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	private unsafe fsResult GetProperty(object instance, out fsMetaProperty property)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0108: Expected native int or pointer, but got VT
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00c6: Expected I4, but got VT
		//IL_00c1: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsSerializer serializer = Serializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type type = default;
		fsMetaType fsMetaType2 = fsMetaType.Get(serializer.Config, type);
		fsMetaProperty[] array = fsMetaType2.Properties__BackingField;
		object obj3 = 0;
		fsResult fsResult2 = default;
		Type type2 = default;
		while (true)
		{
			ref fsMetaProperty reference;
			if (array.Length > (nint)obj3)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)array + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v40+10]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v41+1C]");
				if ((string)0 == _memberName)
				{
					object obj7 = obj3 << 2;
					object obj8 = (object)array + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v21+10]");
					reference = ref *(fsMetaProperty*)null;
					((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
					break;
				}
				object obj9 = obj3 + 1;
				obj3 = obj9;
				continue;
			}
			reference = ref *(fsMetaProperty*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			string text = fsTypeExtensions.CSharpName(type2);
			string warning = "No property named \"" + _memberName + "\" on " + text;
			fsResult fsResult3 = fsResult.Fail(warning);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult2)->_success = false;
			break;
		}
		return fsResult2;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_00c5: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0111: Expected native int or pointer, but got VT
		//IL_00a6: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		ref fsData reference = ref *(fsData*)fsData.Null;
		fsResult property = GetProperty(instance, out *(fsMetaProperty*)(obj + 60));
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 16);
		fsResult fsResult3 = (fsResult)(obj + 8);
		fsResult fsResult4 = fsResult2 + fsResult3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		fsResult fsResult5 = default;
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			((fsResult*)(nint)fsResult5)->_success = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			object instance2 = ((fsMetaProperty)0).Read(instance);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			object obj3 = 0;
			fsSerializer serializer = Serializer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S2_v8+C]");
			fsResult fsResult6 = serializer.TrySerialize((Type)0, instance2, out serialized);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			((fsResult*)(nint)fsResult5)->_success = false;
		}
		return fsResult5;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Ref, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected VT, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected VT, but got Unknown
		//IL_0183: Expected native int or pointer, but got VT
		//IL_006b: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Ref, but got Unknown
		//IL_0098: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected VT, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected VT, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		fsResult property = GetProperty(instance, out *(fsMetaProperty*)(obj + 92));
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		fsResult fsResult2 = (fsResult)(obj + 32);
		fsResult fsResult3 = (fsResult)(obj + 24);
		fsResult fsResult4 = fsResult2 + fsResult3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		bool flag = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		bool success = false;
		if (!flag)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5C]");
			object obj3 = 0;
			ref object result = ref *(object*)(obj + 88);
			fsSerializer serializer = Serializer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S3_v7+C]");
			fsResult fsResult5 = serializer.TryDeserialize(data, (Type)0, ref result);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			fsResult fsResult6 = (fsResult)(obj + 16);
			fsResult fsResult7 = (fsResult)(obj + 8);
			fsResult fsResult8 = fsResult6 + fsResult7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			bool flag2 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			success = false;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+5C]");
				nint num = 0;
				object context = instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				((fsMetaProperty)num).Write(context, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				success = false;
			}
		}
		fsResult fsResult9 = default;
		((fsResult*)(nint)fsResult9)->_success = success;
		return fsResult9;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		fsSerializer serializer = Serializer;
		fsMetaType fsMetaType2 = fsMetaType.Get(serializer.Config, storageType);
		return fsMetaType2.CreateInstance();
	}
}
