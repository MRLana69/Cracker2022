namespace System.Security.Cryptography;

public abstract class Aes : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4

	private static Aes() { }

	protected Aes() { }

	public static Aes Create() { }

	public static Aes Create(string algorithmName) { }

}

