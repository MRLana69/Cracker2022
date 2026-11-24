namespace ABTest;

public static class ABTestManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ABTestDataItem, string> <>9__10_0; //Field offset: 0x4
		public static Func<ABTestDataItem, ABTest> <>9__10_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <SetupTestData>b__10_0(ABTestDataItem x) { }

		internal ABTest <SetupTestData>b__10_1(ABTestDataItem y) { }

	}

	private sealed class <>c__DisplayClass13_0
	{
		public string identifier; //Field offset: 0x8

		public <>c__DisplayClass13_0() { }

		internal bool <GetDefaultPayload>b__0(ABTestDataItem x) { }

	}

	private static List<string> _tags; //Field offset: 0x0
	private static Dictionary<string, ABTest> _tests; //Field offset: 0x4
	public static Action<string, string> onRegisterDailyReport; //Field offset: 0x8
	public static Action<string, int> onTagAdded; //Field offset: 0xC
	private static bool <isInitialized>k__BackingField; //Field offset: 0x10
	private static uint _boostsScreen; //Field offset: 0x14
	private static uint _earnCoinsScreen; //Field offset: 0x18
	private static uint _storeScreen; //Field offset: 0x1C
	private static uint _quickStorePopup; //Field offset: 0x20

	public static bool isInitialized
	{
		 get { } //Length: 319
		private set { } //Length: 2
	}

	private static ABTestManager() { }

	public static void CountPages(string screenName) { }

	public static void DisableDebugPayload(string identifier) { }

	public static void EnableDebugPayload(string identifier, string value) { }

	public static bool get_isInitialized() { }

	public static string GetDebugPayload(string identifier) { }

	public static string GetDefaultPayload(string identifier) { }

	public static bool GetPayloadBool(string identifier) { }

	public static int GetPayloadInt(string identifier) { }

	public static string GetPayloadString(string identifier) { }

	public static uint GetPayloadUInt(string identifier) { }

	public static string GetTag(string identifier) { }

	public static bool HasDebugPayload(string identifier) { }

	public static void Initialize() { }

	public static bool IsActive(string identifier) { }

	private static bool IsDateToday(string previousDate) { }

	private static void LoadTags() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogErr(string msg, Object context = null) { }

	private static void LogWarn(string msg, Object context = null) { }

	private static void OnFinishedDownloadingOnlineSettings() { }

	private static void OnHasRefreshed(RefreshType refreshType) { }

	private static void RegisterDailyReport(string identifier) { }

	private static void SaveTags() { }

	public static void SendPageCountFlurry() { }

	private static void set_isInitialized(bool value) { }

	private static void SetupTestData() { }

	private static void Update() { }

	private static void Update(ABTest test) { }

}

