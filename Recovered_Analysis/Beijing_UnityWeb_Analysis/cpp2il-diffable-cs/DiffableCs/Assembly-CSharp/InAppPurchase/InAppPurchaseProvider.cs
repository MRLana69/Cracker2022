namespace InAppPurchase;

public class InAppPurchaseProvider : IPurchaseProvider, IInAppManager
{
	private static InAppPurchaseProvider _instance; //Field offset: 0x0
	private IPurchaseProvider _provider; //Field offset: 0x8
	private IAPPluginInitializationState _currentInitializationState; //Field offset: 0xC
	private IInAppManager _inAppManager; //Field offset: 0x10
	private Dictionary<string, ProductRequestResultInfo> _latestProductInfo; //Field offset: 0x14

	public static InAppPurchaseProvider instance
	{
		 get { } //Length: 122
	}

	public bool isInstanced
	{
		 get { } //Length: 10
	}

	public bool IsValidationServerSpecified
	{
		 get { } //Length: 52
	}

	public static bool IsValidationSupportedOnCurrentPlatform
	{
		 get { } //Length: 103
	}

	private InAppPurchaseProvider() { }

	public bool CanMakePurchases() { }

	public void CheckedItemRestoredCallback(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult) { }

	public void FinishPurchase(string productId, string transactionId, string purchaseToken) { }

	public static InAppPurchaseProvider get_instance() { }

	public bool get_isInstanced() { }

	public bool get_IsValidationServerSpecified() { }

	public static bool get_IsValidationSupportedOnCurrentPlatform() { }

	public string getInAppAPIKey() { }

	public ProductRequestResultInfo[] GetLatestRequestedProductInfo() { }

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer = null) { }

	public void InitFinishedCallback(bool success) { }

	public IsIAPConsumableValue IsProductConsumable(string productID) { }

	public void ItemRefundedCallback(string productid, string transactionid, string cookie, IPurchaseValidationResult validationResult) { }

	public void ItemRestoredCallback(string productId, string transactionId, string cookie) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	public void ProductInfoRequestCallback(bool success, ProductRequestResultInfo[] productInfo) { }

	public void PurchaseRequestCallback(string productId, string transactionId, string transationIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult) { }

	public void RequestProductInfo(string[] productIds) { }

	public bool RestoreNonConsumablePurchases(string[] productIds) { }

	public void RestoreRequestFinishedCallback(RestoreFinishedResult result) { }

	public bool StartPurchase(string productId, string cookie) { }

	public bool StartPurchase(string productId) { }

	public bool TryGetLatestRequestedProductInfoForProductId(string productId, out ProductRequestResultInfo productInfo) { }

}

