namespace System.Runtime.Remoting.Messaging;

public class RemotingSurrogateSelector : ISurrogateSelector
{
	private static Type s_cachedTypeObjRef; //Field offset: 0x0
	private static ObjRefSurrogate _objRefSurrogate; //Field offset: 0x4
	private static RemotingSurrogate _objRemotingSurrogate; //Field offset: 0x8
	private ISurrogateSelector _next; //Field offset: 0x8

	private static RemotingSurrogateSelector() { }

	public RemotingSurrogateSelector() { }

	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

}

