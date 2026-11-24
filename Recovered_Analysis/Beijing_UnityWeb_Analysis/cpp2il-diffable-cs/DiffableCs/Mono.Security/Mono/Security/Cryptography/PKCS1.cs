namespace Mono.Security.Cryptography;

public sealed class PKCS1
{
	private static byte[] emptySHA1; //Field offset: 0x0
	private static byte[] emptySHA256; //Field offset: 0x4
	private static byte[] emptySHA384; //Field offset: 0x8
	private static byte[] emptySHA512; //Field offset: 0xC

	private static PKCS1() { }

	internal static HashAlgorithm CreateFromName(string name) { }

	internal static HashAlgorithm CreateFromOid(string oid) { }

	internal static string HashNameFromOid(string oid, bool throwOnError = true) { }

}

