namespace SYBO.Subway.StateSystem.States.Settings;

public class PogostickStateSettings
{
	public class PickupWeight
	{
		public UpgradeType UpgradeType; //Field offset: 0x8
		public PickupType PickupType; //Field offset: 0xC

		public PickupWeight() { }

	}

	private float _jumpHeight; //Field offset: 0xC
	private float _jumpDistance; //Field offset: 0x10
	private float _characterChangeTrackLength; //Field offset: 0x14
	private float _finalJumpSpeed; //Field offset: 0x18
	private int _rows; //Field offset: 0x1C
	private int _startRowPosition; //Field offset: 0x20
	private int _endRowPosition; //Field offset: 0x24
	private PickupWeight[] _pickupList; //Field offset: 0x28
	private AnimationCurve _jumpCurve; //Field offset: 0x2C
	private AnimationCurve _cameraCurve; //Field offset: 0x30
	private AnimationCurve _cameraAimFollowCurve; //Field offset: 0x34
	private float _fadeInPosition; //Field offset: 0x38
	private float _hangtimePosition; //Field offset: 0x3C
	private float _smoothCameraXDuration; //Field offset: 0x40
	private Vector3 _cameraAimOffset; //Field offset: 0x44

	public AnimationCurve CameraAimFollowCurve
	{
		 get { } //Length: 6
	}

	public Vector3 CameraAimOffset
	{
		 get { } //Length: 122
	}

	public AnimationCurve CameraCurve
	{
		 get { } //Length: 6
	}

	public float CharacterChangeTrackLength
	{
		 get { } //Length: 6
	}

	public int EndRowPosition
	{
		 get { } //Length: 6
	}

	public float FadeInPosition
	{
		 get { } //Length: 6
	}

	public float FinalJumpSpeed
	{
		 get { } //Length: 6
	}

	public float HangtimePosition
	{
		 get { } //Length: 6
	}

	public AnimationCurve JumpCurve
	{
		 get { } //Length: 6
	}

	public float JumpDistance
	{
		 get { } //Length: 6
	}

	public float JumpHeight
	{
		 get { } //Length: 6
	}

	public PickupWeight[] PickupList
	{
		 get { } //Length: 6
	}

	public int Rows
	{
		 get { } //Length: 6
	}

	public float SmoothCameraXDuration
	{
		 get { } //Length: 6
	}

	public int StartRowPosition
	{
		 get { } //Length: 6
	}

	public PogostickStateSettings() { }

	public AnimationCurve get_CameraAimFollowCurve() { }

	public Vector3 get_CameraAimOffset() { }

	public AnimationCurve get_CameraCurve() { }

	public float get_CharacterChangeTrackLength() { }

	public int get_EndRowPosition() { }

	public float get_FadeInPosition() { }

	public float get_FinalJumpSpeed() { }

	public float get_HangtimePosition() { }

	public AnimationCurve get_JumpCurve() { }

	public float get_JumpDistance() { }

	public float get_JumpHeight() { }

	public PickupWeight[] get_PickupList() { }

	public int get_Rows() { }

	public float get_SmoothCameraXDuration() { }

	public int get_StartRowPosition() { }

}

