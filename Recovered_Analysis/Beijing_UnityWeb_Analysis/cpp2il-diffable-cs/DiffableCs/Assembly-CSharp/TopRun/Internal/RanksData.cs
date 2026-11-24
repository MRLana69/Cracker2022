namespace TopRun.Internal;

public class RanksData
{
	public string tournamentId; //Field offset: 0x8
	public Dictionary<string, Rank> ranks; //Field offset: 0xC

	public RanksData() { }

}

