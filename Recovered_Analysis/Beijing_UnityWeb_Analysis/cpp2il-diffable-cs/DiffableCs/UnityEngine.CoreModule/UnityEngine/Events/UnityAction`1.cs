namespace UnityEngine.Events;

public delegate UnityAction`1
{

	public UnityAction`1(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(T0 arg0) { }

}

