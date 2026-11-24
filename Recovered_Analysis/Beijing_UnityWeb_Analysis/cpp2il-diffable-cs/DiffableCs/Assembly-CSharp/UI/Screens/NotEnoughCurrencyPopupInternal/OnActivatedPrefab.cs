namespace UI.Screens.NotEnoughCurrencyPopupInternal;

public delegate OnActivatedPrefab
{

	public OnActivatedPrefab(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(GameObject activatedGo, bool wasSpawned, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(GameObject activatedGo, bool wasSpawned) { }

}

