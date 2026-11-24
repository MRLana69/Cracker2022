namespace Kiloo.Common.Plugins.Notifications;

public delegate RegisterForRemoteNotificationsCompletedHandler
{

	public RegisterForRemoteNotificationsCompletedHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string registrationId, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(string registrationId) { }

}

