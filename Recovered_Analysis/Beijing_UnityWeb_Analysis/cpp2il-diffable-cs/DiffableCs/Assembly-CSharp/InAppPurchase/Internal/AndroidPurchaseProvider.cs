namespace InAppPurchase.Internal;

public class AndroidPurchaseProvider : IPurchaseProvider
{
	private sealed class <>c__DisplayClass41_0
	{
		public CheckedItemRestoredDelegate handler; //Field offset: 0x8
		public string productId; //Field offset: 0xC
		public string transactionId; //Field offset: 0x10
		public string cookie; //Field offset: 0x14

		public <>c__DisplayClass41_0() { }

		internal void <InvokeCheckedItemRestore>b__0(IPurchaseValidationResult validationResult) { }

	}

	private sealed class <>c__DisplayClass45_0
	{
		public AndroidPurchaseProvider <>4__this; //Field offset: 0x8
		public string productId; //Field offset: 0xC
		public string transactionId; //Field offset: 0x10
		public string receipt; //Field offset: 0x14
		public string cookie; //Field offset: 0x18
		public InternalPurchaseResult internalPurchaseResult; //Field offset: 0x1C

		public <>c__DisplayClass45_0() { }

		internal void <HandlePurchase>b__0(IPurchaseValidationResult validationResult) { }

	}

	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "AndroidPurchaseBridge_callback"; //Field offset: 0x0
	private const string FINISHED_TRANSACTION_ID_PREFIX = "SHOULD_CONSUME_"; //Field offset: 0x0
	private const string FINISHED_PURCHASE_TOKEN_PREFIX = "SHOULD_CONSUME_TOKEN_"; //Field offset: 0x0
	private const string SEPARATOR_CHAR = ";"; //Field offset: 0x0
	private static readonly char[] SEPARATOR_FOR_STRING_SPLIT; //Field offset: 0x0
	private InitDelegate _initDelegate; //Field offset: 0x8
	private PurchaseDelegate _purchaseDelegate; //Field offset: 0xC
	private ItemRestoredDelegate _itemRestoredDelegate; //Field offset: 0x10
	private CheckedItemRestoredDelegate _checkedItemRestoredDelegate; //Field offset: 0x14
	private ItemRefundedDelegate _itemRefundedDelegate; //Field offset: 0x18
	private ProductInfoRequestDelegate _productRequestDelegate; //Field offset: 0x1C
	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate; //Field offset: 0x20
	private IInAppManager _inAppManager; //Field offset: 0x24
	private IPurchaseValidationServer _purchaseValidationServer; //Field offset: 0x28
	private string _iapAPIKey; //Field offset: 0x2C
	private GameObject _callbackGameObject; //Field offset: 0x30

	public bool IsValidationServerSpecified
	{
		 get { } //Length: 54
	}

	private static AndroidPurchaseProvider() { }

	public AndroidPurchaseProvider() { }

	public bool CanMakePurchases() { }

	private void ConsumeFinished(string message) { }

	public void FinishPurchase(string productId, string transactionId, string purchaseToken) { }

	public bool get_IsValidationServerSpecified() { }

	private InternalPurchaseResult GetProperPurchaseResult(string errorCode) { }

	private void HandleCancel(string productId, string transactionId, string cookie, string receipt) { }

	private void HandleDefaultCases(InternalPurchaseResult internalPurchaseResult, string productId, string transactionId, string cookie, string receipt) { }

	private void HandlePurchase(string productId, string transactionId, string cookie, string receipt, InternalPurchaseResult internalPurchaseResult) { }

	private void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult) { }

	private void HandleRefund(string productId, string transactionId, string cookie) { }

	private void HandleRestore(string productId, string transactionId, string cookie, string receipt) { }

	private bool HasTransactionBeenMadeInGame(string productId, string transactionId) { }

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer) { }

	private void InitFailed() { }

	private void InitSuccessful() { }

	private void InvokeCheckedItemRestore(string productId, string transactionId, string cookie, string receipt) { }

	private void InvokeItemRestore(string productId, string transactionId, string cookie) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private string ProductIDsAsString(string[] productIds) { }

	private string ProductIsConsumableAsString(string[] productIds) { }

	private void ProductRequestFailed() { }

	private void ProductRequestSuccessful(string message) { }

	private void PurchaseFailed(string message) { }

	private void PurchasePurchased(string message) { }

	private void PurchaseRefunded(string message) { }

	private void PurchaseRestored(string message) { }

	public void RequestProductInfo(string[] productIds) { }

	private void RestoreFinished(string message) { }

	public bool RestoreNonConsumablePurchases(string[] productIds) { }

	public bool StartPurchase(string productId, string cookie) { }

	public bool StartPurchase(string productId) { }

	private bool TryParseProductInfo(string message, out ProductRequestResultInfo[] productInfo) { }

	private bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId, out string purchaseSignature, out string cookie, out string receipt) { }

}

