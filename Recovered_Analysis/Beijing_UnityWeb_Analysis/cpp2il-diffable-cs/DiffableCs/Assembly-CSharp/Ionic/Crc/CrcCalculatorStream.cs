namespace Ionic.Crc;

public class CrcCalculatorStream : Stream
{
	private static readonly long UnsetLengthLimit; //Field offset: 0x0
	internal Stream _innerStream; //Field offset: 0x14
	private CRC32 _Crc32; //Field offset: 0x18
	private long _lengthLimit; //Field offset: 0x20
	private bool _leaveOpen; //Field offset: 0x28
	private bool _disposed; //Field offset: 0x29

	public override bool CanRead
	{
		 get { } //Length: 9
	}

	public override bool CanSeek
	{
		 get { } //Length: 12
	}

	public override bool CanWrite
	{
		 get { } //Length: 3
	}

	public int Crc
	{
		 get { } //Length: 45
	}

	public bool LeaveOpen
	{
		 get { } //Length: 12
		 set { } //Length: 103
	}

	public override long Length
	{
		 get { } //Length: 9
	}

	public override long Position
	{
		 get { } //Length: 115
		 set { } //Length: 71
	}

	public long TotalBytesSlurped
	{
		 get { } //Length: 6
	}

	private static CrcCalculatorStream() { }

	private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32) { }

	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32) { }

	public CrcCalculatorStream(Stream stream) { }

	public CrcCalculatorStream(Stream stream, long length) { }

	public CrcCalculatorStream(Stream stream, bool leaveOpen) { }

	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen) { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public override void Flush() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public int get_Crc() { }

	public bool get_LeaveOpen() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public long get_TotalBytesSlurped() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public void set_LeaveOpen(bool value) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

