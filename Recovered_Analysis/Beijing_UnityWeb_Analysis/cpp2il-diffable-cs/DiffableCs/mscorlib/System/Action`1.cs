namespace System;

public delegate Action`1
{

	public Action`1(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T obj, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(T obj) { }

}

