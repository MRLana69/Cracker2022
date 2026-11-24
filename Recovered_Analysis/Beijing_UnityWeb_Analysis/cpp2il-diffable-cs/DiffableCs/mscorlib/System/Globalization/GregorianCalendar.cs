namespace System.Globalization;

public class GregorianCalendar : Calendar
{
	internal static readonly int[] DaysToMonth365; //Field offset: 0x0
	internal static readonly int[] DaysToMonth366; //Field offset: 0x4
	private static Calendar s_defaultInstance; //Field offset: 0x8
	internal GregorianCalendarTypes m_type; //Field offset: 0x14

	public override int[] Eras
	{
		 get { } //Length: 6
	}

	internal override int ID
	{
		 get { } //Length: 563
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
		 get { } //Length: 61
	}

	private static GregorianCalendar() { }

	public GregorianCalendar() { }

	public GregorianCalendar(GregorianCalendarTypes type) { }

	public override int[] get_Eras() { }

	internal override int get_ID() { }

	public override DateTime get_MaxSupportedDateTime() { }

	public override DateTime get_MinSupportedDateTime() { }

	public override int get_TwoDigitYearMax() { }

	internal virtual int GetDatePart(long ticks, int part) { }

	public override int GetDayOfMonth(DateTime time) { }

	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	public override int GetDaysInMonth(int year, int month, int era) { }

	internal static Calendar GetDefaultInstance() { }

	public override int GetEra(DateTime time) { }

	public override int GetMonth(DateTime time) { }

	public override int GetMonthsInYear(int year, int era) { }

	public override int GetYear(DateTime time) { }

	public override bool IsLeapYear(int year, int era) { }

	private void OnDeserialized(StreamingContext ctx) { }

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public override int ToFourDigitYear(int year) { }

	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

}

