namespace System.Security.Cryptography;

public abstract class KeyedHashAlgorithm : HashAlgorithm
{
	protected byte[] KeyValue; //Field offset: 0x18

	public virtual byte[] Key
	{
		 get { } //Length: 9
		 set { } //Length: 55
	}

	protected KeyedHashAlgorithm() { }

	public static KeyedHashAlgorithm Create() { }

	public static KeyedHashAlgorithm Create(string algName) { }

	protected override void Dispose(bool disposing) { }

	public virtual byte[] get_Key() { }

	public virtual void set_Key(byte[] value) { }

}

