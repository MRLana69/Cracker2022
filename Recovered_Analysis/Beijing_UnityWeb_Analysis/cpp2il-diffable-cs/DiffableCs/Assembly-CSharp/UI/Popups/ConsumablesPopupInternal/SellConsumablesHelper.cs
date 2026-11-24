namespace UI.Popups.ConsumablesPopupInternal;

public class SellConsumablesHelper
{
	private sealed class <>c__DisplayClass15_0
	{
		public SellConsumablesHelper <>4__this; //Field offset: 0x8
		public Action OnPurchaseSuccessful; //Field offset: 0xC
		public Action OnPurchaseFailed; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal void <MakePurchase>b__0() { }

		internal void <MakePurchase>b__1() { }

		internal void <MakePurchase>b__2() { }

		internal void <MakePurchase>b__3() { }

	}

	private sealed class <>c__DisplayClass23_0
	{
		public SellConsumablesHelper <>4__this; //Field offset: 0x8
		public bool isInRun; //Field offset: 0xC
		public UpgradeType upgradeType; //Field offset: 0x10
		public Action onVideoFinished; //Field offset: 0x14

		public <>c__DisplayClass23_0() { }

		internal void <ShowVideoForConsumable>b__0() { }

	}

	private static Dictionary<UpgradeType, int> _defaultVideoRewardAmounts; //Field offset: 0x0
	private static Dictionary<UpgradeType, string> _videoRewardAmountOSKeys; //Field offset: 0x4
	public static Action<ItemType, int> OnRewardWithVideo; //Field offset: 0x8
	private int _purchaseCount; //Field offset: 0x8
	private bool _purchaseInProgress; //Field offset: 0xC
	private readonly UIScreenController _screenController; //Field offset: 0x10

	private SellableConsumable activeConsumable
	{
		 get { } //Length: 6
	}

	public static Dictionary<UpgradeType, int> defaultVideoRewardAmounts
	{
		 get { } //Length: 226
	}

	public static Dictionary<UpgradeType, string> videoRewardAmountOSKeys
	{
		 get { } //Length: 89
	}

	private static SellConsumablesHelper() { }

	public SellConsumablesHelper() { }

	public void DidHideConsumablesPopup() { }

	public void DidShowConsumablesPopup() { }

	private SellableConsumable get_activeConsumable() { }

	public static Dictionary<UpgradeType, int> get_defaultVideoRewardAmounts() { }

	public static Dictionary<UpgradeType, string> get_videoRewardAmountOSKeys() { }

	public AdLocationInfo GetAdLocationInfo(bool isInRun) { }

	public SellableConsumable GetConsumableReward(bool isInRun) { }

	public int GetConsumableRewardForVideo(bool isInRun) { }

	public UpgradeType GetConsumableUpgradeType(bool isInRun) { }

	private string GetVideoIdForConsumable(bool isInRun) { }

	public bool IsConsumableVideoCached(bool isInRun) { }

	public bool IsConsumableVideoLocationAvailable(bool isInRun) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private void LogPurchases() { }

	public void MakePurchase(bool isInRun, Action OnPurchaseSuccessful = null, Action OnPurchaseFailed = null) { }

	public void ShowVideoForConsumable(bool isInRun, Action onVideoFinished) { }

}

