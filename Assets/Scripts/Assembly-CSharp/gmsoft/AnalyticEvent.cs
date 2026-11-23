using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace gmsoft;

public class AnalyticEvent
{
	public string name;

	public bool hasParams;

	public Dictionary<string, string> @params;

	public AnalyticEvent()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> dictionary = default;
		@params = dictionary;
	}
}
