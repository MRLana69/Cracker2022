namespace System.Security.Cryptography;

public class SHA1Managed : SHA1
{
	private byte[] _buffer; //Field offset: 0x18
	private long _count; //Field offset: 0x20
	private uint[] _stateSHA1; //Field offset: 0x28
	private uint[] _expandedBuffer; //Field offset: 0x2C

	private byte[] _EndHash() { }

	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	public SHA1Managed() { }

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

	private void InitializeState() { }

	private static void SHAExpand(uint* x) { }

	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

}

