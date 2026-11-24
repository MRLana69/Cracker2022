namespace System.IO;

public class FileStream : Stream
{
	private delegate ReadDelegate
	{

		public ReadDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		public virtual int EndInvoke(IAsyncResult result) { }

		public virtual int Invoke(byte[] buffer, int offset, int count) { }

	}

	private delegate WriteDelegate
	{

		public WriteDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(byte[] buffer, int offset, int count) { }

	}

	private static byte[] buf_recycle; //Field offset: 0x0
	private static readonly object buf_recycle_lock; //Field offset: 0x4
	private byte[] buf; //Field offset: 0x14
	private string name; //Field offset: 0x18
	private SafeFileHandle safeHandle; //Field offset: 0x1C
	private bool isExposed; //Field offset: 0x20
	private long append_startpos; //Field offset: 0x28
	private FileAccess access; //Field offset: 0x30
	private bool owner; //Field offset: 0x34
	private bool async; //Field offset: 0x35
	private bool canseek; //Field offset: 0x36
	private bool anonymous; //Field offset: 0x37
	private bool buf_dirty; //Field offset: 0x38
	private int buf_size; //Field offset: 0x3C
	private int buf_length; //Field offset: 0x40
	private int buf_offset; //Field offset: 0x44
	private long buf_start; //Field offset: 0x48

	public override bool CanRead
	{
		 get { } //Length: 317
	}

	public override bool CanSeek
	{
		 get { } //Length: 23
	}

	public override bool CanWrite
	{
		 get { } //Length: 23
	}

	public override long Length
	{
		 get { } //Length: 362
	}

	public override long Position
	{
		 get { } //Length: 318
		 set { } //Length: 435
	}

	public virtual SafeFileHandle SafeFileHandle
	{
		 get { } //Length: 9
	}

	private static FileStream() { }

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = false, bool checkHost = false) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	public FileStream(nint handle, FileAccess access, bool ownsHandle, int bufferSize) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share) { }

	public FileStream(string path, FileMode mode, FileAccess access) { }

	public FileStream(string path, FileMode mode) { }

	internal FileStream(nint handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	protected override void Dispose(bool disposing) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	private void ExposeHandle() { }

	protected override void Finalize() { }

	public override void Flush() { }

	public override Task FlushAsync(CancellationToken cancellationToken) { }

	private void FlushBuffer() { }

	private void FlushBufferIfDirty() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public virtual SafeFileHandle get_SafeFileHandle() { }

	private string GetSecureFileName(string filename, bool full) { }

	private string GetSecureFileName(string filename) { }

	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	private void InitBuffer(int size, bool isZeroSize) { }

	public override int Read(out byte[] array, int offset, int count) { }

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override int ReadByte() { }

	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	private int ReadInternal(byte[] dest, int offset, int count) { }

	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	private void RefillBuffer() { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] array, int offset, int count) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override void WriteByte(byte value) { }

	private void WriteInternal(byte[] src, int offset, int count) { }

	private int WriteSegment(byte[] src, int src_offset, int count) { }

}

