namespace InAppPurchase;

public delegate ItemRefundedDelegate
{

	public ItemRefundedDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(string productId, string transactionId, string cookie, IPurchaseValidationResult validationResult) { }

}

