namespace UnityEngine.Networking;

public class NetworkServerSimple
{
	private bool m_Initialized; //Field offset: 0x8
	private int m_ListenPort; //Field offset: 0xC
	private int m_ServerHostId; //Field offset: 0x10
	private int m_RelaySlotId; //Field offset: 0x14
	private bool m_UseWebSockets; //Field offset: 0x18
	private byte[] m_MsgBuffer; //Field offset: 0x1C
	private NetworkReader m_MsgReader; //Field offset: 0x20
	private Type m_NetworkConnectionClass; //Field offset: 0x24
	private HostTopology m_HostTopology; //Field offset: 0x28
	private List<NetworkConnection> m_Connections; //Field offset: 0x2C
	private ReadOnlyCollection<NetworkConnection> m_ConnectionsReadOnly; //Field offset: 0x30
	private NetworkMessageHandlers m_MessageHandlers; //Field offset: 0x34

	public ReadOnlyCollection<NetworkConnection> connections
	{
		 get { } //Length: 9
	}

	public Dictionary<short, NetworkMessageDelegate> handlers
	{
		 get { } //Length: 6
	}

	public HostTopology hostTopology
	{
		 get { } //Length: 6
	}

	public int listenPort
	{
		 get { } //Length: 88
		 set { } //Length: 2
	}

	public byte[] messageBuffer
	{
		 get { } //Length: 9
	}

	public NetworkReader messageReader
	{
		 get { } //Length: 6
	}

	public Type networkConnectionClass
	{
		 get { } //Length: 6
	}

	public int serverHostId
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool useWebSockets
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public NetworkServerSimple() { }

	public void ClearHandlers() { }

	public bool Configure(HostTopology topology) { }

	public bool Configure(ConnectionConfig config, int maxConnections) { }

	public void Disconnect(int connectionId) { }

	public void DisconnectAllConnections() { }

	public NetworkConnection FindConnection(int connectionId) { }

	public ReadOnlyCollection<NetworkConnection> get_connections() { }

	public Dictionary<short, NetworkMessageDelegate> get_handlers() { }

	public HostTopology get_hostTopology() { }

	public int get_listenPort() { }

	public byte[] get_messageBuffer() { }

	public NetworkReader get_messageReader() { }

	public Type get_networkConnectionClass() { }

	public int get_serverHostId() { }

	public bool get_useWebSockets() { }

	private void HandleConnect(int connectionId, byte error) { }

	private void HandleData(int connectionId, int channelId, int receivedSize, byte error) { }

	private void HandleDisconnect(int connectionId, byte error) { }

	public virtual void Initialize() { }

	public bool Listen(string ipAddress, int serverListenPort) { }

	public bool Listen(int serverListenPort) { }

	public bool Listen(int serverListenPort, HostTopology topology) { }

	public void ListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId) { }

	public virtual void OnConnected(NetworkConnection conn) { }

	public virtual void OnConnectError(int connectionId, byte error) { }

	public virtual void OnData(NetworkConnection conn, int receivedSize, int channelId) { }

	public virtual void OnDataError(NetworkConnection conn, byte error) { }

	public virtual void OnDisconnected(NetworkConnection conn) { }

	public virtual void OnDisconnectError(NetworkConnection conn, byte error) { }

	public void RegisterHandler(short msgType, NetworkMessageDelegate handler) { }

	internal void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler) { }

	public bool RemoveConnectionAtIndex(int connectionId) { }

	public void SendBytesTo(int connectionId, byte[] bytes, int numBytes, int channelId) { }

	public void SendWriterTo(int connectionId, NetworkWriter writer, int channelId) { }

	public void set_listenPort(int value) { }

	public void set_serverHostId(int value) { }

	public void set_useWebSockets(bool value) { }

	public bool SetConnectionAtIndex(NetworkConnection conn) { }

	public void SetNetworkConnectionClass() { }

	public void Stop() { }

	public void UnregisterHandler(short msgType) { }

	public void Update() { }

	public void UpdateConnections() { }

}

