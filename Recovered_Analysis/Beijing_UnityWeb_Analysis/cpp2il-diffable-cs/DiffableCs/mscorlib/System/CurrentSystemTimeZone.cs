namespace System;

internal class CurrentSystemTimeZone : TimeZone
{
	private readonly TimeZoneInfo LocalTimeZone; //Field offset: 0x8

	internal CurrentSystemTimeZone() { }

	public static bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted) { }

	public override TimeSpan GetUtcOffset(DateTime dateTime) { }

}

