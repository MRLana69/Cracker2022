namespace UnityEngine.Networking;

internal class ChannelBuffer : IDisposable
{
	private const int k_PacketHeaderReserveSize = 100; //Field offset: 0x0
	private static List<ChannelPacket> s_FreePackets; //Field offset: 0x0
	public const int MaxBufferedPackets = 512; //Field offset: 0x0
	public const int MaxPendingPacketCount = 16; //Field offset: 0x0
	private const int k_MaxFreePacketCount = 512; //Field offset: 0x0
	internal static int pendingPacketCount; //Field offset: 0x4
	private static NetworkWriter s_SendWriter; //Field offset: 0x8
	private static NetworkWriter s_FragmentWriter; //Field offset: 0xC
	private NetworkConnection m_Connection; //Field offset: 0x8
	private ChannelPacket m_CurrentPacket; //Field offset: 0xC
	private float m_LastFlushTime; //Field offset: 0x18
	private byte m_ChannelId; //Field offset: 0x1C
	private int m_MaxPacketSize; //Field offset: 0x20
	private bool m_IsReliable; //Field offset: 0x24
	private bool m_AllowFragmentation; //Field offset: 0x25
	private bool m_IsBroken; //Field offset: 0x26
	private int m_MaxPendingPacketCount; //Field offset: 0x28
	private Queue<ChannelPacket> m_PendingPackets; //Field offset: 0x2C
	public float maxDelay; //Field offset: 0x30
	private float m_LastBufferedMessageCountTimer; //Field offset: 0x34
	private int <numMsgsOut>k__BackingField; //Field offset: 0x38
	private int <numBufferedMsgsOut>k__BackingField; //Field offset: 0x3C
	private int <numBytesOut>k__BackingField; //Field offset: 0x40
	private int <numMsgsIn>k__BackingField; //Field offset: 0x44
	private int <numBytesIn>k__BackingField; //Field offset: 0x48
	private int <numBufferedPerSecond>k__BackingField; //Field offset: 0x4C
	private int <lastBufferedPerSecond>k__BackingField; //Field offset: 0x50
	private bool m_Disposed; //Field offset: 0x54
	internal NetBuffer fragmentBuffer; //Field offset: 0x58
	private bool readingFragment; //Field offset: 0x5C

	public int lastBufferedPerSecond
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int numBufferedMsgsOut
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int numBufferedPerSecond
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int numBytesIn
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int numBytesOut
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public int numMsgsIn
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public int numMsgsOut
	{
		 get { } //Length: 23
		private set { } //Length: 8
	}

	private static ChannelBuffer() { }

	public ChannelBuffer(NetworkConnection conn, int bufferSize, byte cid, bool isReliable, bool isSequenced) { }

	private ChannelPacket AllocPacket() { }

	public void CheckInternalBuffer() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	private static void FreePacket(ChannelPacket packet) { }

	public int get_lastBufferedPerSecond() { }

	public int get_numBufferedMsgsOut() { }

	public int get_numBufferedPerSecond() { }

	public int get_numBytesIn() { }

	public int get_numBytesOut() { }

	public int get_numMsgsIn() { }

	public int get_numMsgsOut() { }

	internal bool HandleFragment(NetworkReader reader) { }

	private void QueuePacket() { }

	public bool Send(short msgType, MessageBase msg) { }

	internal bool SendBytes(byte[] bytes, int bytesToSend) { }

	internal bool SendFragmentBytes(byte[] bytes, int bytesToSend) { }

	public bool SendInternalBuffer() { }

	public bool SendWriter(NetworkWriter writer) { }

	private void set_lastBufferedPerSecond(int value) { }

	private void set_numBufferedMsgsOut(int value) { }

	private void set_numBufferedPerSecond(int value) { }

	private void set_numBytesIn(int value) { }

	private void set_numBytesOut(int value) { }

	private void set_numMsgsIn(int value) { }

	private void set_numMsgsOut(int value) { }

	public bool SetOption(ChannelOption option, int value) { }

}

