using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Json;

public class JsonReferenceException : Exception
{
	public JsonReferenceException(string message)
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		base._className = message;
		object obj2 = this + 12;
		obj2 = "Json";
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num4 = (nint)typeof(Log);
		if (!flag)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Log);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Log);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
		object obj4 = (nint)0 + (nint)24;
		obj4 = this;
	}
}
