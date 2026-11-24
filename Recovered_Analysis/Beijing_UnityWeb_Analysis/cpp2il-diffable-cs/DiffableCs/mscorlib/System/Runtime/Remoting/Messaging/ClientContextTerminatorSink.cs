namespace System.Runtime.Remoting.Messaging;

internal class ClientContextTerminatorSink : IMessageSink
{
	private Context _context; //Field offset: 0x8

	public ClientContextTerminatorSink(Context ctx) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

