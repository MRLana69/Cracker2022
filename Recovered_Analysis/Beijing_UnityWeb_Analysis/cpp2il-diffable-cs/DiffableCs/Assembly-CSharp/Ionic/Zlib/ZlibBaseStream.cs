namespace Ionic.Zlib;

internal class ZlibBaseStream : Stream
{
	internal enum StreamMode
	{
		Writer = 0,
		Reader = 1,
		Undefined = 2,
	}

	protected internal ZlibCodec _z; //Field offset: 0x14
	protected internal StreamMode _streamMode; //Field offset: 0x18
	protected internal FlushType _flushMode; //Field offset: 0x1C
	protected internal ZlibStreamFlavor _flavor; //Field offset: 0x20
	protected internal CompressionMode _compressionMode; //Field offset: 0x24
	protected internal CompressionLevel _level; //Field offset: 0x28
	protected internal bool _leaveOpen; //Field offset: 0x2C
	protected internal byte[] _workingBuffer; //Field offset: 0x30
	protected internal int _bufferSize; //Field offset: 0x34
	protected internal byte[] _buf1; //Field offset: 0x38
	protected internal Stream _stream; //Field offset: 0x3C
	protected internal CompressionStrategy Strategy; //Field offset: 0x40
	private CRC32 crc; //Field offset: 0x44
	protected internal string _GzipFileName; //Field offset: 0x48
	protected internal string _GzipComment; //Field offset: 0x4C
	protected internal DateTime _GzipMtime; //Field offset: 0x50
	protected internal int _gzipHeaderByteCount; //Field offset: 0x58
	private bool _disposed; //Field offset: 0x5C
	private bool nomoreinput; //Field offset: 0x5D

	protected internal bool _wantCompress
	{
		 get { } //Length: 23
	}

	public override bool CanRead
	{
		 get { } //Length: 690
	}

	public override bool CanSeek
	{
		 get { } //Length: 12
	}

	public override bool CanWrite
	{
		 get { } //Length: 12
	}

	internal int Crc32
	{
		 get { } //Length: 15
	}

	public override long Length
	{
		 get { } //Length: 92
	}

	public override long Position
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	private byte[] workingBuffer
	{
		 get { } //Length: 160
	}

	private ZlibCodec z
	{
		 get { } //Length: 7
	}

	private int _ReadAndValidateGzipHeader() { }

	public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	public static void CompressBuffer(byte[] b, Stream compressor) { }

	public static void CompressString(string s, Stream compressor) { }

	protected override void Dispose(bool disposing) { }

	private void end() { }

	protected override void Finalize() { }

	private void finish() { }

	public override void Flush() { }

	protected internal bool get__wantCompress() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	internal int get_Crc32() { }

	public override long get_Length() { }

	public override long get_Position() { }

	private byte[] get_workingBuffer() { }

	private ZlibCodec get_z() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	private string ReadZeroTerminatedString() { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }

	public static string UncompressString(byte[] compressed, Stream decompressor) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

