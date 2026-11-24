namespace Missions;

public class AwardStatGoal : AwardGoal
{
	public Stat stat
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (Stat)base.iconName__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 16;
			obj = value;
		}
	}
}
