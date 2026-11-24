namespace System.Globalization;

internal class CalendarData
{
	internal const int MAX_CALENDARS = 23; //Field offset: 0x0
	internal static CalendarData Invariant; //Field offset: 0x0
	internal string sNativeName; //Field offset: 0x8
	internal string[] saShortDates; //Field offset: 0xC
	internal string[] saYearMonths; //Field offset: 0x10
	internal string[] saLongDates; //Field offset: 0x14
	internal string sMonthDay; //Field offset: 0x18
	internal string[] saEraNames; //Field offset: 0x1C
	internal string[] saAbbrevEraNames; //Field offset: 0x20
	internal string[] saAbbrevEnglishEraNames; //Field offset: 0x24
	internal string[] saDayNames; //Field offset: 0x28
	internal string[] saAbbrevDayNames; //Field offset: 0x2C
	internal string[] saSuperShortDayNames; //Field offset: 0x30
	internal string[] saMonthNames; //Field offset: 0x34
	internal string[] saAbbrevMonthNames; //Field offset: 0x38
	internal string[] saMonthGenitiveNames; //Field offset: 0x3C
	internal string[] saAbbrevMonthGenitiveNames; //Field offset: 0x40
	internal string[] saLeapYearMonthNames; //Field offset: 0x44
	internal int iTwoDigitYearMax; //Field offset: 0x48
	internal int iCurrentEra; //Field offset: 0x4C
	internal bool bUseUserOverrides; //Field offset: 0x50

	private static CalendarData() { }

	private CalendarData() { }

	internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides) { }

	private static string CalendarIdToCultureName(int calendarId) { }

	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

	internal static CalendarData GetCalendarData(int calendarId) { }

	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	private void InitializeEraNames(string localeName, int calendarId) { }

	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	public static int nativeGetTwoDigitYearMax(int calID) { }

}

