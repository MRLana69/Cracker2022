//Type is in global namespace

public class PurchaseHandler
{
	public class SyboInGameCurrencyPurchaseEventArgs : EventArgs
	{
		public readonly long PurchaseId; //Field offset: 0x8
		public readonly string ItemTitleId; //Field offset: 0x10
		public readonly ItemType ItemType; //Field offset: 0x14
		public readonly long ItemBalanceAfter; //Field offset: 0x18
		public readonly long AmountReceived; //Field offset: 0x20
		public readonly ObtainableItemSource ItemSource; //Field offset: 0x28
		public readonly InGameCurrencyType InGameCurrencyType; //Field offset: 0x2C
		public readonly long CurrencyBalanceAfter; //Field offset: 0x30
		public readonly long Price; //Field offset: 0x38
		public readonly long InstanceId; //Field offset: 0x40

		public SyboInGameCurrencyPurchaseEventArgs(long purchaseId, string itemTitleId, ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price, long instanceId) { }

	}

	private static PurchaseHandler _instance; //Field offset: 0x0
	private Action<UpgradeType, int> onUpgradePurchase; //Field offset: 0x8
	private Action<CharacterId, int> characterPurchased; //Field offset: 0xC
	private Action onFailedToPurchaseEventItemWithInapp; //Field offset: 0x10
	private EventHandler<SyboInGameCurrencyPurchaseEventArgs> OnIngameCurrencyPurchaseCompleted; //Field offset: 0x14
	private BoardSelectButton _btnBuyItemWithInapp; //Field offset: 0x18

	public event Action<CharacterId, int> characterPurchased
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	private event Action onFailedToPurchaseEventItemWithInapp
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<SyboInGameCurrencyPurchaseEventArgs> OnIngameCurrencyPurchaseCompleted
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<UpgradeType, int> onUpgradePurchase
	{
		 add { } //Length: 37
		 remove { } //Length: 111
	}

	public static PurchaseHandler Instance
	{
		 get { } //Length: 53
	}

	public PurchaseHandler() { }

	public void add_characterPurchased(Action<CharacterId, int> value) { }

	private void add_onFailedToPurchaseEventItemWithInapp(Action value) { }

	public void add_OnIngameCurrencyPurchaseCompleted(EventHandler<SyboInGameCurrencyPurchaseEventArgs> value) { }

	public void add_onUpgradePurchase(Action<UpgradeType, int> value) { }

	private static void CheckForDebugFreePurchases(UnlockType unlockType, int price) { }

	public static PurchaseHandler get_Instance() { }

	private long GetIngameCurrencyAmount(InGameCurrencyType unlockType) { }

	private InGameCurrencyType GetIngameCurrencyTypeFromUnlockType(UnlockType unlockType) { }

	private static bool MakeHoverboardPurchase(BoardId boardId, Board boardData) { }

	private static bool MakeHoverboardThemePurchase(BoardId boardId, HoverboardTheme ht) { }

	public void OnPurchaseBoardWithInappFailed() { }

	public void OnPurchaseBoardWithInappSucceded(string inappId, BoardId boardId) { }

	public void OnPurchaseCharacterWithInappFailed() { }

	public void OnPurchaseCharacterWithInappSucceded(CharacterId characterId, string inappId) { }

	public void PurchaseCharacter(CharacterId characterId, int outfit, int priceOverride = -1) { }

	public void PurchaseHoverboard(BoardId boardId, BoardSelectButton sender) { }

	public void PurchaseHoverboardTheme(BoardId boardId, int themeIndex, BoardSelectButton sender) { }

	public void PurchaseKeysIfNeeded(int amountToSaveMe) { }

	public void PurchaseSkipMission(int missionIndex, IBuyButton sender) { }

	public void PurchaseSkipMission(int missionIndex, Action onPurchaseSuccessful, Action onPurchaseFailure) { }

	public void PurchaseUpgrade(UpgradeType type, IBuyButton sender) { }

	public void PurchaseUpgrade(UpgradeType upgradeType, Action onPurchaseSuccessful, Action onPurchaseFailure) { }

	private void RaiseSyboInGameCurrencyPurchaseEvent(string itemTitleId, ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price) { }

	private void RaiseSyboInGameCurrencyPurchaseEvent(string itemTitleId, ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price, long instanceId) { }

	public void remove_characterPurchased(Action<CharacterId, int> value) { }

	private void remove_onFailedToPurchaseEventItemWithInapp(Action value) { }

	public void remove_OnIngameCurrencyPurchaseCompleted(EventHandler<SyboInGameCurrencyPurchaseEventArgs> value) { }

	public void remove_onUpgradePurchase(Action<UpgradeType, int> value) { }

	public void ResetOnFailedToPurchaseEventItemWithInapp() { }

	public void StartPurchaseBoardWithInapp(BoardId boardId, BoardSelectButton sender) { }

	public void StartPurchaseCharacterWithInapp(CharacterId characterId) { }

	public void TriggerOnFailedToPurchaseEventItemWithInapp() { }

}

