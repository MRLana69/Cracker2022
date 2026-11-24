namespace System;

internal delegate IOAsyncCallback
{

	public IOAsyncCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(IOAsyncResult ioares, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(IOAsyncResult ioares) { }

}

