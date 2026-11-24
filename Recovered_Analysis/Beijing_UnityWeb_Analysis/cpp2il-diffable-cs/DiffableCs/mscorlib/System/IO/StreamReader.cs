namespace System.IO;

public class StreamReader : TextReader
{
	private class NullStreamReader : StreamReader
	{

		public override Stream BaseStream
		{
			 get { } //Length: 426
		}

		public override Encoding CurrentEncoding
		{
			 get { } //Length: 89
		}

		internal NullStreamReader() { }

		protected override void Dispose(bool disposing) { }

		public override Stream get_BaseStream() { }

		public override Encoding get_CurrentEncoding() { }

		public override int Peek() { }

		public override int Read() { }

		public override int Read(char[] buffer, int index, int count) { }

		internal override int ReadBuffer() { }

		public override string ReadLine() { }

		public override string ReadToEnd() { }

	}

	public static readonly StreamReader Null; //Field offset: 0x0
	private Stream stream; //Field offset: 0xC
	private Encoding encoding; //Field offset: 0x10
	private Decoder decoder; //Field offset: 0x14
	private byte[] byteBuffer; //Field offset: 0x18
	private char[] charBuffer; //Field offset: 0x1C
	private byte[] _preamble; //Field offset: 0x20
	private int charPos; //Field offset: 0x24
	private int charLen; //Field offset: 0x28
	private int byteLen; //Field offset: 0x2C
	private int bytePos; //Field offset: 0x30
	private int _maxCharsPerBuffer; //Field offset: 0x34
	private bool _detectEncoding; //Field offset: 0x38
	private bool _checkPreamble; //Field offset: 0x39
	private bool _isBlocked; //Field offset: 0x3A
	private bool _closable; //Field offset: 0x3B
	private Task _asyncReadTask; //Field offset: 0x3C

	public virtual Stream BaseStream
	{
		 get { } //Length: 6
	}

	public virtual Encoding CurrentEncoding
	{
		 get { } //Length: 61
	}

	internal static int DefaultBufferSize
	{
		 get { } //Length: 175
	}

	internal bool LeaveOpen
	{
		 get { } //Length: 6
	}

	private static StreamReader() { }

	internal StreamReader() { }

	public StreamReader(Stream stream) { }

	public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	public StreamReader(Stream stream, Encoding encoding) { }

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	public StreamReader(string path) { }

	public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }

	public StreamReader(string path, Encoding encoding) { }

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	internal StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	private void CheckAsyncTaskInProgress() { }

	public override void Close() { }

	private void CompressBuffer(int n) { }

	internal bool DataAvailable() { }

	private void DetectEncoding() { }

	protected override void Dispose(bool disposing) { }

	public virtual Stream get_BaseStream() { }

	public virtual Encoding get_CurrentEncoding() { }

	internal static int get_DefaultBufferSize() { }

	internal bool get_LeaveOpen() { }

	internal void Init(Stream stream) { }

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	private bool IsPreamble() { }

	public override int Peek() { }

	public override int Read(out char[] buffer, int index, int count) { }

	public override int Read() { }

	internal virtual int ReadBuffer() { }

	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

}

