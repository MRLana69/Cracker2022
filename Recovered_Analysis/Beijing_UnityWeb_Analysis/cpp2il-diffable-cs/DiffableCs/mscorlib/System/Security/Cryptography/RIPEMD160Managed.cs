namespace System.Security.Cryptography;

public class RIPEMD160Managed : RIPEMD160
{
	private byte[] _buffer; //Field offset: 0x18
	private long _count; //Field offset: 0x20
	private uint[] _stateMD160; //Field offset: 0x28
	private uint[] _blockDWords; //Field offset: 0x2C

	private byte[] _EndHash() { }

	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	public RIPEMD160Managed() { }

	private static uint F(uint x, uint y, uint z) { }

	private static uint G(uint x, uint y, uint z) { }

	private static uint H(uint x, uint y, uint z) { }

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	private static uint I(uint x, uint y, uint z) { }

	public override void Initialize() { }

	private void InitializeState() { }

	private static uint J(uint x, uint y, uint z) { }

	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

}

