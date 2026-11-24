namespace System.Security.Cryptography;

public abstract class HMAC : KeyedHashAlgorithm
{
	private int blockSizeValue; //Field offset: 0x1C
	internal string m_hashName; //Field offset: 0x20
	internal HashAlgorithm m_hash1; //Field offset: 0x24
	internal HashAlgorithm m_hash2; //Field offset: 0x28
	private byte[] m_inner; //Field offset: 0x2C
	private byte[] m_outer; //Field offset: 0x30
	private bool m_hashing; //Field offset: 0x34

	protected int BlockSizeValue
	{
		 get { } //Length: 3
		 set { } //Length: 52
	}

	public string HashName
	{
		 get { } //Length: 56
		 set { } //Length: 102
	}

	public override byte[] Key
	{
		 get { } //Length: 6
		 set { } //Length: 125
	}

	protected HMAC() { }

	public static HMAC Create() { }

	public static HMAC Create(string algorithmName) { }

	protected override void Dispose(bool disposing) { }

	protected int get_BlockSizeValue() { }

	public string get_HashName() { }

	public override byte[] get_Key() { }

	internal static HashAlgorithm GetHashAlgorithmWithFipsFallback(Func<HashAlgorithm> createStandardHashAlgorithmCallback, Func<HashAlgorithm> createFipsHashAlgorithmCallback) { }

	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

	internal void InitializeKey(byte[] key) { }

	protected void set_BlockSizeValue(int value) { }

	public void set_HashName(string value) { }

	public override void set_Key(byte[] value) { }

	private void UpdateIOPadBuffers() { }

}

