namespace Kiloo.Common.Backend.Cloud;

public delegate CloudServerRequestCompleteHandler
{

	public CloudServerRequestCompleteHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(CloudServerResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(CloudServerResult result) { }

}

