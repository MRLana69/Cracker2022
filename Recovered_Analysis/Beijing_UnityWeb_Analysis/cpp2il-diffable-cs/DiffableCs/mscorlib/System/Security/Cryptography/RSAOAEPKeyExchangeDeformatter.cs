namespace System.Security.Cryptography;

public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
{
	private RSA _rsaKey; //Field offset: 0x8
	private Nullable<bool> _rsaOverridesDecrypt; //Field offset: 0xC

	private bool OverridesDecrypt
	{
		 get { } //Length: 3
	}

	public override string Parameters
	{
		 get { } //Length: 81
		 set { } //Length: 107
	}

	public RSAOAEPKeyExchangeDeformatter() { }

	public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key) { }

	public override byte[] DecryptKeyExchange(byte[] rgbData) { }

	private bool get_OverridesDecrypt() { }

	public override string get_Parameters() { }

	public override void set_Parameters(string value) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

}

