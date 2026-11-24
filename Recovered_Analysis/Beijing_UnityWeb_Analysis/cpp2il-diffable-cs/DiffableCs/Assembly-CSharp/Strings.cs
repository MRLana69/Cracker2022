//Type is in global namespace

public static class Strings
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<StringsLanguage> <>9__18_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <OnRefresh>b__18_0(StringsLanguage x) { }

	}

	private sealed class <>c__DisplayClass19_0
	{
		public Locale locale; //Field offset: 0x8

		public <>c__DisplayClass19_0() { }

		internal bool <DetermineBestLanguage>b__0(StringsLanguage x) { }

		internal bool <DetermineBestLanguage>b__1(StringsLanguage x) { }

		internal bool <DetermineBestLanguage>b__2(StringsLanguage x) { }

	}

	private sealed class <>c__DisplayClass27_0
	{
		public StringsLanguage value; //Field offset: 0x8

		public <>c__DisplayClass27_0() { }

		internal bool <set_language>b__0(StringsLanguage x) { }

	}

	public class StringsLanguage
	{
		public Locale locale; //Field offset: 0x8
		public string resourcesPath; //Field offset: 0xC

		public StringsLanguage() { }

	}

	private static Dictionary<string, string> _currentLanguageMap; //Field offset: 0x0
	private const string LOCALE_FILE_ENDING = "_locale"; //Field offset: 0x0
	private const string RESOURCE_FOLDER_PATH = "Kiloo/LocalizationManager/text"; //Field offset: 0x0
	private static Dictionary<string, string> _defaultLanguageMap; //Field offset: 0x4
	public static bool gibberish; //Field offset: 0x8
	private static Action languageChanged; //Field offset: 0xC
	private static StringsLanguage _language; //Field offset: 0x10
	private static StringsLanguage <defaultLanguage>k__BackingField; //Field offset: 0x14
	public static List<StringsLanguage> languages; //Field offset: 0x18
	private static bool _hasInited; //Field offset: 0x1C
	private static readonly IJsonSerializer _jsonConverter; //Field offset: 0x20

	public static event Action languageChanged
	{
		 add { } //Length: 9
		 remove { } //Length: 209
	}

	public static CultureInfo cultureInfo
	{
		 get { } //Length: 89
	}

	public static StringsLanguage defaultLanguage
	{
		 get { } //Length: 77
		private set { } //Length: 209
	}

	public static StringsLanguage language
	{
		 get { } //Length: 1418
		 set { } //Length: 411
	}

	private static Strings() { }

	public static void add_languageChanged(Action value) { }

	private static string AddLocaleSuffix(string key) { }

	public static Dictionary<string, string> DeserializeObject(string s) { }

	public static StringsLanguage DetermineBestLanguage() { }

	public static string Get(string key) { }

	public static CultureInfo get_cultureInfo() { }

	public static StringsLanguage get_defaultLanguage() { }

	public static StringsLanguage get_language() { }

	public static string GetDefault(string key) { }

	private static string GetFromMap(string key, Dictionary<string, string> map) { }

	public static string GetLegal(string key) { }

	public static CultureInfo GetLegalCultureInfo() { }

	public static string GetLocalizedOnlineSettings(string key, string defaultValue) { }

	public static bool HasLocalizedOnlineSettings(string key) { }

	public static void Init(LocaleData data) { }

	public static bool IsMapped(string keyString) { }

	private static Dictionary<string, string> LoadLanguageMap(StringsLanguage lang, bool forceLoad = false) { }

	private static void Log(string text, Object context = null) { }

	private static void OnRefresh(RefreshType refreshType) { }

	public static void remove_languageChanged(Action value) { }

	public static string SerializeObject(Dictionary<string, string> data) { }

	private static void set_defaultLanguage(StringsLanguage value) { }

	public static void set_language(StringsLanguage value) { }

	public static bool TryGetLocalizedOnlineSettings(string key, out string valueString) { }

	private static void VerifyLocaleResources() { }

}

