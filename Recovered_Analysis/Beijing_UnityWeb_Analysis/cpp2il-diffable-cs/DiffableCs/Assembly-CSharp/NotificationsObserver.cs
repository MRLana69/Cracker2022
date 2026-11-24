//Type is in global namespace

public class NotificationsObserver : MonoBehaviour
{
	public delegate NotificationHandler
	{

		public NotificationHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Notification notification, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Notification notification) { }

	}

	private static readonly IJsonSerializer _jsonConverter; //Field offset: 0x0
	private const string TITLE_DICT_KEY = "title"; //Field offset: 0x0
	private const string MESSAGE_DICT_KEY = "message"; //Field offset: 0x0
	private const string TYPE_DICT_KEY = "type"; //Field offset: 0x0
	private const string SOUNDNAME_DICT_KEY = "soundName"; //Field offset: 0x0
	private const string USERINFO_DICT_KEY = "userInfo"; //Field offset: 0x0
	private static NotificationsObserver _instance; //Field offset: 0x4
	private NotificationHandler onNotificationReceived; //Field offset: 0xC
	private Action<Notification> onNotificationPressed; //Field offset: 0x10

	public event Action<Notification> onNotificationPressed
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event NotificationHandler onNotificationReceived
	{
		 add { } //Length: 20
		 remove { } //Length: 111
	}

	public static NotificationsObserver instance
	{
		 get { } //Length: 52
	}

	private static NotificationsObserver() { }

	public NotificationsObserver() { }

	public void add_onNotificationPressed(Action<Notification> value) { }

	public void add_onNotificationReceived(NotificationHandler value) { }

	private void alertListeners(string title, string message, string type, Dictionary<string, object> userInfo, string soundName = "") { }

	private void Awake() { }

	private bool DidAppStartFromNotificationAndroid(out Notification notification) { }

	private bool DidAppStartFromNotificationIOS(out Notification notification) { }

	public static NotificationsObserver get_instance() { }

	public static void Log(string msg, Object context = null) { }

	public static void LogError(string msg, Object context = null) { }

	public static void LogWarning(string msg, Object context = null) { }

	private void onAndroidNotificationReceived() { }

	private void OnApplicationPause(bool pause) { }

	public void remove_onNotificationPressed(Action<Notification> value) { }

	public void remove_onNotificationReceived(NotificationHandler value) { }

	private void Start() { }

}

