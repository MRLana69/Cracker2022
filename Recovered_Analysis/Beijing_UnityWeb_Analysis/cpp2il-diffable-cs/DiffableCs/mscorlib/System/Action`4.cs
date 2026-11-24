namespace System;

public delegate Action`4
{

	public Action`4(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

