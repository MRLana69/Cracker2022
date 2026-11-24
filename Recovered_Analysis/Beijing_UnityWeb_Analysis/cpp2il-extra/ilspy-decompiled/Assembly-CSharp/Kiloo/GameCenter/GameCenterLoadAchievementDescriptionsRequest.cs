namespace Kiloo.GameCenter;

public class GameCenterLoadAchievementDescriptionsRequest : GameCenterRequest
{
	public GameCenterPlugin.AchievementDescription[] result
	{
		get
		{
			return field;
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
