namespace UnityEngine.Networking;

internal class DefaultNetworkTransport : INetworkTransport
{

	public bool IsStarted
	{
		 get { } //Length: 55
	}

	public DefaultNetworkTransport() { }

	public int AddHost(HostTopology topology, int port, string ip) { }

	public int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port) { }

	public int AddWebsocketHost(HostTopology topology, int port, string ip) { }

	public int Connect(int hostId, string address, int port, int specialConnectionId, out byte error) { }

	public void ConnectAsNetworkHost(int hostId, string address, int port, NetworkID network, SourceID source, NodeID node, out byte error) { }

	public int ConnectEndPoint(int hostId, EndPoint endPoint, int specialConnectionId, out byte error) { }

	public int ConnectToNetworkPeer(int hostId, string address, int port, int specialConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, out byte error) { }

	public int ConnectWithSimulator(int hostId, string address, int port, int specialConnectionId, out byte error, ConnectionSimulatorConfig conf) { }

	public bool Disconnect(int hostId, int connectionId, out byte error) { }

	public bool DoesEndPointUsePlatformProtocols(EndPoint endPoint) { }

	public bool get_IsStarted() { }

	public void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error) { }

	public void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error) { }

	public int GetCurrentRTT(int hostId, int connectionId, out byte error) { }

	public void Init() { }

	public void Init(GlobalConfig config) { }

	public NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error) { }

	public bool RemoveHost(int hostId) { }

	public bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error) { }

	public void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error) { }

	public void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes) { }

	public void Shutdown() { }

	public bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error) { }

	public void StopBroadcastDiscovery() { }

}

