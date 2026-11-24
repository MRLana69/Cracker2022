namespace Missions;

public class DailyChallengesInRowAward : Award
{

	public DailyChallengesInRowAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	private int GetDailyChallengesInRow() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnDailyWordInRowChanged() { }

	protected override void RecordNewOffsets() { }

	private void SyncOffset() { }

}

