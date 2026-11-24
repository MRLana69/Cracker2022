using Cpp2ILInjected;

namespace Kiloo.GameCenter;

public class GameCenterLoadAchievementsRequest : GameCenterRequest
{
	public GameCenterPlugin.Achievement[] result
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.GameCenter.GameCenterLoadAchievementsRequest)+2C]");
			return (GameCenterPlugin.Achievement[])0;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 44;
			obj = value;
		}
	}
}
