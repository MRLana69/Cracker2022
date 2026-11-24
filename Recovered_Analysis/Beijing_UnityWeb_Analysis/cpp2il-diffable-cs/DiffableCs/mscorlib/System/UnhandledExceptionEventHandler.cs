namespace System;

public delegate UnhandledExceptionEventHandler
{

	public UnhandledExceptionEventHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, UnhandledExceptionEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object sender, UnhandledExceptionEventArgs e) { }

}

