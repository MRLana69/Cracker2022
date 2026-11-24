//Type is in global namespace

public class TweenAlpha : UITweener
{
	public float from; //Field offset: 0x58
	public float to; //Field offset: 0x5C
	private bool mCached; //Field offset: 0x60
	private UIRect mRect; //Field offset: 0x64
	private Material mMat; //Field offset: 0x68
	private Light mLight; //Field offset: 0x6C
	private SpriteRenderer mSr; //Field offset: 0x70
	private float mBaseIntensity; //Field offset: 0x74

	public float alpha
	{
		 get { } //Length: 10
		 set { } //Length: 37
	}

	public float value
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public TweenAlpha() { }

	public static TweenAlpha Begin(GameObject go, float duration, float alpha, float delay = 0) { }

	private void Cache() { }

	public float get_alpha() { }

	public float get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_alpha(float value) { }

	public void set_value(float value) { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

