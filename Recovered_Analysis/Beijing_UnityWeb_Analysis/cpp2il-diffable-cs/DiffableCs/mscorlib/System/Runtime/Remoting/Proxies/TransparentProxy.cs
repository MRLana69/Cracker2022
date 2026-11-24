namespace System.Runtime.Remoting.Proxies;

internal class TransparentProxy
{
	public RealProxy _rp; //Field offset: 0x8
	private RuntimeRemoteClassHandle _class; //Field offset: 0xC
	private bool _custom_type_info; //Field offset: 0x10

	private bool IsContextBoundObject
	{
		 get { } //Length: 159
	}

	private Context TargetContext
	{
		 get { } //Length: 15
	}

	public TransparentProxy() { }

	private bool get_IsContextBoundObject() { }

	private Context get_TargetContext() { }

	internal RuntimeType GetProxyType() { }

	private bool InCurrentContext() { }

	internal object LoadRemoteFieldNew(nint classPtr, nint fieldPtr) { }

	internal void StoreRemoteField(nint classPtr, nint fieldPtr, object arg) { }

}

