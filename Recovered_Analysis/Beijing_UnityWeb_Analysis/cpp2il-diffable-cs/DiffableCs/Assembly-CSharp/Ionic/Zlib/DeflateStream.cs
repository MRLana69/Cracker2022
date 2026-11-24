namespace Ionic.Zlib;

public class DeflateStream : Stream
{
	internal ZlibBaseStream _baseStream; //Field offset: 0x14
	internal Stream _innerStream; //Field offset: 0x18
	private bool _disposed; //Field offset: 0x1C

	public int BufferSize
	{
		 get { } //Length: 9
		 set { } //Length: 98
	}

	public override bool CanRead
	{
		 get { } //Length: 12
	}

	public override bool CanSeek
	{
		 get { } //Length: 105
	}

	public override bool CanWrite
	{
		 get { } //Length: 3
	}

	public virtual FlushType FlushMode
	{
		 get { } //Length: 335
		 set { } //Length: 12
	}

	public override long Length
	{
		 get { } //Length: 12
	}

	public override long Position
	{
		 get { } //Length: 73
		 set { } //Length: 6
	}

	public CompressionStrategy Strategy
	{
		 get { } //Length: 9
		 set { } //Length: 289
	}

	public virtual long TotalIn
	{
		 get { } //Length: 124
	}

	public virtual long TotalOut
	{
		 get { } //Length: 12
	}

	public DeflateStream(Stream stream, CompressionMode mode) { }

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level) { }

	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	public static byte[] CompressBuffer(byte[] b) { }

	public static byte[] CompressString(string s) { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public int get_BufferSize() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public virtual FlushType get_FlushMode() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public CompressionStrategy get_Strategy() { }

	public virtual long get_TotalIn() { }

	public virtual long get_TotalOut() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public void set_BufferSize(int value) { }

	public virtual void set_FlushMode(FlushType value) { }

	public override void set_Position(long value) { }

	public void set_Strategy(CompressionStrategy value) { }

	public override void SetLength(long value) { }

	public static byte[] UncompressBuffer(byte[] compressed) { }

	public static string UncompressString(byte[] compressed) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

