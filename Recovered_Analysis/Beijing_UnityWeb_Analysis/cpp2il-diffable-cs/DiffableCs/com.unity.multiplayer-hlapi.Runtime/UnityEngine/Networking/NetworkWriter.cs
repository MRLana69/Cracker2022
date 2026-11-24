namespace UnityEngine.Networking;

public class NetworkWriter
{
	private const int k_MaxStringLength = 32768; //Field offset: 0x0
	private static Encoding s_Encoding; //Field offset: 0x0
	private static byte[] s_StringWriteBuffer; //Field offset: 0x4
	private static UIntFloat s_FloatConverter; //Field offset: 0x8
	private NetBuffer m_Buffer; //Field offset: 0x8

	public short Position
	{
		 get { } //Length: 6
	}

	public NetworkWriter() { }

	public NetworkWriter(byte[] buffer) { }

	public byte[] AsArray() { }

	internal ArraySegment<byte> AsArraySegment() { }

	public void FinishMessage() { }

	public short get_Position() { }

	public void SeekZero() { }

	public void StartMessage(short msgType) { }

	public byte[] ToArray() { }

	public void Write(Transform value) { }

	public void Write(NetworkIdentity value) { }

	public void Write(NetworkHash128 value) { }

	public void Write(Matrix4x4 value) { }

	public void Write(Ray value) { }

	public void Write(MessageBase msg) { }

	public void Write(Rect value) { }

	public void Write(Quaternion value) { }

	public void Write(Color32 value) { }

	public void Write(Color value) { }

	public void Write(Vector4 value) { }

	public void Write(Vector3 value) { }

	public void Write(Vector2 value) { }

	public void Write(GameObject value) { }

	public void Write(Plane value) { }

	public void Write(byte[] buffer, int offset, int count) { }

	public void Write(bool value) { }

	public void Write(NetworkInstanceId value) { }

	public void Write(NetworkSceneId value) { }

	public void Write(char value) { }

	public void Write(byte value) { }

	public void Write(sbyte value) { }

	public void Write(short value) { }

	public void Write(byte[] buffer, int count) { }

	public void Write(int value) { }

	public void Write(ushort value) { }

	public void Write(long value) { }

	public void Write(ulong value) { }

	public void Write(float value) { }

	public void Write(double value) { }

	public void Write(decimal value) { }

	public void Write(uint value) { }

	public void Write(string value) { }

	public void WriteBytesAndSize(byte[] buffer, int count) { }

	public void WriteBytesFull(byte[] buffer) { }

	public void WritePackedUInt32(uint value) { }

	public void WritePackedUInt64(ulong value) { }

}

