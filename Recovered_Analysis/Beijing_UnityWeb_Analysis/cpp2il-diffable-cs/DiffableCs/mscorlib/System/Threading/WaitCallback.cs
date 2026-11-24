namespace System.Threading;

public delegate WaitCallback
{

	public WaitCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object state) { }

}

