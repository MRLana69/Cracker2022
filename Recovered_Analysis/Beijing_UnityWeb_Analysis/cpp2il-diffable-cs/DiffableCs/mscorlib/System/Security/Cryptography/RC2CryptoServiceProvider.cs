namespace System.Security.Cryptography;

public sealed class RC2CryptoServiceProvider : RC2
{
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x0
	private bool m_use40bitSalt; //Field offset: 0x30

	public override int EffectiveKeySize
	{
		 get { } //Length: 55
		 set { } //Length: 105
	}

	public bool UseSalt
	{
		 get { } //Length: 6
		 set { } //Length: 94
	}

	private static RC2CryptoServiceProvider() { }

	public RC2CryptoServiceProvider() { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

	public override int get_EffectiveKeySize() { }

	public bool get_UseSalt() { }

	public override void set_EffectiveKeySize(int value) { }

	public void set_UseSalt(bool value) { }

}

