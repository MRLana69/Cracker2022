namespace UnityEngine.Networking;

public class NetworkMigrationManager : MonoBehaviour
{
	public struct ConnectionPendingPlayers
	{
		public List<PendingPlayerInfo> players; //Field offset: 0x0

	}

	public struct PendingPlayerInfo
	{
		public NetworkInstanceId netId; //Field offset: 0x0
		public short playerControllerId; //Field offset: 0x4
		public GameObject obj; //Field offset: 0x8

	}

	public enum SceneChangeOption
	{
		StayInOnlineScene = 0,
		SwitchToOfflineScene = 1,
	}

	private bool m_HostMigration; //Field offset: 0xC
	private bool m_ShowGUI; //Field offset: 0xD
	private int m_OffsetX; //Field offset: 0x10
	private int m_OffsetY; //Field offset: 0x14
	private NetworkClient m_Client; //Field offset: 0x18
	private bool m_WaitingToBecomeNewHost; //Field offset: 0x1C
	private bool m_WaitingReconnectToNewHost; //Field offset: 0x1D
	private bool m_DisconnectedFromHost; //Field offset: 0x1E
	private bool m_HostWasShutdown; //Field offset: 0x1F
	private MatchInfo m_MatchInfo; //Field offset: 0x20
	private int m_OldServerConnectionId; //Field offset: 0x24
	private string m_NewHostAddress; //Field offset: 0x28
	private PeerInfoMessage m_NewHostInfo; //Field offset: 0x2C
	private PeerListMessage m_PeerListMessage; //Field offset: 0x30
	private PeerInfoMessage[] m_Peers; //Field offset: 0x34
	private Dictionary<int, ConnectionPendingPlayers> m_PendingPlayers; //Field offset: 0x38

	public NetworkClient client
	{
		 get { } //Length: 6
	}

	public bool disconnectedFromHost
	{
		 get { } //Length: 9
	}

	public bool hostMigration
	{
		 get { } //Length: 6
		 set { } //Length: 55
	}

	public bool hostWasShutdown
	{
		 get { } //Length: 9
	}

	public MatchInfo matchInfo
	{
		 get { } //Length: 9
	}

	public string newHostAddress
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public int offsetX
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public int offsetY
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int oldServerConnectionId
	{
		 get { } //Length: 6
	}

	public PeerInfoMessage[] peers
	{
		 get { } //Length: 6
	}

	public Dictionary<int, ConnectionPendingPlayers> pendingPlayers
	{
		 get { } //Length: 6
	}

	public bool showGUI
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool waitingReconnectToNewHost
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool waitingToBecomeNewHost
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public NetworkMigrationManager() { }

	private void AddPendingPlayer(GameObject obj, int connectionId, NetworkInstanceId netId, short playerControllerId) { }

	internal void AssignAuthorityCallback(NetworkConnection conn, NetworkIdentity uv, bool authorityState) { }

	public bool BecomeNewHost(int port) { }

	public void DisablePlayerObjects() { }

	public virtual bool FindNewHost(out PeerInfoMessage newHostInfo, out bool youAreNewHost) { }

	private GameObject FindPendingPlayer(int connectionId, NetworkInstanceId netId, short playerControllerId) { }

	public NetworkClient get_client() { }

	public bool get_disconnectedFromHost() { }

	public bool get_hostMigration() { }

	public bool get_hostWasShutdown() { }

	public MatchInfo get_matchInfo() { }

	public string get_newHostAddress() { }

	public int get_offsetX() { }

	public int get_offsetY() { }

	public int get_oldServerConnectionId() { }

	public PeerInfoMessage[] get_peers() { }

	public Dictionary<int, ConnectionPendingPlayers> get_pendingPlayers() { }

	public bool get_showGUI() { }

	public bool get_waitingReconnectToNewHost() { }

	public bool get_waitingToBecomeNewHost() { }

	public void Initialize(NetworkClient newClient, MatchInfo newMatchInfo) { }

	public bool LostHostOnClient(NetworkConnection conn) { }

	public void LostHostOnHost() { }

	protected virtual void OnAuthorityUpdated(GameObject go, int connectionId, bool authorityState) { }

	protected virtual void OnClientDisconnectedFromHost(NetworkConnection conn, out SceneChangeOption sceneChange) { }

	private void OnGUI() { }

	private void OnGUIClient() { }

	private void OnGUIHost() { }

	private void OnPeerClientAuthority(NetworkMessage netMsg) { }

	private void OnPeerInfo(NetworkMessage netMsg) { }

	protected virtual void OnPeersUpdated(PeerListMessage peers) { }

	protected virtual void OnServerHostShutdown() { }

	protected virtual void OnServerReconnectObject(NetworkConnection newConnection, GameObject oldObject, int oldConnectionId) { }

	protected virtual void OnServerReconnectPlayer(NetworkConnection newConnection, GameObject oldPlayer, int oldConnectionId, short playerControllerId) { }

	protected virtual void OnServerReconnectPlayer(NetworkConnection newConnection, GameObject oldPlayer, int oldConnectionId, short playerControllerId, NetworkReader extraMessageReader) { }

	private void OnServerReconnectPlayerMessage(NetworkMessage netMsg) { }

	public bool ReconnectObjectForConnection(NetworkConnection newConnection, GameObject oldObject, int oldConnectionId) { }

	public bool ReconnectPlayerForConnection(NetworkConnection newConnection, GameObject oldPlayer, int oldConnectionId, short playerControllerId) { }

	private void RemovePendingPlayer(int connectionId) { }

	public void Reset(int reconnectId) { }

	public void SendPeerInfo() { }

	public void set_hostMigration(bool value) { }

	public void set_newHostAddress(string value) { }

	public void set_offsetX(int value) { }

	public void set_offsetY(int value) { }

	public void set_showGUI(bool value) { }

	public void set_waitingReconnectToNewHost(bool value) { }

	public void set_waitingToBecomeNewHost(bool value) { }

	private void Start() { }

}

