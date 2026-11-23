using System;

namespace TopRun;

public class PlayerInfoChangedEventArgs : EventArgs
{
	public IPlayer player
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
