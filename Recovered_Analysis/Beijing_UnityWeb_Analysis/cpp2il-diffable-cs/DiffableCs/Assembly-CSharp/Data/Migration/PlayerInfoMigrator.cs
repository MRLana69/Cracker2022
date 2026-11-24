namespace Data.Migration;

public static class PlayerInfoMigrator
{
	private class JsonObjectWrapper
	{
		private static string <lastLoadedKey>k__BackingField; //Field offset: 0x0
		private JsonObject _jsonObject; //Field offset: 0x8

		public static string lastLoadedKey
		{
			 get { } //Length: 97
			 set { } //Length: 2
		}

		public JsonObjectWrapper(JsonObject jsonObject) { }

		public T Get(string key, T defaultValue) { }

		public static string get_lastLoadedKey() { }

		public static void set_lastLoadedKey(string value) { }

	}

	private const string PLAYER_INFO_SECRET = "we12rtyuiklhgfdjerKJGHfvghyuhnjiokLJHl145rtyfghjvbn"; //Field offset: 0x0
	private const int VERSION = 1; //Field offset: 0x0
	private static Key _lastKeyRead; //Field offset: 0x0
	private const string TOPRUN_FILENAME_MANAGER = "toprun_manager"; //Field offset: 0x0
	private const string TOPRUN_FILENAME_PLAYER_IDS = "toprun_playerids"; //Field offset: 0x0
	private const string TOPRUN_FILENAME_RANKS = "toprun_ranks"; //Field offset: 0x0
	private const string TOPRUN_SALT = "GhgtrRFRfPLJhFDsWe#dEdrt5rfg56"; //Field offset: 0x0
	private const string LAST_SEEN_BUNDLE_VERSION_KEY = "lastSeenBundleVersionKey"; //Field offset: 0x0
	private const byte SOCIALDATA_VERSION = 2; //Field offset: 0x0
	private const string ADSYSTEM_FILE_SECRET = "KilooAdSystemInterstitialStatsSecret"; //Field offset: 0x0
	private static string _lastInterstitialStatsKey; //Field offset: 0x4

	private static PlayerInfoMigrator() { }

	public static bool CanMigrate() { }

	private static Dictionary<UpgradeType, int> ConvertLegacyPowerupsToUpgrades(Dictionary<PowerupTypeLegacy, int> legacyPowerups) { }

	private static CharacterNameEventData DeserializeCharacterEventDataFromJson(string characterNameData) { }

	private static string GetAdSystemFilePath(string folderPath) { }

	private static string GetAdSystemFolderPath() { }

	private static string GetSavePath() { }

	private static string GetSocialDataSavePath() { }

	private static bool InterstitialStatsTryGetValueNotNull(IDictionary<string, object> dict, string key, out object obj) { }

	private static IDictionary<string, object> LoadAdSystemDataFile() { }

	private static bool[] LoadBoolArray(Dictionary<Key, string> dict, Key key, bool[] defaultValue) { }

	private static int[] LoadIntArray(Dictionary<Key, string> dict, Key key, int[] defaultValue) { }

	public static PlayerInfoData LoadPlayerInfoData() { }

	private static Dictionary<string, Status> LoadSocialDataFile() { }

	private static object LoadTopRunJsonFile(string file) { }

	private static void LogMigrationFail(string lastKey, Exception exception) { }

	public static void Migrate() { }

	private static bool MigrateAdsSave(Dictionary<Key, string> mainPlayerData, IDictionary<string, object> adSystemData) { }

	private static bool MigrateAnalyticsSave(Dictionary<Key, string> mainPlayerData) { }

	private static bool MigrateEventsSave(Dictionary<Key, string> mainPlayerData) { }

	private static bool MigrateInventorySave(Dictionary<Key, string> mainPlayerData) { }

	private static bool MigrateOnboardingSave(Dictionary<Key, string> mainPlayerData) { }

	private static bool MigratePlayerSave(Dictionary<Key, string> mainPlayerData) { }

	private static bool MigratePowerups(Dictionary<PowerupTypeLegacy, int> upgradeAmounts) { }

	private static bool MigratePreferencesSave(Dictionary<Key, string> mainPlayerData) { }

	private static void MigrateSocialSave(Dictionary<string, Status> socialData) { }

	private static void MigrateStatistics(string s) { }

	private static bool MigrateSyboAnalyticsSave(Dictionary<Key, string> mainPlayerData) { }

	private static void MigrateTopRunSave(Dictionary<Key, string> mainPlayerData, IDictionary manager, IDictionary playerIds, IDictionary ranks) { }

	private static bool MigrateUpgrades(Dictionary<PowerupTypeLegacy, int> upgradeTiers) { }

	private static bool MigrateUserSave(Dictionary<Key, string> mainPlayerData) { }

	private static Dictionary<string, Status> ReadSocialData(Stream stream) { }

	private static void SaveAdSystemDataFile(IDictionary<string, object> adSystemData) { }

	public static void SavePlayerInfoData(PlayerInfoData playerInfoData) { }

	private static void SaveSocialDataFile(Dictionary<string, Status> friendStatus) { }

	private static void SaveTopRunJsonFile(string file, object json) { }

	private static bool TryGetLoadPaths(out string path) { }

	private static bool TryLoadBool(Dictionary<Key, string> dict, Key key, out bool boolToSet) { }

	private static bool TryLoadDateTime(Dictionary<Key, string> dict, Key key, out DateTime valueToSet) { }

	private static bool TryLoadEnum(Dictionary<Key, string> dict, Key key, out T enumToSet) { }

	private static bool TryLoadFloat(Dictionary<Key, string> dict, Key key, out float floatToSet) { }

	private static bool TryLoadInt(Dictionary<Key, string> dict, Key key, out int intToSet) { }

	private static bool TryLoadLong(Dictionary<Key, string> dict, Key key, out long longToSet) { }

	private static bool TryLoadString(Dictionary<Key, string> dict, Key key, out string stringToSet) { }

	private static void WriteSocialData(Stream stream, Dictionary<string, Status> friendStatus) { }

}

