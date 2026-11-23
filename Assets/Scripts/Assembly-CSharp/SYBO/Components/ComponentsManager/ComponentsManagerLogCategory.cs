using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.ComponentsManager;

public class ComponentsManagerLogCategory : LogCategory
{
	public ComponentsManagerLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		Log.ComponentsManager = this;
		CategoryText = "ComponentsManager";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
