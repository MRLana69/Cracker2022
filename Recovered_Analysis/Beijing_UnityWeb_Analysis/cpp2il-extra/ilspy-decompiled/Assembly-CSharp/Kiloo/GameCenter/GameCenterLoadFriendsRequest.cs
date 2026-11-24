namespace Kiloo.GameCenter;

public class GameCenterLoadFriendsRequest : GameCenterRequest
{
	public string[] result
	{
		get
		{
			return (string[])(object)base.error__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}
}
