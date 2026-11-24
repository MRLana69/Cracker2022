namespace System;

public delegate AssemblyLoadEventHandler
{

	public AssemblyLoadEventHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, AssemblyLoadEventArgs args, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

}

