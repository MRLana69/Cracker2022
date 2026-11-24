//Type is in global namespace

public class OfferWallManager
{
	private enum RequestStates
	{
		NotStarted = 0,
		InProgress = 1,
		Succeeded = 2,
		Failed = 3,
	}

	private const string OFFERWALL_INITIALIZE_FAIL_CODE = "fail"; //Field offset: 0x0
	private const int DEFAULT_REWARDS_REFRESH_INTERVAL_AFTER_SUCCESS = 120; //Field offset: 0x0
	private const int DEFAULT_REWARDS_REFRESH_INTERVAL_AFTER_FAIL = 30; //Field offset: 0x0
	private static OfferWallManager _instance; //Field offset: 0x0
	private const string OFFERWALL_EVENT_NAME = "Offerwall"; //Field offset: 0x0
	private const string OFFERWALL_DISABLED_ONLINE_SETTING = "offerwall_disabled"; //Field offset: 0x0
	private const bool DEFAULT_DISABLED_ONLINE_SETTING = False; //Field offset: 0x0
	private Action onOfferWallReceived; //Field offset: 0x8
	private Action<int> onPendingRewardsReceived; //Field offset: 0xC
	private RequestStates _requestRewardState; //Field offset: 0x10
	private RequestStates _spendRewardState; //Field offset: 0x14
	private DateTime _lastTimeRewardsWereRequested; //Field offset: 0x18
	private int _amountPendingApprovalToBeRewarded; //Field offset: 0x20
	private int _amountApprovedToBeRewarded; //Field offset: 0x24
	private string _lastOriginForShow; //Field offset: 0x28
	private bool _listenersSet; //Field offset: 0x2C
	private int MINIMUM_SUPPORTED_ANDROID_API; //Field offset: 0x30

	public event Action onOfferWallReceived
	{
		 add { } //Length: 59
		 remove { } //Length: 111
	}

	public event Action<int> onPendingRewardsReceived
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static OfferWallManager instance
	{
		 get { } //Length: 112
	}

	public bool isOfferWallDisabled
	{
		 get { } //Length: 43
	}

	public OfferWallManager() { }

	public void add_onOfferWallReceived(Action value) { }

	public void add_onPendingRewardsReceived(Action<int> value) { }

	public static OfferWallManager get_instance() { }

	public bool get_isOfferWallDisabled() { }

	public void GetPendingRewards() { }

	private string GetSDKAppID() { }

	private string GetSDKAppKey() { }

	private string GetSDKEventName() { }

	private bool HasTimeIntervalPassedSinceDate(DateTime lastRequestDateTime, int timeInterval) { }

	public void Initialize() { }

	public bool IsOfferWallAllowed() { }

	public bool IsOfferWallReady() { }

	private void Log(string message) { }

	private void OnEarnPoints(string amount) { }

	private void OnGetPointsError() { }

	private void OnGotPoints(string amount) { }

	private void OnInitializeFinished(string s) { }

	private void OnOfferWallResponse(string message) { }

	private void OnSpendPoints(string amountOfPointsLeftInUsersBalance) { }

	private void OnSpendPointsError() { }

	private void OnViewDidAppear(string viewType) { }

	private void OnViewDidDisappear(string viewType) { }

	private void PayoutRewardToUser(int rewardAmount) { }

	public void remove_onOfferWallReceived(Action value) { }

	public void remove_onPendingRewardsReceived(Action<int> value) { }

	public void RequestOfferWall() { }

	private void SetListeners() { }

	public void ShowOfferWall(string origin) { }

	private void SpendPoints(int amount) { }

}

