namespace UnityEngine.Networking;

public class NetworkTransformChild : NetworkBehaviour
{
	private const float k_LocalRotationThreshold = 1E-05; //Field offset: 0x0
	private const float k_LocalMovementThreshold = 1E-05; //Field offset: 0x0
	private Transform m_Target; //Field offset: 0x1C
	private uint m_ChildIndex; //Field offset: 0x20
	private NetworkTransform m_Root; //Field offset: 0x24
	private float m_SendInterval; //Field offset: 0x28
	private AxisSyncMode m_SyncRotationAxis; //Field offset: 0x2C
	private CompressionSyncMode m_RotationSyncCompression; //Field offset: 0x30
	private float m_MovementThreshold; //Field offset: 0x34
	private float m_InterpolateRotation; //Field offset: 0x38
	private float m_InterpolateMovement; //Field offset: 0x3C
	private ClientMoveCallback3D m_ClientMoveCallback3D; //Field offset: 0x40
	private Vector3 m_TargetSyncPosition; //Field offset: 0x44
	private Quaternion m_TargetSyncRotation3D; //Field offset: 0x50
	private float m_LastClientSyncTime; //Field offset: 0x60
	private float m_LastClientSendTime; //Field offset: 0x64
	private Vector3 m_PrevPosition; //Field offset: 0x68
	private Quaternion m_PrevRotation; //Field offset: 0x74
	private NetworkWriter m_LocalTransformWriter; //Field offset: 0x84

	public uint childIndex
	{
		 get { } //Length: 6
	}

	public ClientMoveCallback3D clientMoveCallback3D
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float interpolateMovement
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float interpolateRotation
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float lastSyncTime
	{
		 get { } //Length: 6
	}

	public float movementThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public CompressionSyncMode rotationSyncCompression
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float sendInterval
	{
		 get { } //Length: 15
		 set { } //Length: 191
	}

	public AxisSyncMode syncRotationAxis
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public Transform target
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Vector3 targetSyncPosition
	{
		 get { } //Length: 11
	}

	public Quaternion targetSyncRotation3D
	{
		 get { } //Length: 27
	}

	public NetworkTransformChild() { }

	private void Awake() { }

	private void FixedUpdate() { }

	private void FixedUpdateClient() { }

	private void FixedUpdateServer() { }

	public uint get_childIndex() { }

	public ClientMoveCallback3D get_clientMoveCallback3D() { }

	public float get_interpolateMovement() { }

	public float get_interpolateRotation() { }

	public float get_lastSyncTime() { }

	public float get_movementThreshold() { }

	public CompressionSyncMode get_rotationSyncCompression() { }

	public float get_sendInterval() { }

	public AxisSyncMode get_syncRotationAxis() { }

	public Transform get_target() { }

	public Vector3 get_targetSyncPosition() { }

	public Quaternion get_targetSyncRotation3D() { }

	public override int GetNetworkChannel() { }

	public override float GetNetworkSendInterval() { }

	internal static void HandleChildTransform(NetworkMessage netMsg) { }

	private bool HasMoved() { }

	public override void OnDeserialize(NetworkReader reader, bool initialState) { }

	public override bool OnSerialize(NetworkWriter writer, bool initialState) { }

	private void OnValidate() { }

	private void SendTransform() { }

	private void SerializeModeTransform(NetworkWriter writer) { }

	public void set_clientMoveCallback3D(ClientMoveCallback3D value) { }

	public void set_interpolateMovement(float value) { }

	public void set_interpolateRotation(float value) { }

	public void set_movementThreshold(float value) { }

	public void set_rotationSyncCompression(CompressionSyncMode value) { }

	public void set_sendInterval(float value) { }

	public void set_syncRotationAxis(AxisSyncMode value) { }

	public void set_target(Transform value) { }

	private void UnserializeModeTransform(NetworkReader reader, bool initialState) { }

	private void Update() { }

}

