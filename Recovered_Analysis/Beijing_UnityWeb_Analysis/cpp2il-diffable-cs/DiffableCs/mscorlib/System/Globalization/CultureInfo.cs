namespace System.Globalization;

public class CultureInfo : ICloneable, IFormatProvider
{
	private struct Data
	{
		public int ansi; //Field offset: 0x0
		public int ebcdic; //Field offset: 0x4
		public int mac; //Field offset: 0x8
		public int oem; //Field offset: 0xC
		public bool right_to_left; //Field offset: 0x10
		public byte list_sep; //Field offset: 0x11

	}

	private static CultureInfo invariant_culture_info; //Field offset: 0x0
	private const string MSG_READONLY = "This instance is read only"; //Field offset: 0x0
	private const int CalendarTypeBits = 8; //Field offset: 0x0
	internal const int InvariantCultureId = 127; //Field offset: 0x0
	private static object shared_table_lock; //Field offset: 0x4
	private static CultureInfo default_current_culture; //Field offset: 0x8
	private static CultureInfo s_DefaultThreadCurrentUICulture; //Field offset: 0xC
	private static CultureInfo s_DefaultThreadCurrentCulture; //Field offset: 0x10
	private static Dictionary<int, CultureInfo> shared_by_number; //Field offset: 0x14
	private static Dictionary<string, CultureInfo> shared_by_name; //Field offset: 0x18
	internal static readonly bool IsTaiwanSku; //Field offset: 0x1C
	private bool m_isReadOnly; //Field offset: 0x8
	private int cultureID; //Field offset: 0xC
	private int parent_lcid; //Field offset: 0x10
	private int datetime_index; //Field offset: 0x14
	private int number_index; //Field offset: 0x18
	private int default_calendar_type; //Field offset: 0x1C
	private bool m_useUserOverride; //Field offset: 0x20
	internal NumberFormatInfo numInfo; //Field offset: 0x24
	internal DateTimeFormatInfo dateTimeInfo; //Field offset: 0x28
	private TextInfo textInfo; //Field offset: 0x2C
	internal string m_name; //Field offset: 0x30
	private string englishname; //Field offset: 0x34
	private string nativename; //Field offset: 0x38
	private string iso3lang; //Field offset: 0x3C
	private string iso2lang; //Field offset: 0x40
	private string win3lang; //Field offset: 0x44
	private string territory; //Field offset: 0x48
	private string[] native_calendar_names; //Field offset: 0x4C
	private CompareInfo compareInfo; //Field offset: 0x50
	private readonly void* textinfo_data; //Field offset: 0x54
	private int m_dataItem; //Field offset: 0x58
	private Calendar calendar; //Field offset: 0x5C
	private CultureInfo parent_culture; //Field offset: 0x60
	private bool constructed; //Field offset: 0x64
	internal byte[] cached_serialized_form; //Field offset: 0x68
	internal CultureData m_cultureData; //Field offset: 0x6C
	internal bool m_isInherited; //Field offset: 0x70

	public virtual Calendar Calendar
	{
		 get { } //Length: 6
	}

	internal int CalendarType
	{
		 get { } //Length: 7281
	}

	public virtual CompareInfo CompareInfo
	{
		 get { } //Length: 6
	}

	public static CultureInfo CurrentCulture
	{
		 get { } //Length: 89
	}

	public static CultureInfo CurrentUICulture
	{
		 get { } //Length: 13
	}

	public virtual DateTimeFormatInfo DateTimeFormat
	{
		 get { } //Length: 101
		 set { } //Length: 164
	}

	public static CultureInfo DefaultThreadCurrentCulture
	{
		 get { } //Length: 5
	}

	public static CultureInfo DefaultThreadCurrentUICulture
	{
		 get { } //Length: 89
	}

	public virtual string EnglishName
	{
		 get { } //Length: 131
	}

	public static CultureInfo InvariantCulture
	{
		 get { } //Length: 92
	}

	public virtual bool IsNeutralCulture
	{
		 get { } //Length: 479
	}

	public bool IsReadOnly
	{
		 get { } //Length: 23
	}

	public virtual int LCID
	{
		 get { } //Length: 6
	}

	public virtual string Name
	{
		 get { } //Length: 6
	}

	public virtual NumberFormatInfo NumberFormat
	{
		 get { } //Length: 39
		 set { } //Length: 36
	}

	public virtual CultureInfo Parent
	{
		 get { } //Length: 126
	}

	internal string SortName
	{
		 get { } //Length: 93
	}

	internal string Territory
	{
		 get { } //Length: 373
	}

	public virtual TextInfo TextInfo
	{
		 get { } //Length: 461
	}

	public virtual string ThreeLetterISOLanguageName
	{
		 get { } //Length: 416
	}

	public virtual string TwoLetterISOLanguageName
	{
		 get { } //Length: 23
	}

	internal static CultureInfo UserDefaultCulture
	{
		 get { } //Length: 77
	}

	internal static CultureInfo UserDefaultUICulture
	{
		 get { } //Length: 89
	}

	private static CultureInfo() { }

	private CultureInfo() { }

	private CultureInfo(string name, bool useUserOverride, bool read_only) { }

	public CultureInfo(string name, bool useUserOverride) { }

	public CultureInfo(string name) { }

	private CultureInfo(int culture, bool useUserOverride, bool read_only) { }

	public CultureInfo(int culture, bool useUserOverride) { }

	public CultureInfo(int culture) { }

	internal static void CheckDomainSafetyObject(object obj, object container) { }

	private void CheckNeutral() { }

	public virtual object Clone() { }

	private void Construct() { }

	private bool construct_internal_locale_from_lcid(int lcid) { }

	private bool construct_internal_locale_from_name(string name) { }

	internal static CultureInfo ConstructCurrentCulture() { }

	internal static CultureInfo ConstructCurrentUICulture() { }

	private void ConstructInvariant(bool read_only) { }

	private static Calendar CreateCalendar(int calendarType) { }

	internal static CultureInfo CreateCulture(string name, bool reference) { }

	private static Exception CreateNotFoundException(string name) { }

	public static CultureInfo CreateSpecificCulture(string name) { }

	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	private TextInfo CreateTextInfo(bool readOnly) { }

	public override bool Equals(object value) { }

	public virtual Calendar get_Calendar() { }

	internal int get_CalendarType() { }

	public virtual CompareInfo get_CompareInfo() { }

	private static string get_current_locale_name() { }

	public static CultureInfo get_CurrentCulture() { }

	public static CultureInfo get_CurrentUICulture() { }

	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	public virtual string get_EnglishName() { }

	public static CultureInfo get_InvariantCulture() { }

	public virtual bool get_IsNeutralCulture() { }

	public bool get_IsReadOnly() { }

	public virtual int get_LCID() { }

	public virtual string get_Name() { }

	public virtual NumberFormatInfo get_NumberFormat() { }

	public virtual CultureInfo get_Parent() { }

	internal string get_SortName() { }

	internal string get_Territory() { }

	public virtual TextInfo get_TextInfo() { }

	public virtual string get_ThreeLetterISOLanguageName() { }

	public virtual string get_TwoLetterISOLanguageName() { }

	internal static CultureInfo get_UserDefaultCulture() { }

	internal static CultureInfo get_UserDefaultUICulture() { }

	public static CultureInfo GetCultureInfo(string name) { }

	public static CultureInfo GetCultureInfo(int culture) { }

	public virtual object GetFormat(Type formatType) { }

	public override int GetHashCode() { }

	private Data GetTextInfoData() { }

	private static void insert_into_shared_tables(CultureInfo c) { }

	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	public override string ToString() { }

}

