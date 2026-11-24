namespace Missions;

public abstract class AwardGoal
{
	private int goal__BackingField;

	private bool hasIcon__BackingField;

	private string iconName__BackingField;

	public int goal
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)iconName__BackingField;
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

	public bool hasIcon
	{
		get
		{
			return (byte)goal__BackingField != 0;
		}
		set
		{
			goal__BackingField = (value ? 1 : 0);
		}
	}

	public string iconName
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = hasIcon__BackingField;
			return (string)flag;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			hasIcon__BackingField = flag;
		}
	}
}
