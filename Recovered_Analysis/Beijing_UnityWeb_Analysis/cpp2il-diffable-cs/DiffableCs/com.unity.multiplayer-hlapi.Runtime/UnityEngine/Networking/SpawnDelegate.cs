namespace UnityEngine.Networking;

public delegate SpawnDelegate
{

	public SpawnDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(Vector3 position, NetworkHash128 assetId, AsyncCallback callback, object object) { }

	public virtual GameObject EndInvoke(IAsyncResult result) { }

	public virtual GameObject Invoke(Vector3 position, NetworkHash128 assetId) { }

}

