//Type is in global namespace

public class SocialManager : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Friend> <>9__84_0; //Field offset: 0x4
		public static Comparison<Friend> <>9__85_0; //Field offset: 0x8
		public static Action <>9__89_0; //Field offset: 0xC
		public static Action<RefreshType> <>9__89_1; //Field offset: 0x10
		public static Predicate<Friend> <>9__97_0; //Field offset: 0x14
		public static Action<Friend> <>9__97_1; //Field offset: 0x18
		public static Predicate<Friend> <>9__113_0; //Field offset: 0x1C
		public static Action<Friend> <>9__113_1; //Field offset: 0x20
		public static Comparison<FacebookProfile> <>9__128_3; //Field offset: 0x24
		public static DialogCompleteHandler <>9__130_0; //Field offset: 0x28
		public static Comparison<Friend> <>9__133_0; //Field offset: 0x2C
		public static DialogCompleteHandler <>9__133_1; //Field offset: 0x30
		public static Action<bool> <>9__143_0; //Field offset: 0x34

		private static <>c() { }

		public <>c() { }

		internal int <BragFacebook>b__133_0(Friend x, Friend y) { }

		internal void <BragFacebook>b__133_1(IDictionary<string, object> result, FacebookError error) { }

		internal bool <ClearGameCenter>b__97_0(Friend item) { }

		internal void <ClearGameCenter>b__97_1(Friend item) { }

		internal int <FacebookLoginCoroutine>b__128_3(FacebookProfile p1, FacebookProfile p2) { }

		internal bool <FacebookLogout>b__113_0(Friend item) { }

		internal void <FacebookLogout>b__113_1(Friend item) { }

		internal int <FriendsSortedByCash>b__85_0(Friend x, Friend y) { }

		internal int <FriendsSortedByScore>b__84_0(Friend x, Friend y) { }

		internal void <Init>b__89_0() { }

		internal void <Init>b__89_1(RefreshType refreshType) { }

		internal void <Invalidate>b__143_0(bool success) { }

		internal void <RecommendAppFacebook>b__130_0(IDictionary<string, object> result, FacebookError error) { }

	}

	private sealed class <>c__DisplayClass125_0
	{
		public FacebookPermissionCheck check; //Field offset: 0x8
		public SocialManager <>4__this; //Field offset: 0xC

		public <>c__DisplayClass125_0() { }

		internal void <FacebookCheckPermissionsCoroutine>b__0(IDictionary<string, object> result, FacebookError error, bool isFromCache) { }

	}

	private sealed class <>c__DisplayClass128_0
	{
		public float timeLeftBeforeGivingUp; //Field offset: 0x8
		public SocialManager <>4__this; //Field offset: 0xC
		public FacebookSession fbSession; //Field offset: 0x10
		public bool asynchronousRequestsCompleted; //Field offset: 0x14
		public Action<bool> onComplete; //Field offset: 0x18
		public RequestCompleteHandler <>9__2; //Field offset: 0x1C

		public <>c__DisplayClass128_0() { }

		internal void <FacebookLoginCoroutine>b__0(IDictionary<string, object> result, FacebookError error, bool isFromCache) { }

		internal void <FacebookLoginCoroutine>b__2(IDictionary<string, object> friendsResult, FacebookError friendsError, bool friendsIsFromCache) { }

	}

	private sealed class <>c__DisplayClass128_1
	{
		public StatusChangedHandler statusChangedHandler; //Field offset: 0x8
		public bool statusDidChange; //Field offset: 0xC

		public <>c__DisplayClass128_1() { }

		internal void <FacebookLoginCoroutine>b__1(State status, FacebookError error) { }

	}

	private sealed class <>c__DisplayClass162_0
	{
		public int context; //Field offset: 0x8
		public SocialManager <>4__this; //Field offset: 0xC

		public <>c__DisplayClass162_0() { }

		internal void <InitAchievements>b__0(Achievement[] achievements, string error) { }

	}

	private sealed class <>c__DisplayClass163_0
	{
		public SocialManager <>4__this; //Field offset: 0x8
		public string achievementId; //Field offset: 0xC
		public float percentCompleted; //Field offset: 0x10

		public <>c__DisplayClass163_0() { }

		internal void <ReportAchievement>b__0(string error) { }

	}

	private sealed class <>c__DisplayClass192_0
	{
		public int userid; //Field offset: 0x8

		public <>c__DisplayClass192_0() { }

		internal bool <WWWUpdateFriendScoresCompleted>b__0(Friend f) { }

	}

	private sealed class <>c__DisplayClass83_0
	{
		public int userid; //Field offset: 0x8

		public <>c__DisplayClass83_0() { }

		internal bool <FindFriend>b__0(Friend f) { }

	}

	private sealed class <>c__DisplayClass86_0
	{
		public Action<Friend, Texture2D> handler; //Field offset: 0x8
		public Friend friend; //Field offset: 0xC

		public <>c__DisplayClass86_0() { }

		internal void <DownloadLargePictureForUser>b__0(FacebookProfile profile, Texture2D texture) { }

		internal void <DownloadLargePictureForUser>b__1(GameCenterProfile Profiler, Texture2D texture) { }

	}

	private sealed class <DownloadFacebookPictures>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SocialManager <>4__this; //Field offset: 0x10
		public IDictionary<string, FacebookProfile> fbProfiles; //Field offset: 0x14
		private int <downloadFacebookPicturesContext>5__2; //Field offset: 0x18
		private Enumerator<FacebookProfile> <>7__wrap2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1676
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadFacebookPictures>d__137(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DownloadPictureForProfile>d__135 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FacebookProfile profile; //Field offset: 0x10
		public SocialPictureSize pictureSize; //Field offset: 0x14
		public Action<FacebookProfile, Texture2D> handler; //Field offset: 0x18
		private WWW <www>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 307
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadPictureForProfile>d__135(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <FacebookCheckPermissionsCoroutine>d__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FacebookPermissionCheck check; //Field offset: 0x10
		public SocialManager <>4__this; //Field offset: 0x14
		private <>c__DisplayClass125_0 <>8__1; //Field offset: 0x18
		private float <timeLeftBeforeGivingUp>5__2; //Field offset: 0x1C
		private float <lastRealTime>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 484
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FacebookCheckPermissionsCoroutine>d__125(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <FacebookLoginCoroutine>d__128 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SocialManager <>4__this; //Field offset: 0x10
		public Action<bool> onComplete; //Field offset: 0x14
		private <>c__DisplayClass128_0 <>8__1; //Field offset: 0x18
		private <>c__DisplayClass128_1 <>8__2; //Field offset: 0x1C
		private float <lastRealTime>5__2; //Field offset: 0x20
		private FacebookPermissionCheck <permissionsCheck>5__3; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1604
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FacebookLoginCoroutine>d__128(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <WWWRequestCoroutine>d__169 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string relativeUrl; //Field offset: 0x10
		public string[] postItems; //Field offset: 0x14
		public WWWComplete onWWWComplete; //Field offset: 0x18
		public object cookie; //Field offset: 0x1C
		private StringBuilder <sb>5__2; //Field offset: 0x20
		private WWW <www>5__3; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1263
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WWWRequestCoroutine>d__169(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class FacebookPermissionCheck
	{
		public FacebookPermissionCheckState state; //Field offset: 0x8

		public FacebookPermissionCheck() { }

	}

	private enum FacebookPermissionCheckState
	{
		Waiting = 0,
		Ok = 1,
		Missing = 2,
		LoggedOut = 3,
		Error = 4,
	}

	public enum FacebookState
	{
		None = 0,
		Error = 1,
		LoggingIn = 2,
		LoggedIn = 3,
		Opening = 4,
	}

	public enum SocialPictureSize
	{
		Normal = 0,
		Large = 1,
	}

	public delegate WWWComplete
	{

		public WWWComplete(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(WWWRequestResult result, string output, object cookie, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(WWWRequestResult result, string output, object cookie) { }

	}

	public enum WWWRequestResult
	{
		Success = 0,
		Error = 1,
	}

	private const byte VERSION = 2; //Field offset: 0x0
	private const int REPOST_MIN_SECONDS_DEFAULT = 1200; //Field offset: 0x0
	private const string LAST_REGISTER_TIMESTAMPTICKS_PLAYERPREFSKEY = "socmanlastregtime"; //Field offset: 0x0
	private const string LAST_REGISTER_DATA_PLAYERPREFSKEY = "socmanlastregdata"; //Field offset: 0x0
	private const string ONLINESETTINGS_REGISTER_MIN_SECONDS_KEY = "social_register_min_seconds"; //Field offset: 0x0
	private const int REGISTER_MIN_SECONDS_DEFAULT = 3600; //Field offset: 0x0
	private const string ONLINESETTINGS_FACEBOOK_FETCH_MAX_USERS_KEY = "social_facebook_fetch_max_users"; //Field offset: 0x0
	private const string ONLINESETTINGS_REPORT_MIN_SECONDS_KEY = "social_report_min_seconds"; //Field offset: 0x0
	private const int FACEBOOK_FETCH_MAX_USERS_DEFAULT = 5000; //Field offset: 0x0
	private const int FACEBOOK_KEEP_MAX_USERS_DEFAULT = 200; //Field offset: 0x0
	private const string ONLINESETTINGS_FRIENDSCORES_MIN_SECONDS_KEY = "social_friendscores_min_seconds"; //Field offset: 0x0
	private const int FRIENDSCORES_MIN_SECONDS_DEFAULT = 120; //Field offset: 0x0
	private static SocialManager _instance; //Field offset: 0x0
	public const int GAMECENTER_CONSOLIDATED = 2; //Field offset: 0x0
	public const int FACEBOOK_CONSOLIDATED = 1; //Field offset: 0x0
	private const string ONLINESETTINGS_FACEBOOK_KEEP_MAX_USERS_KEY = "social_facebook_keep_max_users"; //Field offset: 0x0
	private const int REPORT_GAMES_COUNT_DEFAULT = 5; //Field offset: 0x0
	private const string ONLINESETTINGS_REPORT_GAMES_COUNT_KEY = "social_report_games_count"; //Field offset: 0x0
	private const string ANNOUNCE_URL = "/announce.php"; //Field offset: 0x0
	private const string UNREGISTER_DEVICE_URL = "/unregisterdevice.php"; //Field offset: 0x0
	private const string REGISTER_DEVICE_URL = "/register2.php"; //Field offset: 0x0
	public const float FRIEND_DATA_REFRESH_ON_RESUME_AGE = 3600; //Field offset: 0x0
	public const float USER_DATA_REFRESH_ON_AUTHENTICATE_AGE = 600; //Field offset: 0x0
	private const int CONSOLIDATE_MIN_SECONDS_DEFAULT = 3600; //Field offset: 0x0
	private const string ONLINESETTINGS_CONSOLIDATE_MIN_SECONDS_KEY = "social_consolidate_min_seconds"; //Field offset: 0x0
	public const string SECRET = "resxrctrv7tgv7gb8h9h9u0909kllfmolkjnhghgjjkhjghg"; //Field offset: 0x0
	private const string FACEBOOK_APPID = "254616967963463"; //Field offset: 0x0
	public const string NOTIFICATION_SOUND_NAME = "cpush.wav"; //Field offset: 0x0
	private const float FACEBOOK_LOGIN_TIMEOUT = 10; //Field offset: 0x0
	private const string REPORT_SCORE_URL = "/report2.php"; //Field offset: 0x0
	private const string BRAG_URL = "/brag.php"; //Field offset: 0x0
	private const string POKE_URL = "/poke.php"; //Field offset: 0x0
	private const string CONSOLIDATE_FRIENDS_URL = "/friends2.php"; //Field offset: 0x0
	private const string UPDATE_FRIEND_SCORES_URL = "/scores2.php"; //Field offset: 0x0
	private static Action<FacebookProfile> facebookPictureDownloadedHandler; //Field offset: 0x4
	private static Action friendsChangedHandler; //Field offset: 0x8
	private static bool _applicationIsQuiting; //Field offset: 0xC
	private float _lastConsolidateFriendCompleteTime; //Field offset: 0xC
	private List<string> _latestPreConsolidationFacebookIds; //Field offset: 0x10
	private List<string> _latestSuccesfullyConsolidatedFacebookIds; //Field offset: 0x14
	private string _tempRegisterUserData; //Field offset: 0x18
	private bool _appHasFocus; //Field offset: 0x1C
	private int _userid; //Field offset: 0x20
	private string _lastFacebookLoginLocation; //Field offset: 0x24
	private bool <isRunningFacebookLogin>k__BackingField; //Field offset: 0x28
	private Action<bool> onRegisterUserCompleted; //Field offset: 0x2C
	private bool _registerUserCompleted; //Field offset: 0x30
	private Action<bool> friendsConsolidatedHandler; //Field offset: 0x34
	private FacebookProfile _fbProfile; //Field offset: 0x38
	private GameCenterProfile _gcProfile; //Field offset: 0x3C
	private Action _localUserUpdatedHandler; //Field offset: 0x40
	private List<Friend> _friends; //Field offset: 0x44
	private IDictionary<string, FacebookProfile> _fbProfiles; //Field offset: 0x48
	private bool _fbReady; //Field offset: 0x4C
	private DateTime _lastFriendScoreUpdateTimestamp; //Field offset: 0x50
	private bool _didAddAuthenticationHandlerToGameCenter; //Field offset: 0x58
	private Action _onFacebookStateChanged; //Field offset: 0x5C
	private FacebookState _fbState; //Field offset: 0x60
	private bool _didAddChangeHandlerToFacebookSession; //Field offset: 0x64
	private readonly string[] requiredPermissions; //Field offset: 0x68
	private int _downloadFacebookPicturesContext; //Field offset: 0x6C
	private int _consolidationState; //Field offset: 0x70
	private bool _consolidatedFriendsCompleted; //Field offset: 0x74
	private IDictionary<string, Achievement> _achievements; //Field offset: 0x78
	private int _initAchievementsContext; //Field offset: 0x7C
	private bool <requestInvolvingDevicetokenInProgress>k__BackingField; //Field offset: 0x80
	private bool <canUnregisterDevice>k__BackingField; //Field offset: 0x81
	private bool _pausePhotoDownloading; //Field offset: 0x82

	public static event Action<FacebookProfile> facebookPictureDownloadedHandler
	{
		 add { } //Length: 2
		 remove { } //Length: 209
	}

	public static event Action friendsChangedHandler
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public event Action<bool> friendsConsolidatedHandler
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<bool> onRegisterUserCompleted
	{
		 add { } //Length: 2
		 remove { } //Length: 111
	}

	public bool canUnregisterDevice
	{
		 get { } //Length: 10
		private set { } //Length: 12
	}

	public bool consolidatedFriendsCompleted
	{
		 get { } //Length: 724
	}

	public int consolidationState
	{
		 get { } //Length: 578
	}

	public static bool facebookDialogsSupported
	{
		 get { } //Length: 91
	}

	public bool facebookIsLoggedIn
	{
		 get { } //Length: 6
	}

	public FacebookProfile facebookProfile
	{
		 get { } //Length: 9
	}

	public FacebookState facebookState
	{
		 get { } //Length: 81
		private set { } //Length: 69
	}

	public bool gamecenterIsLoggedIn
	{
		 get { } //Length: 292
	}

	public bool gamecenterIsLoggedOut
	{
		 get { } //Length: 97
	}

	public GameCenterProfile gamecenterProfile
	{
		 get { } //Length: 6
	}

	public bool HasFacebookProfile
	{
		 get { } //Length: 123
	}

	public static SocialManager instance
	{
		 get { } //Length: 150
	}

	public bool isRegisterUserCompleted
	{
		 get { } //Length: 9
	}

	public bool isRunningFacebookLogin
	{
		 get { } //Length: 6
		private set { } //Length: 228
	}

	public string localDisplayName
	{
		 get { } //Length: 102
	}

	public int localUserId
	{
		 get { } //Length: 234
	}

	public Texture2D localUserImage
	{
		 get { } //Length: 6
	}

	public string localUserRealName
	{
		 get { } //Length: 37
	}

	public bool pausePhotoDownloading
	{
		 get { } //Length: 617
		 set { } //Length: 1302
	}

	public bool requestInvolvingDevicetokenInProgress
	{
		 get { } //Length: 87
		private set { } //Length: 297
	}

	private static SocialManager() { }

	public SocialManager() { }

	private void <Invalidate>b__143_1(bool success) { }

	private void <OnGameCenterAuthentication>b__98_0(string playerID, Texture2D photo, string photoError) { }

	private void <UpdateRemoteNotificationControl>b__203_0(bool success) { }

	public static void add_facebookPictureDownloadedHandler(Action<FacebookProfile> value) { }

	public static void add_friendsChangedHandler(Action value) { }

	public void add_friendsConsolidatedHandler(Action<bool> value) { }

	public void add_onRegisterUserCompleted(Action<bool> value) { }

	public void AddFacebookStateChangedHandler(Action handler) { }

	public void AddGameCenterSmallSizePictureDownloadedHandler(Action<GameCenterProfile> handler) { }

	public void AddLocalUserUpdatedHandler(Action handler) { }

	public void AnnounceToFriends(int relationsMask) { }

	public bool AreFacebookFriendsConsolidated() { }

	private void AttemptRelogin() { }

	private void Awake() { }

	public void BragFacebook(List<Friend> friends) { }

	public void BragNotify(int oldScore, List<Friend> friends) { }

	public int CashIn(Friend friend, int max) { }

	public int CashInAll(int maxPerFriend) { }

	private void ClearGameCenter() { }

	public void CollectFriendReward(Friend friend) { }

	private void ConsolidateFriends(Action<bool> consolidateFriendsCompleted) { }

	private FacebookSession CreateFacebookSessionIfNeeded() { }

	private IEnumerator DownloadFacebookPictures(IDictionary<string, FacebookProfile> fbProfiles) { }

	public void DownloadLargePictureForUser(Friend friend, Action<Friend, Texture2D> handler) { }

	private IEnumerator DownloadPictureForProfile(FacebookProfile profile, SocialPictureSize pictureSize, Action<FacebookProfile, Texture2D> handler) { }

	private Coroutine FacebookCheckPermissionsAsync(FacebookPermissionCheck check) { }

	private IEnumerator FacebookCheckPermissionsCoroutine(FacebookPermissionCheck check) { }

	public bool FacebookLogin(Action<bool> onComplete) { }

	private IEnumerator FacebookLoginCoroutine(Action<bool> onComplete) { }

	public void FacebookLogout() { }

	private void FetchRegisterUserParams(out string fbid, out string gcid, out string deviceToken, out string bundleVersion, out string highestScore, out string registerUserData, out string timezone, out string locale) { }

	public Friend FindFriend(int userid) { }

	private void FireAndForgetUnregisterDevice(string token) { }

	private void FriendConsolidationDidFinish(bool success) { }

	private void FriendsDidChange() { }

	public Friend[] FriendsSortedByCash() { }

	public Friend[] FriendsSortedByScore() { }

	public bool get_canUnregisterDevice() { }

	public bool get_consolidatedFriendsCompleted() { }

	public int get_consolidationState() { }

	public static bool get_facebookDialogsSupported() { }

	public bool get_facebookIsLoggedIn() { }

	public FacebookProfile get_facebookProfile() { }

	public FacebookState get_facebookState() { }

	public bool get_gamecenterIsLoggedIn() { }

	public bool get_gamecenterIsLoggedOut() { }

	public GameCenterProfile get_gamecenterProfile() { }

	public bool get_HasFacebookProfile() { }

	public static SocialManager get_instance() { }

	public bool get_isRegisterUserCompleted() { }

	public bool get_isRunningFacebookLogin() { }

	public string get_localDisplayName() { }

	public int get_localUserId() { }

	public Texture2D get_localUserImage() { }

	public string get_localUserRealName() { }

	public bool get_pausePhotoDownloading() { }

	public bool get_requestInvolvingDevicetokenInProgress() { }

	public static string GetChecksum(string data) { }

	private static string GetChecksum(string[] data) { }

	private int GetCurrentRank() { }

	private static string GetDeviceTypeString() { }

	private string GetFBListAsStringAndSaveAsPreConsolidated() { }

	private TimeSpan GetForceReportScoreTimeSpan() { }

	public string GetNameForRelation(Friend friend) { }

	private static string GetRandomIdentifier() { }

	private static string GetSaveDataPath() { }

	private void HandleLoggingIntoFacebookComplete(bool success, Action<bool> onComplete) { }

	public bool HasFacebookAccessToken() { }

	private bool HasUnconsolidatedFacebookFriends() { }

	public static void Init() { }

	private void InitAchievements() { }

	public void InitGameCenter() { }

	public void Invalidate() { }

	public static bool IsOAuthException(FacebookError error, object obj) { }

	public static void Log(string msg, Object context = null) { }

	public static void LogError(string msg, Object context = null) { }

	public static void LogWarning(string msg, Object context = null) { }

	private void OnApplicationFocus(bool focus) { }

	private void OnApplicationPause(bool pause) { }

	private void OnApplicationQuit() { }

	private void OnDownloadedFacebookPicture(FacebookProfile profile, Texture2D picture) { }

	private void OnFacebookPhotoDownloaded(FacebookProfile fbProfile) { }

	private void OnFacebookSessionStatusChanged(State status, FacebookError error) { }

	private void OnGameCenterAuthentication(bool hasLoginView, string error) { }

	private void OnGameCenterPhotoDownloaded(GameCenterProfile gcProfile) { }

	private void OnRemoteNotificationsEnabled(string deviceToken, string oldDeviceToken) { }

	public void Poke(Friend friend) { }

	public void RecommendAppFacebook() { }

	private void RegisterUser(Action<bool> registerUserCompleted) { }

	public static void remove_facebookPictureDownloadedHandler(Action<FacebookProfile> value) { }

	public static void remove_friendsChangedHandler(Action value) { }

	public void remove_friendsConsolidatedHandler(Action<bool> value) { }

	public void remove_onRegisterUserCompleted(Action<bool> value) { }

	public void RemoveFacebookStateChangedHandler(Action handler) { }

	public void RemoveGameCenterSmallSizePictureDownloadedHandler(Action<GameCenterProfile> handler) { }

	public void RemoveLocalUserUpdatedHandler(Action handler) { }

	public void ReportAchievement(string achievementId, float percentCompleted) { }

	public void ReportScore(int newScore, bool isNewHighscore) { }

	private void ResetTimeLeft(out float lastRealTime, out float timeLeft) { }

	private void set_canUnregisterDevice(bool value) { }

	private void set_facebookState(FacebookState value) { }

	private void set_isRunningFacebookLogin(bool value) { }

	public void set_pausePhotoDownloading(bool value) { }

	private void set_requestInvolvingDevicetokenInProgress(bool value) { }

	public void SetPokeFirstTime(Friend friend) { }

	private bool ShouldConsolidateFriends() { }

	private bool ShouldRegisterUser() { }

	private void UnregisterDevice(Action<bool> completionHandler) { }

	public void UpdateFriendScores(Action<bool> updateFriendsScoresCompleted) { }

	public void UpdateRemoteNotificationControl(bool newValue) { }

	private void UpdateTimeLeft(ref float lastRealTime, ref float timeLeft) { }

	private void WWWConsolidateFriendsCompleted(WWWRequestResult result, string output, object cookie) { }

	private void WWWRegisterUserCompleted(WWWRequestResult result, string output, object cookie) { }

	private void WWWReportScoreCompleted(WWWRequestResult result, string output, object cookie) { }

	public static IEnumerator WWWRequestCoroutine(WWWComplete onWWWComplete, string relativeUrl, object cookie, string[] postItems) { }

	private void WWWUnregisterDeviceCompleted(WWWRequestResult result, string output, object cookie) { }

	private void WWWUpdateFriendScoresCompleted(WWWRequestResult result, string output, object cookie) { }

}

