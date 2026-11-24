namespace NaughtyAttributes;

public class RequiredAttribute : ValidatorAttribute
{
	private string message; //Field offset: 0x8

	public string Message
	{
		 get { } //Length: 6
	}

	public RequiredAttribute(string message = null) { }

	public string get_Message() { }

}

