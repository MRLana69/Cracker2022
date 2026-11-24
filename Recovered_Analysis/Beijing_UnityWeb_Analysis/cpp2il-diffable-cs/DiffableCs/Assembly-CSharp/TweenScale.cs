//Type is in global namespace

public class TweenScale : UITweener
{
	public Vector3 from; //Field offset: 0x58
	public Vector3 to; //Field offset: 0x64
	public bool updateTable; //Field offset: 0x70
	private Transform mTrans; //Field offset: 0x74
	private UITable mTable; //Field offset: 0x78

	public Transform cachedTransform
	{
		 get { } //Length: 109
	}

	public Vector3 scale
	{
		 get { } //Length: 52
		 set { } //Length: 11
	}

	public Vector3 value
	{
		 get { } //Length: 52
		 set { } //Length: 17
	}

	public TweenScale() { }

	public static TweenScale Begin(GameObject go, float duration, Vector3 scale) { }

	public Transform get_cachedTransform() { }

	public Vector3 get_scale() { }

	public Vector3 get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_scale(Vector3 value) { }

	public void set_value(Vector3 value) { }

	private void SetCurrentValueToEnd() { }

	private void SetCurrentValueToStart() { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

