namespace Mono.Security.Cryptography;

internal class ARC4Managed : RC4, ICryptoTransform, IDisposable
{
	private byte[] key; //Field offset: 0x2C
	private byte[] state; //Field offset: 0x30
	private byte x; //Field offset: 0x34
	private byte y; //Field offset: 0x35
	private bool m_disposed; //Field offset: 0x36

	public bool CanReuseTransform
	{
		 get { } //Length: 73
	}

	public bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public int InputBlockSize
	{
		 get { } //Length: 3
	}

	public override byte[] Key
	{
		 get { } //Length: 15
		 set { } //Length: 179
	}

	public int OutputBlockSize
	{
		 get { } //Length: 3
	}

	public ARC4Managed() { }

	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

	public bool get_CanReuseTransform() { }

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public override byte[] get_Key() { }

	public int get_OutputBlockSize() { }

	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	private void KeySetup(byte[] key) { }

	public override void set_Key(byte[] value) { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

