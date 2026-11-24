namespace UnityEngine.Networking;

public class NetworkTransport
{
	private static int s_PacketSize; //Field offset: 0x0
	private static bool <IsStarted>k__BackingField; //Field offset: 0x4

	public static bool IsStarted
	{
		 get { } //Length: 214
	}

	private static NetworkTransport() { }

	public static int AddHost(HostTopology topology, int port, string ip) { }

	public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port, string ip) { }

	public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port) { }

	public static int AddWebsocketHost(HostTopology topology, int port, string ip = null) { }

	public static int Connect(int hostId, string address, int port, int exeptionConnectionId, out byte error) { }

	public static void ConnectAsNetworkHost(int hostId, string address, int port, NetworkID network, SourceID source, NodeID node, out byte error) { }

	public static int ConnectEndPoint(int hostId, EndPoint xboxOneEndPoint, int exceptionConnectionId, out byte error) { }

	public static int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, out byte error) { }

	public static int ConnectWithSimulator(int hostId, string address, int port, int exeptionConnectionId, out byte error, ConnectionSimulatorConfig conf) { }

	public static bool Disconnect(int hostId, int connectionId, out byte error) { }

	public static bool DoesEndPointUsePlatformProtocols(EndPoint endPoint) { }

	public static bool get_IsStarted() { }

	public static void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error) { }

	public static void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public static void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error) { }

	public static int GetCurrentRTT(int hostId, int connectionId, out byte error) { }

	public static void Init() { }

	public static void Init(GlobalConfig config) { }

	public static NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public static NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public static NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error) { }

	public static bool RemoveHost(int hostId) { }

	public static bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error) { }

	public static void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error) { }

	public static void SetMulticastLock(bool enabled) { }

	public static void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes) { }

	public static void Shutdown() { }

	public static bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error) { }

	public static void StopBroadcastDiscovery() { }

}

