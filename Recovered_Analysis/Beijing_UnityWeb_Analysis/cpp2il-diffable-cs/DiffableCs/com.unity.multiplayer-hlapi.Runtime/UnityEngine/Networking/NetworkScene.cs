namespace UnityEngine.Networking;

internal class NetworkScene
{
	private static Dictionary<NetworkHash128, GameObject> s_GuidToPrefab; //Field offset: 0x0
	private static Dictionary<NetworkHash128, SpawnDelegate> s_SpawnHandlers; //Field offset: 0x4
	private static Dictionary<NetworkHash128, UnSpawnDelegate> s_UnspawnHandlers; //Field offset: 0x8
	private Dictionary<NetworkInstanceId, NetworkIdentity> m_LocalObjects; //Field offset: 0x8

	internal static Dictionary<NetworkHash128, GameObject> guidToPrefab
	{
		 get { } //Length: 89
	}

	internal Dictionary<NetworkInstanceId, NetworkIdentity> localObjects
	{
		 get { } //Length: 12
	}

	internal static Dictionary<NetworkHash128, SpawnDelegate> spawnHandlers
	{
		 get { } //Length: 89
	}

	internal static Dictionary<NetworkHash128, UnSpawnDelegate> unspawnHandlers
	{
		 get { } //Length: 89
	}

	private static NetworkScene() { }

	public NetworkScene() { }

	internal void ClearLocalObjects() { }

	internal static void ClearSpawners() { }

	internal void DestroyAllClientObjects() { }

	internal void DumpAllClientObjects() { }

	internal GameObject FindLocalObject(NetworkInstanceId netId) { }

	internal static Dictionary<NetworkHash128, GameObject> get_guidToPrefab() { }

	internal Dictionary<NetworkInstanceId, NetworkIdentity> get_localObjects() { }

	internal static Dictionary<NetworkHash128, SpawnDelegate> get_spawnHandlers() { }

	internal static Dictionary<NetworkHash128, UnSpawnDelegate> get_unspawnHandlers() { }

	internal bool GetNetworkIdentity(NetworkInstanceId netId, out NetworkIdentity uv) { }

	internal static bool GetPrefab(NetworkHash128 assetId, out GameObject prefab) { }

	internal static bool GetSpawnHandler(NetworkHash128 assetId, out SpawnDelegate handler) { }

	internal static bool InvokeUnSpawnHandler(NetworkHash128 assetId, GameObject obj) { }

	internal static void RegisterPrefab(GameObject prefab, NetworkHash128 newAssetId) { }

	internal static void RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	internal static void RegisterPrefab(GameObject prefab) { }

	internal static void RegisterSpawnHandler(NetworkHash128 assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	internal bool RemoveLocalObject(NetworkInstanceId netId) { }

	internal bool RemoveLocalObjectAndDestroy(NetworkInstanceId netId) { }

	internal void SetLocalObject(NetworkInstanceId netId, GameObject obj, bool isClient, bool isServer) { }

	internal void Shutdown() { }

	internal static void UnregisterPrefab(GameObject prefab) { }

	public static void UnregisterSpawnHandler(NetworkHash128 assetId) { }

}

