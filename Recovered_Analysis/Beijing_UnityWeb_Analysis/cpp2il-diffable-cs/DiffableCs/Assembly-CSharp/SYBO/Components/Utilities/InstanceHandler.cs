namespace SYBO.Components.Utilities;

public static class InstanceHandler
{
	public delegate DestroyDelegate
	{

		public DestroyDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject instance, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject instance) { }

	}

	public delegate InstantiateDelegate
	{

		public InstantiateDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject prefab, Vector3 pos, Quaternion rot, AsyncCallback callback, object object) { }

		public virtual GameObject EndInvoke(IAsyncResult result) { }

		public virtual GameObject Invoke(GameObject prefab, Vector3 pos, Quaternion rot) { }

	}

	public static InstantiateDelegate InstantiateDelegates; //Field offset: 0x0
	public static DestroyDelegate DestroyDelegates; //Field offset: 0x4

	internal static void DestroyInstance(GameObject instance) { }

	internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot) { }

}

