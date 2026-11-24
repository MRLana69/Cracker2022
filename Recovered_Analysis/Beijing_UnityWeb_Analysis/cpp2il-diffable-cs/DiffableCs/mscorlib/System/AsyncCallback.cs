namespace System;

public delegate AsyncCallback
{

	public AsyncCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(IAsyncResult ar) { }

}

