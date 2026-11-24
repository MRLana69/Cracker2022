namespace Info.VideoRewardCooldowns;

public class Cooldowns
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Cooldown, string> <>9__9_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <AsString>b__9_0(Cooldown x) { }

	}

	public const string HOVERBOARD_ID = "hoverboard"; //Field offset: 0x0
	public const string COINS_ID = "coins"; //Field offset: 0x0
	public const string SCORE_BOOSTER_ID = "score_booster"; //Field offset: 0x0
	public const string HEADSTART_ID = "headstart"; //Field offset: 0x0
	public const string DOUBLE_COINS_VIDEO_ID = "doublecoinsvideo"; //Field offset: 0x0
	private Dictionary<string, Cooldown> _defaultCooldowns; //Field offset: 0x8
	public Dictionary<string, Cooldown> activeCooldowns; //Field offset: 0xC

	public Cooldowns() { }

	public void Add(Cooldown cooldown) { }

	public string AsString() { }

	public Cooldown Get(string id) { }

}

