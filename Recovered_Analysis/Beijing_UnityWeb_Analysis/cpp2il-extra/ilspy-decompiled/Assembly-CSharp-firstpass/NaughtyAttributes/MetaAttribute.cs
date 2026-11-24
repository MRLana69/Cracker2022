using Cpp2ILInjected;

namespace NaughtyAttributes;

public abstract class MetaAttribute : NaughtyAttribute
{
	private int order;

	public int Order
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.MetaAttribute)+14]");
			return 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}
}
