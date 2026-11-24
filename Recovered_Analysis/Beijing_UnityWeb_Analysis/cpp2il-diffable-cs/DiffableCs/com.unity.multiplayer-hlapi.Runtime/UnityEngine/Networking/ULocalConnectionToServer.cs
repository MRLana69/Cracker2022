namespace UnityEngine.Networking;

internal class ULocalConnectionToServer : NetworkConnection
{
	private NetworkServer m_LocalServer; //Field offset: 0x50

	public ULocalConnectionToServer(NetworkServer localServer) { }

	public override void GetStatsIn(out int numMsgs, out int numBytes) { }

	public override void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond) { }

	public override bool Send(short msgType, MessageBase msg) { }

	public override bool SendByChannel(short msgType, MessageBase msg, int channelId) { }

	public override bool SendBytes(byte[] bytes, int numBytes, int channelId) { }

	public override bool SendUnreliable(short msgType, MessageBase msg) { }

	public override bool SendWriter(NetworkWriter writer, int channelId) { }

}

