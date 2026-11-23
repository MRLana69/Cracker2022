using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogUIFSMFlow : LogCategory
{
	public LogUIFSMFlow(int categoryId)
	{
		CategoryId = categoryId;
		Log.FSM = this;
		CategoryText = "NPC";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
