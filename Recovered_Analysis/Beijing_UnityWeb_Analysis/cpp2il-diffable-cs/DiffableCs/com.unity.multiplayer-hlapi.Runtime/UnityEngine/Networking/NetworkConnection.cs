namespace UnityEngine.Networking;

public class NetworkConnection : IDisposable
{
	public class PacketStat
	{
		public short msgType; //Field offset: 0x8
		public int count; //Field offset: 0xC
		public int bytes; //Field offset: 0x10

		public PacketStat() { }

		public PacketStat(PacketStat s) { }

		public override string ToString() { }

	}

	private const int k_MaxMessageLogSize = 150; //Field offset: 0x0
	private ChannelBuffer[] m_Channels; //Field offset: 0x8
	private List<PlayerController> m_PlayerControllers; //Field offset: 0xC
	private NetworkMessage m_NetMsg; //Field offset: 0x10
	private HashSet<NetworkIdentity> m_VisList; //Field offset: 0x14
	private NetworkWriter m_Writer; //Field offset: 0x18
	private Dictionary<short, NetworkMessageDelegate> m_MessageHandlersDict; //Field offset: 0x1C
	private NetworkMessageHandlers m_MessageHandlers; //Field offset: 0x20
	private HashSet<NetworkInstanceId> m_ClientOwnedObjects; //Field offset: 0x24
	private NetworkMessage m_MessageInfo; //Field offset: 0x28
	private NetworkError error; //Field offset: 0x2C
	public int hostId; //Field offset: 0x30
	public int connectionId; //Field offset: 0x34
	public bool isReady; //Field offset: 0x38
	public string address; //Field offset: 0x3C
	public float lastMessageTime; //Field offset: 0x40
	public bool logNetworkMessages; //Field offset: 0x44
	private Dictionary<short, PacketStat> m_PacketStats; //Field offset: 0x48
	private bool m_Disposed; //Field offset: 0x4C

	public HashSet<NetworkInstanceId> clientOwnedObjects
	{
		 get { } //Length: 6
	}

	public bool isConnected
	{
		 get { } //Length: 6
	}

	public NetworkError lastError
	{
		 get { } //Length: 9
		internal set { } //Length: 14
	}

	internal Dictionary<short, PacketStat> packetStats
	{
		 get { } //Length: 6
	}

	public List<PlayerController> playerControllers
	{
		 get { } //Length: 6
	}

	internal HashSet<NetworkIdentity> visList
	{
		 get { } //Length: 103
	}

	public NetworkConnection() { }

	internal void AddOwnedObject(NetworkIdentity obj) { }

	internal void AddToVisList(NetworkIdentity uv) { }

	private bool CheckChannel(int channelId) { }

	public bool CheckHandler(short msgType) { }

	public void Disconnect() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public void FlushChannels() { }

	public HashSet<NetworkInstanceId> get_clientOwnedObjects() { }

	public bool get_isConnected() { }

	public NetworkError get_lastError() { }

	internal Dictionary<short, PacketStat> get_packetStats() { }

	public List<PlayerController> get_playerControllers() { }

	internal HashSet<NetworkIdentity> get_visList() { }

	internal bool GetPlayerController(short playerControllerId, out PlayerController playerController) { }

	public virtual void GetStatsIn(out int numMsgs, out int numBytes) { }

	public virtual void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond) { }

	protected void HandleBytes(byte[] buffer, int receivedSize, int channelId) { }

	internal void HandleFragment(NetworkReader reader, int channelId) { }

	protected void HandleReader(NetworkReader reader, int receivedSize, int channelId) { }

	public virtual void Initialize(string networkAddress, int networkHostId, int networkConnectionId, HostTopology hostTopology) { }

	public bool InvokeHandler(short msgType, NetworkReader reader, int channelId) { }

	public bool InvokeHandler(NetworkMessage netMsg) { }

	public bool InvokeHandlerNoData(short msgType) { }

	private static bool IsReliableQoS(QosType qos) { }

	private static bool IsSequencedQoS(QosType qos) { }

	private void LogSend(byte[] bytes) { }

	internal static void OnFragment(NetworkMessage netMsg) { }

	public void RegisterHandler(short msgType, NetworkMessageDelegate handler) { }

	internal void RemoveFromVisList(NetworkIdentity uv, bool isDestroyed) { }

	internal void RemoveObservers() { }

	internal void RemoveOwnedObject(NetworkIdentity obj) { }

	internal void RemovePlayerController(short playerControllerId) { }

	public void ResetStats() { }

	public virtual bool Send(short msgType, MessageBase msg) { }

	public virtual bool SendByChannel(short msgType, MessageBase msg, int channelId) { }

	public virtual bool SendBytes(byte[] bytes, int numBytes, int channelId) { }

	public virtual bool SendUnreliable(short msgType, MessageBase msg) { }

	public virtual bool SendWriter(NetworkWriter writer, int channelId) { }

	internal void set_lastError(NetworkError value) { }

	public bool SetChannelOption(int channelId, ChannelOption option, int value) { }

	internal void SetHandlers(NetworkMessageHandlers handlers) { }

	public void SetMaxDelay(float seconds) { }

	internal void SetPlayerController(PlayerController player) { }

	public override string ToString() { }

	public virtual void TransportReceive(byte[] bytes, int numBytes, int channelId) { }

	public virtual void TransportRecieve(byte[] bytes, int numBytes, int channelId) { }

	public virtual bool TransportSend(byte[] bytes, int numBytes, int channelId, out byte error) { }

	public void UnregisterHandler(short msgType) { }

}

