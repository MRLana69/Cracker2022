namespace UnityEngine.Networking;

public sealed class NetworkIdentity : MonoBehaviour
{
	public delegate ClientAuthorityCallback
	{

		public ClientAuthorityCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(NetworkConnection conn, NetworkIdentity uv, bool authorityState, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(NetworkConnection conn, NetworkIdentity uv, bool authorityState) { }

	}

	private static uint s_NextNetworkId; //Field offset: 0x0
	private static NetworkWriter s_UpdateWriter; //Field offset: 0x4
	public static ClientAuthorityCallback clientAuthorityCallback; //Field offset: 0x8
	private NetworkSceneId m_SceneId; //Field offset: 0xC
	private NetworkHash128 m_AssetId; //Field offset: 0x10
	private bool m_ServerOnly; //Field offset: 0x20
	private bool m_LocalPlayerAuthority; //Field offset: 0x21
	private bool m_IsClient; //Field offset: 0x22
	private bool m_IsServer; //Field offset: 0x23
	private bool m_HasAuthority; //Field offset: 0x24
	private NetworkInstanceId m_NetId; //Field offset: 0x28
	private bool m_IsLocalPlayer; //Field offset: 0x2C
	private NetworkConnection m_ConnectionToServer; //Field offset: 0x30
	private NetworkConnection m_ConnectionToClient; //Field offset: 0x34
	private short m_PlayerId; //Field offset: 0x38
	private NetworkBehaviour[] m_NetworkBehaviours; //Field offset: 0x3C
	private HashSet<int> m_ObserverConnections; //Field offset: 0x40
	private List<NetworkConnection> m_Observers; //Field offset: 0x44
	private NetworkConnection m_ClientAuthorityOwner; //Field offset: 0x48
	private bool m_Reset; //Field offset: 0x4C

	public NetworkHash128 assetId
	{
		 get { } //Length: 11
	}

	public NetworkConnection clientAuthorityOwner
	{
		 get { } //Length: 9
	}

	public NetworkConnection connectionToClient
	{
		 get { } //Length: 6
	}

	public NetworkConnection connectionToServer
	{
		 get { } //Length: 6
	}

	public bool hasAuthority
	{
		 get { } //Length: 88
	}

	public bool isClient
	{
		 get { } //Length: 12
	}

	public bool isLocalPlayer
	{
		 get { } //Length: 6
	}

	public bool isServer
	{
		 get { } //Length: 9
	}

	public bool localPlayerAuthority
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public NetworkInstanceId netId
	{
		 get { } //Length: 9
	}

	public ReadOnlyCollection<NetworkConnection> observers
	{
		 get { } //Length: 6
	}

	public short playerControllerId
	{
		 get { } //Length: 9
	}

	public NetworkSceneId sceneId
	{
		 get { } //Length: 6
	}

	public bool serverOnly
	{
		 get { } //Length: 6
		 set { } //Length: 880
	}

	private static NetworkIdentity() { }

	public NetworkIdentity() { }

	internal static void AddNetworkId(uint id) { }

	internal void AddObserver(NetworkConnection conn) { }

	public bool AssignClientAuthority(NetworkConnection conn) { }

	private void CacheBehaviours() { }

	internal void ClearClientOwner() { }

	internal void ClearObservers() { }

	internal void ForceAuthority(bool authority) { }

	public void ForceSceneId(int newSceneId) { }

	public NetworkHash128 get_assetId() { }

	public NetworkConnection get_clientAuthorityOwner() { }

	public NetworkConnection get_connectionToClient() { }

	public NetworkConnection get_connectionToServer() { }

	public bool get_hasAuthority() { }

	public bool get_isClient() { }

	public bool get_isLocalPlayer() { }

	public bool get_isServer() { }

	public bool get_localPlayerAuthority() { }

	public NetworkInstanceId get_netId() { }

	public ReadOnlyCollection<NetworkConnection> get_observers() { }

	public short get_playerControllerId() { }

	public NetworkSceneId get_sceneId() { }

	public bool get_serverOnly() { }

	private NetworkBehaviour[] GetBehavioursOfSameChannel(int channelId, bool initialState) { }

	private bool GetInvokeComponent(int cmdHash, Type invokeClass, out NetworkBehaviour invokeComponent) { }

	internal static NetworkInstanceId GetNextNetworkId() { }

	internal void HandleClientAuthority(bool authority) { }

	internal void HandleCommand(int cmdHash, NetworkReader reader) { }

	internal void HandleRPC(int cmdHash, NetworkReader reader) { }

	internal void HandleSyncEvent(int cmdHash, NetworkReader reader) { }

	internal void HandleSyncList(int cmdHash, NetworkReader reader) { }

	internal void MarkForReset() { }

	internal bool OnCheckObserver(NetworkConnection conn) { }

	private void OnDestroy() { }

	internal void OnNetworkDestroy() { }

	private static void OnRuntimeInitializeOnLoad() { }

	internal void OnSetLocalVisibility(bool vis) { }

	internal void OnStartAuthority() { }

	internal void OnStartClient() { }

	internal void OnStartServer(bool allowNonZeroNetId) { }

	internal void OnStopAuthority() { }

	internal void OnUpdateVars(NetworkReader reader, bool initialState, NetworkMessage netMsg) { }

	public void RebuildObservers(bool initialize) { }

	public bool RemoveClientAuthority(NetworkConnection conn) { }

	internal void RemoveObserver(NetworkConnection conn) { }

	internal void RemoveObserverInternal(NetworkConnection conn) { }

	internal void Reset() { }

	public void set_localPlayerAuthority(bool value) { }

	public void set_serverOnly(bool value) { }

	internal void SetClientOwner(NetworkConnection conn) { }

	internal void SetConnectionToClient(NetworkConnection conn, short newPlayerControllerId) { }

	internal void SetConnectionToServer(NetworkConnection conn) { }

	internal void SetDynamicAssetId(NetworkHash128 newAssetId) { }

	internal void SetLocalPlayer(short localPlayerControllerId) { }

	internal void SetNetworkInstanceId(NetworkInstanceId newNetId) { }

	internal void SetNotLocalPlayer() { }

	internal void UNetSerializeAllVars(NetworkWriter writer) { }

	internal static void UNetStaticUpdate() { }

	public void UNetUpdate() { }

	internal void UpdateClientServer(bool isClientFlag, bool isServerFlag) { }

}

