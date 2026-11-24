namespace System.Security.Cryptography.X509Certificates;

public class X509Certificate2 : X509Certificate
{
	private static byte[] signedData; //Field offset: 0x0
	private string friendlyName; //Field offset: 0x18

	public X509ExtensionCollection Extensions
	{
		 get { } //Length: 65
	}

	internal X509Certificate2Impl Impl
	{
		 get { } //Length: 243
	}

	public X500DistinguishedName IssuerName
	{
		 get { } //Length: 15
	}

	internal X509Certificate MonoCertificate
	{
		 get { } //Length: 17
	}

	public DateTime NotAfter
	{
		 get { } //Length: 105
	}

	public DateTime NotBefore
	{
		 get { } //Length: 43
	}

	public AsymmetricAlgorithm PrivateKey
	{
		 get { } //Length: 15
		 set { } //Length: 75
	}

	public PublicKey PublicKey
	{
		 get { } //Length: 15
	}

	public string SerialNumber
	{
		 get { } //Length: 15
	}

	public Oid SignatureAlgorithm
	{
		 get { } //Length: 9
	}

	public X500DistinguishedName SubjectName
	{
		 get { } //Length: 15
	}

	public string Thumbprint
	{
		 get { } //Length: 15
	}

	public int Version
	{
		 get { } //Length: 9
	}

	private static X509Certificate2() { }

	public X509Certificate2() { }

	public X509Certificate2(byte[] rawData) { }

	public X509Certificate2(X509Certificate certificate) { }

	protected X509Certificate2(SerializationInfo info, StreamingContext context) { }

	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	public X509ExtensionCollection get_Extensions() { }

	internal X509Certificate2Impl get_Impl() { }

	public X500DistinguishedName get_IssuerName() { }

	internal X509Certificate get_MonoCertificate() { }

	public DateTime get_NotAfter() { }

	public DateTime get_NotBefore() { }

	public AsymmetricAlgorithm get_PrivateKey() { }

	public PublicKey get_PublicKey() { }

	public string get_SerialNumber() { }

	public Oid get_SignatureAlgorithm() { }

	public X500DistinguishedName get_SubjectName() { }

	public string get_Thumbprint() { }

	public int get_Version() { }

	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	public override void Import(byte[] rawData) { }

	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	public override void Reset() { }

	public void set_PrivateKey(AsymmetricAlgorithm value) { }

	public override string ToString() { }

	public override string ToString(bool verbose) { }

	public bool Verify() { }

}

