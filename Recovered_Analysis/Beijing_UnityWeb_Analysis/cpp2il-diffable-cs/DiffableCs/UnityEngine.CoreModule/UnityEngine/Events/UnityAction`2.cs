namespace UnityEngine.Events;

public delegate UnityAction`2
{

	public UnityAction`2(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(T0 arg0, T1 arg1) { }

}

