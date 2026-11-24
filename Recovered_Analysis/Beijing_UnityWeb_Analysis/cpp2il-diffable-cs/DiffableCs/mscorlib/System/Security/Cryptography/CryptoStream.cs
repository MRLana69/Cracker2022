namespace System.Security.Cryptography;

public class CryptoStream : Stream, IDisposable
{
	private struct <ReadAsyncInternal>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<int> <>t__builder; //Field offset: 0x4
		public CryptoStream <>4__this; //Field offset: 0x10
		public int count; //Field offset: 0x14
		public int offset; //Field offset: 0x18
		public byte[] buffer; //Field offset: 0x1C
		public CancellationToken cancellationToken; //Field offset: 0x20
		private byte[] <tempInputBuffer>5__1; //Field offset: 0x24
		private int <currentOutputIndex>5__2; //Field offset: 0x28
		private int <bytesToDeliver>5__3; //Field offset: 0x2C
		private SemaphoreSlim <sem>5__4; //Field offset: 0x30
		private HopToThreadPoolAwaitable <>u__1; //Field offset: 0x34
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x38
		private int <>7__wrap1; //Field offset: 0x40
		private ConfiguredTaskAwaiter<int> <>u__3; //Field offset: 0x44

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct <WriteAsyncInternal>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CryptoStream <>4__this; //Field offset: 0x10
		public int count; //Field offset: 0x14
		public int offset; //Field offset: 0x18
		public byte[] buffer; //Field offset: 0x1C
		public CancellationToken cancellationToken; //Field offset: 0x20
		private int <bytesToWrite>5__1; //Field offset: 0x24
		private int <currentInputIndex>5__2; //Field offset: 0x28
		private int <numWholeBlocksInBytes>5__3; //Field offset: 0x2C
		private SemaphoreSlim <sem>5__4; //Field offset: 0x30
		private HopToThreadPoolAwaitable <>u__1; //Field offset: 0x34
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x38

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct HopToThreadPoolAwaitable : INotifyCompletion
	{

		public bool IsCompleted
		{
			 get { } //Length: 9
		}

		public bool get_IsCompleted() { }

		public HopToThreadPoolAwaitable GetAwaiter() { }

		public void GetResult() { }

		public void OnCompleted(Action continuation) { }

	}

	private Stream _stream; //Field offset: 0x14
	private ICryptoTransform _Transform; //Field offset: 0x18
	private byte[] _InputBuffer; //Field offset: 0x1C
	private int _InputBufferIndex; //Field offset: 0x20
	private int _InputBlockSize; //Field offset: 0x24
	private byte[] _OutputBuffer; //Field offset: 0x28
	private int _OutputBufferIndex; //Field offset: 0x2C
	private int _OutputBlockSize; //Field offset: 0x30
	private CryptoStreamMode _transformMode; //Field offset: 0x34
	private bool _canRead; //Field offset: 0x38
	private bool _canWrite; //Field offset: 0x39
	private bool _finalBlockTransformed; //Field offset: 0x3A

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
		 get { } //Length: 3
	}

	public bool HasFlushedFinalBlock
	{
		 get { } //Length: 9
	}

	public override long Length
	{
		 get { } //Length: 31
	}

	public override long Position
	{
		 get { } //Length: 85
		 set { } //Length: 301
	}

	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	public void Clear() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public override Task FlushAsync(CancellationToken cancellationToken) { }

	public void FlushFinalBlock() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public bool get_HasFlushedFinalBlock() { }

	public override long get_Length() { }

	public override long get_Position() { }

	private void InitializeBuffer() { }

	public override int Read(out byte[] buffer, int offset, int count) { }

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

