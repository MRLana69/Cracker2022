namespace System.Security.Cryptography;

public sealed class AesCryptoServiceProvider : Aes
{

	public override int FeedbackSize
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public override byte[] IV
	{
		 get { } //Length: 12
		 set { } //Length: 307
	}

	public override byte[] Key
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public override int KeySize
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public override CipherMode Mode
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public override PaddingMode Padding
	{
		 get { } //Length: 6
		 set { } //Length: 98
	}

	public AesCryptoServiceProvider() { }

	public override ICryptoTransform CreateDecryptor() { }

	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	public override ICryptoTransform CreateEncryptor() { }

	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

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

