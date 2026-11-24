//Type is in global namespace

public class TweenColor : UITweener
{
	public Color from; //Field offset: 0x58
	public Color to; //Field offset: 0x68
	private bool mCached; //Field offset: 0x78
	private UIWidget mWidget; //Field offset: 0x7C
	private Material mMat; //Field offset: 0x80
	private Light mLight; //Field offset: 0x84
	private SpriteRenderer mSr; //Field offset: 0x88

	public Color color
	{
		 get { } //Length: 2
		 set { } //Length: 11
	}

	public Color value
	{
		 get { } //Length: 46
		 set { } //Length: 355
	}

	public TweenColor() { }

	public static TweenColor Begin(GameObject go, float duration, Color color) { }

	private void Cache() { }

	public Color get_color() { }

	public Color get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_color(Color value) { }

	public void set_value(Color value) { }

	private void SetCurrentValueToEnd() { }

	private void SetCurrentValueToStart() { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

