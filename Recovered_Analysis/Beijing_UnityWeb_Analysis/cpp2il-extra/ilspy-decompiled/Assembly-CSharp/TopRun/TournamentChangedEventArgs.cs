using System;

namespace TopRun;

public class TournamentChangedEventArgs : EventArgs
{
	private bool tournamentDidChange__BackingField;

	public bool tournamentDidChange
	{
		get
		{
			return tournamentDidChange__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public bool tournamentWasUpdated
	{
		get
		{
			return tournamentDidChange__BackingField;
		}
		internal set
		{
			tournamentDidChange__BackingField = value;
		}
	}

	public TournamentChangedEventArgs()
	{
		TopRunRoot.manager__BackingField = (IManager)this;
	}
}
