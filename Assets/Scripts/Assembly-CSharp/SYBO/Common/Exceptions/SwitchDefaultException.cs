using System;
using Cpp2ILInjected;

namespace SYBO.Common.Exceptions;

public class SwitchDefaultException : Exception
{
	public SwitchDefaultException(string missingSwitchValue)
		: base("SwitchDefaultException: Add case for '" + missingSwitchValue + "'.")
	{
	}

	public static void Throw(string missingSwitchValue)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		SwitchDefaultException ex = default;
		ex._002Ector(missingSwitchValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}
}
