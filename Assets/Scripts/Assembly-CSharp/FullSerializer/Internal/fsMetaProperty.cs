using System;
using System.Reflection;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsMetaProperty
{
	private MemberInfo _memberInfo;

	private Type OverrideConverterType__BackingField;

	private string JsonName__BackingField;

	public Type StorageType
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public Type OverrideConverterType
	{
		get
		{
			return OverrideConverterType__BackingField;
		}
		private set
		{
			OverrideConverterType__BackingField = value;
		}
	}

	public bool CanRead
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public bool CanWrite
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public string JsonName
	{
		get
		{
			return JsonName__BackingField;
		}
		private set
		{
			JsonName__BackingField = value;
		}
	}

	public string MemberName
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public bool IsPublic
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	internal fsMetaProperty(fsConfig config, FieldInfo field)
	{
		//IL_0012: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0050: Expected I, but got Obj
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00af: Expected I4, but got Obj
		_memberInfo = field;
		nint num = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S2_v2 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
		Type type = default;
		StorageType__BackingField = type;
		object obj = field - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v6+BC] (should have been resolved before IL gen)");
		string text = default;
		MemberName__BackingField = text;
		nint num2 = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S2_v9 (Il2CppClass<System.Reflection.FieldInfo>)+13C] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 & 7;
		bool flag = (nint)obj2 == 6;
		IsPublic__BackingField = flag;
		nint num3 = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S1_v11 (Il2CppClass<System.Reflection.FieldInfo>)+13C] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 & 0x20;
		bool flag2 = (byte)(obj4 >> 5) != 0;
		CanRead__BackingField = true;
		IsReadOnly__BackingField = flag2;
		CommonInitialize(config);
	}

	internal fsMetaProperty(fsConfig config, PropertyInfo property)
	{
		//IL_0012: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0050: Expected I, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_01a6: Expected I, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00ed: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		_memberInfo = property;
		nint num = (nint)property;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S2_v2 (Il2CppClass<System.Reflection.PropertyInfo>)+13C] (should have been resolved before IL gen)");
		Type type = default;
		StorageType__BackingField = type;
		object obj = property - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v6+BC] (should have been resolved before IL gen)");
		string text = default;
		MemberName__BackingField = text;
		nint num2 = (nint)property;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v7 (Il2CppClass<System.Reflection.PropertyInfo>)+174] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj2 = default;
		bool flag = obj2 == null;
		bool flag2 = false;
		if (!flag)
		{
			nint num3 = (nint)property;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S3_v16 (Il2CppClass<System.Reflection.PropertyInfo>)+174] (should have been resolved before IL gen)");
			object obj4 = default;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S2_v20+144] (should have been resolved before IL gen)");
			object obj6 = default;
			object obj5 = obj6 & 7;
			bool flag3 = (nint)obj5 != 6;
			flag2 = false;
			if (!flag3)
			{
				nint num4 = (nint)property;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S3_v21 (Il2CppClass<System.Reflection.PropertyInfo>)+184] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
				object obj7 = default;
				bool flag4 = obj7 == null;
				flag2 = false;
				if (!flag4)
				{
					nint num5 = (nint)property;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S2_v27 (Il2CppClass<System.Reflection.PropertyInfo>)+184] (should have been resolved before IL gen)");
					object obj9 = default;
					object obj8 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S1_v29+144] (should have been resolved before IL gen)");
					object obj11 = default;
					object obj10 = obj11 & 7;
					flag2 = (nint)obj10 == 6;
				}
			}
		}
		IsReadOnly__BackingField = false;
		IsPublic__BackingField = flag2;
		nint num6 = (nint)property;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S2_v12 (Il2CppClass<System.Reflection.PropertyInfo>)+154] (should have been resolved before IL gen)");
		bool flag5 = default;
		CanRead__BackingField = flag5;
		nint num7 = (nint)property;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S2_v15 (Il2CppClass<System.Reflection.PropertyInfo>)+15C] (should have been resolved before IL gen)");
		bool flag6 = default;
		CanWrite__BackingField = flag6;
		CommonInitialize(config);
	}

	private void CommonInitialize(fsConfig config)
	{
		//IL_004d: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I4
		fsPropertyAttribute attribute = fsPortableReflection.GetAttribute<fsPropertyAttribute>(_memberInfo);
		if (attribute != null)
		{
			JsonName__BackingField = attribute.Name;
			OverrideConverterType__BackingField = attribute.Converter;
		}
		string text = JsonName__BackingField;
		object obj;
		if (JsonName__BackingField != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00cd;
			}
		}
		obj = 1;
		goto IL_00cd;
		IL_00cd:
		if (obj != null)
		{
			Func<string, MemberInfo, string> getJsonNameFromMemberName = config.GetJsonNameFromMemberName;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S1_v8 (System.Func`3<System.String, System.Reflection.MemberInfo, System.String>)+C] (should have been resolved before IL gen)");
			string text2 = default;
			JsonName__BackingField = text2;
		}
	}

	public void Write(object context, object value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj = default;
		if (obj != null)
		{
			FieldInfo fieldInfo = default;
			fieldInfo.SetValue(context, value);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj2 = default;
		if (obj2 != null)
		{
			object obj4 = default;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S2_v5+184] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			object obj5 = default;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
		}
	}

	public object Read(object context)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			object obj3 = default;
			object obj2 = obj3;
			object obj4 = obj3 + 208;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S3_v5+18C] (should have been resolved before IL gen)");
			object result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		object obj6 = default;
		object obj5 = obj6;
		object obj7 = obj6 + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S2_v2+184] (should have been resolved before IL gen)");
		object result2 = default;
		return result2;
	}
}
