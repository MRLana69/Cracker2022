namespace UnityEngine.Networking;

public class NetworkClient
{
	protected enum ConnectState
	{
		None = 0,
		Resolving = 1,
		Resolved = 2,
		Connecting = 3,
		Connected = 4,
		Disconnected = 5,
		Failed = 6,
	}

	private const int k_MaxEventsPerFrame = 500; //Field offset: 0x0
	private static List<NetworkClient> s_Clients; //Field offset: 0x0
	private static bool s_IsActive; //Field offset: 0x4
	private static CRCMessage s_CRCMessage; //Field offset: 0x8
	private Type m_NetworkConnectionClass; //Field offset: 0x8
	private HostTopology m_HostTopology; //Field offset: 0xC
	private int m_HostPort; //Field offset: 0x10
	private bool m_UseSimulator; //Field offset: 0x14
	private int m_SimulatedLatency; //Field offset: 0x18
	private float m_PacketLoss; //Field offset: 0x1C
	private string m_ServerIp; //Field offset: 0x20
	private int m_ServerPort; //Field offset: 0x24
	private int m_ClientId; //Field offset: 0x28
	private int m_ClientConnectionId; //Field offset: 0x2C
	private int m_StatResetTime; //Field offset: 0x30
	private EndPoint m_RemoteEndPoint; //Field offset: 0x34
	private NetworkMessageHandlers m_MessageHandlers; //Field offset: 0x38
	protected NetworkConnection m_Connection; //Field offset: 0x3C
	private byte[] m_MsgBuffer; //Field offset: 0x40
	private NetworkReader m_MsgReader; //Field offset: 0x44
	protected ConnectState m_AsyncConnect; //Field offset: 0x48
	private string m_RequestedServerHost; //Field offset: 0x4C

	public static bool active
	{
		 get { } //Length: 89
	}

	public static List<NetworkClient> allClients
	{
		 get { } //Length: 92
	}

	public NetworkConnection connection
	{
		 get { } //Length: 6
	}

	public Dictionary<short, NetworkMessageDelegate> handlers
	{
		 get { } //Length: 6
	}

	internal int hostId
	{
		 get { } //Length: 3
	}

	public int hostPort
	{
		 get { } //Length: 6
		 set { } //Length: 29
	}

	public HostTopology hostTopology
	{
		 get { } //Length: 15
	}

	public bool isConnected
	{
		 get { } //Length: 6
	}

	public Type networkConnectionClass
	{
		 get { } //Length: 9
	}

	public int numChannels
	{
		 get { } //Length: 9
	}

	public PeerInfoMessage[] peers
	{
		 get { } //Length: 6
	}

	public string serverIp
	{
		 get { } //Length: 128
	}

	public int serverPort
	{
		 get { } //Length: 6
	}

	private static NetworkClient() { }

	public NetworkClient(NetworkConnection conn) { }

	public NetworkClient() { }

	internal static void AddClient(NetworkClient client) { }

	public bool Configure(HostTopology topology) { }

	public bool Configure(ConnectionConfig config, int maxConnections) { }

	public void Connect(EndPoint secureTunnelEndPoint) { }

	public void Connect(string serverIp, int serverPort) { }

	public void Connect(MatchInfo matchInfo) { }

	private void ConnectWithRelay(MatchInfo info) { }

	public void ConnectWithSimulator(string serverIp, int serverPort, int latency, float packetLoss) { }

	internal void ContinueConnect() { }

	public virtual void Disconnect() { }

	private void GenerateConnectError(int error) { }

	private void GenerateDataError(int error) { }

	private void GenerateDisconnectError(int error) { }

	private void GenerateError(int error) { }

	public static bool get_active() { }

	public static List<NetworkClient> get_allClients() { }

	public NetworkConnection get_connection() { }

	public Dictionary<short, NetworkMessageDelegate> get_handlers() { }

	internal int get_hostId() { }

	public int get_hostPort() { }

	public HostTopology get_hostTopology() { }

	public bool get_isConnected() { }

	public Type get_networkConnectionClass() { }

	public int get_numChannels() { }

	public PeerInfoMessage[] get_peers() { }

	public string get_serverIp() { }

	public int get_serverPort() { }

	public Dictionary<short, PacketStat> GetConnectionStats() { }

	internal static void GetHostAddressesCallback(IAsyncResult ar) { }

	public int GetRTT() { }

	public void GetStatsIn(out int numMsgs, out int numBytes) { }

	public void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond) { }

	public static Dictionary<short, PacketStat> GetTotalConnectionStats() { }

	private static bool IsValidIpV6(string address) { }

	private void OnCRC(NetworkMessage netMsg) { }

	private void PrepareForConnect() { }

	private void PrepareForConnect(bool usePlatformSpecificProtocols) { }

	public bool ReconnectToNewHost(string serverIp, int serverPort) { }

	public bool ReconnectToNewHost(EndPoint secureTunnelEndPoint) { }

	public void RegisterHandler(short msgType, NetworkMessageDelegate handler) { }

	public void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler) { }

	internal void RegisterSystemHandlers(bool localClient) { }

	internal static bool RemoveClient(NetworkClient client) { }

	public void ResetConnectionStats() { }

	public bool Send(short msgType, MessageBase msg) { }

	public bool SendByChannel(short msgType, MessageBase msg, int channelId) { }

	public bool SendBytes(byte[] data, int numBytes, int channelId) { }

	public bool SendUnreliable(short msgType, MessageBase msg) { }

	public bool SendWriter(NetworkWriter writer, int channelId) { }

	public void set_hostPort(int value) { }

	internal static void SetActive(bool state) { }

	internal void SetHandlers(NetworkConnection conn) { }

	public void SetMaxDelay(float seconds) { }

	public void SetNetworkConnectionClass() { }

	public void Shutdown() { }

	public static void ShutdownAll() { }

	public void UnregisterHandler(short msgType) { }

	internal virtual void Update() { }

	internal static void UpdateClients() { }

}

