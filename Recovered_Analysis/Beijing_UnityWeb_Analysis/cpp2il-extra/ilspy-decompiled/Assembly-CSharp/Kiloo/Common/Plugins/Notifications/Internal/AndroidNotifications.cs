namespace Kiloo.Common.Plugins.Notifications.Internal;

internal class AndroidNotifications
{
	private AndroidNotifications()
	{
		Notifications.instance__BackingField = (INotifications)this;
	}

	public static INotifications Create(bool receiveNotifications)
	{
		//IL_0066: Expected I4, but got Obj
		//IL_0066: Expected Obj, but got I4
		INotification notification = ((DummyNotifications)receiveNotifications).get_Item((int)"sound");
		if (notification != null)
		{
			if ((object)notification.GetType() == typeof(string))
			{
				return (INotifications)notification;
			}
			return null;
		}
		return null;
	}
}
