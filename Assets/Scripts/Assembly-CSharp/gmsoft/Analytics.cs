using FirebaseWebGL.Scripts.FirebaseAnalytics;

namespace gmsoft;

public class Analytics
{
	public static void SetUserProperties(string props)
	{
		FirebaseAnalytics.SetUserProperties(props);
	}

	public static void LogEvent(string eventName)
	{
		FirebaseAnalytics.LogEvent(eventName);
	}

	public static void LogEventParameter(string eventName, string eventParam)
	{
		FirebaseAnalytics.LogEventParameter(eventName, eventParam);
	}
}
