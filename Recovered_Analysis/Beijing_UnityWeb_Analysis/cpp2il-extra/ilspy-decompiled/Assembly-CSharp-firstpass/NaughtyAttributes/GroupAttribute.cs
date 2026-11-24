using Cpp2ILInjected;

namespace NaughtyAttributes;

public abstract class GroupAttribute : NaughtyAttribute
{
	private string name;

	public string Name
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.GroupAttribute)+C]");
			return (string)0;
		}
	}

	public GroupAttribute(string name)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = name;
	}
}
