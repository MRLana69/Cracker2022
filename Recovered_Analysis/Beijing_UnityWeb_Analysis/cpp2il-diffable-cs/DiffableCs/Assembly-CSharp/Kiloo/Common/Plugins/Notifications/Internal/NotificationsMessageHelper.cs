namespace Kiloo.Common.Plugins.Notifications.Internal;

internal class NotificationsMessageHelper : MonoBehaviour
{
	private Action<string> notificationReceived; //Field offset: 0xC
	private Action<string> registerForRemoteNotificationsCompleted; //Field offset: 0x10
	private Action<string> unregisterForRemoteNotificationsCompleted; //Field offset: 0x14

	public event Action<string> notificationReceived
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> registerForRemoteNotificationsCompleted
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<string> unregisterForRemoteNotificationsCompleted
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public NotificationsMessageHelper() { }

	public void add_notificationReceived(Action<string> value) { }

	public void add_registerForRemoteNotificationsCompleted(Action<string> value) { }

	public void add_unregisterForRemoteNotificationsCompleted(Action<string> value) { }

	private void OnNotificationReceived(string payload) { }

	private void OnRegisterForRemoteNotificationsCompleted(string regid) { }

	private void OnUnregisterForRemoteNotificationsCompleted(string success) { }

	public void remove_notificationReceived(Action<string> value) { }

	public void remove_registerForRemoteNotificationsCompleted(Action<string> value) { }

	public void remove_unregisterForRemoteNotificationsCompleted(Action<string> value) { }

}

