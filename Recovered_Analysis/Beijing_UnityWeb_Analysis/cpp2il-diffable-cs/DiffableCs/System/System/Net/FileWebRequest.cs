namespace System.Net;

public class FileWebRequest : WebRequest, ISerializable
{
	private static WaitCallback s_GetRequestStreamCallback; //Field offset: 0x0
	private static WaitCallback s_GetResponseCallback; //Field offset: 0x4
	private string m_connectionGroupName; //Field offset: 0x14
	private long m_contentLength; //Field offset: 0x18
	private FileAccess m_fileAccess; //Field offset: 0x20
	private WebHeaderCollection m_headers; //Field offset: 0x24
	private string m_method; //Field offset: 0x28
	private IWebProxy m_proxy; //Field offset: 0x2C
	private ManualResetEvent m_readerEvent; //Field offset: 0x30
	private WebResponse m_response; //Field offset: 0x34
	private Stream m_stream; //Field offset: 0x38
	private bool m_syncHint; //Field offset: 0x3C
	private int m_timeout; //Field offset: 0x40
	private Uri m_uri; //Field offset: 0x44
	private bool m_writePending; //Field offset: 0x48
	private bool m_writing; //Field offset: 0x49
	private int m_Aborted; //Field offset: 0x4C

	internal bool Aborted
	{
		 get { } //Length: 485
	}

	private static FileWebRequest() { }

	internal FileWebRequest(Uri uri) { }

	protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal bool get_Aborted() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private static void GetRequestStreamCallback(object state) { }

	private static void GetResponseCallback(object state) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal void UnblockReader() { }

}

