namespace System.Runtime.Remoting.Proxies;

internal class RemotingProxy : RealProxy, IRemotingTypeInfo
{
	private static MethodInfo _cache_GetTypeMethod; //Field offset: 0x0
	private static MethodInfo _cache_GetHashCodeMethod; //Field offset: 0x4
	private IMessageSink _sink; //Field offset: 0x28
	private bool _hasEnvoySink; //Field offset: 0x2C
	private ConstructionCall _ctorCall; //Field offset: 0x30

	public string TypeName
	{
		 get { } //Length: 194
	}

	private static RemotingProxy() { }

	internal RemotingProxy(Type type, ClientIdentity identity) { }

	internal RemotingProxy(Type type, string activationUrl, object[] activationAttributes) { }

	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	internal void AttachIdentity(Identity identity) { }

	public bool CanCastTo(Type fromType, object o) { }

	protected override void Finalize() { }

	public string get_TypeName() { }

	public override IMessage Invoke(IMessage request) { }

}

