namespace System.Security.Cryptography;

public class MACTripleDES : KeyedHashAlgorithm
{
	private const int m_bitsPerByte = 8; //Field offset: 0x0
	private ICryptoTransform m_encryptor; //Field offset: 0x1C
	private CryptoStream _cs; //Field offset: 0x20
	private TailStream _ts; //Field offset: 0x24
	private int m_bytesPerBlock; //Field offset: 0x28
	private TripleDES des; //Field offset: 0x2C

	public PaddingMode Padding
	{
		 get { } //Length: 55
		 set { } //Length: 53
	}

	public MACTripleDES() { }

	public MACTripleDES(byte[] rgbKey) { }

	public MACTripleDES(string strTripleDES, byte[] rgbKey) { }

	protected override void Dispose(bool disposing) { }

	public PaddingMode get_Padding() { }

	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

	public void set_Padding(PaddingMode value) { }

}

