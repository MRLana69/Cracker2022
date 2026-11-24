using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Json;

public class JsonLogCategory : LogCategory
{
	public JsonLogCategory(int categoryId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(List<object>);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(List<object>);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((List<object>)(object)this)._002Ector(categoryId);
	}

	public override string[] GetCallstackPrefixes()
	{
		bool typeHasKey = ((JsonClassInfo)(object)this).TypeHasKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		string[] result = default;
		return result;
	}
}
