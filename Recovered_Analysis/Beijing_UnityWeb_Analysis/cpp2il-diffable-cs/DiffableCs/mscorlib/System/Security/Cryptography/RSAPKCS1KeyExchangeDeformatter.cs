namespace System.Security.Cryptography;

public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
{
	private RSA _rsaKey; //Field offset: 0x8
	private Nullable<bool> _rsaOverridesDecrypt; //Field offset: 0xC
	private RandomNumberGenerator RngValue; //Field offset: 0x10

	private bool OverridesDecrypt
	{
		 get { } //Length: 3
	}

	public override string Parameters
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public RandomNumberGenerator RNG
	{
		 get { } //Length: 392
		 set { } //Length: 107
	}

	public RSAPKCS1KeyExchangeDeformatter() { }

	public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key) { }

	public override byte[] DecryptKeyExchange(byte[] rgbIn) { }

	private bool get_OverridesDecrypt() { }

	public override string get_Parameters() { }

	public RandomNumberGenerator get_RNG() { }

	public override void set_Parameters(string value) { }

	public void set_RNG(RandomNumberGenerator value) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

}

