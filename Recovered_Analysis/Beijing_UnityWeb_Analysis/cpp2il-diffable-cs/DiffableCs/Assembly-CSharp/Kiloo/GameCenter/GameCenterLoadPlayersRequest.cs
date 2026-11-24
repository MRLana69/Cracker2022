namespace Kiloo.GameCenter;

public class GameCenterLoadPlayersRequest : GameCenterRequest
{
	private string[] <playerIDs>k__BackingField; //Field offset: 0x14
	private Player[] <result>k__BackingField; //Field offset: 0x18

	public string[] playerIDs
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public Player[] result
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public GameCenterLoadPlayersRequest() { }

	public string[] get_playerIDs() { }

	public Player[] get_result() { }

	internal void set_playerIDs(string[] value) { }

	internal void set_result(Player[] value) { }

}

