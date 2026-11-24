namespace System.Runtime.Remoting.Messaging;

internal class ObjRefSurrogate : ISerializationSurrogate
{

	public ObjRefSurrogate() { }

	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

}

