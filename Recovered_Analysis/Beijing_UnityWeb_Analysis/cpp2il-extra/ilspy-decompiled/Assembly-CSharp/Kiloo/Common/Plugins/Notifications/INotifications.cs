using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kiloo.Common.Plugins.Notifications;

public interface INotifications : IEnumerable<INotification>, IEnumerable
{
	int count { get; }

	// C# has no syntax for parameterized property 'Item'.
	INotification get_Item(int index);

	string registrationId { get; }

	string oldRegistrationId { get; }

	string errorMessage { get; }

	bool isErrorUserRecoverable { get; }

	event Action notificationReceived;

	Coroutine RegisterForRemoteNotifications(RegisterForRemoteNotificationsCompletedHandler onComplete = null);

	Coroutine UnregisterForRemoteNotifications(UnregisterForRemoteNotificationsCompletedHandler onComplete = null);

	void HandleUserRecoverableError();

	void ClearNotifications();

	void ScheduleLocalNotification(DateTime date, string title, string message, string soundName);

	void ClearAllLocalNotifications();

	void EnableLocalNotificationLogs();
}
