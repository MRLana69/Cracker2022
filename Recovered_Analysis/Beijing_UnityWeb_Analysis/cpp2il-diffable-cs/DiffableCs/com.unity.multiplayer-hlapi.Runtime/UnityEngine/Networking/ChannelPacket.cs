namespace UnityEngine.Networking;

internal struct ChannelPacket
{
	private int m_Position; //Field offset: 0x0
	private byte[] m_Buffer; //Field offset: 0x4
	private bool m_IsReliable; //Field offset: 0x8

	public ChannelPacket(int packetSize, bool isReliable) { }

	public bool HasSpace(int numBytes) { }

	public bool IsEmpty() { }

	public void Reset() { }

	public bool SendToTransport(NetworkConnection conn, int channelId) { }

	public void Write(byte[] bytes, int numBytes) { }

}

