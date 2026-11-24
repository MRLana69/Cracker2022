namespace SYBO.Components.Analytics;

public abstract class AnalyticsEvent
{
	public static Func<string> GetGameVersion; //Field offset: 0x0
	public static Func<DateTime> GetDeviceStartupTime; //Field offset: 0x4
	public static Func<string> GetUserID; //Field offset: 0x8
	public static Func<float> GetSamplingKey; //Field offset: 0xC
	protected string _userID; //Field offset: 0x8
	protected string _eventID; //Field offset: 0xC
	protected string _gameVersion; //Field offset: 0x10
	private string _eventTime; //Field offset: 0x14

	public string EventId
	{
		 get { } //Length: 6
	}

	public abstract string EventName
	{
		 get { } //Length: 0
	}

	public string EventTime
	{
		 get { } //Length: 6
	}

	public string GameVersion
	{
		 get { } //Length: 6
	}

	public string UserId
	{
		 get { } //Length: 6
	}

	public AnalyticsEvent() { }

	protected AnalyticsEvent(bool initializeValues) { }

	protected AnalyticsEvent(bool initializeValues, DateTime eventTime) { }

	public string get_EventId() { }

	public abstract string get_EventName() { }

	public string get_EventTime() { }

	public string get_GameVersion() { }

	public string get_UserId() { }

	public static DateTime GetEventTime() { }

	public static string GetTimeText(DateTime time) { }

	public override string ToString() { }

}

