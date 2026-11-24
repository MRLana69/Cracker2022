namespace System;

public delegate Func`3
{

	public Func`3(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }

	public virtual TResult EndInvoke(IAsyncResult result) { }

	public virtual TResult Invoke(T1 arg1, T2 arg2) { }

}

