//Type is in global namespace

public class EventTesterManager
{
	private static Action OnEventTesterInfoChanged; //Field offset: 0x0
	private static EventTesterManager _instance; //Field offset: 0x4
	private Dictionary<string, string> _settings; //Field offset: 0x8

	public static event Action OnEventTesterInfoChanged
	{
		 add { } //Length: 80
		 remove { } //Length: 206
	}

	public static EventTesterManager Instance
	{
		 get { } //Length: 322
	}

	public static bool isInitialized
	{
		 get { } //Length: 226
	}

	private static EventTesterManager() { }

	private EventTesterManager() { }

	public static void add_OnEventTesterInfoChanged(Action value) { }

	public static EventTesterManager get_Instance() { }

	public static bool get_isInitialized() { }

	public SSEventCategory GetEventCategory() { }

	public long GetEventEndTime() { }

	public long GetEventID() { }

	public long GetEventStartTime() { }

	public SSEventType GetEventType() { }

	public string GetEventValue() { }

	public static void remove_OnEventTesterInfoChanged(Action value) { }

	public void UpdateInfo(string eventType, string charType, string boardType, string eventCategory, string hoursLeft) { }

	private void UpdateSettingValue(string key, string value) { }

	private void UpdateTimeLimit(int hoursFromNow) { }

}

