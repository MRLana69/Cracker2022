namespace System;

public delegate EventHandler
{

	public EventHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object sender, EventArgs e) { }

}

