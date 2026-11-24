namespace Missions;

public abstract class Award
{
	private const char SEPERATOR_CHAR = '\u3B'; //Field offset: 0x0
	protected readonly AwardStaticData _awardData; //Field offset: 0x8
	private AwardTier _awardActiveTier; //Field offset: 0xC
	private DateTime _previewDateTime; //Field offset: 0x10
	protected AwardTier _awardProgressTier; //Field offset: 0x18
	protected readonly PersistentAwardProgress savedProgress; //Field offset: 0x1C
	private bool <isInPreview>k__BackingField; //Field offset: 0x20
	public AwardTierType tierAnimationPlayed; //Field offset: 0x24
	private Action<Award> onStateChangedHandler; //Field offset: 0x28

	private event Action<Award> onStateChangedHandler
	{
		 add { } //Length: 868
		 remove { } //Length: 111
	}

	public AwardTierType activeTierType
	{
		 get { } //Length: 101
	}

	public AwardStaticData awardsData
	{
		 get { } //Length: 155
	}

	public AwardState awardState
	{
		 get { } //Length: 20
		 set { } //Length: 182
	}

	public AwardGoal[] goals
	{
		 get { } //Length: 6
	}

	public bool isInPreview
	{
		 get { } //Length: 9
		 set { } //Length: 63
	}

	public bool isNew
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public DateTime lastStateChangeDateTime
	{
		 get { } //Length: 6
	}

	public int reward
	{
		 get { } //Length: 9
	}

	protected Award(AwardStaticData awardData, PersistentAwardProgress savedProgress, Action<Award> handler) { }

	public void Activate() { }

	protected abstract void ActivateCurrentAwardTier() { }

	private void add_onStateChangedHandler(Action<Award> value) { }

	private void AppWillRefresh(RefreshType refreshType) { }

	public bool BelongsToState(AwardState state) { }

	protected void CalculateNextActiveTier() { }

	protected void CheckAndUpdateProgress() { }

	private void CheckTierValues() { }

	public void CompleteCurrentTierIfDebug() { }

	protected virtual void DeactivateCurrentAwardTier() { }

	private void FlurryLogAwardCollectibleInformation(string throphyDataID, int activeTierTypeID, DateTime dateTime) { }

	public AwardTierType get_activeTierType() { }

	public AwardStaticData get_awardsData() { }

	public AwardState get_awardState() { }

	public AwardGoal[] get_goals() { }

	public bool get_isInPreview() { }

	public bool get_isNew() { }

	public DateTime get_lastStateChangeDateTime() { }

	public int get_reward() { }

	public PersistentAwardProgress GetPersistentProgress() { }

	public int GetProgressAsPercentage() { }

	protected abstract int GetProgressForGoal(AwardGoal goal) { }

	private void GoToState(AwardState state) { }

	public bool HasCompletedTierExact(AwardTierType tier) { }

	public abstract bool IsGoalAccomplished(AwardGoal goal) { }

	protected void MoveToNextTierOrFinishIfLast() { }

	protected abstract void RecordNewOffsets() { }

	private void remove_onStateChangedHandler(Action<Award> value) { }

	public void RewardPayedOut() { }

	public void set_awardState(AwardState value) { }

	public void set_isInPreview(bool value) { }

	public void set_isNew(bool value) { }

	public void SetAwardTierToAlmostComplete() { }

	public void SetBackToInProgress() { }

}

