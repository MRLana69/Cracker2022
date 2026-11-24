namespace System;

public delegate EventHandler`1
{

	public EventHandler`1(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, TEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object sender, TEventArgs e) { }

}

