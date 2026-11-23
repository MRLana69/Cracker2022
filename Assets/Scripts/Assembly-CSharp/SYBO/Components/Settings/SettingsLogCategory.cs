using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Settings;

public class SettingsLogCategory : LogCategory
{
	public SettingsLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		CategoryText = "Settings";
		Log.Settings = this;
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
