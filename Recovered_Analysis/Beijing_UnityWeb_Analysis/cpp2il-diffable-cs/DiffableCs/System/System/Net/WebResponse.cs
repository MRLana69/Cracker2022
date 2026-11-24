namespace System.Net;

public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{

	protected WebResponse() { }

	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual void Close() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

