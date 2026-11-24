namespace UnityEngine.Networking;

public class NetworkReader
{
	private const int k_MaxStringLength = 32768; //Field offset: 0x0
	private const int k_InitialStringBufferSize = 1024; //Field offset: 0x0
	private static byte[] s_StringReaderBuffer; //Field offset: 0x0
	private static Encoding s_Encoding; //Field offset: 0x4
	private NetBuffer m_buf; //Field offset: 0x8

	public int Length
	{
		 get { } //Length: 9
	}

	public uint Position
	{
		 get { } //Length: 6
	}

	public NetworkReader() { }

	public NetworkReader(NetworkWriter writer) { }

	public NetworkReader(byte[] buffer) { }

	public int get_Length() { }

	public uint get_Position() { }

	private static void Initialize() { }

	public bool ReadBoolean() { }

	public byte ReadByte() { }

	public byte[] ReadBytes(int count) { }

	public byte[] ReadBytesAndSize() { }

	public char ReadChar() { }

	public Color ReadColor() { }

	public Color32 ReadColor32() { }

	public decimal ReadDecimal() { }

	public double ReadDouble() { }

	public GameObject ReadGameObject() { }

	public short ReadInt16() { }

	public int ReadInt32() { }

	public long ReadInt64() { }

	public Matrix4x4 ReadMatrix4x4() { }

	public TMsg ReadMessage() { }

	public NetworkHash128 ReadNetworkHash128() { }

	public NetworkInstanceId ReadNetworkId() { }

	public NetworkIdentity ReadNetworkIdentity() { }

	public uint ReadPackedUInt32() { }

	public ulong ReadPackedUInt64() { }

	public Plane ReadPlane() { }

	public Quaternion ReadQuaternion() { }

	public Ray ReadRay() { }

	public Rect ReadRect() { }

	public sbyte ReadSByte() { }

	public NetworkSceneId ReadSceneId() { }

	public float ReadSingle() { }

	public string ReadString() { }

	public Transform ReadTransform() { }

	public ushort ReadUInt16() { }

	public uint ReadUInt32() { }

	public ulong ReadUInt64() { }

	public Vector2 ReadVector2() { }

	public Vector3 ReadVector3() { }

	public Vector4 ReadVector4() { }

	internal void Replace(byte[] buffer) { }

	public void SeekZero() { }

	public override string ToString() { }

}

