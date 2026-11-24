namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509CertificateImpl : IDisposable
{
	private byte[] cachedCertificateHash; //Field offset: 0x8

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	protected X509CertificateImpl() { }

	public abstract X509CertificateImpl Clone() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public override bool Equals(object obj) { }

	public abstract bool Equals(X509CertificateImpl other, out bool result) { }

	protected override void Finalize() { }

	public abstract bool get_IsValid() { }

	public byte[] GetCertHash() { }

	protected abstract byte[] GetCertHash(bool lazy) { }

	public override int GetHashCode() { }

	public abstract string GetIssuerName(bool legacyV1Mode) { }

	public abstract byte[] GetRawCertData() { }

	public abstract byte[] GetSerialNumber() { }

	public abstract string GetSubjectName(bool legacyV1Mode) { }

	public abstract DateTime GetValidFrom() { }

	public abstract DateTime GetValidUntil() { }

	protected void ThrowIfContextInvalid() { }

	public abstract string ToString(bool full) { }

}

