namespace UnityEngine.Assertions;

public class AssertionException : Exception
{
	private string m_UserMessage; //Field offset: 0x44

	public override string Message
	{
		 get { } //Length: 49
	}

	public AssertionException(string message, string userMessage) { }

	public override string get_Message() { }

}

