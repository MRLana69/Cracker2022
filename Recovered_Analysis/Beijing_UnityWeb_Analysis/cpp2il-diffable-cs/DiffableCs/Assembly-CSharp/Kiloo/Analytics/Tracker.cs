namespace Kiloo.Analytics;

internal static class Tracker
{
	internal const string EVENT_NAME_RUN_ENDED = "run_ended"; //Field offset: 0x0
	private const string EVENT_NAME_CONSENT_WITHDRAWN = "cons_with"; //Field offset: 0x0
	private const string EVENT_NAME_CONSENT_GIVEN = "cons_give"; //Field offset: 0x0
	private const string PARAMETER_PLAYER_BIRTHDAY_MONTH = "month"; //Field offset: 0x0
	private const string PARAMETER_PLAYER_BIRTHDAY_YEAR = "year"; //Field offset: 0x0
	private const string EVENT_NAME_PLAYER_BIRTHDAY = "bday"; //Field offset: 0x0
	private const string PARAMETER_SYBO_USER_ID = "uid"; //Field offset: 0x0
	private const string EVENT_NAME_SYBO_USER_ID = "sybo_id"; //Field offset: 0x0
	private const string PARAMETER_ABTEST_PAYLOAD = "pl"; //Field offset: 0x0
	private const string PARAMETER_ABTEST_IDENTIFIER = "id"; //Field offset: 0x0
	private const string EVENT_NAME_ABTEST_DAILY_REPORT = "abtest_day"; //Field offset: 0x0
	private const string PARAMETER_IAP_INSTALL_DATE = "inst_date"; //Field offset: 0x0
	private const string PARAMETER_IAP_PRODUCT_LOCALIZED_PRICE = "loc_price"; //Field offset: 0x0
	private const string PARAMETER_IAP_PRODUCT_ID = "pid"; //Field offset: 0x0
	private const string EVENT_NAME_IN_APP_PURCHASE = "iap_val"; //Field offset: 0x0
	private const string PARAMETER_CONSENT_RESULT = "res"; //Field offset: 0x0
	private const string EVENT_NAME_MADE_ONE_PURCHASE = "one_iap"; //Field offset: 0x0
	private const string EVENT_NAME_DAILY_DATA = "daily"; //Field offset: 0x0
	private const string PARAMETER_DATA_FLURRY_ID = "flurry"; //Field offset: 0x0
	private const string PARAMETER_DATA_INSTALL_DATE = "inst_date"; //Field offset: 0x0
	private const string EVENT_NAME_STATIC_DATA = "static"; //Field offset: 0x0
	internal const string PARAMETER_CHARACTER_LETTERS_COLLECTED_IN_RUN = "c_let_cnt"; //Field offset: 0x0
	internal const string PARAMETER_DAILY_LETTERS_COLLECTED_IN_RUN = "d_let_cnt"; //Field offset: 0x0
	internal const string PARAMETER_FIRST_MYSTERY_BOX_COLLECTED_IN_RUN = "MB1_sec"; //Field offset: 0x0
	internal const string PARAMETER_MYSTERY_BOXES_COLLECTED_IN_RUN = "MB_cnt"; //Field offset: 0x0
	internal const string PARAMETER_RUN_WAS_ABORTED = "aborted"; //Field offset: 0x0
	internal const string PARAMETER_HOVERBOARD_COUNT_IN_RUN = "hovb_count"; //Field offset: 0x0
	internal const string PARAMETER_BASE_MULTIPLIER_START_OF_RUN = "multiply"; //Field offset: 0x0
	internal const string PARAMETER_RUN_LENGTH_UNTIL_FIRST_SAVE_ME = "len_save"; //Field offset: 0x0
	internal const string PARAMETER_SAVE_ME_COUNT_IN_RUN = "save_count"; //Field offset: 0x0
	internal const string PARAMETER_RUN_LENGTH = "len_sec"; //Field offset: 0x0
	private const string PARAMETER_DEVICE_LOCALE = "locale"; //Field offset: 0x0
	private const string EVENT_NAME_CONSENT_PRIVACY_POLICY_LINK_OPENED = "cons_privacy"; //Field offset: 0x0

	public static void CreateEvent(EventType eventType, Action<Event> onLogReady, string extra = null) { }

	private static Event GetABTestDailyReportValue(string identifier) { }

	private static Event GetConsentGivenEvent() { }

	private static Event GetConsentPrivacyLinkClickedEvent() { }

	private static Event GetConsentWithdrawnEvent(string result) { }

	private static Event GetDailyData() { }

	private static Event GetPlayerBirthday() { }

	private static Event GetSingleValidPurchase() { }

	private static Event GetStaticData() { }

	private static Event GetSyboUserId() { }

	private static Event GetValidInAppPurchase(string productId) { }

	private static bool IsDateToday(DateTime lastDate) { }

	private static void Log(string msg, Object context = null) { }

}

