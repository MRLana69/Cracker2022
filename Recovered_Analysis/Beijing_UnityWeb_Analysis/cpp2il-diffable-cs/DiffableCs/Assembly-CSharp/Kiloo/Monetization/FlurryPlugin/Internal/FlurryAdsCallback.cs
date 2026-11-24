namespace Kiloo.Monetization.FlurryPlugin.Internal;

public delegate FlurryAdsCallback
{

	public FlurryAdsCallback(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(string message) { }

}

