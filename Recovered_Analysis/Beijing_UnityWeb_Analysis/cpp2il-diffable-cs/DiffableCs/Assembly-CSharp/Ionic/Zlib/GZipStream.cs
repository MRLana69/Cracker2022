namespace Ionic.Zlib;

public class GZipStream : Stream
{
	internal static readonly DateTime _unixEpoch; //Field offset: 0x0
	internal static readonly Encoding iso8859dash1; //Field offset: 0x8
	public Nullable<DateTime> LastModified; //Field offset: 0x18
	private int _headerByteCount; //Field offset: 0x28
	internal ZlibBaseStream _baseStream; //Field offset: 0x2C
	private bool _disposed; //Field offset: 0x30
	private bool _firstReadDone; //Field offset: 0x31
	private string _FileName; //Field offset: 0x34
	private string _Comment; //Field offset: 0x38
	private int _Crc32; //Field offset: 0x3C

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

	public string Comment
	{
		 get { } //Length: 413
		 set { } //Length: 272
	}

	public int Crc32
	{
		 get { } //Length: 6
	}

	public string FileName
	{
		 get { } //Length: 6
		 set { } //Length: 98
	}

	public virtual FlushType FlushMode
	{
		 get { } //Length: 6
		 set { } //Length: 315
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
		 get { } //Length: 53
	}

	public virtual long TotalOut
	{
		 get { } //Length: 12
	}

	private static GZipStream() { }

	public GZipStream(Stream stream, CompressionMode mode) { }

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level) { }

	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	public static byte[] CompressBuffer(byte[] b) { }

	public static byte[] CompressString(string s) { }

	protected override void Dispose(bool disposing) { }

	private int EmitHeader() { }

	public override void Flush() { }

	public int get_BufferSize() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public string get_Comment() { }

	public int get_Crc32() { }

	public string get_FileName() { }

	public virtual FlushType get_FlushMode() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public virtual long get_TotalIn() { }

	public virtual long get_TotalOut() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public void set_BufferSize(int value) { }

	public void set_Comment(string value) { }

	public void set_FileName(string value) { }

	public virtual void set_FlushMode(FlushType value) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public static byte[] UncompressBuffer(byte[] compressed) { }

	public static string UncompressString(byte[] compressed) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

