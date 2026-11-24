namespace UnityEngine.Networking;

public class HostTopology
{
	private ConnectionConfig m_DefConfig; //Field offset: 0x8
	private int m_MaxDefConnections; //Field offset: 0xC
	private List<ConnectionConfig> m_SpecialConnections; //Field offset: 0x10
	private ushort m_ReceivedMessagePoolSize; //Field offset: 0x14
	private ushort m_SentMessagePoolSize; //Field offset: 0x16
	private float m_MessagePoolSizeGrowthFactor; //Field offset: 0x18

	public ConnectionConfig DefaultConfig
	{
		 get { } //Length: 6
	}

	public HostTopology(ConnectionConfig defaultConfig, int maxDefaultConnections) { }

	private HostTopology() { }

	public ConnectionConfig get_DefaultConfig() { }

}

