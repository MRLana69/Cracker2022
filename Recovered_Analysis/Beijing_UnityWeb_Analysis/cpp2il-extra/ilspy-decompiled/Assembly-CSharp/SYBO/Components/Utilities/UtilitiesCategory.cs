using SYBO.Components.Logging;

namespace SYBO.Components.Utilities;

public class UtilitiesCategory : LogCategory
{
	public UtilitiesCategory(int categoryId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 8;
		obj = categoryId;
	}

	public override string[] GetCallstackPrefixes()
	{
		//IL_0022: Expected I4, but got Obj
		//IL_0022: Expected I4, but got Obj
		string text = FileUtility.ConvertToPathWithForwardSlashes((string)(object)this);
		return (string[])(object)text.Remove((int)"\\", (int)"->");
	}
}
