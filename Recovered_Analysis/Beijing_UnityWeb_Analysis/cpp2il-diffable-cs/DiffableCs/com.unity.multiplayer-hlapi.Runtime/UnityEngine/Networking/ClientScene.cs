namespace UnityEngine.Networking;

public class ClientScene
{
	private struct PendingOwner
	{
		public NetworkInstanceId netId; //Field offset: 0x0
		public short playerControllerId; //Field offset: 0x4

	}

	private static List<PlayerController> s_LocalPlayers; //Field offset: 0x0
	public const int ReconnectIdHost = 0; //Field offset: 0x0
	public const int ReconnectIdInvalid = -1; //Field offset: 0x0
	private static NetworkConnection s_ReadyConnection; //Field offset: 0x4
	private static Dictionary<NetworkSceneId, NetworkIdentity> s_SpawnableObjects; //Field offset: 0x8
	private static bool s_IsReady; //Field offset: 0xC
	private static bool s_IsSpawnFinished; //Field offset: 0xD
	private static NetworkScene s_NetworkScene; //Field offset: 0x10
	private static ObjectSpawnSceneMessage s_ObjectSpawnSceneMessage; //Field offset: 0x14
	private static ObjectSpawnFinishedMessage s_ObjectSpawnFinishedMessage; //Field offset: 0x18
	private static ObjectDestroyMessage s_ObjectDestroyMessage; //Field offset: 0x1C
	private static ObjectSpawnMessage s_ObjectSpawnMessage; //Field offset: 0x20
	private static OwnerMessage s_OwnerMessage; //Field offset: 0x24
	private static ClientAuthorityMessage s_ClientAuthorityMessage; //Field offset: 0x28
	private static int s_ReconnectId; //Field offset: 0x2C
	private static PeerInfoMessage[] s_Peers; //Field offset: 0x30
	private static List<PendingOwner> s_PendingOwnerIds; //Field offset: 0x34

	public static List<PlayerController> localPlayers
	{
		 get { } //Length: 92
	}

	public static Dictionary<NetworkInstanceId, NetworkIdentity> objects
	{
		 get { } //Length: 89
	}

	public static Dictionary<NetworkHash128, GameObject> prefabs
	{
		 get { } //Length: 92
	}

	public static bool ready
	{
		 get { } //Length: 89
	}

	public static NetworkConnection readyConnection
	{
		 get { } //Length: 92
	}

	public static int reconnectId
	{
		 get { } //Length: 89
	}

	public static Dictionary<NetworkSceneId, NetworkIdentity> spawnableObjects
	{
		 get { } //Length: 77
	}

	private static ClientScene() { }

	public ClientScene() { }

	public static bool AddPlayer(NetworkConnection readyConn, short playerControllerId, MessageBase extraMessage) { }

	public static bool AddPlayer(NetworkConnection readyConn, short playerControllerId) { }

	public static bool AddPlayer(short playerControllerId) { }

	private static void ApplySpawnPayload(NetworkIdentity uv, Vector3 position, byte[] payload, NetworkInstanceId netId, GameObject newGameObject, NetworkMessage netMsg) { }

	private static void CheckForOwner(NetworkIdentity uv) { }

	internal static void ClearLocalPlayers() { }

	public static void ClearSpawners() { }

	public static NetworkClient ConnectLocalServer() { }

	public static void DestroyAllClientObjects() { }

	public static GameObject FindLocalObject(NetworkInstanceId netId) { }

	public static List<PlayerController> get_localPlayers() { }

	public static Dictionary<NetworkInstanceId, NetworkIdentity> get_objects() { }

	public static Dictionary<NetworkHash128, GameObject> get_prefabs() { }

	public static bool get_ready() { }

	public static NetworkConnection get_readyConnection() { }

	public static int get_reconnectId() { }

	public static Dictionary<NetworkSceneId, NetworkIdentity> get_spawnableObjects() { }

	internal static bool GetPlayerController(short playerControllerId, out PlayerController player) { }

	internal static string GetStringForAssetId(NetworkHash128 assetId) { }

	internal static void HandleClientDisconnect(NetworkConnection conn) { }

	private static bool hasMigrationPending() { }

	internal static void InternalAddPlayer(NetworkIdentity view, short playerControllerId) { }

	private static void OnClientAuthority(NetworkMessage netMsg) { }

	private static void OnLocalClientObjectDestroy(NetworkMessage netMsg) { }

	private static void OnLocalClientObjectHide(NetworkMessage netMsg) { }

	private static void OnLocalClientObjectSpawn(NetworkMessage netMsg) { }

	private static void OnLocalClientObjectSpawnScene(NetworkMessage netMsg) { }

	private static void OnObjectDestroy(NetworkMessage netMsg) { }

	private static void OnObjectSpawn(NetworkMessage netMsg) { }

	private static void OnObjectSpawnFinished(NetworkMessage netMsg) { }

	private static void OnObjectSpawnScene(NetworkMessage netMsg) { }

	private static void OnOwnerMessage(NetworkMessage netMsg) { }

	private static void OnRPCMessage(NetworkMessage netMsg) { }

	private static void OnSyncEventMessage(NetworkMessage netMsg) { }

	private static void OnSyncListMessage(NetworkMessage netMsg) { }

	private static void OnUpdateVarsMessage(NetworkMessage netMsg) { }

	internal static void PrepareToSpawnSceneObjects() { }

	public static bool Ready(NetworkConnection conn) { }

	internal static NetworkClient ReconnectLocalServer() { }

	public static void RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	public static void RegisterPrefab(GameObject prefab) { }

	public static void RegisterPrefab(GameObject prefab, NetworkHash128 newAssetId) { }

	public static void RegisterSpawnHandler(NetworkHash128 assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	internal static void RegisterSystemHandlers(NetworkClient client, bool localClient) { }

	public static bool RemovePlayer(short playerControllerId) { }

	public static bool SendReconnectMessage(MessageBase extraMessage) { }

	public static void SetLocalObject(NetworkInstanceId netId, GameObject obj) { }

	internal static void SetNotReady() { }

	public static void SetReconnectId(int newReconnectId, PeerInfoMessage[] peers) { }

	internal static void Shutdown() { }

	internal static NetworkIdentity SpawnSceneObject(NetworkSceneId sceneId) { }

	public static void UnregisterPrefab(GameObject prefab) { }

	public static void UnregisterSpawnHandler(NetworkHash128 assetId) { }

}

