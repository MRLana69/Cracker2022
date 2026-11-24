namespace System.Security.Cryptography;

public abstract class AsymmetricKeyExchangeFormatter
{

	public abstract string Parameters
	{
		 get { } //Length: 0
	}

	protected AsymmetricKeyExchangeFormatter() { }

	public abstract byte[] CreateKeyExchange(byte[] data) { }

	public abstract byte[] CreateKeyExchange(byte[] data, Type symAlgType) { }

	public abstract string get_Parameters() { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

}

