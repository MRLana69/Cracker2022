using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Utilities;

public class PoolManagerLogCategory : LogCategory
{
	public PoolManagerLogCategory(int categoryId)
	{
		CategoryId = categoryId;
		Log.PoolManager = this;
		CategoryText = "Pool";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string[] result = default;
		return result;
	}
}
