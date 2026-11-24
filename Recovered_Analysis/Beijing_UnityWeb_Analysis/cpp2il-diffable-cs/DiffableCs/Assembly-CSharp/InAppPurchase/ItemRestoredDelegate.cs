namespace InAppPurchase;

public delegate ItemRestoredDelegate
{

	public ItemRestoredDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string productId, string transactionId, string cookie, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(string productId, string transactionId, string cookie) { }

}

