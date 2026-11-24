namespace Kiloo.Common.Plugins.Notifications;

public interface INotifications : IEnumerable<INotification>, IEnumerable
{

	public event Action notificationReceived
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public int count
	{
		 get { } //Length: 0
	}

	public string errorMessage
	{
		 get { } //Length: 0
	}

	public bool isErrorUserRecoverable
	{
		 get { } //Length: 0
	}

	public INotification Item
	{
		 get { } //Length: 0
	}

	public string oldRegistrationId
	{
		 get { } //Length: 0
	}

	public string registrationId
	{
		 get { } //Length: 0
	}

	public void add_notificationReceived(Action value) { }

	public void ClearAllLocalNotifications() { }

	public void ClearNotifications() { }

	public void EnableLocalNotificationLogs() { }

	public int get_count() { }

	public string get_errorMessage() { }

	public bool get_isErrorUserRecoverable() { }

	public INotification get_Item(int index) { }

	public string get_oldRegistrationId() { }

	public string get_registrationId() { }

	public void HandleUserRecoverableError() { }

	public Coroutine RegisterForRemoteNotifications(RegisterForRemoteNotificationsCompletedHandler onComplete = null) { }

	public void remove_notificationReceived(Action value) { }

	public void ScheduleLocalNotification(DateTime date, string title, string message, string soundName) { }

	public Coroutine UnregisterForRemoteNotifications(UnregisterForRemoteNotificationsCompletedHandler onComplete = null) { }

}

