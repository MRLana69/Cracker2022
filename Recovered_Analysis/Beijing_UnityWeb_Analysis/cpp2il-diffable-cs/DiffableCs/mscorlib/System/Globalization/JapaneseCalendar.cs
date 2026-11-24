namespace System.Globalization;

public class JapaneseCalendar : Calendar
{
	internal static readonly DateTime calendarMinValue; //Field offset: 0x0
	internal static EraInfo[] japaneseEraInfo; //Field offset: 0x8
	internal static Calendar s_defaultInstance; //Field offset: 0xC
	internal GregorianCalendarHelper helper; //Field offset: 0x14

	public override int[] Eras
	{
		 get { } //Length: 3
	}

	internal override int ID
	{
		 get { } //Length: 218
	}

	public override DateTime MaxSupportedDateTime
	{
		 get { } //Length: 89
	}

	public override DateTime MinSupportedDateTime
	{
		 get { } //Length: 89
	}

	public override int TwoDigitYearMax
	{
		 get { } //Length: 12
	}

	private static JapaneseCalendar() { }

	public JapaneseCalendar() { }

	internal static string[] AbbrevEraNames() { }

	internal static string[] EnglishEraNames() { }

	internal static string[] EraNames() { }

	public override int[] get_Eras() { }

	internal override int get_ID() { }

	public override DateTime get_MaxSupportedDateTime() { }

	public override DateTime get_MinSupportedDateTime() { }

	public override int get_TwoDigitYearMax() { }

	public override int GetDayOfMonth(DateTime time) { }

	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	public override int GetDaysInMonth(int year, int month, int era) { }

	internal static Calendar GetDefaultInstance() { }

	public override int GetEra(DateTime time) { }

	internal static EraInfo[] GetEraInfo() { }

	private static EraInfo[] GetErasFromRegistry() { }

	public override int GetMonth(DateTime time) { }

	public override int GetMonthsInYear(int year, int era) { }

	public override int GetYear(DateTime time) { }

	public override bool IsLeapYear(int year, int era) { }

	internal override bool IsValidYear(int year, int era) { }

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public override int ToFourDigitYear(int year) { }

}

