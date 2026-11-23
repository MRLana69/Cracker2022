using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogLevenGeneration : LogCategory
{
	public LogLevenGeneration(int categoryId)
	{
		CategoryId = categoryId;
		Log.LevelGen = this;
		CategoryText = "LevelGen";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
