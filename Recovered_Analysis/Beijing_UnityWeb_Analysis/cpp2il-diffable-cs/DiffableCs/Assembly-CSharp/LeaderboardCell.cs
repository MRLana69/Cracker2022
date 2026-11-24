//Type is in global namespace

public class LeaderboardCell
{
	public LeaderboardCellType cellType; //Field offset: 0x8
	public Friend friend; //Field offset: 0xC
	public LeaderboardDummy dummyFriend; //Field offset: 0x10
	public int rank; //Field offset: 0x14
	public bool isPlayerRanked; //Field offset: 0x18
	public bool useDarkColour; //Field offset: 0x19
	public bool lockList; //Field offset: 0x1A
	public string headerText; //Field offset: 0x1C
	public Color headerColor; //Field offset: 0x20
	public bool adjustOverlay; //Field offset: 0x30
	public bool noFriends; //Field offset: 0x31
	public Action OnUpdateCell; //Field offset: 0x34

	public LeaderboardCell() { }

	public void UpdateCell() { }

}

