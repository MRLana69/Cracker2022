namespace System;

public class MissingFieldException : MissingMemberException, ISerializable
{

	public override string Message
	{
		 get { } //Length: 104
	}

	public MissingFieldException() { }

	public MissingFieldException(string message) { }

	protected MissingFieldException(SerializationInfo info, StreamingContext context) { }

	public MissingFieldException(string className, string fieldName) { }

	public override string get_Message() { }

}

