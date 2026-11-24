namespace Kiloo.Common.LocalizationManager;

public class LocaleData : ScriptableObject
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<SerializableLocale> <>9__4_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <Load>b__4_0(SerializableLocale x) { }

	}

	private struct SerializableLocale
	{
		public string nativeName; //Field offset: 0x0
		public bool isEnabled; //Field offset: 0x4
		public string language; //Field offset: 0x8
		public string region; //Field offset: 0xC
		public string[] extraRegions; //Field offset: 0x10

	}

	private const string RESOURCE_PATH = "Kiloo/LocalizationManager/LocaleData"; //Field offset: 0x0
	private static LocaleData _instance; //Field offset: 0x0
	public Locale[] supportedLocales; //Field offset: 0xC
	public Dictionary<string, string> nativeNames; //Field offset: 0x10
	private List<SerializableLocale> _locales; //Field offset: 0x14

	public Locale defaultLocale
	{
		 get { } //Length: 66
	}

	public static LocaleData instance
	{
		 get { } //Length: 168
	}

	public LocaleData() { }

	public Locale get_defaultLocale() { }

	public static LocaleData get_instance() { }

	private void Load() { }

}

