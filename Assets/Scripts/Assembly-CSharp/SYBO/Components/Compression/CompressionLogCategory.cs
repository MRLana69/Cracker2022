using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Compression;

public class CompressionLogCategory : LogCategory
{
	public CompressionLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		Log.Compression = this;
		CategoryText = "Compression";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
