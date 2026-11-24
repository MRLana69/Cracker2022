using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Native;

public class NativeLogCategory : LogCategory
{
	public NativeLogCategory(int categoryId)
	{
	}

	public override string[] GetCallstackPrefixes()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		string[] array = default;
		object obj = array + 16;
		obj = this;
		return array;
	}
}
