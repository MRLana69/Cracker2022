using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.BuildSizeMonitor;

public class BuildSizeMonitorLogCategory : LogCategory
{
	public BuildSizeMonitorLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		Log.BuildSizeMonitor = this;
		CategoryText = "BuildSizeMonitor";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
