namespace System.Runtime.Remoting;

internal class ClientIdentity : Identity
{
	private WeakReference _proxyReference; //Field offset: 0x24

	public MarshalByRefObject ClientProxy
	{
		 get { } //Length: 23
		 set { } //Length: 11
	}

	public string TargetUri
	{
		 get { } //Length: 58
	}

	public ClientIdentity(string objectUri, ObjRef objRef) { }

	public override ObjRef CreateObjRef(Type requestedType) { }

	public MarshalByRefObject get_ClientProxy() { }

	public string get_TargetUri() { }

	public void set_ClientProxy(MarshalByRefObject value) { }

}

