namespace UnityEngine.Networking;

public class GlobalConfig
{
	private const uint g_MaxTimerTimeout = 12000; //Field offset: 0x0
	private const uint g_MaxNetSimulatorTimeout = 12000; //Field offset: 0x0
	private const ushort g_MaxHosts = 128; //Field offset: 0x0
	private uint m_ThreadAwakeTimeout; //Field offset: 0x8
	private ReactorModel m_ReactorModel; //Field offset: 0xC
	private ushort m_ReactorMaximumReceivedMessages; //Field offset: 0x10
	private ushort m_ReactorMaximumSentMessages; //Field offset: 0x12
	private ushort m_MaxPacketSize; //Field offset: 0x14
	private ushort m_MaxHosts; //Field offset: 0x16
	private byte m_ThreadPoolSize; //Field offset: 0x18
	private uint m_MinTimerTimeout; //Field offset: 0x1C
	private uint m_MaxTimerTimeout; //Field offset: 0x20
	private uint m_MinNetSimulatorTimeout; //Field offset: 0x24
	private uint m_MaxNetSimulatorTimeout; //Field offset: 0x28
	private Action<int, int> m_ConnectionReadyForSend; //Field offset: 0x2C
	private Action<int> m_NetworkEventAvailable; //Field offset: 0x30

	public uint ThreadAwakeTimeout
	{
		 get { } //Length: 6
		 set { } //Length: 109
	}

	public GlobalConfig() { }

	public uint get_ThreadAwakeTimeout() { }

	public void set_ThreadAwakeTimeout(uint value) { }

}

