namespace System.Security.Cryptography;

public abstract class AsymmetricAlgorithm : IDisposable
{
	protected int KeySizeValue; //Field offset: 0x8
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0xC

	public virtual string KeyExchangeAlgorithm
	{
		 get { } //Length: 73
	}

	public virtual int KeySize
	{
		 get { } //Length: 108
		 set { } //Length: 2
	}

	public virtual KeySizes[] LegalKeySizes
	{
		 get { } //Length: 6
	}

	public virtual string SignatureAlgorithm
	{
		 get { } //Length: 56
	}

	protected AsymmetricAlgorithm() { }

	public void Clear() { }

	public static AsymmetricAlgorithm Create() { }

	public static AsymmetricAlgorithm Create(string algName) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void FromXmlString(string xmlString) { }

	public virtual string get_KeyExchangeAlgorithm() { }

	public virtual int get_KeySize() { }

	public virtual KeySizes[] get_LegalKeySizes() { }

	public virtual string get_SignatureAlgorithm() { }

	public virtual void set_KeySize(int value) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

}

