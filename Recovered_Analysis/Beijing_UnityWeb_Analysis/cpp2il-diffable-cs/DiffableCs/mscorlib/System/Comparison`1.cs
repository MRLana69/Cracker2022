namespace System;

public delegate Comparison`1
{

	public Comparison`1(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T x, T y, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

	public virtual int Invoke(T x, T y) { }

}

