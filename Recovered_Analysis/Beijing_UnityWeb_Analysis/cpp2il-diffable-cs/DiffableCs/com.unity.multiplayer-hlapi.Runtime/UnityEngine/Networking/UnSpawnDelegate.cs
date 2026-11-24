namespace UnityEngine.Networking;

public delegate UnSpawnDelegate
{

	public UnSpawnDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(GameObject spawned, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(GameObject spawned) { }

}

