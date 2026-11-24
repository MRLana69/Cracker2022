namespace Mono.Security.X509;

public sealed class X501
{
	private static byte[] countryName; //Field offset: 0x0
	private static byte[] organizationName; //Field offset: 0x4
	private static byte[] organizationalUnitName; //Field offset: 0x8
	private static byte[] commonName; //Field offset: 0xC
	private static byte[] localityName; //Field offset: 0x10
	private static byte[] stateOrProvinceName; //Field offset: 0x14
	private static byte[] streetAddress; //Field offset: 0x18
	private static byte[] domainComponent; //Field offset: 0x1C
	private static byte[] userid; //Field offset: 0x20
	private static byte[] email; //Field offset: 0x24
	private static byte[] dnQualifier; //Field offset: 0x28
	private static byte[] title; //Field offset: 0x2C
	private static byte[] surname; //Field offset: 0x30
	private static byte[] givenName; //Field offset: 0x34
	private static byte[] initial; //Field offset: 0x38

	private static X501() { }

	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	public static string ToString(ASN1 seq) { }

	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

}

