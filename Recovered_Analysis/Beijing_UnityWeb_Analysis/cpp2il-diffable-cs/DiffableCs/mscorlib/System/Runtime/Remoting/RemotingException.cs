namespace System.Runtime.Remoting;

public class RemotingException : SystemException
{

	public RemotingException() { }

	public RemotingException(string message) { }

	protected RemotingException(SerializationInfo info, StreamingContext context) { }

	public RemotingException(string message, Exception InnerException) { }

}

