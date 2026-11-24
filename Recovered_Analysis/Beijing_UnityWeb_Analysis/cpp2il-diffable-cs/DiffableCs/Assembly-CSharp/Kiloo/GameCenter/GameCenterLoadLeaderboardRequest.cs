namespace Kiloo.GameCenter;

public class GameCenterLoadLeaderboardRequest : GameCenterRequest
{
	private string <category>k__BackingField; //Field offset: 0x14
	private LeaderboardTimeScope <timeScope>k__BackingField; //Field offset: 0x18
	private LeaderboardPlayerScope <playerScope>k__BackingField; //Field offset: 0x1C
	private int <rangeBegin>k__BackingField; //Field offset: 0x20
	private int <rangeCount>k__BackingField; //Field offset: 0x24
	private string[] <playerIDs>k__BackingField; //Field offset: 0x28
	private Leaderboard <result>k__BackingField; //Field offset: 0x2C

	public string category
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string[] playerIDs
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public LeaderboardPlayerScope playerScope
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int rangeBegin
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int rangeCount
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Leaderboard result
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public LeaderboardTimeScope timeScope
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public GameCenterLoadLeaderboardRequest() { }

	public string get_category() { }

	public string[] get_playerIDs() { }

	public LeaderboardPlayerScope get_playerScope() { }

	public int get_rangeBegin() { }

	public int get_rangeCount() { }

	public Leaderboard get_result() { }

	public LeaderboardTimeScope get_timeScope() { }

	public void set_category(string value) { }

	public void set_playerIDs(string[] value) { }

	public void set_playerScope(LeaderboardPlayerScope value) { }

	public void set_rangeBegin(int value) { }

	public void set_rangeCount(int value) { }

	internal void set_result(Leaderboard value) { }

	public void set_timeScope(LeaderboardTimeScope value) { }

}

