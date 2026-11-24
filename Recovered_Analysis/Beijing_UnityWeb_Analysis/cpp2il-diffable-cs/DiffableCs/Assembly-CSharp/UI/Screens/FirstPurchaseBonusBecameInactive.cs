namespace UI.Screens;

public delegate FirstPurchaseBonusBecameInactive
{

	public FirstPurchaseBonusBecameInactive(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke() { }

}

