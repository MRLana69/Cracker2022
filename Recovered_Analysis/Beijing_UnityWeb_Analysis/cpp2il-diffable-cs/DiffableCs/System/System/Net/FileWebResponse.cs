namespace System.Net;

public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	private bool m_closed; //Field offset: 0xC
	private long m_contentLength; //Field offset: 0x10
	private FileAccess m_fileAccess; //Field offset: 0x18
	private WebHeaderCollection m_headers; //Field offset: 0x1C
	private Stream m_stream; //Field offset: 0x20
	private Uri m_uri; //Field offset: 0x24

	internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override void Close() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

