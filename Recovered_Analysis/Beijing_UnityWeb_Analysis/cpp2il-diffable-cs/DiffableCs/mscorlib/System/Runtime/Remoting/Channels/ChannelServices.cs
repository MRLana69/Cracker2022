namespace System.Runtime.Remoting.Channels;

public sealed class ChannelServices
{
	private static ArrayList registeredChannels; //Field offset: 0x0
	private static ArrayList delayedClientChannels; //Field offset: 0x4
	private static CrossContextChannel _crossContextSink; //Field offset: 0x8
	internal static string CrossContextUrl; //Field offset: 0xC
	private static IList oldStartModeTypes; //Field offset: 0x10

	internal static CrossContextChannel CrossContextChannel
	{
		 get { } //Length: 95
	}

	private static ChannelServices() { }

	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	private static object CreateProvider(ProviderData prov) { }

	internal static CrossContextChannel get_CrossContextChannel() { }

	internal static object[] GetCurrentChannelInfo() { }

	private static bool IsLocalCall(IMessage callMsg) { }

	public static void RegisterChannel(IChannel chnl) { }

	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	internal static void RegisterChannelConfig(ChannelData channel) { }

	public static IMessage SyncDispatchMessage(IMessage msg) { }

}

