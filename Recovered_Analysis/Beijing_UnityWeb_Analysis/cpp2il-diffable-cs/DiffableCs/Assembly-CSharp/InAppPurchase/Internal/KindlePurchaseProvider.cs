namespace InAppPurchase.Internal;

public class KindlePurchaseProvider : MonoBehaviour, IPurchaseProvider
{
	private const string BRIDGE_DELEGATE_GAMEOBJECT_NAME = "KindleInAppCallback"; //Field offset: 0x0
	private const string FINISHED_TRANSACTION_ID_PREFIX = "SHOULD_CONSUME_"; //Field offset: 0x0
	private const string SEPARATOR_CHAR = ";"; //Field offset: 0x0
	private static readonly char[] SEPARATOR_FOR_STRING_SPLIT; //Field offset: 0x0
	private PurchaseDelegate _purchaseDelegate; //Field offset: 0xC
	private ItemRestoredDelegate _itemRestoredDelegate; //Field offset: 0x10
	private ItemRefundedDelegate _itemRefundedDelegate; //Field offset: 0x14
	private ProductInfoRequestDelegate _productRequestDelegate; //Field offset: 0x18
	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate; //Field offset: 0x1C
	private GameObject _callbackGameObject; //Field offset: 0x20

	public bool IsValidationServerSpecified
	{
		 get { } //Length: 716
	}

	private static KindlePurchaseProvider() { }

	public KindlePurchaseProvider() { }

	public bool CanMakePurchases() { }

	public GameObject CreateCallbackGameObject() { }

	public void FinishPurchase(string productId, string transactionId, string purchaseToken) { }

	public bool get_IsValidationServerSpecified() { }

	private void HandleDefaultCase(string productId, string transactionId, string transactionRecieptBase64, string cookie, InternalPurchaseResult internalPurchaseResult) { }

	private void HandlePurchaseEnded(string message, InternalPurchaseResult internalPurchaseResult) { }

	private void HandleRefund(string productId, string transactionId, string cookie) { }

	private void HandleRestore(string productId, string transactionId) { }

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	public void ProductPurchasedSuccessfully(string message) { }

	public void ProductPurchaseFailed(string message) { }

	public void ProductPurchaseInvalidId(string message) { }

	public void ProductRefunded(string message) { }

	public void ProductRequestFailed(string message) { }

	public void ProductRequestSuccessful(string message) { }

	public void ProductRestoredSuccessfully(string message) { }

	public void ProductRestoreFailed() { }

	public void ProductRestoreFinished() { }

	public void ProductRestoreFinishedButNothingHasBeenRestored() { }

	public void RequestProductInfo(string[] productIds) { }

	public bool RestoreNonConsumablePurchases(string[] productIds) { }

	public bool StartPurchase(string productId, string cookie) { }

	public bool StartPurchase(string productId) { }

	private bool TryParseProductInfo(string message, out ProductRequestResultInfo[] productInfo) { }

	private bool TryParsePurchaseEndedMessage(string message, out string productId, out string transactionId) { }

	private void ValidateTransaction(string productId, string transactionId, string transactionRecieptBase64, InternalPurchaseResult internalPurchaseResult) { }

}

