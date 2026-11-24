namespace System.Security.Cryptography;

public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable
{
	private static readonly byte[] s_Sbox; //Field offset: 0x0
	private static readonly int[] s_Rcon; //Field offset: 0x4
	private static readonly int[] s_T; //Field offset: 0x8
	private static readonly int[] s_TF; //Field offset: 0xC
	private static readonly int[] s_iT; //Field offset: 0x10
	private static readonly int[] s_iTF; //Field offset: 0x14
	private CipherMode m_cipherMode; //Field offset: 0x8
	private PaddingMode m_paddingValue; //Field offset: 0xC
	private RijndaelManagedTransformMode m_transformMode; //Field offset: 0x10
	private int m_blockSizeBits; //Field offset: 0x14
	private int m_blockSizeBytes; //Field offset: 0x18
	private int m_inputBlockSize; //Field offset: 0x1C
	private int m_outputBlockSize; //Field offset: 0x20
	private int[] m_encryptKeyExpansion; //Field offset: 0x24
	private int[] m_decryptKeyExpansion; //Field offset: 0x28
	private int m_Nr; //Field offset: 0x2C
	private int m_Nb; //Field offset: 0x30
	private int m_Nk; //Field offset: 0x34
	private int[] m_encryptindex; //Field offset: 0x38
	private int[] m_decryptindex; //Field offset: 0x3C
	private int[] m_IV; //Field offset: 0x40
	private int[] m_lastBlockBuffer; //Field offset: 0x44
	private byte[] m_depadBuffer; //Field offset: 0x48
	private byte[] m_shiftRegister; //Field offset: 0x4C

	public int BlockSizeValue
	{
		 get { } //Length: 55
	}

	public bool CanReuseTransform
	{
		 get { } //Length: 3
	}

	public bool CanTransformMultipleBlocks
	{
		 get { } //Length: 6
	}

	public int InputBlockSize
	{
		 get { } //Length: 6
	}

	public int OutputBlockSize
	{
		 get { } //Length: 6
	}

	private static RijndaelManagedTransform() { }

	internal RijndaelManagedTransform(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	internal RijndaelManagedTransform() { }

	public void Clear() { }

	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	private void GenerateKeyExpansion(byte[] rgbKey) { }

	public int get_BlockSizeValue() { }

	public bool get_CanReuseTransform() { }

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public int get_OutputBlockSize() { }

	private static int MulX(int x) { }

	public void Reset() { }

	private static int rot1(int val) { }

	private static int rot2(int val) { }

	private static int rot3(int val) { }

	private static int SubWord(int a) { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

