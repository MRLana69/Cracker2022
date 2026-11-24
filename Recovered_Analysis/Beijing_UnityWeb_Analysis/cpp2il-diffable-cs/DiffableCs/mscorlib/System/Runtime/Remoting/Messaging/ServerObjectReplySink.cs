namespace System.Runtime.Remoting.Messaging;

internal class ServerObjectReplySink : IMessageSink
{
	private IMessageSink _replySink; //Field offset: 0x8
	private ServerIdentity _identity; //Field offset: 0xC

	public ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

