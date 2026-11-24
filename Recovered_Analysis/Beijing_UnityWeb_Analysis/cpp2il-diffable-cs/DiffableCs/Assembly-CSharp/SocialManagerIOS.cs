//Type is in global namespace

public class SocialManagerIOS : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RequestCompleteHandler <>9__36_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <ReportScore>b__36_0(string error) { }

	}

	private sealed class <>c__DisplayClass29_0
	{
		public int context; //Field offset: 0x8
		public SocialManagerIOS <>4__this; //Field offset: 0xC
		public LoadPlayersCompletionHandler <>9__1; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal void <LoadFriends>b__0(Leaderboard leaderboard, string leaderboardError) { }

		internal void <LoadFriends>b__1(Player[] players, string playersError) { }

	}

	private sealed class <>c__DisplayClass30_0
	{
		public GameCenterProfile profile; //Field offset: 0x8

		public <>c__DisplayClass30_0() { }

		internal void <RefreshFriendImages>b__0(GameCenterProfile prof, Texture2D picture) { }

	}

	private sealed class <>c__DisplayClass31_0
	{
		public GameCenterProfile profile; //Field offset: 0x8
		public Action<GameCenterProfile, Texture2D> handler; //Field offset: 0xC

		public <>c__DisplayClass31_0() { }

		internal void <DownloadPictureForProfile>b__0(string playerID, Texture2D photo, string error) { }

	}

	private sealed class <DownloadPictureForProfile>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterProfile profile; //Field offset: 0x10
		public Action<GameCenterProfile, Texture2D> handler; //Field offset: 0x14
		public SocialPictureSize pictureSize; //Field offset: 0x18
		private <>c__DisplayClass31_0 <>8__1; //Field offset: 0x1C
		private DateTime <lastRefresh>5__2; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 716
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadPictureForProfile>d__31(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RefreshFriendImages>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SocialManagerIOS <>4__this; //Field offset: 0x10
		public Dictionary<string, GameCenterProfile> gcProfiles; //Field offset: 0x14
		private int <photoDownloadContext>5__2; //Field offset: 0x18
		private Enumerator<GameCenterProfile> <>7__wrap2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1743
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RefreshFriendImages>d__30(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum GCState
	{
		LoggedOut = 0,
		Authenticating = 1,
		LoadingFriends = 2,
		LoggedIn = 3,
	}

	private const string ONLINESETTINGS_FILTER_GC_FRIENDS_KEY = "social_filter_gc_friends"; //Field offset: 0x0
	private const bool FILTER_GC_FRIENDS_USING_LEADERBOARD_DEFAULT = True; //Field offset: 0x0
	private const string GC_LEADERBOARD_ID = "com.kiloo.subwaysurfers.ScoreLeaderboard"; //Field offset: 0x0
	private static SocialManagerIOS _instance; //Field offset: 0x0
	private static Action<GameCenterProfile> playerPhotoDownloadedHandler; //Field offset: 0x4
	private static bool _applicationIsQuiting; //Field offset: 0x8
	private GCState _gcState; //Field offset: 0xC
	private Dictionary<string, GameCenterProfile> _gcFriends; //Field offset: 0x10
	private bool _pausePhotoDownloading; //Field offset: 0x14
	private int _photoDownloadContext; //Field offset: 0x18
	private List<string> _latestPreConsolidationGCIds; //Field offset: 0x1C
	private List<string> _latestSuccesfullyConsolidationGCIds; //Field offset: 0x20
	private int _loadFriendsContext; //Field offset: 0x24
	private ShowViewState _lastViewState; //Field offset: 0x28
	private string _lastLeaderboardCategory; //Field offset: 0x2C
	private LeaderboardTimeScope _lastTimeScope; //Field offset: 0x30
	private Action _invalidate; //Field offset: 0x34

	private static event Action<GameCenterProfile> playerPhotoDownloadedHandler
	{
		 add { } //Length: 223
		 remove { } //Length: 209
	}

	public GCState gameCenterState
	{
		 get { } //Length: 12
		 set { } //Length: 9
	}

	public static SocialManagerIOS instance
	{
		 get { } //Length: 43
	}

	public static bool isInstanced
	{
		 get { } //Length: 91
	}

	public bool pausePhotoDownloading
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	private static SocialManagerIOS() { }

	public SocialManagerIOS() { }

	private void <ShowLeaderBoard>b__40_0(ShowViewState viewState, string leaderboardCategory, LeaderboardTimeScope leaderboardTimescope) { }

	public void AbortAsynchronousProcesses() { }

	private static void add_playerPhotoDownloadedHandler(Action<GameCenterProfile> value) { }

	public void AddInvalidateHandler(Action handler) { }

	public static void AddPlayerPhotoDownloadedHandler(Action<GameCenterProfile> handler) { }

	private void Awake() { }

	public void ClearFriends() { }

	public IEnumerator DownloadPictureForProfile(GameCenterProfile profile, SocialPictureSize pictureSize, Action<GameCenterProfile, Texture2D> handler) { }

	private void FlurryLogGCFriendsRetrieved(int total, int withGameInstalled) { }

	public bool GCFriendsContainKey(string key) { }

	public GCState get_gameCenterState() { }

	public static SocialManagerIOS get_instance() { }

	public static bool get_isInstanced() { }

	public bool get_pausePhotoDownloading() { }

	public string GetGCListAsStringAndSaveAsPreConsolidated() { }

	public void HandleConsolidatedFriendsSuccess() { }

	public bool HasUnconsolidatedGCFriends() { }

	private static void Init() { }

	public bool IsDoneAuthenticating() { }

	public void LoadFriends() { }

	public static void Log(string msg, Object context = null) { }

	public static void LogError(string msg, Object context = null) { }

	public static void LogWarning(string msg, Object context = null) { }

	private void OnApplicationQuit() { }

	private void PerformLoadFriendsDoneActions() { }

	private IEnumerator RefreshFriendImages(Dictionary<string, GameCenterProfile> gcProfiles) { }

	private static void remove_playerPhotoDownloadedHandler(Action<GameCenterProfile> value) { }

	public static void RemovePlayerPhotoDownloadedHandler(Action<GameCenterProfile> handler) { }

	public void ReportScore(int newScore) { }

	public void set_gameCenterState(GCState value) { }

	public void set_pausePhotoDownloading(bool value) { }

	public void ShowLeaderBoard() { }

	public GameCenterProfile TryGetUserProfileFromKey(string key) { }

}

