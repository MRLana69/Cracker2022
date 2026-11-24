namespace System;

public class BadImageFormatException : SystemException
{
	private string _fileName; //Field offset: 0x44
	private string _fusionLog; //Field offset: 0x48

	public string FusionLog
	{
		 get { } //Length: 721
	}

	public override string Message
	{
		 get { } //Length: 9
	}

	public BadImageFormatException() { }

	public BadImageFormatException(string message) { }

	public BadImageFormatException(string message, Exception inner) { }

	public BadImageFormatException(string message, string fileName) { }

	protected BadImageFormatException(SerializationInfo info, StreamingContext context) { }

	public string get_FusionLog() { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetMessageField() { }

	public override string ToString() { }

}

