namespace System.Security.Cryptography;

public abstract class TripleDES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x4

	public override byte[] Key
	{
		 get { } //Length: 25
		 set { } //Length: 102
	}

	private static TripleDES() { }

	protected TripleDES() { }

	public static TripleDES Create() { }

	public static TripleDES Create(string str) { }

	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	public override byte[] get_Key() { }

	private static bool IsLegalKeySize(byte[] rgbKey) { }

	public static bool IsWeakKey(byte[] rgbKey) { }

	public override void set_Key(byte[] value) { }

}

