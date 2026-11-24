namespace System.Security.Cryptography;

public abstract class DES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4

	public override byte[] Key
	{
		 get { } //Length: 3
		 set { } //Length: 2
	}

	private static DES() { }

	protected DES() { }

	public static DES Create() { }

	public static DES Create(string algName) { }

	public override byte[] get_Key() { }

	private static bool IsLegalKeySize(byte[] rgbKey) { }

	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	public static bool IsWeakKey(byte[] rgbKey) { }

	private static ulong QuadWordFromBigEndian(byte[] block) { }

	public override void set_Key(byte[] value) { }

}

