namespace SYBO.Subway.Cameras;

public class CameraData
{
	public static readonly CameraDataMode CAMERA_MODE_DEFAULT; //Field offset: 0x0
	public static readonly float FIELD_OF_VIEW_DEFAULT; //Field offset: 0x4
	public static readonly Vector3 CAMERA_TARGET_OFFSET_DEFAULT; //Field offset: 0x8
	public static readonly Vector3 CAMERA_POSITION_OFFSET_DEFAULT; //Field offset: 0x14
	public static readonly Vector3 CAMERA_TARGET_OFFSET_SMOOTH_TIME_DEFAULT; //Field offset: 0x20
	public static readonly Vector3 CAMERA_POSITION_OFFSET_SMOOTH_TIME_DEFAULT; //Field offset: 0x2C
	public static readonly float TRANSFORM_TWEEN_DURATION; //Field offset: 0x38
	public static readonly float FIELD_OF_VIEW_SMOOTH_TIME_DEFAULT; //Field offset: 0x3C
	internal CameraDataMode _cameraDataMode; //Field offset: 0x8
	internal bool _useLastGroundedY; //Field offset: 0xC
	internal bool _dontMoveInY; //Field offset: 0xD
	internal SmoothDampFloat _fieldOfView; //Field offset: 0x10
	internal Vector3 _cameraTargetOffset; //Field offset: 0x14
	internal Vector3 _cameraTargetOffsetSmoothTime; //Field offset: 0x20
	internal Vector3 _cameraPositionOffset; //Field offset: 0x2C
	internal Vector3 _cameraPositionOffsetSmoothTime; //Field offset: 0x38
	private float _transformTweenDuration; //Field offset: 0x44

	public CameraDataMode CameraDataMode
	{
		 get { } //Length: 66
		internal set { } //Length: 17
	}

	public Vector3 CameraPositionOffset
	{
		 get { } //Length: 26
		 set { } //Length: 26
	}

	public Vector3 CameraPositionOffsetSmoothTime
	{
		 get { } //Length: 61
	}

	public Vector3 CameraTargetOffset
	{
		 get { } //Length: 11
	}

	public Vector3 CameraTargetOffsetSmoothTime
	{
		 get { } //Length: 26
	}

	public bool DontMoveInY
	{
		 get { } //Length: 9
	}

	public SmoothDampFloat FieldOfView
	{
		 get { } //Length: 9
		 set { } //Length: 8
	}

	public float TransformTweenDuration
	{
		 get { } //Length: 14
	}

	public bool UseLastGroundedY
	{
		 get { } //Length: 6
	}

	private static CameraData() { }

	public CameraData() { }

	public CameraDataMode get_CameraDataMode() { }

	public Vector3 get_CameraPositionOffset() { }

	public Vector3 get_CameraPositionOffsetSmoothTime() { }

	public Vector3 get_CameraTargetOffset() { }

	public Vector3 get_CameraTargetOffsetSmoothTime() { }

	public bool get_DontMoveInY() { }

	public SmoothDampFloat get_FieldOfView() { }

	public float get_TransformTweenDuration() { }

	public bool get_UseLastGroundedY() { }

	internal void set_CameraDataMode(CameraDataMode value) { }

	public void set_CameraPositionOffset(Vector3 value) { }

	public void set_FieldOfView(SmoothDampFloat value) { }

}

