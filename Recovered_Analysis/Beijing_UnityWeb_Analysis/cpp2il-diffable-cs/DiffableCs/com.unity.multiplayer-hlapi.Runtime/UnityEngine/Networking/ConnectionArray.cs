namespace UnityEngine.Networking;

internal class ConnectionArray
{
	private List<NetworkConnection> m_LocalConnections; //Field offset: 0x8
	private List<NetworkConnection> m_Connections; //Field offset: 0xC

	internal List<NetworkConnection> connections
	{
		 get { } //Length: 6
	}

	public int Count
	{
		 get { } //Length: 6
	}

	internal List<NetworkConnection> localConnections
	{
		 get { } //Length: 137
	}

	public int LocalIndex
	{
		 get { } //Length: 52
	}

	public ConnectionArray() { }

	public int Add(int connId, NetworkConnection conn) { }

	public int AddLocal(NetworkConnection conn) { }

	public bool ContainsPlayer(GameObject player, out NetworkConnection conn) { }

	public NetworkConnection Get(int connId) { }

	internal List<NetworkConnection> get_connections() { }

	public int get_Count() { }

	internal List<NetworkConnection> get_localConnections() { }

	public int get_LocalIndex() { }

	public NetworkConnection GetUnsafe(int connId) { }

	public void Remove(int connId) { }

}

