namespace System.Runtime.Remoting.Messaging;

internal class RemotingSurrogate : ISerializationSurrogate
{

	public RemotingSurrogate() { }

	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

}

