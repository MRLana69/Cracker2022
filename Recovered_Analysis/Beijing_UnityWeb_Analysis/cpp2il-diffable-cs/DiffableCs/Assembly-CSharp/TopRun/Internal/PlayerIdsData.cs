namespace TopRun.Internal;

public class PlayerIdsData
{
	public class PlayerIdData
	{
		public string publicKey; //Field offset: 0x8
		public string name; //Field offset: 0xC
		public Nullable<DateTime> expiry; //Field offset: 0x10

		public PlayerIdData() { }

	}

	public Dictionary<string, PlayerIdData> players; //Field offset: 0x8

	public PlayerIdsData() { }

}

