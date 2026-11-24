namespace System;

public delegate Func`2
{

	public Func`2(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T arg, AsyncCallback callback, object object) { }

	public virtual TResult EndInvoke(IAsyncResult result) { }

	public virtual TResult Invoke(T arg) { }

}

