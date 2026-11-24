namespace Mono.Net.Security;

internal abstract class MobileTlsContext : IDisposable
{
	private MobileAuthenticatedStream parent; //Field offset: 0x8
	private bool serverMode; //Field offset: 0xC
	private string targetHost; //Field offset: 0x10
	private string serverName; //Field offset: 0x14
	private SslProtocols enabledProtocols; //Field offset: 0x18
	private X509Certificate serverCertificate; //Field offset: 0x1C
	private X509CertificateCollection clientCertificates; //Field offset: 0x20
	private bool askForClientCert; //Field offset: 0x24
	private ICertificateValidator2 certificateValidator; //Field offset: 0x28

	protected X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 6
	}

	public abstract bool IsAuthenticated
	{
		 get { } //Length: 0
	}

	public bool IsServer
	{
		 get { } //Length: 9
	}

	internal MobileAuthenticatedStream Parent
	{
		 get { } //Length: 50
	}

	protected string ServerName
	{
		 get { } //Length: 6
	}

	public MonoTlsSettings Settings
	{
		 get { } //Length: 6
	}

	protected string TargetHost
	{
		 get { } //Length: 9
	}

	public MobileTlsContext(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public abstract void FinishHandshake() { }

	protected X509CertificateCollection get_ClientCertificates() { }

	public abstract bool get_IsAuthenticated() { }

	public bool get_IsServer() { }

	internal MobileAuthenticatedStream get_Parent() { }

	protected string get_ServerName() { }

	public MonoTlsSettings get_Settings() { }

	protected string get_TargetHost() { }

	public abstract bool ProcessHandshake() { }

	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	public abstract void Shutdown() { }

	public abstract void StartHandshake() { }

	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

}

