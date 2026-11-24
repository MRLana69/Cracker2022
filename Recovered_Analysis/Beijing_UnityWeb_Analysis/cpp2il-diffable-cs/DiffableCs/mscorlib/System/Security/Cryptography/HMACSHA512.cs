namespace System.Security.Cryptography;

public class HMACSHA512 : HMAC
{
	private bool m_useLegacyBlockSize; //Field offset: 0x35

	private int BlockSize
	{
		 get { } //Length: 9
	}

	public bool ProduceLegacyHmacValues
	{
		 get { } //Length: 16
		 set { } //Length: 200
	}

	public HMACSHA512() { }

	public HMACSHA512(byte[] key) { }

	private int get_BlockSize() { }

	public bool get_ProduceLegacyHmacValues() { }

	public void set_ProduceLegacyHmacValues(bool value) { }

}

