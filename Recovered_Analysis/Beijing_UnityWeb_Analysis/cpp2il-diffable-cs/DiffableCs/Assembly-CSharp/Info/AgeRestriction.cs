namespace Info;

public static class AgeRestriction
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__25_0(RefreshType type) { }

	}

	private const string ONLINESETTINGS_AGE_RESTRICTION_THRESHOLD_KEY = "age_restriction_threshold"; //Field offset: 0x0
	private const string ONLINESETTINGS_AGE_RESTRICTION_VERSION_KEY = "age_restriction_version"; //Field offset: 0x0
	private const string ONLINESETTINGS_AGE_RESTRICTION_GLOBAL_DEFAULT_KEY = "age_restriction_global_default"; //Field offset: 0x0
	private const int AGE_RESTRICTION_GLOBAL_THRESHOLD_DEFAULT = 13; //Field offset: 0x0
	private const int AGE_RESTRICTION_VERSION_DEFAULT = 0; //Field offset: 0x0
	private static Action restrictionChanged; //Field offset: 0x0
	public static bool shouldSendAgeEvent; //Field offset: 0x4
	public static bool shouldSendConsentEvent; //Field offset: 0x5
	private static bool <countryCodeRestricted>k__BackingField; //Field offset: 0x6
	private static bool _userAgeRegistered; //Field offset: 0x7
	private static readonly string CACHED_COUNTRY_CODE; //Field offset: 0x8
	private static readonly Dictionary<string, int> DEFAULT_COUNTRY_CODE_RESTRICTIONS; //Field offset: 0xC

	public static event Action restrictionChanged
	{
		 add { } //Length: 2
		 remove { } //Length: 206
	}

	public static bool countryCodeRestricted
	{
		 get { } //Length: 176
		private set { } //Length: 206
	}

	public static bool isRestricted
	{
		 get { } //Length: 233
	}

	public static bool shouldDisplayPopup
	{
		 get { } //Length: 236
	}

	public static bool shouldShowBehaviouralAdsConsentPopup
	{
		 get { } //Length: 143
	}

	public static bool waitForAgeRestriction
	{
		 get { } //Length: 176
	}

	private static AgeRestriction() { }

	public static void add_restrictionChanged(Action value) { }

	private static void FireRestrictionChangedEvent() { }

	public static bool get_countryCodeRestricted() { }

	public static bool get_isRestricted() { }

	public static bool get_shouldDisplayPopup() { }

	public static bool get_shouldShowBehaviouralAdsConsentPopup() { }

	public static bool get_waitForAgeRestriction() { }

	private static int GetAgeThreshold() { }

	public static int GetUserAge() { }

	public static DateTime GetUserBirthday() { }

	private static bool HasValidData() { }

	private static bool IsAgeRestricted() { }

	private static bool IsConsentGiven() { }

	private static bool IsCountryRestricted() { }

	private static void Log(string msg) { }

	private static void LogBirthdayChanged() { }

	private static void OnlineSettingsDownloaded() { }

	public static void RegisterConsent(bool given) { }

	public static void RegisterUserBirthday(DateTime birthday) { }

	public static void remove_restrictionChanged(Action value) { }

	private static void set_countryCodeRestricted(bool value) { }

}

