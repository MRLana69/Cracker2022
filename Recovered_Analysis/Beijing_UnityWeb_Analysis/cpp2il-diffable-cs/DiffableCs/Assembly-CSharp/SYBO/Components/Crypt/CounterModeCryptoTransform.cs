namespace SYBO.Components.Crypt;

public class CounterModeCryptoTransform : ICryptoTransform, IDisposable
{
	private readonly byte[] _counter; //Field offset: 0x8
	private readonly ICryptoTransform _counterEncryptor; //Field offset: 0xC
	private readonly Queue<byte> _xorMask; //Field offset: 0x10
	private readonly SymmetricAlgorithm _symmetricAlgorithm; //Field offset: 0x14
	private byte[] _counterModeBlock; //Field offset: 0x18
	private readonly byte[] _empty; //Field offset: 0x1C

	public bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public int InputBlockSize
	{
		 get { } //Length: 53
	}

	public int OutputBlockSize
	{
		 get { } //Length: 3
	}

	public CounterModeCryptoTransform(SymmetricAlgorithm symmetricAlgorithm, byte[] key, byte[] counter) { }

	public void Dispose() { }

	private void EncryptCounterThenIncrement() { }

	public bool get_CanReuseTransform() { }

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public int get_OutputBlockSize() { }

	private void IncrementCounter() { }

	private bool NeedMoreXorMaskBytes() { }

	public void Seek(long distance) { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

