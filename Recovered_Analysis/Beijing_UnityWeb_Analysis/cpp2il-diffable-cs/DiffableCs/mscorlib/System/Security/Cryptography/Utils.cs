namespace System.Security.Cryptography;

internal static class Utils
{
	internal const int DefaultRsaProviderType = 1; //Field offset: 0x0
	private static RNGCryptoServiceProvider _rng; //Field offset: 0x0

	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
	{
		 get { } //Length: 57
	}

	internal static bool _ProduceLegacyHmacValues() { }

	private static Utils() { }

	internal static bool CompareBigIntArrays(byte[] lhs, byte[] rhs) { }

	internal static int ConvertByteArrayToInt(byte[] input) { }

	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	internal static void ConvertIntToByteArray(uint dwInput, ref byte[] counter) { }

	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	internal static bool DoesRsaKeyOverride(RSA rsaKey, string methodName, Type[] parameterTypes) { }

	private static bool DoesRsaKeyOverrideSlowPath(Type t, string methodName, Type[] parameterTypes) { }

	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	internal static byte[] FixupKeyParity(byte[] key) { }

	internal static byte[] GenerateRandom(int keySize) { }

	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	internal static byte[] Int(uint i) { }

	internal static HashAlgorithmName OidToHashAlgorithmName(string oid) { }

	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	internal static byte[] RsaOaepDecrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, byte[] encryptedData) { }

	internal static byte[] RsaOaepEncrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, RandomNumberGenerator rng, byte[] data) { }

	internal static byte[] RsaPkcs1Padding(RSA rsa, byte[] oid, byte[] hash) { }

}

