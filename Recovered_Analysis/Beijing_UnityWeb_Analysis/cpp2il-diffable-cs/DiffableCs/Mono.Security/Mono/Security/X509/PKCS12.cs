namespace Mono.Security.X509;

public class PKCS12 : ICloneable
{
	public class DeriveBytes
	{
		private static byte[] keyDiversifier; //Field offset: 0x0
		private static byte[] ivDiversifier; //Field offset: 0x4
		private static byte[] macDiversifier; //Field offset: 0x8
		private string _hashName; //Field offset: 0x8
		private int _iterations; //Field offset: 0xC
		private byte[] _password; //Field offset: 0x10
		private byte[] _salt; //Field offset: 0x14

		public string HashName
		{
			 set { } //Length: 13
		}

		public int IterationCount
		{
			 set { } //Length: 11
		}

		public byte[] Password
		{
			 set { } //Length: 8
		}

		public byte[] Salt
		{
			 set { } //Length: 89
		}

		private static DeriveBytes() { }

		public DeriveBytes() { }

		private void Adjust(byte[] a, int aOff, byte[] b) { }

		private byte[] Derive(byte[] diversifier, int n) { }

		public byte[] DeriveIV(int size) { }

		public byte[] DeriveKey(int size) { }

		public byte[] DeriveMAC(int size) { }

		public void set_HashName(string value) { }

		public void set_IterationCount(int value) { }

		public void set_Password(byte[] value) { }

		public void set_Salt(byte[] value) { }

	}

	private static int password_max_length; //Field offset: 0x0
	private byte[] _password; //Field offset: 0x8
	private ArrayList _keyBags; //Field offset: 0xC
	private ArrayList _secretBags; //Field offset: 0x10
	private X509CertificateCollection _certs; //Field offset: 0x14
	private bool _keyBagsChanged; //Field offset: 0x18
	private bool _secretBagsChanged; //Field offset: 0x19
	private bool _certsChanged; //Field offset: 0x1A
	private int _iterations; //Field offset: 0x1C
	private ArrayList _safeBags; //Field offset: 0x20
	private RandomNumberGenerator _rng; //Field offset: 0x24

	public X509CertificateCollection Certificates
	{
		 get { } //Length: 2126
	}

	public int IterationCount
	{
		 get { } //Length: 6
		 set { } //Length: 296
	}

	public ArrayList Keys
	{
		 get { } //Length: 6
	}

	public static int MaximumPasswordLength
	{
		 get { } //Length: 91
	}

	public string Password
	{
		 set { } //Length: 1265
	}

	internal RandomNumberGenerator RNG
	{
		 get { } //Length: 955
	}

	private static PKCS12() { }

	public PKCS12(byte[] data, string password) { }

	public PKCS12() { }

	public PKCS12(byte[] data) { }

	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	public void AddCertificate(X509Certificate cert) { }

	private void AddPrivateKey(PrivateKeyInfo pki) { }

	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	public object Clone() { }

	private bool Compare(byte[] expected, byte[] actual) { }

	private void Decode(byte[] data) { }

	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	public byte[] Decrypt(EncryptedData ed) { }

	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	private ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	protected override void Finalize() { }

	public X509CertificateCollection get_Certificates() { }

	public int get_IterationCount() { }

	public ArrayList get_Keys() { }

	public static int get_MaximumPasswordLength() { }

	internal RandomNumberGenerator get_RNG() { }

	public byte[] GetBytes() { }

	private DSAParameters GetExistingParameters(out bool found) { }

	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	private void ReadSafeBag(ASN1 safeBag) { }

	public void RemoveCertificate(X509Certificate cert) { }

	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	public void set_IterationCount(int value) { }

	public void set_Password(string value) { }

}

