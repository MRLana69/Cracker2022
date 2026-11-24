namespace InAppPurchase;

public interface IInAppManager
{

	public void CheckedItemRestoredCallback(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult) { }

	public string getInAppAPIKey() { }

	public void InitFinishedCallback(bool success) { }

	public IsIAPConsumableValue IsProductConsumable(string productID) { }

	public void ItemRefundedCallback(string productid, string transactionid, string cookie, IPurchaseValidationResult validationResult) { }

	public void ItemRestoredCallback(string productId, string transactionId, string cookie) { }

	public void ProductInfoRequestCallback(bool success, ProductRequestResultInfo[] productInfo) { }

	public void PurchaseRequestCallback(string productId, string transactionId, string transactionIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult) { }

	public void RestoreRequestFinishedCallback(RestoreFinishedResult result) { }

}

