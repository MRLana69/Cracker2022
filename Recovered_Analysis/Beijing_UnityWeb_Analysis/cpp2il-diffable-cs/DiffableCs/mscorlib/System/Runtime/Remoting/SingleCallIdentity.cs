namespace System.Runtime.Remoting;

internal class SingleCallIdentity : ServerIdentity
{

	public SingleCallIdentity(string objectUri, Context context, Type objectType) { }

	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

}

