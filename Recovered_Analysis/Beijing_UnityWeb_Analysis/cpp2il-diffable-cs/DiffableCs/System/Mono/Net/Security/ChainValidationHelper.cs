namespace Mono.Net.Security;

internal class ChainValidationHelper : ICertificateValidator2, ICertificateValidator
{
	private readonly object sender; //Field offset: 0x8
	private readonly MonoTlsSettings settings; //Field offset: 0xC
	private readonly MonoTlsProvider provider; //Field offset: 0x10
	private readonly ServerCertValidationCallback certValidationCallback; //Field offset: 0x14
	private readonly LocalCertSelectionCallback certSelectionCallback; //Field offset: 0x18
	private readonly ServerCertValidationCallbackWrapper callbackWrapper; //Field offset: 0x1C
	private readonly MonoTlsStream tlsStream; //Field offset: 0x20
	private readonly HttpWebRequest request; //Field offset: 0x24

	public MonoTlsSettings Settings
	{
		 get { } //Length: 66
	}

	private ChainValidationHelper(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	public MonoTlsSettings get_Settings() { }

	internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	public ValidationResult ValidateCertificate(string host, bool serverMode, X509CertificateCollection certs) { }

	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

