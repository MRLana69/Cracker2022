namespace System.IO;

public abstract class Stream : MarshalByRefObject, IDisposable
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SemaphoreSlim> <>9__4_0; //Field offset: 0x4
		public static Action<object> <>9__36_0; //Field offset: 0x8
		public static Func<object, int> <>9__39_0; //Field offset: 0xC
		public static Func<Stream, ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__43_0; //Field offset: 0x10
		public static Func<Stream, IAsyncResult, int> <>9__43_1; //Field offset: 0x14
		public static Func<object, int> <>9__46_0; //Field offset: 0x18
		public static Action<Task, object> <>9__47_0; //Field offset: 0x1C
		public static Func<Stream, ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__53_0; //Field offset: 0x20
		public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__53_1; //Field offset: 0x24

		private static <>c() { }

		public <>c() { }

		internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

		internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		internal VoidTaskResult <BeginEndWriteAsync>b__53_1(Stream stream, IAsyncResult asyncResult) { }

		internal int <BeginReadInternal>b__39_0(object <p0>) { }

		internal int <BeginWriteInternal>b__46_0(object <p0>) { }

		internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

		internal void <FlushAsync>b__36_0(object state) { }

		internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

	}

	private sealed class NullStream : Stream
	{
		private static Task<int> s_nullReadTask; //Field offset: 0x0

		public override bool CanRead
		{
			 get { } //Length: 9
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
			 get { } //Length: 31
		}

		public override long Position
		{
			 get { } //Length: 3
			 set { } //Length: 269
		}

		internal NullStream() { }

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		protected override void Dispose(bool disposing) { }

		public override int EndRead(IAsyncResult asyncResult) { }

		public override void EndWrite(IAsyncResult asyncResult) { }

		public override void Flush() { }

		public override Task FlushAsync(CancellationToken cancellationToken) { }

		public override bool get_CanRead() { }

		public override bool get_CanSeek() { }

		public override bool get_CanWrite() { }

		public override long get_Length() { }

		public override long get_Position() { }

		public override int Read(out byte[] buffer, int offset, int count) { }

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		public override int ReadByte() { }

		public override long Seek(long offset, SeekOrigin origin) { }

		public override void set_Position(long value) { }

		public override void SetLength(long length) { }

		public override void Write(byte[] buffer, int offset, int count) { }

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		public override void WriteByte(byte value) { }

	}

	private struct ReadWriteParameters
	{
		internal byte[] Buffer; //Field offset: 0x0
		internal int Offset; //Field offset: 0x4
		internal int Count; //Field offset: 0x8

	}

	private sealed class ReadWriteTask : ITaskCompletionAction
	{
		private static ContextCallback s_invokeAsyncCallback; //Field offset: 0x0
		internal readonly bool _isRead; //Field offset: 0x2C
		internal Stream _stream; //Field offset: 0x30
		internal byte[] _buffer; //Field offset: 0x34
		internal int _offset; //Field offset: 0x38
		internal int _count; //Field offset: 0x3C
		private AsyncCallback _callback; //Field offset: 0x40
		private ExecutionContext _context; //Field offset: 0x44

		public ReadWriteTask(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

		internal void ClearBeginState() { }

		private static void InvokeAsyncCallback(object completedTask) { }

		private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

	}

	internal sealed class SynchronousAsyncResult : IAsyncResult
	{
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<ManualResetEvent> <>9__12_0; //Field offset: 0x4

			private static <>c() { }

			public <>c() { }

			internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

		}

		private readonly object _stateObject; //Field offset: 0x8
		private readonly bool _isWrite; //Field offset: 0xC
		private ManualResetEvent _waitHandle; //Field offset: 0x10
		private ExceptionDispatchInfo _exceptionInfo; //Field offset: 0x14
		private bool _endXxxCalled; //Field offset: 0x18
		private int _bytesRead; //Field offset: 0x1C

		public object AsyncState
		{
			 get { } //Length: 292
		}

		public WaitHandle AsyncWaitHandle
		{
			 get { } //Length: 3
		}

		public bool CompletedSynchronously
		{
			 get { } //Length: 6
		}

		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject) { }

		internal SynchronousAsyncResult(object asyncStateObject) { }

		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite) { }

		internal static int EndRead(IAsyncResult asyncResult) { }

		internal static void EndWrite(IAsyncResult asyncResult) { }

		public object get_AsyncState() { }

		public WaitHandle get_AsyncWaitHandle() { }

		public bool get_CompletedSynchronously() { }

		internal void ThrowIfError() { }

	}

	public static readonly Stream Null; //Field offset: 0x0
	private const int _DefaultCopyBufferSize = 81920; //Field offset: 0x0
	private ReadWriteTask _activeReadWriteTask; //Field offset: 0xC
	private SemaphoreSlim _asyncActiveSemaphore; //Field offset: 0x10

	public abstract bool CanRead
	{
		 get { } //Length: 0
	}

	public abstract bool CanSeek
	{
		 get { } //Length: 0
	}

	public abstract bool CanWrite
	{
		 get { } //Length: 0
	}

	public abstract long Length
	{
		 get { } //Length: 0
	}

	public abstract long Position
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	private static Stream() { }

	protected Stream() { }

	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	public virtual void Close() { }

	public void CopyTo(Stream destination) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	public abstract void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public abstract bool get_CanRead() { }

	public abstract bool get_CanSeek() { }

	public abstract bool get_CanWrite() { }

	public abstract long get_Length() { }

	public abstract long get_Position() { }

	private void InternalCopyTo(Stream destination, int bufferSize) { }

	public abstract int Read(out byte[] buffer, int offset, int count) { }

	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual int ReadByte() { }

	private void RunReadWriteTask(ReadWriteTask readWriteTask) { }

	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask) { }

	public abstract long Seek(long offset, SeekOrigin origin) { }

	public abstract void set_Position(long value) { }

	public abstract void SetLength(long value) { }

	public abstract void Write(byte[] buffer, int offset, int count) { }

	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	public virtual void WriteByte(byte value) { }

}

