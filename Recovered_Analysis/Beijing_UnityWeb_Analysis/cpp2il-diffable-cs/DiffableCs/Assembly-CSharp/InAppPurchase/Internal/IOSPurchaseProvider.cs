namespace InAppPurchase.Internal;

public class IOSPurchaseProvider : IPurchaseProvider
{
	private sealed class <>c__DisplayClass22_0
	{
		public IOSPurchaseProvider <>4__this; //Field offset: 0x8
		public string productId; //Field offset: 0xC
		public string transactionId; //Field offset: 0x10
		public string transactionRecieptBase64; //Field offset: 0x14
		public InternalPurchaseResult internalPurchaseResult; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <HandlePurchase>b__0(IPurchaseValidationResult validationResult) { }

	}

	private sealed class <>c__DisplayClass25_0
	{
		public CheckedItemRestoredDelegate handler; //Field offset: 0x8
		public string productId; //Field offset: 0xC
		public string transactionId; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal void <InvokeCheckedItemRestore>b__0(IPurchaseValidationResult validationResult) { }

	}

	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "IOSPurchaseBridge_callback"; //Field offset: 0x0
	private const char SEPARATOR_CHAR = '\u3B'; //Field offset: 0x0
	private static readonly char[] SEPARATOR_FOR_STRING_SPLIT; //Field offset: 0x0
	private IInAppManager _inAppManager; //Field offset: 0x8
	private PurchaseDelegate _purchaseDelegate; //Field offset: 0xC
	private ItemRestoredDelegate _itemRestoredDelegate; //Field offset: 0x10
	private CheckedItemRestoredDelegate _checkedItemRestoredDelegate; //Field offset: 0x14
	private ProductInfoRequestDelegate _productRequestDelegate; //Field offset: 0x18
	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate; //Field offset: 0x1C
	private IPurchaseValidationServer _purchaseValidationServer; //Field offset: 0x20
	private GameObject _callbackGameObject; //Field offset: 0x24

	public bool IsValidationServerSpecified
	{
		 get { } //Length: 26
	}

	private static IOSPurchaseProvider() { }

	public IOSPurchaseProvider() { }

	private string ArrayToString(string[] array) { }

	public bool CanMakePurchases() { }

	public void FinishPurchase(string productId, string transactionId, string purchaseToken) { }

	public bool get_IsValidationServerSpecified() { }

	private InternalPurchaseResult GetProperPurchaseResult(string errorCode) { }

	private void HandlePurchase(string productId, string transactionId, string transactionRecieptBase64, InternalPurchaseResult internalPurchaseResult) { }

	private void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult) { }

	private void HandleRestore(string productId, string transactionId, string transactionRecieptBase64) { }

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer) { }

	private void InvokeCheckedItemRestore(string productId, string transactionId, string transactionRecieptBase64) { }

	private void InvokeItemRestore(string productId, string transactionId) { }

	private static bool IOSPurchaseBridge_CanMakePayments() { }

	private static bool IOSPurchaseBridge_EnableDebugLogs(string enabledBoolString) { }

	private static void IOSPurchaseBridge_FinishTransaction(string productId, string transactionId) { }

	private static void IOSPurchaseBridge_Init() { }

	private static bool IOSPurchaseBridge_RestoreNonConsumablePurchases() { }

	private static void IOSPurchaseBridge_RunProductsRequest(string productIdsList) { }

	private static bool IOSPurchaseBridge_StartPurchase(string productId) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	private void ProductRequestFailed() { }

	private void ProductRequestSuccessful(string message) { }

	private void PurchaseFailed(string message) { }

	private void PurchasePurchased(string message) { }

	private void PurchaseRestored(string message) { }

	public void RequestProductInfo(string[] productIds) { }

	private void RestoreFinished(string message) { }

	public bool RestoreNonConsumablePurchases(string[] productIds) { }

	public bool StartPurchase(string productId, string cookie) { }

	public bool StartPurchase(string productId) { }

	private bool TryParseProductInfo(string message, out ProductRequestResultInfo[] productInfo) { }

	private bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId, out string transactionRecieptBase64) { }

	private void ValidateTransaction(string productId, string transactionReciptBase64, Action<IPurchaseValidationResult> completeHandler) { }

}

