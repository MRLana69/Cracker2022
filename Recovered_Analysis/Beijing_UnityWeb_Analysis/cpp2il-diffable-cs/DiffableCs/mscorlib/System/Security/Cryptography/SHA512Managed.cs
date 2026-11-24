namespace System.Security.Cryptography;

public class SHA512Managed : SHA512
{
	private static readonly ulong[] _K; //Field offset: 0x0
	private byte[] _buffer; //Field offset: 0x18
	private ulong _count; //Field offset: 0x20
	private ulong[] _stateSHA512; //Field offset: 0x28
	private ulong[] _W; //Field offset: 0x2C

	private byte[] _EndHash() { }

	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	private static SHA512Managed() { }

	public SHA512Managed() { }

	private static ulong Ch(ulong x, ulong y, ulong z) { }

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

	private void InitializeState() { }

	private static ulong Maj(ulong x, ulong y, ulong z) { }

	private static ulong RotateRight(ulong x, int n) { }

	private static void SHA512Expand(ulong* x) { }

	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	private static ulong sigma_0(ulong x) { }

	private static ulong Sigma_0(ulong x) { }

	private static ulong sigma_1(ulong x) { }

	private static ulong Sigma_1(ulong x) { }

}

