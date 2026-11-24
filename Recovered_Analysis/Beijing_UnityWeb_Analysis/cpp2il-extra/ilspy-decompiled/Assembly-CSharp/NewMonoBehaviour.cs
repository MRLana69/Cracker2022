using UnityEngine;

public class NewMonoBehaviour : MonoBehaviour
{
	public NewMonoBehaviour()
	{
		//IL_000b: Expected Obj, but got I4
		((NotificationsObserver)this).onNotificationReceived += (NotificationsObserver.NotificationHandler)1;
	}
}
