namespace UI.VideoAdPrizes;

public class VideoAdPrizeManager
{
	public const string LOGGING_SYMBOL = "ENABLE_VIDEO_AD_PRIZE_MANAGER_LOGS"; //Field offset: 0x0
	private const string ONLINE_SETTING_KEYS_REWARDED_FOR_VIDEO = "keys_rewarded_for_video_ad"; //Field offset: 0x0
	private const int DEFAULT_NUMBER_OF_KEYS_TO_REWARD_FOR_VIDEO_AD = 2; //Field offset: 0x0
	private static VideoAdPrizeManager _instance; //Field offset: 0x0
	private List<VideoAdPrize> _introPrizePool; //Field offset: 0x8
	private List<VideoAdPrize> _randomPrizePool; //Field offset: 0xC
	private VideoAdPrize _currentVideoAdPrize; //Field offset: 0x10
	private VideoAdPrizePools _videoAdPrizePools; //Field offset: 0x14
	private int _currentVideoAdPrizeIndex; //Field offset: 0x18
	private PrizePoolState _prizePoolState; //Field offset: 0x1C

	public static VideoAdPrizeManager instance
	{
		 get { } //Length: 132
	}

	public PrizePoolState prizePoolState
	{
		 get { } //Length: 115
	}

	private VideoAdPrizeManager() { }

	private bool AbleToWatchAVideoForKeysToday() { }

	public void DebugReload() { }

	public static VideoAdPrizeManager get_instance() { }

	public PrizePoolState get_prizePoolState() { }

	public int GetAmountOfKeysRewardedForVideo() { }

	private VideoAdPrize GetIntroPoolPrize() { }

	public DateTime GetLastTimeAVideoForKeysWasSeen() { }

	private int GetRandomVideoAdPrizeSeed() { }

	public VideoAdPrize GetVideoAdPrize() { }

	public void GiveReward(UnlockItemSource rewardSource) { }

	public void GoToNextVideoAdPrize() { }

	private bool HasVideoAdPrizeIndexChanged() { }

	private void InitPrizePools() { }

	private void InitRandomPrizePool() { }

	public bool IsVideoForKeysAvailable() { }

	public static void Log(object message) { }

	private void ResetRandomPrizePool() { }

	private void ResetRandomPrizePoolIfAllPrizesTaken() { }

	private void SetIntroPrize() { }

	private void SetNewVideoAdPrize() { }

	private void SetRandomPrize() { }

	private void SetVideoAdPrizeIndexes() { }

	private void UpdatePrizePoolState() { }

	private void UpdateValueOfCurrentVideoAdPrizeIndex() { }

}

