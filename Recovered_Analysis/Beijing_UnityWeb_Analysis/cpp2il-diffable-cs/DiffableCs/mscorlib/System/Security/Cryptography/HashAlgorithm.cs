namespace System.Security.Cryptography;

public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	protected int HashSizeValue; //Field offset: 0x8
	protected internal byte[] HashValue; //Field offset: 0xC
	protected int State; //Field offset: 0x10
	private bool m_bDisposed; //Field offset: 0x14

	public virtual bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public virtual bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public virtual byte[] Hash
	{
		 get { } //Length: 6
	}

	public virtual int HashSize
	{
		 get { } //Length: 55
	}

	public virtual int InputBlockSize
	{
		 get { } //Length: 55
	}

	public virtual int OutputBlockSize
	{
		 get { } //Length: 3
	}

	protected HashAlgorithm() { }

	public void Clear() { }

	public byte[] ComputeHash(Stream inputStream) { }

	public byte[] ComputeHash(byte[] buffer) { }

	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	public static HashAlgorithm Create() { }

	public static HashAlgorithm Create(string hashName) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public virtual bool get_CanReuseTransform() { }

	public virtual bool get_CanTransformMultipleBlocks() { }

	public virtual byte[] get_Hash() { }

	public virtual int get_HashSize() { }

	public virtual int get_InputBlockSize() { }

	public virtual int get_OutputBlockSize() { }

	protected abstract void HashCore(byte[] array, int ibStart, int cbSize) { }

	protected abstract byte[] HashFinal() { }

	public abstract void Initialize() { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

