namespace System.Net;

internal sealed class FileWebStream : FileStream, ICloseEx
{
	private FileWebRequest m_request; //Field offset: 0x50

	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	private void CheckError() { }

	protected override void Dispose(bool disposing) { }

	public override int EndRead(IAsyncResult ar) { }

	public override void EndWrite(IAsyncResult ar) { }

	public override int Read(byte[] buffer, int offset, int size) { }

	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	public override void Write(byte[] buffer, int offset, int size) { }

}

