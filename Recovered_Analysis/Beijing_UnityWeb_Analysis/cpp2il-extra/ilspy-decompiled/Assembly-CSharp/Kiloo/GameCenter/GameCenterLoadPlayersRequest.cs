namespace Kiloo.GameCenter;

public class GameCenterLoadPlayersRequest : GameCenterRequest
{
	private string[] playerIDs__BackingField;

	public string[] playerIDs
	{
		get
		{
			return playerIDs__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public GameCenterPlugin.Player[] result
	{
		get
		{
			return (GameCenterPlugin.Player[])(object)playerIDs__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}
}
