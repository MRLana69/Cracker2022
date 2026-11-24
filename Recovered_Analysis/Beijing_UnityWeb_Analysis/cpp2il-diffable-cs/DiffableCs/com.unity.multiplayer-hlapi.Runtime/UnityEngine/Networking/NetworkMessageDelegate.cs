namespace UnityEngine.Networking;

public delegate NetworkMessageDelegate
{

	public NetworkMessageDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(NetworkMessage netMsg, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(NetworkMessage netMsg) { }

}

