namespace SYBO.Components.Crypt;

public class Aes128CounterMode : SymmetricAlgorithm
{
	private readonly byte[] _counter; //Field offset: 0x2C
	private readonly AesManaged _aes; //Field offset: 0x30

	public override byte[] Key
	{
		 get { } //Length: 81
		 set { } //Length: 299
	}

	public Aes128CounterMode(byte[] counter) { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] ignoredParameter) { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] ignoredParameter) { }

	public ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] ignoredParameter, int position) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

	public override byte[] get_Key() { }

	public override void set_Key(byte[] value) { }

}

