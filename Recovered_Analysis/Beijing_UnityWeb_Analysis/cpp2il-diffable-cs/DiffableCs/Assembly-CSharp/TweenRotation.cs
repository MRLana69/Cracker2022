//Type is in global namespace

public class TweenRotation : UITweener
{
	public Vector3 from; //Field offset: 0x58
	public Vector3 to; //Field offset: 0x64
	public bool quaternionLerp; //Field offset: 0x70
	private Transform mTrans; //Field offset: 0x74

	public Transform cachedTransform
	{
		 get { } //Length: 109
	}

	public Quaternion rotation
	{
		 get { } //Length: 449
		 set { } //Length: 11
	}

	public Quaternion value
	{
		 get { } //Length: 46
		 set { } //Length: 17
	}

	public TweenRotation() { }

	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot) { }

	public Transform get_cachedTransform() { }

	public Quaternion get_rotation() { }

	public Quaternion get_value() { }

	protected override void OnUpdate(float factor, bool isFinished) { }

	public void set_rotation(Quaternion value) { }

	public void set_value(Quaternion value) { }

	private void SetCurrentValueToEnd() { }

	private void SetCurrentValueToStart() { }

	public override void SetEndToCurrentValue() { }

	public override void SetStartToCurrentValue() { }

}

