namespace System;

public delegate Action`3
{

	public Action`3(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }

}

