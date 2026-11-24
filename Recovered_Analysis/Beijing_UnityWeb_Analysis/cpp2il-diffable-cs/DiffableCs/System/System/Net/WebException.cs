namespace System.Net;

public class WebException : InvalidOperationException, ISerializable
{
	private WebExceptionStatus m_Status; //Field offset: 0x44
	private WebResponse m_Response; //Field offset: 0x48

	public WebException() { }

	public WebException(string message, Exception innerException) { }

	public WebException(string message, WebExceptionStatus status) { }

	public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

