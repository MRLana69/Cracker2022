namespace TopRun;

public class PlayerInfoChangedEventArgs : EventArgs
{
	private IPlayer <player>k__BackingField; //Field offset: 0x8

	public IPlayer player
	{
		 get { } //Length: 87
		internal set { } //Length: 125
	}

	public PlayerInfoChangedEventArgs() { }

	public IPlayer get_player() { }

	internal void set_player(IPlayer value) { }

}

