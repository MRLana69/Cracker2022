//Type is in global namespace

public class DebugSettingsPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RequestCompleteHandler <>9__140_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <RequestAnalyticsCheck>b__140_0(IRequest request, bool cache) { }

	}

	public enum DebugGuidelineType
	{
		Empty = 0,
		Hoverboards = 1,
		FacebookConnect = 2,
		Missions = 3,
		CollectGold = 4,
	}

	public enum DebugNotificationType
	{
		Test = 0,
		Coins = 1,
		TopRun = 2,
		MB = 3,
		SMB = 4,
		Video = 5,
	}

	public class DebugSettingsListAdapter
	{
		private const int DEBUGSETTINGS_TOGGLE_PREFAB = 0; //Field offset: 0x0
		private const int DEBUGSETTINGS_BUTTON_PREFAB = 1; //Field offset: 0x0
		private const int DEBUGSETTINGS_SUBTOGGLE_PREFAB = 2; //Field offset: 0x0
		private const int DEBUGSETTINGS_SPACE_PREFAB = 3; //Field offset: 0x0
		private const int DEBUGSETTINGS_EXPANDABLE_PREFAB = 4; //Field offset: 0x0
		private const int DEBUGSETTINGS_TITLE_PREFAB = 5; //Field offset: 0x0
		private const int DEBUGSETTINGS_SUBBUTTON_PREFAB = 6; //Field offset: 0x0
		public DebugSettingsPopup debugSettingsPopup; //Field offset: 0x10
		public GameObject debugTitlePrefab; //Field offset: 0x14
		public GameObject debugTogglePrefab; //Field offset: 0x18
		public GameObject debugButtonPrefab; //Field offset: 0x1C
		public GameObject debugSubButtonPrefab; //Field offset: 0x20
		public GameObject debugSubTogglePrefab; //Field offset: 0x24
		public GameObject debugExpandablePrefab; //Field offset: 0x28
		public GameObject debugSpacePrefab; //Field offset: 0x2C

		public DebugSettingsListAdapter(List<DebugSettingsCell> contentList, GameObject debugSettingsTogglePrefab, GameObject debugSettingsButtonPrefab, GameObject debugSettingsSubTogglePrefab, GameObject debugSettingsSpacePrefab, GameObject debugSettingsExpandablePrefab, GameObject debugSettingsTitlePrefab, GameObject debugSettingsSubButtonPrefab, DebugSettingsPopup screenReference) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass) { }

		public override int GetModelType(int index) { }

		public void SetNewDataList(List<DebugSettingsCell> leaderboardListT) { }

	}

	public class SybotRequestData
	{
		public string user_id; //Field offset: 0x8

		public SybotRequestData() { }

	}

	private enum TabNumber
	{
		Tab1 = 0,
		Tab2 = 1,
		Tab3 = 2,
		Tab4 = 3,
	}

	private static bool <forceRefreshAdSystem>k__BackingField; //Field offset: 0x0
	private const string ScreenTimeoutDescription = "Enables / disables screen timeout"; //Field offset: 0x0
	private const string ScreenTimeoutTitle = "Screen Timeout Disabled"; //Field offset: 0x0
	private const string ScreenTimeoutFunc = "ToggleScreenTimeout"; //Field offset: 0x0
	private const string KilooGoogleSheetID = "1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU"; //Field offset: 0x0
	private static bool _isShowingFps; //Field offset: 0x1
	public static Dictionary<string, string> completeAwardsTiersSelectedItems; //Field offset: 0x4
	public static int completeAwardsTiersSelectedTiers; //Field offset: 0x8
	public static Dictionary<string, string> almostCompleteAwardsTiersSelectedItems; //Field offset: 0xC
	public static int amountOfHuntTokensToReward; //Field offset: 0x10
	public static int amountOfMissionSetsToSkip; //Field offset: 0x14
	public static DebugNotificationType notificationTypeToDisplay; //Field offset: 0x18
	private static DebugGuidelineType _guidelineToDebug; //Field offset: 0x1C
	public static float TimeScaleInGameOverrideSelectedValue; //Field offset: 0x20
	public static float TimeScaleInMenuOverrideSelectedValue; //Field offset: 0x24
	public static bool DownloadNewOS; //Field offset: 0x28
	public static bool RefreshInterstitials; //Field offset: 0x29
	public static bool RefreshVideoAds; //Field offset: 0x2A
	public static bool HasDeliveredFullUpgrades; //Field offset: 0x2B
	public static bool ScreenTimoutDisabled; //Field offset: 0x2C
	public static bool HasSkippedMissions; //Field offset: 0x2D
	public static bool PrintRouteChunksInDebugLabel; //Field offset: 0x2E
	private static Action<bool> OnRoutePrintSettingChanged; //Field offset: 0x30
	private static bool _shouldRefreshListOnShow; //Field offset: 0x34
	private GameObject DebugSettingsTogglePrefab; //Field offset: 0x28
	private GameObject DebugSettingsSubTogglePrefab; //Field offset: 0x2C
	private GameObject DebugSettingsExpandablePrefab; //Field offset: 0x30
	private GameObject DebugSettingsButtonPrefab; //Field offset: 0x34
	private GameObject DebugSettingsSpacePrefab; //Field offset: 0x38
	private GameObject DebugSettingsTitlePrefab; //Field offset: 0x3C
	private GameObject DebugSettingsSubButtonPrefab; //Field offset: 0x40
	private GameObject TabsParent; //Field offset: 0x44
	private int lastTab1Index; //Field offset: 0x48
	private int lastTab2Index; //Field offset: 0x4C
	private int lastTab3Index; //Field offset: 0x50
	private int lastTab4Index; //Field offset: 0x54
	private TabNumber lastTabOpen; //Field offset: 0x58
	private bool _listHasBeenDisplayedOnce; //Field offset: 0x5C
	private List<DebugSettingsCell> _contentList; //Field offset: 0x60
	private DebugSettingsListAdapter _adapter; //Field offset: 0x64
	private ScrollView _scrollView; //Field offset: 0x68
	private bool _isDailyWordCompletedeChangeRegistered; //Field offset: 0x6C
	private int _originalScreenTimout; //Field offset: 0x70
	private GameObject fpsObject; //Field offset: 0x74

	public static event Action<bool> OnRoutePrintSettingChanged
	{
		 add { } //Length: 94
		 remove { } //Length: 209
	}

	public static bool forceRefreshAdSystem
	{
		 get { } //Length: 92
		private set { } //Length: 152
	}

	public static DebugGuidelineType guidelineToDebug
	{
		 get { } //Length: 92
		 set { } //Length: 215
	}

	public static bool IsShowingFPS
	{
		 get { } //Length: 92
	}

	private static DebugSettingsPopup() { }

	public DebugSettingsPopup() { }

	private void ActivateCollectState() { }

	public static void add_OnRoutePrintSettingChanged(Action<bool> value) { }

	private void AddSpace() { }

	private void AlmostCompleteAwardTier() { }

	private void ChangeToNextProvider() { }

	private void CompleteAwardsTiers() { }

	private void CopyPlayerDataToClipboard() { }

	public static void DebugButtonSkipTutorialLevel() { }

	private void DisplayFpsCounter() { }

	public void DisplayTab1() { }

	public void DisplayTab2() { }

	public void DisplayTab3() { }

	public void DisplayTab4() { }

	private void DisplayTimescalePauseButton() { }

	private void EnableGuidelineTest() { }

	private void ExportPlayerInfo() { }

	private static void ForceClosePresentPopups() { }

	private void ForceDownloadOnlineSettings() { }

	private void ForceRefreshAdSystem(AdType adType) { }

	private void ForciblyChangeInterstitialProvider() { }

	private void ForciblyChangeVideoProvider() { }

	public static bool get_forceRefreshAdSystem() { }

	public static DebugGuidelineType get_guidelineToDebug() { }

	public static bool get_IsShowingFPS() { }

	private void GiveFullUpgrades() { }

	public override void Hide() { }

	private void ImportPlayerInfo() { }

	public override void Init() { }

	private void InsertButton(string title, string description, string functionName, ButtonIcon buttonIcon) { }

	private void InsertGroupBottom() { }

	private void InsertGroupExpandable(string title, DebugSetting settingType, bool multiSelect = false) { }

	private void InsertGroupSubButton(string title, string buttonText, string functionName) { }

	private void InsertGroupTitle(string title, string description) { }

	private void InsertGroupToggle(string title, string functionName, DebugSetting settingType) { }

	private void InsertGroupTopToggle(string title, string description, string functionName, DebugSetting settingType) { }

	private void InsertToggle(string title, string description, string functionName, DebugSetting settingType) { }

	public static bool IsAllowingDebugging() { }

	private bool IsWordyWeekendActive() { }

	private void OpenABTestTesterPopup() { }

	private void OpenAdSystemTesterPopup() { }

	private void OpenCelebrationTesterPopup() { }

	private void OpenCharacterOwnagePopup() { }

	private void OpenEventTesterPopup() { }

	private void OpenWeeklyHuntTesterPopup() { }

	private void OpenWelcomePopup() { }

	private void RecordFPS() { }

	private void RefreshScrollList() { }

	public static void remove_OnRoutePrintSettingChanged(Action<bool> value) { }

	public void RequestAnalyticsCheck() { }

	private void ResetFpb() { }

	private void ResetList() { }

	private void RewardHuntTokens() { }

	private void RewardWordyWeekendLetter() { }

	private void SaveIndex() { }

	private void ScheduleTestNotification() { }

	private void ScrollToLastIndex(TabNumber tab) { }

	private static void set_forceRefreshAdSystem(bool value) { }

	public static void set_guidelineToDebug(DebugGuidelineType value) { }

	private void SetContent() { }

	private void SetContentList(TabNumber tab) { }

	public override void Show() { }

	private void SkipMissions() { }

	private void SkipTutorialLevel() { }

	private static void SkipTutorialLevelSegment() { }

	private void SkipVideoAds() { }

	private void StartAutoFPSTest() { }

	private void StartAutoFPSTestPreSet() { }

	private void StartBenchmark() { }

	private void StartBenchmarkConfirmed(string popupResult) { }

	private void TestFpsSpikes() { }

	private void ToggleAdDebugProviderState() { }

	private void ToggleAdSystemSingleImpressionLimit() { }

	private void ToggleAllBoards() { }

	private void ToggleAllChars() { }

	private void ToggleCappedFPS() { }

	private void ToggleCharacterNoHitCollisions() { }

	private void ToggleDebugFailNextCacheCall() { }

	private void ToggleDebugInterstitialEditor() { }

	private void ToggleDebugInterstitialIgnoreGracePeriod() { }

	private void ToggleDebugInterstitialImpressionlimit() { }

	private void ToggleDebugInterstitialInApp() { }

	private void ToggleDebugInterstitialProviders() { }

	private void ToggleDebugInterstitialTimelimit() { }

	private void ToggleDebugLimitedBoardPopup() { }

	private void ToggleDebugLimitedCharacterPopup() { }

	private void ToggleDebugShaders() { }

	private void ToggleDebugVideoAdProviders() { }

	private void ToggleDebugZDistanceTargetPosition() { }

	private void ToggleDisplayAllBoards() { }

	private void ToggleDisplayAllChars() { }

	private void ToggleEnableBoardBundle() { }

	private void ToggleFreePurchases() { }

	private void ToggleHolidaySales() { }

	private void ToggleLimitedBoardPopupIgnoreExpire() { }

	private void ToggleLimitedCharacterPopupIgnoreExpire() { }

	private void ToggleNewYearSales() { }

	private void ToggleOnlineSettingsTestTime() { }

	private void TogglePrintRouteNames() { }

	private void ToggleQueuedEnvironmentSpawning() { }

	private void ToggleSales() { }

	private void ToggleScreenTimeout() { }

	private void ToggleShowEndPerformanceInDevScreen() { }

	private void ToggleShowFrontScreen() { }

	private void ToggleSkipDailyLetters() { }

	private void ToggleUnCappedFPS() { }

	private void ToggleUseOnlineSettingsSet() { }

	private void UpdateQuickVideoButtonState() { }

}

