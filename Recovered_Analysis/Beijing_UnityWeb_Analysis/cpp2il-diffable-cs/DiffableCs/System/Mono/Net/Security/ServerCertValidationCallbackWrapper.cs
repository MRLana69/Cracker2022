namespace Mono.Net.Security;

internal delegate ServerCertValidationCallbackWrapper
{

	public ServerCertValidationCallbackWrapper(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

	public virtual bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

