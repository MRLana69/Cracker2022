namespace UnityEngine.Networking;

internal class ULocalConnectionToClient : NetworkConnection
{
	private LocalClient m_LocalClient; //Field offset: 0x50

	public LocalClient localClient
	{
		 get { } //Length: 37
	}

	public ULocalConnectionToClient(LocalClient localClient) { }

	public LocalClient get_localClient() { }

	public override void GetStatsIn(out int numMsgs, out int numBytes) { }

	public override void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond) { }

	public override bool Send(short msgType, MessageBase msg) { }

	public override bool SendByChannel(short msgType, MessageBase msg, int channelId) { }

	public override bool SendBytes(byte[] bytes, int numBytes, int channelId) { }

	public override bool SendUnreliable(short msgType, MessageBase msg) { }

	public override bool SendWriter(NetworkWriter writer, int channelId) { }

}

