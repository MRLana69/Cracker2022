using System;
using UnityEngine;

public class LocalNotificationsManager
{
	public const int TIME_OF_NOTIFICATION = 17;

	public const int TIME_OF_NOTIFICATION_DAILY_VIDEO = 19;

	public const string ONLINE_SETTING = "enable_local_notifications";

	private static LocalNotificationsManager _instance;

	private static ILocalNotificationController _notificationCtrl;

	public ILocalNotificationController NotificationController => _notificationCtrl;

	public static LocalNotificationsManager Instance
	{
		get
		{
			if (_instance == null)
			{
				LocalNotificationsManager instance = default;
				_instance = instance;
				RuntimePlatform platform = Application.platform;
				if (platform != RuntimePlatform.Android)
				{
					RuntimePlatform platform2 = Application.platform;
					if (platform2 != RuntimePlatform.IPhonePlayer)
					{
					}
				}
				ILocalNotificationController notificationCtrl = default;
				_notificationCtrl = notificationCtrl;
			}
			return _instance;
		}
	}

	public unsafe DateTime GetNextNotificationTimeForVideos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected VT, but got Unknown
		//IL_0046: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime today = DateTime.Today;
		DateTime dateTime = (DateTime)(obj + 8);
		return ((DateTime*)dateTime)->AddHours(19.0);
	}
}
