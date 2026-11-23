using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Json;

public class JsonLogCategory : LogCategory
{
	public JsonLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		CategoryText = "Json";
		Log.Json = this;
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
