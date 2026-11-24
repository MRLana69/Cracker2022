namespace System;

public delegate ResolveEventHandler
{

	public ResolveEventHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs args, AsyncCallback callback, object object) { }

	public virtual Assembly EndInvoke(IAsyncResult result) { }

	public virtual Assembly Invoke(object sender, ResolveEventArgs args) { }

}

