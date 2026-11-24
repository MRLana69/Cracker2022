namespace System;

public class ArgumentException : SystemException, ISerializable
{
	private string m_paramName; //Field offset: 0x44

	public override string Message
	{
		 get { } //Length: 11
	}

	public ArgumentException() { }

	public ArgumentException(string message) { }

	public ArgumentException(string message, Exception innerException) { }

	public ArgumentException(string message, string paramName, Exception innerException) { }

	public ArgumentException(string message, string paramName) { }

	protected ArgumentException(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

