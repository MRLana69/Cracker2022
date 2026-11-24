namespace Missions;

public class SupersneakersTimeInRowAward : Award
{

	public SupersneakersTimeInRowAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnTimeChanged() { }

	protected override void RecordNewOffsets() { }

}

