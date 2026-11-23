using System.Collections.Generic;
using Kiloo.Common.FlurryAnalytics.Internal;
using UnityEngine;

namespace Kiloo.Common.FlurryAnalytics;

public static class FlurryAnalytics
{
	private static bool _initialized;

	private static IFlurryAnalyticsBridge _platformBridge;

	private static IFlurryAnalyticsBridge platformBridge
	{
		get
		{
			//IL_0039: Expected Obj, but got I4
			FlurryAnalyticsIOS result;
			if (_platformBridge == null)
			{
				RuntimePlatform platform = Application.platform;
				if (platform != RuntimePlatform.OSXEditor)
				{
					object obj = platform - 7;
					if (platform != RuntimePlatform.WindowsEditor)
					{
						if ((nint)obj == 1)
						{
							FlurryAnalyticsIOS instance = FlurryAnalyticsIOS.instance;
							result = instance;
							goto IL_012e;
						}
						if ((nint)obj != 2 && (nint)obj != 3)
						{
							if ((nint)obj == 4)
							{
								FlurryAnalyticsAndroid instance2 = FlurryAnalyticsAndroid.instance;
								result = (FlurryAnalyticsIOS)(object)instance2;
								goto IL_012e;
							}
							if (platform == RuntimePlatform.MetroPlayerARM)
							{
								goto IL_0128;
							}
						}
						LogError("Not supported on current platform");
					}
				}
			}
			goto IL_0128;
			IL_012e:
			_platformBridge = result;
			return result;
			IL_0128:
			return _platformBridge;
		}
	}

	public static bool isSupportedOnPlatform
	{
		get
		{
			//IL_0034: Expected Obj, but got I4
			RuntimePlatform platform = Application.platform;
			if (platform != RuntimePlatform.OSXEditor)
			{
				object obj = platform - 7;
				if ((nint)obj >= 2)
				{
					return platform == RuntimePlatform.Android;
				}
			}
			return true;
		}
	}

	public static void StartSession(string apiKey)
	{
	}

	public static void EndSession()
	{
	}

	public static void LogEvent(string eventName)
	{
	}

	public static void LogEventWithParams(string eventName, Dictionary<string, string> parameters)
	{
	}

	public static void LogTimedEvent(string eventName)
	{
	}

	public static void LogTimedEventWithParams(string eventName, Dictionary<string, string> parameters)
	{
	}

	public static void EndTimedEvent(string eventName)
	{
	}

	public static void LogPageView()
	{
	}

	public static void LogError(string errorId, string message, string errorClass)
	{
	}

	public static void SetUserId(string userId)
	{
	}

	public static void SetAge(int age)
	{
	}

	public static void SetGender(Gender gender)
	{
	}

	public static void SetContinueSessionMillis(long milliseconds)
	{
	}

	public static void SetCaptureUncaughtExceptions(bool value)
	{
	}

	private static void Log(string msg, Object context = null)
	{
	}

	private static void EnableNativeLogs(bool value)
	{
	}

	private static void LogError(string msg, Object context = null)
	{
		string text = "[FlurryAnalytics] " + msg;
	}
}
