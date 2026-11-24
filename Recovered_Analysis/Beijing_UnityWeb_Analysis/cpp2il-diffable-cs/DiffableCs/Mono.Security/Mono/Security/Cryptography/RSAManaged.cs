namespace Mono.Security.Cryptography;

public class RSAManaged : RSA
{
	public delegate KeyGeneratedEventHandler
	{

		public KeyGeneratedEventHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(object sender, EventArgs e) { }

	}

	private bool isCRTpossible; //Field offset: 0x10
	private bool keyBlinding; //Field offset: 0x11
	private bool keypairGenerated; //Field offset: 0x12
	private bool m_disposed; //Field offset: 0x13
	private BigInteger d; //Field offset: 0x14
	private BigInteger p; //Field offset: 0x18
	private BigInteger q; //Field offset: 0x1C
	private BigInteger dp; //Field offset: 0x20
	private BigInteger dq; //Field offset: 0x24
	private BigInteger qInv; //Field offset: 0x28
	private BigInteger n; //Field offset: 0x2C
	private BigInteger e; //Field offset: 0x30
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x34

	public override string KeyExchangeAlgorithm
	{
		 get { } //Length: 140
	}

	public override int KeySize
	{
		 get { } //Length: 6
	}

	public bool PublicOnly
	{
		 get { } //Length: 43
	}

	public override string SignatureAlgorithm
	{
		 get { } //Length: 150
	}

	public override byte[] DecryptValue(byte[] rgb) { }

	protected override void Dispose(bool disposing) { }

	public override byte[] EncryptValue(byte[] rgb) { }

	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	protected override void Finalize() { }

	private void GenerateKeyPair() { }

	public override string get_KeyExchangeAlgorithm() { }

	public override int get_KeySize() { }

	public bool get_PublicOnly() { }

	public override string get_SignatureAlgorithm() { }

	private byte[] GetPaddedValue(BigInteger value, int length) { }

	public override void ImportParameters(RSAParameters parameters) { }

	public override string ToXmlString(bool includePrivateParameters) { }

}

