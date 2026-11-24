namespace System.Runtime.Remoting.Proxies;

public class ProxyAttribute : Attribute
{

	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

}

