//Type is in global namespace

public static class Localization
{
	public delegate LoadFunction
	{

		public LoadFunction(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string path, AsyncCallback callback, object object) { }

		public virtual byte[] EndInvoke(IAsyncResult result) { }

		public virtual byte[] Invoke(string path) { }

	}

	public delegate OnLocalizeNotification
	{

		public OnLocalizeNotification(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public static LoadFunction loadFunction; //Field offset: 0x0
	public static OnLocalizeNotification onLocalize; //Field offset: 0x4
	public static bool localizationHasBeenSet; //Field offset: 0x8
	private static string[] mLanguages; //Field offset: 0xC
	private static Dictionary<string, string> mOldDictionary; //Field offset: 0x10
	private static Dictionary<string, string[]> mDictionary; //Field offset: 0x14
	private static Dictionary<string, string> mReplacement; //Field offset: 0x18
	private static int mLanguageIndex; //Field offset: 0x1C
	private static string mLanguage; //Field offset: 0x20
	private static bool mMerging; //Field offset: 0x24

	public static Dictionary<string, string[]> dictionary
	{
		 get { } //Length: 304
		 set { } //Length: 529
	}

	public static bool isActive
	{
		 get { } //Length: 288
	}

	public static string[] knownLanguages
	{
		 get { } //Length: 214
	}

	public static string language
	{
		 get { } //Length: 214
		 set { } //Length: 113
	}

	private static Localization() { }

	private static void AddCSV(BetterList<string> newValues, string[] newLanguages, Dictionary<string, int> languageIndices) { }

	public static void ClearReplacements() { }

	public static bool Exists(string key) { }

	private static string[] ExtractStrings(BetterList<string> added, string[] newLanguages, Dictionary<string, int> languageIndices) { }

	public static string Format(string key, object[] parameters) { }

	public static string Get(string key, bool warnIfMissing = true) { }

	public static Dictionary<string, string[]> get_dictionary() { }

	public static bool get_isActive() { }

	public static string[] get_knownLanguages() { }

	public static string get_language() { }

	private static bool HasLanguage(string languageName) { }

	public static void Load(TextAsset asset) { }

	private static bool LoadAndSelect(string value) { }

	private static bool LoadCSV(byte[] bytes, TextAsset asset, bool merge = false) { }

	public static bool LoadCSV(byte[] bytes, bool merge = false) { }

	public static bool LoadCSV(TextAsset asset, bool merge = false) { }

	private static bool LoadDictionary(string value, bool merge = false) { }

	public static string Localize(string key) { }

	public static bool Reload() { }

	public static void ReplaceKey(string key, string val) { }

	private static bool SelectLanguage(string language) { }

	public static void Set(string languageName, Dictionary<string, string> dictionary) { }

	public static void Set(string key, string value) { }

	public static void Set(string languageName, byte[] bytes) { }

	public static void Set(string language, string key, string text) { }

	public static void set_dictionary(Dictionary<string, string[]> value) { }

	public static void set_language(string value) { }

}

