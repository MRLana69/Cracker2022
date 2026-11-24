namespace Info.VideoRewardCooldowns;

public class CooldownManager
{
	private static CooldownManager _instance; //Field offset: 0x0
	private const string OS_KEY = "video_reward_cooldowns"; //Field offset: 0x0
	private const char OS_ENTRY_SEPARATOR = '\u2C'; //Field offset: 0x0
	private const char OS_COMPONENT_SEPARATOR = '\u3A'; //Field offset: 0x0
	private const int INFINITE_CHARGES_VALUE = -1; //Field offset: 0x0
	private OnlineSettings _onlineSettings; //Field offset: 0x8
	private Cooldowns _cooldowns; //Field offset: 0xC

	private static CooldownManager instance
	{
		 get { } //Length: 179
	}

	public CooldownManager() { }

	public static void Consume(string id) { }

	private static CooldownManager get_instance() { }

	public static int GetChargesUsed(string id) { }

	private static bool HasCharge(Cooldown cd) { }

	public static bool HasCharge(string id) { }

	private void LoadAndParseFromOnlineSettings() { }

	private Cooldown Parse(string data) { }

}

