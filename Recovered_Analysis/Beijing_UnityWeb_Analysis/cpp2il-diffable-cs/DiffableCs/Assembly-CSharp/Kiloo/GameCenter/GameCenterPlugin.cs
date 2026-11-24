namespace Kiloo.GameCenter;

public class GameCenterPlugin : MonoBehaviour
{
	private sealed class <>c__DisplayClass51_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterGenerateIdentityVerificationSignatureRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass51_0() { }

		internal void <GenerateIdentityVerificationSignatureCoroutine>b__0(string publicKeyUrl, byte[] signature, byte[] salt, ulong timestamp, string error) { }

	}

	private sealed class <>c__DisplayClass55_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterLoadFriendsRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal void <LoadFriendsCoroutine>b__0(string[] result, string error) { }

	}

	private sealed class <>c__DisplayClass59_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterLoadPlayersRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass59_0() { }

		internal void <LoadPlayersCoroutine>b__0(Player[] result, string error) { }

	}

	private sealed class <>c__DisplayClass63_0
	{
		public int textureWidth; //Field offset: 0x8
		public int textureHeight; //Field offset: 0xC
		public LoadPhotoCompletionHandler completionHandler; //Field offset: 0x10
		public string playerID; //Field offset: 0x14

		public <>c__DisplayClass63_0() { }

	}

	private sealed class <>c__DisplayClass63_1
	{
		public int context; //Field offset: 0x8
		public <>c__DisplayClass63_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass63_1() { }

		internal void <LoadPhoto>b__0(int imgWidth, int imgHeight, string error) { }

	}

	private sealed class <>c__DisplayClass65_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterLoadPhotoRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass65_0() { }

		internal void <LoadPhotoCoroutine>b__0(string id, Texture2D result, string error) { }

	}

	private sealed class <>c__DisplayClass70_0
	{
		public GameCenterReportScoreRequest request; //Field offset: 0x8

		public <>c__DisplayClass70_0() { }

		internal void <ReportScore>b__0(RequestCompleteHandler completeHandler) { }

	}

	private sealed class <>c__DisplayClass72_0
	{
		public LoadLeaderboardCompletionHandler completionHandler; //Field offset: 0x8
		public string category; //Field offset: 0xC
		public LeaderboardPlayerScope playerScope; //Field offset: 0x10
		public LeaderboardTimeScope timeScope; //Field offset: 0x14
		public int rangeBegin; //Field offset: 0x18
		public int rangeCount; //Field offset: 0x1C

		public <>c__DisplayClass72_0() { }

		internal void <LoadLeaderboard>b__0(Leaderboard leaderboard, string error) { }

	}

	private sealed class <>c__DisplayClass74_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterLoadLeaderboardRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass74_0() { }

		internal void <LoadLeaderboardCoroutine>b__0(Leaderboard result, string error) { }

	}

	private sealed class <>c__DisplayClass75_0
	{
		public LoadLeaderboardCompletionHandler completionHandler; //Field offset: 0x8
		public string category; //Field offset: 0xC
		public LeaderboardTimeScope timeScope; //Field offset: 0x10

		public <>c__DisplayClass75_0() { }

		internal void <LoadLeaderboardForIDs>b__0(Leaderboard leaderboard, string error) { }

	}

	private sealed class <>c__DisplayClass79_0
	{
		public GameCenterReportAchievementsRequest request; //Field offset: 0x8

		public <>c__DisplayClass79_0() { }

		internal void <ReportAchievements>b__0(RequestCompleteHandler completeHandler) { }

	}

	private sealed class <>c__DisplayClass83_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterLoadAchievementsRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass83_0() { }

		internal void <LoadAchievementsCoroutine>b__0(Achievement[] result, string error) { }

	}

	private sealed class <>c__DisplayClass87_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterLoadAchievementDescriptionsRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass87_0() { }

		internal void <LoadAchievementDescriptionsCoroutine>b__0(AchievementDescription[] result, string error) { }

	}

	private sealed class <>c__DisplayClass90_0
	{
		public bool canceled; //Field offset: 0x8
		public GameCenterRequest request; //Field offset: 0xC
		public bool working; //Field offset: 0x10

		public <>c__DisplayClass90_0() { }

		internal void <RequestCoroutine>b__0(string error) { }

	}

	private sealed class <GenerateIdentityVerificationSignatureCoroutine>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterGenerateIdentityVerificationSignatureRequest request; //Field offset: 0x10
		private <>c__DisplayClass51_0 <>8__1; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 384
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GenerateIdentityVerificationSignatureCoroutine>d__51(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoadAchievementDescriptionsCoroutine>d__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLoadAchievementDescriptionsRequest request; //Field offset: 0x10
		private <>c__DisplayClass87_0 <>8__1; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 384
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadAchievementDescriptionsCoroutine>d__87(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoadAchievementsCoroutine>d__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLoadAchievementsRequest request; //Field offset: 0x10
		private <>c__DisplayClass83_0 <>8__1; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 384
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadAchievementsCoroutine>d__83(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoadFriendsCoroutine>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLoadFriendsRequest request; //Field offset: 0x10
		private <>c__DisplayClass55_0 <>8__1; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 384
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadFriendsCoroutine>d__55(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoadLeaderboardCoroutine>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLoadLeaderboardRequest request; //Field offset: 0x10
		private <>c__DisplayClass74_0 <>8__1; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 547
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadLeaderboardCoroutine>d__74(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoadPhotoCoroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLoadPhotoRequest request; //Field offset: 0x10
		private <>c__DisplayClass65_0 <>8__1; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 439
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadPhotoCoroutine>d__65(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoadPlayersCoroutine>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterLoadPlayersRequest request; //Field offset: 0x10
		private <>c__DisplayClass59_0 <>8__1; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 398
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoadPlayersCoroutine>d__59(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestCoroutine>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterRequest request; //Field offset: 0x10
		public Action<RequestCompleteHandler> requestFunction; //Field offset: 0x14
		private <>c__DisplayClass90_0 <>8__1; //Field offset: 0x18
		private float <startTime>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 359
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestCoroutine>d__90(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class Achievement
	{
		public string identifier; //Field offset: 0x8
		public float percentComplete; //Field offset: 0xC
		public DateTime lastReportedDate; //Field offset: 0x10

		public bool complete
		{
			 get { } //Length: 6
		}

		public Achievement() { }

		public bool get_complete() { }

	}

	public class AchievementDescription
	{
		public string identifier; //Field offset: 0x8
		public string title; //Field offset: 0xC
		public string unachievedDescription; //Field offset: 0x10
		public string achievedDescription; //Field offset: 0x14
		public int maximumPoints; //Field offset: 0x18
		public bool replayable; //Field offset: 0x1C
		public bool hidden; //Field offset: 0x1D
		public string groupIdentifier; //Field offset: 0x20

		public AchievementDescription() { }

	}

	public delegate AuthenticateHandler
	{

		public AuthenticateHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool hasLoginView, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool hasLoginView, string error) { }

	}

	public delegate GenerateIdentityVerificationSignatureCompletionHandler
	{

		public GenerateIdentityVerificationSignatureCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string publicKeyUrl, byte[] signature, byte[] salt, ulong timestamp, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string publicKeyUrl, byte[] signature, byte[] salt, ulong timestamp, string error) { }

	}

	private class GenerateIdentityVerificationSignatureResult
	{
		public int context; //Field offset: 0x8
		public string publicKeyUrl; //Field offset: 0xC
		public string signature; //Field offset: 0x10
		public string salt; //Field offset: 0x14
		public ulong timestamp; //Field offset: 0x18
		public string error; //Field offset: 0x20

		public GenerateIdentityVerificationSignatureResult() { }

	}

	private delegate InternalLoadPhotoCompletionHandler
	{

		public InternalLoadPhotoCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int imgWidth, int imgHeight, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(int imgWidth, int imgHeight, string error) { }

	}

	public class Leaderboard
	{
		public string category; //Field offset: 0x8
		public int rangeBegin; //Field offset: 0xC
		public int rangeCount; //Field offset: 0x10
		public LeaderboardPlayerScope playerScope; //Field offset: 0x14
		public LeaderboardTimeScope timeScope; //Field offset: 0x18
		public Score localPlayerScore; //Field offset: 0x20
		public Score[] scores; //Field offset: 0x48
		public string groupIdentifier; //Field offset: 0x4C
		public uint maxRange; //Field offset: 0x50
		public string title; //Field offset: 0x54

		public Leaderboard() { }

	}

	public enum LeaderboardPlayerScope
	{
		Global = 0,
		FriendsOnly = 1,
	}

	public enum LeaderboardTimeScope
	{
		Today = 0,
		Week = 1,
		AllTime = 2,
	}

	public delegate LoadAchievementDescriptionsCompletionHandler
	{

		public LoadAchievementDescriptionsCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AchievementDescription[] achievements, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(AchievementDescription[] achievements, string error) { }

	}

	public delegate LoadAchievementsCompletionHandler
	{

		public LoadAchievementsCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Achievement[] achievements, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Achievement[] achievements, string error) { }

	}

	public delegate LoadFriendsCompletionHandler
	{

		public LoadFriendsCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string[] friends, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string[] friends, string error) { }

	}

	public delegate LoadLeaderboardCompletionHandler
	{

		public LoadLeaderboardCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Leaderboard leaderboard, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Leaderboard leaderboard, string error) { }

	}

	public delegate LoadPhotoCompletionHandler
	{

		public LoadPhotoCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string playerID, Texture2D photo, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string playerID, Texture2D photo, string error) { }

	}

	public delegate LoadPlayersCompletionHandler
	{

		public LoadPlayersCompletionHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Player[] players, string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Player[] players, string error) { }

	}

	public struct LocalPlayer
	{
		public string playerID; //Field offset: 0x0
		public string alias; //Field offset: 0x4
		public string displayName; //Field offset: 0x8
		public bool underage; //Field offset: 0xC
		public bool authenticated; //Field offset: 0xD

	}

	public enum PhotoSize
	{
		Small = 0,
		Normal = 1,
	}

	public struct Player
	{
		public string playerID; //Field offset: 0x0
		public string alias; //Field offset: 0x4
		public string displayName; //Field offset: 0x8
		public bool isFriend; //Field offset: 0xC

	}

	public delegate RequestCompleteHandler
	{

		public RequestCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string error) { }

	}

	public struct Score
	{
		public string playerID; //Field offset: 0x0
		public int rank; //Field offset: 0x4
		public long value; //Field offset: 0x8
		public string formattedValue; //Field offset: 0x10
		public DateTime date; //Field offset: 0x18
		public ulong context; //Field offset: 0x20

	}

	public enum ShowViewState
	{
		Default = -1,
		LeaderBoards = 0,
		Achievements = 1,
		Challenges = 2,
	}

	public delegate ViewDismissedHandler
	{

		public ViewDismissedHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(ShowViewState viewState, string leaderboardCategory, LeaderboardTimeScope leaderboardTimeScope, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(ShowViewState viewState, string leaderboardCategory, LeaderboardTimeScope leaderboardTimeScope) { }

	}

	private const char SEPARATION_CHAR = '\u7C'; //Field offset: 0x0
	private const string ESCAPED_SEPARATION_CHAR = "&#124;"; //Field offset: 0x0
	private static GameCenterPlugin _instance; //Field offset: 0x0
	private static AuthenticateHandler authenticationEvent; //Field offset: 0x4
	private bool _hasLoginView; //Field offset: 0xC
	private bool _initialAuthenticationComplete; //Field offset: 0xD
	private ViewDismissedHandler _viewDismissedHandler; //Field offset: 0x10

	public static event AuthenticateHandler authenticationEvent
	{
		 add { } //Length: 6
		 remove { } //Length: 209
	}

	public static bool hasLoginView
	{
		 get { } //Length: 10
	}

	public static bool initialAuthenticationComplete
	{
		 get { } //Length: 199
	}

	public static bool isSupported
	{
		 get { } //Length: 3
	}

	private static bool _GameCenterArePhotosSupported() { }

	private static void _GameCenterGenerateIdentityVerificationSignature(int handlerContext) { }

	private static void _GameCenterGetLocalPlayer(ref LocalPlayer localPlayer) { }

	private static bool _GameCenterGetPhotoPixels(int context, int width, int height, nint pixels) { }

	private static void _GameCenterInit(string gameObject) { }

	private static void _GameCenterLoadAchievementDescriptions(int handlerContext) { }

	private static void _GameCenterLoadAchievements(int handlerContext) { }

	private static void _GameCenterLoadFriends(int handlerContext) { }

	private static void _GameCenterLoadLeaderboard(string category, int playerScope, int timeScope, int rangeBegin, int rangeCount, int handlerContext) { }

	private static void _GameCenterLoadLeaderboardForIDs(string category, string playerIDs, int timeScope, int handlerContext) { }

	private static void _GameCenterLoadPhoto(string playerID, int size, int handlerContext) { }

	private static void _GameCenterLoadPlayers(string playerIDs, int handlerContext) { }

	private static void _GameCenterReportAchievement(string achievementID, float percentComplete, int showsCompletionBanner, int handlerContext) { }

	private static void _GameCenterReportAchievements(string interleavedAchievements, int showsCompletionBanner, int handlerContext) { }

	private static void _GameCenterReportScore(string category, long scoreValue, ulong scoreContext, int handlerContext) { }

	private static void _GameCenterResetAchievements(int handlerContext) { }

	private static void _GameCenterShowLoginView() { }

	private static void _GameCenterShowView(int viewState, string leaderboardCategory, int leaderboardTimeScope) { }

	private static GameCenterPlugin() { }

	public GameCenterPlugin() { }

	public static void add_authenticationEvent(AuthenticateHandler value) { }

	public static bool ArePhotosSupported() { }

	public static Coroutine GenerateIdentityVerificationSignature(GameCenterGenerateIdentityVerificationSignatureRequest request) { }

	public static void GenerateIdentityVerificationSignature(GenerateIdentityVerificationSignatureCompletionHandler completionHandler) { }

	private static IEnumerator GenerateIdentityVerificationSignatureCoroutine(GameCenterGenerateIdentityVerificationSignatureRequest request) { }

	public static bool get_hasLoginView() { }

	public static bool get_initialAuthenticationComplete() { }

	public static bool get_isSupported() { }

	public static LocalPlayer GetLocalPlayer() { }

	public static void GetLocalPlayer(ref LocalPlayer player) { }

	public static void Init() { }

	public static Coroutine LoadAchievementDescriptions(GameCenterLoadAchievementDescriptionsRequest request) { }

	public static void LoadAchievementDescriptions(LoadAchievementDescriptionsCompletionHandler completionHandler) { }

	private static IEnumerator LoadAchievementDescriptionsCoroutine(GameCenterLoadAchievementDescriptionsRequest request) { }

	public static Coroutine LoadAchievements(GameCenterLoadAchievementsRequest request) { }

	public static void LoadAchievements(LoadAchievementsCompletionHandler completionHandler) { }

	private static IEnumerator LoadAchievementsCoroutine(GameCenterLoadAchievementsRequest request) { }

	public static Coroutine LoadFriends(GameCenterLoadFriendsRequest request) { }

	public static void LoadFriends(LoadFriendsCompletionHandler completionHandler) { }

	private static IEnumerator LoadFriendsCoroutine(GameCenterLoadFriendsRequest request) { }

	public static Coroutine LoadLeaderboard(GameCenterLoadLeaderboardRequest request) { }

	public static void LoadLeaderboard(string category, LeaderboardPlayerScope playerScope, LeaderboardTimeScope timeScope, int rangeBegin, int rangeCount, LoadLeaderboardCompletionHandler completionHandler) { }

	private static IEnumerator LoadLeaderboardCoroutine(GameCenterLoadLeaderboardRequest request) { }

	public static void LoadLeaderboardForIDs(string category, string[] playerIDs, LeaderboardTimeScope timeScope, LoadLeaderboardCompletionHandler completionHandler) { }

	public static void LoadPhoto(string playerID, PhotoSize size, int textureWidth, int textureHeight, LoadPhotoCompletionHandler completionHandler) { }

	public static Coroutine LoadPhoto(GameCenterLoadPhotoRequest request) { }

	private static IEnumerator LoadPhotoCoroutine(GameCenterLoadPhotoRequest request) { }

	public static void LoadPlayers(string[] playerIDs, LoadPlayersCompletionHandler completionHandler) { }

	public static Coroutine LoadPlayers(GameCenterLoadPlayersRequest request) { }

	private static IEnumerator LoadPlayersCoroutine(GameCenterLoadPlayersRequest request) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	private void OnGameCenterAuthenticationEvent(string param) { }

	private void OnGameCenterGenerateIdentityVerificationSignatureComplete(string json) { }

	private void OnGameCenterLoadAchievementDescriptionsComplete(string param) { }

	private void OnGameCenterLoadAchievementsComplete(string param) { }

	private void OnGameCenterLoadFriendsComplete(string param) { }

	private void OnGameCenterLoadLeaderboardComplete(string param) { }

	private void OnGameCenterLoadPhotoComplete(string param) { }

	private void OnGameCenterLoadPlayersComplete(string param) { }

	private void OnGameCenterRequestComplete(string param) { }

	private void OnGameCenterViewDismissed(string param) { }

	public static void remove_authenticationEvent(AuthenticateHandler value) { }

	public static void ReportAchievement(string identifier, float percentComplete, bool showsCompletionBanner, RequestCompleteHandler completionHandler) { }

	public static void ReportAchievement(Achievement achievement, bool showsCompletionBanner, RequestCompleteHandler completionHandler) { }

	public static Coroutine ReportAchievements(GameCenterReportAchievementsRequest request) { }

	public static void ReportAchievements(Achievement[] achievements, bool showsCompletionBanner, RequestCompleteHandler completionHandler) { }

	public static Coroutine ReportScore(GameCenterReportScoreRequest request) { }

	public static void ReportScore(string category, long scoreValue, ulong scoreContext, RequestCompleteHandler completionHandler) { }

	private static IEnumerator RequestCoroutine(GameCenterRequest request, Action<RequestCompleteHandler> requestFunction) { }

	public static Coroutine ResetAchievements(GameCenterRequest request) { }

	public static void ResetAchievements(RequestCompleteHandler completionHandler) { }

	public static void ShowLoginView() { }

	public static void ShowView(ShowViewState viewState, string leaderboardCategory = null, LeaderboardTimeScope leaderboardTimeScope = 2, ViewDismissedHandler viewDismissedHandler = null) { }

	private static string UnescapeResultString(string s) { }

}

