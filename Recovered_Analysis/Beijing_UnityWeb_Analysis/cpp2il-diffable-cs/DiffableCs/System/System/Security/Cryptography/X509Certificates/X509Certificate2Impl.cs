namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509Certificate2Impl : X509CertificateImpl
{

	public abstract X509ExtensionCollection Extensions
	{
		 get { } //Length: 0
	}

	internal abstract X509Certificate2Impl FallbackImpl
	{
		 get { } //Length: 0
	}

	internal abstract X509CertificateImplCollection IntermediateCertificates
	{
		 get { } //Length: 0
	}

	public abstract X500DistinguishedName IssuerName
	{
		 get { } //Length: 0
	}

	public abstract AsymmetricAlgorithm PrivateKey
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract PublicKey PublicKey
	{
		 get { } //Length: 0
	}

	public abstract Oid SignatureAlgorithm
	{
		 get { } //Length: 0
	}

	public abstract X500DistinguishedName SubjectName
	{
		 get { } //Length: 0
	}

	public abstract int Version
	{
		 get { } //Length: 0
	}

	protected X509Certificate2Impl() { }

	public abstract X509ExtensionCollection get_Extensions() { }

	internal abstract X509Certificate2Impl get_FallbackImpl() { }

	internal abstract X509CertificateImplCollection get_IntermediateCertificates() { }

	public abstract X500DistinguishedName get_IssuerName() { }

	public abstract AsymmetricAlgorithm get_PrivateKey() { }

	public abstract PublicKey get_PublicKey() { }

	public abstract Oid get_SignatureAlgorithm() { }

	public abstract X500DistinguishedName get_SubjectName() { }

	public abstract int get_Version() { }

	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	public abstract void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	public abstract void Reset() { }

	public abstract void set_PrivateKey(AsymmetricAlgorithm value) { }

	public abstract bool Verify(X509Certificate2 thisCertificate) { }

}

