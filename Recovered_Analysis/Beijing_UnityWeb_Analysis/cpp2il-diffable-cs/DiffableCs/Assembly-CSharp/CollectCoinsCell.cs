//Type is in global namespace

public class CollectCoinsCell
{
	public CollectCoinsCellType cellType; //Field offset: 0x8
	public Friend friend; //Field offset: 0xC
	public CollectCoinsDummy dummyFriend; //Field offset: 0x10
	public bool useDarkColour; //Field offset: 0x14
	public bool disableScrolling; //Field offset: 0x15
	public Action OnUpdateCell; //Field offset: 0x18

	public CollectCoinsCell() { }

	public void UpdateCell() { }

}

