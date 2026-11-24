namespace InAppPurchase;

public delegate ProductInfoRequestDelegate
{

	public ProductInfoRequestDelegate(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(bool success, ProductRequestResultInfo[] productInfo, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(bool success, ProductRequestResultInfo[] productInfo) { }

}

