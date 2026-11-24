namespace Missions;

public class ScorePointsSingleLane : Award
{
	private Character _character; //Field offset: 0x2C
	private int _offset; //Field offset: 0x30

	public ScorePointsSingleLane(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnLaneChanged(OnChangeTrackDirection direction) { }

	private void OnRunEnded() { }

	private void OnRunStarted() { }

	private void OnScoreChanged() { }

	protected override void RecordNewOffsets() { }

}

