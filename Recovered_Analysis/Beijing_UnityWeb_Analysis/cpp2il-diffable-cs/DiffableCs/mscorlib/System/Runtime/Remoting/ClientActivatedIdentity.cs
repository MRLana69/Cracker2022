namespace System.Runtime.Remoting;

internal class ClientActivatedIdentity : ServerIdentity
{
	private MarshalByRefObject _targetThis; //Field offset: 0x38

	public ClientActivatedIdentity(string objectUri, Type objectType) { }

	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public MarshalByRefObject GetServerObject() { }

	public override void OnLifetimeExpired() { }

	public void SetClientProxy(MarshalByRefObject obj) { }

	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

}

