namespace System.Security.Cryptography;

public class PasswordDeriveBytes : DeriveBytes
{
	private int _extraCount; //Field offset: 0x8
	private int _prefix; //Field offset: 0xC
	private int _iterations; //Field offset: 0x10
	private byte[] _baseValue; //Field offset: 0x14
	private byte[] _extra; //Field offset: 0x18
	private byte[] _salt; //Field offset: 0x1C
	private string _hashName; //Field offset: 0x20
	private byte[] _password; //Field offset: 0x24
	private HashAlgorithm _hash; //Field offset: 0x28

	public string HashName
	{
		 get { } //Length: 55
		 set { } //Length: 279
	}

	public int IterationCount
	{
		 get { } //Length: 6
		 set { } //Length: 185
	}

	public byte[] Salt
	{
		 get { } //Length: 6
		 set { } //Length: 215
	}

	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt) { }

	public PasswordDeriveBytes(byte[] password, byte[] salt) { }

	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations) { }

	public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations) { }

	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams) { }

	public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams) { }

	public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams) { }

	public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams) { }

	private byte[] ComputeBaseValue() { }

	private byte[] ComputeBytes(int cb) { }

	public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV) { }

	protected override void Dispose(bool disposing) { }

	public string get_HashName() { }

	public int get_IterationCount() { }

	public byte[] get_Salt() { }

	public override byte[] GetBytes(int cb) { }

	private void HashPrefix(CryptoStream cs) { }

	public override void Reset() { }

	public void set_HashName(string value) { }

	public void set_IterationCount(int value) { }

	public void set_Salt(byte[] value) { }

}

