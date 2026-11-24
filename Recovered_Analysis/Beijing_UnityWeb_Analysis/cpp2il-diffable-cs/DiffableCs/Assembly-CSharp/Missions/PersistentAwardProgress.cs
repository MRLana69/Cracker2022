namespace Missions;

public class PersistentAwardProgress
{
	public AwardTierType activeTierType; //Field offset: 0x8
	public AwardTierType progressTierType; //Field offset: 0xC
	public AwardState currentActiveAwardState; //Field offset: 0x10
	public AwardState currentProgressAwardState; //Field offset: 0x14
	public DateTime lastActiveStateChangeDateTime; //Field offset: 0x18
	public int offset; //Field offset: 0x20
	public Dictionary<Stat, int> statOffset; //Field offset: 0x24
	public bool hasMigratedToUseStatOffset; //Field offset: 0x28

	public PersistentAwardProgress() { }

}

