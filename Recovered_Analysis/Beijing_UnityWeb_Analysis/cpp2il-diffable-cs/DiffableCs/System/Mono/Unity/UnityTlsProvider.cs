namespace Mono.Unity;

internal class UnityTlsProvider : MonoTlsProvider
{

	public override Guid ID
	{
		 get { } //Length: 419
	}

	public override string Name
	{
		 get { } //Length: 170
	}

	public override SslProtocols SupportedProtocols
	{
		 get { } //Length: 3
	}

	internal override bool SupportsCleanShutdown
	{
		 get { } //Length: 3
	}

	public override bool SupportsConnectionInfo
	{
		 get { } //Length: 3
	}

	public override bool SupportsMonoExtensions
	{
		 get { } //Length: 3
	}

	public override bool SupportsSslStream
	{
		 get { } //Length: 43
	}

	public UnityTlsProvider() { }

	public override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings = null) { }

	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	public override Guid get_ID() { }

	public override string get_Name() { }

	public override SslProtocols get_SupportedProtocols() { }

	internal override bool get_SupportsCleanShutdown() { }

	public override bool get_SupportsConnectionInfo() { }

	public override bool get_SupportsMonoExtensions() { }

	public override bool get_SupportsSslStream() { }

	internal override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

}

