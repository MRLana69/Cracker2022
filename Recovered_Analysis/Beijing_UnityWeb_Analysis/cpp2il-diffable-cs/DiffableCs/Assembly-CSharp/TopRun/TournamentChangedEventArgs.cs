namespace TopRun;

public class TournamentChangedEventArgs : EventArgs
{
	private bool <tournamentDidChange>k__BackingField; //Field offset: 0x8
	private bool <tournamentWasUpdated>k__BackingField; //Field offset: 0x9

	public bool tournamentDidChange
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public bool tournamentWasUpdated
	{
		 get { } //Length: 9
		internal set { } //Length: 11
	}

	public TournamentChangedEventArgs() { }

	public bool get_tournamentDidChange() { }

	public bool get_tournamentWasUpdated() { }

	internal void set_tournamentDidChange(bool value) { }

	internal void set_tournamentWasUpdated(bool value) { }

}

