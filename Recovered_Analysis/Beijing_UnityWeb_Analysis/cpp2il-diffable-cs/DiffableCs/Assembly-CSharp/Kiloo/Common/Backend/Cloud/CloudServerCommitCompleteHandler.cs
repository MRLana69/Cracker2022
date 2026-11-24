namespace Kiloo.Common.Backend.Cloud;

public delegate CloudServerCommitCompleteHandler
{

	public CloudServerCommitCompleteHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(CloudServerCommitResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(CloudServerCommitResult result) { }

}

