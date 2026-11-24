namespace Kiloo.Common.JsonUtil;

public class AdTrackingSystemLogger
{
	private static AdSystemEventLogger _adSystemEventLogger; //Field offset: 0x0

	public AdTrackingSystemLogger() { }

	private static string GetAdPrefix(AdType adType) { }

	public static void LogAttemptToCacheResult(AdType adType, string providerId, string result) { }

	public static void LogAttemptToShowButtonFlow(AdLocationInfo adLocation) { }

	public static void LogAttemptToShowButtonFlow(AdLocationInfo adLocation, bool isCached) { }

	public static void LogAttemptToShowButtonFlow(AdLocationInfo adLocation, string result) { }

	public static void LogFillRequest(AdLocationInfo adLocation) { }

	public static void LogFillRequest(AdLocationInfo adLocation, bool adAvailable) { }

	public static void LogFlow(AdType adType, AdLocationInfo adLocation, string flowId, string result) { }

	public static void LogFlow(AdType adType, string adLocationId, string providerId, string flowId, string result) { }

	public static void LogVideoAdButtonClick(AdLocationInfo adLocation) { }

	public static void LogWaterFallReach(string screenName, int waterfallReach) { }

	public static void SetAdSystemEventLogger(AdSystemEventLogger adSystemEventLogger) { }

}

