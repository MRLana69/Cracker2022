namespace System.Security.Cryptography;

internal static class CAPI
{
	internal const uint CRYPT_OID_INFO_OID_KEY = 1; //Field offset: 0x0
	internal const uint CRYPT_OID_INFO_NAME_KEY = 2; //Field offset: 0x0
	internal const uint CRYPT_OID_INFO_ALGID_KEY = 3; //Field offset: 0x0
	internal const uint CRYPT_OID_INFO_SIGN_KEY = 4; //Field offset: 0x0

	public static string CryptFindOIDInfoKeyFromName(string name, OidGroup oidGroup) { }

	public static string CryptFindOIDInfoNameFromKey(string key, OidGroup oidGroup) { }

}

