namespace Data.Save;

public class SyboAnalyticsSave
{

	public static bool isSyboAnalyticsUserIdAssigned
	{
		 get { } //Length: 54
	}

	public static bool kilooAnalyticsHasLoggedSyboUserId
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static int persistedSessionEventNumber
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static string syboAggregatedDataString
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int syboAnalyticsCurrentSession
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static string syboAnalyticsDeviceID
	{
		 get { } //Length: 50
		 set { } //Length: 55
	}

	public static int syboAnalyticsGamesSinceFlush
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int syboAnalyticsGpuScore
	{
		 get { } //Length: 50
		 set { } //Length: 52
	}

	public static string syboAnalyticsOnlineSettingsLocale
	{
		 get { } //Length: 50
		 set { } //Length: 52
	}

	public static string syboAnalyticsOperatingSystem
	{
		 get { } //Length: 50
		 set { } //Length: 55
	}

	public static string syboAnalyticsOSLanguage
	{
		 get { } //Length: 50
		 set { } //Length: 55
	}

	public static Dictionary<string, string> syboAnalyticsPendingOfferRewardToOfferIdMap
	{
		 get { } //Length: 50
		 set { } //Length: 55
	}

	public static PerformanceLevel syboAnalyticsPerformanceLevel
	{
		 get { } //Length: 50
		 set { } //Length: 55
	}

	public static string syboAnalyticsPreviousClientVersion
	{
		 get { } //Length: 50
		 set { } //Length: 52
	}

	public static SampleState syboAnalyticsSampleState
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static Dictionary<string, string> syboAnalyticsUnhandledAbTestData
	{
		 get { } //Length: 53
		 set { } //Length: 55
	}

	public static string syboAnalyticsUserId
	{
		 get { } //Length: 51
		 set { } //Length: 49
	}

	public SyboAnalyticsSave() { }

	public static bool get_isSyboAnalyticsUserIdAssigned() { }

	public static bool get_kilooAnalyticsHasLoggedSyboUserId() { }

	public static int get_persistedSessionEventNumber() { }

	public static string get_syboAggregatedDataString() { }

	public static int get_syboAnalyticsCurrentSession() { }

	public static string get_syboAnalyticsDeviceID() { }

	public static int get_syboAnalyticsGamesSinceFlush() { }

	public static int get_syboAnalyticsGpuScore() { }

	public static string get_syboAnalyticsOnlineSettingsLocale() { }

	public static string get_syboAnalyticsOperatingSystem() { }

	public static string get_syboAnalyticsOSLanguage() { }

	public static Dictionary<string, string> get_syboAnalyticsPendingOfferRewardToOfferIdMap() { }

	public static PerformanceLevel get_syboAnalyticsPerformanceLevel() { }

	public static string get_syboAnalyticsPreviousClientVersion() { }

	public static SampleState get_syboAnalyticsSampleState() { }

	public static Dictionary<string, string> get_syboAnalyticsUnhandledAbTestData() { }

	public static string get_syboAnalyticsUserId() { }

	public static void set_kilooAnalyticsHasLoggedSyboUserId(bool value) { }

	public static void set_persistedSessionEventNumber(int value) { }

	public static void set_syboAggregatedDataString(string value) { }

	public static void set_syboAnalyticsCurrentSession(int value) { }

	public static void set_syboAnalyticsDeviceID(string value) { }

	public static void set_syboAnalyticsGamesSinceFlush(int value) { }

	public static void set_syboAnalyticsGpuScore(int value) { }

	public static void set_syboAnalyticsOnlineSettingsLocale(string value) { }

	public static void set_syboAnalyticsOperatingSystem(string value) { }

	public static void set_syboAnalyticsOSLanguage(string value) { }

	public static void set_syboAnalyticsPendingOfferRewardToOfferIdMap(Dictionary<string, string> value) { }

	public static void set_syboAnalyticsPerformanceLevel(PerformanceLevel value) { }

	public static void set_syboAnalyticsPreviousClientVersion(string value) { }

	public static void set_syboAnalyticsSampleState(SampleState value) { }

	public static void set_syboAnalyticsUnhandledAbTestData(Dictionary<string, string> value) { }

	public static void set_syboAnalyticsUserId(string value) { }

	public static void SyboAnalyticsAddPendingOfferReward(string rewardAmount, long offerId) { }

	public static void SyboAnalyticsAddUnhandledAbTestData(string testTag, int segmentIndex) { }

	public static void SyboAnalyticsClearPendingOffers() { }

	public static void SyboAnalyticsClearUnhandledAbTestData() { }

	public static Dictionary<string, string> SyboAnalyticsGetPendingOfferRewards() { }

	public static void SyboAnalyticsRemovePendingOffer(string rewardAmount) { }

}

