namespace UnityEngine.Networking;

public class NetworkLobbyPlayer : NetworkBehaviour
{
	public bool ShowLobbyGUI; //Field offset: 0x1C
	private byte m_Slot; //Field offset: 0x1D
	private bool m_ReadyToBegin; //Field offset: 0x1E

	public bool readyToBegin
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public byte slot
	{
		 get { } //Length: 98
		 set { } //Length: 2
	}

	public NetworkLobbyPlayer() { }

	public bool get_readyToBegin() { }

	public byte get_slot() { }

	private NetworkLobbyManager GetLobbyManager() { }

	public virtual void OnClientEnterLobby() { }

	public virtual void OnClientExitLobby() { }

	public virtual void OnClientReady(bool readyState) { }

	public override void OnDeserialize(NetworkReader reader, bool initialState) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnGUI() { }

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	public override bool OnSerialize(NetworkWriter writer, bool initialState) { }

	public override void OnStartClient() { }

	public void RemovePlayer() { }

	public void SendNotReadyToBeginMessage() { }

	public void SendReadyToBeginMessage() { }

	public void SendSceneLoadedMessage() { }

	public void set_readyToBegin(bool value) { }

	public void set_slot(byte value) { }

	private void Start() { }

}

