namespace System;

public delegate Func`4
{

	public Func`4(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

	public virtual TResult EndInvoke(IAsyncResult result) { }

	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3) { }

}

