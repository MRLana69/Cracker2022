using System.Collections.Generic;

public class LeaderboardDummyData
{
	public class LeaderboardDummy
	{
		public string name;

		public int score;
	}

	public static List<LeaderboardDummy> dummyData;

	static LeaderboardDummyData()
	{
		List<LeaderboardDummy> list = default;
		list._002Ector();
		LeaderboardDummy leaderboardDummy = default;
		leaderboardDummy.name = "Friend";
		leaderboardDummy.score = 1000000;
		list.Add(leaderboardDummy);
		LeaderboardDummy leaderboardDummy2 = default;
		leaderboardDummy2.name = "Homie";
		leaderboardDummy2.score = 600000;
		list.Add(leaderboardDummy2);
		LeaderboardDummy leaderboardDummy3 = default;
		leaderboardDummy3.name = "Mate";
		leaderboardDummy3.score = 400000;
		list.Add(leaderboardDummy3);
		LeaderboardDummy leaderboardDummy4 = default;
		leaderboardDummy4.name = "Homegirl";
		leaderboardDummy4.score = 200000;
		list.Add(leaderboardDummy4);
		LeaderboardDummy leaderboardDummy5 = default;
		leaderboardDummy5.name = "Pal";
		leaderboardDummy5.score = 100000;
		list.Add(leaderboardDummy5);
		LeaderboardDummy leaderboardDummy6 = default;
		leaderboardDummy6.name = "Amiga";
		leaderboardDummy6.score = 80000;
		list.Add(leaderboardDummy6);
		LeaderboardDummy leaderboardDummy7 = default;
		leaderboardDummy7.name = "Homeboy";
		leaderboardDummy7.score = 50000;
		list.Add(leaderboardDummy7);
		LeaderboardDummy leaderboardDummy8 = default;
		leaderboardDummy8.name = "Mate";
		leaderboardDummy8.score = 30000;
		list.Add(leaderboardDummy8);
		LeaderboardDummy leaderboardDummy9 = default;
		leaderboardDummy9.name = "Neighbor";
		leaderboardDummy9.score = 16000;
		list.Add(leaderboardDummy9);
		LeaderboardDummy leaderboardDummy10 = default;
		leaderboardDummy10.name = "Friend";
		leaderboardDummy10.score = 9000;
		list.Add(leaderboardDummy10);
		LeaderboardDummy leaderboardDummy11 = default;
		leaderboardDummy11.name = "Schoolmate";
		leaderboardDummy11.score = 7000;
		list.Add(leaderboardDummy11);
		LeaderboardDummy leaderboardDummy12 = default;
		leaderboardDummy12.name = "Homie";
		leaderboardDummy12.score = 2000;
		list.Add(leaderboardDummy12);
		dummyData = list;
	}
}
