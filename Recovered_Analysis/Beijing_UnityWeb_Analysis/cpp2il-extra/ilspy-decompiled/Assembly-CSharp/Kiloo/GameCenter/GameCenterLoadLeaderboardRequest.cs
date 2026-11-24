namespace Kiloo.GameCenter;

public class GameCenterLoadLeaderboardRequest : GameCenterRequest
{
	private string category__BackingField;

	private GameCenterPlugin.LeaderboardTimeScope timeScope__BackingField;

	private GameCenterPlugin.LeaderboardPlayerScope playerScope__BackingField;

	private int rangeBegin__BackingField;

	private int rangeCount__BackingField;

	private string[] playerIDs__BackingField;

	public string category
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)rangeCount__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 36;
			obj = value;
		}
	}

	public GameCenterPlugin.LeaderboardTimeScope timeScope
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (GameCenterPlugin.LeaderboardTimeScope)category__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public GameCenterPlugin.LeaderboardPlayerScope playerScope
	{
		get
		{
			return (GameCenterPlugin.LeaderboardPlayerScope)timeScope__BackingField;
		}
		set
		{
			timeScope__BackingField = (GameCenterPlugin.LeaderboardTimeScope)value;
		}
	}

	public int rangeBegin
	{
		get
		{
			return (int)playerScope__BackingField;
		}
		set
		{
			playerScope__BackingField = (GameCenterPlugin.LeaderboardPlayerScope)value;
		}
	}

	public int rangeCount
	{
		get
		{
			return rangeBegin__BackingField;
		}
		set
		{
			rangeBegin__BackingField = value;
		}
	}

	public string[] playerIDs
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string[])rangeCount__BackingField;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			rangeCount__BackingField = (int)value;
		}
	}

	public GameCenterPlugin.Leaderboard result
	{
		get
		{
			return (GameCenterPlugin.Leaderboard)(object)playerIDs__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
		}
	}
}
