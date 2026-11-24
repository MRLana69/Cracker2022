using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Json;
using SYBO.Components.Logging;

namespace SYBO.Components.EditorExtensions;

public class EditorExtensionsLogCategory : LogCategory
{
	public EditorExtensionsLogCategory(int categoryId)
	{
		//IL_015f: Expected VT, but got Obj
		//IL_015f: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_00b0: Expected I, but got Obj
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		if (((HashSet<T>)categoryId).Remove((T)this))
		{
			return;
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v5 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v6+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v7+38]");
		object obj3 = (object)((object)0 & 0x1FFF) + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v5 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num3 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v30 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection((Type)(object)this);
		object obj4 = 0;
		while (true)
		{
			JsonFieldInfo[] cachedSerializedFields = nonCachedTypeReflection.CachedSerializedFields;
			if ((nint)obj4 < cachedSerializedFields.Length)
			{
				object obj5 = nonCachedTypeReflection.CachedSerializedFields + 16;
				object obj6 = obj4 << 2;
				object obj7 = obj5 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v26+C]");
				((EditorExtensionsLogCategory)0)._002Ector(categoryId);
				object obj9 = obj4 + 1;
				obj4 = obj9;
				continue;
			}
			break;
		}
	}

	public unsafe override string[] GetCallstackPrefixes()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected I, but got Unknown
		//IL_00bc: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v6 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v17 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(SerializeFileAttribute);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type type = Type.internal_from_handle((IntPtr)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8582");
		object obj2 = default;
		bool flag = obj2 != null;
		return (string[])flag;
	}
}
