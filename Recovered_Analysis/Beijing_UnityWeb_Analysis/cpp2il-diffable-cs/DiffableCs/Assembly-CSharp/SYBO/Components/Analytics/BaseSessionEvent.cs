namespace SYBO.Components.Analytics;

public abstract class BaseSessionEvent : AnalyticsEvent
{
	public static Func<int> GetSessionID; //Field offset: 0x0
	public static Func<int> GetSessionDelta; //Field offset: 0x4
	public static Func<int> GetIncrementedSessionEventNumber; //Field offset: 0x8
	public static Func<string> GetDeviceID; //Field offset: 0xC
	public static Func<string> GetOperatingSystem; //Field offset: 0x10
	public static Func<string> GetDeviceModel; //Field offset: 0x14
	public static Func<string> GetISOThreeLetterLanguageCode; //Field offset: 0x18
	protected int _sessionID; //Field offset: 0x18
	protected int _sessionDelta; //Field offset: 0x1C
	protected int _sessionEventID; //Field offset: 0x20

	public int SessionDelta
	{
		 get { } //Length: 6
	}

	public int SessionEventId
	{
		 get { } //Length: 6
	}

	public int SessionId
	{
		 get { } //Length: 43
	}

	private static BaseSessionEvent() { }

	public BaseSessionEvent() { }

	protected BaseSessionEvent(DateTime eventTime, int sessionDelta) { }

	protected BaseSessionEvent(bool initializeValues) { }

	protected BaseSessionEvent(bool initializeValues, DateTime eventTime, int sessionDelta) { }

	public int get_SessionDelta() { }

	public int get_SessionEventId() { }

	public int get_SessionId() { }

	private static string GetDeviceIDDefault() { }

	private static string GetDeviceModelDefault() { }

	private static string GetISOThreeLetterLanguageCodeDefault() { }

	private static string GetOperatingSystemDefault() { }

	private void InitializeCommon() { }

}

