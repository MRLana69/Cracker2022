using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogEveryPlay : LogCategory
{
	public LogEveryPlay(int categoryId)
	{
		CategoryId = categoryId;
		Log.EveryPlay = this;
		CategoryText = "EveryPlay";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
