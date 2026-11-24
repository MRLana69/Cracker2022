namespace System.Threading;

public delegate WaitOrTimerCallback
{

	public WaitOrTimerCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object state, bool timedOut, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object state, bool timedOut) { }

}

