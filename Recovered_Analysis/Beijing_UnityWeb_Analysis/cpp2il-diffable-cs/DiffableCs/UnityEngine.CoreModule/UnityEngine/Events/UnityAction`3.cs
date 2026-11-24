namespace UnityEngine.Events;

public delegate UnityAction`3
{

	public UnityAction`3(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

