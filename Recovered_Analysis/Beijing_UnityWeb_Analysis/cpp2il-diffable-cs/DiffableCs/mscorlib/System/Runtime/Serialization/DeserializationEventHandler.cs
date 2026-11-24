namespace System.Runtime.Serialization;

internal delegate DeserializationEventHandler
{

	public DeserializationEventHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(object sender, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(object sender) { }

}

