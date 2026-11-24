namespace System.Globalization;

public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider
{
	private static DateTimeFormatInfo invariantInfo; //Field offset: 0x0
	internal const DateTimeStyles InvalidDateTimeStyles = -256; //Field offset: 0x0
	private const int TOKEN_HASH_SIZE = 199; //Field offset: 0x0
	private const int SECOND_PRIME = 197; //Field offset: 0x0
	private const string dateSeparatorOrTimeZoneOffset = "-"; //Field offset: 0x0
	private const string invariantDateSeparator = "/"; //Field offset: 0x0
	private const string invariantTimeSeparator = ":"; //Field offset: 0x0
	internal const string IgnorablePeriod = "."; //Field offset: 0x0
	internal const string IgnorableComma = ","; //Field offset: 0x0
	internal const string CJKYearSuff = "�"; //Field offset: 0x0
	internal const string CJKMonthSuff = "�"; //Field offset: 0x0
	internal const string CJKDaySuff = "�"; //Field offset: 0x0
	internal const string KoreanYearSuff = "�"; //Field offset: 0x0
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132; //Field offset: 0x0
	internal const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss"; //Field offset: 0x0
	internal const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'"; //Field offset: 0x0
	internal const string KoreanMonthSuff = "�"; //Field offset: 0x0
	internal const string EnglishLangName = "en"; //Field offset: 0x0
	internal const string JapaneseLangName = "ja"; //Field offset: 0x0
	internal const string KoreanLangName = "ko"; //Field offset: 0x0
	internal const string LocalTimeMark = "T"; //Field offset: 0x0
	internal const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"; //Field offset: 0x0
	internal const string CJKMinuteSuff = "�"; //Field offset: 0x0
	internal const string CJKSecondSuff = "�"; //Field offset: 0x0
	internal const string CJKHourSuff = "�"; //Field offset: 0x0
	internal const string KoreanSecondSuff = "�"; //Field offset: 0x0
	internal const string KoreanMinuteSuff = "�"; //Field offset: 0x0
	internal const string KoreanHourSuff = "�"; //Field offset: 0x0
	internal const string KoreanDaySuff = "�"; //Field offset: 0x0
	internal const string ChineseHourSuff = "�"; //Field offset: 0x0
	internal static bool preferExistingTokens; //Field offset: 0x4
	private static Hashtable s_calendarNativeNames; //Field offset: 0x8
	private static DateTimeFormatInfo s_jajpDTFI; //Field offset: 0xC
	private static DateTimeFormatInfo s_zhtwDTFI; //Field offset: 0x10
	private CultureData m_cultureData; //Field offset: 0x8
	internal string m_name; //Field offset: 0xC
	private string m_langName; //Field offset: 0x10
	private CompareInfo m_compareInfo; //Field offset: 0x14
	private CultureInfo m_cultureInfo; //Field offset: 0x18
	internal string amDesignator; //Field offset: 0x1C
	internal string pmDesignator; //Field offset: 0x20
	internal string dateSeparator; //Field offset: 0x24
	internal string generalShortTimePattern; //Field offset: 0x28
	internal string generalLongTimePattern; //Field offset: 0x2C
	internal string timeSeparator; //Field offset: 0x30
	internal string monthDayPattern; //Field offset: 0x34
	internal string dateTimeOffsetPattern; //Field offset: 0x38
	internal Calendar calendar; //Field offset: 0x3C
	internal int firstDayOfWeek; //Field offset: 0x40
	internal int calendarWeekRule; //Field offset: 0x44
	internal string fullDateTimePattern; //Field offset: 0x48
	internal string[] abbreviatedDayNames; //Field offset: 0x4C
	internal string[] m_superShortDayNames; //Field offset: 0x50
	internal string[] dayNames; //Field offset: 0x54
	internal string[] abbreviatedMonthNames; //Field offset: 0x58
	internal string[] monthNames; //Field offset: 0x5C
	internal string[] genitiveMonthNames; //Field offset: 0x60
	internal string[] m_genitiveAbbreviatedMonthNames; //Field offset: 0x64
	internal string[] leapYearMonthNames; //Field offset: 0x68
	internal string longDatePattern; //Field offset: 0x6C
	internal string shortDatePattern; //Field offset: 0x70
	internal string yearMonthPattern; //Field offset: 0x74
	internal string longTimePattern; //Field offset: 0x78
	internal string shortTimePattern; //Field offset: 0x7C
	private string[] allYearMonthPatterns; //Field offset: 0x80
	internal string[] allShortDatePatterns; //Field offset: 0x84
	internal string[] allLongDatePatterns; //Field offset: 0x88
	internal string[] allShortTimePatterns; //Field offset: 0x8C
	internal string[] allLongTimePatterns; //Field offset: 0x90
	internal string[] m_eraNames; //Field offset: 0x94
	internal string[] m_abbrevEraNames; //Field offset: 0x98
	internal string[] m_abbrevEnglishEraNames; //Field offset: 0x9C
	internal int[] optionalCalendars; //Field offset: 0xA0
	internal bool m_isReadOnly; //Field offset: 0xA4
	internal DateTimeFormatFlags formatFlags; //Field offset: 0xA8
	private int CultureID; //Field offset: 0xAC
	private bool m_useUserOverride; //Field offset: 0xB0
	private bool bUseCalendarInfo; //Field offset: 0xB1
	private int nDataItem; //Field offset: 0xB4
	internal bool m_isDefaultCalendar; //Field offset: 0xB8
	internal string[] m_dateWords; //Field offset: 0xBC
	private string m_fullTimeSpanPositivePattern; //Field offset: 0xC0
	private string m_fullTimeSpanNegativePattern; //Field offset: 0xC4
	private TokenHashValue[] m_dtfiTokenHash; //Field offset: 0xC8

	public string[] AbbreviatedDayNames
	{
		 get { } //Length: 38
	}

	internal string[] AbbreviatedEnglishEraNames
	{
		 get { } //Length: 48
	}

	internal string[] AbbreviatedEraNames
	{
		 get { } //Length: 48
	}

	public string[] AbbreviatedMonthNames
	{
		 get { } //Length: 59
	}

	private string[] AllLongDatePatterns
	{
		 get { } //Length: 118
	}

	private string[] AllLongTimePatterns
	{
		 get { } //Length: 93
	}

	private string[] AllShortDatePatterns
	{
		 get { } //Length: 93
	}

	private string[] AllShortTimePatterns
	{
		 get { } //Length: 93
	}

	private string[] AllYearMonthPatterns
	{
		 get { } //Length: 46
	}

	public string AMDesignator
	{
		 get { } //Length: 94
	}

	public Calendar Calendar
	{
		 get { } //Length: 6
		 set { } //Length: 329
	}

	internal CompareInfo CompareInfo
	{
		 get { } //Length: 86
	}

	private CultureInfo Culture
	{
		 get { } //Length: 31
	}

	private string CultureName
	{
		 get { } //Length: 167
	}

	public static DateTimeFormatInfo CurrentInfo
	{
		 get { } //Length: 237
	}

	public string DateSeparator
	{
		 get { } //Length: 48
	}

	internal string DateTimeOffsetPattern
	{
		 get { } //Length: 95
	}

	public string[] DayNames
	{
		 get { } //Length: 59
	}

	internal string[] EraNames
	{
		 get { } //Length: 37
	}

	internal DateTimeFormatFlags FormatFlags
	{
		 get { } //Length: 43
	}

	public string FullDateTimePattern
	{
		 get { } //Length: 6
	}

	internal string FullTimeSpanNegativePattern
	{
		 get { } //Length: 144
	}

	internal string FullTimeSpanPositivePattern
	{
		 get { } //Length: 61
	}

	internal string GeneralLongTimePattern
	{
		 get { } //Length: 95
	}

	internal string GeneralShortTimePattern
	{
		 get { } //Length: 43
	}

	internal bool HasForceTwoDigitYears
	{
		 get { } //Length: 223
	}

	internal bool HasSpacesInDayNames
	{
		 get { } //Length: 15
	}

	internal bool HasSpacesInMonthNames
	{
		 get { } //Length: 59
	}

	internal bool HasYearMonthAdjustment
	{
		 get { } //Length: 18
	}

	public static DateTimeFormatInfo InvariantInfo
	{
		 get { } //Length: 3
	}

	public bool IsReadOnly
	{
		 get { } //Length: 34
	}

	private string LanguageName
	{
		 get { } //Length: 133
	}

	public string LongDatePattern
	{
		 get { } //Length: 96
		 set { } //Length: 656
	}

	public string LongTimePattern
	{
		 get { } //Length: 38
		 set { } //Length: 195
	}

	public string MonthDayPattern
	{
		 get { } //Length: 63
	}

	public string[] MonthGenitiveNames
	{
		 get { } //Length: 10
	}

	public string[] MonthNames
	{
		 get { } //Length: 59
	}

	private int[] OptionalCalendars
	{
		 get { } //Length: 6
	}

	public string PMDesignator
	{
		 get { } //Length: 45
	}

	public string RFC1123Pattern
	{
		 get { } //Length: 6
	}

	public string ShortDatePattern
	{
		 get { } //Length: 43
		 set { } //Length: 215
	}

	public string ShortTimePattern
	{
		 get { } //Length: 38
		 set { } //Length: 214
	}

	public string SortableDateTimePattern
	{
		 get { } //Length: 63
	}

	public string TimeSeparator
	{
		 get { } //Length: 458
	}

	private string[] UnclonedLongDatePatterns
	{
		 get { } //Length: 48
	}

	private string[] UnclonedLongTimePatterns
	{
		 get { } //Length: 34
	}

	private string[] UnclonedShortDatePatterns
	{
		 get { } //Length: 48
	}

	private string[] UnclonedShortTimePatterns
	{
		 get { } //Length: 48
	}

	private string[] UnclonedYearMonthPatterns
	{
		 get { } //Length: 118
	}

	public string UniversalSortableDateTimePattern
	{
		 get { } //Length: 6
	}

	public string YearMonthPattern
	{
		 get { } //Length: 43
		 set { } //Length: 194
	}

	private static DateTimeFormatInfo() { }

	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal) { }

	public DateTimeFormatInfo() { }

	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	private void ClearTokenHashTable() { }

	public object Clone() { }

	internal TokenHashValue[] CreateTokenHashTable() { }

	public string[] get_AbbreviatedDayNames() { }

	internal string[] get_AbbreviatedEnglishEraNames() { }

	internal string[] get_AbbreviatedEraNames() { }

	public string[] get_AbbreviatedMonthNames() { }

	private string[] get_AllLongDatePatterns() { }

	private string[] get_AllLongTimePatterns() { }

	private string[] get_AllShortDatePatterns() { }

	private string[] get_AllShortTimePatterns() { }

	private string[] get_AllYearMonthPatterns() { }

	public string get_AMDesignator() { }

	public Calendar get_Calendar() { }

	internal CompareInfo get_CompareInfo() { }

	private CultureInfo get_Culture() { }

	private string get_CultureName() { }

	public static DateTimeFormatInfo get_CurrentInfo() { }

	public string get_DateSeparator() { }

	internal string get_DateTimeOffsetPattern() { }

	public string[] get_DayNames() { }

	internal string[] get_EraNames() { }

	internal DateTimeFormatFlags get_FormatFlags() { }

	public string get_FullDateTimePattern() { }

	internal string get_FullTimeSpanNegativePattern() { }

	internal string get_FullTimeSpanPositivePattern() { }

	internal string get_GeneralLongTimePattern() { }

	internal string get_GeneralShortTimePattern() { }

	internal bool get_HasForceTwoDigitYears() { }

	internal bool get_HasSpacesInDayNames() { }

	internal bool get_HasSpacesInMonthNames() { }

	internal bool get_HasYearMonthAdjustment() { }

	public static DateTimeFormatInfo get_InvariantInfo() { }

	public bool get_IsReadOnly() { }

	private string get_LanguageName() { }

	public string get_LongDatePattern() { }

	public string get_LongTimePattern() { }

	public string get_MonthDayPattern() { }

	public string[] get_MonthGenitiveNames() { }

	public string[] get_MonthNames() { }

	private int[] get_OptionalCalendars() { }

	public string get_PMDesignator() { }

	public string get_RFC1123Pattern() { }

	public string get_ShortDatePattern() { }

	public string get_ShortTimePattern() { }

	public string get_SortableDateTimePattern() { }

	public string get_TimeSeparator() { }

	private string[] get_UnclonedLongDatePatterns() { }

	private string[] get_UnclonedLongTimePatterns() { }

	private string[] get_UnclonedShortDatePatterns() { }

	private string[] get_UnclonedShortTimePatterns() { }

	private string[] get_UnclonedYearMonthPatterns() { }

	public string get_UniversalSortableDateTimePattern() { }

	public string get_YearMonthPattern() { }

	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	public string GetAbbreviatedEraName(int era) { }

	public string GetAbbreviatedMonthName(int month) { }

	public string[] GetAllDateTimePatterns(char format) { }

	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	public string GetDayName(DayOfWeek dayofweek) { }

	public string GetEraName(int era) { }

	public object GetFormat(Type formatType) { }

	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	public string GetMonthName(int month) { }

	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	private static bool InitPreferExistingTokens() { }

	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	private string[] internalGetAbbreviatedMonthNames() { }

	private string[] internalGetDayOfWeekNames() { }

	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	internal string[] internalGetLeapYearMonthNames() { }

	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	private string[] internalGetMonthNames() { }

	private static bool IsHebrewChar(char ch) { }

	private void OnDeserialized(StreamingContext ctx) { }

	private void OnSerializing(StreamingContext ctx) { }

	public void set_Calendar(Calendar value) { }

	public void set_LongDatePattern(string value) { }

	public void set_LongTimePattern(string value) { }

	public void set_ShortDatePattern(string value) { }

	public void set_ShortTimePattern(string value) { }

	public void set_YearMonthPattern(string value) { }

	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

}

