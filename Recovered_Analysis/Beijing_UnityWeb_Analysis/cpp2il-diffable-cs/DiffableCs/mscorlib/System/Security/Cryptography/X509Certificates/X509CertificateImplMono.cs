namespace System.Security.Cryptography.X509Certificates;

internal sealed class X509CertificateImplMono : X509CertificateImpl
{
	private X509Certificate x509; //Field offset: 0xC

	public override bool IsValid
	{
		 get { } //Length: 126
	}

	public X509CertificateImplMono(X509Certificate x509) { }

	public override X509CertificateImpl Clone() { }

	protected override void Dispose(bool disposing) { }

	public override bool Equals(X509CertificateImpl other, out bool result) { }

	public override bool get_IsValid() { }

	protected override byte[] GetCertHash(bool lazy) { }

	public override string GetIssuerName(bool legacyV1Mode) { }

	public override byte[] GetRawCertData() { }

	public override byte[] GetSerialNumber() { }

	public override string GetSubjectName(bool legacyV1Mode) { }

	public override DateTime GetValidFrom() { }

	public override DateTime GetValidUntil() { }

	public override string ToString(bool full) { }

}

