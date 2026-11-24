//Type is in global namespace

public class LeaderboardDummyData
{
	public class LeaderboardDummy
	{
		public string name; //Field offset: 0x8
		public int score; //Field offset: 0xC

		public LeaderboardDummy() { }

	}

	public static List<LeaderboardDummy> dummyData; //Field offset: 0x0

	private static LeaderboardDummyData() { }

	public LeaderboardDummyData() { }

}

