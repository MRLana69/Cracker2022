namespace System.Globalization;

public abstract class Calendar : ICloneable
{
	internal const long TicksPerMillisecond = 10000; //Field offset: 0x0
	internal const int CAL_HEBREW = 8; //Field offset: 0x0
	internal const int CAL_GREGORIAN_ME_FRENCH = 9; //Field offset: 0x0
	internal const int CAL_GREGORIAN_ARABIC = 10; //Field offset: 0x0
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11; //Field offset: 0x0
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12; //Field offset: 0x0
	internal const int CAL_JULIAN = 13; //Field offset: 0x0
	internal const int CAL_JAPANESELUNISOLAR = 14; //Field offset: 0x0
	internal const int CAL_THAI = 7; //Field offset: 0x0
	internal const int CAL_CHINESELUNISOLAR = 15; //Field offset: 0x0
	internal const int CAL_LUNAR_ETO_CHN = 17; //Field offset: 0x0
	internal const int CAL_LUNAR_ETO_KOR = 18; //Field offset: 0x0
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19; //Field offset: 0x0
	internal const int CAL_KOREANLUNISOLAR = 20; //Field offset: 0x0
	internal const int CAL_TAIWANLUNISOLAR = 21; //Field offset: 0x0
	internal const int CAL_PERSIAN = 22; //Field offset: 0x0
	internal const int CAL_UMALQURA = 23; //Field offset: 0x0
	internal const int CAL_SAKA = 16; //Field offset: 0x0
	public const int CurrentEra = 0; //Field offset: 0x0
	internal const int CAL_HIJRI = 6; //Field offset: 0x0
	internal const int CAL_TAIWAN = 4; //Field offset: 0x0
	internal const long TicksPerSecond = 10000000; //Field offset: 0x0
	internal const long TicksPerMinute = 600000000; //Field offset: 0x0
	internal const long TicksPerHour = 36000000000; //Field offset: 0x0
	internal const long TicksPerDay = 864000000000; //Field offset: 0x0
	internal const int MillisPerSecond = 1000; //Field offset: 0x0
	internal const int MillisPerMinute = 60000; //Field offset: 0x0
	internal const int MillisPerHour = 3600000; //Field offset: 0x0
	internal const int CAL_KOREA = 5; //Field offset: 0x0
	internal const int MillisPerDay = 86400000; //Field offset: 0x0
	internal const int DaysPer4Years = 1461; //Field offset: 0x0
	internal const int DaysPer100Years = 36524; //Field offset: 0x0
	internal const int DaysPer400Years = 146097; //Field offset: 0x0
	internal const int DaysTo10000 = 3652059; //Field offset: 0x0
	internal const long MaxMillis = 315537897600000; //Field offset: 0x0
	internal const int CAL_GREGORIAN = 1; //Field offset: 0x0
	internal const int CAL_GREGORIAN_US = 2; //Field offset: 0x0
	internal const int CAL_JAPAN = 3; //Field offset: 0x0
	internal const int DaysPerYear = 365; //Field offset: 0x0
	internal int m_currentEraValue; //Field offset: 0x8
	private bool m_isReadOnly; //Field offset: 0xC
	internal int twoDigitYearMax; //Field offset: 0x10

	internal virtual int BaseCalendarID
	{
		 get { } //Length: 3
	}

	internal virtual int CurrentEraValue
	{
		 get { } //Length: 62
	}

	public abstract int[] Eras
	{
		 get { } //Length: 0
	}

	internal virtual int ID
	{
		 get { } //Length: 85
	}

	public virtual DateTime MaxSupportedDateTime
	{
		 get { } //Length: 89
	}

	public virtual DateTime MinSupportedDateTime
	{
		 get { } //Length: 338
	}

	public virtual int TwoDigitYearMax
	{
		 get { } //Length: 113
	}

	protected Calendar() { }

	public virtual object Clone() { }

	internal virtual int get_BaseCalendarID() { }

	internal virtual int get_CurrentEraValue() { }

	public abstract int[] get_Eras() { }

	internal virtual int get_ID() { }

	public virtual DateTime get_MaxSupportedDateTime() { }

	public virtual DateTime get_MinSupportedDateTime() { }

	public virtual int get_TwoDigitYearMax() { }

	public abstract int GetDayOfMonth(DateTime time) { }

	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	public abstract int GetDaysInMonth(int year, int month, int era) { }

	public abstract int GetEra(DateTime time) { }

	public abstract int GetMonth(DateTime time) { }

	public abstract int GetMonthsInYear(int year, int era) { }

	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }

	public abstract int GetYear(DateTime time) { }

	public abstract bool IsLeapYear(int year, int era) { }

	public virtual bool IsLeapYear(int year) { }

	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	internal virtual bool IsValidMonth(int year, int month, int era) { }

	internal virtual bool IsValidYear(int year, int era) { }

	internal void SetReadOnlyState(bool readOnly) { }

	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public virtual int ToFourDigitYear(int year) { }

	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

}

