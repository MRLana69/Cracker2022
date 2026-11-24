//Type is in global namespace

public class UIProgressBar : UIWidgetContainer
{
	public enum FillDirection
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	public delegate OnDragFinished
	{

		public OnDragFinished(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public static UIProgressBar current; //Field offset: 0x0
	public OnDragFinished onDragFinished; //Field offset: 0xC
	public Transform thumb; //Field offset: 0x10
	protected UIWidget mBG; //Field offset: 0x14
	protected UIWidget mFG; //Field offset: 0x18
	protected float mValue; //Field offset: 0x1C
	protected FillDirection mFill; //Field offset: 0x20
	protected bool mStarted; //Field offset: 0x24
	protected Transform mTrans; //Field offset: 0x28
	protected bool mIsDirty; //Field offset: 0x2C
	protected Camera mCam; //Field offset: 0x30
	protected float mOffset; //Field offset: 0x34
	public int numberOfSteps; //Field offset: 0x38
	public List<EventDelegate> onChange; //Field offset: 0x3C

	public float alpha
	{
		 get { } //Length: 123
		 set { } //Length: 13
	}

	public UIWidget backgroundWidget
	{
		 get { } //Length: 6
		 set { } //Length: 104
	}

	public Camera cachedCamera
	{
		 get { } //Length: 108
	}

	public Transform cachedTransform
	{
		 get { } //Length: 66
	}

	public FillDirection fillDirection
	{
		 get { } //Length: 6
		 set { } //Length: 104
	}

	public UIWidget foregroundWidget
	{
		 get { } //Length: 160
		 set { } //Length: 313
	}

	protected bool isHorizontal
	{
		 get { } //Length: 6
	}

	protected bool isInverted
	{
		 get { } //Length: 20
	}

	public float value
	{
		 get { } //Length: 402
		 set { } //Length: 156
	}

	public UIProgressBar() { }

	public virtual void ForceUpdate() { }

	public float get_alpha() { }

	public UIWidget get_backgroundWidget() { }

	public Camera get_cachedCamera() { }

	public Transform get_cachedTransform() { }

	public FillDirection get_fillDirection() { }

	public UIWidget get_foregroundWidget() { }

	protected bool get_isHorizontal() { }

	protected bool get_isInverted() { }

	public float get_value() { }

	protected virtual float LocalToValue(Vector2 localPos) { }

	public virtual void OnPan(Vector2 delta) { }

	protected virtual void OnStart() { }

	protected void OnValidate() { }

	protected float ScreenToValue(Vector2 screenPos) { }

	public void Set(float val, bool notify = true) { }

	public void set_alpha(float value) { }

	public void set_backgroundWidget(UIWidget value) { }

	public void set_fillDirection(FillDirection value) { }

	public void set_foregroundWidget(UIWidget value) { }

	public void set_value(float value) { }

	protected void SetThumbPosition(Vector3 worldPos) { }

	public void Start() { }

	protected void Update() { }

	protected virtual void Upgrade() { }

}

