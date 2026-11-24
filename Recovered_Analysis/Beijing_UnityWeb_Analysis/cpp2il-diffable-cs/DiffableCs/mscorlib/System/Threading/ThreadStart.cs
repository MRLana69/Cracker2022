namespace System.Threading;

public delegate ThreadStart
{

	public ThreadStart(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke() { }

}

