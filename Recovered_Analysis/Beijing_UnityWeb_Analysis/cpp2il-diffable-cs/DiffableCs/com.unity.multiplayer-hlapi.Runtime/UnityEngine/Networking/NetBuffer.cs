namespace UnityEngine.Networking;

internal class NetBuffer
{
	private const int k_InitialSize = 64; //Field offset: 0x0
	private const float k_GrowthFactor = 1.5; //Field offset: 0x0
	private const int k_BufferSizeWarning = 134217728; //Field offset: 0x0
	private byte[] m_Buffer; //Field offset: 0x8
	private uint m_Pos; //Field offset: 0xC

	public int Length
	{
		 get { } //Length: 6
	}

	public uint Position
	{
		 get { } //Length: 3
	}

	public NetBuffer() { }

	public NetBuffer(byte[] buffer) { }

	internal ArraySegment<byte> AsArraySegment() { }

	public void FinishMessage() { }

	public int get_Length() { }

	public uint get_Position() { }

	public byte ReadByte() { }

	public void ReadBytes(byte[] buffer, uint count) { }

	public void Replace(byte[] buffer) { }

	public void SeekZero() { }

	public override string ToString() { }

	public void WriteByte(byte value) { }

	public void WriteByte2(byte value0, byte value1) { }

	public void WriteByte4(byte value0, byte value1, byte value2, byte value3) { }

	public void WriteByte8(byte value0, byte value1, byte value2, byte value3, byte value4, byte value5, byte value6, byte value7) { }

	public void WriteBytes(byte[] buffer, ushort count) { }

	public void WriteBytesAtOffset(byte[] buffer, ushort targetOffset, ushort count) { }

	private void WriteCheckForSpace(ushort count) { }

}

