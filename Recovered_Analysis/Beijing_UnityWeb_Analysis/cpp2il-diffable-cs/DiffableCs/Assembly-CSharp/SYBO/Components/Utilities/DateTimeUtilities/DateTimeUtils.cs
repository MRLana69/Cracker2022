namespace SYBO.Components.Utilities.DateTimeUtilities;

public static class DateTimeUtils
{
	private enum Months
	{
		Jan = 1,
		Feb = 2,
		Mar = 3,
		Apr = 4,
		May = 5,
		Jun = 6,
		Jul = 7,
		Aug = 8,
		Sep = 9,
		Oct = 10,
		Nov = 11,
		Dec = 12,
	}

	private static readonly char[] RFC3339SplitSymbols; //Field offset: 0x0
	public const int TicksPerSecond = 10000000; //Field offset: 0x0
	public const int TicksPerMillisecond = 10000; //Field offset: 0x0
	public const int NanosecondsPerTicks = 100; //Field offset: 0x0
	private static readonly char[] RFC822SplitSymbols; //Field offset: 0x4
	public static readonly DateTime FallbackDateTime; //Field offset: 0x8

	private static DateTimeUtils() { }

	public static string ToStringRFC3339(DateTime time) { }

	public static double TotalSecondsSinceEpoch() { }

	public static bool TryParseRFC3339(string timestamp, out DateTime parsedDateTime) { }

	public static bool TryParseRFC822(string timestamp, out DateTime parsedDateTime) { }

}

