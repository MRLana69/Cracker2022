namespace Mono.Unity;

internal class UnityTlsContext : MobileTlsContext
{
	private unitytls_tlsctx* tlsContext; //Field offset: 0x2C
	private unitytls_x509list* requestedClientCertChain; //Field offset: 0x30
	private unitytls_key* requestedClientKey; //Field offset: 0x34
	private unitytls_tlsctx_read_callback readCallback; //Field offset: 0x38
	private unitytls_tlsctx_write_callback writeCallback; //Field offset: 0x3C
	private unitytls_tlsctx_certificate_callback certificateCallback; //Field offset: 0x40
	private unitytls_tlsctx_x509verify_callback verifyCallback; //Field offset: 0x44
	private X509Certificate localClientCertificate; //Field offset: 0x48
	private X509Certificate remoteCertificate; //Field offset: 0x4C
	private MonoTlsConnectionInfo connectioninfo; //Field offset: 0x50
	private bool isAuthenticated; //Field offset: 0x54
	private bool hasContext; //Field offset: 0x55
	private bool closedGraceful; //Field offset: 0x56
	private byte[] writeBuffer; //Field offset: 0x58
	private byte[] readBuffer; //Field offset: 0x5C
	private GCHandle handle; //Field offset: 0x60
	private Exception lastException; //Field offset: 0x64

	public override bool IsAuthenticated
	{
		 get { } //Length: 3
	}

	public UnityTlsContext(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	private static void CertificateCallback(void* userData, unitytls_tlsctx* ctx, byte* cn, nint cnLen, unitytls_x509name* caList, nint caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	private void CertificateCallback(unitytls_tlsctx* ctx, byte* cn, nint cnLen, unitytls_x509name* caList, nint caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	protected override void Dispose(bool disposing) { }

	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, out unitytls_x509list* nativeCertChain, out unitytls_key* nativeKey) { }

	public override void FinishHandshake() { }

	public override bool get_IsAuthenticated() { }

	public override bool ProcessHandshake() { }

	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	private static nint ReadCallback(void* userData, byte* buffer, nint bufferLen, unitytls_errorstate* errorState) { }

	private nint ReadCallback(byte* buffer, nint bufferLen, unitytls_errorstate* errorState) { }

	public override void Shutdown() { }

	public override void StartHandshake() { }

	private static unitytls_x509verify_result VerifyCallback(void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	private static nint WriteCallback(void* userData, byte* data, nint bufferLen, unitytls_errorstate* errorState) { }

	private nint WriteCallback(byte* data, nint bufferLen, unitytls_errorstate* errorState) { }

}

