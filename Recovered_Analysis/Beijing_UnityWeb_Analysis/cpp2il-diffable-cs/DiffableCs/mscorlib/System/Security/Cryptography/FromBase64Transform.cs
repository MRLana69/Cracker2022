namespace System.Security.Cryptography;

public class FromBase64Transform : ICryptoTransform, IDisposable
{
	private byte[] _inputBuffer; //Field offset: 0x8
	private int _inputIndex; //Field offset: 0xC
	private FromBase64TransformMode _whitespaces; //Field offset: 0x10

	public virtual bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public int InputBlockSize
	{
		 get { } //Length: 3
	}

	public int OutputBlockSize
	{
		 get { } //Length: 3
	}

	public FromBase64Transform() { }

	public FromBase64Transform(FromBase64TransformMode whitespaces) { }

	public void Clear() { }

	private byte[] DiscardWhiteSpaces(byte[] inputBuffer, int inputOffset, int inputCount) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public virtual bool get_CanReuseTransform() { }

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public int get_OutputBlockSize() { }

	private void Reset() { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

