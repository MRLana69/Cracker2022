namespace System.Security.Cryptography;

public sealed class AesManaged : Aes
{
	private RijndaelManaged m_rijndael; //Field offset: 0x2C

	public override int FeedbackSize
	{
		 get { } //Length: 3
		 set { } //Length: 19
	}

	public override byte[] IV
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	public override byte[] Key
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	public override int KeySize
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	public override CipherMode Mode
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	public override PaddingMode Padding
	{
		 get { } //Length: 12
		 set { } //Length: 108
	}

	public AesManaged() { }

	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	public override ICryptoTransform CreateDecryptor() { }

	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	public override ICryptoTransform CreateEncryptor() { }

	protected override void Dispose(bool disposing) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

	public override int get_FeedbackSize() { }

	public override byte[] get_IV() { }

	public override byte[] get_Key() { }

	public override int get_KeySize() { }

	public override CipherMode get_Mode() { }

	public override PaddingMode get_Padding() { }

	public override void set_FeedbackSize(int value) { }

	public override void set_IV(byte[] value) { }

	public override void set_Key(byte[] value) { }

	public override void set_KeySize(int value) { }

	public override void set_Mode(CipherMode value) { }

	public override void set_Padding(PaddingMode value) { }

}

