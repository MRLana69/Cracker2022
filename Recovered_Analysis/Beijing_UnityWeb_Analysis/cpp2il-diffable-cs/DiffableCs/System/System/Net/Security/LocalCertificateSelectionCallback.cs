namespace System.Net.Security;

public delegate LocalCertificateSelectionCallback
{

	public LocalCertificateSelectionCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

