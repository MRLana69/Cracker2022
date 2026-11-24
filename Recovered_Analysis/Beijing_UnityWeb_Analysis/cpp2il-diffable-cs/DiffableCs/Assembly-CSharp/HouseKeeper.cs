//Type is in global namespace

public class HouseKeeper : MonoBehaviour
{
	private sealed class <InitAuthAndCloudSave>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 431
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <InitAuthAndCloudSave>d__18(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <OnSecondFrameEnded>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 216
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <OnSecondFrameEnded>d__19(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Start>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public HouseKeeper <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 170
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Start>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public delegate OnLateUpdate
	{

		public OnLateUpdate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private static OnLateUpdate onLateUpdate; //Field offset: 0x0
	private const string APPLICATION_AUTHENTICITY_KEY = "applicationAuthenticity"; //Field offset: 0x0
	private const string SFX_BEFORE_APPLICATION_LOSTFOCUS = "sfxBeforeLostFocus"; //Field offset: 0x0
	private const string MUSIC_BEFORE_APPLICATION_LOSTFOCUS = "musicBeforeLostFocus"; //Field offset: 0x0
	private const string RTL_ALIGNED_LANGUAGES_REGEX = "\p{IsArabic}|\p{IsHebrew}|\p{IsSyriac}|\p{IsThaana}"; //Field offset: 0x0
	private const float MIN_REFRESH_INTERVAL = 3600; //Field offset: 0x0
	private const string REFRESH_INTERVAL_KEY = "refreshinterval"; //Field offset: 0x0
	private const string ANDROID_IN_APP_BILLING_GAMEOBJECT_NAME = "InAppBillingAndroidGameObject"; //Field offset: 0x0
	private static Action secondFrameEnded; //Field offset: 0x4
	public static bool waitForCloudSave; //Field offset: 0x8
	private static bool _onlineServicesInitialized; //Field offset: 0x9
	private static Action<bool> delegateFacebookPayoutPopupAction; //Field offset: 0xC
	private static float _onlineSettingsLastDownloadTime; //Field offset: 0x10
	private bool _hasAddedAgeRestrictionEventListener; //Field offset: 0xC
	private int[] _dailyKeysBrackets; //Field offset: 0x10
	private int[] _consumableHoverboardBrackets; //Field offset: 0x14
	private int[] _headstartBrackets; //Field offset: 0x18
	private int[] _scoreBoosterBrackets; //Field offset: 0x1C

	public static event OnLateUpdate onLateUpdate
	{
		 add { } //Length: 96
		 remove { } //Length: 206
	}

	public static event Action secondFrameEnded
	{
		 add { } //Length: 217
		 remove { } //Length: 209
	}

	private static HouseKeeper() { }

	public HouseKeeper() { }

	public static void add_onLateUpdate(OnLateUpdate value) { }

	public static void add_secondFrameEnded(Action value) { }

	private void AddFpsCounter() { }

	private void Awake() { }

	private void CancellAllLocalNotifications() { }

	private void DebugSimulateFpsSpikes() { }

	public static void DeleteSoundOptionBeforeVideoAds() { }

	public static string FormatMessageWithNameIfPossible(string unidentifiedMessageID, string identifiedMessageID, object[] extraFormatArgs) { }

	private string GetBracketForValue(int value, int[] bracket) { }

	private string GetLocalNotificationMessage() { }

	private int GetNumberOfDaysSinceLastPlay() { }

	private void HookUpListenersToOnlineSettings() { }

	private void IncrementOwnedOutfits(CharacterId character, ref int outfitsOwned) { }

	private void IncrementTypeOfOwnedCharacter(CharacterId character, ref int regularCharactersOwned, ref int limitedCharactersOwned, ref int tokenCharactersOwned, ref int facebookCharactersOwned) { }

	public static IEnumerator InitAuthAndCloudSave() { }

	private void InitializeAdsSystem() { }

	private void InitLocale() { }

	public static void InitOnlineServicesIfNeeded() { }

	private bool IsDateToday(DateTime lastDate) { }

	private void LateUpdate() { }

	private static void Log(string msg, Object context = null) { }

	private void LogApplicationAuthenticity() { }

	private void LogApplicationWasLaunchedFromNotification(string message, string type = "", string jobID = "") { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	private static void MakeIOSNativeLog(string logMessage, string stackTrace, LogType type) { }

	private void OnAppHasRefreshed(RefreshType refreshType) { }

	private void OnApplicationPause(bool pause) { }

	private void OnApplicationQuit() { }

	private void OnFriendsConsolidated(bool success) { }

	private void OnOnlineSettingsDownloadedWithResult(bool result) { }

	private void OnOnlineSettingsSetupFinished() { }

	private void OnOpenedThroughNotification(Notification notification) { }

	private void OnProductPlacementDownloaded() { }

	private IEnumerator OnSecondFrameEnded() { }

	private void PostFlurryEventsOnceADay() { }

	private static void QueueFacebookPayoutPopupIfNeeded(bool isLoggedInToFacebook) { }

	public static void RefreshOnlineSettingsAndInappsIfNeeded() { }

	private void RefreshTopRun() { }

	private void RegisterAllBundlesDownloaded() { }

	private void RegisterBundleIdentifier() { }

	private void RegisterDailyActiveBoard() { }

	private void RegisterDailyActiveCharacter() { }

	private void RegisterDailyCoinsAmount() { }

	private void RegisterDailyKeysAmount() { }

	private void RegisterDevicePerformanceLevel() { }

	private void RegisterFacebookStatus() { }

	private void RegisterFirstInstallDate() { }

	private void RegisterLocale() { }

	private void RegisterLocalNotificationStatus() { }

	private void RegisterOwnedCharactersAndOutfits() { }

	private void RegisterOwnedConsumableHoverboards() { }

	private void RegisterOwnedHeadstarts() { }

	public void RegisterOwnedHoverboardsAndAbilities() { }

	private void RegisterOwnedScoreBoosters() { }

	private void RegisterReminderStatus() { }

	private void RegisterTotalAmountOfFinishedDiamondAwards() { }

	private void RegisterTotalAmountOfFinishedGoldAwards() { }

	private void RegisterTotalAmountOfFinishedSilverAwards() { }

	public static void remove_onLateUpdate(OnLateUpdate value) { }

	public static void remove_secondFrameEnded(Action value) { }

	private string RoundUpToTargetValue(int total, int factor) { }

	public static void SaveAudioOptionsBeforeVideoAds(bool sfxEnabled, bool musicEnabled) { }

	private void ScheduleDailyVideoNotificationIfNecessary() { }

	private void ScheduleDailyWordNotificationIfNecessary() { }

	private void ScheduleLocalNotificationsIfNecessary() { }

	private void ScheduleNotification(DateTime time, string title, string message) { }

	private void ScheduleTopRunNotificationIfNecessary() { }

	public static void SetFacebookPayoutAction(Action<bool> action) { }

	public static void SetFacebookPayoutActionToDefault() { }

	private IEnumerator Start() { }

	private static void TriggerActionForFacebookPayout(bool isLoggedInToFacebook) { }

	public static void TryRestoreSoundOptionAfterLostFocusIfNeeded() { }

	private void VerifyCharactersAndBoardsAmount() { }

}

