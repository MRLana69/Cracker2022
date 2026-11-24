//Type is in global namespace

public class TweenTransform : UITweener
{
	public Transform from; //Field offset: 0x58
	public Transform to; //Field offset: 0x5C
	public bool parentWhenFinished; //Field offset: 0x60
	private Transform mTrans; //Field offset: 0x64
	private Vector3 mPos; //Field offset: 0x68
	private Quaternion mRot; //Field offset: 0x74
	private Vector3 mScale; //Field offset: 0x84

	public TweenTransform() { }

	public static TweenTransform Begin(GameObject go, float duration, Transform to) { }

	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to) { }

	protected override void OnUpdate(float factor, bool isFinished) { }

}

