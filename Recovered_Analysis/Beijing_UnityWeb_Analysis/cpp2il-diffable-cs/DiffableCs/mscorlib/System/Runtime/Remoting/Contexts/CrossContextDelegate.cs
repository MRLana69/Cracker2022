namespace System.Runtime.Remoting.Contexts;

public delegate CrossContextDelegate
{

	public CrossContextDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke() { }

}

