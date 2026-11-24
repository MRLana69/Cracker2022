namespace Info;

public static class Upgrades
{
	private const int SPAWNRATE_FOR_CHARACTER_LETTERS = 25; //Field offset: 0x0
	private const int SPAWNRATE_TO_FORCE_A_SPAWNING = 1500000000; //Field offset: 0x0
	private const int SPAWNRATE_FOR_LETTERS = 1500000000; //Field offset: 0x0
	private const int SPAWNRATE_FOR_MYSTERYPOWERUP = 23; //Field offset: 0x0
	public const int SCORE_BOOSTER_MULTIPLIER_TIER1 = 5; //Field offset: 0x0
	public const int SCORE_BOOSTER_MULTIPLIER_TIER2 = 6; //Field offset: 0x0
	public const int SCORE_BOOSTER_MULTIPLIER_TIER3 = 7; //Field offset: 0x0
	public const int CHARACTER_DAY_MULTIPLIER = 5; //Field offset: 0x0
	public const int PLUS_MULTIPLIER_MYSTERY_POWERUP = 10; //Field offset: 0x0
	private const float HEADSTART_TIER_ONE_SPEED = 400; //Field offset: 0x0
	private const float HEADSTART_TIER_ONE_LAND_SPEED = 0.01; //Field offset: 0x0
	private const float HEADSTART_TIER_ONE_DURATION = 6; //Field offset: 0x0
	public static readonly HeadstartTier[] HEADSTART_TIERS; //Field offset: 0x0
	public static readonly Dictionary<UpgradeType, Upgrade> upgrades; //Field offset: 0x4

	private static Upgrades() { }

	public static int CountUpgradeTiers() { }

	public static float GetUpgradeDuration(UpgradeType type) { }

}

