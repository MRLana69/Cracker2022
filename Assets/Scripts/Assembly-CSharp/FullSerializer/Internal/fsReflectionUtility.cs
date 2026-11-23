using System;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public static class fsReflectionUtility
{
	public static Type GetInterface(Type type, Type interfaceType)
	{
		//IL_019d: Expected I, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		nint num = (nint)interfaceType;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v3 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
		object obj = default;
		Type type2 = default;
		if (obj != null)
		{
			nint num2 = (nint)interfaceType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S1_v30 (Il2CppClass<System.Type>)+204] (should have been resolved before IL gen)");
			object obj2 = default;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ArgumentException ex = default;
				ex._002Ector("GetInterface requires that if the interface type is generic, then it must be the generic type definition, not a specific generic type instantiation");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				type2 = (Type)(object)ex;
			}
		}
		Type result;
		object obj7 = default;
		object obj8 = default;
		IntPtr intPtr = default;
		Type type4 = default;
		while (true)
		{
			bool flag = (object)type2 == null;
			result = null;
			if (flag)
			{
				break;
			}
			object obj3 = type2 + 928;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S1_v9+BC] (should have been resolved before IL gen)");
			object obj4 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v19+C]");
				if (0 <= (nint)obj4)
				{
					break;
				}
				object obj5 = obj4 << 2;
				object obj6 = obj7 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v30+10]");
				Type type3 = (Type)0;
				nint num3 = (nint)type3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S1_v20 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
				if (obj8 != null)
				{
					nint num4 = (nint)type3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S1_v26 (Il2CppClass<System.Type>)+23C] (should have been resolved before IL gen)");
					if ((nint)interfaceType == (nint)intPtr)
					{
						result = type3;
						goto end_IL_01f3;
					}
				}
				else
				{
					bool flag2 = (object)interfaceType == type3;
					result = type3;
					if (flag2)
					{
						goto end_IL_01f3;
					}
				}
				object obj9 = obj4 + 1;
				obj4 = obj9;
			}
			object obj10 = type2 + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ S1_v15+BC] (should have been resolved before IL gen)");
			type2 = type4;
			continue;
			end_IL_01f3:
			break;
		}
		return result;
	}
}
