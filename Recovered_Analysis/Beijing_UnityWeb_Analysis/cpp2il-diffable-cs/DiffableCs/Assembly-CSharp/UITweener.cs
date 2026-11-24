//Type is in global namespace

public abstract class UITweener : MonoBehaviour
{
	public enum Method
	{
		Linear = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
		BounceIn = 4,
		BounceOut = 5,
	}

	public enum Style
	{
		Once = 0,
		Loop = 1,
		PingPong = 2,
	}

	public static UITweener current; //Field offset: 0x0
	public Method method; //Field offset: 0xC
	public Style style; //Field offset: 0x10
	public AnimationCurve animationCurve; //Field offset: 0x14
	public bool ignoreTimeScale; //Field offset: 0x18
	public float delay; //Field offset: 0x1C
	public float duration; //Field offset: 0x20
	public bool steeperCurves; //Field offset: 0x24
	public int tweenGroup; //Field offset: 0x28
	public bool useFixedUpdate; //Field offset: 0x2C
	public List<EventDelegate> onFinished; //Field offset: 0x30
	public GameObject eventReceiver; //Field offset: 0x34
	public string callWhenFinished; //Field offset: 0x38
	public float timeScale; //Field offset: 0x3C
	private bool mStarted; //Field offset: 0x40
	private float mStartTime; //Field offset: 0x44
	private float mDuration; //Field offset: 0x48
	private float mAmountPerDelta; //Field offset: 0x4C
	private float mFactor; //Field offset: 0x50
	private List<EventDelegate> mTemp; //Field offset: 0x54

	public float amountPerDelta
	{
		 get { } //Length: 107
	}

	public Direction direction
	{
		 get { } //Length: 12
	}

	public float tweenFactor
	{
		 get { } //Length: 167
		 set { } //Length: 103
	}

	protected UITweener() { }

	public void AddOnFinished(EventDelegate del) { }

	public void AddOnFinished(Callback del) { }

	public static T Begin(GameObject go, float duration, float delay = 0) { }

	private float BounceLogic(float val) { }

	protected void DoUpdate() { }

	protected void FixedUpdate() { }

	public float get_amountPerDelta() { }

	public Direction get_direction() { }

	public float get_tweenFactor() { }

	private void OnDisable() { }

	protected abstract void OnUpdate(float factor, bool isFinished) { }

	public void Play() { }

	public virtual void Play(bool forward) { }

	public void PlayForward() { }

	public void PlayReverse() { }

	public void RemoveOnFinished(EventDelegate del) { }

	private void Reset() { }

	public void ResetToBeginning() { }

	public void Sample(float factor, bool isFinished) { }

	public void set_tweenFactor(float value) { }

	public virtual void SetEndToCurrentValue() { }

	public void SetOnFinished(EventDelegate del) { }

	public void SetOnFinished(Callback del) { }

	public virtual void SetStartToCurrentValue() { }

	protected virtual void Start() { }

	public void Toggle() { }

	protected void Update() { }

}

