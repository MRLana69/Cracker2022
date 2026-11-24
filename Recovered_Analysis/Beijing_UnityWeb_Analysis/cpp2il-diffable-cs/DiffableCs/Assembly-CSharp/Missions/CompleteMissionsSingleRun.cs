namespace Missions;

public class CompleteMissionsSingleRun : Award
{
	private int _progress; //Field offset: 0x2C
	private int _offset; //Field offset: 0x30

	public CompleteMissionsSingleRun(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnMissionCompleted(string description, int missionIndex) { }

	private void OnRunEnded() { }

	private void OnRunStarted() { }

	protected override void RecordNewOffsets() { }

}

