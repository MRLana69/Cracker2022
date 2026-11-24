namespace System.Security.Cryptography;

internal class SHA1Internal
{
	private const int BLOCK_SIZE_BYTES = 64; //Field offset: 0x0
	private uint[] _H; //Field offset: 0x8
	private ulong count; //Field offset: 0x10
	private byte[] _ProcessingBuffer; //Field offset: 0x18
	private int _ProcessingBufferCount; //Field offset: 0x1C
	private uint[] buff; //Field offset: 0x20

	public SHA1Internal() { }

	internal void AddLength(ulong length, byte[] buffer, int position) { }

	private static void FillBuff(uint[] buff) { }

	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	public byte[] HashFinal() { }

	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	public void Initialize() { }

	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

