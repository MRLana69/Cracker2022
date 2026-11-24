namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
{
	private static object s_lock; //Field offset: 0x0

	public virtual object ChannelData
	{
		 get { } //Length: 4
	}

	public virtual string ChannelName
	{
		 get { } //Length: 6
	}

	public virtual int ChannelPriority
	{
		 get { } //Length: 43
	}

	private static CrossAppDomainChannel() { }

	public CrossAppDomainChannel() { }

	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	public virtual object get_ChannelData() { }

	public virtual string get_ChannelName() { }

	public virtual int get_ChannelPriority() { }

	internal static void RegisterCrossAppDomainChannel() { }

	public virtual void StartListening(object data) { }

}

