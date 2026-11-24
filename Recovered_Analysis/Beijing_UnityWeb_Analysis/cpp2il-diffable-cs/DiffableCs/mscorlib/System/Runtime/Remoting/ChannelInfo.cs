namespace System.Runtime.Remoting;

internal class ChannelInfo : IChannelInfo
{
	private object[] channelData; //Field offset: 0x8

	public object[] ChannelData
	{
		 get { } //Length: 34
	}

	public ChannelInfo() { }

	public ChannelInfo(object remoteChannelData) { }

	public object[] get_ChannelData() { }

}

