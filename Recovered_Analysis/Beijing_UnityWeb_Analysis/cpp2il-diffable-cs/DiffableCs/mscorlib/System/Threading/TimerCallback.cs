namespace System.Threading;

public delegate TimerCallback
{

	public TimerCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object state) { }

}

