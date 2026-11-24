namespace Ionic.Zlib;

public class ZlibStream : Stream
{
	internal ZlibBaseStream _baseStream; //Field offset: 0x14
	private bool _disposed; //Field offset: 0x18

	public int BufferSize
	{
		 get { } //Length: 9
		 set { } //Length: 98
	}

	public override bool CanRead
	{
		 get { } //Length: 9
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
		 get { } //Length: 103
		 set { } //Length: 180
	}

	public override long Length
	{
		 get { } //Length: 12
	}

	public override long Position
	{
		 get { } //Length: 73
		 set { } //Length: 71
	}

	public virtual long TotalIn
	{
		 get { } //Length: 73
	}

	public virtual long TotalOut
	{
		 get { } //Length: 12
	}

	public ZlibStream(Stream stream, CompressionMode mode) { }

	public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level) { }

	public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

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

	public virtual long get_TotalIn() { }

	public virtual long get_TotalOut() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public void set_BufferSize(int value) { }

	public virtual void set_FlushMode(FlushType value) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public static byte[] UncompressBuffer(byte[] compressed) { }

	public static string UncompressString(byte[] compressed) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

