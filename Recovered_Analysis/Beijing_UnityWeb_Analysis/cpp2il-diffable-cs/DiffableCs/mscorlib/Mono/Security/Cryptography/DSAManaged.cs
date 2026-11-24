namespace Mono.Security.Cryptography;

internal class DSAManaged : DSA
{
	public delegate KeyGeneratedEventHandler
	{

		public KeyGeneratedEventHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(object sender, EventArgs e) { }

	}

	private bool keypairGenerated; //Field offset: 0x10
	private bool m_disposed; //Field offset: 0x11
	private BigInteger p; //Field offset: 0x14
	private BigInteger q; //Field offset: 0x18
	private BigInteger g; //Field offset: 0x1C
	private BigInteger x; //Field offset: 0x20
	private BigInteger y; //Field offset: 0x24
	private BigInteger j; //Field offset: 0x28
	private BigInteger seed; //Field offset: 0x2C
	private int counter; //Field offset: 0x30
	private bool j_missing; //Field offset: 0x34
	private RandomNumberGenerator rng; //Field offset: 0x38
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x3C

	public event KeyGeneratedEventHandler KeyGenerated
	{
		 add { } //Length: 567
		 remove { } //Length: 111
	}

	public override string KeyExchangeAlgorithm
	{
		 get { } //Length: 26
	}

	public override int KeySize
	{
		 get { } //Length: 29
	}

	public bool PublicOnly
	{
		 get { } //Length: 3
	}

	private RandomNumberGenerator Random
	{
		 get { } //Length: 34
	}

	public override string SignatureAlgorithm
	{
		 get { } //Length: 95
	}

	public DSAManaged(int dwKeySize) { }

	private void add(byte[] a, byte[] b, int value) { }

	public void add_KeyGenerated(KeyGeneratedEventHandler value) { }

	public override byte[] CreateSignature(byte[] rgbHash) { }

	protected override void Dispose(bool disposing) { }

	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	protected override void Finalize() { }

	private void Generate() { }

	private void GenerateKeyPair() { }

	private void GenerateParams(int keyLength) { }

	public override string get_KeyExchangeAlgorithm() { }

	public override int get_KeySize() { }

	public bool get_PublicOnly() { }

	private RandomNumberGenerator get_Random() { }

	public override string get_SignatureAlgorithm() { }

	public override void ImportParameters(DSAParameters parameters) { }

	private byte[] NormalizeArray(byte[] array) { }

	public void remove_KeyGenerated(KeyGeneratedEventHandler value) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

