namespace System;

public delegate Predicate`1
{

	public Predicate`1(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T obj, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

	public virtual bool Invoke(T obj) { }

}

