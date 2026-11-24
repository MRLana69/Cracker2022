namespace UnityEngine.UI;

public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
{
	public enum MovementType
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	public enum ScrollbarVisibility
	{
		Permanent = 0,
		AutoHide = 1,
		AutoHideAndExpandViewport = 2,
	}

	public class ScrollRectEvent
	{

		public ScrollRectEvent() { }

	}

	private RectTransform m_Content; //Field offset: 0xC
	private bool m_Horizontal; //Field offset: 0x10
	private bool m_Vertical; //Field offset: 0x11
	private MovementType m_MovementType; //Field offset: 0x14
	private float m_Elasticity; //Field offset: 0x18
	private bool m_Inertia; //Field offset: 0x1C
	private float m_DecelerationRate; //Field offset: 0x20
	private float m_ScrollSensitivity; //Field offset: 0x24
	private RectTransform m_Viewport; //Field offset: 0x28
	private Scrollbar m_HorizontalScrollbar; //Field offset: 0x2C
	private Scrollbar m_VerticalScrollbar; //Field offset: 0x30
	private ScrollbarVisibility m_HorizontalScrollbarVisibility; //Field offset: 0x34
	private ScrollbarVisibility m_VerticalScrollbarVisibility; //Field offset: 0x38
	private float m_HorizontalScrollbarSpacing; //Field offset: 0x3C
	private float m_VerticalScrollbarSpacing; //Field offset: 0x40
	private ScrollRectEvent m_OnValueChanged; //Field offset: 0x44
	private Vector2 m_PointerStartLocalCursor; //Field offset: 0x48
	protected Vector2 m_ContentStartPosition; //Field offset: 0x50
	private RectTransform m_ViewRect; //Field offset: 0x58
	protected Bounds m_ContentBounds; //Field offset: 0x5C
	private Bounds m_ViewBounds; //Field offset: 0x74
	private Vector2 m_Velocity; //Field offset: 0x8C
	private bool m_Dragging; //Field offset: 0x94
	private bool m_Scrolling; //Field offset: 0x95
	private Vector2 m_PrevPosition; //Field offset: 0x98
	private Bounds m_PrevContentBounds; //Field offset: 0xA0
	private Bounds m_PrevViewBounds; //Field offset: 0xB8
	private bool m_HasRebuiltLayout; //Field offset: 0xD0
	private bool m_HSliderExpand; //Field offset: 0xD1
	private bool m_VSliderExpand; //Field offset: 0xD2
	private float m_HSliderHeight; //Field offset: 0xD4
	private float m_VSliderWidth; //Field offset: 0xD8
	private RectTransform m_Rect; //Field offset: 0xDC
	private RectTransform m_HorizontalScrollbarRect; //Field offset: 0xE0
	private RectTransform m_VerticalScrollbarRect; //Field offset: 0xE4
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0xE8
	private readonly Vector3[] m_Corners; //Field offset: 0xEC

	public RectTransform content
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float decelerationRate
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float elasticity
	{
		 get { } //Length: 35
		 set { } //Length: 136
	}

	public virtual float flexibleHeight
	{
		 get { } //Length: 6
	}

	public virtual float flexibleWidth
	{
		 get { } //Length: 6
	}

	public bool horizontal
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public float horizontalNormalizedPosition
	{
		 get { } //Length: 9
		 set { } //Length: 19
	}

	public Scrollbar horizontalScrollbar
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public float horizontalScrollbarSpacing
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public ScrollbarVisibility horizontalScrollbarVisibility
	{
		 get { } //Length: 6
		 set { } //Length: 319
	}

	private bool hScrollingNeeded
	{
		 get { } //Length: 98
	}

	public bool inertia
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public virtual int layoutPriority
	{
		 get { } //Length: 80
	}

	public virtual float minHeight
	{
		 get { } //Length: 6
	}

	public virtual float minWidth
	{
		 get { } //Length: 343
	}

	public MovementType movementType
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Vector2 normalizedPosition
	{
		 get { } //Length: 588
		 set { } //Length: 42
	}

	public ScrollRectEvent onValueChanged
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public virtual float preferredHeight
	{
		 get { } //Length: 6
	}

	public virtual float preferredWidth
	{
		 get { } //Length: 6
	}

	private RectTransform rectTransform
	{
		 get { } //Length: 187
	}

	public float scrollSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Vector2 velocity
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public bool vertical
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float verticalNormalizedPosition
	{
		 get { } //Length: 343
		 set { } //Length: 13
	}

	public Scrollbar verticalScrollbar
	{
		 get { } //Length: 6
		 set { } //Length: 319
	}

	public float verticalScrollbarSpacing
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public ScrollbarVisibility verticalScrollbarVisibility
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public RectTransform viewport
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	protected RectTransform viewRect
	{
		 get { } //Length: 6
	}

	private bool vScrollingNeeded
	{
		 get { } //Length: 80
	}

	protected ScrollRect() { }

	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	private Vector2 CalculateOffset(Vector2 delta) { }

	private void EnsureLayoutHasRebuilt() { }

	public RectTransform get_content() { }

	public float get_decelerationRate() { }

	public float get_elasticity() { }

	public virtual float get_flexibleHeight() { }

	public virtual float get_flexibleWidth() { }

	public bool get_horizontal() { }

	public float get_horizontalNormalizedPosition() { }

	public Scrollbar get_horizontalScrollbar() { }

	public float get_horizontalScrollbarSpacing() { }

	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	private bool get_hScrollingNeeded() { }

	public bool get_inertia() { }

	public virtual int get_layoutPriority() { }

	public virtual float get_minHeight() { }

	public virtual float get_minWidth() { }

	public MovementType get_movementType() { }

	public Vector2 get_normalizedPosition() { }

	public ScrollRectEvent get_onValueChanged() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_preferredWidth() { }

	private RectTransform get_rectTransform() { }

	public float get_scrollSensitivity() { }

	public Vector2 get_velocity() { }

	public bool get_vertical() { }

	public float get_verticalNormalizedPosition() { }

	public Scrollbar get_verticalScrollbar() { }

	public float get_verticalScrollbarSpacing() { }

	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	public RectTransform get_viewport() { }

	protected RectTransform get_viewRect() { }

	private bool get_vScrollingNeeded() { }

	private Bounds GetBounds() { }

	public virtual void GraphicUpdateComplete() { }

	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) { }

	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	public override bool IsActive() { }

	protected virtual void LateUpdate() { }

	public virtual void LayoutComplete() { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	protected override void OnDisable() { }

	public virtual void OnDrag(PointerEventData eventData) { }

	protected override void OnEnable() { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	protected override void OnRectTransformDimensionsChange() { }

	public virtual void OnScroll(PointerEventData data) { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	private static float RubberDelta(float overStretching, float viewSize) { }

	public void set_content(RectTransform value) { }

	public void set_decelerationRate(float value) { }

	public void set_elasticity(float value) { }

	public void set_horizontal(bool value) { }

	public void set_horizontalNormalizedPosition(float value) { }

	public void set_horizontalScrollbar(Scrollbar value) { }

	public void set_horizontalScrollbarSpacing(float value) { }

	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	public void set_inertia(bool value) { }

	public void set_movementType(MovementType value) { }

	public void set_normalizedPosition(Vector2 value) { }

	public void set_onValueChanged(ScrollRectEvent value) { }

	public void set_scrollSensitivity(float value) { }

	public void set_velocity(Vector2 value) { }

	public void set_vertical(bool value) { }

	public void set_verticalNormalizedPosition(float value) { }

	public void set_verticalScrollbar(Scrollbar value) { }

	public void set_verticalScrollbarSpacing(float value) { }

	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	public void set_viewport(RectTransform value) { }

	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	protected void SetDirty() { }

	protected void SetDirtyCaching() { }

	private void SetHorizontalNormalizedPosition(float value) { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

	protected virtual void SetNormalizedPosition(float value, int axis) { }

	private void SetVerticalNormalizedPosition(float value) { }

	public virtual void StopMovement() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	protected void UpdateBounds() { }

	private void UpdateCachedData() { }

	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	protected void UpdatePrevData() { }

	private void UpdateScrollbarLayout() { }

	private void UpdateScrollbars(Vector2 offset) { }

	private void UpdateScrollbarVisibility() { }

}

