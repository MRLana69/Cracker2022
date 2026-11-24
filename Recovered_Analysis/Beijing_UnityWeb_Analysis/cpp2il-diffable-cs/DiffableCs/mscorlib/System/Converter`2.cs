namespace System;

public delegate Converter`2
{

	public Converter`2(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, object object) { }

	public virtual TOutput EndInvoke(IAsyncResult result) { }

	public virtual TOutput Invoke(TInput input) { }

}

