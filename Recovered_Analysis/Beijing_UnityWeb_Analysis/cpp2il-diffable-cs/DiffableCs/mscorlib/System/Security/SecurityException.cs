namespace System.Security;

public class SecurityException : SystemException
{
	private string permissionState; //Field offset: 0x44

	public SecurityException() { }

	public SecurityException(string message) { }

	protected SecurityException(SerializationInfo info, StreamingContext context) { }

	public SecurityException(string message, Exception inner) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString() { }

}

