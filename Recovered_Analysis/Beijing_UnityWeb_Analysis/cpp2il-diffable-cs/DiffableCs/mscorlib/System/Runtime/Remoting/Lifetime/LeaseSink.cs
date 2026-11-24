namespace System.Runtime.Remoting.Lifetime;

internal class LeaseSink : IMessageSink
{
	private IMessageSink _nextSink; //Field offset: 0x8

	public LeaseSink(IMessageSink nextSink) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	private void RenewLease(IMessage msg) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

