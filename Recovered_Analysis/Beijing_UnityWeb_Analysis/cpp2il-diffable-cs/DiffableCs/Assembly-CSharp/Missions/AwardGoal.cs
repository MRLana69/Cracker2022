namespace Missions;

public abstract class AwardGoal
{
	private int <goal>k__BackingField; //Field offset: 0x8
	private bool <hasIcon>k__BackingField; //Field offset: 0xC
	private string <iconName>k__BackingField; //Field offset: 0x10

	public int goal
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool hasIcon
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public string iconName
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	protected AwardGoal() { }

	public int get_goal() { }

	public bool get_hasIcon() { }

	public string get_iconName() { }

	public void set_goal(int value) { }

	public void set_hasIcon(bool value) { }

	public void set_iconName(string value) { }

}

