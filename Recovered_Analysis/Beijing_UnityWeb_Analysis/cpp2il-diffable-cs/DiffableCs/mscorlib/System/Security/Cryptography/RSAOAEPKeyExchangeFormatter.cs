namespace System.Security.Cryptography;

public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
{
	private byte[] ParameterValue; //Field offset: 0x8
	private RSA _rsaKey; //Field offset: 0xC
	private Nullable<bool> _rsaOverridesEncrypt; //Field offset: 0x10
	private RandomNumberGenerator RngValue; //Field offset: 0x14

	private bool OverridesEncrypt
	{
		 get { } //Length: 6
	}

	public byte[] Parameter
	{
		 get { } //Length: 392
		 set { } //Length: 107
	}

	public override string Parameters
	{
		 get { } //Length: 67
	}

	public RandomNumberGenerator Rng
	{
		 get { } //Length: 3
		 set { } //Length: 77
	}

	public RSAOAEPKeyExchangeFormatter() { }

	public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key) { }

	public override byte[] CreateKeyExchange(byte[] rgbData) { }

	public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType) { }

	private bool get_OverridesEncrypt() { }

	public byte[] get_Parameter() { }

	public override string get_Parameters() { }

	public RandomNumberGenerator get_Rng() { }

	public void set_Parameter(byte[] value) { }

	public void set_Rng(RandomNumberGenerator value) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

}

