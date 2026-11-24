namespace System.Runtime.Remoting.Channels;

public interface IChannelSender : IChannel
{

	public IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { }

}

