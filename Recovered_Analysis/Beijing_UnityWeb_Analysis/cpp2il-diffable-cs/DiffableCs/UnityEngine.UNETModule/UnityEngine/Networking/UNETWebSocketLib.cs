namespace UnityEngine.Networking;

internal class UNETWebSocketLib : IDisposable
{
	private static readonly UNETWebSocketLib instance; //Field offset: 0x0
	private static int m_MaxMessageSize; //Field offset: 0x4

	public static UNETWebSocketLib Instance
	{
		 get { } //Length: 3
	}

	private static UNETWebSocketLib() { }

	private UNETWebSocketLib() { }

	public int AddHost(HostTopology topology, int port) { }

	public int Connect(int hostId, string ip, int port, int exeptionConnectionId, out byte error) { }

	public bool Disconnect(int hostId, int connectionId, out byte error) { }

	public void Dispose() { }

	public static UNETWebSocketLib get_Instance() { }

	public void Init() { }

	private static int JS_UNETWebSockets_AddHost(uint pingTimeout) { }

	private static void JS_UNETWebSockets_Init() { }

	private static bool JS_UNETWebSockets_IsHostCorrect(int hostId) { }

	private static bool JS_UNETWebSockets_IsHostReadyToConnect(int hostId) { }

	private static void JS_UNETWebSockets_SocketCleanEvnt() { }

	private static void JS_UNETWebSockets_SocketCleanEvntFromHost(int hostId) { }

	private static void JS_UNETWebSockets_SocketClose(int hostId) { }

	private static void JS_UNETWebSockets_SocketCreate(int hostId, string url) { }

	private static int JS_UNETWebSockets_SocketRecvEvntBuff(byte[] buff, int length) { }

	private static int JS_UNETWebSockets_SocketRecvEvntBuffFromHost(int hostId, byte[] buff, int length) { }

	private static int JS_UNETWebSockets_SocketRecvEvntBuffLength() { }

	private static int JS_UNETWebSockets_SocketRecvEvntBuffLengthFromHost(int hostId) { }

	private static int JS_UNETWebSockets_SocketRecvEvntHost() { }

	private static int JS_UNETWebSockets_SocketRecvEvntType() { }

	private static int JS_UNETWebSockets_SocketRecvEvntTypeFromHost(int hostId) { }

	private static void JS_UNETWebSockets_SocketSend(int hostId, byte[] buff, int length) { }

	private static void JS_UNETWebSockets_SocketStop() { }

	public NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error) { }

	public bool Send(int hostId, int connectionId, int channelId, byte[] buff, int size, out byte error) { }

	public void Stop() { }

}

