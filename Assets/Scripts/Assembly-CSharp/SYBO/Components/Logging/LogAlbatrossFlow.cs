using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogAlbatrossFlow : LogCategory
{
	public LogAlbatrossFlow(int categoryId)
	{
		CategoryId = categoryId;
		Log.Flow = this;
		CategoryText = "Flow";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
