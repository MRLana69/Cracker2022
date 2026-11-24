namespace Mono.Security.Cryptography;

internal sealed class PKCS1
{
	private static byte[] emptySHA1; //Field offset: 0x0
	private static byte[] emptySHA256; //Field offset: 0x4
	private static byte[] emptySHA384; //Field offset: 0x8
	private static byte[] emptySHA512; //Field offset: 0xC

	private static PKCS1() { }

	private static bool Compare(byte[] array1, byte[] array2) { }

	internal static HashAlgorithm CreateFromName(string name) { }

	public static byte[] Decrypt_OAEP(RSA rsa, HashAlgorithm hash, byte[] C) { }

	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	public static byte[] Encrypt_OAEP(RSA rsa, HashAlgorithm hash, RandomNumberGenerator rng, byte[] M) { }

	private static byte[] GetEmptyHash(HashAlgorithm hash) { }

	public static byte[] I2OSP(byte[] x, int size) { }

	public static byte[] I2OSP(int x, int size) { }

	public static byte[] MGF1(HashAlgorithm hash, byte[] mgfSeed, int maskLen) { }

	public static byte[] OS2IP(byte[] x) { }

	public static byte[] RSADP(RSA rsa, byte[] c) { }

	public static byte[] RSAEP(RSA rsa, byte[] m) { }

	public static byte[] RSASP1(RSA rsa, byte[] m) { }

	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	public static byte[] Sign_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue) { }

	internal static byte[] Sign_v15(RSA rsa, string hashName, byte[] hashValue) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature) { }

	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	private static byte[] xor(byte[] array1, byte[] array2) { }

}

