namespace System.Runtime.Remoting.Messaging;

internal class EnvoyTerminatorSink : IMessageSink
{
	public static EnvoyTerminatorSink Instance; //Field offset: 0x0

	private static EnvoyTerminatorSink() { }

	public EnvoyTerminatorSink() { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

}

