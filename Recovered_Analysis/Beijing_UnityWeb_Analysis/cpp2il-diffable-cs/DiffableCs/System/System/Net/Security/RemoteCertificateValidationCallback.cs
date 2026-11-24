namespace System.Net.Security;

public delegate RemoteCertificateValidationCallback
{

	public RemoteCertificateValidationCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

