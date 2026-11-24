namespace System.IO;

public class UnmanagedMemoryStream : Stream
{
	private SafeBuffer _buffer; //Field offset: 0x14
	private byte* _mem; //Field offset: 0x18
	private long _length; //Field offset: 0x20
	private long _capacity; //Field offset: 0x28
	private long _position; //Field offset: 0x30
	private long _offset; //Field offset: 0x38
	private FileAccess _access; //Field offset: 0x40
	internal bool _isOpen; //Field offset: 0x44
	private Task<int> _lastReadTask; //Field offset: 0x48

	public override bool CanRead
	{
		 get { } //Length: 12
	}

	public override bool CanSeek
	{
		 get { } //Length: 26
	}

	public override bool CanWrite
	{
		 get { } //Length: 9
	}

	public override long Length
	{
		 get { } //Length: 3
	}

	public override long Position
	{
		 get { } //Length: 52
		 set { } //Length: 2
	}

	public byte* PositionPointer
	{
		 get { } //Length: 26
	}

	protected UnmanagedMemoryStream() { }

	internal UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public override Task FlushAsync(CancellationToken cancellationToken) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public byte* get_PositionPointer() { }

	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	public override int Read(out byte[] buffer, int offset, int count) { }

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override int ReadByte() { }

	public override long Seek(long offset, SeekOrigin loc) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override void WriteByte(byte value) { }

}

