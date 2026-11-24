namespace System.Net.NetworkInformation;

public class NetworkInformationException : Win32Exception
{

	public override int ErrorCode
	{
		 get { } //Length: 65
	}

	public NetworkInformationException() { }

	protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override int get_ErrorCode() { }

}

