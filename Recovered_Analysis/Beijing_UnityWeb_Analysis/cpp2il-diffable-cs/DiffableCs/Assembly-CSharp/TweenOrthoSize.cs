//Type is in global namespace

public class TweenOrthoSize : UITweener
{
	public float from; //Field offset: 0x58
	public float to; //Field offset: 0x5C
	private Camera mCam; //Field offset: 0x60

	public Camera cachedCamera
	{
		 get { } //Length: 12
	}

	public float orthoSize
	{
		 get { } //Length: 15
		 set { } //Length: 17
	}

	public float value
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public TweenOrthoSize() { }

	public static TweenOrthoSize Begin(GameObject go, float duration, float to) { }

	public Camera get_cachedCamera() { }

	public float get_orthoSize() { }

	public float get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_orthoSize(float value) { }

	public void set_value(float value) { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

