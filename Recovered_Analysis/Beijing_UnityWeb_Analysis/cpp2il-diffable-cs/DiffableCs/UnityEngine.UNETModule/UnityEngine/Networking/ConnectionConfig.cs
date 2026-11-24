namespace UnityEngine.Networking;

public class ConnectionConfig
{
	private const int g_MinPacketSize = 128; //Field offset: 0x0
	private ushort m_PacketSize; //Field offset: 0x8
	private ushort m_FragmentSize; //Field offset: 0xA
	private uint m_ResendTimeout; //Field offset: 0xC
	private uint m_DisconnectTimeout; //Field offset: 0x10
	private uint m_ConnectTimeout; //Field offset: 0x14
	private uint m_MinUpdateTimeout; //Field offset: 0x18
	private uint m_PingTimeout; //Field offset: 0x1C
	private uint m_ReducedPingTimeout; //Field offset: 0x20
	private uint m_AllCostTimeout; //Field offset: 0x24
	private byte m_NetworkDropThreshold; //Field offset: 0x28
	private byte m_OverflowDropThreshold; //Field offset: 0x29
	private byte m_MaxConnectionAttempt; //Field offset: 0x2A
	private uint m_AckDelay; //Field offset: 0x2C
	private uint m_SendDelay; //Field offset: 0x30
	private ushort m_MaxCombinedReliableMessageSize; //Field offset: 0x34
	private ushort m_MaxCombinedReliableMessageCount; //Field offset: 0x36
	private ushort m_MaxSentMessageQueueSize; //Field offset: 0x38
	private ConnectionAcksType m_AcksType; //Field offset: 0x3C
	private bool m_UsePlatformSpecificProtocols; //Field offset: 0x40
	private uint m_InitialBandwidth; //Field offset: 0x44
	private float m_BandwidthPeakFactor; //Field offset: 0x48
	private ushort m_WebSocketReceiveBufferMaxSize; //Field offset: 0x4C
	private uint m_UdpSocketReceiveBufferMaxSize; //Field offset: 0x50
	private string m_SSLCertFilePath; //Field offset: 0x54
	private string m_SSLPrivateKeyFilePath; //Field offset: 0x58
	private string m_SSLCAFilePath; //Field offset: 0x5C
	internal List<ChannelQOS> m_Channels; //Field offset: 0x60
	internal List<List<byte>> m_SharedOrderChannels; //Field offset: 0x64

	public int ChannelCount
	{
		 get { } //Length: 12
	}

	public List<ChannelQOS> Channels
	{
		 get { } //Length: 52
	}

	public ushort FragmentSize
	{
		 get { } //Length: 6
	}

	public ushort MaxCombinedReliableMessageSize
	{
		 get { } //Length: 6
	}

	public uint MinUpdateTimeout
	{
		 get { } //Length: 6
		 set { } //Length: 1340
	}

	public ushort PacketSize
	{
		 get { } //Length: 6
	}

	public uint PingTimeout
	{
		 get { } //Length: 6
	}

	public bool UsePlatformSpecificProtocols
	{
		 get { } //Length: 6
		 set { } //Length: 92
	}

	public ConnectionConfig() { }

	public ConnectionConfig(ConnectionConfig config) { }

	public byte AddChannel(QosType value) { }

	public int get_ChannelCount() { }

	public List<ChannelQOS> get_Channels() { }

	public ushort get_FragmentSize() { }

	public ushort get_MaxCombinedReliableMessageSize() { }

	public uint get_MinUpdateTimeout() { }

	public ushort get_PacketSize() { }

	public uint get_PingTimeout() { }

	public bool get_UsePlatformSpecificProtocols() { }

	public void set_MinUpdateTimeout(uint value) { }

	public void set_UsePlatformSpecificProtocols(bool value) { }

	public static void Validate(ConnectionConfig config) { }

}

