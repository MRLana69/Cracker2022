//Type is in global namespace

public class CoinsForVideoManager
{
	private static CoinsForVideoManager _instance; //Field offset: 0x0
	private const string VIDEO_AVAIL_YES = "Yes"; //Field offset: 0x0
	private const string BUTTON_NAME_VIDEO = "Video"; //Field offset: 0x0
	private const string BUTTON_NO_COOLDOWN = "No Cooldown"; //Field offset: 0x0
	private const string BUTTON_COOLDOWN = "Cooldown_{0}_watched"; //Field offset: 0x0
	private NotEnoughCoinsLootTableEntry[] _lootTable; //Field offset: 0x8

	public static CoinsForVideoManager instance
	{
		 get { } //Length: 2195
	}

	private static CoinsForVideoManager() { }

	private CoinsForVideoManager() { }

	private void CreateLootTable() { }

	public static CoinsForVideoManager get_instance() { }

	public int GetRewardAmount() { }

	private NotEnoughCoinsLootTableEntry MakeRoll() { }

}

