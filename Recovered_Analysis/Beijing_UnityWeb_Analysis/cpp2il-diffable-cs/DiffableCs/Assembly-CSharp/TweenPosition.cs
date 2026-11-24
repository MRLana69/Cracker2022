//Type is in global namespace

public class TweenPosition : UITweener
{
	public Vector3 from; //Field offset: 0x58
	public Vector3 to; //Field offset: 0x64
	public bool worldSpace; //Field offset: 0x70
	private Transform mTrans; //Field offset: 0x74
	private UIRect mRect; //Field offset: 0x78

	public Transform cachedTransform
	{
		 get { } //Length: 115
	}

	public Vector3 position
	{
		 get { } //Length: 354
		 set { } //Length: 11
	}

	public Vector3 value
	{
		 get { } //Length: 46
		 set { } //Length: 43
	}

	public TweenPosition() { }

	private void Awake() { }

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos) { }

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace) { }

	public Transform get_cachedTransform() { }

	public Vector3 get_position() { }

	public Vector3 get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_position(Vector3 value) { }

	public void set_value(Vector3 value) { }

	private void SetCurrentValueToEnd() { }

	private void SetCurrentValueToStart() { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

