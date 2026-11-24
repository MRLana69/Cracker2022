namespace System;

public delegate Func`5
{

	public Func`5(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }

	public virtual TResult EndInvoke(IAsyncResult result) { }

	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

