namespace Data.Save;

public class InventorySave
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<CelebrationReward> <>9__54_1; //Field offset: 0x4
		public static Predicate<CelebrationReward> <>9__54_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RemovePendingReward>b__54_1(CelebrationReward reward) { }

		internal bool <RemovePendingReward>b__54_2(CelebrationReward reward) { }

	}

	private sealed class <>c__DisplayClass53_0
	{
		public Func<CelebrationRewardOrigin, int> getRewardPriority; //Field offset: 0x8

		public <>c__DisplayClass53_0() { }

		internal int <AddPendingReward>b__0(CelebrationReward first, CelebrationReward second) { }

	}

	private sealed class <>c__DisplayClass54_0
	{
		public CelebrationReward rewardToRemove; //Field offset: 0x8

		public <>c__DisplayClass54_0() { }

		internal bool <RemovePendingReward>b__0(CelebrationReward reward) { }

	}

	private static Action coinsChanged; //Field offset: 0x0
	private static Action keysChanged; //Field offset: 0x4
	private static Action<UpgradeType, int> powerupsChanged; //Field offset: 0x8
	private static CelebrationReward <lastAddedReward>k__BackingField; //Field offset: 0xC

	public static event Action coinsChanged
	{
		 add { } //Length: 49
		 remove { } //Length: 126
	}

	public static event Action keysChanged
	{
		 add { } //Length: 126
		 remove { } //Length: 129
	}

	public static event Action<UpgradeType, int> powerupsChanged
	{
		 add { } //Length: 129
		 remove { } //Length: 129
	}

	public static Dictionary<BoardId, Dictionary<ThemeIdentifier, BoardThemeData>> boardThemeData
	{
		 get { } //Length: 50
	}

	public static int coins
	{
		 get { } //Length: 92
		private set { } //Length: 114
	}

	public static Dictionary<CharacterId, int> collectedCharacterTokens
	{
		 get { } //Length: 50
	}

	public static int keys
	{
		 get { } //Length: 54
		private set { } //Length: 9
	}

	public static CelebrationReward lastAddedReward
	{
		 get { } //Length: 50
		private set { } //Length: 94
	}

	public static List<CelebrationReward> pendingRewards
	{
		 get { } //Length: 92
	}

	public static Dictionary<CharacterId, int> selectedOutfits
	{
		 get { } //Length: 49
	}

	public static List<BoardId> unlockedBoards
	{
		 get { } //Length: 50
	}

	public static List<CharacterId> unlockedCharacters
	{
		 get { } //Length: 50
	}

	public static Dictionary<CharacterId, List<int>> unlockedOutfits
	{
		 get { } //Length: 50
	}

	public static int unrewardedCoins
	{
		 get { } //Length: 92
		 set { } //Length: 114
	}

	public static Dictionary<UpgradeType, int> upgrades
	{
		 get { } //Length: 50
	}

	public InventorySave() { }

	public static void add_coinsChanged(Action value) { }

	public static void add_keysChanged(Action value) { }

	public static void add_powerupsChanged(Action<UpgradeType, int> value) { }

	public static void AddPendingReward(CelebrationReward reward, Func<CelebrationRewardOrigin, int> getRewardPriority) { }

	public static void DecreaseCoins(int amount, string itemId, string secondaryItemId = "N/A") { }

	public static void DecreaseKeys(int amount, string itemId, string secondaryItemId = "N/A") { }

	public static Dictionary<BoardId, Dictionary<ThemeIdentifier, BoardThemeData>> get_boardThemeData() { }

	public static int get_coins() { }

	public static Dictionary<CharacterId, int> get_collectedCharacterTokens() { }

	public static int get_keys() { }

	public static CelebrationReward get_lastAddedReward() { }

	public static List<CelebrationReward> get_pendingRewards() { }

	public static Dictionary<CharacterId, int> get_selectedOutfits() { }

	public static List<BoardId> get_unlockedBoards() { }

	public static List<CharacterId> get_unlockedCharacters() { }

	public static Dictionary<CharacterId, List<int>> get_unlockedOutfits() { }

	public static int get_unrewardedCoins() { }

	public static Dictionary<UpgradeType, int> get_upgrades() { }

	public static int GetAmount(UpgradeType type) { }

	public static int GetTier(UpgradeType type) { }

	public static void IncreaseAmount(UpgradeType type, int amount) { }

	public static void IncreaseCoins(int amount, string sourceId) { }

	public static void IncreaseKeys(int amount, string sourceId) { }

	public static void IncreaseTier(UpgradeType type) { }

	private static void LogEarnedEvent(int amount, ItemType itemType, string sourceId) { }

	private static void LogSpentEvent(int amount, ItemType itemType, string itemId, string secondaryItemId) { }

	public static void remove_coinsChanged(Action value) { }

	public static void remove_keysChanged(Action value) { }

	public static void remove_powerupsChanged(Action<UpgradeType, int> value) { }

	public static void RemovePendingReward(CelebrationReward rewardToRemove) { }

	public static void ResetTier(UpgradeType type) { }

	public static void RewardUnrewardedCoins() { }

	private static void set_coins(int value) { }

	private static void set_keys(int value) { }

	private static void set_lastAddedReward(CelebrationReward value) { }

	public static void set_unrewardedCoins(int value) { }

	public static void SetCoins(int newAmount) { }

	public static void SetKeys(int newAmount) { }

	public static void Use(UpgradeType type) { }

}

