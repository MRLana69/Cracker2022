namespace System.IO;

public class StreamWriter : TextWriter
{
	public static readonly StreamWriter Null; //Field offset: 0x0
	private static Encoding _UTF8NoBOM; //Field offset: 0x4
	private Stream stream; //Field offset: 0x14
	private Encoding encoding; //Field offset: 0x18
	private Encoder encoder; //Field offset: 0x1C
	private byte[] byteBuffer; //Field offset: 0x20
	private char[] charBuffer; //Field offset: 0x24
	private int charPos; //Field offset: 0x28
	private int charLen; //Field offset: 0x2C
	private bool autoFlush; //Field offset: 0x30
	private bool haveWrittenPreamble; //Field offset: 0x31
	private bool closable; //Field offset: 0x32
	private Task _asyncWriteTask; //Field offset: 0x34

	public virtual bool AutoFlush
	{
		 set { } //Length: 621
	}

	public override Encoding Encoding
	{
		 get { } //Length: 12
	}

	internal bool LeaveOpen
	{
		 get { } //Length: 3
	}

	internal static Encoding UTF8NoBOM
	{
		 get { } //Length: 4
	}

	private static StreamWriter() { }

	internal StreamWriter(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	internal StreamWriter() { }

	public StreamWriter(Stream stream) { }

	public StreamWriter(Stream stream, Encoding encoding) { }

	public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	public StreamWriter(string path, bool append, Encoding encoding) { }

	public StreamWriter(string path, bool append, Encoding encoding, int bufferSize) { }

	private void CheckAsyncTaskInProgress() { }

	public override void Close() { }

	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	private void Flush(bool flushStream, bool flushEncoder) { }

	public override Encoding get_Encoding() { }

	internal bool get_LeaveOpen() { }

	internal static Encoding get_UTF8NoBOM() { }

	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	public virtual void set_AutoFlush(bool value) { }

	public override void Write(string value) { }

	public override void Write(char value) { }

	public override void Write(char[] buffer) { }

	public override void Write(char[] buffer, int index, int count) { }

}

