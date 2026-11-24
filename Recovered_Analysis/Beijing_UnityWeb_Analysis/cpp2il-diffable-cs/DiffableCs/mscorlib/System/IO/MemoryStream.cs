namespace System.IO;

public class MemoryStream : Stream
{
	private byte[] _buffer; //Field offset: 0x14
	private int _origin; //Field offset: 0x18
	private int _position; //Field offset: 0x1C
	private int _length; //Field offset: 0x20
	private int _capacity; //Field offset: 0x24
	private bool _expandable; //Field offset: 0x28
	private bool _writable; //Field offset: 0x29
	private bool _exposable; //Field offset: 0x2A
	private bool _isOpen; //Field offset: 0x2B
	private Task<int> _lastReadTask; //Field offset: 0x2C

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
		 get { } //Length: 9
	}

	public virtual int Capacity
	{
		 get { } //Length: 130
		 set { } //Length: 173
	}

	public override long Length
	{
		 get { } //Length: 128
	}

	public override long Position
	{
		 get { } //Length: 31
		 set { } //Length: 154
	}

	public MemoryStream() { }

	public MemoryStream(int capacity) { }

	public MemoryStream(byte[] buffer) { }

	public MemoryStream(byte[] buffer, bool writable) { }

	public MemoryStream(byte[] buffer, int index, int count) { }

	public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	protected override void Dispose(bool disposing) { }

	private bool EnsureCapacity(int value) { }

	private void EnsureWriteable() { }

	public override void Flush() { }

	public override Task FlushAsync(CancellationToken cancellationToken) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public virtual int get_Capacity() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public virtual byte[] GetBuffer() { }

	internal int InternalEmulateRead(int count) { }

	internal byte[] InternalGetBuffer() { }

	internal int InternalGetPosition() { }

	internal int InternalReadInt32() { }

	public override int Read(out byte[] buffer, int offset, int count) { }

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override int ReadByte() { }

	public override long Seek(long offset, SeekOrigin loc) { }

	public virtual void set_Capacity(int value) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public virtual byte[] ToArray() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override void WriteByte(byte value) { }

}

