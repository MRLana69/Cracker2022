//Type is in global namespace

public class TweenFOV : UITweener
{
	public float from; //Field offset: 0x58
	public float to; //Field offset: 0x5C
	private Camera mCam; //Field offset: 0x60

	public Camera cachedCamera
	{
		 get { } //Length: 3
	}

	public float fov
	{
		 get { } //Length: 119
		 set { } //Length: 117
	}

	public float value
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public TweenFOV() { }

	public static TweenFOV Begin(GameObject go, float duration, float to) { }

	public Camera get_cachedCamera() { }

	public float get_fov() { }

	public float get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_fov(float value) { }

	public void set_value(float value) { }

	private void SetCurrentValueToEnd() { }

	private void SetCurrentValueToStart() { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

