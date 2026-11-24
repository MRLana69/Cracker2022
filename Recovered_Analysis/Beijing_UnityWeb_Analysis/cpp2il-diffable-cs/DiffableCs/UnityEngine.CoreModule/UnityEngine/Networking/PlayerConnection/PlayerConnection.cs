namespace UnityEngine.Networking.PlayerConnection;

public class PlayerConnection : ScriptableObject
{
	private sealed class <BlockUntilRecvMsg>c__AnonStorey2
	{
		internal bool msgReceived; //Field offset: 0x8

		public <BlockUntilRecvMsg>c__AnonStorey2() { }

		internal void <>m__0(MessageEventArgs args) { }

	}

	private sealed class <Register>c__AnonStorey0
	{
		internal Guid messageId; //Field offset: 0x8

		public <Register>c__AnonStorey0() { }

		internal bool <>m__0(MessageTypeSubscribers x) { }

	}

	private sealed class <Unregister>c__AnonStorey1
	{
		internal Guid messageId; //Field offset: 0x8

		public <Unregister>c__AnonStorey1() { }

		internal bool <>m__0(MessageTypeSubscribers x) { }

	}

	internal static IPlayerEditorConnectionNative connectionNative; //Field offset: 0x0
	private static PlayerConnection s_Instance; //Field offset: 0x4
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; //Field offset: 0xC
	private List<int> m_connectedPlayers; //Field offset: 0x10
	private bool m_IsInitilized; //Field offset: 0x14

	public static PlayerConnection instance
	{
		 get { } //Length: 47
	}

	public bool isConnected
	{
		 get { } //Length: 12
	}

	public PlayerConnection() { }

	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	private static void ConnectedCallbackInternal(int playerId) { }

	private static PlayerConnection CreateInstance() { }

	public void DisconnectAll() { }

	private static void DisconnectedCallback(int playerId) { }

	public static PlayerConnection get_instance() { }

	public bool get_isConnected() { }

	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	private static void MessageCallbackInternal(nint data, ulong size, ulong guid, string messageId) { }

	public void OnEnable() { }

	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	public void RegisterConnection(UnityAction<int> callback) { }

	public void RegisterDisconnection(UnityAction<int> callback) { }

	public void Send(Guid messageId, byte[] data) { }

	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

}

