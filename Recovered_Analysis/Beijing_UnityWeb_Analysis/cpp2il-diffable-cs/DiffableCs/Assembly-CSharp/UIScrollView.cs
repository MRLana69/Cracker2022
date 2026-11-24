//Type is in global namespace

public class UIScrollView : MonoBehaviour
{
	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2,
	}

	public enum Movement
	{
		Horizontal = 0,
		Vertical = 1,
		Unrestricted = 2,
		Custom = 3,
	}

	public delegate OnDragNotification
	{

		public OnDragNotification(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public enum ShowCondition
	{
		Always = 0,
		OnlyIfNeeded = 1,
		WhenDragging = 2,
	}

	public static BetterList<UIScrollView> list; //Field offset: 0x0
	public Movement movement; //Field offset: 0xC
	public DragEffect dragEffect; //Field offset: 0x10
	public bool restrictWithinPanel; //Field offset: 0x14
	public bool constrainOnDrag; //Field offset: 0x15
	public bool disableDragIfFits; //Field offset: 0x16
	public bool smoothDragStart; //Field offset: 0x17
	public bool iOSDragEmulation; //Field offset: 0x18
	public float scrollWheelFactor; //Field offset: 0x1C
	public float momentumAmount; //Field offset: 0x20
	public float dampenStrength; //Field offset: 0x24
	public UIProgressBar horizontalScrollBar; //Field offset: 0x28
	public UIProgressBar verticalScrollBar; //Field offset: 0x2C
	public ShowCondition showScrollBars; //Field offset: 0x30
	public Vector2 customMovement; //Field offset: 0x34
	public Pivot contentPivot; //Field offset: 0x3C
	public OnDragNotification onDragStarted; //Field offset: 0x40
	public OnDragNotification onDragFinished; //Field offset: 0x44
	public OnDragNotification onMomentumMove; //Field offset: 0x48
	public OnDragNotification onStoppedMoving; //Field offset: 0x4C
	private Vector3 scale; //Field offset: 0x50
	private Vector2 relativePositionOnReset; //Field offset: 0x5C
	protected Transform mTrans; //Field offset: 0x64
	protected UIPanel mPanel; //Field offset: 0x68
	protected Plane mPlane; //Field offset: 0x6C
	protected Vector3 mLastPos; //Field offset: 0x7C
	protected bool mPressed; //Field offset: 0x88
	protected Vector3 mMomentum; //Field offset: 0x8C
	protected float mScroll; //Field offset: 0x98
	protected Bounds mBounds; //Field offset: 0x9C
	protected bool mCalculatedBounds; //Field offset: 0xB4
	protected bool mShouldMove; //Field offset: 0xB5
	protected bool mIgnoreCallbacks; //Field offset: 0xB6
	protected int mDragID; //Field offset: 0xB8
	protected Vector2 mDragStartOffset; //Field offset: 0xBC
	protected bool mDragStarted; //Field offset: 0xC4
	private bool mStarted; //Field offset: 0xC5
	public UICenterOnChild centerOnChild; //Field offset: 0xC8

	public virtual Bounds bounds
	{
		 get { } //Length: 569
	}

	public bool canMoveHorizontally
	{
		 get { } //Length: 22
	}

	public bool canMoveVertically
	{
		 get { } //Length: 54
	}

	public Vector3 currentMomentum
	{
		 get { } //Length: 178
		 set { } //Length: 27
	}

	public bool isDragging
	{
		 get { } //Length: 6
	}

	public UIPanel panel
	{
		 get { } //Length: 89
	}

	protected virtual bool shouldMove
	{
		 get { } //Length: 246
	}

	public virtual bool shouldMoveHorizontally
	{
		 get { } //Length: 57
	}

	public virtual bool shouldMoveVertically
	{
		 get { } //Length: 246
	}

	private static UIScrollView() { }

	public UIScrollView() { }

	private void Awake() { }

	private void CheckScrollbars() { }

	public void DisableSpring() { }

	public void Drag() { }

	public virtual Bounds get_bounds() { }

	public bool get_canMoveHorizontally() { }

	public bool get_canMoveVertically() { }

	public Vector3 get_currentMomentum() { }

	public bool get_isDragging() { }

	public UIPanel get_panel() { }

	protected virtual bool get_shouldMove() { }

	public virtual bool get_shouldMoveHorizontally() { }

	public virtual bool get_shouldMoveVertically() { }

	public void InvalidateBounds() { }

	private void LateUpdate() { }

	public void MoveAbsolute(Vector3 absolute) { }

	public virtual void MoveRelative(Vector3 relative) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void OnPan(Vector2 delta) { }

	public void OnScrollBar() { }

	public void Press(bool pressed) { }

	public void ResetPosition() { }

	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical) { }

	public bool RestrictWithinBounds(bool instant) { }

	public void Scroll(float delta) { }

	public void set_currentMomentum(Vector3 value) { }

	public virtual void SetDragAmount(float x, float y, bool updateScrollbars) { }

	private void Start() { }

	public void UpdatePosition() { }

	public void UpdateScrollbars() { }

	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted) { }

	public virtual void UpdateScrollbars(bool recalculateBounds) { }

}

