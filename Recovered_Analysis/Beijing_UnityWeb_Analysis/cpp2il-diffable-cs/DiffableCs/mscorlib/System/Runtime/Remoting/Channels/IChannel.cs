namespace System.Runtime.Remoting.Channels;

public interface IChannel
{

	public string ChannelName
	{
		 get { } //Length: 0
	}

	public int ChannelPriority
	{
		 get { } //Length: 0
	}

	public string get_ChannelName() { }

	public int get_ChannelPriority() { }

}

