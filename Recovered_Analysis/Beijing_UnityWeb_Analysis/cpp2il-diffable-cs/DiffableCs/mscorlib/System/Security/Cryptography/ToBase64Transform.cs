namespace System.Security.Cryptography;

public class ToBase64Transform : ICryptoTransform, IDisposable
{

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
		 get { } //Length: 55
	}

	public int OutputBlockSize
	{
		 get { } //Length: 3
	}

	public ToBase64Transform() { }

	public void Clear() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public virtual bool get_CanReuseTransform() { }

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public int get_OutputBlockSize() { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

