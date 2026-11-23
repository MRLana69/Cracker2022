using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogGameState : LogCategory
{
	public LogGameState(int categoryId)
	{
		CategoryId = categoryId;
		Log.GameState = this;
		CategoryText = "GameState";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
