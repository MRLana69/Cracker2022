namespace System.Net.Sockets;

public class SocketException : Win32Exception
{
	private EndPoint m_EndPoint; //Field offset: 0x48

	public override int ErrorCode
	{
		 get { } //Length: 175
	}

	public override string Message
	{
		 get { } //Length: 6
	}

	public SocketError SocketErrorCode
	{
		 get { } //Length: 90
	}

	public SocketException() { }

	internal SocketException(int error, string message) { }

	public SocketException(int errorCode) { }

	internal SocketException(SocketError socketError) { }

	protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override int get_ErrorCode() { }

	public override string get_Message() { }

	public SocketError get_SocketErrorCode() { }

	private static int WSAGetLastError_internal() { }

}

