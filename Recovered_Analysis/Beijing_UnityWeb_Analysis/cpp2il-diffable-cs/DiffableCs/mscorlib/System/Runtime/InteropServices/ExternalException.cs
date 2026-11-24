namespace System.Runtime.InteropServices;

public class ExternalException : SystemException
{

	public virtual int ErrorCode
	{
		 get { } //Length: 285
	}

	public ExternalException() { }

	public ExternalException(string message) { }

	protected ExternalException(SerializationInfo info, StreamingContext context) { }

	public virtual int get_ErrorCode() { }

	public override string ToString() { }

}

