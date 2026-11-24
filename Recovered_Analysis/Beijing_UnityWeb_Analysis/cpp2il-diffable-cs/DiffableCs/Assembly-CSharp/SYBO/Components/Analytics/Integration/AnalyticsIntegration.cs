namespace SYBO.Components.Analytics.Integration;

public class AnalyticsIntegration : IAnalyticsIntegrationTest, ICoroutineHandler
{
	public const string PlatformConfig = "ios"; //Field offset: 0x0
	private const string PrefsKeyPersistedLeavesForegroundSessionDelta = "LeavesForegroundSessionDelta"; //Field offset: 0x0
	private const int PrefsKeyPersistedLeavesForegroundSessionDeltaDefault = -1; //Field offset: 0x0
	private const int persistedSessionEventNumberDefault = -1; //Field offset: 0x0
	public const string OSKeyAnalyticsEnabled = "sybo_analytics_enabled"; //Field offset: 0x0
	private const bool OSKeyAnalyticsEnabledDefault = False; //Field offset: 0x0
	public const string OSKeyAnalyticsFlushEnabled = "sybo_analytics_flush_enabled"; //Field offset: 0x0
	private const bool OSKeyAnalyticsFlushEnabledDefault = True; //Field offset: 0x0
	private const string PrefsKeyPersistedLeavesForegroundTime = "LeavesForegroundTime"; //Field offset: 0x0
	public const string OSKeySamplingThreshold = "sybo_analytics_sampling_threshold"; //Field offset: 0x0
	private const string OSKeyEndpointBaseUrlDefault = null; //Field offset: 0x0
	public const string OSKeyMaxGamesWithoutFlush = "sybo_analytics_max_games_without_flush"; //Field offset: 0x0
	private const int OSKeyMaxGamesWithoutFlushDefault = 10; //Field offset: 0x0
	public const string OSKeyGamesInSessionBeforeFirstFlush = "sybo_analytics_games_in_session_before_first_flush"; //Field offset: 0x0
	private const int OSKeyGamesInSessionBeforeFirstFlushDefault = 1; //Field offset: 0x0
	public const string OSKeyOnlyValidatedPurchases = "sybo_analytics_only_validated_purchases"; //Field offset: 0x0
	private const bool OSKeyOnlyValidatedPurchasesDefault = True; //Field offset: 0x0
	private const float OSKeySamplingThresholdDefault = 0; //Field offset: 0x0
	private const int NoAbTestSegmentDefault = -1; //Field offset: 0x0
	public const string OSKeyEndpointBaseUrl = "sybo_analytics_endpoint_baseurl"; //Field offset: 0x0
	private const int MenuScreenHistoryCountReported = 3; //Field offset: 0x0
	public const int UnusedInt = -1; //Field offset: 0x0
	public static readonly string AnalyticsUserIdPersistedDefault; //Field offset: 0x0
	public const string PrefabPath = "Analytics/AnalyticsIntegration"; //Field offset: 0x0
	private const float MaxFrameTimeSampleRangeMs = 2000; //Field offset: 0x0
	private const long ForegroundChangeThresholdMsTicks = 2000; //Field offset: 0x0
	private const int MenuScreenHistoryCountTracked = 4; //Field offset: 0x0
	public static readonly string PreviousClientVersionPersistedDefault; //Field offset: 0x4
	public static readonly int GamesSinceFlushPersistedDefault; //Field offset: 0x8
	public static readonly int CurrentSessionPersistedDefault; //Field offset: 0xC
	public static readonly string OperatingSystemPersistedDefault; //Field offset: 0x10
	public static readonly string DeviceIDPersistedDefault; //Field offset: 0x14
	public static readonly string OSLanguagePersistedDefault; //Field offset: 0x18
	public static readonly PerformanceLevel PerformanceLevelPersistedDefault; //Field offset: 0x1C
	public static readonly int GpuScorePersistedDefault; //Field offset: 0x20
	public static readonly string OnlineSettingsLocalePersistedDefault; //Field offset: 0x24
	public static readonly string UnhandledAbTestDataPersistedDefault; //Field offset: 0x28
	public static readonly SampleState SampleStateDefault; //Field offset: 0x2C
	private static readonly string PrefsKeyPersistedLeavesForegroundTimeDefault; //Field offset: 0x30
	private static bool _jsonClassInfoCached; //Field offset: 0x34
	private static Action<ISubwayBaseEvent> OnEventPosted; //Field offset: 0x38
	private AnalyticsSettings _settings; //Field offset: 0x10
	private float _samplingKey; //Field offset: 0x14
	private SampleState _sampleState; //Field offset: 0x18
	private bool _useDebugSettings; //Field offset: 0x1C
	private bool _useDebugSettingsOnce; //Field offset: 0x1D
	private AnalyticsSettings _debugSettings; //Field offset: 0x20
	private bool _usedDebugSettings; //Field offset: 0x24
	private SessionTracker _sessionTracker; //Field offset: 0x28
	private long _msTicksAtCurrentSessionStart; //Field offset: 0x30
	private AnalyticsManager _manager; //Field offset: 0x38
	private int _lastSession; //Field offset: 0x3C
	private int _lastGameIdInSession; //Field offset: 0x40
	private bool _isRunInProgress; //Field offset: 0x44
	private bool _isReadyToPostGameEvents; //Field offset: 0x45
	private bool _hasUnflushedPurchaseEvent; //Field offset: 0x46
	private bool _waitingToInitialize; //Field offset: 0x47
	private bool _subscribedEventPostingHandlers; //Field offset: 0x48
	private bool _subscribedToFrontScreenEvent; //Field offset: 0x49
	private bool _subscribedToInAppManager; //Field offset: 0x4A
	private string _menuScreenLast; //Field offset: 0x4C
	private Queue<string> _menuScreenQueue; //Field offset: 0x50
	private IPerformanceTracker _performanceProvider; //Field offset: 0x54
	private long _cachedMissionSkipPurchaseId; //Field offset: 0x58

	public static event Action<ISubwayBaseEvent> OnEventPosted
	{
		 add { } //Length: 2
		 remove { } //Length: 209
	}

	public AnalyticsSettings DebugSettings
	{
		 get { } //Length: 155
	}

	private int GameCountInSession
	{
		 get { } //Length: 39
	}

	private bool IsActive
	{
		 get { } //Length: 23
	}

	private bool IsPartOfSample
	{
		 get { } //Length: 566
	}

	private bool IsSupportedOnDevice
	{
		 get { } //Length: 12
	}

	public bool OnlyValidatedPurchases
	{
		 get { } //Length: 6
	}

	private AnalyticsManager SYBO.Components.Analytics.Integration.IAnalyticsIntegrationTest.Manager
	{
		 get { } //Length: 482
	}

	private static AnalyticsIntegration() { }

	public AnalyticsIntegration() { }

	private static void ABTestManager_OnTagAdded(string testTag, int segmentIndex) { }

	public static void add_OnEventPosted(Action<ISubwayBaseEvent> value) { }

	private void AddUserToSample(JoinedSampleSource joinedSampleSource, long sourceId) { }

	private static void CacheJsonClassInfo() { }

	private void CelebrationPopup_OnRewardDoubleUp(CelebrationReward reward) { }

	private void CharacterNameEventManager_OnCharacterSkippedWithKeys(CharacterId characterId, int amount) { }

	private void CharacterNameEventManager_OnCharacterSkippedWithVideo(CharacterId characterId) { }

	private PostAnalyticsProvider CreatePostAnalyticsProvider() { }

	private void EarnCoinsData_OnRewardURLOpened(Id id, int coinAmount) { }

	private void FacebookRewardsPopup_OnFacebookCharacterReceived(CharacterId characterId, int outfitIndex) { }

	private void FacebookRewardsPopup_OnFacebookRewardPaidOut(FacebookRewardType rewardType, int amount) { }

	public void Flush() { }

	private void FlushIfNeeded() { }

	private void FriendHelperCrew_OnFriendCoinsReceived(int coinAmount) { }

	private void Game_OnGameEnded() { }

	private void Game_OnGameStarted() { }

	private void Game_OnMenuScreenShown() { }

	private void Game_OnPlayerDied(bool wasPlayerAutoRevived) { }

	private void Game_OnRunStarted(bool wasPlayerRevived, bool revivedWithAds, bool adsWasAvailable, bool adsFailed) { }

	public AnalyticsSettings get_DebugSettings() { }

	private int get_GameCountInSession() { }

	private bool get_IsActive() { }

	private bool get_IsPartOfSample() { }

	private bool get_IsSupportedOnDevice() { }

	public bool get_OnlyValidatedPurchases() { }

	private string GetDeviceID() { }

	private int GetIncrementedSessionEventNumber() { }

	private int GetIncrementedSessionID() { }

	private string GetMenusBeforeString(bool excludeLastMenuIfNotPurchaseOrigin) { }

	private static string GetNewUserId() { }

	private static string GetOperatingSystem() { }

	private int GetPendingRewardAmount() { }

	private static string GetPlatformVendor() { }

	private float GetSamplingKey() { }

	private int GetSessionDelta() { }

	private int GetSessionID() { }

	private string GetUserAgentString() { }

	private void HandleNewAbTestTags() { }

	private bool HasUserInPlayerInfo() { }

	private void InAppManager_OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult) { }

	private void Initialize() { }

	private void InitializeFromSettings() { }

	private void InitializeManager() { }

	private void InitializeSampleState() { }

	private void InitializeSettings() { }

	private bool IsRewardMysteryBox(CelebrationReward reward) { }

	private bool IsTicksSinceLastActiveOverForegroundChangeThreshold(long msTicksSinceLastActive) { }

	private void LogRunSummary() { }

	private void LogWarningIfWindowsPhone() { }

	private void MissionManager_OnMissionComplete(string message, int missionIndex) { }

	private void MissionManager_OnMissionSkipped(bool skippedWithVideo, int missionIndex) { }

	private void OfferWallManager_OnPendingRewardsReceived(int rewardAmount) { }

	private void OnApplicationFocus(bool focusStatus) { }

	private void OnApplicationPause(bool pauseStatus) { }

	private void OnApplicationQuit() { }

	protected override void OnDestroy() { }

	private void OnDoubleCoinsReceived(CelebrationReward reward) { }

	private void OnlineSettings_OnDownloaded(bool success) { }

	private void OnRewardConsumablesWithVideo(ItemType type, int amount) { }

	private void OnValidate() { }

	private void PlayerInfo_OnDailyLetterCoinsRewarded(int amount) { }

	private void PostCharacterSkippedEvent(CharacterId characterId, ObtainableItemSource sourceType, long sourceId = -1) { }

	private void PostDeviceInfoIfDataChanged() { }

	private void PostEvent(T eventData, bool ignoreSampleCheck = false) { }

	private void PostJoinedSampleEvent(JoinedSampleSource joinedSampleSource, long sourceId) { }

	private void PostLeavesForegroundEvent(bool skipTimeThresholdCheck) { }

	private void PostSessionAndForegroundEvents() { }

	private void PurchaseHandler_OnIngameCurrencyPurchaseCompleted(object sender, SyboInGameCurrencyPurchaseEventArgs e) { }

	public static void remove_OnEventPosted(Action<ISubwayBaseEvent> value) { }

	private void Reset() { }

	private void RewardManager_OnMysteryBoxAddedForUnlock(CelebrationReward reward) { }

	private void RewardManager_OnRewardPaidOut(CelebrationReward reward) { }

	private void Start() { }

	private void SYBO.Components.Analytics.ICoroutineHandler.StartCoroutine(IEnumerator coroutine) { }

	private void SYBO.Components.Analytics.Integration.IAnalyticsIntegrationTest.GenerateFakeSessionEvents(int count) { }

	private AnalyticsManager SYBO.Components.Analytics.Integration.IAnalyticsIntegrationTest.get_Manager() { }

	private void SYBO.Components.Analytics.Integration.IAnalyticsIntegrationTest.SimulateOnlineSettingsDownload() { }

	private void UIScreenController_OnAwake() { }

	private void UIScreenController_OnChangedScreen(string screenName) { }

	private void UpdateEndpoint() { }

	private void UpdateEventHandlersPostingAnalyticsEvents(bool subscribe) { }

	private void UpdateFrontScreenHandler(bool subscribe) { }

}

