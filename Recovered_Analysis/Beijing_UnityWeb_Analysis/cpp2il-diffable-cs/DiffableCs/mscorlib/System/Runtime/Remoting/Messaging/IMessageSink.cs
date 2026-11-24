namespace System.Runtime.Remoting.Messaging;

public interface IMessageSink
{

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

