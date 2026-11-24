namespace System.Net.Security;

public class SslStream : AuthenticatedStream
{
	private MonoTlsProvider provider; //Field offset: 0x1C
	private IMonoSslStream impl; //Field offset: 0x20

	public override bool CanRead
	{
		 get { } //Length: 3
	}

	public override bool CanSeek
	{
		 get { } //Length: 61
	}

	public override bool CanWrite
	{
		 get { } //Length: 65
	}

	internal IMonoSslStream Impl
	{
		 get { } //Length: 6
	}

	public override bool IsAuthenticated
	{
		 get { } //Length: 14
	}

	public override long Length
	{
		 get { } //Length: 85
	}

	public override long Position
	{
		 get { } //Length: 61
		 set { } //Length: 83
	}

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	public virtual void AuthenticateAsClient(string targetHost) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	private void CheckDisposed() { }

	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	protected override void Dispose(bool disposing) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override void Flush() { }

	public override Task FlushAsync(CancellationToken cancellationToken) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	internal IMonoSslStream get_Impl() { }

	public override bool get_IsAuthenticated() { }

	public override long get_Length() { }

	public override long get_Position() { }

	private static MonoTlsProvider GetProvider() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

