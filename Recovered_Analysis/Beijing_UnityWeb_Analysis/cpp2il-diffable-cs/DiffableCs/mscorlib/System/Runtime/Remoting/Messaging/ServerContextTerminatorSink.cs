namespace System.Runtime.Remoting.Messaging;

internal class ServerContextTerminatorSink : IMessageSink
{

	public ServerContextTerminatorSink() { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

