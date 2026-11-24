namespace System.Runtime.Serialization;

internal delegate SerializationEventHandler
{

	public SerializationEventHandler(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(StreamingContext context, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

	public virtual void Invoke(StreamingContext context) { }

}

