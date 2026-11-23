public class MystBoxButtonTest : UIBasicButton
{
	public bool doubleBox;

	protected override void Send()
	{
		RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.MysteryBox);
		if (~(doubleBox ? 1u : 0u) == 0)
		{
			RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.MysteryBox);
		}
	}
}
