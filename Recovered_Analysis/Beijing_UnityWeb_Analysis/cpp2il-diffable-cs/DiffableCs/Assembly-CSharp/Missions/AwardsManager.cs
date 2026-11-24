namespace Missions;

public class AwardsManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Award> <>9__14_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <GetSortedListAwards>b__14_0(Award a1, Award a2) { }

	}

	private static AwardsManager _instance; //Field offset: 0x0
	private static bool _hasInited; //Field offset: 0x4
	private List<Award> _listAwards; //Field offset: 0x8

	public static AwardsManager instance
	{
		 get { } //Length: 307
	}

	private static AwardsManager() { }

	private AwardsManager() { }

	public static AwardsManager get_instance() { }

	public Award GetAwardForId(AwardId id) { }

	public List<Award> GetAwardsForState(AwardState state) { }

	public float GetAwardsPercentageComplete() { }

	public int GetNumberOfFinishedAwardsExactTier(AwardTierType awardTierType) { }

	public int GetNumberOfNewVisibleAwards() { }

	public List<Award> GetSortedListAwards(out bool containsCollectibleAwards) { }

	public int GetTotalAwardTiers() { }

	public int GetTotalCompletedTiers() { }

	public void InitAwards() { }

	private void InitAwardsIfNeeded() { }

	private void OnHasRefreshed(RefreshType refreshType) { }

	private void OnMissionStateChanged(Award award) { }

	private void SaveAllAwards() { }

	private void SaveAwardProgress(Award award) { }

	private bool ShouldInsertAwardToList(Award award) { }

	public bool ShouldSpawnOldTrophyForStat(Stat stat) { }

	private int SortAwardByDate(Award a, Award b) { }

	private void UpdateTheNewStatusForTheAwardsOnCleanInstall() { }

}

