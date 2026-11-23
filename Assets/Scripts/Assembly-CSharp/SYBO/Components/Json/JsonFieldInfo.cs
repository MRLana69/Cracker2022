using System;
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

	public object GetValue(object obj)
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		FieldInfo field = Field;
		nint num = (nint)field;
		object obj2 = field + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S2_v2 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
		object result = default;
		return result;
	}

	public unsafe object ReadValue(JsonDict json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		//IL_004b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = json.TryGetValue(SerializedName, out *(object*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return 0;
	}

	public object GetKey(object obj)
	{
		JsonClassInfo jsonTypeReflection = JsonClassInfo.GetJsonTypeReflection(ValueType);
		return jsonTypeReflection.GetKey(obj);
	}

	public void WriteValue(object value, JsonDict json)
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public string ToLimitedString(object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0227: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		nint num = (nint)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v4 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
		bool flag = SizeLimit < 0;
		string text = default;
		string result = text;
		if (!flag)
		{
			bool flag2 = text == null;
			result = text;
			if (!flag2)
			{
				bool flag3 = text._stringLength <= SizeLimit;
				result = text;
				if (!flag3)
				{
					if (!FailOnSizeLimit)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						_ = SizeLimit;
						object obj3 = obj + 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					throw new ArrayTypeMismatchException();
				}
			}
		}
		return result;
	}
}
