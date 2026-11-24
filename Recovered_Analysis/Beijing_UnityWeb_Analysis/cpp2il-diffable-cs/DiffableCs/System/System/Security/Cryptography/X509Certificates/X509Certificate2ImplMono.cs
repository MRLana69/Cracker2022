namespace System.Security.Cryptography.X509Certificates;

internal class X509Certificate2ImplMono : X509Certificate2Impl
{
	private static string empty_error; //Field offset: 0x0
	private static byte[] commonName; //Field offset: 0x4
	private static byte[] email; //Field offset: 0x8
	private static byte[] signedData; //Field offset: 0xC
	private bool _archived; //Field offset: 0xC
	private X509ExtensionCollection _extensions; //Field offset: 0x10
	private PublicKey _publicKey; //Field offset: 0x14
	private X500DistinguishedName issuer_name; //Field offset: 0x18
	private X500DistinguishedName subject_name; //Field offset: 0x1C
	private Oid signature_algorithm; //Field offset: 0x20
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0x24
	private X509Certificate _cert; //Field offset: 0x28

	public override X509ExtensionCollection Extensions
	{
		 get { } //Length: 20
	}

	internal override X509Certificate2Impl FallbackImpl
	{
		 get { } //Length: 6
	}

	internal override X509CertificateImplCollection IntermediateCertificates
	{
		 get { } //Length: 62
	}

	public override X500DistinguishedName IssuerName
	{
		 get { } //Length: 193
	}

	public override bool IsValid
	{
		 get { } //Length: 54
	}

	internal X509Certificate MonoCertificate
	{
		 get { } //Length: 6
	}

	public override AsymmetricAlgorithm PrivateKey
	{
		 get { } //Length: 202
		 set { } //Length: 41
	}

	public override PublicKey PublicKey
	{
		 get { } //Length: 1171
	}

	public override Oid SignatureAlgorithm
	{
		 get { } //Length: 508
	}

	public override X500DistinguishedName SubjectName
	{
		 get { } //Length: 199
	}

	public override int Version
	{
		 get { } //Length: 202
	}

	private static X509Certificate2ImplMono() { }

	private X509Certificate2ImplMono(X509Certificate cert) { }

	private X509Certificate2ImplMono(X509Certificate2ImplMono other) { }

	public X509Certificate2ImplMono() { }

	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	public override X509CertificateImpl Clone() { }

	public override bool Equals(X509CertificateImpl other, out bool result) { }

	private ASN1 Find(byte[] oid, ASN1 dn) { }

	public override X509ExtensionCollection get_Extensions() { }

	internal override X509Certificate2Impl get_FallbackImpl() { }

	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	public override X500DistinguishedName get_IssuerName() { }

	public override bool get_IsValid() { }

	internal X509Certificate get_MonoCertificate() { }

	public override AsymmetricAlgorithm get_PrivateKey() { }

	public override PublicKey get_PublicKey() { }

	public override Oid get_SignatureAlgorithm() { }

	public override X500DistinguishedName get_SubjectName() { }

	public override int get_Version() { }

	protected override byte[] GetCertHash(bool lazy) { }

	public override string GetIssuerName(bool legacyV1Mode) { }

	public override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	public override byte[] GetRawCertData() { }

	public override byte[] GetSerialNumber() { }

	public override string GetSubjectName(bool legacyV1Mode) { }

	public override DateTime GetValidFrom() { }

	public override DateTime GetValidUntil() { }

	private string GetValueAsString(ASN1 pair) { }

	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	public override void Reset() { }

	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	public override string ToString() { }

	public override string ToString(bool verbose) { }

	public override bool Verify(X509Certificate2 thisCertificate) { }

}

