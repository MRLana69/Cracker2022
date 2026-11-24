namespace System.Runtime.Remoting.Messaging;

internal class StackBuilderSink : IMessageSink
{
	private MarshalByRefObject _target; //Field offset: 0x8
	private RealProxy _rp; //Field offset: 0xC

	public StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute) { }

	private void <AsyncProcessMessage>b__4_0(object data) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	private void CheckParameters(IMessage msg) { }

	private void ExecuteAsyncMessage(object ob) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

