using System.Collections.Generic;
using MiniJSON;

namespace Kiloo.Common.FlurryAnalytics.Internal;

internal class FlurryAnalyticsIOS : IFlurryAnalyticsBridge
{
	private static FlurryAnalyticsIOS _instance;

	private static FlurryAnalyticsIOS instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			FlurryAnalyticsIOS result = _instance;
			if (!flag2)
			{
				FlurryAnalyticsIOS flurryAnalyticsIOS = default;
				_instance = flurryAnalyticsIOS;
				result = flurryAnalyticsIOS;
			}
			return result;
		}
	}

	private FlurryAnalyticsIOS()
	{
	}

	public static FlurryAnalyticsIOS CreatePlugin()
	{
		return instance;
	}

	private static void flurryStartSession(string apiKey, bool crashReportingEnabled)
	{
	}

	private static void flurrySetUserId(string userId)
	{
	}

	private static void flurrySetAge(int age)
	{
	}

	private static void flurrySetGender(int gender)
	{
	}

	private static void flurryLogEvent(string eventName)
	{
	}

	private static void flurryLogEventWithParams(string eventName, string jsonParams)
	{
	}

	private static void flurryLogTimedEvent(string eventName)
	{
	}

	private static void flurryLogTimedEventWithParams(string eventName, string jsonParams)
	{
	}

	private static void flurryEndTimedEvent(string eventName)
	{
	}

	private static void flurryOnPageView()
	{
	}

	private static void flurrySetContinueSessionMillis(int milliseconds)
	{
	}

	private static void flurrySetDebugLogsEnabled(bool value)
	{
	}

	private static void flurryLogError(string errorName, string message)
	{
	}

	public void StartSession(string apiKey)
	{
	}

	public void EndSession()
	{
	}

	public void LogEvent(string eventName)
	{
	}

	public void LogEventWithParams(string eventName, Dictionary<string, string> parameters)
	{
		string text = Json.Serialize(parameters);
	}

	public void LogTimedEvent(string eventName)
	{
	}

	public void LogTimedEventWithParams(string eventName, Dictionary<string, string> parameters)
	{
		string text = Json.Serialize(parameters);
	}

	public void EndTimedEvent(string eventName)
	{
	}

	public void LogPageView()
	{
	}

	public void LogError(string errorId, string message, string errorClass)
	{
	}

	public void SetUserId(string userId)
	{
	}

	public void SetAge(int age)
	{
	}

	public void SetGender(Gender gender)
	{
	}

	public void SetContinueSessionMillis(long milliseconds)
	{
	}

	public void SetCaptureUncaughtExceptions(bool value)
	{
	}

	public void SetDebugLogsEnabled(bool value)
	{
	}
}
