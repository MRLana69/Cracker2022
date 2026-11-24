namespace Data.Save;

public class MigrationSave
{
	private const char DATA_CHUNK_SEPARATOR = '\u3B'; //Field offset: 0x0
	private const char DATA_ASSIGNATION_SEPARATOR = '\u3D'; //Field offset: 0x0
	private const char DATA_VALUE_GROUP_SEPARATOR = '\u2C'; //Field offset: 0x0
	private const char DATA_VALUE_SEPARATOR = '\u3A'; //Field offset: 0x0
	private const char DATA_THEME_IDENTIFIER_SEPARATOR = '\u23'; //Field offset: 0x0

	public MigrationSave() { }

	private static Dictionary<ThemeIdentifier, BoardThemeData> GetCustomizationValues(string rawValues) { }

	public static Dictionary<AwardId, PersistentAwardProgress> MigrateAwardProgress(string rawProgress) { }

	public static void MigrateBoards(string unlockedHoverboards) { }

	public static void MigrateBoardThemeData(string data) { }

	public static void MigrateCharacters(int[] characterTokens) { }

	public static Dictionary<Id, string> MigrateEarnCurrencyData(string rawList) { }

	public static void MigratePendingRewards(string rewardsAsString) { }

	public static void MigrateUnlockedOutfits(Dictionary<CharacterId, int[]> migrateDict) { }

	private static PersistentAwardProgress ParseAwardProgress(string val) { }

	public static CollectCoinsDummy[] ParseDummyData(string rawData) { }

	public static void SetPowerups(Dictionary<UpgradeType, int> powerups) { }

	public static void SetUpgrades(Dictionary<UpgradeType, int> upgrades) { }

	private static bool TryParseDummy(string rawDummyData, out CollectCoinsDummy dummy) { }

}

