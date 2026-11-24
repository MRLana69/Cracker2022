namespace NaughtyAttributes;

public class ValidateInputAttribute : ValidatorAttribute
{
	private string callbackName; //Field offset: 0x8
	private string message; //Field offset: 0xC

	public string CallbackName
	{
		 get { } //Length: 6
	}

	public string Message
	{
		 get { } //Length: 6
	}

	public ValidateInputAttribute(string callbackName, string message = null) { }

	public string get_CallbackName() { }

	public string get_Message() { }

}

