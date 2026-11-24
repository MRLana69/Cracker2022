namespace System.Security.Cryptography.X509Certificates;

public sealed class X500DistinguishedName : AsnEncodedData
{
	private string name; //Field offset: 0x10
	private byte[] canonEncoding; //Field offset: 0x14

	public X500DistinguishedName(byte[] encodedDistinguishedName) { }

	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

	private static string Canonize(string s) { }

	public string Decode(X500DistinguishedNameFlags flag) { }

	private void DecodeRawData() { }

	public override string Format(bool multiLine) { }

	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

}

