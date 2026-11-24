namespace System;

public delegate Func`1
{

	public Func`1(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual TResult EndInvoke(IAsyncResult result) { }

	public virtual TResult Invoke() { }

}

