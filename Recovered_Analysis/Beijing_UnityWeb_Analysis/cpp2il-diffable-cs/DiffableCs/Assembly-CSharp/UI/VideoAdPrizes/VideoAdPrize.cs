namespace UI.VideoAdPrizes;

public class VideoAdPrize
{
	private VideoAdPrizeType <prizeType>k__BackingField; //Field offset: 0x8
	private int <amount>k__BackingField; //Field offset: 0xC
	private bool <hasBeenRewarded>k__BackingField; //Field offset: 0x10

	private int amount
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool hasBeenRewarded
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public VideoAdPrizeType prizeType
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public VideoAdPrize(VideoAdPrizeType prizeType, int amount = 1) { }

	public string AsString() { }

	private CelebrationReward CreateCelebrationReward() { }

	private CelebrationReward CreateCurrencyReward(int amountOfCurrencyToGive, CelebrationRewardType celebrationRewardType) { }

	private CelebrationReward CreateMysteryBox(Type mysteryBoxType, CelebrationRewardOrigin celebrationRewardOrigin) { }

	private int get_amount() { }

	public bool get_hasBeenRewarded() { }

	public VideoAdPrizeType get_prizeType() { }

	private string GetPrizeTypeAsString() { }

	public void GiveReward(UnlockItemSource rewardSource) { }

	private void set_amount(int value) { }

	private void set_hasBeenRewarded(bool value) { }

	private void set_prizeType(VideoAdPrizeType value) { }

}

