namespace Kiloo.Common.Utility;

public static class TimeUtility
{
	public static readonly DateTime epoch; //Field offset: 0x0

	private static TimeUtility() { }

	public static DateTime FromUnixTime(long unixtime) { }

	public static TimeSpan GetCurrentTimeZoneUTCOffset(DateTime time) { }

	public static long RFC1123StringToUnixTime(string str) { }

	public static string ToJSON(DateTime value) { }

	public static string ToRFC1123(DateTime value) { }

	public static string ToSortableNumber(DateTime value) { }

	public static long ToUnixTime(DateTime time) { }

	public static DateTimeOffset Trim(DateTimeOffset time, long ticks) { }

	public static DateTime Trim(DateTime time, long ticks) { }

	public static DateTimeOffset TrimToWholeMilliSeconds(DateTimeOffset time) { }

	public static DateTime TrimToWholeMilliSeconds(DateTime time) { }

	public static DateTimeOffset TrimToWholeSeconds(DateTimeOffset time) { }

	public static DateTime TrimToWholeSeconds(DateTime time) { }

	public static bool TryParseRFC1123(string str, out DateTime result) { }

	public static bool TryParseSortableNumber(string str, out DateTime result) { }

}

