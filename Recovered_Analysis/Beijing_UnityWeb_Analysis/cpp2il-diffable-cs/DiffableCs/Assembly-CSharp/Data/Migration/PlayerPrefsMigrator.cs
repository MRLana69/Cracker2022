namespace Data.Migration;

public class PlayerPrefsMigrator
{
	private const int MIGRATE_VERSION = 1; //Field offset: 0x0
	private const string LAST_SEEN_BUNDLE_VERSION_KEY = "lastSeenBundleVersionKey"; //Field offset: 0x0
	private const string LAST_EVENT_SHOWN_TIMESTAMP_KEY = "lastEventShownTimestamp"; //Field offset: 0x0
	private const string LAST_EVENT_TYPE_SHOWN_KEY = "lastEventTypeShown"; //Field offset: 0x0
	private const string BREADCRUMBS_KEY = "breadcrumbs"; //Field offset: 0x0
	private const string KEY_FIRST_TIME_RUN = "SetShouldShowPopupToFalse"; //Field offset: 0x0
	private const string AWARDS_FIRST_LOADED_KEY = "awardsFirstLoaded"; //Field offset: 0x0
	private const string AWARD_HASPAYED_OUT_KEY_PREFIX = "hasPayed"; //Field offset: 0x0
	private const string PrefsKeyPersistedSessionEventNumber = "SessionEventNumber"; //Field offset: 0x0
	private const string AWARD_ISNEW_KEY_PREFIX = "isAwardNew"; //Field offset: 0x0
	private const string HAS_LOGGED_FACEBOOK_LOGIN_KEY = "flurry_has_logged_fb"; //Field offset: 0x0
	private const string HAS_LOGGED_GAMECENTER_LOGIN_KEY = "flurry_has_logged_gc"; //Field offset: 0x0
	private const string OPTION_REMINDER_PREFERENCE_KEY = "OPTION_REMINDER_PREFERENCE"; //Field offset: 0x0
	private const string OPTION_REMINDER_DEFAULT_OFF_KEY = "OPTION_REMINDER_WITH_DEFAULT_OFF"; //Field offset: 0x0
	private const string OPTION_TOPRUNCHALLENGERS_KEY = "OPTION_TOPRUNCHALLENGERS"; //Field offset: 0x0
	private const string OPTION_MUSIC_KEY = "OPTION_MUSIC"; //Field offset: 0x0
	private const string OPTION_SFX_KEY = "OPTION_SFX"; //Field offset: 0x0
	private const string HAS_LOGGED_DAILY_EVENT_SOCIAL_PREFIX = "socflurdaily"; //Field offset: 0x0
	private static string _lastKeyRead; //Field offset: 0x0

	private static PlayerPrefsMigrator() { }

	public PlayerPrefsMigrator() { }

	public static bool CanMigrate() { }

	public static bool HasPlayerPrefsKey(string key) { }

	public static void Migrate() { }

	public static void ResetMigratedVersion() { }

	public static void TryCleanPlayerPrefsKeys() { }

}

