//Type is in global namespace

public class TopRunCell
{
	public TopRunCellType cellType; //Field offset: 0x8
	public int rank; //Field offset: 0xC
	public int bestScore; //Field offset: 0x10
	public IPlayer player; //Field offset: 0x14
	public bool useDarkColour; //Field offset: 0x18
	public bool isLocalUser; //Field offset: 0x19
	public bool noPadding; //Field offset: 0x1A
	public Action OnUpdateCell; //Field offset: 0x1C
	public TopRunPlayerCell topRunPlayerCellScript; //Field offset: 0x20

	public TopRunCell() { }

	public void UpdateCell() { }

}

