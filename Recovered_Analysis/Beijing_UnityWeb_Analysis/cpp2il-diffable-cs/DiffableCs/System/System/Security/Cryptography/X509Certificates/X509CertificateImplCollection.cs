namespace System.Security.Cryptography.X509Certificates;

internal class X509CertificateImplCollection : IDisposable
{
	private List<X509CertificateImpl> list; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 54
	}

	public X509CertificateImpl Item
	{
		 get { } //Length: 104
	}

	public X509CertificateImplCollection() { }

	private X509CertificateImplCollection(X509CertificateImplCollection other) { }

	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	public X509CertificateImplCollection Clone() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public int get_Count() { }

	public X509CertificateImpl get_Item(int index) { }

}

