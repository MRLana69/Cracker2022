namespace Data.Migration;

public class PlayerInfoData
{
	public Dictionary<Key, string> mainPlayerInfoData; //Field offset: 0x8
	public Dictionary<PowerupTypeLegacy, int> upgradeAmounts; //Field offset: 0xC
	public Dictionary<PowerupTypeLegacy, int> upgradeTiers; //Field offset: 0x10
	public IDictionary topRunManager; //Field offset: 0x14
	public IDictionary topRunPlayerIds; //Field offset: 0x18
	public IDictionary topRunRanks; //Field offset: 0x1C
	public Dictionary<string, Status> socialData; //Field offset: 0x20
	public IDictionary<string, object> adSystemData; //Field offset: 0x24

	public PlayerInfoData() { }

}

