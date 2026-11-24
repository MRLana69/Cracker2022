namespace UnityEngine.Playables;

public interface INotificationReceiver
{

	public void OnNotify(Playable origin, INotification notification, object context) { }

}

