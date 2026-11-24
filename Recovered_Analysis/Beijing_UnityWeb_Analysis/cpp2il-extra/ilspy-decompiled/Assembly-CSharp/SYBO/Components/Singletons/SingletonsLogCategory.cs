using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Singletons;

public class SingletonsLogCategory : LogCategory
{
	public SingletonsLogCategory(int categoryId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Exception)(object)this).SetErrorCode(categoryId);
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string[] result = default;
		return result;
	}
}
