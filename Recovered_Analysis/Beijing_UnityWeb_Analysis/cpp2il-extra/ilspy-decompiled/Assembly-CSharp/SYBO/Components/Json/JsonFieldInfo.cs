using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;

namespace SYBO.Components.Json;

public class JsonFieldInfo
{
	public FieldInfo Field;

	public Type ValueType;

	public bool SerializeByKey;

	public bool EnumAsString;

	public string SerializedName;

	public int SizeLimit;

	public bool FailOnSizeLimit;

	public string SerializedFileName;

	public unsafe object GetValue(object obj)
	{
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		if (((Dictionary<string, object>)this).TryGetValue((string)obj, out *(object*)null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				object result = default;
				return result;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonObjectStore jsonObjectStore = default;
		jsonObjectStore._002Ector();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S4_v4+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S4_v5+48]");
		object obj5 = 0;
		object obj6 = obj5 & 0x7FF;
		object obj7 = obj6 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61 @ S5_v5 (should have been resolved before IL gen)");
		return jsonObjectStore;
	}

	public void SetValue(object obj, object value)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S4_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v4+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S5_v4 (should have been resolved before IL gen)");
	}

	public object ReadValue(JsonDict json)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object result = default;
		return result;
	}

	public unsafe object GetKey(object obj)
	{
		ref object reference = ref *(object*)null;
		bool flag = ((Dictionary<string, object>)obj).TryGetValue(SerializedName, out reference);
		return reference;
	}

	public void WriteValue(object value, JsonDict json)
	{
		//IL_0013: Expected VT, but got Obj
		Field.SetValueDirect((TypedReference)value, json);
	}

	public string ToLimitedString(object value)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection(ValueType);
		return (string)nonCachedTypeReflection.Construct((JsonContext)value);
	}

	public JsonFieldInfo()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S4_v4 (should have been resolved before IL gen)");
	}
}
