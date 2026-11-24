namespace Missions;

public class OwnCharactersOutfitsAward : Award
{

	public OwnCharactersOutfitsAward(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	protected override void ActivateCurrentAwardTier() { }

	protected override void DeactivateCurrentAwardTier() { }

	private int GetNumberOfOwnedCharacterOutfits() { }

	protected override int GetProgressForGoal(AwardGoal goal) { }

	public override bool IsGoalAccomplished(AwardGoal goal) { }

	private void OnOutfitUnlocked(CharacterId id) { }

	protected override void RecordNewOffsets() { }

}

