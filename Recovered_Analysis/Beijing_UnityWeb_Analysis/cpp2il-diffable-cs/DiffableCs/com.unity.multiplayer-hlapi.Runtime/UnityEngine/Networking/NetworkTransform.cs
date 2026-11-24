namespace UnityEngine.Networking;

public class NetworkTransform : NetworkBehaviour
{
	public enum AxisSyncMode
	{
		None = 0,
		AxisX = 1,
		AxisY = 2,
		AxisZ = 3,
		AxisXY = 4,
		AxisXZ = 5,
		AxisYZ = 6,
		AxisXYZ = 7,
	}

	public delegate ClientMoveCallback2D
	{

		public ClientMoveCallback2D(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(ref Vector2 position, ref Vector2 velocity, ref float rotation, AsyncCallback callback, object object) { }

		public virtual bool EndInvoke(ref Vector2 position, ref Vector2 velocity, ref float rotation, IAsyncResult result) { }

		public virtual bool Invoke(ref Vector2 position, ref Vector2 velocity, ref float rotation) { }

	}

	public delegate ClientMoveCallback3D
	{

		public ClientMoveCallback3D(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(ref Vector3 position, ref Vector3 velocity, ref Quaternion rotation, AsyncCallback callback, object object) { }

		public virtual bool EndInvoke(ref Vector3 position, ref Vector3 velocity, ref Quaternion rotation, IAsyncResult result) { }

		public virtual bool Invoke(ref Vector3 position, ref Vector3 velocity, ref Quaternion rotation) { }

	}

	public enum CompressionSyncMode
	{
		None = 0,
		Low = 1,
		High = 2,
	}

	public enum TransformSyncMode
	{
		SyncNone = 0,
		SyncTransform = 1,
		SyncRigidbody2D = 2,
		SyncRigidbody3D = 3,
		SyncCharacterController = 4,
	}

	private const float k_LocalMovementThreshold = 1E-05; //Field offset: 0x0
	private const float k_LocalVelocityThreshold = 1E-05; //Field offset: 0x0
	private const float k_MoveAheadRatio = 0.1; //Field offset: 0x0
	private const float k_LocalRotationThreshold = 1E-05; //Field offset: 0x0
	private TransformSyncMode m_TransformSyncMode; //Field offset: 0x1C
	private float m_SendInterval; //Field offset: 0x20
	private AxisSyncMode m_SyncRotationAxis; //Field offset: 0x24
	private CompressionSyncMode m_RotationSyncCompression; //Field offset: 0x28
	private bool m_SyncSpin; //Field offset: 0x2C
	private float m_MovementTheshold; //Field offset: 0x30
	private float m_VelocityThreshold; //Field offset: 0x34
	private float m_SnapThreshold; //Field offset: 0x38
	private float m_InterpolateRotation; //Field offset: 0x3C
	private float m_InterpolateMovement; //Field offset: 0x40
	private ClientMoveCallback3D m_ClientMoveCallback3D; //Field offset: 0x44
	private ClientMoveCallback2D m_ClientMoveCallback2D; //Field offset: 0x48
	private Rigidbody m_RigidBody3D; //Field offset: 0x4C
	private Rigidbody2D m_RigidBody2D; //Field offset: 0x50
	private CharacterController m_CharacterController; //Field offset: 0x54
	private bool m_Grounded; //Field offset: 0x58
	private Vector3 m_TargetSyncPosition; //Field offset: 0x5C
	private Vector3 m_TargetSyncVelocity; //Field offset: 0x68
	private Vector3 m_FixedPosDiff; //Field offset: 0x74
	private Quaternion m_TargetSyncRotation3D; //Field offset: 0x80
	private Vector3 m_TargetSyncAngularVelocity3D; //Field offset: 0x90
	private float m_TargetSyncRotation2D; //Field offset: 0x9C
	private float m_TargetSyncAngularVelocity2D; //Field offset: 0xA0
	private float m_LastClientSyncTime; //Field offset: 0xA4
	private float m_LastClientSendTime; //Field offset: 0xA8
	private Vector3 m_PrevPosition; //Field offset: 0xAC
	private Quaternion m_PrevRotation; //Field offset: 0xB8
	private float m_PrevRotation2D; //Field offset: 0xC8
	private float m_PrevVelocity; //Field offset: 0xCC
	private NetworkWriter m_LocalTransformWriter; //Field offset: 0xD0

	public CharacterController characterContoller
	{
		 get { } //Length: 6
	}

	public ClientMoveCallback2D clientMoveCallback2D
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public ClientMoveCallback3D clientMoveCallback3D
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool grounded
	{
		 get { } //Length: 6
		 set { } //Length: 27
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
		 get { } //Length: 9
	}

	public float movementTheshold
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Rigidbody2D rigidbody2D
	{
		 get { } //Length: 6
	}

	public Rigidbody rigidbody3D
	{
		 get { } //Length: 6
	}

	public CompressionSyncMode rotationSyncCompression
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float sendInterval
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float snapThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public AxisSyncMode syncRotationAxis
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool syncSpin
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Vector3 targetSyncPosition
	{
		 get { } //Length: 12
	}

	public float targetSyncRotation2D
	{
		 get { } //Length: 7
	}

	public Quaternion targetSyncRotation3D
	{
		 get { } //Length: 27
	}

	public Vector3 targetSyncVelocity
	{
		 get { } //Length: 27
	}

	public TransformSyncMode transformSyncMode
	{
		 get { } //Length: 3
		 set { } //Length: 256
	}

	public float velocityThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public NetworkTransform() { }

	private void Awake() { }

	private bool CheckVelocityChanged() { }

	private void FixedUpdate() { }

	private void FixedUpdateClient() { }

	private void FixedUpdateServer() { }

	public CharacterController get_characterContoller() { }

	public ClientMoveCallback2D get_clientMoveCallback2D() { }

	public ClientMoveCallback3D get_clientMoveCallback3D() { }

	public bool get_grounded() { }

	public float get_interpolateMovement() { }

	public float get_interpolateRotation() { }

	public float get_lastSyncTime() { }

	public float get_movementTheshold() { }

	public Rigidbody2D get_rigidbody2D() { }

	public Rigidbody get_rigidbody3D() { }

	public CompressionSyncMode get_rotationSyncCompression() { }

	public float get_sendInterval() { }

	public float get_snapThreshold() { }

	public AxisSyncMode get_syncRotationAxis() { }

	public bool get_syncSpin() { }

	public Vector3 get_targetSyncPosition() { }

	public float get_targetSyncRotation2D() { }

	public Quaternion get_targetSyncRotation3D() { }

	public Vector3 get_targetSyncVelocity() { }

	public TransformSyncMode get_transformSyncMode() { }

	public float get_velocityThreshold() { }

	public override int GetNetworkChannel() { }

	public override float GetNetworkSendInterval() { }

	public static void HandleTransform(NetworkMessage netMsg) { }

	private bool HasMoved() { }

	private void InterpolateTransformMode2D() { }

	private void InterpolateTransformMode3D() { }

	private void InterpolateTransformModeCharacterController() { }

	public override void OnDeserialize(NetworkReader reader, bool initialState) { }

	public override bool OnSerialize(NetworkWriter writer, bool initialState) { }

	public override void OnStartAuthority() { }

	public override void OnStartServer() { }

	private void OnValidate() { }

	private static float ReadAngle(NetworkReader reader, CompressionSyncMode compression) { }

	private void SendTransform() { }

	private void SerializeMode2D(NetworkWriter writer) { }

	private void SerializeMode3D(NetworkWriter writer) { }

	private void SerializeModeCharacterController(NetworkWriter writer) { }

	private void SerializeModeTransform(NetworkWriter writer) { }

	public static void SerializeRotation2D(NetworkWriter writer, float rot, CompressionSyncMode compression) { }

	public static void SerializeRotation3D(NetworkWriter writer, Quaternion rot, AxisSyncMode mode, CompressionSyncMode compression) { }

	public static void SerializeSpin2D(NetworkWriter writer, float angularVelocity, CompressionSyncMode compression) { }

	public static void SerializeSpin3D(NetworkWriter writer, Vector3 angularVelocity, AxisSyncMode mode, CompressionSyncMode compression) { }

	public static void SerializeVelocity2D(NetworkWriter writer, Vector2 velocity, CompressionSyncMode compression) { }

	public static void SerializeVelocity3D(NetworkWriter writer, Vector3 velocity, CompressionSyncMode compression) { }

	public void set_clientMoveCallback2D(ClientMoveCallback2D value) { }

	public void set_clientMoveCallback3D(ClientMoveCallback3D value) { }

	public void set_grounded(bool value) { }

	public void set_interpolateMovement(float value) { }

	public void set_interpolateRotation(float value) { }

	public void set_movementTheshold(float value) { }

	public void set_rotationSyncCompression(CompressionSyncMode value) { }

	public void set_sendInterval(float value) { }

	public void set_snapThreshold(float value) { }

	public void set_syncRotationAxis(AxisSyncMode value) { }

	public void set_syncSpin(bool value) { }

	public void set_transformSyncMode(TransformSyncMode value) { }

	public void set_velocityThreshold(float value) { }

	private void UnserializeMode2D(NetworkReader reader, bool initialState) { }

	private void UnserializeMode3D(NetworkReader reader, bool initialState) { }

	private void UnserializeModeCharacterController(NetworkReader reader, bool initialState) { }

	private void UnserializeModeTransform(NetworkReader reader, bool initialState) { }

	public static float UnserializeRotation2D(NetworkReader reader, CompressionSyncMode compression) { }

	public static Quaternion UnserializeRotation3D(NetworkReader reader, AxisSyncMode mode, CompressionSyncMode compression) { }

	public static float UnserializeSpin2D(NetworkReader reader, CompressionSyncMode compression) { }

	public static Vector3 UnserializeSpin3D(NetworkReader reader, AxisSyncMode mode, CompressionSyncMode compression) { }

	public static Vector3 UnserializeVelocity2D(NetworkReader reader, CompressionSyncMode compression) { }

	public static Vector3 UnserializeVelocity3D(NetworkReader reader, CompressionSyncMode compression) { }

	private void Update() { }

	private void VerifySerializeComponentExists() { }

	private static void WriteAngle(NetworkWriter writer, float angle, CompressionSyncMode compression) { }

}

