using Cpp2ILInjected;

namespace SYBO.Components.Utilities;

public static class StringUtility
{
	public static string[] SplitStringOnNewlines(string source)
	{
		//IL_001f: Expected Obj, but got I
		char firstChar = source.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (System.Char)+C]");
		return (string[])0;
	}
}
