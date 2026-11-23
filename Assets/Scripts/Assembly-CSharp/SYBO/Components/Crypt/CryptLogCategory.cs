using System;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Crypt;

public class CryptLogCategory : LogCategory
{
	public CryptLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		Log.Crypt = this;
		CategoryText = "Crypt";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
