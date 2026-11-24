namespace Mono.Security.Interface;

public delegate MonoRemoteCertificateValidationCallback
{

	public MonoRemoteCertificateValidationCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

