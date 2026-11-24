namespace System.Security.Cryptography;

public class Rfc2898DeriveBytes : DeriveBytes
{
	private const int BlockSize = 20; //Field offset: 0x0
	private byte[] m_buffer; //Field offset: 0x8
	private byte[] m_salt; //Field offset: 0xC
	private HMACSHA1 m_hmacsha1; //Field offset: 0x10
	private byte[] m_password; //Field offset: 0x14
	private uint m_iterations; //Field offset: 0x18
	private uint m_block; //Field offset: 0x1C
	private int m_startIndex; //Field offset: 0x20
	private int m_endIndex; //Field offset: 0x24

	public int IterationCount
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public byte[] Salt
	{
		 get { } //Length: 6
		 set { } //Length: 115
	}

	public Rfc2898DeriveBytes(string password, int saltSize) { }

	public Rfc2898DeriveBytes(string password, int saltSize, int iterations) { }

	public Rfc2898DeriveBytes(string password, byte[] salt) { }

	public Rfc2898DeriveBytes(string password, byte[] salt, int iterations) { }

	public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations) { }

	public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV) { }

	protected override void Dispose(bool disposing) { }

	private byte[] Func() { }

	public int get_IterationCount() { }

	public byte[] get_Salt() { }

	public override byte[] GetBytes(int cb) { }

	private void Initialize() { }

	public override void Reset() { }

	public void set_IterationCount(int value) { }

	public void set_Salt(byte[] value) { }

}

