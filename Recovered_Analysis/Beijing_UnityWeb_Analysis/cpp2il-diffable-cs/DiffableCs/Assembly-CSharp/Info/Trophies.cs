namespace Info;

public static class Trophies
{
	public enum Trophy
	{
		diamond = 0,
		goldbar = 1,
		goldChainClock = 2,
		goldChainDollar = 3,
		goldSkull = 4,
		headphones = 5,
		lpBlack = 6,
		tapeBlack = 7,
	}

	public const int TROPHY_COUNT = 8; //Field offset: 0x0
	public static readonly Dictionary<Trophy, TrophyData> TROPHY_DATA; //Field offset: 0x0

	private static Trophies() { }

	public static void OldTrophySpawned(Trophy trophy) { }

	public static bool ShouldSpawnTrophy(Trophy trophy) { }

	private static Stat StatForTrophyType(Trophy trophy) { }

}

