namespace InAppPurchase;

public delegate RestorePurchaseFinishedDelegate
{

	public RestorePurchaseFinishedDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(RestoreFinishedResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(RestoreFinishedResult result) { }

}

