namespace System;

public class MissingMethodException : MissingMemberException, ISerializable
{
	private string signature; //Field offset: 0x50

	public override string Message
	{
		 get { } //Length: 42
	}

	public MissingMethodException() { }

	public MissingMethodException(string message) { }

	protected MissingMethodException(SerializationInfo info, StreamingContext context) { }

	public MissingMethodException(string className, string methodName) { }

	private MissingMethodException(string className, string methodName, string signature, string message) { }

	public override string get_Message() { }

}

