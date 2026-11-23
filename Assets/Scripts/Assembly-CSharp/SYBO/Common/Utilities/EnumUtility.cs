using System;
using Cpp2ILInjected;

namespace SYBO.Common.Utilities;

public class EnumUtility
{
	public static int[] ConvertEnumToIntArray<T>()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0136: Expected VT, but got I
		//IL_0051: Expected Obj, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00b4: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+C]");
		int[] array = default;
		if (0 > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj6 = default;
			object obj5 = obj6 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v14+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj7 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num2 = 0;
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)num2);
			object obj9 = default;
			object obj8 = obj9 << 2;
			object obj10 = (object)array + obj8;
			object value = default;
			object obj11 = Convert.ChangeType(value, typeFromHandle2);
			throw new NullReferenceException();
		}
		return array;
	}

	public static T ConvertIntToEnumValue<T>(int i)
	{
		//IL_0043: Expected VT, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		object obj = Enum.ToObject(typeFromHandle, i);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		T result = default;
		return result;
	}

	public static T ConvertIntToFlagEnumValue<T>(int i)
	{
		//IL_0062: Expected VT, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0053: Expected VT, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		int num2 = i << 2;
		object obj2 = default;
		object obj = obj2 + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+10]");
		return (T)0;
	}

	public static T ConvertIndexToEnumValue<T>(int index)
	{
		//IL_0062: Expected VT, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0053: Expected VT, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		int num2 = index << 2;
		object obj2 = default;
		object obj = obj2 + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+10]");
		return (T)0;
	}

	public static int ConvertEnumValueToIndex<T>(T enumValue)
	{
		//IL_0153: Expected VT, but got I
		//IL_0034: Expected Obj, but got I4
		//IL_0101: Invalid comparison between VT and I4
		//IL_006d: Expected Obj, but got I
		//IL_011d: Expected I, but got VT
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		object obj = 0;
		int num2 = 0;
		object obj5 = default;
		object obj8 = default;
		string text = default;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+C]");
			if ((nint)obj2 < 0)
			{
				object obj3 = obj << 2;
				object obj4 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30+10]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S2_v14+BC] (should have been resolved before IL gen)");
				if (obj8 == null)
				{
					int num3 = num2 + 1;
					object obj9 = obj + 1;
					obj = obj9;
					num2 = num3;
					continue;
				}
				if (num2 != -1)
				{
					break;
				}
			}
			if (enumValue != (T)(object)0)
			{
				nint num4 = (nint)enumValue;
				object obj10 = enumValue + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S2_v9 (Il2CppClass<T>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string text2 = "Did not find enumvalue: " + text + " in Enum";
			num2 = -1;
			break;
		}
		return num2;
	}
}
