//Type is in global namespace

public class RemoteNotificationControl
{
	public delegate RemoteNotificationsEnabledHandler
	{

		public RemoteNotificationsEnabledHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string token, string oldToken, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string token, string oldToken) { }

	}

	private const string CACHED_DEVICE_TOKEN_KEY = "remote_notifications_cached_device_token"; //Field offset: 0x0
	private static bool _cachedDeviceTokenLoaded; //Field offset: 0x0
	private static string _cachedDeviceToken; //Field offset: 0x4

	private static RemoteNotificationControl() { }

	public RemoteNotificationControl() { }

	private static string ByteArrayToHex(byte[] barray) { }

	private static string CacheTokenAndGetOldIfChanged(string token) { }

	public static void Disable() { }

	public static void Enable(RemoteNotificationsEnabledHandler completionHandler, string soundToPlay) { }

	public static string GetDeviceToken() { }

}

