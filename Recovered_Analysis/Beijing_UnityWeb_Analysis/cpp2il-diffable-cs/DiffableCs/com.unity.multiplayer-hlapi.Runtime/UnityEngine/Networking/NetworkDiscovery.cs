namespace UnityEngine.Networking;

public class NetworkDiscovery : MonoBehaviour
{
	private const int k_MaxBroadcastMsgSize = 1024; //Field offset: 0x0
	private int m_BroadcastPort; //Field offset: 0xC
	private int m_BroadcastKey; //Field offset: 0x10
	private int m_BroadcastVersion; //Field offset: 0x14
	private int m_BroadcastSubVersion; //Field offset: 0x18
	private int m_BroadcastInterval; //Field offset: 0x1C
	private bool m_UseNetworkManager; //Field offset: 0x20
	private string m_BroadcastData; //Field offset: 0x24
	private bool m_ShowGUI; //Field offset: 0x28
	private int m_OffsetX; //Field offset: 0x2C
	private int m_OffsetY; //Field offset: 0x30
	private int m_HostId; //Field offset: 0x34
	private bool m_Running; //Field offset: 0x38
	private bool m_IsServer; //Field offset: 0x39
	private bool m_IsClient; //Field offset: 0x3A
	private byte[] m_MsgOutBuffer; //Field offset: 0x3C
	private byte[] m_MsgInBuffer; //Field offset: 0x40
	private HostTopology m_DefaultTopology; //Field offset: 0x44
	private Dictionary<string, NetworkBroadcastResult> m_BroadcastsReceived; //Field offset: 0x48

	public string broadcastData
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public int broadcastInterval
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int broadcastKey
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int broadcastPort
	{
		 get { } //Length: 6
		 set { } //Length: 1453
	}

	public Dictionary<string, NetworkBroadcastResult> broadcastsReceived
	{
		 get { } //Length: 9
	}

	public int broadcastSubVersion
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int broadcastVersion
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int hostId
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool isClient
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool isServer
	{
		 get { } //Length: 9
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

	public bool running
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool showGUI
	{
		 get { } //Length: 6
		 set { } //Length: 167
	}

	public bool useNetworkManager
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public NetworkDiscovery() { }

	private static string BytesToString(byte[] bytes) { }

	public string get_broadcastData() { }

	public int get_broadcastInterval() { }

	public int get_broadcastKey() { }

	public int get_broadcastPort() { }

	public Dictionary<string, NetworkBroadcastResult> get_broadcastsReceived() { }

	public int get_broadcastSubVersion() { }

	public int get_broadcastVersion() { }

	public int get_hostId() { }

	public bool get_isClient() { }

	public bool get_isServer() { }

	public int get_offsetX() { }

	public int get_offsetY() { }

	public bool get_running() { }

	public bool get_showGUI() { }

	public bool get_useNetworkManager() { }

	public bool Initialize() { }

	private void OnDestroy() { }

	private void OnGUI() { }

	public virtual void OnReceivedBroadcast(string fromAddress, string data) { }

	public void set_broadcastData(string value) { }

	public void set_broadcastInterval(int value) { }

	public void set_broadcastKey(int value) { }

	public void set_broadcastPort(int value) { }

	public void set_broadcastSubVersion(int value) { }

	public void set_broadcastVersion(int value) { }

	public void set_hostId(int value) { }

	public void set_isClient(bool value) { }

	public void set_isServer(bool value) { }

	public void set_offsetX(int value) { }

	public void set_offsetY(int value) { }

	public void set_running(bool value) { }

	public void set_showGUI(bool value) { }

	public void set_useNetworkManager(bool value) { }

	public bool StartAsClient() { }

	public bool StartAsServer() { }

	public void StopBroadcast() { }

	private static byte[] StringToBytes(string str) { }

	private void Update() { }

}

