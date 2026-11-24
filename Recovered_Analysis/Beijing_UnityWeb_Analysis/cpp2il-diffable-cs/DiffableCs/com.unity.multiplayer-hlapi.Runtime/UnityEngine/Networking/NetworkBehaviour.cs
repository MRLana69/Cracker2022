namespace UnityEngine.Networking;

public class NetworkBehaviour : MonoBehaviour
{
	public delegate CmdDelegate
	{

		public CmdDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(NetworkBehaviour obj, NetworkReader reader, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(NetworkBehaviour obj, NetworkReader reader) { }

	}

	protected delegate EventDelegate
	{

		public EventDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(List<Delegate> targets, NetworkReader reader, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(List<Delegate> targets, NetworkReader reader) { }

	}

	protected class Invoker
	{
		public UNetInvokeType invokeType; //Field offset: 0x8
		public Type invokeClass; //Field offset: 0xC
		public CmdDelegate invokeFunction; //Field offset: 0x10

		public Invoker() { }

		public string DebugString() { }

	}

	protected enum UNetInvokeType
	{
		Command = 0,
		ClientRpc = 1,
		SyncEvent = 2,
		SyncList = 3,
	}

	private const float k_DefaultSendInterval = 0.1; //Field offset: 0x0
	private static Dictionary<int, Invoker> s_CmdHandlerDelegates; //Field offset: 0x0
	private uint m_SyncVarDirtyBits; //Field offset: 0xC
	private float m_LastSendTime; //Field offset: 0x10
	private bool m_SyncVarGuard; //Field offset: 0x14
	private NetworkIdentity m_MyView; //Field offset: 0x18

	public NetworkConnection connectionToClient
	{
		 get { } //Length: 12
	}

	public NetworkConnection connectionToServer
	{
		 get { } //Length: 12
	}

	public bool hasAuthority
	{
		 get { } //Length: 15
	}

	public bool isClient
	{
		 get { } //Length: 15
	}

	public bool isLocalPlayer
	{
		 get { } //Length: 15
	}

	public bool isServer
	{
		 get { } //Length: 15
	}

	public bool localPlayerAuthority
	{
		 get { } //Length: 139
	}

	private NetworkIdentity myView
	{
		 get { } //Length: 9
	}

	public NetworkInstanceId netId
	{
		 get { } //Length: 15
	}

	internal NetworkIdentity netIdentity
	{
		 get { } //Length: 9
	}

	public short playerControllerId
	{
		 get { } //Length: 12
	}

	protected uint syncVarDirtyBits
	{
		 get { } //Length: 12
	}

	protected bool syncVarHookGuard
	{
		 get { } //Length: 6
		 set { } //Length: 337
	}

	private static NetworkBehaviour() { }

	public NetworkBehaviour() { }

	public void ClearAllDirtyBits() { }

	internal bool ContainsCommandDelegate(int cmdHash) { }

	internal static void DumpInvokers() { }

	public NetworkConnection get_connectionToClient() { }

	public NetworkConnection get_connectionToServer() { }

	public bool get_hasAuthority() { }

	public bool get_isClient() { }

	public bool get_isLocalPlayer() { }

	public bool get_isServer() { }

	public bool get_localPlayerAuthority() { }

	private NetworkIdentity get_myView() { }

	public NetworkInstanceId get_netId() { }

	internal NetworkIdentity get_netIdentity() { }

	public short get_playerControllerId() { }

	protected uint get_syncVarDirtyBits() { }

	protected bool get_syncVarHookGuard() { }

	internal static string GetCmdHashCmdName(int cmdHash) { }

	internal static string GetCmdHashEventName(int cmdHash) { }

	internal static string GetCmdHashHandlerName(int cmdHash) { }

	internal static string GetCmdHashListName(int cmdHash) { }

	private static string GetCmdHashPrefixName(int cmdHash, string prefix) { }

	internal static string GetCmdHashRpcName(int cmdHash) { }

	internal int GetDirtyChannel() { }

	internal static string GetInvoker(int cmdHash) { }

	private static bool GetInvokerForHash(int cmdHash, UNetInvokeType invokeType, out Type invokeClass, out CmdDelegate invokeFunction) { }

	internal static bool GetInvokerForHashClientRpc(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction) { }

	internal static bool GetInvokerForHashCommand(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction) { }

	internal static bool GetInvokerForHashSyncEvent(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction) { }

	internal static bool GetInvokerForHashSyncList(int cmdHash, out Type invokeClass, out CmdDelegate invokeFunction) { }

	public virtual int GetNetworkChannel() { }

	public virtual float GetNetworkSendInterval() { }

	public virtual bool InvokeCommand(int cmdHash, NetworkReader reader) { }

	internal bool InvokeCommandDelegate(int cmdHash, NetworkReader reader) { }

	public virtual bool InvokeRPC(int cmdHash, NetworkReader reader) { }

	internal bool InvokeRpcDelegate(int cmdHash, NetworkReader reader) { }

	public virtual bool InvokeSyncEvent(int cmdHash, NetworkReader reader) { }

	internal bool InvokeSyncEventDelegate(int cmdHash, NetworkReader reader) { }

	public virtual bool InvokeSyncList(int cmdHash, NetworkReader reader) { }

	internal bool InvokeSyncListDelegate(int cmdHash, NetworkReader reader) { }

	public virtual bool OnCheckObserver(NetworkConnection conn) { }

	public virtual void OnDeserialize(NetworkReader reader, bool initialState) { }

	public virtual void OnNetworkDestroy() { }

	public virtual bool OnRebuildObservers(HashSet<NetworkConnection> observers, bool initialize) { }

	public virtual bool OnSerialize(NetworkWriter writer, bool initialState) { }

	public virtual void OnSetLocalVisibility(bool vis) { }

	public virtual void OnStartAuthority() { }

	public virtual void OnStartClient() { }

	public virtual void OnStartLocalPlayer() { }

	public virtual void OnStartServer() { }

	public virtual void OnStopAuthority() { }

	public virtual void PreStartClient() { }

	protected static void RegisterCommandDelegate(Type invokeClass, int cmdHash, CmdDelegate func) { }

	protected static void RegisterEventDelegate(Type invokeClass, int cmdHash, CmdDelegate func) { }

	protected static void RegisterRpcDelegate(Type invokeClass, int cmdHash, CmdDelegate func) { }

	protected static void RegisterSyncListDelegate(Type invokeClass, int cmdHash, CmdDelegate func) { }

	protected void SendCommandInternal(NetworkWriter writer, int channelId, string cmdName) { }

	protected void SendEventInternal(NetworkWriter writer, int channelId, string eventName) { }

	protected void SendRPCInternal(NetworkWriter writer, int channelId, string rpcName) { }

	protected void SendTargetRPCInternal(NetworkConnection conn, NetworkWriter writer, int channelId, string rpcName) { }

	protected void set_syncVarHookGuard(bool value) { }

	public void SetDirtyBit(uint dirtyBit) { }

	protected void SetSyncVar(T value, ref T fieldValue, uint dirtyBit) { }

	protected void SetSyncVarGameObject(GameObject newGameObject, ref GameObject gameObjectField, uint dirtyBit, ref NetworkInstanceId netIdField) { }

}

