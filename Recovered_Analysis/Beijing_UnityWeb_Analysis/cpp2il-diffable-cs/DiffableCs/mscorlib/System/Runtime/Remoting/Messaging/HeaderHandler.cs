namespace System.Runtime.Remoting.Messaging;

public delegate HeaderHandler
{

	public HeaderHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(Header[] headers, AsyncCallback callback, object object) { }

	public virtual object EndInvoke(IAsyncResult result) { }

	public virtual object Invoke(Header[] headers) { }

}

