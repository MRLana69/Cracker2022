namespace Kiloo.Common.Plugins.Notifications;

public delegate UnregisterForRemoteNotificationsCompletedHandler
{

	public UnregisterForRemoteNotificationsCompletedHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(bool success, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(bool success) { }

}

