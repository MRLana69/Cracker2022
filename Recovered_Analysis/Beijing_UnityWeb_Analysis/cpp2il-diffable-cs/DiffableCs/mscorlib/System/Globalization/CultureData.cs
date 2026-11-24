namespace System.Globalization;

internal class CultureData
{
	private static CultureData s_Invariant; //Field offset: 0x0
	private string sAM1159; //Field offset: 0x8
	private string sPM2359; //Field offset: 0xC
	private string sTimeSeparator; //Field offset: 0x10
	private string[] saLongTimes; //Field offset: 0x14
	private string[] saShortTimes; //Field offset: 0x18
	private int iFirstDayOfWeek; //Field offset: 0x1C
	private int iFirstWeekOfYear; //Field offset: 0x20
	private int[] waCalendars; //Field offset: 0x24
	private CalendarData[] calendars; //Field offset: 0x28
	private string sISO639Language; //Field offset: 0x2C
	private readonly string sRealName; //Field offset: 0x30
	private bool bUseOverrides; //Field offset: 0x34
	private int calendarId; //Field offset: 0x38
	private int numberIndex; //Field offset: 0x3C
	private int iDefaultAnsiCodePage; //Field offset: 0x40
	private int iDefaultOemCodePage; //Field offset: 0x44
	private int iDefaultMacCodePage; //Field offset: 0x48
	private int iDefaultEbcdicCodePage; //Field offset: 0x4C
	private bool isRightToLeft; //Field offset: 0x50
	private string sListSeparator; //Field offset: 0x54

	internal int[] CalendarIds
	{
		 get { } //Length: 6
	}

	internal string CultureName
	{
		 get { } //Length: 20
	}

	internal int IFIRSTDAYOFWEEK
	{
		 get { } //Length: 6
	}

	internal int IFIRSTWEEKOFYEAR
	{
		 get { } //Length: 6
	}

	internal int ILANGUAGE
	{
		 get { } //Length: 6
	}

	public static CultureData Invariant
	{
		 get { } //Length: 147
	}

	internal bool IsInvariantCulture
	{
		 get { } //Length: 217
	}

	internal string[] LongTimes
	{
		 get { } //Length: 274
	}

	internal string SAM1159
	{
		 get { } //Length: 6
	}

	internal string SCOMPAREINFO
	{
		 get { } //Length: 6
	}

	internal string[] ShortTimes
	{
		 get { } //Length: 6
	}

	internal string SISO639LANGNAME
	{
		 get { } //Length: 6
	}

	internal string SPM2359
	{
		 get { } //Length: 6
	}

	internal string STEXTINFO
	{
		 get { } //Length: 43
	}

	internal string TimeSeparator
	{
		 get { } //Length: 6
	}

	internal bool UseUserOverride
	{
		 get { } //Length: 3
	}

	private CultureData(string name) { }

	internal string[] AbbrevEraNames(int calendarId) { }

	internal string[] AbbreviatedDayNames(int calendarId) { }

	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	internal string[] AbbreviatedMonthNames(int calendarId) { }

	internal string DateSeparator(int calendarId) { }

	internal string[] DayNames(int calendarId) { }

	internal string[] EraNames(int calendarId) { }

	private void fill_culture_data(int datetimeIndex) { }

	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }

	internal string[] GenitiveMonthNames(int calendarId) { }

	internal int[] get_CalendarIds() { }

	internal string get_CultureName() { }

	internal int get_IFIRSTDAYOFWEEK() { }

	internal int get_IFIRSTWEEKOFYEAR() { }

	internal int get_ILANGUAGE() { }

	public static CultureData get_Invariant() { }

	internal bool get_IsInvariantCulture() { }

	internal string[] get_LongTimes() { }

	internal string get_SAM1159() { }

	internal string get_SCOMPAREINFO() { }

	internal string[] get_ShortTimes() { }

	internal string get_SISO639LANGNAME() { }

	internal string get_SPM2359() { }

	internal string get_STEXTINFO() { }

	internal string get_TimeSeparator() { }

	internal bool get_UseUserOverride() { }

	public CalendarData GetCalendar(int calendarId) { }

	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	private static string GetDateSeparator(string format) { }

	internal void GetNFIValues(NumberFormatInfo nfi) { }

	private static string GetSeparator(string format, string timeParts) { }

	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	internal string[] LeapYearMonthNames(int calendarId) { }

	internal string[] LongDates(int calendarId) { }

	internal string MonthDay(int calendarId) { }

	internal string[] MonthNames(int calendarId) { }

	internal static string ReescapeWin32String(string str) { }

	internal static string[] ReescapeWin32Strings(string[] array) { }

	internal string[] ShortDates(int calendarId) { }

	private static string UnescapeNlsString(string str, int start, int end) { }

	internal string[] YearMonths(int calendarId) { }

}

