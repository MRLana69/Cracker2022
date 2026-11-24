using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Crypt;

public class CryptLogCategory : LogCategory
{
	public CryptLogCategory(int categoryId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public override string[] GetCallstackPrefixes()
	{
		return null;
	}
}
