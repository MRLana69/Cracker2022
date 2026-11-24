namespace System;

public class ObjectDisposedException : InvalidOperationException
{
	private string objectName; //Field offset: 0x44

	public override string Message
	{
		 get { } //Length: 12
	}

	public string ObjectName
	{
		 get { } //Length: 144
	}

	private ObjectDisposedException() { }

	public ObjectDisposedException(string objectName) { }

	public ObjectDisposedException(string objectName, string message) { }

	protected ObjectDisposedException(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	public string get_ObjectName() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

