//Type is in global namespace

public class TweenFill : UITweener
{
	public float from; //Field offset: 0x58
	public float to; //Field offset: 0x5C
	private bool mCached; //Field offset: 0x60
	private UIBasicSprite mSprite; //Field offset: 0x64

	public float value
	{
		 get { } //Length: 286
		 set { } //Length: 510
	}

	public TweenFill() { }

	public static TweenFill Begin(GameObject go, float duration, float fill) { }

	private void Cache() { }

	public float get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_value(float value) { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

