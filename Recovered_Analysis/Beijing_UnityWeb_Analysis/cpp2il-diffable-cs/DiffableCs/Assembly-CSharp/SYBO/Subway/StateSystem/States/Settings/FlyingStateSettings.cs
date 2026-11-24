namespace SYBO.Subway.StateSystem.States.Settings;

public class FlyingStateSettings
{
	private float _characterChangeTrackLength; //Field offset: 0xC
	private float _flyHeight; //Field offset: 0x10
	private float _flyAheadDuration; //Field offset: 0x14
	private float _stopBeforeLandingChunkDistance; //Field offset: 0x18
	private float _smoothCameraXDuration; //Field offset: 0x1C
	private float _smoothYDuration; //Field offset: 0x20
	private float _cameraAimOffsetY; //Field offset: 0x24
	private AnimationCurve _flyAheadCameraMovement; //Field offset: 0x28

	public float CameraAimOffsetY
	{
		 get { } //Length: 6
	}

	public float CharacterChangeTrackLength
	{
		 get { } //Length: 18
	}

	public AnimationCurve FlyAheadCameraMovement
	{
		 get { } //Length: 3
	}

	public float FlyAheadDuration
	{
		 get { } //Length: 6
	}

	public float FlyHeight
	{
		 get { } //Length: 6
	}

	public float SmoothCameraXDuration
	{
		 get { } //Length: 6
	}

	public float SmoothYDuration
	{
		 get { } //Length: 6
	}

	public float StopBeforeLandingChunkDistance
	{
		 get { } //Length: 6
	}

	public FlyingStateSettings() { }

	public float get_CameraAimOffsetY() { }

	public float get_CharacterChangeTrackLength() { }

	public AnimationCurve get_FlyAheadCameraMovement() { }

	public float get_FlyAheadDuration() { }

	public float get_FlyHeight() { }

	public float get_SmoothCameraXDuration() { }

	public float get_SmoothYDuration() { }

	public float get_StopBeforeLandingChunkDistance() { }

}

