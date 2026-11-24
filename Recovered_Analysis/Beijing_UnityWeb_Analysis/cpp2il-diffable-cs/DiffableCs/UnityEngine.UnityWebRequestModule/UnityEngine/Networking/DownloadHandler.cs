namespace UnityEngine.Networking;

public class DownloadHandler : IDisposable
{
	internal nint m_Ptr; //Field offset: 0x8

	public byte[] data
	{
		 get { } //Length: 107
	}

	public string text
	{
		 get { } //Length: 9
	}

	internal DownloadHandler() { }

	public void Dispose() { }

	protected override void Finalize() { }

	public byte[] get_data() { }

	public string get_text() { }

	private string GetContentType() { }

	protected virtual byte[] GetData() { }

	protected virtual string GetText() { }

	private Encoding GetTextEncoder() { }

	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

	private void Release() { }

}

