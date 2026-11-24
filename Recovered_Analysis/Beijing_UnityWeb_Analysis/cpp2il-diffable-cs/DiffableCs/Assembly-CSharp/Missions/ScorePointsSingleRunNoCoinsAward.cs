namespace Missions;

public class ScorePointsSingleRunNoCoinsAward : Award
{
	private int _offset; //Field offset: 0x2C

	public ScorePointsSingleRunNoCoinsAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnCoinsChanged() { }

	private void OnRunEnded() { }

	private void OnRunStarted() { }

	private void OnScoreChanged() { }

	protected override void RecordNewOffsets() { }

}

