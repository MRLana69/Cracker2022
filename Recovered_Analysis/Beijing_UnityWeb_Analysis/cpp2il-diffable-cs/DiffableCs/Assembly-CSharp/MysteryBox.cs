//Type is in global namespace

public static class MysteryBox
{
	private class LootTableEntry
	{
		public CelebrationRewardType itemType; //Field offset: 0x8
		public float weight; //Field offset: 0xC
		public int min; //Field offset: 0x10
		public int max; //Field offset: 0x14
		public UpgradeType upgradeType; //Field offset: 0x18

		public LootTableEntry() { }

	}

	public enum Type
	{
		Normal = 0,
		Super = 1,
		Mini = 2,
	}

	public static readonly CharacterId[] TOKEN_REWARD_IDS; //Field offset: 0x0
	public const int MINI_MYSTERY_BOX_RARE_KEYS_AMOUNT = 2; //Field offset: 0x0
	public const int MINI_MYSTERY_BOX_COMMON_COINS_AMOUNT = 200; //Field offset: 0x0
	public const int MINI_MYSTERY_BOX_COMMON_BOARDS_AMOUNT = 3; //Field offset: 0x0
	public const int SUPER_MYSTERY_BOX_SPECIAL_BOARDS_AMOUNT = 20; //Field offset: 0x0
	public const int SUPER_MYSTERY_BOX_SPECIAL_COINS_AMOUNT = 8000; //Field offset: 0x0
	public const int SUPER_MYSTERY_BOX_RARE_COINS_AMOUNT = 50000; //Field offset: 0x0
	public const int MYSTERY_BOX_SPECIAL_BOARDS_AMOUNT = 10; //Field offset: 0x0
	public const int MYSTERY_BOX_SPECIAL_COINS_AMOUNT = 2500; //Field offset: 0x0
	public const int MYSTERY_BOX_RARE_COINS_AMOUNT = 5000; //Field offset: 0x0
	public const int DEFAULT_MEGA_JACKPOT_SUPER_MYSTERYBOX = 1500000; //Field offset: 0x0
	public const int DEFAULT_MEGA_JACKPOT_MYSTERYBOX = 900000; //Field offset: 0x0
	public const int SUPER_MYSTERY_BOX_JACKPOT_AMOUNT = 300000; //Field offset: 0x0
	public const int MYSTERY_BOX_JACKPOT_AMOUNT = 100000; //Field offset: 0x0
	public static readonly Dictionary<CharacterId, int> characterTokenWeight; //Field offset: 0x4
	private static readonly LootTableEntry[][] _lootTables; //Field offset: 0x8
	private static readonly CelebrationReward MYSTERYBOX_CONSOLATION_REWARD; //Field offset: 0xC
	private static readonly CelebrationReward SUPERMYSTERYBOX_CONSOLATION_REWARD; //Field offset: 0x10

	private static MysteryBox() { }

	private static List<CharacterId> GetAvailableCharacterTokens() { }

	private static List<Trophy> GetAvailableTrophyList(Type mysteryBoxType) { }

	public static int GetMegaJackpotAmount(Type mysteryBoxType) { }

	private static CharacterId GetRandomCharacterTokenTypeUsingWeights(List<CharacterId> validCharacters) { }

	private static LootTableEntry MakeRoll(Type mysteryBoxType) { }

	public static CelebrationReward Roll(Type mysteryBoxType) { }

	public static void TestRolls(int numberOfRolls, Type mysteryBoxType = 0) { }

}

