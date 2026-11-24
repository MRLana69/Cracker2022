//Type is in global namespace

public static class SaveMeManager
{
	private static readonly int NUMBER_OF_RUNS_BEFORE_SAVE_ME_FUNCTIONALITY; //Field offset: 0x0
	private static int _numberOfUsedKeysInCurrentRun; //Field offset: 0x4
	private static bool _hasReviveWithAdsBeenAvailableInCurrentRun; //Field offset: 0x8
	public static bool isPurchaseMadeFromIngame; //Field offset: 0x9
	public static bool isPurchaseRunningIngame; //Field offset: 0xA
	private static bool <WatchedReviveAdInCurrentRun>k__BackingField; //Field offset: 0xB
	private static int <SaveMePopupCountInCurrentRun>k__BackingField; //Field offset: 0xC
	private static int <ReviveCountInCurrentRun>k__BackingField; //Field offset: 0x10

	public static bool IsRevivalVideoCached
	{
		 get { } //Length: 89
	}

	public static int ReviveCountInCurrentRun
	{
		 get { } //Length: 89
		private set { } //Length: 91
	}

	public static int SaveMePopupCountInCurrentRun
	{
		 get { } //Length: 92
		private set { } //Length: 94
	}

	public static bool WatchedReviveAdInCurrentRun
	{
		 get { } //Length: 309
		 set { } //Length: 19
	}

	private static SaveMeManager() { }

	public static bool get_IsRevivalVideoCached() { }

	public static int get_ReviveCountInCurrentRun() { }

	public static int get_SaveMePopupCountInCurrentRun() { }

	public static bool get_WatchedReviveAdInCurrentRun() { }

	public static int GetNumberOfKeysToSaveMe() { }

	private static void HandleOnMenuScreenShown() { }

	public static void IncrementNumberOfUsedKeys() { }

	public static void IncrementRevivalCountInCurrentRun() { }

	public static void IncrementSaveMePopupCountInCurrentRun() { }

	public static bool IsReviveWithAdsAvailable() { }

	public static bool IsSaveMePopupEnabled() { }

	public static void ResetSaveMeForNewRun() { }

	public static void SendReviveIfPurchaseSucceeded() { }

	private static void set_ReviveCountInCurrentRun(int value) { }

	private static void set_SaveMePopupCountInCurrentRun(int value) { }

	public static void set_WatchedReviveAdInCurrentRun(bool value) { }

	public static void SkipReviveIfPurchaseFailed() { }

}

