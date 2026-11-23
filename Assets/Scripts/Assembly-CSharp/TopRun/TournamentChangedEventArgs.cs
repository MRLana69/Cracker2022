using System;

namespace TopRun;

public class TournamentChangedEventArgs : EventArgs
{
	public bool tournamentDidChange
	{
		get
		{
			return field;
		}
		internal set
		{
			field = value;
		}
	}

	public bool tournamentWasUpdated
	{
		get
		{
			return field;
		}
		internal set
		{
			field = value;
		}
	}
}
