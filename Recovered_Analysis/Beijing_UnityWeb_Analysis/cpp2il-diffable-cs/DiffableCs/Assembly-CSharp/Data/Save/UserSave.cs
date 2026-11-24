namespace Data.Save;

public class UserSave
{
	private static Action onKnownServerTimeChange; //Field offset: 0x0

	public static event Action onKnownServerTimeChange
	{
		 add { } //Length: 49
		 remove { } //Length: 206
	}

	public static int ageRestrictionInputMonth
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int ageRestrictionInputVersion
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int ageRestrictionInputYear
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static bool allAssetBundlesDownloaded
	{
		 get { } //Length: 54
		 set { } //Length: 56
	}

	public static BreadcrumbSave breadcrumbs
	{
		 get { } //Length: 54
		 set { } //Length: 56
	}

	public static Dictionary<CharacterId, HashSet<int>> characterOutfitsSeen
	{
		private get { } //Length: 51
		 set { } //Length: 53
	}

	public static bool cloudSaveEnabled
	{
		 get { } //Length: 51
		 set { } //Length: 96
	}

	public static CollectCoinsDummy[] collectCoinsDummyData
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static Dictionary<Id, string> earnCurrencyData
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static DateTime firstInstallDate
	{
		 get { } //Length: 51
		 set { } //Length: 6
	}

	public static string firstInstalledVersion
	{
		 get { } //Length: 54
		 set { } //Length: 96
	}

	public static bool hasAdRemovalUpgrade
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static Dictionary<BoardId, bool> hasBoardBeenSeen
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static Dictionary<CharacterId, bool> hasCharacterBeenSeen
	{
		 get { } //Length: 54
		 set { } //Length: 56
	}

	public static bool hasCloudSaveCelebrationBeenShown
	{
		 get { } //Length: 53
		 set { } //Length: 95
	}

	public static bool hasDoubleCoinsUpgrade
	{
		 get { } //Length: 54
		 set { } //Length: 81
	}

	public static bool hasMadeOneValidPurchase
	{
		 get { } //Length: 54
		 set { } //Length: 56
	}

	public static bool hasMigratedPlayerInfo
	{
		 get { } //Length: 51
		 set { } //Length: 206
	}

	public static bool hasPaidOutFacebookReward
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static bool hasPurchasedOrRestored
	{
		 get { } //Length: 50
	}

	public static bool hasSeenFrontScreenFirstTime
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static bool hasUserRunAppBefore
	{
		 get { } //Length: 50
		 set { } //Length: 52
	}

	public static int inAppConsumablePurchaseCount
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int inAppLegacyPurchaseCount
	{
		 get { } //Length: 233
		 set { } //Length: 155
	}

	public static int inAppNonConsumablePurchaseCount
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static Dictionary<string, string> inAppPurchaseHistory
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int inAppRestoredPurchaseCount
	{
		 get { } //Length: 51
		 set { } //Length: 53
	}

	public static int introductionPopupShownCount
	{
		 get { } //Length: 53
		 set { } //Length: 55
	}

	public static bool isFreshInstall
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static DateTime lastCloudSaveReminderShownTime
	{
		 get { } //Length: 50
		 set { } //Length: 91
	}

	public static DateTime lastDailyOnlineLog
	{
		 get { } //Length: 50
		 set { } //Length: 53
	}

	public static DateTime lastEventShownTimestamp
	{
		 get { } //Length: 50
		 set { } //Length: 6
	}

	public static SSEventType lastEventTypeShown
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static DateTime lastKnownServerTime
	{
		 get { } //Length: 51
		 set { } //Length: 6
	}

	public static DateTime lastPlayDate
	{
		 get { } //Length: 51
		 set { } //Length: 6
	}

	public static BundleTier lastPurchasedBundle
	{
		 get { } //Length: 54
		 set { } //Length: 96
	}

	public static DateTime lastQuitDate
	{
		 get { } //Length: 51
		 set { } //Length: 6
	}

	public static string lastSeenBundleVersion
	{
		 get { } //Length: 51
		 set { } //Length: 96
	}

	public static DateTime lastTimeAppWasUpdatedOrInstalled
	{
		 get { } //Length: 51
		 set { } //Length: 91
	}

	public static DateTime lastTimeAVideoForKeysWasSeen
	{
		 get { } //Length: 51
		 set { } //Length: 6
	}

	public static string lastVersionRated
	{
		 get { } //Length: 51
		 set { } //Length: 56
	}

	public static int latestAvailableAssetBundlesVersion
	{
		 get { } //Length: 54
		 set { } //Length: 56
	}

	public static DateTime latestSuccessfulCloudSaveSyncTime
	{
		 get { } //Length: 51
		 set { } //Length: 6
	}

	public static int migratedPlayerPrefsVersion
	{
		 get { } //Length: 53
		 set { } //Length: 55
	}

	public static int numberOfBreadCrumbsShownOnFrontPage
	{
		 get { } //Length: 50
		 set { } //Length: 95
	}

	public static DateTime welcomePackStartTime
	{
		 get { } //Length: 50
		 set { } //Length: 6
	}

	private static UserSave() { }

	public UserSave() { }

	public static void add_onKnownServerTimeChange(Action value) { }

	public static int get_ageRestrictionInputMonth() { }

	public static int get_ageRestrictionInputVersion() { }

	public static int get_ageRestrictionInputYear() { }

	public static bool get_allAssetBundlesDownloaded() { }

	public static BreadcrumbSave get_breadcrumbs() { }

	private static Dictionary<CharacterId, HashSet<int>> get_characterOutfitsSeen() { }

	public static bool get_cloudSaveEnabled() { }

	public static CollectCoinsDummy[] get_collectCoinsDummyData() { }

	public static Dictionary<Id, string> get_earnCurrencyData() { }

	public static DateTime get_firstInstallDate() { }

	public static string get_firstInstalledVersion() { }

	public static bool get_hasAdRemovalUpgrade() { }

	public static Dictionary<BoardId, bool> get_hasBoardBeenSeen() { }

	public static Dictionary<CharacterId, bool> get_hasCharacterBeenSeen() { }

	public static bool get_hasCloudSaveCelebrationBeenShown() { }

	public static bool get_hasDoubleCoinsUpgrade() { }

	public static bool get_hasMadeOneValidPurchase() { }

	public static bool get_hasMigratedPlayerInfo() { }

	public static bool get_hasPaidOutFacebookReward() { }

	public static bool get_hasPurchasedOrRestored() { }

	public static bool get_hasSeenFrontScreenFirstTime() { }

	public static bool get_hasUserRunAppBefore() { }

	public static int get_inAppConsumablePurchaseCount() { }

	public static int get_inAppLegacyPurchaseCount() { }

	public static int get_inAppNonConsumablePurchaseCount() { }

	public static Dictionary<string, string> get_inAppPurchaseHistory() { }

	public static int get_inAppRestoredPurchaseCount() { }

	public static int get_introductionPopupShownCount() { }

	public static bool get_isFreshInstall() { }

	public static DateTime get_lastCloudSaveReminderShownTime() { }

	public static DateTime get_lastDailyOnlineLog() { }

	public static DateTime get_lastEventShownTimestamp() { }

	public static SSEventType get_lastEventTypeShown() { }

	public static DateTime get_lastKnownServerTime() { }

	public static DateTime get_lastPlayDate() { }

	public static BundleTier get_lastPurchasedBundle() { }

	public static DateTime get_lastQuitDate() { }

	public static string get_lastSeenBundleVersion() { }

	public static DateTime get_lastTimeAppWasUpdatedOrInstalled() { }

	public static DateTime get_lastTimeAVideoForKeysWasSeen() { }

	public static string get_lastVersionRated() { }

	public static int get_latestAvailableAssetBundlesVersion() { }

	public static DateTime get_latestSuccessfulCloudSaveSyncTime() { }

	public static int get_migratedPlayerPrefsVersion() { }

	public static int get_numberOfBreadCrumbsShownOnFrontPage() { }

	public static DateTime get_welcomePackStartTime() { }

	public static void IncrementNumberOfBreadCrumbsShownOnFrontPage() { }

	public static bool IsCharacterOutfitSeen(CharacterId character, int index) { }

	public static void OutfitSeen(CharacterId character, int index) { }

	public static void remove_onKnownServerTimeChange(Action value) { }

	public static void set_ageRestrictionInputMonth(int value) { }

	public static void set_ageRestrictionInputVersion(int value) { }

	public static void set_ageRestrictionInputYear(int value) { }

	public static void set_allAssetBundlesDownloaded(bool value) { }

	public static void set_breadcrumbs(BreadcrumbSave value) { }

	public static void set_characterOutfitsSeen(Dictionary<CharacterId, HashSet<int>> value) { }

	public static void set_cloudSaveEnabled(bool value) { }

	public static void set_collectCoinsDummyData(CollectCoinsDummy[] value) { }

	public static void set_earnCurrencyData(Dictionary<Id, string> value) { }

	public static void set_firstInstallDate(DateTime value) { }

	public static void set_firstInstalledVersion(string value) { }

	public static void set_hasAdRemovalUpgrade(bool value) { }

	public static void set_hasBoardBeenSeen(Dictionary<BoardId, bool> value) { }

	public static void set_hasCharacterBeenSeen(Dictionary<CharacterId, bool> value) { }

	public static void set_hasCloudSaveCelebrationBeenShown(bool value) { }

	public static void set_hasDoubleCoinsUpgrade(bool value) { }

	public static void set_hasMadeOneValidPurchase(bool value) { }

	public static void set_hasMigratedPlayerInfo(bool value) { }

	public static void set_hasPaidOutFacebookReward(bool value) { }

	public static void set_hasSeenFrontScreenFirstTime(bool value) { }

	public static void set_hasUserRunAppBefore(bool value) { }

	public static void set_inAppConsumablePurchaseCount(int value) { }

	public static void set_inAppLegacyPurchaseCount(int value) { }

	public static void set_inAppNonConsumablePurchaseCount(int value) { }

	public static void set_inAppPurchaseHistory(Dictionary<string, string> value) { }

	public static void set_inAppRestoredPurchaseCount(int value) { }

	public static void set_introductionPopupShownCount(int value) { }

	public static void set_isFreshInstall(bool value) { }

	public static void set_lastCloudSaveReminderShownTime(DateTime value) { }

	public static void set_lastDailyOnlineLog(DateTime value) { }

	public static void set_lastEventShownTimestamp(DateTime value) { }

	public static void set_lastEventTypeShown(SSEventType value) { }

	public static void set_lastKnownServerTime(DateTime value) { }

	public static void set_lastPlayDate(DateTime value) { }

	public static void set_lastPurchasedBundle(BundleTier value) { }

	public static void set_lastQuitDate(DateTime value) { }

	public static void set_lastSeenBundleVersion(string value) { }

	public static void set_lastTimeAppWasUpdatedOrInstalled(DateTime value) { }

	public static void set_lastTimeAVideoForKeysWasSeen(DateTime value) { }

	public static void set_lastVersionRated(string value) { }

	public static void set_latestAvailableAssetBundlesVersion(int value) { }

	public static void set_latestSuccessfulCloudSaveSyncTime(DateTime value) { }

	public static void set_migratedPlayerPrefsVersion(int value) { }

	public static void set_numberOfBreadCrumbsShownOnFrontPage(int value) { }

	public static void set_welcomePackStartTime(DateTime value) { }

}

