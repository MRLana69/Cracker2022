namespace Mono.Security.Cryptography;

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
{
	protected SymmetricAlgorithm algo; //Field offset: 0x8
	protected bool encrypt; //Field offset: 0xC
	protected int BlockSizeByte; //Field offset: 0x10
	protected byte[] temp; //Field offset: 0x14
	protected byte[] temp2; //Field offset: 0x18
	private byte[] workBuff; //Field offset: 0x1C
	private byte[] workout; //Field offset: 0x20
	protected PaddingMode padmode; //Field offset: 0x24
	protected int FeedBackByte; //Field offset: 0x28
	private bool m_disposed; //Field offset: 0x2C
	protected bool lastBlock; //Field offset: 0x2D
	private RandomNumberGenerator _rng; //Field offset: 0x30

	public virtual bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public virtual bool CanTransformMultipleBlocks
	{
		 get { } //Length: 20
	}

	public virtual int InputBlockSize
	{
		 get { } //Length: 3
	}

	private bool KeepLastBlock
	{
		 get { } //Length: 6
	}

	public virtual int OutputBlockSize
	{
		 get { } //Length: 6
	}

	public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	protected virtual void CBC(byte[] input, byte[] output) { }

	protected virtual void CFB(byte[] input, byte[] output) { }

	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected virtual void CTS(byte[] input, byte[] output) { }

	protected virtual void Dispose(bool disposing) { }

	protected abstract void ECB(byte[] input, byte[] output) { }

	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected override void Finalize() { }

	public virtual bool get_CanReuseTransform() { }

	public virtual bool get_CanTransformMultipleBlocks() { }

	public virtual int get_InputBlockSize() { }

	private bool get_KeepLastBlock() { }

	public virtual int get_OutputBlockSize() { }

	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	protected virtual void OFB(byte[] input, byte[] output) { }

	private void Random(byte[] buffer, int start, int length) { }

	private void System.IDisposable.Dispose() { }

	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	protected virtual void Transform(byte[] input, byte[] output) { }

	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

