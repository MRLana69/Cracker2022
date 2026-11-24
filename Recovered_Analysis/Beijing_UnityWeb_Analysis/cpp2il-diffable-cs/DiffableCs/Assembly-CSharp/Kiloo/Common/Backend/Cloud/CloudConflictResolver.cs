namespace Kiloo.Common.Backend.Cloud;

public delegate CloudConflictResolver
{

	public CloudConflictResolver(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(ICloudConflict[] conflicts, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(ICloudConflict[] conflicts) { }

}

