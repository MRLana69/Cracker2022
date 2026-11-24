namespace Kiloo.Common.Plugins.Notifications.Internal;

internal class DummyNotifications : INotifications, IEnumerable<INotification>, IEnumerable
{
	private sealed class <GetEnumerator>d__23 : IEnumerator<INotification>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private INotification <>2__current; //Field offset: 0xC

		private INotification System.Collections.Generic.IEnumerator<Kiloo.Common.Plugins.Notifications.INotification>.Current
		{
			 get { } //Length: 19
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetEnumerator>d__23(int <>1__state) { }

		private bool MoveNext() { }

		private INotification System.Collections.Generic.IEnumerator<Kiloo.Common.Plugins.Notifications.INotification>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private bool _enabledLocalNotificationLogs; //Field offset: 0x8
	private Action notificationReceived; //Field offset: 0xC

	public event Action notificationReceived
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public int count
	{
		 get { } //Length: 3
	}

	public string errorMessage
	{
		 get { } //Length: 43
	}

	public bool isErrorUserRecoverable
	{
		 get { } //Length: 43
	}

	public INotification Item
	{
		 get { } //Length: 112
	}

	public string oldRegistrationId
	{
		 get { } //Length: 43
	}

	public string registrationId
	{
		 get { } //Length: 3
	}

	public DummyNotifications() { }

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

	public IEnumerator<INotification> GetEnumerator() { }

	public void HandleUserRecoverableError() { }

	protected virtual void OnNotificationReceived() { }

	public Coroutine RegisterForRemoteNotifications(RegisterForRemoteNotificationsCompletedHandler onComplete = null) { }

	public void remove_notificationReceived(Action value) { }

	public void ScheduleLocalNotification(DateTime date, string title, string message, string soundName) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public Coroutine UnregisterForRemoteNotifications(UnregisterForRemoteNotificationsCompletedHandler onComplete = null) { }

}

