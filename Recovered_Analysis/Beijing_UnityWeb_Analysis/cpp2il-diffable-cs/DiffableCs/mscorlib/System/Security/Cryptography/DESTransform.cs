namespace System.Security.Cryptography;

internal class DESTransform : SymmetricTransform
{
	internal static readonly int KEY_BIT_SIZE; //Field offset: 0x0
	internal static readonly int KEY_BYTE_SIZE; //Field offset: 0x4
	internal static readonly int BLOCK_BIT_SIZE; //Field offset: 0x8
	internal static readonly int BLOCK_BYTE_SIZE; //Field offset: 0xC
	private static readonly uint[] spBoxes; //Field offset: 0x10
	private static readonly byte[] PC1; //Field offset: 0x14
	private static readonly byte[] leftRotTotal; //Field offset: 0x18
	private static readonly byte[] PC2; //Field offset: 0x1C
	internal static readonly uint[] ipTab; //Field offset: 0x20
	internal static readonly uint[] fpTab; //Field offset: 0x24
	private byte[] keySchedule; //Field offset: 0x34
	private byte[] byteBuff; //Field offset: 0x38
	private uint[] dwordBuff; //Field offset: 0x3C

	private static DESTransform() { }

	internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	private static void BSwap(byte[] byteBuff) { }

	private uint CipherFunct(uint r, int n) { }

	protected override void ECB(byte[] input, byte[] output) { }

	internal static byte[] GetStrongKey() { }

	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	public void ProcessBlock(byte[] input, byte[] output) { }

	internal void SetKey(byte[] key) { }

}

