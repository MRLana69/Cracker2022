namespace NaughtyAttributes;

public class ValidateInputAttribute : ValidatorAttribute
{
	private string callbackName;

	private string message;

	public string CallbackName => callbackName;

	public string Message => callbackName;

	public ValidateInputAttribute(string callbackName, string message = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = callbackName;
		_ = 0;
		object obj2 = this + 20;
		obj2 = message;
	}
}
