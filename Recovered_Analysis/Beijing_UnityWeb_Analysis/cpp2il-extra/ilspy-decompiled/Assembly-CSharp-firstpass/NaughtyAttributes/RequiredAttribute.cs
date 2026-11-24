using Cpp2ILInjected;

namespace NaughtyAttributes;

public class RequiredAttribute(string message = null) : ValidatorAttribute
{
	private string message = message;

	public string Message
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NaughtyAttributes.RequiredAttribute)+C]");
			return (string)0;
		}
	}
}
