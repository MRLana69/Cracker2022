using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Utilities;

public class UtilitiesCategory : LogCategory
{
	public UtilitiesCategory(int categoryId)
	{
		CategoryId = categoryId;
		CategoryText = "Utilities";
		Log.Utilities = this;
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
