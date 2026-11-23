using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogSystemLogCategory : LogCategory
{
	public LogSystemLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		CategoryText = "Log";
		Log.LogSystem = this;
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
