namespace Mono.Security.Cryptography;

internal abstract class RC4 : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4

	public override byte[] IV
	{
		 get { } //Length: 6
		 set { } //Length: 629
	}

	private static RC4() { }

	public RC4() { }

	public static RC4 Create() { }

	public override byte[] get_IV() { }

	public override void set_IV(byte[] value) { }

}

