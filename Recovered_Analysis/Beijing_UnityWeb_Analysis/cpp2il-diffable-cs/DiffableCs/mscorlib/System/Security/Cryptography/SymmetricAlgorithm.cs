namespace System.Security.Cryptography;

public abstract class SymmetricAlgorithm : IDisposable
{
	protected int BlockSizeValue; //Field offset: 0x8
	protected int FeedbackSizeValue; //Field offset: 0xC
	protected byte[] IVValue; //Field offset: 0x10
	protected byte[] KeyValue; //Field offset: 0x14
	protected KeySizes[] LegalBlockSizesValue; //Field offset: 0x18
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x1C
	protected int KeySizeValue; //Field offset: 0x20
	protected CipherMode ModeValue; //Field offset: 0x24
	protected PaddingMode PaddingValue; //Field offset: 0x28

	public virtual int BlockSize
	{
		 get { } //Length: 58
		 set { } //Length: 84
	}

	public virtual int FeedbackSize
	{
		 get { } //Length: 6
		 set { } //Length: 289
	}

	public virtual byte[] IV
	{
		 get { } //Length: 6
		 set { } //Length: 117
	}

	public virtual byte[] Key
	{
		 get { } //Length: 73
		 set { } //Length: 177
	}

	public virtual int KeySize
	{
		 get { } //Length: 56
		 set { } //Length: 197
	}

	public virtual KeySizes[] LegalBlockSizes
	{
		 get { } //Length: 73
	}

	public virtual KeySizes[] LegalKeySizes
	{
		 get { } //Length: 56
	}

	public virtual CipherMode Mode
	{
		 get { } //Length: 6
		 set { } //Length: 114
	}

	public virtual PaddingMode Padding
	{
		 get { } //Length: 6
		 set { } //Length: 102
	}

	protected SymmetricAlgorithm() { }

	public void Clear() { }

	public static SymmetricAlgorithm Create(string algName) { }

	public static SymmetricAlgorithm Create() { }

	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual ICryptoTransform CreateDecryptor() { }

	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract void GenerateIV() { }

	public abstract void GenerateKey() { }

	public virtual int get_BlockSize() { }

	public virtual int get_FeedbackSize() { }

	public virtual byte[] get_IV() { }

	public virtual byte[] get_Key() { }

	public virtual int get_KeySize() { }

	public virtual KeySizes[] get_LegalBlockSizes() { }

	public virtual KeySizes[] get_LegalKeySizes() { }

	public virtual CipherMode get_Mode() { }

	public virtual PaddingMode get_Padding() { }

	public virtual void set_BlockSize(int value) { }

	public virtual void set_FeedbackSize(int value) { }

	public virtual void set_IV(byte[] value) { }

	public virtual void set_Key(byte[] value) { }

	public virtual void set_KeySize(int value) { }

	public virtual void set_Mode(CipherMode value) { }

	public virtual void set_Padding(PaddingMode value) { }

	public bool ValidKeySize(int bitLength) { }

}

