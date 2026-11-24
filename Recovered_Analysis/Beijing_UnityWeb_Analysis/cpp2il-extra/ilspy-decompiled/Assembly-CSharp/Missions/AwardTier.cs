using Cpp2ILInjected;

namespace Missions;

public class AwardTier
{
	private AwardTierType tierType__BackingField;

	private int reward__BackingField = 0;

	public AwardTierType tierType
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Missions.AwardTier)+2C]");
			return AwardTierType.None;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 44;
			obj = value;
		}
	}

	public int reward
	{
		get
		{
			return (int)tierType__BackingField;
		}
		set
		{
			tierType__BackingField = (AwardTierType)value;
		}
	}

	public AwardGoal[] listGoals
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (AwardGoal[])reward__BackingField;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			reward__BackingField = (int)value;
		}
	}

	public AwardTier()
	{
		_ = 1;
		_ = 0;
		_ = 1;
		_ = 0;
		_ = 0;
	}
}
