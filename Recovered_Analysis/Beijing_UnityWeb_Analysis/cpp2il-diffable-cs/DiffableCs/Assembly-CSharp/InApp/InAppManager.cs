namespace InApp;

public class InAppManager : MonoBehaviour, IInAppManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<BundleItem> <>9__96_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <GetBoardItemFromBundleId>b__96_0(BundleItem item) { }

	}

	private sealed class <>c__DisplayClass100_0
	{
		public string productId; //Field offset: 0x8

		public <>c__DisplayClass100_0() { }

		internal bool <PayoutInAppPurchase>b__0(string id) { }

		internal bool <PayoutInAppPurchase>b__1(string id) { }

		internal bool <PayoutInAppPurchase>b__2(string bundleInApp) { }

	}

	private sealed class <>c__DisplayClass75_0
	{
		public InAppManager <>4__this; //Field offset: 0x8
		public string productId; //Field offset: 0xC

		public <>c__DisplayClass75_0() { }

		internal void <StartPurchase>b__0(IPurchaseValidationResult purchaseValidationResult) { }

	}

	public delegate OnInitializeFinished
	{

		public OnInitializeFinished(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool success, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool success) { }

	}

	public delegate OnItemRefunded
	{

		public OnItemRefunded(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string productId, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string productId) { }

	}

	public delegate OnItemRestored
	{

		public OnItemRestored(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string productId, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string productId) { }

	}

	public delegate OnItemRestoreFinished
	{

		public OnItemRestoreFinished(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(RestoreFinishedResult result, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(RestoreFinishedResult result) { }

	}

	public delegate OnProductRequestDone
	{

		public OnProductRequestDone(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnPurchaseCanceled
	{

		public OnPurchaseCanceled(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string productId, PurchaseResult result, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string productId, PurchaseResult result) { }

	}

	public delegate OnPurchaseFailure
	{

		public OnPurchaseFailure(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string productId, PurchaseResult result, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string productId, PurchaseResult result) { }

	}

	public delegate OnPurchaseItemNotAvailable
	{

		public OnPurchaseItemNotAvailable(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string productId, PurchaseResult result, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string productId, PurchaseResult result) { }

	}

	public delegate OnPurchaseSuccess
	{

		public OnPurchaseSuccess(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string productId, bool wasRestored, IPurchaseValidationResult validationResult, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string productId, bool wasRestored, IPurchaseValidationResult validationResult) { }

	}

	public delegate OnValidatedItemRestored
	{

		public OnValidatedItemRestored(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private const string ONLINESETTINGS_IAP_VALIDATION_URL_KEY = "iap_validation_url"; //Field offset: 0x0
	private const string DEFAULT_IAP_VALIDATION_URL = "https://purchasevalidation.kiloo-games.com/"; //Field offset: 0x0
	private const string ONLINESETTINGS_IAP_VALIDATION_ENABLED = "iap_validation_enabled"; //Field offset: 0x0
	private const string ONLINESETTINGS_DISCOUNT_END_TIME_KEY = "discount_end_time"; //Field offset: 0x0
	private const double DEFAULT_DISCOUNT_END_TIME = 0; //Field offset: 0x0
	private const bool DEFAULT_IAP_VALIDATION_ENABLED = True; //Field offset: 0x0
	private const string ONLINESETTINGS_DISCOUNT_SPECIAL_SALE_WINTER_HOLIDAY_ACTIVE = "winter_holiday_sale_active"; //Field offset: 0x0
	private const string ONLINESETTINGS_DISCOUNT_SPECIAL_SALE_NEW_YEAR_ACTIVE = "new_year_sale_active"; //Field offset: 0x0
	private const bool DEFAULT_DISCOUNT_SPECIAL_SALE_ACTIVE = False; //Field offset: 0x0
	private static readonly Dictionary<string, int> _debugDiscount; //Field offset: 0x0
	private const string GAME_OBJECT_NAME = "InAppManager"; //Field offset: 0x0
	private static OnInitializeFinished onInitializeFinished; //Field offset: 0x4
	private static InAppManager _instance; //Field offset: 0x8
	private static PurchaseHandler _purchaseHandler; //Field offset: 0xC
	private static bool _isRestoredManually; //Field offset: 0x10
	private static bool _hasSuccessfullyInitialized; //Field offset: 0x11
	private static bool _applicationIsQuiting; //Field offset: 0x12
	private static readonly int[] SEGMENT_78S9H5S6D78; //Field offset: 0x14
	private static readonly int[] SEGMENT_8865FHJ76FG; //Field offset: 0x18
	private static readonly int[] SEGMENT_8907SDFGF56; //Field offset: 0x1C
	private static readonly int[] SEGMENT_0A8ASDF7EWF; //Field offset: 0x20
	private static readonly int[] SEGMENT_5S678DF5G6S; //Field offset: 0x24
	private OnProductRequestDone onProductRequestDone; //Field offset: 0xC
	private OnPurchaseSuccess onPurchaseSuccess; //Field offset: 0x10
	private OnPurchaseFailure onPurchaseFailure; //Field offset: 0x14
	private OnPurchaseCanceled onPurchaseCanceled; //Field offset: 0x18
	private OnPurchaseItemNotAvailable onPurchaseItemNotAvailable; //Field offset: 0x1C
	private OnItemRestored onItemRestored; //Field offset: 0x20
	private OnValidatedItemRestored onValidatedItemRestored; //Field offset: 0x24
	private OnItemRefunded onItemRefunded; //Field offset: 0x28
	private OnItemRestoreFinished onItemRestoreFinished; //Field offset: 0x2C
	private string _itemRequested; //Field offset: 0x30
	private string _inAppPurchaseKey; //Field offset: 0x34
	private bool _productRequestSucceeded; //Field offset: 0x38
	private InAppManagerPopupData _popupData; //Field offset: 0x3C
	public AudioClip purchaseSuccessSound; //Field offset: 0x40
	private IPurchaseValidationServer _purchaseValidationServer; //Field offset: 0x44
	private IPurchaseValidationServer _simulatedPurchaseValidationServer; //Field offset: 0x48
	private bool _isQueryingProductInfo; //Field offset: 0x4C

	public static event OnInitializeFinished onInitializeFinished
	{
		 add { } //Length: 167
		 remove { } //Length: 209
	}

	public event OnItemRefunded onItemRefunded
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnItemRestored onItemRestored
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnItemRestoreFinished onItemRestoreFinished
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnProductRequestDone onProductRequestDone
	{
		 add { } //Length: 59
		 remove { } //Length: 111
	}

	public event OnPurchaseCanceled onPurchaseCanceled
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnPurchaseFailure onPurchaseFailure
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnPurchaseItemNotAvailable onPurchaseItemNotAvailable
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnPurchaseSuccess onPurchaseSuccess
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event OnValidatedItemRestored onValidatedItemRestored
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static InAppManager instance
	{
		 get { } //Length: 196
	}

	public static bool IsAnyCurrencyDiscountActive
	{
		 get { } //Length: 315
	}

	public static bool IsAnyDiscountAvailable
	{
		 get { } //Length: 1397
	}

	public static bool IsDoubleCoinsDiscountActive
	{
		 get { } //Length: 291
	}

	public static bool isInitialized
	{
		 get { } //Length: 619
	}

	public static bool IsNewYearSpecialSaleActive
	{
		 get { } //Length: 208
	}

	public static bool IsSpecialSaleActive
	{
		 get { } //Length: 380
	}

	public static bool IsWinterHolidaySpecialSaleActive
	{
		 get { } //Length: 125
	}

	public string itemRequested
	{
		 get { } //Length: 54
	}

	private static InAppManager() { }

	private InAppManager() { }

	public static void add_onInitializeFinished(OnInitializeFinished value) { }

	public void add_onItemRefunded(OnItemRefunded value) { }

	public void add_onItemRestored(OnItemRestored value) { }

	public void add_onItemRestoreFinished(OnItemRestoreFinished value) { }

	public void add_onProductRequestDone(OnProductRequestDone value) { }

	public void add_onPurchaseCanceled(OnPurchaseCanceled value) { }

	public void add_onPurchaseFailure(OnPurchaseFailure value) { }

	public void add_onPurchaseItemNotAvailable(OnPurchaseItemNotAvailable value) { }

	public void add_onPurchaseSuccess(OnPurchaseSuccess value) { }

	public void add_onValidatedItemRestored(OnValidatedItemRestored value) { }

	private void AddSegment(StringBuilder sb, int[] section) { }

	private void Awake() { }

	public void BuyExpiredLimitedBoard(string inappId, PurchaseHandler sender) { }

	public void BuyExpiredLimitedCharacter(string inappId, string characterName, PurchaseHandler sender) { }

	public void CheckedItemRestoredCallback(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult) { }

	public void DeletePopupData() { }

	private void DeliverBundle(string bundleId, bool unlockedByRestore) { }

	public static InAppManager get_instance() { }

	public static bool get_IsAnyCurrencyDiscountActive() { }

	public static bool get_IsAnyDiscountAvailable() { }

	public static bool get_IsDoubleCoinsDiscountActive() { }

	public static bool get_isInitialized() { }

	public static bool get_IsNewYearSpecialSaleActive() { }

	public static bool get_IsSpecialSaleActive() { }

	public static bool get_IsWinterHolidaySpecialSaleActive() { }

	public string get_itemRequested() { }

	public static Dictionary<string, InAppItemModel> GetActiveInAppOffers() { }

	private BundleItem GetBoardItemFromBundleId(string bundleId) { }

	private string GetContactingStoreOverlayText() { }

	public static double GetDiscountEndTime() { }

	public static int GetDiscountValue(string onlineSettingsId, int defaultValue) { }

	public string getInAppAPIKey() { }

	public int GetItemPayoutAmount(string productId, string onlineSettingsDiscountId = null) { }

	public InAppManagerPopupData GetPopupData() { }

	public static bool HasTransactionHistoryItemId(string itemId) { }

	public static void Init() { }

	public void InitFinishedCallback(bool success) { }

	private void InvokeRestoreEvents(string productId) { }

	private bool IsBoardBundleUnlocked(string bundleId) { }

	private static bool IsDiscountActive(string onlineSettingsId) { }

	public IsIAPConsumableValue IsProductConsumable(string productID) { }

	public static bool IsTransactionInHistory(string orderId) { }

	public void ItemRefundedCallback(string productid, string transactionid, string cookie, IPurchaseValidationResult validationResult) { }

	public void ItemRestoredCallback(string productId, string transactionId, string cookie) { }

	private void LimitedBoardPurchaseSuccesful(string itemId, bool unlockedByRestore) { }

	private void LimitedCharacterPurchaseSuccesful(string itemId, bool unlockedByRestore) { }

	public static void Log(string msg, Object context = null) { }

	public static void LogError(string msg, Object context = null) { }

	public static void LogWarning(string msg, Object context = null) { }

	public void NativePurchaseErrorForReviveWithKeys() { }

	public void NativePurchaseFail(string message) { }

	public void NativePurchaseFinished(bool success) { }

	public void NativePurchaseInappPack(string message) { }

	private void OnApplicationQuit() { }

	private void PayoutInAppPurchase(string productId) { }

	private void PlayPurchaseSucessSound() { }

	public static void PrintAllInappHistory() { }

	public void ProductInfoRequestCallback(bool success, ProductRequestResultInfo[] productInfo) { }

	public bool ProductRequestSucceeded() { }

	private void PurchaseCanceled(string productId) { }

	private void PurchaseFailed(string productId) { }

	private void PurchaseItemUnavailable(string productId) { }

	public void PurchaseRequestCallback(string productId, string transactionId, string transactionIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult) { }

	private void PurchaseRestored(string productId) { }

	public static void remove_onInitializeFinished(OnInitializeFinished value) { }

	public void remove_onItemRefunded(OnItemRefunded value) { }

	public void remove_onItemRestored(OnItemRestored value) { }

	public void remove_onItemRestoreFinished(OnItemRestoreFinished value) { }

	public void remove_onProductRequestDone(OnProductRequestDone value) { }

	public void remove_onPurchaseCanceled(OnPurchaseCanceled value) { }

	public void remove_onPurchaseFailure(OnPurchaseFailure value) { }

	public void remove_onPurchaseItemNotAvailable(OnPurchaseItemNotAvailable value) { }

	public void remove_onPurchaseSuccess(OnPurchaseSuccess value) { }

	public void remove_onValidatedItemRestored(OnValidatedItemRestored value) { }

	public static bool RemoveTransactionFromHistory(string orderId) { }

	public void RequestIAPInfo() { }

	public bool RestoreNonConsumablePurchases(string[] productIds, bool calledManually = true) { }

	public void RestoreRequestFinishedCallback(RestoreFinishedResult result) { }

	public void SetPopupData(InAppManagerPopupData popupData) { }

	private void ShowSlideInForBoard(BoardId boardId) { }

	public void StartPurchase(string productId) { }

	public void SuggestInAppPopup(int cost, string senderName, ItemType type) { }

	private void TriggerFailForPurchaseHandler() { }

	public static bool TryAddTransactionToHistory(string orderId, string itemId) { }

	private void UpdateLastPurchasedBundle() { }

}

