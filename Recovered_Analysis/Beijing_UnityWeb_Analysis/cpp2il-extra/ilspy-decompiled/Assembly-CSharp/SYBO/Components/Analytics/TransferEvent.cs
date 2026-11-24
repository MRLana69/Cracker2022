using System;
using System.Threading;
using Cpp2ILInjected;
using SYBO.Components.Json;
using SYBO.Components.Json.Internal;

namespace SYBO.Components.Analytics;

public class TransferEvent<T> where T : AnalyticsEvent
{
	private string name;

	private T eventData;

	public unsafe TransferEvent(T eventData, string name)
	{
		//IL_0035: Expected Obj, but got I
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected I, but got Unknown
		//IL_0116: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		bool flag = name == null;
		bool flag2 = !flag;
		JsonCustomSerializer context = (JsonCustomSerializer)(object)name;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer = default;
			jsonCustomSerializer._002Ector();
			context = jsonCustomSerializer;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v25 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj;
		nint num3 = (nint)(obj3 + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type fields = Type.internal_from_handle((IntPtr)num3);
		JsonReflectionParser.DeserializeFieldsOnto((JsonFieldInfo[])(object)fields, (object)this, (JsonDict)(object)eventData, (JsonContext)(object)context);
	}

	public T GetEventData()
	{
		//IL_006e: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		int domainID = Thread.GetDomainID();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.TransferEvent`1<T>)+14]");
		if ((nint)0 == domainID)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v10+1C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S2_v10 (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
		nint num = default;
		object obj6 = num + 12;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v10+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v2+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v3+10]");
		object obj11 = 0;
		object obj12 = obj11 & 0x3FFF;
		object obj13 = obj12 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S3_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}
}
