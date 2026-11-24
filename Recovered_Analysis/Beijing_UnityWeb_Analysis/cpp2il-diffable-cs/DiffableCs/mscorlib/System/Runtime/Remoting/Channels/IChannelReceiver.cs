namespace System.Runtime.Remoting.Channels;

public interface IChannelReceiver : IChannel
{

	public object ChannelData
	{
		 get { } //Length: 0
	}

	public object get_ChannelData() { }

	public void StartListening(object data) { }

}

