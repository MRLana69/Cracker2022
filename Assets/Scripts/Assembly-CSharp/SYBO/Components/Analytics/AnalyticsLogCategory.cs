using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Analytics;

public class AnalyticsLogCategory : LogCategory
{
	public AnalyticsLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		Log.Analytics = this;
		CategoryText = "Analytics";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
