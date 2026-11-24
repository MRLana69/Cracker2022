namespace UI.Screens.RewardManagement;

public class CelebrationReward
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ThemeIdentifier, string> <>9__23_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__23_0(ThemeIdentifier x) { }

	}

	public CelebrationRewardOrigin CelebrationRewardOrigin; //Field offset: 0x8
	public CelebrationRewardType rewardType; //Field offset: 0xC
	public UnlockItemSource unlockItemSource; //Field offset: 0x10
	public int amount; //Field offset: 0x14
	public CharacterId characterId; //Field offset: 0x18
	public int characterOutfitIndex; //Field offset: 0x1C
	public BoardId boardId; //Field offset: 0x20
	public Trophy trophyType; //Field offset: 0x24
	public UpgradeType upgradeType; //Field offset: 0x28
	public long Uid; //Field offset: 0x30
	public AwardTierType awardTierType; //Field offset: 0x38
	public string awardTitle; //Field offset: 0x3C
	public int rank; //Field offset: 0x40
	public int score; //Field offset: 0x44
	public int weekNumber; //Field offset: 0x48
	public BoardAbility boardPower; //Field offset: 0x4C
	public int characterEventCompleted; //Field offset: 0x50
	public string description; //Field offset: 0x54
	public List<ThemeIdentifier> bundledThemes; //Field offset: 0x58
	public string kilooAnalyticsSourceId; //Field offset: 0x5C
	public ObtainableItemSource syboAnalyticsSource; //Field offset: 0x60
	public long syboAnalyticsSourceId; //Field offset: 0x68
	public string syboAnalyticsSourceMetaOrNull; //Field offset: 0x70

	public CelebrationReward() { }

	public void PopulateFromString(string rewardAsString) { }

	private void ResetToDefaultValues() { }

	public override string ToString() { }

}

