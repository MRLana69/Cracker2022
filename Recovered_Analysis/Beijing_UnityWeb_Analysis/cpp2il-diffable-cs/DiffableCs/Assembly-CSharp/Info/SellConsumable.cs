namespace Info;

public static class SellConsumable
{
	private const string ONLINESETTINGS_SELL_CONSUMABLES_DURING_RUN_KEY = "consumables_sell_during_run"; //Field offset: 0x0
	private const bool ONLINESETTINGS_SELL_CONSUMABLES_DURING_RUN_DEFAULT = True; //Field offset: 0x0
	private static SellableConsumable <activeConsumable>k__BackingField; //Field offset: 0x0
	private static Action<UpgradeType, int> completed; //Field offset: 0x4

	public static event Action<UpgradeType, int> completed
	{
		 add { } //Length: 99
		 remove { } //Length: 129
	}

	public static SellableConsumable activeConsumable
	{
		 get { } //Length: 93
		private set { } //Length: 206
	}

	public static bool allowSellConsumablesDuringRun
	{
		 get { } //Length: 104
	}

	public static void add_completed(Action<UpgradeType, int> value) { }

	public static void CompleteSelling(UpgradeType upgradeType, int amountPurchased) { }

	public static SellableConsumable get_activeConsumable() { }

	public static bool get_allowSellConsumablesDuringRun() { }

	public static void remove_completed(Action<UpgradeType, int> value) { }

	public static void Sell(SellableConsumable consumable) { }

	private static void set_activeConsumable(SellableConsumable value) { }

}

