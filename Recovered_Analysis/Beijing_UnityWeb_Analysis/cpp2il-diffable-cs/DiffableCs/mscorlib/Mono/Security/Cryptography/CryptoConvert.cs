namespace Mono.Security.Cryptography;

internal sealed class CryptoConvert
{

	public static RSA FromCapiKeyBlob(byte[] blob) { }

	public static RSA FromCapiKeyBlob(byte[] blob, int offset) { }

	public static DSA FromCapiKeyBlobDSA(byte[] blob) { }

	public static DSA FromCapiKeyBlobDSA(byte[] blob, int offset) { }

	public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset) { }

	public static DSA FromCapiPrivateKeyBlobDSA(byte[] blob, int offset) { }

	public static RSA FromCapiPublicKeyBlob(byte[] blob, int offset) { }

	public static DSA FromCapiPublicKeyBlobDSA(byte[] blob, int offset) { }

	private static byte[] GetBytesLE(int val) { }

	public static byte[] ToCapiPrivateKeyBlob(RSA rsa) { }

	public static byte[] ToCapiPrivateKeyBlob(DSA dsa) { }

	public static byte[] ToCapiPublicKeyBlob(RSA rsa) { }

	public static byte[] ToCapiPublicKeyBlob(DSA dsa) { }

	private static int ToInt32LE(byte[] bytes, int offset) { }

	private static uint ToUInt32LE(byte[] bytes, int offset) { }

	private static byte[] Trim(byte[] array) { }

}

