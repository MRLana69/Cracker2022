namespace InAppPurchase.Internal;

public interface IPurchaseProvider
{

	public bool IsValidationServerSpecified
	{
		 get { } //Length: 0
	}

	public bool CanMakePurchases() { }

	public void FinishPurchase(string productId, string transactionId, string purchaseToken) { }

	public bool get_IsValidationServerSpecified() { }

	public void Init(IInAppManager inApManager, IPurchaseValidationServer validationServer = null) { }

	public void RequestProductInfo(string[] productIds) { }

	public bool RestoreNonConsumablePurchases(string[] productIds) { }

	public bool StartPurchase(string productId) { }

	public bool StartPurchase(string productId, string cookie) { }

}

