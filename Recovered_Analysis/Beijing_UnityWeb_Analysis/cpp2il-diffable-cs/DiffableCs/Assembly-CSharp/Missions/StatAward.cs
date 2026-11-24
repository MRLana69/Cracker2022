namespace Missions;

public class StatAward : Award
{
	private bool _shouldMigrateToUseStatOffset; //Field offset: 0x2C

	public StatAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private int OffsetForStat(Stat stat) { }

	private void OnStatChanged(Stat stat, int newValue) { }

	protected override void RecordNewOffsets() { }

}

