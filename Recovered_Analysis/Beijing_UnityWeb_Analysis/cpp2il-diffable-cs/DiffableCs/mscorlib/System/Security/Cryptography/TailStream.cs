namespace System.Security.Cryptography;

internal sealed class TailStream : Stream
{
	private byte[] _Buffer; //Field offset: 0x14
	private int _BufferSize; //Field offset: 0x18
	private int _BufferIndex; //Field offset: 0x1C
	private bool _BufferFull; //Field offset: 0x20

	public byte[] Buffer
	{
		 get { } //Length: 202
	}

	public override bool CanRead
	{
		 get { } //Length: 56
	}

	public override bool CanSeek
	{
		 get { } //Length: 3
	}

	public override bool CanWrite
	{
		 get { } //Length: 3
	}

	public override long Length
	{
		 get { } //Length: 101
	}

	public override long Position
	{
		 get { } //Length: 85
		 set { } //Length: 83
	}

	public TailStream(int bufferSize) { }

	public void Clear() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public byte[] get_Buffer() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

