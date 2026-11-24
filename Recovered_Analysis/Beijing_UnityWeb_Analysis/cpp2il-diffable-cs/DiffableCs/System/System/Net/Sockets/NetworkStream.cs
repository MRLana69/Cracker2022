namespace System.Net.Sockets;

public class NetworkStream : Stream
{
	private Socket m_StreamSocket; //Field offset: 0x14
	private bool m_Readable; //Field offset: 0x18
	private bool m_Writeable; //Field offset: 0x19
	private bool m_OwnsSocket; //Field offset: 0x1A
	private int m_CloseTimeout; //Field offset: 0x1C
	private bool m_CleanedUp; //Field offset: 0x20
	private int m_CurrentReadTimeout; //Field offset: 0x24
	private int m_CurrentWriteTimeout; //Field offset: 0x28

	public override bool CanRead
	{
		 get { } //Length: 6
	}

	public override bool CanSeek
	{
		 get { } //Length: 9
	}

	public override bool CanWrite
	{
		 get { } //Length: 3
	}

	public override long Length
	{
		 get { } //Length: 95
	}

	public override long Position
	{
		 get { } //Length: 85
		 set { } //Length: 128
	}

	public NetworkStream(Socket socket, bool ownsSocket) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	protected override void Dispose(bool disposing) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	protected override void Finalize() { }

	public override void Flush() { }

	public override Task FlushAsync(CancellationToken cancellationToken) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	public override int Read(out byte[] buffer, int offset, int size) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int size) { }

}

