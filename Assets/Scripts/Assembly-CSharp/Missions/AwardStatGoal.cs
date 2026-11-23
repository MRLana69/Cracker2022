namespace Missions;

public class AwardStatGoal : AwardGoal
{
	public Stat stat
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public AwardStatGoal()
	{
		base.hasIcon__BackingField = false;
	}
}
