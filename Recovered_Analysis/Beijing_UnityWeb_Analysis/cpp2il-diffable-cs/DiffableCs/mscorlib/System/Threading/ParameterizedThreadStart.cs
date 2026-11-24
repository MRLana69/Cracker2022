namespace System.Threading;

public delegate ParameterizedThreadStart
{

	public ParameterizedThreadStart(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object obj, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object obj) { }

}

