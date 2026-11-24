namespace UnityEngine.Networking;

public class NetworkManager : MonoBehaviour
{
	private static INetworkTransport s_ActiveTransport; //Field offset: 0x0
	public static string networkSceneName; //Field offset: 0x4
	private static List<Transform> s_StartPositions; //Field offset: 0x8
	private static int s_StartPositionIndex; //Field offset: 0xC
	public static NetworkManager singleton; //Field offset: 0x10
	private static AddPlayerMessage s_AddPlayerMessage; //Field offset: 0x14
	private static RemovePlayerMessage s_RemovePlayerMessage; //Field offset: 0x18
	private static ErrorMessage s_ErrorMessage; //Field offset: 0x1C
	private static AsyncOperation s_LoadingSceneAsync; //Field offset: 0x20
	private static NetworkConnection s_ClientReadyConnection; //Field offset: 0x24
	private static string s_Address; //Field offset: 0x28
	private int m_NetworkPort; //Field offset: 0xC
	private bool m_ServerBindToIP; //Field offset: 0x10
	private string m_ServerBindAddress; //Field offset: 0x14
	private string m_NetworkAddress; //Field offset: 0x18
	private bool m_DontDestroyOnLoad; //Field offset: 0x1C
	private bool m_RunInBackground; //Field offset: 0x1D
	private bool m_ScriptCRCCheck; //Field offset: 0x1E
	private float m_MaxDelay; //Field offset: 0x20
	private FilterLevel m_LogLevel; //Field offset: 0x24
	private GameObject m_PlayerPrefab; //Field offset: 0x28
	private bool m_AutoCreatePlayer; //Field offset: 0x2C
	private PlayerSpawnMethod m_PlayerSpawnMethod; //Field offset: 0x30
	private string m_OfflineScene; //Field offset: 0x34
	private string m_OnlineScene; //Field offset: 0x38
	private List<GameObject> m_SpawnPrefabs; //Field offset: 0x3C
	private bool m_CustomConfig; //Field offset: 0x40
	private int m_MaxConnections; //Field offset: 0x44
	private ConnectionConfig m_ConnectionConfig; //Field offset: 0x48
	private GlobalConfig m_GlobalConfig; //Field offset: 0x4C
	private List<QosType> m_Channels; //Field offset: 0x50
	private bool m_UseWebSockets; //Field offset: 0x54
	private bool m_UseSimulator; //Field offset: 0x55
	private int m_SimulatedLatency; //Field offset: 0x58
	private float m_PacketLossPercentage; //Field offset: 0x5C
	private int m_MaxBufferedPackets; //Field offset: 0x60
	private bool m_AllowFragmentation; //Field offset: 0x64
	private string m_MatchHost; //Field offset: 0x68
	private int m_MatchPort; //Field offset: 0x6C
	public string matchName; //Field offset: 0x70
	public uint matchSize; //Field offset: 0x74
	private NetworkMigrationManager m_MigrationManager; //Field offset: 0x78
	private EndPoint m_EndPoint; //Field offset: 0x7C
	private bool m_ClientLoadedScene; //Field offset: 0x80
	public bool isNetworkActive; //Field offset: 0x81
	public NetworkClient client; //Field offset: 0x84
	public MatchInfo matchInfo; //Field offset: 0x88
	public NetworkMatch matchMaker; //Field offset: 0x8C
	public List<MatchInfoSnapshot> matches; //Field offset: 0x90

	public static INetworkTransport activeTransport
	{
		 get { } //Length: 47
		 set { } //Length: 86
	}

	public bool autoCreatePlayer
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public List<QosType> channels
	{
		 get { } //Length: 6
	}

	public bool clientLoadedScene
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public ConnectionConfig connectionConfig
	{
		 get { } //Length: 12
	}

	public bool customConfig
	{
		 get { } //Length: 89
		 set { } //Length: 11
	}

	public static INetworkTransport defaultTransport
	{
		 get { } //Length: 156
	}

	public bool dontDestroyOnLoad
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public GlobalConfig globalConfig
	{
		 get { } //Length: 80
	}

	public FilterLevel logLevel
	{
		 get { } //Length: 3
		 set { } //Length: 2
	}

	public string matchHost
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int matchPort
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public int maxConnections
	{
		 get { } //Length: 80
		 set { } //Length: 14
	}

	public float maxDelay
	{
		 get { } //Length: 57
		 set { } //Length: 60
	}

	public NetworkMigrationManager migrationManager
	{
		 get { } //Length: 10
	}

	public string networkAddress
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public int networkPort
	{
		 get { } //Length: 101
		 set { } //Length: 2
	}

	public int numPlayers
	{
		 get { } //Length: 6
	}

	public string offlineScene
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public string onlineScene
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public float packetLossPercentage
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public GameObject playerPrefab
	{
		 get { } //Length: 6
		 set { } //Length: 86
	}

	public PlayerSpawnMethod playerSpawnMethod
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool runInBackground
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool scriptCRCCheck
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public EndPoint secureTunnelEndpoint
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool sendPeerInfo
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string serverBindAddress
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool serverBindToIP
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int simulatedLatency
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public List<GameObject> spawnPrefabs
	{
		 get { } //Length: 6
	}

	public List<Transform> startPositions
	{
		 get { } //Length: 6
	}

	public bool useSimulator
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool useWebSockets
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	private static NetworkManager() { }

	public NetworkManager() { }

	private void Awake() { }

	private void CleanupNetworkIdentities() { }

	internal void ClientChangeScene(string newSceneName, bool forceReload) { }

	private NetworkClient ConnectLocalClient() { }

	private void FinishLoadScene() { }

	public static INetworkTransport get_activeTransport() { }

	public bool get_autoCreatePlayer() { }

	public List<QosType> get_channels() { }

	public bool get_clientLoadedScene() { }

	public ConnectionConfig get_connectionConfig() { }

	public bool get_customConfig() { }

	public static INetworkTransport get_defaultTransport() { }

	public bool get_dontDestroyOnLoad() { }

	public GlobalConfig get_globalConfig() { }

	public FilterLevel get_logLevel() { }

	public string get_matchHost() { }

	public int get_matchPort() { }

	public int get_maxConnections() { }

	public float get_maxDelay() { }

	public NetworkMigrationManager get_migrationManager() { }

	public string get_networkAddress() { }

	public int get_networkPort() { }

	public int get_numPlayers() { }

	public string get_offlineScene() { }

	public string get_onlineScene() { }

	public float get_packetLossPercentage() { }

	public GameObject get_playerPrefab() { }

	public PlayerSpawnMethod get_playerSpawnMethod() { }

	public bool get_runInBackground() { }

	public bool get_scriptCRCCheck() { }

	public EndPoint get_secureTunnelEndpoint() { }

	public bool get_sendPeerInfo() { }

	public string get_serverBindAddress() { }

	public bool get_serverBindToIP() { }

	public int get_simulatedLatency() { }

	public List<GameObject> get_spawnPrefabs() { }

	public List<Transform> get_startPositions() { }

	public bool get_useSimulator() { }

	public bool get_useWebSockets() { }

	public Transform GetStartPosition() { }

	private void InitializeSingleton() { }

	public bool IsClientConnected() { }

	public virtual void OnClientConnect(NetworkConnection conn) { }

	internal void OnClientConnectInternal(NetworkMessage netMsg) { }

	public virtual void OnClientDisconnect(NetworkConnection conn) { }

	internal void OnClientDisconnectInternal(NetworkMessage netMsg) { }

	public virtual void OnClientError(NetworkConnection conn, int errorCode) { }

	internal void OnClientErrorInternal(NetworkMessage netMsg) { }

	public virtual void OnClientNotReady(NetworkConnection conn) { }

	internal void OnClientNotReadyMessageInternal(NetworkMessage netMsg) { }

	public virtual void OnClientSceneChanged(NetworkConnection conn) { }

	internal void OnClientSceneInternal(NetworkMessage netMsg) { }

	private void OnDestroy() { }

	public virtual void OnDestroyMatch(bool success, string extendedInfo) { }

	public virtual void OnDropConnection(bool success, string extendedInfo) { }

	public virtual void OnMatchCreate(bool success, string extendedInfo, MatchInfo matchInfo) { }

	public virtual void OnMatchJoined(bool success, string extendedInfo, MatchInfo matchInfo) { }

	public virtual void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList) { }

	public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader) { }

	public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId) { }

	private void OnServerAddPlayerInternal(NetworkConnection conn, short playerControllerId) { }

	internal void OnServerAddPlayerMessageInternal(NetworkMessage netMsg) { }

	public virtual void OnServerConnect(NetworkConnection conn) { }

	internal void OnServerConnectInternal(NetworkMessage netMsg) { }

	public virtual void OnServerDisconnect(NetworkConnection conn) { }

	internal void OnServerDisconnectInternal(NetworkMessage netMsg) { }

	public virtual void OnServerError(NetworkConnection conn, int errorCode) { }

	internal void OnServerErrorInternal(NetworkMessage netMsg) { }

	public virtual void OnServerReady(NetworkConnection conn) { }

	internal void OnServerReadyMessageInternal(NetworkMessage netMsg) { }

	public virtual void OnServerRemovePlayer(NetworkConnection conn, PlayerController player) { }

	internal void OnServerRemovePlayerMessageInternal(NetworkMessage netMsg) { }

	public virtual void OnServerSceneChanged(string sceneName) { }

	public virtual void OnSetMatchAttributes(bool success, string extendedInfo) { }

	public virtual void OnStartClient(NetworkClient client) { }

	public virtual void OnStartHost() { }

	public virtual void OnStartServer() { }

	public virtual void OnStopClient() { }

	public virtual void OnStopHost() { }

	public virtual void OnStopServer() { }

	private void OnValidate() { }

	internal void RegisterClientMessages(NetworkClient client) { }

	internal void RegisterServerMessages() { }

	public static void RegisterStartPosition(Transform start) { }

	public virtual void ServerChangeScene(string newSceneName) { }

	public static void set_activeTransport(INetworkTransport value) { }

	public void set_autoCreatePlayer(bool value) { }

	public void set_clientLoadedScene(bool value) { }

	public void set_customConfig(bool value) { }

	public void set_dontDestroyOnLoad(bool value) { }

	public void set_logLevel(FilterLevel value) { }

	public void set_matchHost(string value) { }

	public void set_matchPort(int value) { }

	public void set_maxConnections(int value) { }

	public void set_maxDelay(float value) { }

	public void set_networkAddress(string value) { }

	public void set_networkPort(int value) { }

	public void set_offlineScene(string value) { }

	public void set_onlineScene(string value) { }

	public void set_packetLossPercentage(float value) { }

	public void set_playerPrefab(GameObject value) { }

	public void set_playerSpawnMethod(PlayerSpawnMethod value) { }

	public void set_runInBackground(bool value) { }

	public void set_scriptCRCCheck(bool value) { }

	public void set_secureTunnelEndpoint(EndPoint value) { }

	public void set_sendPeerInfo(bool value) { }

	public void set_serverBindAddress(string value) { }

	public void set_serverBindToIP(bool value) { }

	public void set_simulatedLatency(int value) { }

	public void set_useSimulator(bool value) { }

	public void set_useWebSockets(bool value) { }

	public void SetMatchHost(string newHost, int port, bool https) { }

	public void SetupMigrationManager(NetworkMigrationManager man) { }

	public static void Shutdown() { }

	public NetworkClient StartClient() { }

	public NetworkClient StartClient(MatchInfo info, ConnectionConfig config, int hostPort) { }

	public NetworkClient StartClient(MatchInfo matchInfo) { }

	public NetworkClient StartClient(MatchInfo info, ConnectionConfig config) { }

	public virtual NetworkClient StartHost(ConnectionConfig config, int maxConnections) { }

	public virtual NetworkClient StartHost(MatchInfo info) { }

	public virtual NetworkClient StartHost() { }

	public void StartMatchMaker() { }

	public bool StartServer(MatchInfo info) { }

	private bool StartServer(MatchInfo info, ConnectionConfig config, int maxConnections) { }

	public bool StartServer() { }

	public bool StartServer(ConnectionConfig config, int maxConnections) { }

	public void StopClient() { }

	public void StopHost() { }

	public void StopMatchMaker() { }

	public void StopServer() { }

	public static void UnRegisterStartPosition(Transform start) { }

	internal static void UpdateScene() { }

	public void UseExternalClient(NetworkClient externalClient) { }

}

