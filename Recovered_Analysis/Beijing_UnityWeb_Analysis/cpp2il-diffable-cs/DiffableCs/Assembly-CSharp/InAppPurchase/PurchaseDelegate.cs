namespace InAppPurchase;

public delegate PurchaseDelegate
{

	public PurchaseDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string productId, string transactionId, string transactionIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(string productId, string transactionId, string transactionIdBase64, string cookie, PurchaseResult result, IPurchaseValidationResult validationResult) { }

}

