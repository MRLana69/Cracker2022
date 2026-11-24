namespace System.Security.Cryptography;

public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
{
	private RandomNumberGenerator RngValue; //Field offset: 0x8
	private RSA _rsaKey; //Field offset: 0xC
	private Nullable<bool> _rsaOverridesEncrypt; //Field offset: 0x10

	private bool OverridesEncrypt
	{
		 get { } //Length: 6
	}

	public override string Parameters
	{
		 get { } //Length: 392
	}

	public RandomNumberGenerator Rng
	{
		 get { } //Length: 43
		 set { } //Length: 107
	}

	public RSAPKCS1KeyExchangeFormatter() { }

	public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key) { }

	public override byte[] CreateKeyExchange(byte[] rgbData) { }

	public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType) { }

	private bool get_OverridesEncrypt() { }

	public override string get_Parameters() { }

	public RandomNumberGenerator get_Rng() { }

	public void set_Rng(RandomNumberGenerator value) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

}

