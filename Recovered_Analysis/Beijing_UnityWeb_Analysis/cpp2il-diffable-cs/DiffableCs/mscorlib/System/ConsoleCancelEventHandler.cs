namespace System;

public delegate ConsoleCancelEventHandler
{

	public ConsoleCancelEventHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, ConsoleCancelEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

}

