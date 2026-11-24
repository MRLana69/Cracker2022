namespace UnityEngine.Networking;

public sealed class NetworkServer
{
	private class ServerSimpleWrapper : NetworkServerSimple
	{
		private NetworkServer m_Server; //Field offset: 0x38

		public ServerSimpleWrapper(NetworkServer server) { }

		public override void OnConnected(NetworkConnection conn) { }

		public override void OnConnectError(int connectionId, byte error) { }

		public override void OnData(NetworkConnection conn, int receivedSize, int channelId) { }

		public override void OnDataError(NetworkConnection conn, byte error) { }

		public override void OnDisconnected(NetworkConnection conn) { }

		public override void OnDisconnectError(NetworkConnection conn, byte error) { }

	}

	private static bool s_Active; //Field offset: 0x0
	private const int k_RemoveListInterval = 100; //Field offset: 0x0
	private static NetworkServer s_Instance; //Field offset: 0x4
	private static object s_Sync; //Field offset: 0x8
	private static bool m_DontListen; //Field offset: 0xC
	internal static ushort maxPacketSize; //Field offset: 0xE
	private static RemovePlayerMessage s_RemovePlayerMessage; //Field offset: 0x10
	private bool m_LocalClientActive; //Field offset: 0x8
	private List<NetworkConnection> m_LocalConnectionsFakeList; //Field offset: 0xC
	private ULocalConnectionToClient m_LocalConnection; //Field offset: 0x10
	private NetworkScene m_NetworkScene; //Field offset: 0x14
	private HashSet<int> m_ExternalConnections; //Field offset: 0x18
	private ServerSimpleWrapper m_SimpleServerSimple; //Field offset: 0x1C
	private float m_MaxDelay; //Field offset: 0x20
	private HashSet<NetworkInstanceId> m_RemoveList; //Field offset: 0x24
	private int m_RemoveListCount; //Field offset: 0x28

	public static bool active
	{
		 get { } //Length: 795
	}

	public static ReadOnlyCollection<NetworkConnection> connections
	{
		 get { } //Length: 83
	}

	public static bool dontListen
	{
		 get { } //Length: 3
		 set { } //Length: 2
	}

	public static Dictionary<short, NetworkMessageDelegate> handlers
	{
		 get { } //Length: 83
	}

	public static HostTopology hostTopology
	{
		 get { } //Length: 86
	}

	internal static NetworkServer instance
	{
		 get { } //Length: 86
	}

	public static int listenPort
	{
		 get { } //Length: 80
	}

	public static bool localClientActive
	{
		 get { } //Length: 92
	}

	public static List<NetworkConnection> localConnections
	{
		 get { } //Length: 89
	}

	public static float maxDelay
	{
		 get { } //Length: 47
		 set { } //Length: 49
	}

	public static Type networkConnectionClass
	{
		 get { } //Length: 92
	}

	public static int numChannels
	{
		 get { } //Length: 83
	}

	public static Dictionary<NetworkInstanceId, NetworkIdentity> objects
	{
		 get { } //Length: 83
	}

	public static bool sendPeerInfo
	{
		 get { } //Length: 83
		 set { } //Length: 99
	}

	public static int serverHostId
	{
		 get { } //Length: 83
	}

	public static bool useWebSockets
	{
		 get { } //Length: 92
		 set { } //Length: 94
	}

	private static NetworkServer() { }

	private NetworkServer() { }

	internal void ActivateLocalClientScene() { }

	public static bool AddExternalConnection(NetworkConnection conn) { }

	private bool AddExternalConnectionInternal(NetworkConnection conn) { }

	internal int AddLocalClient(LocalClient localClient) { }

	public static bool AddPlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId, NetworkHash128 assetId) { }

	public static bool AddPlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId) { }

	public static NetworkClient BecomeHost(NetworkClient oldClient, int port, MatchInfo matchInfo, int oldConnectionId, PeerInfoMessage[] peers) { }

	internal NetworkClient BecomeHostInternal(NetworkClient oldClient, int port, MatchInfo matchInfo, int oldConnectionId, PeerInfoMessage[] peers) { }

	private void CheckForNullObjects() { }

	private static bool CheckForPrefab(GameObject obj) { }

	private static bool CheckPlayerControllerIdForConnection(NetworkConnection conn, short playerControllerId) { }

	public static void ClearHandlers() { }

	public static void ClearLocalObjects() { }

	public static void ClearSpawners() { }

	public static bool Configure(HostTopology topology) { }

	public static bool Configure(ConnectionConfig config, int maxConnections) { }

	public static void Destroy(GameObject obj) { }

	private static void DestroyObject(GameObject obj) { }

	private static void DestroyObject(NetworkIdentity uv, bool destroyServerObject) { }

	public static void DestroyPlayersForConnection(NetworkConnection conn) { }

	public static void DisconnectAll() { }

	public static GameObject FindLocalObject(NetworkInstanceId netId) { }

	private static void FinishPlayerForConnection(NetworkConnection conn, NetworkIdentity uv, GameObject playerGameObject) { }

	private void GenerateConnectError(int error) { }

	private void GenerateDataError(NetworkConnection conn, int error) { }

	private void GenerateDisconnectError(NetworkConnection conn, int error) { }

	private void GenerateError(NetworkConnection conn, int error) { }

	public static bool get_active() { }

	public static ReadOnlyCollection<NetworkConnection> get_connections() { }

	public static bool get_dontListen() { }

	public static Dictionary<short, NetworkMessageDelegate> get_handlers() { }

	public static HostTopology get_hostTopology() { }

	internal static NetworkServer get_instance() { }

	public static int get_listenPort() { }

	public static bool get_localClientActive() { }

	public static List<NetworkConnection> get_localConnections() { }

	public static float get_maxDelay() { }

	public static Type get_networkConnectionClass() { }

	public static int get_numChannels() { }

	public static Dictionary<NetworkInstanceId, NetworkIdentity> get_objects() { }

	public static bool get_sendPeerInfo() { }

	public static int get_serverHostId() { }

	public static bool get_useWebSockets() { }

	public static Dictionary<short, PacketStat> GetConnectionStats() { }

	private static bool GetNetworkIdentity(GameObject go, out NetworkIdentity view) { }

	public static void GetStatsIn(out int numMsgs, out int numBytes) { }

	public static void GetStatsOut(out int numMsgs, out int numBufferedMsgs, out int numBytes, out int lastBufferedPerSecond) { }

	internal static void HideForConnection(NetworkIdentity uv, NetworkConnection conn) { }

	internal bool InternalAddPlayerForConnection(NetworkConnection conn, GameObject playerGameObject, short playerControllerId) { }

	internal void InternalDisconnectAll() { }

	internal bool InternalListen(string ipAddress, int serverPort) { }

	private void InternalListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId) { }

	internal bool InternalReplacePlayerForConnection(NetworkConnection conn, GameObject playerGameObject, short playerControllerId) { }

	internal void InternalSetClientNotReady(NetworkConnection conn) { }

	private void InternalSetMaxDelay(float seconds) { }

	internal void InternalUpdate() { }

	internal bool InvokeBytes(ULocalConnectionToServer conn, byte[] buffer, int numBytes, int channelId) { }

	internal bool InvokeHandlerOnServer(ULocalConnectionToServer conn, short msgType, MessageBase msg, int channelId) { }

	public static bool Listen(string ipAddress, int serverPort) { }

	public static bool Listen(int serverPort) { }

	public static bool Listen(MatchInfo matchInfo, int listenPort) { }

	public static void ListenRelay(string relayIp, int relayPort, NetworkID netGuid, SourceID sourceId, NodeID nodeId) { }

	private static void OnClientReadyMessage(NetworkMessage netMsg) { }

	private static void OnCommandMessage(NetworkMessage netMsg) { }

	private void OnConnected(NetworkConnection conn) { }

	private void OnData(NetworkConnection conn, int receivedSize, int channelId) { }

	private void OnDisconnected(NetworkConnection conn) { }

	private static void OnRemovePlayerMessage(NetworkMessage netMsg) { }

	public static void RegisterHandler(short msgType, NetworkMessageDelegate handler) { }

	internal void RegisterMessageHandlers() { }

	public static void RemoveExternalConnection(int connectionId) { }

	private bool RemoveExternalConnectionInternal(int connectionId) { }

	internal void RemoveLocalClient(NetworkConnection localClientConnection) { }

	public static bool ReplacePlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId) { }

	public static bool ReplacePlayerForConnection(NetworkConnection conn, GameObject player, short playerControllerId, NetworkHash128 assetId) { }

	public static void Reset() { }

	public static void ResetConnectionStats() { }

	public static bool SendByChannelToAll(short msgType, MessageBase msg, int channelId) { }

	public static bool SendByChannelToReady(GameObject contextObj, short msgType, MessageBase msg, int channelId) { }

	public static void SendBytesToPlayer(GameObject player, byte[] buffer, int numBytes, int channelId) { }

	public static void SendBytesToReady(GameObject contextObj, byte[] buffer, int numBytes, int channelId) { }

	private static void SendCrc(NetworkConnection targetConnection) { }

	public void SendNetworkInfo(NetworkConnection targetConnection) { }

	internal void SendSpawnMessage(NetworkIdentity uv, NetworkConnection conn) { }

	public static bool SendToAll(short msgType, MessageBase msg) { }

	public static void SendToClient(int connectionId, short msgType, MessageBase msg) { }

	public static void SendToClientOfPlayer(GameObject player, short msgType, MessageBase msg) { }

	private static bool SendToObservers(GameObject contextObj, short msgType, MessageBase msg) { }

	public static bool SendToReady(GameObject contextObj, short msgType, MessageBase msg) { }

	public static bool SendUnreliableToAll(short msgType, MessageBase msg) { }

	public static bool SendUnreliableToReady(GameObject contextObj, short msgType, MessageBase msg) { }

	public static void SendWriterToReady(GameObject contextObj, NetworkWriter writer, int channelId) { }

	public static void set_dontListen(bool value) { }

	public static void set_maxDelay(float value) { }

	public static void set_sendPeerInfo(bool value) { }

	public static void set_useWebSockets(bool value) { }

	public static void SetAllClientsNotReady() { }

	public static void SetClientNotReady(NetworkConnection conn) { }

	public static void SetClientReady(NetworkConnection conn) { }

	internal void SetClientReadyInternal(NetworkConnection conn) { }

	internal void SetLocalObjectOnServer(NetworkInstanceId netId, GameObject obj) { }

	public static void SetNetworkConnectionClass() { }

	private bool SetupLocalPlayerForConnection(NetworkConnection conn, NetworkIdentity uv, PlayerController newPlayerController) { }

	internal static void ShowForConnection(NetworkIdentity uv, NetworkConnection conn) { }

	public static void Shutdown() { }

	public static void Spawn(GameObject obj, NetworkHash128 assetId) { }

	public static void Spawn(GameObject obj) { }

	internal void SpawnObject(GameObject obj) { }

	public static bool SpawnObjects() { }

	public static bool SpawnWithClientAuthority(GameObject obj, GameObject player) { }

	public static bool SpawnWithClientAuthority(GameObject obj, NetworkConnection conn) { }

	public static bool SpawnWithClientAuthority(GameObject obj, NetworkHash128 assetId, NetworkConnection conn) { }

	public static void UnregisterHandler(short msgType) { }

	public static void UnSpawn(GameObject obj) { }

	private static void UnSpawnObject(NetworkIdentity uv) { }

	private static void UnSpawnObject(GameObject obj) { }

	internal static void Update() { }

	private void UpdateServerObjects() { }

	private static bool ValidateSceneObject(NetworkIdentity netId) { }

	private static bool VerifyCanSpawn(GameObject obj) { }

}

