namespace System.Runtime.Remoting;

internal class SingletonIdentity : ServerIdentity
{

	public SingletonIdentity(string objectUri, Context context, Type objectType) { }

	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public MarshalByRefObject GetServerObject() { }

	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

}

