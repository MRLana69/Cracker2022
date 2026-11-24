namespace System.Security.Cryptography;

public sealed class CryptoAPITransform : ICryptoTransform, IDisposable
{
	private bool m_disposed; //Field offset: 0x8

	public bool CanReuseTransform
	{
		 get { } //Length: 190
	}

	public bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public int InputBlockSize
	{
		 get { } //Length: 3
	}

	public nint KeyHandle
	{
		 get { } //Length: 3
	}

	public int OutputBlockSize
	{
		 get { } //Length: 37
	}

	internal CryptoAPITransform() { }

	public void Clear() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	public bool get_CanReuseTransform() { }

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public nint get_KeyHandle() { }

	public int get_OutputBlockSize() { }

	public void Reset() { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

