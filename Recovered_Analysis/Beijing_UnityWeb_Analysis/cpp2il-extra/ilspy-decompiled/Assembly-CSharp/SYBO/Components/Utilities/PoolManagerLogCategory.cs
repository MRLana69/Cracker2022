using SYBO.Components.Logging;

namespace SYBO.Components.Utilities;

public class PoolManagerLogCategory : LogCategory
{
	public PoolManagerLogCategory(int categoryId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 24;
		obj = categoryId;
	}

	public override string[] GetCallstackPrefixes()
	{
		//IL_0007: Expected Obj, but got I4
		return (string[])HideStackLevel;
	}
}
