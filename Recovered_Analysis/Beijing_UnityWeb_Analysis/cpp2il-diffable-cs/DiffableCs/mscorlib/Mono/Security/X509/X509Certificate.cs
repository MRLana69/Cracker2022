namespace Mono.Security.X509;

internal class X509Certificate : ISerializable
{
	private static string encoding_error; //Field offset: 0x0
	private ASN1 decoder; //Field offset: 0x8
	private byte[] m_encodedcert; //Field offset: 0xC
	private DateTime m_from; //Field offset: 0x10
	private DateTime m_until; //Field offset: 0x18
	private ASN1 issuer; //Field offset: 0x20
	private string m_issuername; //Field offset: 0x24
	private string m_keyalgo; //Field offset: 0x28
	private byte[] m_keyalgoparams; //Field offset: 0x2C
	private ASN1 subject; //Field offset: 0x30
	private string m_subject; //Field offset: 0x34
	private byte[] m_publickey; //Field offset: 0x38
	private byte[] signature; //Field offset: 0x3C
	private string m_signaturealgo; //Field offset: 0x40
	private byte[] m_signaturealgoparams; //Field offset: 0x44
	private RSA _rsa; //Field offset: 0x48
	private DSA _dsa; //Field offset: 0x4C
	private int version; //Field offset: 0x50
	private byte[] serialnumber; //Field offset: 0x54
	private byte[] issuerUniqueID; //Field offset: 0x58
	private byte[] subjectUniqueID; //Field offset: 0x5C
	private X509ExtensionCollection extensions; //Field offset: 0x60

	public DSA DSA
	{
		 get { } //Length: 187
	}

	public virtual string IssuerName
	{
		 get { } //Length: 640
	}

	public virtual byte[] KeyAlgorithmParameters
	{
		 get { } //Length: 6
	}

	public virtual byte[] RawData
	{
		 get { } //Length: 407
	}

	public virtual RSA RSA
	{
		 get { } //Length: 67
	}

	public virtual byte[] SerialNumber
	{
		 get { } //Length: 67
	}

	public virtual string SubjectName
	{
		 get { } //Length: 67
	}

	public virtual DateTime ValidFrom
	{
		 get { } //Length: 933
	}

	public virtual DateTime ValidUntil
	{
		 get { } //Length: 6
	}

	private static X509Certificate() { }

	public X509Certificate(byte[] data) { }

	public DSA get_DSA() { }

	public virtual string get_IssuerName() { }

	public virtual byte[] get_KeyAlgorithmParameters() { }

	public virtual byte[] get_RawData() { }

	public virtual RSA get_RSA() { }

	public virtual byte[] get_SerialNumber() { }

	public virtual string get_SubjectName() { }

	public virtual DateTime get_ValidFrom() { }

	public virtual DateTime get_ValidUntil() { }

	public ASN1 GetIssuerName() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public ASN1 GetSubjectName() { }

	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	private void Parse(byte[] data) { }

	private static byte[] PEM(string type, byte[] data) { }

}

