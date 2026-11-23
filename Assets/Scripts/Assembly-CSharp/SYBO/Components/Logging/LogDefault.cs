using Cpp2ILInjected;

namespace SYBO.Components.Logging;

public class LogDefault : LogCategory
{
	public LogDefault(int categoryId)
	{
		CategoryId = categoryId;
		Log.Default = this;
		CategoryText = "Default";
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string[] result = default;
		return result;
	}
}
