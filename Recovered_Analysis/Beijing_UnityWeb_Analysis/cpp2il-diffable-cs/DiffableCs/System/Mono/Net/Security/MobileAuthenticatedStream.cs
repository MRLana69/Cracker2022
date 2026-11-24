namespace Mono.Net.Security;

internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IMonoSslStream, IDisposable
{
	private sealed class <>c__DisplayClass66_0
	{
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x8
		public int len; //Field offset: 0xC

		public <>c__DisplayClass66_0() { }

		internal int <InnerRead>b__0() { }

	}

	private struct <InnerRead>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<int> <>t__builder; //Field offset: 0x4
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		public int requestedSize; //Field offset: 0x18
		public bool sync; //Field offset: 0x1C
		private ConfiguredTaskAwaiter<int> <>u__1; //Field offset: 0x20

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct <InnerWrite>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CancellationToken cancellationToken; //Field offset: 0x10
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x14
		public bool sync; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct <ProcessAuthentication>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool serverMode; //Field offset: 0x10
		public X509Certificate serverCertificate; //Field offset: 0x14
		public string targetHost; //Field offset: 0x18
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x1C
		public bool runSynchronously; //Field offset: 0x20
		public SslProtocols enabledProtocols; //Field offset: 0x24
		public X509CertificateCollection clientCertificates; //Field offset: 0x28
		public bool clientCertRequired; //Field offset: 0x2C
		private ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; //Field offset: 0x30

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct <StartOperation>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<int> <>t__builder; //Field offset: 0x4
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x10
		public OperationType type; //Field offset: 0x14
		public AsyncProtocolRequest asyncRequest; //Field offset: 0x18
		public CancellationToken cancellationToken; //Field offset: 0x1C
		private ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; //Field offset: 0x20

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum OperationType
	{
		Read = 0,
		Write = 1,
		Shutdown = 2,
	}

	private static int uniqueNameInteger; //Field offset: 0x0
	private static int nextId; //Field offset: 0x4
	private MobileTlsContext xobileTlsContext; //Field offset: 0x1C
	private ExceptionDispatchInfo lastException; //Field offset: 0x20
	private AsyncProtocolRequest asyncHandshakeRequest; //Field offset: 0x24
	private AsyncProtocolRequest asyncReadRequest; //Field offset: 0x28
	private AsyncProtocolRequest asyncWriteRequest; //Field offset: 0x2C
	private BufferOffsetSize2 readBuffer; //Field offset: 0x30
	private BufferOffsetSize2 writeBuffer; //Field offset: 0x34
	private object ioLock; //Field offset: 0x38
	private int closeRequested; //Field offset: 0x3C
	private bool shutdown; //Field offset: 0x40
	private readonly SslStream <SslStream>k__BackingField; //Field offset: 0x44
	private readonly MonoTlsSettings <Settings>k__BackingField; //Field offset: 0x48
	private readonly MonoTlsProvider <Provider>k__BackingField; //Field offset: 0x4C
	internal readonly int ID; //Field offset: 0x50

	public override bool CanRead
	{
		 get { } //Length: 338
	}

	public override bool CanSeek
	{
		 get { } //Length: 41
	}

	public override bool CanWrite
	{
		 get { } //Length: 26
	}

	private SslProtocols DefaultProtocols
	{
		 get { } //Length: 143
	}

	public override bool IsAuthenticated
	{
		 get { } //Length: 4
	}

	public override long Length
	{
		 get { } //Length: 55
	}

	public override long Position
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	public MonoTlsProvider Provider
	{
		 get { } //Length: 6
	}

	public MonoTlsSettings Settings
	{
		 get { } //Length: 6
	}

	private static MobileAuthenticatedStream() { }

	public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	private void <InnerWrite>b__67_0() { }

	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public void AuthenticateAsClient(string targetHost) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false) { }

	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	protected override void Dispose(bool disposing) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override void Flush() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	private SslProtocols get_DefaultProtocols() { }

	public override bool get_IsAuthenticated() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public MonoTlsProvider get_Provider() { }

	public MonoTlsSettings get_Settings() { }

	internal static Exception GetIOException(Exception e, string message) { }

	internal static Exception GetSSPIException(Exception e) { }

	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	internal ExceptionDispatchInfo SetException(Exception e) { }

	public override void SetLength(long value) { }

	private Task<int> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

