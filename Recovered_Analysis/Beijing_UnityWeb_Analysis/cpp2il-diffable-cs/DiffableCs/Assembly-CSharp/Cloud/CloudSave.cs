namespace Cloud;

public static class CloudSave
{
	private sealed class <>c__DisplayClass44_0
	{
		public DateTime startTime; //Field offset: 0x8

		public <>c__DisplayClass44_0() { }

		internal void <CommitAsync>b__0(bool success) { }

	}

	private sealed class <>c__DisplayClass47_0
	{
		public bool wait; //Field offset: 0x8
		public DateTime startTime; //Field offset: 0x10
		public bool hadConflict; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal void <Update_Routine>b__0(ICloudConflict[] conflicts) { }

		internal void <Update_Routine>b__1(bool updateSuccess) { }

	}

	private sealed class <CommitAsync>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 362
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CommitAsync>d__44(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoginAsync>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Action onUpdateFinished; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 221
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoginAsync>d__39(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Update_Routine>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		private <>c__DisplayClass47_0 <>8__1; //Field offset: 0x10
		public Action onFinished; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 656
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Update_Routine>d__47(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const string DEFAULT_CLOUD_BASE_URL = "https://cloudsave2-subwaysurfers.kiloo-games.com/"; //Field offset: 0x0
	private const string ONLINESETTINGS_CLOUD_URL_KEY = "cloudsave_url"; //Field offset: 0x0
	private const int DEFAULT_DATA_VERSION = 0; //Field offset: 0x0
	private const bool USE_SIMULATED_SERVER_IN_EDITOR = True; //Field offset: 0x0
	private const string CLOUD_SAVE_AVAILABLE_KEY = "cloudsave_enabled"; //Field offset: 0x0
	private const bool CLOUD_SAVE_AVAILABLE_DEFAULT = False; //Field offset: 0x0
	private static Action stateChanged; //Field offset: 0x0
	private static int _dataVersion; //Field offset: 0x4
	private static CloudSaveState _state; //Field offset: 0x8
	private static CloudSaveErrorState _errorState; //Field offset: 0xC
	private static ICloudServer _cloudServer; //Field offset: 0x10
	private static CloudWorkingCopy _workingCopy; //Field offset: 0x14
	private static CloudSaveConflictResolver _conflictResolver; //Field offset: 0x18
	private static KilooSerializer _serializer; //Field offset: 0x1C
	private static IFileSaver _fileSaver; //Field offset: 0x20
	private static IInstallationInfo _installationInfo; //Field offset: 0x24
	private static bool _allowReinitAfterMismatch; //Field offset: 0x28
	private static bool _mayQueueCelebration; //Field offset: 0x29
	private static bool <isAvailable>k__BackingField; //Field offset: 0x2A

	public static event Action stateChanged
	{
		 add { } //Length: 2
		 remove { } //Length: 206
	}

	public static CloudSaveConflictResolver conflictResolver
	{
		 get { } //Length: 89
	}

	public static CloudSaveErrorState errorState
	{
		 get { } //Length: 89
		private set { } //Length: 171
	}

	public static bool isAvailable
	{
		 get { } //Length: 187
		private set { } //Length: 91
	}

	private static bool isInitialized
	{
		 get { } //Length: 89
	}

	public static CloudSaveState state
	{
		 get { } //Length: 191
		private set { } //Length: 206
	}

	public static string userName
	{
		 get { } //Length: 3
	}

	public static bool useSimulatedServer
	{
		 get { } //Length: 92
	}

	private static CloudSave() { }

	public static void add_stateChanged(Action value) { }

	public static void Commit() { }

	private static IEnumerator CommitAsync() { }

	private static ICloudServer CreateServer(string url, IKilooAuth kilooAuth, IBsonSerializer serializer) { }

	public static ICloudUserData DEBUG_MakeUserData() { }

	public static void Disable() { }

	public static void EnableAndInitIfNeeded() { }

	public static CloudSaveConflictResolver get_conflictResolver() { }

	public static CloudSaveErrorState get_errorState() { }

	public static bool get_isAvailable() { }

	private static bool get_isInitialized() { }

	public static CloudSaveState get_state() { }

	public static string get_userName() { }

	public static bool get_useSimulatedServer() { }

	private static int GetDataVersion() { }

	private static string GetFilePath() { }

	private static string GetRootDir() { }

	private static void HandleAccountMismatch() { }

	public static void Init() { }

	private static void Log(string msg, Object obj = null) { }

	private static void LogError(string msg, Object obj = null) { }

	public static IEnumerator LoginAsync(Action onUpdateFinished = null) { }

	public static ICloudUserData MakeUserData() { }

	private static void OnItemUpdated(object sender, CloudItemUpdatedArgs cloudItemUpdatedArgs) { }

	private static void OnProccessUnsuccessful() { }

	private static bool PrepareCommit() { }

	private static string PutInSecondBucket(TimeSpan span) { }

	private static void RefreshState(bool calledFromInit = false) { }

	public static void remove_stateChanged(Action value) { }

	private static void set_errorState(CloudSaveErrorState value) { }

	private static void set_isAvailable(bool value) { }

	private static void set_state(CloudSaveState value) { }

	private static void SetStateOkAndQueueCelebrationIfNeeded() { }

	private static void SetUserDataIfChanged(CloudWorkingCopy workingCopy, string file, ICloudUserData userData) { }

	private static IEnumerator Update_Routine(Action onFinished = null) { }

	public static Coroutine UpdateAsync(Action onFinished = null) { }

}

