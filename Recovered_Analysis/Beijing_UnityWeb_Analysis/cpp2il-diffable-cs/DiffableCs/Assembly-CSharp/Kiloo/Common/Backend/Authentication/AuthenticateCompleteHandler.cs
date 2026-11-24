namespace Kiloo.Common.Backend.Authentication;

public delegate AuthenticateCompleteHandler
{

	public AuthenticateCompleteHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(bool success, Error error, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(bool success, Error error) { }

}

