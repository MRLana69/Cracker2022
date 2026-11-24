namespace System.Runtime.Remoting.Messaging;

internal class ServerObjectTerminatorSink : IMessageSink
{
	private IMessageSink _nextSink; //Field offset: 0x8

	public ServerObjectTerminatorSink(IMessageSink nextSink) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

