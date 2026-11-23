using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogGameStateMachine : LogCategory
{
	public LogGameStateMachine(int categoryId)
	{
		CategoryId = categoryId;
		Log.StateMachine = this;
		CategoryText = "StateMachine";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
