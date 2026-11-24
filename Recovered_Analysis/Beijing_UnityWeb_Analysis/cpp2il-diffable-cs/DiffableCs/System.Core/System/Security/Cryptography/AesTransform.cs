namespace System.Security.Cryptography;

internal class AesTransform : SymmetricTransform
{
	private static readonly uint[] Rcon; //Field offset: 0x0
	private static readonly byte[] SBox; //Field offset: 0x4
	private static readonly byte[] iSBox; //Field offset: 0x8
	private static readonly uint[] T0; //Field offset: 0xC
	private static readonly uint[] T1; //Field offset: 0x10
	private static readonly uint[] T2; //Field offset: 0x14
	private static readonly uint[] T3; //Field offset: 0x18
	private static readonly uint[] iT0; //Field offset: 0x1C
	private static readonly uint[] iT1; //Field offset: 0x20
	private static readonly uint[] iT2; //Field offset: 0x24
	private static readonly uint[] iT3; //Field offset: 0x28
	private uint[] expandedKey; //Field offset: 0x34
	private int Nk; //Field offset: 0x38
	private int Nr; //Field offset: 0x3C

	private static AesTransform() { }

	public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	protected override void ECB(byte[] input, byte[] output) { }

	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	private uint SubByte(uint a) { }

}

