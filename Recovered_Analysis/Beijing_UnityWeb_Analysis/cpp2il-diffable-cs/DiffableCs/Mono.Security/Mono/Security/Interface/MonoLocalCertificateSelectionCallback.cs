namespace Mono.Security.Interface;

public delegate MonoLocalCertificateSelectionCallback
{

	public MonoLocalCertificateSelectionCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

