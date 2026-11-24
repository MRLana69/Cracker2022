namespace Missions;

public class OwnCharactersAward : Award
{

	public OwnCharactersAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	private int GetNumberOfOwnedCharacters() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnCharacterUnlocked(CharacterId id) { }

	protected override void RecordNewOffsets() { }

}

