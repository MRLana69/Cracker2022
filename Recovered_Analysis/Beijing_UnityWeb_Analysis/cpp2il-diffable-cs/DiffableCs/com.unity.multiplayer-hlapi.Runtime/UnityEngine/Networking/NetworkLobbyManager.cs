namespace UnityEngine.Networking;

public class NetworkLobbyManager : NetworkManager
{
	private struct PendingPlayer
	{
		public NetworkConnection conn; //Field offset: 0x0
		public GameObject lobbyPlayer; //Field offset: 0x4

	}

	private static LobbyReadyToBeginMessage s_ReadyToBeginMessage; //Field offset: 0x0
	private static IntegerMessage s_SceneLoadedMessage; //Field offset: 0x4
	private static LobbyReadyToBeginMessage s_LobbyReadyToBeginMessage; //Field offset: 0x8
	private bool m_ShowLobbyGUI; //Field offset: 0x94
	private int m_MaxPlayers; //Field offset: 0x98
	private int m_MaxPlayersPerConnection; //Field offset: 0x9C
	private int m_MinPlayers; //Field offset: 0xA0
	private NetworkLobbyPlayer m_LobbyPlayerPrefab; //Field offset: 0xA4
	private GameObject m_GamePlayerPrefab; //Field offset: 0xA8
	private string m_LobbyScene; //Field offset: 0xAC
	private string m_PlayScene; //Field offset: 0xB0
	private List<PendingPlayer> m_PendingPlayers; //Field offset: 0xB4
	public NetworkLobbyPlayer[] lobbySlots; //Field offset: 0xB8

	public GameObject gamePlayerPrefab
	{
		 get { } //Length: 7
		 set { } //Length: 12
	}

	public NetworkLobbyPlayer lobbyPlayerPrefab
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public string lobbyScene
	{
		 get { } //Length: 7
		 set { } //Length: 12
	}

	public int maxPlayers
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public int maxPlayersPerConnection
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public int minPlayers
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public string playScene
	{
		 get { } //Length: 7
		 set { } //Length: 22
	}

	public bool showLobbyGUI
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	private static NetworkLobbyManager() { }

	public NetworkLobbyManager() { }

	private void CallOnClientEnterLobby() { }

	private void CallOnClientExitLobby() { }

	private static int CheckConnectionIsReadyToBegin(NetworkConnection conn) { }

	public void CheckReadyToBegin() { }

	private byte FindSlot() { }

	public GameObject get_gamePlayerPrefab() { }

	public NetworkLobbyPlayer get_lobbyPlayerPrefab() { }

	public string get_lobbyScene() { }

	public int get_maxPlayers() { }

	public int get_maxPlayersPerConnection() { }

	public int get_minPlayers() { }

	public string get_playScene() { }

	public bool get_showLobbyGUI() { }

	private void OnClientAddPlayerFailedMessage(NetworkMessage netMsg) { }

	public override void OnClientConnect(NetworkConnection conn) { }

	public override void OnClientDisconnect(NetworkConnection conn) { }

	private void OnClientReadyToBegin(NetworkMessage netMsg) { }

	public override void OnClientSceneChanged(NetworkConnection conn) { }

	private void OnGUI() { }

	public virtual void OnLobbyClientAddPlayerFailed() { }

	public virtual void OnLobbyClientConnect(NetworkConnection conn) { }

	public virtual void OnLobbyClientDisconnect(NetworkConnection conn) { }

	public virtual void OnLobbyClientEnter() { }

	public virtual void OnLobbyClientExit() { }

	public virtual void OnLobbyClientSceneChanged(NetworkConnection conn) { }

	public virtual void OnLobbyServerConnect(NetworkConnection conn) { }

	public virtual GameObject OnLobbyServerCreateGamePlayer(NetworkConnection conn, short playerControllerId) { }

	public virtual GameObject OnLobbyServerCreateLobbyPlayer(NetworkConnection conn, short playerControllerId) { }

	public virtual void OnLobbyServerDisconnect(NetworkConnection conn) { }

	public virtual void OnLobbyServerPlayerRemoved(NetworkConnection conn, short playerControllerId) { }

	public virtual void OnLobbyServerPlayersReady() { }

	public virtual void OnLobbyServerSceneChanged(string sceneName) { }

	public virtual bool OnLobbyServerSceneLoadedForPlayer(GameObject lobbyPlayer, GameObject gamePlayer) { }

	public virtual void OnLobbyStartClient(NetworkClient lobbyClient) { }

	public virtual void OnLobbyStartHost() { }

	public virtual void OnLobbyStartServer() { }

	public virtual void OnLobbyStopClient() { }

	public virtual void OnLobbyStopHost() { }

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId) { }

	public override void OnServerConnect(NetworkConnection conn) { }

	public override void OnServerDisconnect(NetworkConnection conn) { }

	private void OnServerReadyToBeginMessage(NetworkMessage netMsg) { }

	public override void OnServerRemovePlayer(NetworkConnection conn, PlayerController player) { }

	private void OnServerReturnToLobbyMessage(NetworkMessage netMsg) { }

	public override void OnServerSceneChanged(string sceneName) { }

	private void OnServerSceneLoadedMessage(NetworkMessage netMsg) { }

	public override void OnStartClient(NetworkClient lobbyClient) { }

	public override void OnStartHost() { }

	public override void OnStartServer() { }

	public override void OnStopClient() { }

	public override void OnStopHost() { }

	private void OnValidate() { }

	private void SceneLoadedForPlayer(NetworkConnection conn, GameObject lobbyPlayerGameObject) { }

	public bool SendReturnToLobby() { }

	public override void ServerChangeScene(string sceneName) { }

	public void ServerReturnToLobby() { }

	public void set_gamePlayerPrefab(GameObject value) { }

	public void set_lobbyPlayerPrefab(NetworkLobbyPlayer value) { }

	public void set_lobbyScene(string value) { }

	public void set_maxPlayers(int value) { }

	public void set_maxPlayersPerConnection(int value) { }

	public void set_minPlayers(int value) { }

	public void set_playScene(string value) { }

	public void set_showLobbyGUI(bool value) { }

	public void TryToAddPlayer() { }

}

