namespace Missions;

public class CollectCoinsSingleRun : Award
{
	private int _progress; //Field offset: 0x2C
	private int _offset; //Field offset: 0x30

	public CollectCoinsSingleRun(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnCoinsIncreased(int count) { }

	private void OnFrontScreen(string screenName) { }

	private void OnRunEnded() { }

	private void OnRunStarted() { }

	protected override void RecordNewOffsets() { }

	private void ResetProgress() { }

}

