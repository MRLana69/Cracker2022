//Type is in global namespace

public class LeaderboardGameoverCell
{
	public LeaderboardGameoverCellType cellType; //Field offset: 0x8
	public Friend friend; //Field offset: 0xC
	public LeaderboardDummy dummyFriend; //Field offset: 0x10
	public int rank; //Field offset: 0x14
	public bool isPlayerRanked; //Field offset: 0x18
	public bool useDarkColour; //Field offset: 0x19
	public bool lockList; //Field offset: 0x1A
	public bool noFriends; //Field offset: 0x1B
	public Action OnUpdateCell; //Field offset: 0x1C

	public LeaderboardGameoverCell() { }

	public void UpdateCell() { }

}

