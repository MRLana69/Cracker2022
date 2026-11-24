namespace System.Security.Cryptography.X509Certificates;

public sealed class X509EnhancedKeyUsageExtension : X509Extension
{
	private OidCollection _enhKeyUsage; //Field offset: 0x14
	private AsnDecodeStatus _status; //Field offset: 0x18

	public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal AsnDecodeStatus Decode(byte[] extension) { }

	internal override string ToString(bool multiLine) { }

}

