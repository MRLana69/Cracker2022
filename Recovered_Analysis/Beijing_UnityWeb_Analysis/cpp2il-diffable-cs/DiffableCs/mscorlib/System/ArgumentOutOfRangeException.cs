namespace System;

public class ArgumentOutOfRangeException : ArgumentException, ISerializable
{
	private static string _rangeMessage; //Field offset: 0x0
	private object m_actualValue; //Field offset: 0x48

	public override string Message
	{
		 get { } //Length: 143
	}

	private static string RangeMessage
	{
		 get { } //Length: 57
	}

	public ArgumentOutOfRangeException() { }

	public ArgumentOutOfRangeException(string paramName) { }

	public ArgumentOutOfRangeException(string paramName, string message) { }

	public ArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	private static string get_RangeMessage() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

