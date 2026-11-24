namespace Missions;

public class OwnBoardsAward : Award
{

	public OwnBoardsAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	private void BoardUnlocked(BoardId boardId) { }

	protected override void DeactivateCurrentAwardTier() { }

	private int GetNumberOfOwnedBoards() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	protected override void RecordNewOffsets() { }

}

