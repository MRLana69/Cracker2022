namespace Missions;

public class AwardTier
{
	private AwardTierType <tierType>k__BackingField; //Field offset: 0x8
	private int <reward>k__BackingField; //Field offset: 0xC
	private AwardGoal[] <listGoals>k__BackingField; //Field offset: 0x10

	public AwardGoal[] listGoals
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int reward
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public AwardTierType tierType
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public AwardTier() { }

	public AwardGoal[] get_listGoals() { }

	public int get_reward() { }

	public AwardTierType get_tierType() { }

	public void set_listGoals(AwardGoal[] value) { }

	public void set_reward(int value) { }

	public void set_tierType(AwardTierType value) { }

}

