namespace System.Security.Cryptography;

public sealed class MD5CryptoServiceProvider : MD5
{
	private const int BLOCK_SIZE_BYTES = 64; //Field offset: 0x0
	private static readonly uint[] K; //Field offset: 0x0
	private uint[] _H; //Field offset: 0x18
	private uint[] buff; //Field offset: 0x1C
	private ulong count; //Field offset: 0x20
	private byte[] _ProcessingBuffer; //Field offset: 0x28
	private int _ProcessingBufferCount; //Field offset: 0x2C

	private static MD5CryptoServiceProvider() { }

	public MD5CryptoServiceProvider() { }

	internal void AddLength(ulong length, byte[] buffer, int position) { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

