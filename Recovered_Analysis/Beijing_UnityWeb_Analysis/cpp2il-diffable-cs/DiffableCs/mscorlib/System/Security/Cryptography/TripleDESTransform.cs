namespace System.Security.Cryptography;

internal class TripleDESTransform : SymmetricTransform
{
	private DESTransform E1; //Field offset: 0x34
	private DESTransform D2; //Field offset: 0x38
	private DESTransform E3; //Field offset: 0x3C
	private DESTransform D1; //Field offset: 0x40
	private DESTransform E2; //Field offset: 0x44
	private DESTransform D3; //Field offset: 0x48

	public TripleDESTransform(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	protected override void ECB(byte[] input, byte[] output) { }

	internal static byte[] GetStrongKey() { }

}

