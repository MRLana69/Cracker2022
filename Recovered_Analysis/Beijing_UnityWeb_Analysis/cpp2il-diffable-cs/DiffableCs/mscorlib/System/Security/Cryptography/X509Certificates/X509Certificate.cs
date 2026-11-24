namespace System.Security.Cryptography.X509Certificates;

public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable
{
	private X509CertificateImpl impl; //Field offset: 0x8
	private bool hideDates; //Field offset: 0xC
	private string issuer_name; //Field offset: 0x10
	private string subject_name; //Field offset: 0x14

	internal X509CertificateImpl Impl
	{
		 get { } //Length: 19
	}

	public string Issuer
	{
		 get { } //Length: 9
	}

	internal bool IsValid
	{
		 get { } //Length: 17
	}

	public string Subject
	{
		 get { } //Length: 47
	}

	internal X509Certificate(byte[] data, bool dates) { }

	public X509Certificate(byte[] data) { }

	internal X509Certificate(X509CertificateImpl impl) { }

	public X509Certificate(X509Certificate cert) { }

	public X509Certificate() { }

	public X509Certificate(SerializationInfo info, StreamingContext context) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual bool Equals(X509Certificate other) { }

	public override bool Equals(object obj) { }

	internal X509CertificateImpl get_Impl() { }

	public string get_Issuer() { }

	internal bool get_IsValid() { }

	public string get_Subject() { }

	public virtual byte[] GetCertHash() { }

	public virtual string GetCertHashString() { }

	public override int GetHashCode() { }

	public virtual byte[] GetRawCertData() { }

	public virtual byte[] GetSerialNumber() { }

	public virtual string GetSerialNumberString() { }

	public virtual void Import(byte[] rawData) { }

	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	internal void ImportHandle(X509CertificateImpl impl) { }

	public virtual void Reset() { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString() { }

	public virtual string ToString(bool fVerbose) { }

}

