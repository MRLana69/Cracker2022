namespace Missions;

public class AwardTier
{
	public AwardTierType tierType
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

	public int reward
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

	public AwardGoal[] listGoals
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
}
