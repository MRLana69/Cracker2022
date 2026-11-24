//Type is in global namespace

public static class RewardManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CelebrationReward, bool> <>9__15_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <PayoutNonMysteryBoxRewards>b__15_0(CelebrationReward celebrationReward) { }

	}

	private sealed class <>c__DisplayClass11_0
	{
		public CelebrationReward reward; //Field offset: 0x8

		public <>c__DisplayClass11_0() { }

		internal bool <AddMysteryBoxToUnlock>b__0(CelebrationReward mb) { }

	}

	private const int UnusedInt = -1; //Field offset: 0x0
	private static Action<CelebrationReward> OnMysteryBoxAddedForUnlock; //Field offset: 0x0
	private static Action<CelebrationReward> OnRewardPaidOut; //Field offset: 0x4
	public static bool canShowMultipleQueuedCelebrations; //Field offset: 0x8
	private static long _nextRewardUid; //Field offset: 0x10
	private static readonly Dictionary<CelebrationRewardOrigin, int> PENDING_REWARD_PRIORITY; //Field offset: 0x18

	public static event Action<CelebrationReward> OnMysteryBoxAddedForUnlock
	{
		 add { } //Length: 9
		 remove { } //Length: 206
	}

	public static event Action<CelebrationReward> OnRewardPaidOut
	{
		 add { } //Length: 206
		 remove { } //Length: 209
	}

	public static int rewardsToUnlockCount
	{
		 get { } //Length: 154
	}

	private static RewardManager() { }

	public static void add_OnMysteryBoxAddedForUnlock(Action<CelebrationReward> value) { }

	public static void add_OnRewardPaidOut(Action<CelebrationReward> value) { }

	private static void AddMysteryBoxToUnlock(CelebrationReward reward) { }

	public static void AddRewardToUnlock(CelebrationRewardOrigin origin, ObtainableItemSource syboAnalyticsSource, string kilooAnalyticsSourceId = null, string syboAnalyticsSourceMeta = null) { }

	public static void AddRewardToUnlock(CelebrationReward reward) { }

	public static Type ConvertRewardOriginToBoxType(CelebrationRewardOrigin origin) { }

	public static long GenerateRewardUid() { }

	public static int get_rewardsToUnlockCount() { }

	private static int GetPendingRewardPriority(CelebrationRewardOrigin origin) { }

	public static CelebrationReward[] GetRewardsToUnlockForCelebration() { }

	public static List<CelebrationReward> GetWeeklyHuntRewardsToUnlock() { }

	private static bool IsRewardMysteryBox(CelebrationReward reward) { }

	public static void PayoutNonMysteryBoxRewards() { }

	public static void remove_OnMysteryBoxAddedForUnlock(Action<CelebrationReward> value) { }

	public static void remove_OnRewardPaidOut(Action<CelebrationReward> value) { }

	public static void RewardPaidOut(CelebrationReward celebrationReward) { }

	public static void SetNextRewardUid(long rewardUid) { }

}

